// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace AQTapDemo
{
	[Register ("AQTapDemoViewController")]
	partial class AQTapDemoViewController
	{
		[Outlet]
		MonoTouch.UIKit.UISlider pitchSlider { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel stationURLLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel pitchLabel { get; set; }

		[Action ("handlePitchSliderValueChanged:")]
		partial void handlePitchSliderValueChanged (MonoTouch.Foundation.NSObject sender);

		[Action ("handleResetTo1Tapped:")]
		partial void handleResetTo1Tapped (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (pitchSlider != null) {
				pitchSlider.Dispose ();
				pitchSlider = null;
			}

			if (stationURLLabel != null) {
				stationURLLabel.Dispose ();
				stationURLLabel = null;
			}

			if (pitchLabel != null) {
				pitchLabel.Dispose ();
				pitchLabel = null;
			}
		}
	}
}
