using System;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;

namespace iOSLibsBinding.ORStackView
{
	
	// @interface ORStackView : UIView
	[BaseType (typeof(UIView))]
	interface ORStackView
	{
		// -(void)addSubview:(UIView *)view withTopMargin:(NSString *)margin;
		[Export ("addSubview:withTopMargin:")]
		void AddSubview (UIView view, string margin);

		// -(void)addSubview:(UIView *)view withTopMargin:(NSString *)topMargin sideMargin:(NSString *)sideMargin;
		[Export ("addSubview:withTopMargin:sideMargin:")]
		void AddSubview (UIView view, string topMargin, string sideMargin);

		// -(void)addViewController:(UIViewController *)viewController toParent:(UIViewController *)parentViewController withTopMargin:(NSString *)margin;
		[Export ("addViewController:toParent:withTopMargin:")]
		void AddViewController (UIViewController viewController, UIViewController parentViewController, string margin);

		// -(void)addViewController:(UIViewController *)viewController toParent:(UIViewController *)parentViewController withTopMargin:(NSString *)margin sideMargin:(NSString *)sideMargin;
		[Export ("addViewController:toParent:withTopMargin:sideMargin:")]
		void AddViewController (UIViewController viewController, UIViewController parentViewController, string margin, string sideMargin);

		// -(void)insertSubview:(UIView *)view atIndex:(NSInteger)index withTopMargin:(NSString *)margin;
		[Export ("insertSubview:atIndex:withTopMargin:")]
		void InsertSubview (UIView view, int index, string margin);

		// -(void)insertSubview:(UIView *)view atIndex:(NSInteger)index withTopMargin:(NSString *)topMargin sideMargin:(NSString *)sideMargin;
		[Export ("insertSubview:atIndex:withTopMargin:sideMargin:")]
		void InsertSubview (UIView view, int index, string topMargin, string sideMargin);

		// -(void)insertSubview:(UIView *)view belowSubview:(UIView *)siblingSubview withTopMargin:(NSString *)margin;
		[Export ("insertSubview:belowSubview:withTopMargin:")]
		void InsertSubviewBelowSubview (UIView view, UIView belowSiblingSubview, string margin);

		// -(void)insertSubview:(UIView *)view aboveSubview:(UIView *)siblingSubview withTopMargin:(NSString *)margin;
		[Export ("insertSubview:aboveSubview:withTopMargin:")]
		void InsertSubviewAboveSubview (UIView view, UIView aboveSiblingSubview, string margin);

		// -(void)removeSubview:(UIView *)subview;
		[Export ("removeSubview:")]
		void RemoveSubview (UIView subview);

		// -(void)removeAllSubviews;
		[Export ("removeAllSubviews")]
		void RemoveAllSubviews ();

		// -(void)performBatchUpdates:(void (^)(void))updates;
		[Export ("performBatchUpdates:")]
		void PerformBatchUpdates (Action updates);

		// -(NSLayoutConstraint *)topConstraintForView:(UIView *)view;
		[Export ("topConstraintForView:")]
		NSLayoutConstraint TopConstraintForView (UIView view);

		// -(UIView *)lastView;
		[Export ("lastView")]
		//[Verify (MethodToProperty)]
		UIView LastView { get; }

		// @property (assign, nonatomic) CGFloat bottomMarginHeight;
		[Export ("bottomMarginHeight", ArgumentSemantic.Assign)]
		float BottomMarginHeight { get; set; }

		// @property (nonatomic, strong) id<UILayoutSupport> topLayoutGuide;
		[Export ("topLayoutGuide", ArgumentSemantic.Strong)]
		UILayoutSupport TopLayoutGuide { get; set; }

		// -(void)addSubview:(UIView *)view __attribute__((unavailable("addSubview is not supported on ORStackView.")));
		[Export ("addSubview:")]
		void AddSubview (UIView view);

		// -(void)insertSubview:(UIView *)view atIndex:(NSInteger)index __attribute__((unavailable("insertSubview is not supported on ORStackView.")));
		[Export ("insertSubview:atIndex:")]
		void InsertSubview (UIView view, int index);

		// -(void)insertSubview:(UIView *)view aboveSubview:(UIView *)siblingSubview __attribute__((unavailable("insertSubview is not supported on ORStackView.")));
		[Export ("insertSubview:aboveSubview:")]
		void InsertSubviewAboveSubview (UIView view, UIView aboveSiblingSubview);

		// -(void)insertSubview:(UIView *)view belowSubview:(UIView *)siblingSubview __attribute__((unavailable("insertSubview is not supported on ORStackView.")));
		[Export ("insertSubview:belowSubview:")]
		void InsertSubviewBelowSubview (UIView view, UIView belowSiblingSubview);
	}

	// @interface ORSplitStackView : UIView
	[BaseType (typeof(UIView))]
	interface ORSplitStackView
	{
		// -(instancetype)initWithLeftPredicate:(NSString *)left rightPredicate:(NSString *)right;
		[Export ("initWithLeftPredicate:rightPredicate:")]
		IntPtr Constructor (string left, string right);

		// @property (readonly, nonatomic, weak) ORStackView * leftStack;
		[Export ("leftStack", ArgumentSemantic.Weak)]
		ORStackView LeftStack { get; }

		// @property (readonly, nonatomic, weak) ORStackView * rightStack;
		[Export ("rightStack", ArgumentSemantic.Weak)]
		ORStackView RightStack { get; }
	}

	// @interface ORStackScrollView : UIScrollView
	[BaseType (typeof(UIScrollView))]
	interface ORStackScrollView
	{
		// @property (readonly, nonatomic, strong) ORStackView * stackView;
		[Export ("stackView", ArgumentSemantic.Strong)]
		ORStackView StackView { get; }

		// -(instancetype)initWithStackViewClass:(Class)klass;
		[Export ("initWithStackViewClass:")]
		IntPtr Constructor (Class klass);
	}

	// @interface ORTagBasedAutoStackView : ORStackView
	[BaseType (typeof(ORStackView))]
	interface ORTagBasedAutoStackView
	{
		// -(void)insertSubview:(UIView *)view atIndex:(NSInteger)index withTopMargin:(NSString *)margin __attribute__((unavailable("Inserting subviews is not supported on ORTagBasedAutoStackView.")));
		[Export ("insertSubview:atIndex:withTopMargin:")]
		void InsertSubview (UIView view, int index, string margin);

		// -(void)insertSubview:(UIView *)view atIndex:(NSInteger)index withTopMargin:(NSString *)topMargin sideMargin:(NSString *)sideMargin __attribute__((unavailable("Inserting subviews is not supported on ORTagBasedAutoStackView.")));
		[Export ("insertSubview:atIndex:withTopMargin:sideMargin:")]
		void InsertSubview (UIView view, int index, string topMargin, string sideMargin);

		// -(void)insertSubview:(UIView *)view belowSubview:(UIView *)siblingSubview withTopMargin:(NSString *)margin __attribute__((unavailable("Inserting subviews is not supported on ORTagBasedAutoStackView.")));
		[Export ("insertSubview:belowSubview:withTopMargin:")]
		void InsertSubview (UIView view, UIView siblingSubview, string margin);

		// -(void)insertSubview:(UIView *)view aboveSubview:(UIView *)siblingSubview withTopMargin:(NSString *)margin __attribute__((unavailable("Inserting subviews is not supported on ORTagBasedAutoStackView.")));
		[Export ("insertSubview:aboveSubview:withTopMargin:")]
		void InsertSubviewAboveSubview (UIView view, UIView aboveSiblingSubview, string margin);
	}
}
