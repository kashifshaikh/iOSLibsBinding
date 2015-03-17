using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOSLibsBinding.DejalActivityView
{
	// @interface DejalActivityView : UIView
	[BaseType (typeof(UIView))]
	interface DejalActivityView
	{
		// @property (readonly, nonatomic, strong) UIView * borderView;
		[Export ("borderView", ArgumentSemantic.Strong)]
		UIView BorderView { get; }

		// @property (readonly, nonatomic, strong) UIActivityIndicatorView * activityIndicator;
		[Export ("activityIndicator", ArgumentSemantic.Strong)]
		UIActivityIndicatorView ActivityIndicator { get; }

		// @property (readonly, nonatomic, strong) UILabel * activityLabel;
		[Export ("activityLabel", ArgumentSemantic.Strong)]
		UILabel ActivityLabel { get; }

		// @property (nonatomic) NSUInteger labelWidth;
		[Export ("labelWidth", ArgumentSemantic.Assign)]
		uint LabelWidth { get; set; }

		// @property (nonatomic) BOOL showNetworkActivityIndicator;
		[Export ("showNetworkActivityIndicator")]
		bool ShowNetworkActivityIndicator { get; set; }

		// +(DejalActivityView *)currentActivityView;
		[Static]
		[Export ("currentActivityView")]
		//[Verify (MethodToProperty)]
		DejalActivityView CurrentActivityView { get; }

		// +(DejalActivityView *)activityViewForView:(UIView *)addToView;
		[Static]
		[Export ("activityViewForView:")]
		DejalActivityView ActivityViewForView (UIView addToView);

		// +(DejalActivityView *)activityViewForView:(UIView *)addToView withLabel:(NSString *)labelText;
		[Static]
		[Export ("activityViewForView:withLabel:")]
		DejalActivityView ActivityViewForView (UIView addToView, string labelText);

		// +(DejalActivityView *)activityViewForView:(UIView *)addToView withLabel:(NSString *)labelText width:(NSUInteger)aLabelWidth;
		[Static]
		[Export ("activityViewForView:withLabel:width:")]
		DejalActivityView ActivityViewForView (UIView addToView, string labelText, uint aLabelWidth);

		// -(DejalActivityView *)initForView:(UIView *)addToView withLabel:(NSString *)labelText width:(NSUInteger)aLabelWidth;
		[Export ("initForView:withLabel:width:")]
		IntPtr Constructor (UIView addToView, string labelText, uint aLabelWidth);

		// +(void)removeView;
		[Static]
		[Export ("removeView")]
		void RemoveView ();
	}

	// @interface  DejalActivityView ()

	// A Categoy gets translated to Extension methods - so we can't define properties on extension methods.
	[Category]
	[BaseType (typeof(DejalActivityView))]
	interface DejalActivityViewCategoryExtension
	{
		// -(UIView *)viewForView:(UIView *)view;
		[Export ("viewForView:")]
		UIView ViewForView (UIView view);

		// -(CGRect)enclosingFrame;
		[Export ("enclosingFrame")]
		//[Verify (MethodToProperty)]
		//RectangleF EnclosingFrame { get; }
		RectangleF EnclosingFrame();

		// -(void)setupBackground;
		[Export ("setupBackground")]
		void SetupBackground ();

		// -(UIView *)makeBorderView;
		[Export ("makeBorderView")]
		//[Verify (MethodToProperty)]
		//UIView MakeBorderView { get; } 
		UIView MakeBorderView();

		// -(UIActivityIndicatorView *)makeActivityIndicator;
		[Export ("makeActivityIndicator")]
		//[Verify (MethodToProperty)]
		//UIActivityIndicatorView MakeActivityIndicator { get; }
		UIActivityIndicatorView MakeActivityIndicator();

		// -(UILabel *)makeActivityLabelWithText:(NSString *)labelText;
		[Export ("makeActivityLabelWithText:")]
		UILabel MakeActivityLabelWithText (string labelText);

		// -(void)animateShow;
		[Export ("animateShow")]
		void AnimateShow ();

		// -(void)animateRemove;
		[Export ("animateRemove")]
		void AnimateRemove ();
	}

	// @interface DejalWhiteActivityView : DejalActivityView
	[BaseType (typeof(DejalActivityView))]
	interface DejalWhiteActivityView
	{
	}

	// @interface DejalBezelActivityView : DejalActivityView
	[BaseType (typeof(DejalActivityView))]
	interface DejalBezelActivityView
	{
		// KASHIF - Constructors are not inherited from 
		[Export ("initForView:withLabel:width:")]
		IntPtr Constructor (UIView addToView, string labelText, uint aLabelWidth);

		// +(void)removeViewAnimated:(BOOL)animated;
		[Static]
		[Export ("removeViewAnimated:")]
		void RemoveViewAnimated (bool animated);
	}

	// @interface DejalKeyboardActivityView : DejalBezelActivityView
	[BaseType (typeof(DejalBezelActivityView))]
	interface DejalKeyboardActivityView
	{
		// +(DejalKeyboardActivityView *)activityView;
		[Static]
		[Export ("activityView")]
		//[Verify (MethodToProperty)]
		DejalKeyboardActivityView ActivityView { get; }

		// +(DejalKeyboardActivityView *)activityViewWithLabel:(NSString *)labelText;
		[Static]
		[Export ("activityViewWithLabel:")]
		DejalKeyboardActivityView ActivityViewWithLabel (string labelText);
	}

	// @interface KeyboardView (UIApplication)
	[Category]
	[BaseType (typeof(UIApplication))]
	interface UIApplication_KeyboardView
	{
		// -(UIView *)keyboardView;
		[Export ("keyboardView")]
		//[Verify (MethodToProperty)]
		UIView KeyboardView();
	}


}
