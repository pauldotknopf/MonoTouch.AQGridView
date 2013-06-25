using System;

namespace MonoTouch.AQGridView
{
	public enum AQGridViewScrollPosition {
		AQGridViewScrollPositionNone = 0,
		AQGridViewScrollPositionTop = 1,
		AQGridViewScrollPositionMiddle = 2,
		AQGridViewScrollPositionBottom = 3
	}

	public enum AQGridViewItemAnimation {
		AQGridViewItemAnimationFade = 0,
		AQGridViewItemAnimationRight = 1,
		AQGridViewItemAnimationLeft = 2,
		AQGridViewItemAnimationTop = 3,
		AQGridViewItemAnimationBottom = 4,
		AQGridViewItemAnimationNone = 5
	}

	public enum AQGridViewLayoutDirection {
		AQGridViewLayoutDirectionVertical = 0,
		AQGridViewLayoutDirectionHorizontal = 1
	}
	
	public enum AQGridViewCellSeparatorStyle {
		AQGridViewCellSeparatorStyleNone = 0,
		AQGridViewCellSeparatorStyleEmptySpace = 1,
		AQGridViewCellSeparatorStyleSingleLine = 2
	}

	public enum AQGridViewCellSelectionStyle {
		AQGridViewCellSelectionStyleNone = 0,
		AQGridViewCellSelectionStyleBlue = 1,
		AQGridViewCellSelectionStyleGray = 2,
		AQGridViewCellSelectionStyleBlueGray = 3,
		AQGridViewCellSelectionStyleGreen = 4,
		AQGridViewCellSelectionStyleRed = 5,
		AQGridViewCellSelectionStyleGlow = 6
	}

	public enum AQGridViewCellSeparatorEdge {
		AQGridViewCellSeparatorEdgeBottom = 1,
		AQGridViewCellSeparatorEdgeRight = 2
	}
	
	public enum AQGridViewUpdateAction {
		AQGridViewUpdateActionInsert = 0,
		AQGridViewUpdateActionDelete = 1,
		AQGridViewUpdateActionMove = 2,
		AQGridViewUpdateActionReload = 3
	}
}

