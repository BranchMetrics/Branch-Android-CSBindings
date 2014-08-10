using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BranchSDK {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.branch.referral']/interface[@name='NetworkCallback']"
	[Register ("io/branch/referral/NetworkCallback", "", "BranchSDK.INetworkCallbackInvoker")]
	public partial interface INetworkCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/interface[@name='NetworkCallback']/method[@name='finished' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("finished", "(Lorg/json/JSONObject;)V", "GetFinished_Lorg_json_JSONObject_Handler:BranchSDK.INetworkCallbackInvoker, Branch-Android-CSBindings")]
		void Finished (global::Org.Json.JSONObject p0);

	}

	[global::Android.Runtime.Register ("io/branch/referral/NetworkCallback", DoNotGenerateAcw=true)]
	internal class INetworkCallbackInvoker : global::Java.Lang.Object, INetworkCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/branch/referral/NetworkCallback");
		IntPtr class_ref;

		public static INetworkCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.branch.referral.NetworkCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (INetworkCallbackInvoker); }
		}

		static Delegate cb_finished_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetFinished_Lorg_json_JSONObject_Handler ()
		{
			if (cb_finished_Lorg_json_JSONObject_ == null)
				cb_finished_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Finished_Lorg_json_JSONObject_);
			return cb_finished_Lorg_json_JSONObject_;
		}

		static void n_Finished_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.INetworkCallback __this = global::Java.Lang.Object.GetObject<global::BranchSDK.INetworkCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Finished (p0);
		}
#pragma warning restore 0169

		IntPtr id_finished_Lorg_json_JSONObject_;
		public void Finished (global::Org.Json.JSONObject p0)
		{
			if (id_finished_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_finished_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "finished", "(Lorg/json/JSONObject;)V");
			JNIEnv.CallVoidMethod (Handle, id_finished_Lorg_json_JSONObject_, new JValue (p0));
		}

	}

}
