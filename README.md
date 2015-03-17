# iOSLibsBinding
A project designed to make it easy to download cocoapods and generate universal libs and bindings for Xamarin
bindings.

HOW TO

1. First add your pods to iOSLibs/Podfile and run pod install or pod update. This will fetch the cocoapods and generate the Pods directory.

2. Under iOSLibsBinding, run Scripts/UniversalLibs.sh. This will generate the fat libraries for each pod under iOSLibs/build/universal/{Debug|Release}

3. Then run Scripts/SharpieBind.sh <PODNAME>. This will generate the ApiDefinition.cs and StructAndEnums.cs for the pod and store results under iOSLibsBinding/<PODNAME>.

4. Open iOSLibsBinding solution file and import <PODNAME> directory with ApiDefinition.cs and StructAndEnums.cs into the iOSLibsBinding project. Also import the generate fat library from iOSLib/build/universal/Release/<PODNAME>.a

5. Verify ApiDefinition per sharpie output.

6. Build library and import iOSLibsBinding project into your other solutions and Enjoy!

