// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_Notifications.Screens.iPhone.DeviceToken {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("GetDeviceTokenScreen")]
	public partial class GetDeviceTokenScreen {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UILabel __mt_lblToken;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblToken")]
		private MonoTouch.UIKit.UILabel lblToken {
			get {
				this.__mt_lblToken = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblToken")));
				return this.__mt_lblToken;
			}
			set {
				this.__mt_lblToken = value;
				this.SetNativeField("lblToken", value);
			}
		}
	}
}
