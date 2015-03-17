using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOSLibsBinding.FLKAutoLayout
{
	
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const FLKNoConstraint;
		[Field ("FLKNoConstraint")]
		NSString FLKNoConstraint { get; }
	}

	// @interface FLKAutoLayout (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_FLKAutoLayout
	{
		// -(NSArray *)alignAttribute:(NSLayoutAttribute)attribute toAttribute:(NSLayoutAttribute)toAttribute ofView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("alignAttribute:toAttribute:ofView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignAttribute (NSLayoutAttribute attribute, NSLayoutAttribute toAttribute, UIView view, string predicate);

		// -(NSArray *)alignToView:(UIView *)view;
		[Export ("alignToView:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignToView (UIView view);

		// -(NSArray *)alignTop:(NSString *)top leading:(NSString *)leading bottom:(NSString *)bottom trailing:(NSString *)trailing toView:(UIView *)view;
		[Export ("alignTop:leading:bottom:trailing:toView:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignEdges (string top, string leading, string bottom, string trailing, UIView view);

		// -(NSArray *)alignTop:(NSString *)top leading:(NSString *)leading toView:(UIView *)view;
		[Export ("alignTop:leading:toView:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignTopAndLeading (string top, string leading, UIView view);

		// -(NSArray *)alignBottom:(NSString *)bottom trailing:(NSString *)trailing toView:(UIView *)view;
		[Export ("alignBottom:trailing:toView:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignBottom (string bottom, string trailing, UIView view);

		// -(NSArray *)alignTop:(NSString *)top bottom:(NSString *)bottom toView:(UIView *)view;
		[Export ("alignTop:bottom:toView:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignTopAndBottom (string top, string bottom, UIView view);

		// -(NSArray *)alignLeading:(NSString *)leading trailing:(NSString *)trailing toView:(UIView *)view;
		[Export ("alignLeading:trailing:toView:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignLeading (string leading, string trailing, UIView view);

		// -(NSArray *)alignLeadingEdgeWithView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("alignLeadingEdgeWithView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignLeadingEdgeWithView (UIView view, string predicate);

		// -(NSArray *)alignTrailingEdgeWithView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("alignTrailingEdgeWithView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignTrailingEdgeWithView (UIView view, string predicate);

		// -(NSArray *)alignTopEdgeWithView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("alignTopEdgeWithView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignTopEdgeWithView (UIView view, string predicate);

		// -(NSArray *)alignBottomEdgeWithView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("alignBottomEdgeWithView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignBottomEdgeWithView (UIView view, string predicate);

		// -(NSArray *)alignBaselineWithView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("alignBaselineWithView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignBaselineWithView (UIView view, string predicate);

		// -(NSArray *)alignCenterXWithView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("alignCenterXWithView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignCenterXWithView (UIView view, string predicate);

		// -(NSArray *)alignCenterYWithView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("alignCenterYWithView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignCenterYWithView (UIView view, string predicate);

		// -(NSArray *)alignCenterWithView:(UIView *)view;
		[Export ("alignCenterWithView:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AlignCenterWithView (UIView view);

		// -(NSArray *)constrainWidth:(NSString *)widthPredicate height:(NSString *)heightPredicate;
		[Export ("constrainWidth:height:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ConstrainWidthAndHeight (string widthPredicate, string heightPredicate);

		// -(NSArray *)constrainWidth:(NSString *)widthPredicate;
		[Export ("constrainWidth:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ConstrainWidth (string widthPredicate);

		// -(NSArray *)constrainHeight:(NSString *)heightPredicate;
		[Export ("constrainHeight:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ConstrainHeight (string heightPredicate);

		// -(NSArray *)constrainWidthToView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("constrainWidthToView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ConstrainWidthToView (UIView view, string predicate);

		// -(NSArray *)constrainHeightToView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("constrainHeightToView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ConstrainHeightToView (UIView view, string predicate);

		// -(NSArray *)constrainAspectRatio:(NSString *)predicate;
		[Export ("constrainAspectRatio:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ConstrainAspectRatio (string predicate);

		// -(NSArray *)constrainLeadingSpaceToView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("constrainLeadingSpaceToView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ConstrainLeadingSpaceToView (UIView view, string predicate);

		// -(NSArray *)constrainTrailingSpaceToView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("constrainTrailingSpaceToView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ConstrainTrailingSpaceToView (UIView view, string predicate);

		// -(NSArray *)constrainTopSpaceToView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("constrainTopSpaceToView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ConstrainTopSpaceToView (UIView view, string predicate);

		// -(NSArray *)constrainBottomSpaceToView:(UIView *)view predicate:(NSString *)predicate;
		[Export ("constrainBottomSpaceToView:predicate:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ConstrainBottomSpaceToView (UIView view, string predicate);

		// +(NSArray *)alignAttribute:(NSLayoutAttribute)attribute ofViews:(NSArray *)ofViews toViews:(NSArray *)toViews predicate:(NSString *)predicate;
		[Static]
		[Export ("alignAttribute:ofViews:toViews:predicate:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] AlignAttribute (NSLayoutAttribute attribute, NSObject[] ofViews, NSObject[] toViews, string predicate);

		// +(NSArray *)alignAttribute:(NSLayoutAttribute)attribute ofViews:(NSArray *)views toAttribute:(NSLayoutAttribute)toAttribute ofViews:(NSArray *)toViews predicate:(NSString *)predicate;
		[Static]
		[Export ("alignAttribute:ofViews:toAttribute:ofViews:predicate:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] AlignAttribute (NSLayoutAttribute attribute, NSObject[] views, NSLayoutAttribute toAttribute, NSObject[] toViews, string predicate);

		// +(NSArray *)equalWidthForViews:(NSArray *)views;
		[Static]
		[Export ("equalWidthForViews:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] EqualWidthForViews (NSObject[] views);

		// +(NSArray *)equalHeightForViews:(NSArray *)views;
		[Static]
		[Export ("equalHeightForViews:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] EqualHeightForViews (NSObject[] views);

		// +(NSArray *)alignLeadingEdgesOfViews:(NSArray *)views;
		[Static]
		[Export ("alignLeadingEdgesOfViews:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] AlignLeadingEdgesOfViews (NSObject[] views);

		// +(NSArray *)alignTrailingEdgesOfViews:(NSArray *)views;
		[Static]
		[Export ("alignTrailingEdgesOfViews:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] AlignTrailingEdgesOfViews (NSObject[] views);

		// +(NSArray *)alignTopEdgesOfViews:(NSArray *)views;
		[Static]
		[Export ("alignTopEdgesOfViews:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] AlignTopEdgesOfViews (NSObject[] views);

		// +(NSArray *)alignBottomEdgesOfViews:(NSArray *)views;
		[Static]
		[Export ("alignBottomEdgesOfViews:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] AlignBottomEdgesOfViews (NSObject[] views);

		// +(NSArray *)alignLeadingAndTrailingEdgesOfViews:(NSArray *)views;
		[Static]
		[Export ("alignLeadingAndTrailingEdgesOfViews:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] AlignLeadingAndTrailingEdgesOfViews (NSObject[] views);

		// +(NSArray *)alignTopAndBottomEdgesOfViews:(NSArray *)views;
		[Static]
		[Export ("alignTopAndBottomEdgesOfViews:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] AlignTopAndBottomEdgesOfViews (NSObject[] views);

		// +(NSArray *)spaceOutViewsHorizontally:(NSArray *)views predicate:(NSString *)predicate;
		[Static]
		[Export ("spaceOutViewsHorizontally:predicate:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] SpaceOutViewsHorizontally (NSObject[] views, string predicate);

		// +(NSArray *)spaceOutViewsVertically:(NSArray *)views predicate:(NSString *)predicate;
		[Static]
		[Export ("spaceOutViewsVertically:predicate:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] SpaceOutViewsVertically (NSObject[] views, string predicate);

		// +(NSArray *)distributeCenterXOfViews:(NSArray *)views inView:(UIView *)view;
		[Static]
		[Export ("distributeCenterXOfViews:inView:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] DistributeCenterXOfViews (NSObject[] views, UIView view);

		// +(NSArray *)distributeCenterYOfViews:(NSArray *)views inView:(UIView *)inView;
		[Static]
		[Export ("distributeCenterYOfViews:inView:")]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] DistributeCenterYOfViews (NSObject[] views, UIView inView);
	}
}
