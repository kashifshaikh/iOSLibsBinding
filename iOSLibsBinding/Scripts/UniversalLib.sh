#!/bin/sh

CONFIGS="Debug Release"

DEVICE_BUILD="iphoneos"
SIM_BUILD="iphonesimulator"

if [ ! -f "iOSLibsBinding.csproj" ];then
	echo "You must run this script from iOS Binding Project directory";
	exit 1
fi

IOSLIB_DIR=${PWD}/../iOSLibs
POD_DIR=${IOSLIB_DIR}/Pods

if [ ! -d $POD_DIR ]; then
	echo "No Pods directory under ${IOSLIB_DIR}: You must run pod update"
	exit 1
fi

BUILD_DIR=${IOSLIB_DIR}/build

mkdir -p ${BUILD_DIR}

UNIVERSAL_DIR=${BUILD_DIR}/universal
# make sure the output directory exists

CLEAN=""
if [ "$1" = "clean" ]; then
	CLEAN=$1
fi

mkdir -p "${UNIVERSAL_DIR}"

cd $POD_DIR

for config in  ${CONFIGS}
do
	xcodebuild -target Pods-iOSLibs ONLY_ACTIVE_ARCH=NO -configuration ${config} -sdk $DEVICE_BUILD BUILD_DIR="${BUILD_DIR}" BUILD_ROOT="${BUILD_ROOT}" ${CLEAN}

    xcodebuild -target  Pods-iOSLibs -configuration ${config} -sdk $SIM_BUILD -arch i386 BUILD_DIR="${BUILD_DIR}" BUILD_ROOT="${BUILD_ROOT}" ${CLEAN}

	if [ "$CLEAN" != "" ]; then
		#echo Removing ${UNIVERSAL_DIR}/$config...
		rm -rf ${UNIVERSAL_DIR}/${config}/
		continue
	fi
	
    BUILD_DIR_DEVICE=${BUILD_DIR}/${config}-${DEVICE_BUILD}
    BUILD_DIR_SIM=${BUILD_DIR}/${config}-${SIM_BUILD}

	mkdir -p ${UNIVERSAL_DIR}/${config}
	for lib in $BUILD_DIR_DEVICE/*
	do
		inlib=`basename $lib`
		outlib="${inlib//libPods-}"
		outlib="${outlib//iOSLibs-}"
		echo Creating \"$config\" fat library from \"$inlib\" to \"${config}/$outlib\"
		lipo -create -output "${UNIVERSAL_DIR}/${config}/${outlib}" "${BUILD_DIR_DEVICE}/${inlib}" "${BUILD_DIR_SIM}/${inlib}"
	done
	
#  for lib in $LIBS
#     do
#         lipo -create -output "${UNIVERSAL_DIR}/${config}/lib${lib}.a" "${BUILD_DIR_DEVICE}/libPods-iOSLibs-${lib}.a" "${BUILD_DIR_SIM}/libPods-iOSLibs-${lib}.a"
#     done
# 
#     lipo -create -output "${UNIVERSAL_DIR}/${config}/libPods-iOSLibs.a" "${BUILD_DIR_DEVICE}/libPods-iOSLibs.a" "${BUILD_DIR_SIM}/libPods-iOSLibs.a"
done

# Step 1. Build Device and Simulator versions
#xcodebuild -target ImageFilters ONLY_ACTIVE_ARCH=NO -configuration ${CONFIGURATION} -sdk iphoneos  BUILD_DIR="${BUILD_DIR}" BUILD_ROOT="${BUILD_ROOT}"
#xcodebuild -target ImageFilters -configuration ${CONFIGURATION} -sdk iphonesimulator -arch i386 BUILD_DIR="${BUILD_DIR}" BUILD_ROOT="${BUILD_ROOT}"



# Step 2. Create universal binary file using lipo
#lipo -create -output "${UNIVERSAL_OUTPUTFOLDER}/lib${PROJECT_NAME}.a" "${BUILD_DIR}/${CONFIGURATION}-iphoneos/lib${PROJECT_NAME}.a" "${BUILD_DIR}/${CONFIGURATION}-iphonesimulator/lib${PROJECT_NAME}.a"

# Last touch. copy the header files. Just for convenience
#cp -R "${BUILD_DIR}/${CONFIGURATION}-iphoneos/include" "${UNIVERSAL_OUTPUTFOLDER}/"