using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;

namespace MonoTouch.AQGridView
{
	//@protocol AQGridViewDelegate <NSObject, UIScrollViewDelegate>
	[Model]
	[BaseType(typeof(NSObject))]
	public partial interface AQGridViewDelegate {

		//- (void) gridView: (AQGridView *) gridView willDisplayCell: (AQGridViewCell *) cell forItemAtIndex: (NSUInteger) index;
		[Export ("gridView:willDisplayCell:forItemAtIndex:")]
		void WillDisplayCell (AQGridView gridView, AQGridViewCell cell, uint index);

		//- (NSUInteger) gridView: (AQGridView *) gridView willSelectItemAtIndex: (NSUInteger) index;
		[Export ("gridView:willSelectItemAtIndex:")]
		uint WillSelectItemAtIndex (AQGridView gridView, uint index);

		//- (NSUInteger) gridView: (AQGridView *) gridView willSelectItemAtIndex: (NSUInteger) index numFingersTouch:(NSUInteger) numFingers;
		[Export ("gridView:willSelectItemAtIndex:numFingersTouch:")]
		uint WillSelectItemAtIndex (AQGridView gridView, uint index, uint numFingers);

		//- (NSUInteger) gridView: (AQGridView *) gridView willDeselectItemAtIndex: (NSUInteger) index;
		[Export ("gridView:willDeselectItemAtIndex:")]
		uint WillDeselectItemAtIndex (AQGridView gridView, uint index);

		//- (void) gridView: (AQGridView *) gridView didSelectItemAtIndex: (NSUInteger) index;
		[Export ("gridView:didSelectItemAtIndex:")]
		void DidSelectItemAtIndex (AQGridView gridView, uint index);

		//- (void) gridView: (AQGridView *) gridView didSelectItemAtIndex: (NSUInteger) index numFingersTouch:(NSUInteger)numFingers;
		[Export ("gridView:didSelectItemAtIndex:numFingersTouch:")]
		void DidSelectItemAtIndex (AQGridView gridView, uint index, uint numFingers);

		//- (void) gridView: (AQGridView *) gridView didDeselectItemAtIndex: (NSUInteger) index;
		[Export ("gridView:didDeselectItemAtIndex:")]
		void DidDeselectItemAtIndex (AQGridView gridView, uint index);

		//- (void) gridViewDidEndUpdateAnimation:(AQGridView *) gridView;
		[Export ("gridViewDidEndUpdateAnimation:")]
		void GridViewDidEndUpdateAnimation (AQGridView gridView);

		//- (void) gridView: (AQGridView *) gridView gestureRecognizer: (UIGestureRecognizer *) recognizer activatedForItemAtIndex: (NSUInteger) index;
		[Export ("gridView:gestureRecognizer:activatedForItemAtIndex:")]
		void GestureRecognizerActivatedForItemAtIndex (AQGridView gridView, UIGestureRecognizer recognizer, uint index);

		//- (CGRect) gridView: (AQGridView *) gridView adjustCellFrame: (CGRect) cellFrame withinGridCellFrame: (CGRect) gridCellFrame;
		[Export ("gridView:adjustCellFrame:withinGridCellFrame:")]
		RectangleF AdjustCellFrame (AQGridView gridView, RectangleF cellFrame, RectangleF gridCellFrame);

		//- (void)gridView:(AQGridView *)aGridView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndex:(NSUInteger)index;
		[Export ("gridView:commitEditingStyle:forRowAtIndex:")]
		void CommitEditingStyle (AQGridView aGridView, UITableViewCellEditingStyle editingStyle, uint index);

//		[Notification, Field ("AQGridViewSelectionDidChangeNotification")]
//		NSString AQGridViewSelectionDidChangeNotification { get; }
	}

	//@interface AQGridView : UIScrollView
	[BaseType (typeof (UIScrollView))]
	public partial interface AQGridView {

		//@property (nonatomic, unsafe_unretained) IBOutlet id<AQGridViewDataSource> dataSource;
		[Export ("dataSource"), NullAllowed]
		NSObject GridViewWeakDataSource { get; set; }

		[Wrap ("GridViewWeakDataSource")]
		AQGridViewDataSource GridViewDataSource { get; set; }

		//@property (nonatomic, unsafe_unretained) IBOutlet id<AQGridViewDelegate> delegate;
		[Export ("delegate"), NullAllowed]
		NSObject GridViewWeakDelegate { get; set; }

		[Wrap ("GridViewWeakDelegate")]
		AQGridViewDelegate GridViewDelegate { get; set; }

		//@property (nonatomic, assign) AQGridViewLayoutDirection layoutDirection;
		[Export ("layoutDirection")]
		AQGridViewLayoutDirection LayoutDirection { get; set; }

		//- (void) reloadData;
		[Export ("reloadData")]
		void ReloadData ();

		//@property (nonatomic, readonly) NSUInteger numberOfItems;
		[Export ("numberOfItems")]
		uint NumberOfItems { get; }

		//@property (nonatomic, readonly) NSUInteger numberOfColumns;
		[Export ("numberOfColumns")]
		uint NumberOfColumns { get; }

		//@property (nonatomic, readonly) NSUInteger numberOfRows;
		[Export ("numberOfRows")]
		uint NumberOfRows { get; }

		//@property (nonatomic, readonly) CGSize gridCellSize;
		[Export ("gridCellSize")]
		SizeF GridCellSize { get; }

		//- (void)doAddVisibleCell: (UIView *)cell;
		[Export ("doAddVisibleCell:")]
		void DoAddVisibleCell (UIView cell);

		//- (CGRect) rectForItemAtIndex: (NSUInteger) index;
		[Export ("rectForItemAtIndex:")]
		RectangleF RectForItemAtIndex (uint index);

		//- (CGRect) gridViewVisibleBounds;
		[Export ("gridViewVisibleBounds")]
		RectangleF GridViewVisibleBounds { get; }

		//- (AQGridViewCell *) cellForItemAtIndex: (NSUInteger) index;
		[Export ("cellForItemAtIndex:")]
		AQGridViewCell CellForItemAtIndex (uint index);

		//- (NSUInteger) indexForItemAtPoint: (CGPoint) point;
		[Export ("indexForItemAtPoint:")]
		uint IndexForItemAtPoint (PointF point);

		//- (NSUInteger) indexForCell: (AQGridViewCell *) cell;
		[Export ("indexForCell:")]
		uint IndexForCell (AQGridViewCell cell);

		//- (AQGridViewCell *) cellForItemAtPoint: (CGPoint) point;
		[Export ("cellForItemAtPoint:")]
		AQGridViewCell CellForItemAtPoint (PointF point);

		//- (NSArray *) visibleCells;
		[Export ("visibleCells")]
		NSObject [] VisibleCells { get; }

		//- (NSIndexSet *) visibleCellIndices;
		[Export ("visibleCellIndices")]
		NSIndexSet VisibleCellIndices { get; }

		//- (void) scrollToItemAtIndex: (NSUInteger) index atScrollPosition: (AQGridViewScrollPosition) scrollPosition animated: (BOOL) animated;
		[Export ("scrollToItemAtIndex:atScrollPosition:animated:")]
		void ScrollToItemAtIndex (uint index, AQGridViewScrollPosition scrollPosition, bool animated);

		//- (void) beginUpdates;
		[Export ("beginUpdates")]
		void BeginUpdates ();

		//- (void) endUpdates;
		[Export ("endUpdates")]
		void EndUpdates ();

		//- (void) insertItemsAtIndices: (NSIndexSet *) indices withAnimation: (AQGridViewItemAnimation) animation;
		[Export ("insertItemsAtIndices:withAnimation:")]
		void InsertItemsAtIndices (NSIndexSet indices, AQGridViewItemAnimation animation);

		//- (void) deleteItemsAtIndices: (NSIndexSet *) indices withAnimation: (AQGridViewItemAnimation) animation;
		[Export ("deleteItemsAtIndices:withAnimation:")]
		void DeleteItemsAtIndices (NSIndexSet indices, AQGridViewItemAnimation animation);

		//- (void) reloadItemsAtIndices: (NSIndexSet *) indices withAnimation: (AQGridViewItemAnimation) animation;
		[Export ("reloadItemsAtIndices:withAnimation:")]
		void ReloadItemsAtIndices (NSIndexSet indices, AQGridViewItemAnimation animation);

		//- (void) moveItemAtIndex: (NSUInteger) index toIndex: (NSUInteger) newIndex withAnimation: (AQGridViewItemAnimation) animation;
		[Export ("moveItemAtIndex:toIndex:withAnimation:")]
		void MoveItemAtIndex (uint index, uint newIndex, AQGridViewItemAnimation animation);

		//@property (nonatomic) BOOL allowsSelection;
		[Export ("allowsSelection")]
		bool AllowsSelection { get; set; }

		//@property (nonatomic) BOOL requiresSelection;
		[Export ("requiresSelection")]
		bool RequiresSelection { get; set; }

		//- (NSUInteger) indexOfSelectedItem;	
		[Export ("indexOfSelectedItem")]
		uint IndexOfSelectedItem { get; }

		//- (void) selectItemAtIndex: (NSUInteger) index animated: (BOOL) animated scrollPosition: (AQGridViewScrollPosition) scrollPosition;
		[Export ("selectItemAtIndex:animated:scrollPosition:")]
		void SelectItemAtIndex (uint index, bool animated, AQGridViewScrollPosition scrollPosition);

		//- (void) deselectItemAtIndex: (NSUInteger) index animated: (BOOL) animated;
		[Export ("deselectItemAtIndex:animated:")]
		void DeselectItemAtIndex (uint index, bool animated);

		//@property (nonatomic, assign) BOOL resizesCellWidthToFit;	
		[Export ("resizesCellWidthToFit")]
		bool ResizesCellWidthToFit { get; set; }

		//@property (nonatomic, assign) BOOL clipsContentWidthToBounds __attribute__((deprecated));
		[Export ("clipsContentWidthToBounds")]
		bool ClipsContentWidthToBounds { get; set; }

		//@property (nonatomic, retain) UIView * backgroundView;
		[Export ("backgroundView")]
		UIView BackgroundView { get; set; }

		//@property (nonatomic) BOOL backgroundViewExtendsUp;
		[Export ("backgroundViewExtendsUp")]
		bool BackgroundViewExtendsUp { get; set; }

		//@property (nonatomic) BOOL backgroundViewExtendsDown;
		[Export ("backgroundViewExtendsDown")]
		bool BackgroundViewExtendsDown { get; set; }

		//@property (nonatomic) BOOL usesPagedHorizontalScrolling;
		[Export ("usesPagedHorizontalScrolling")]
		bool UsesPagedHorizontalScrolling { get; set; }

		//@property (nonatomic) AQGridViewCellSeparatorStyle separatorStyle;
		[Export ("separatorStyle")]
		AQGridViewCellSeparatorStyle SeparatorStyle { get; set; }

		//@property (nonatomic, retain) UIColor * separatorColor;	
		[Export ("separatorColor")]
		UIColor SeparatorColor { get; set; }

		//- (AQGridViewCell *) dequeueReusableCellWithIdentifier: (NSString *) reuseIdentifier;
		[Export ("dequeueReusableCellWithIdentifier:")]
		AQGridViewCell DequeueReusableCellWithIdentifier (string reuseIdentifier);

		//@property (nonatomic, retain) UIView * gridHeaderView;
		[Export ("gridHeaderView")]
		UIView GridHeaderView { get; set; }

		//@property (nonatomic, retain) UIView * gridFooterView;
		[Export ("gridFooterView")]
		UIView GridFooterView { get; set; }

		//@property (nonatomic, assign) CGFloat leftContentInset;
		[Export ("leftContentInset")]
		float LeftContentInset { get; set; }

		//@property (nonatomic, assign) CGFloat rightContentInset;
		[Export ("rightContentInset")]
		float RightContentInset { get; set; }

		//@property (nonatomic, assign) BOOL contentSizeGrowsToFillBounds;
		[Export ("contentSizeGrowsToFillBounds")]
		bool ContentSizeGrowsToFillBounds { get; set; }

		//@property (nonatomic, readonly) BOOL isAnimatingUpdates;
		[Export ("isAnimatingUpdates")]
		bool IsAnimatingUpdates { get; }

		//@property(nonatomic,getter=isEditing) BOOL editing; 
		[Export ("editing")]
		bool Editing { [Bind ("isEditing")] get; set; }

		//- (void)setEditing:(BOOL)editing animated:(BOOL)animated;
		[Export ("setEditing:animated:")]
		void SetEditing (bool editing, bool animated);
	}

	//@protocol AQGridViewDataSource <NSObject>
	[Model]
	[BaseType(typeof(NSObject))]
	public partial interface AQGridViewDataSource {

		//- (NSUInteger) numberOfItemsInGridView: (AQGridView *) gridView;
		[Export ("numberOfItemsInGridView:"), Abstract]
		uint NumberOfItemsInGridView (AQGridView gridView);

		//- (AQGridViewCell *) gridView: (AQGridView *) gridView cellForItemAtIndex: (NSUInteger) index;
		[Export ("gridView:cellForItemAtIndex:"), Abstract]
		AQGridViewCell CellForItemAtIndex (AQGridView gridView, uint index);

		//- (CGSize) portraitGridCellSizeForGridView: (AQGridView *) gridView;
		[Export ("portraitGridCellSizeForGridView:")]
		SizeF PortraitGridCellSizeForGridView (AQGridView gridView);
	}

	//@interface AQGridView (AQCellLayout)
	[Category, BaseType (typeof (AQGridView))]
	public partial interface AQGridViewAQCellLayout {

		//- (CGRect) fixCellFrame: (CGRect) cellFrame forGridRect: (CGRect) gridRect;
		[Export ("fixCellFrame:forGridRect:")]
		RectangleF FixCellFrame (RectangleF cellFrame, RectangleF gridRect);

		//- (void) updateGridViewBoundsForNewGridData: (AQGridViewData *) newGridData;
		[Export ("updateGridViewBoundsForNewGridData:")]
		void UpdateGridViewBoundsForNewGridData (AQGridViewData newGridData);

		//- (AQGridViewCell *) createPreparedCellForIndex: (NSUInteger) index;
		[Export ("createPreparedCellForIndex:")]
		AQGridViewCell CreatePreparedCellForIndex (uint index);

		//- (AQGridViewCell *) createPreparedCellForIndex: (NSUInteger) index usingGridData: (AQGridViewData *) gridData;
		[Export ("createPreparedCellForIndex:usingGridData:")]
		AQGridViewCell CreatePreparedCellForIndex (uint index, AQGridViewData gridData);

		//- (void) insertVisibleCell: (AQGridViewCell *) cell atIndex: (NSUInteger) visibleCellListIndex;
		[Export ("insertVisibleCell:atIndex:")]
		void InsertVisibleCell (AQGridViewCell cell, uint visibleCellListIndex);

		//- (void) deleteVisibleCell: (AQGridViewCell *) cell atIndex: (NSUInteger) visibleCellListIndex appendingNewCell: (AQGridViewCell *) newCell;
		[Export ("deleteVisibleCell:atIndex:appendingNewCell:")]
		void DeleteVisibleCell (AQGridViewCell cell, uint visibleCellListIndex, AQGridViewCell newCell);

		//- (void) ensureCellInVisibleList: (AQGridViewCell *) cell;
		[Export ("ensureCellInVisibleList:")]
		void EnsureCellInVisibleList (AQGridViewCell cell);

		//- (void) animationWillRevealItemsAtIndices: (NSRange) indices;
		[Export ("animationWillRevealItemsAtIndices:")]
		void AnimationWillRevealItemsAtIndices (NSRange indices);
	}

	//@interface AQGridView (CellLocationDelegation)
	[Category, BaseType (typeof (AQGridView))]
	public partial interface AQGridViewCellLocationDelegation {

		//- (void) delegateWillDisplayCell: (AQGridViewCell *) cell atIndex: (NSUInteger) index;
		[Export ("delegateWillDisplayCell:atIndex:")]
		void DelegateWillDisplayCell (AQGridViewCell cell, uint index);
	}

	//@interface AQGridViewAnimatorItem : NSObject
	[BaseType (typeof (NSObject))]
	public partial interface AQGridViewAnimatorItem {

		//+ (AQGridViewAnimatorItem *) itemWithView: (UIView *) aView index: (NSUInteger) anIndex;
		[Static, Export ("itemWithView:index:")]
		AQGridViewAnimatorItem ItemWithView (UIView aView, uint anIndex);

		//@property (nonatomic, retain) UIView * animatingView;
		[Export ("animatingView")]
		UIView AnimatingView { get; set; }

		//@property (nonatomic, assign) NSUInteger index;
		[Export ("index")]
		uint Index { get; set; }

		//- (NSUInteger) hash;
		[Export ("hash")]
		uint Hash { get; }

		//- (BOOL) isEqual: (AQGridViewAnimatorItem *) o;
		[Export ("isEqual:")]
		bool IsEqual (AQGridViewAnimatorItem o);

		//- (NSComparisonResult) compare: (id) obj;
		[Export ("compare:")]
		NSComparisonResult Compare (NSObject obj);
	}

	//@interface AQGridViewCell : UIView
	[BaseType (typeof (UIView))]
	public partial interface AQGridViewCell {

		//- (id) initWithFrame: (CGRect) frame reuseIdentifier: (NSString *) reuseIdentifier;
		[Export ("initWithFrame:reuseIdentifier:")]
		IntPtr Constructor (RectangleF frame, string reuseIdentifier);

		//@property (nonatomic, readonly, retain) UIView * contentView;
		[Export ("contentView")]
		UIView ContentView { get; }

		//@property (nonatomic, retain) UIView * backgroundView;
		[Export ("backgroundView")]
		UIView BackgroundView { get; set; }

		//@property (nonatomic, retain) UIView * selectedBackgroundView;
		[Export ("selectedBackgroundView")]
		UIView SelectedBackgroundView { get; set; }

		//@property (nonatomic, readonly, copy) NSString * reuseIdentifier;
		[Export ("reuseIdentifier")]
		string ReuseIdentifier { get; }

		//- (void) prepareForReuse;
		[Export ("prepareForReuse")]
		void PrepareForReuse ();

		//@property (nonatomic) AQGridViewCellSelectionStyle selectionStyle;	
		[Export ("selectionStyle")]
		AQGridViewCellSelectionStyle SelectionStyle { get; set; }

		//@property (nonatomic, getter=isSelected) BOOL selected;	
		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }

		//@property (nonatomic, getter=isHighlighted) BOOL highlighted;	
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		//@property (nonatomic, retain) UIColor * selectionGlowColor;	
		[Export ("selectionGlowColor")]
		UIColor SelectionGlowColor { get; set; }

		//@property (nonatomic) CGFloat selectionGlowShadowRadius;
		[Export ("selectionGlowShadowRadius")]
		float SelectionGlowShadowRadius { get; set; }

		//@property (nonatomic, readonly) CALayer * glowSelectionLayer;
		[Export ("glowSelectionLayer")]
		CALayer GlowSelectionLayer { get; }

		//- (void) setSelected: (BOOL) selected animated: (BOOL) animated;
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);

		//- (void) setHighlighted: (BOOL) highlighted animated: (BOOL) animated;
		[Export ("setHighlighted:animated:")]
		void SetHighlighted (bool highlighted, bool animated);

		//@property(nonatomic,getter=isEditing) BOOL          editing; 
		[Export ("editing")]
		bool Editing { [Bind ("isEditing")] get; set; }

		//- (void)setEditing:(BOOL)editing animated:(BOOL)animated;
		[Export ("setEditing:animated:")]
		void SetEditing (bool editing, bool animated);

		//- (NSComparisonResult) compareOriginAgainstCell: (AQGridViewCell *) otherCell;
		[Export ("compareOriginAgainstCell:")]
		NSComparisonResult CompareOriginAgainstCell (AQGridViewCell otherCell);
	}

	//@interface AQGridViewController : UIViewController <AQGridViewDelegate, AQGridViewDataSource, UIPopoverControllerDelegate>
	[BaseType (typeof (UIViewController))]
	public partial interface AQGridViewController : AQGridViewDelegate, AQGridViewDataSource {

		//@property (nonatomic, retain) AQGridView * gridView;
		[Export ("gridView")]
		AQGridView GridView { get; set; }

		//@property (nonatomic) BOOL clearsSelectionOnViewWillAppear;
		[Export ("clearsSelectionOnViewWillAppear")]
		bool ClearsSelectionOnViewWillAppear { get; set; }
	}

	//@interface AQGridViewData : NSObject <NSCopying, NSMutableCopying>
	[BaseType (typeof (NSObject))]
	public partial interface AQGridViewData {

		//- (id) initWithGridView: (AQGridView *) gridView;
		[Export ("initWithGridView:")]
		IntPtr Constructor (AQGridView gridView);

		//@property (nonatomic) NSUInteger numberOfItems;
		[Export ("numberOfItems")]
		uint NumberOfItems { get; set; }

		//@property (nonatomic) CGFloat topPadding, bottomPadding, leftPadding, rightPadding;
		[Export ("topPadding")]
		float TopPadding { get; set; }

		//@property (nonatomic) CGFloat topPadding, bottomPadding, leftPadding, rightPadding;
		[Export ("bottomPadding")]
		float BottomPadding { get; set; }

		//@property (nonatomic) CGFloat topPadding, bottomPadding, leftPadding, rightPadding;
		[Export ("leftPadding")]
		float LeftPadding { get; set; }

		//@property (nonatomic) CGFloat topPadding, bottomPadding, leftPadding, rightPadding;
		[Export ("rightPadding")]
		float RightPadding { get; set; }

		//@property (nonatomic) AQGridViewLayoutDirection layoutDirection;
		[Export ("layoutDirection")]
		AQGridViewLayoutDirection LayoutDirection { get; set; }

		//- (void) gridViewDidChangeBoundsSize: (CGSize) boundsSize;
		[Export ("gridViewDidChangeBoundsSize:")]
		void GridViewDidChangeBoundsSize (SizeF boundsSize);

		//@property (nonatomic) NSUInteger reorderedIndex;
		[Export ("reorderedIndex")]
		uint ReorderedIndex { get; set; }

		//- (NSUInteger) itemIndexForPoint: (CGPoint) point;
		[Export ("itemIndexForPoint:")]
		uint ItemIndexForPoint (PointF point);

		//- (BOOL) pointIsInLastRow: (CGPoint) point;
		[Export ("pointIsInLastRow:")]
		bool PointIsInLastRow (PointF point);

		//- (void) setDesiredCellSize: (CGSize) desiredCellSize;
		[Export ("desiredCellSize")]
		SizeF DesiredCellSize { set; }

		//- (CGSize) cellSize;
		[Export ("cellSize")]
		SizeF CellSize { get; }

		//- (CGRect) rectForEntireGrid;
		[Export ("rectForEntireGrid")]
		RectangleF RectForEntireGrid { get; }

		//- (CGSize) sizeForEntireGrid;
		[Export ("sizeForEntireGrid")]
		SizeF SizeForEntireGrid { get; }

		//- (NSUInteger) numberOfItemsPerRow;
		[Export ("numberOfItemsPerRow")]
		uint NumberOfItemsPerRow { get; }

		//- (CGRect) cellRectAtIndex: (NSUInteger) index;
		[Export ("cellRectAtIndex:")]
		RectangleF CellRectAtIndex (uint index);

		//- (CGRect) cellRectForPoint: (CGPoint) point;
		[Export ("cellRectForPoint:")]
		RectangleF CellRectForPoint (PointF point);

		//- (NSIndexSet *) indicesOfCellsInRect: (CGRect) rect;
		[Export ("indicesOfCellsInRect:")]
		NSIndexSet IndicesOfCellsInRect (RectangleF rect);
	}

	//@interface AQGridViewUpdateInfo : NSObject
	[BaseType (typeof (NSObject))]
	public partial interface AQGridViewUpdateInfo {

		//- (id) initWithOldGridData: (AQGridViewData *) oldGridData forGridView: (AQGridView *) gridView;
		[Export ("initWithOldGridData:forGridView:")]
		IntPtr Constructor (AQGridViewData oldGridData, AQGridView gridView);

		//- (void) updateItemsAtIndices: (NSIndexSet *) indices
		//	updateAction: (AQGridViewUpdateAction) action
		//		withAnimation: (AQGridViewItemAnimation) animation;
		[Export ("updateItemsAtIndices:updateAction:withAnimation:")]
		void UpdateItemsAtIndices (NSIndexSet indices, AQGridViewUpdateAction action, AQGridViewItemAnimation animation);

		//- (void) moveItemAtIndex: (NSUInteger) index
		//	toIndex: (NSUInteger) index
		//		withAnimation: (AQGridViewItemAnimation) animation;
		[Export ("moveItemAtIndex:toIndex:withAnimation:")]
		void MoveItemAtIndex (uint index, uint toIndex, AQGridViewItemAnimation animation);

		//@property (nonatomic, readonly) NSUInteger numberOfUpdates;
		[Export ("numberOfUpdates")]
		uint NumberOfUpdates { get; }

		//- (void) cleanupUpdateItems;
		[Export ("cleanupUpdateItems")]
		void CleanupUpdateItems ();

		//- (NSArray *) sortedInsertItems;
		[Export ("sortedInsertItems")]
		NSObject [] SortedInsertItems { get; }

		//- (NSArray *) sortedDeleteItems;
		[Export ("sortedDeleteItems")]
		NSObject [] SortedDeleteItems { get; }

		//- (NSArray *) sortedMoveItems;
		[Export ("sortedMoveItems")]
		NSObject [] SortedMoveItems { get; }

		//- (NSArray *) sortedReloadItems;
		[Export ("sortedReloadItems")]
		NSObject [] SortedReloadItems { get; }

		//- (AQGridViewData *) newGridViewData;
		[Export ("newGridViewData")]
		AQGridViewData NewGridViewData { get; }

		//- (NSUInteger) numberOfItemsAfterUpdates;
		[Export ("numberOfItemsAfterUpdates")]
		uint NumberOfItemsAfterUpdates { get; }

		//- (NSUInteger) newIndexForOldIndex: (NSUInteger) oldIndex;
		[Export ("newIndexForOldIndex:")]
		uint NewIndexForOldIndex (uint oldIndex);

		//- (NSSet *) animateCellUpdatesUsingVisibleContentRect: (CGRect) contentRect;
		[Export ("animateCellUpdatesUsingVisibleContentRect:")]
		NSSet AnimateCellUpdatesUsingVisibleContentRect (RectangleF contentRect);
	}

	//@interface AQGridViewUpdateItem : NSObject
	[BaseType (typeof (NSObject))]
	public partial interface AQGridViewUpdateItem {

		//- (id) initWithIndex: (NSUInteger) index action: (AQGridViewUpdateAction) action animation: (AQGridViewItemAnimation) animation;
		[Export ("initWithIndex:action:animation:")]
		IntPtr Constructor (uint index, AQGridViewUpdateAction action, AQGridViewItemAnimation animation);

		//- (NSComparisonResult) compare: (AQGridViewUpdateItem *) other;
		[Export ("compare:")]
		NSComparisonResult Compare (AQGridViewUpdateItem other);

		//- (NSComparisonResult) inverseCompare: (AQGridViewUpdateItem *) other;
		[Export ("inverseCompare:")]
		NSComparisonResult InverseCompare (AQGridViewUpdateItem other);

		//@property (nonatomic, readonly) NSUInteger index;
		[Export ("index")]
		uint Index { get; }

		//@property (nonatomic) NSUInteger newIndex;
		[Export ("newIndex")]
		uint NewIndex { get; set; }

		//@property (nonatomic, readonly) AQGridViewUpdateAction action;
		[Export ("action")]
		AQGridViewUpdateAction Action { get; }

		//@property (nonatomic, readonly) AQGridViewItemAnimation animation;
		[Export ("animation")]
		AQGridViewItemAnimation Animation { get; }

		//@property (nonatomic) NSInteger offset;
		[Export ("offset")]
		int Offset { get; set; }

		//@property (nonatomic, readonly) NSUInteger originalIndex;
		[Export ("originalIndex")]
		uint OriginalIndex { get; }
	}
}

