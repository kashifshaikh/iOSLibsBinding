using MonoTouch.ObjCRuntime;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOSLibsBinding.PureLayout
{
	[Native]
	public enum ALEdge : int
	{
		Left = NSLayoutAttribute.Left,
		Right = NSLayoutAttribute.Right,
		Top = NSLayoutAttribute.Top,
		Bottom = NSLayoutAttribute.Bottom,
		Leading = NSLayoutAttribute.Leading,
		Trailing = NSLayoutAttribute.Trailing
	}

	[Native]
	public enum ALDimension : int
	{
		Width = NSLayoutAttribute.Width,
		Height = NSLayoutAttribute.Height
	}

	[Native]
	public enum ALAxis : int
	{
		Vertical = NSLayoutAttribute.CenterX,
		Horizontal = NSLayoutAttribute.CenterY,
		Baseline = NSLayoutAttribute.Baseline,
		LastBaseline = Baseline,
		FirstBaseline = NSLayoutAttribute.FirstBaseline
	}

	// KASHIF: ALMargin and ALMargin Axis only available on iOS8+
	[Native]
	public enum ALMargin : int
	{
		Left = NSLayoutAttribute.LeftMargin,
		Right = NSLayoutAttribute.RightMargin,
		Top = NSLayoutAttribute.TopMargin,
		Bottom = NSLayoutAttribute.BottomMargin,
		Leading = NSLayoutAttribute.LeadingMargin,
		Trailing = NSLayoutAttribute.TrailingMargin
	}

	[Native]
	public enum ALMarginAxis : int
	{
		Vertical = NSLayoutAttribute.CenterXWithinMargins,
		Horizontal = NSLayoutAttribute.CenterYWithinMargins
	}

	[Native]
	public enum ALAttribute : int
	{
		Left = ALEdge.Left,
		Right = ALEdge.Right,
		Top = ALEdge.Top,
		Bottom = ALEdge.Bottom,
		Leading = ALEdge.Leading,
		Trailing = ALEdge.Trailing,
		Width = ALDimension.Width,
		Height = ALDimension.Height,
		Vertical = ALAxis.Vertical,
		Horizontal = ALAxis.Horizontal,
		Baseline = ALAxis.Baseline,
		LastBaseline = ALAxis.LastBaseline,
		FirstBaseline = ALAxis.FirstBaseline,
		MarginLeft = ALMargin.Left,
		MarginRight = ALMargin.Right,
		MarginTop = ALMargin.Top,
		MarginBottom = ALMargin.Bottom,
		MarginLeading = ALMargin.Leading,
		MarginTrailing = ALMargin.Trailing,
		MarginAxisVertical = ALMarginAxis.Vertical,
		MarginAxisHorizontal = ALMarginAxis.Horizontal
	}
}
