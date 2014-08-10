using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BranchSDK {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']"
	[global::Android.Runtime.Register ("io/branch/referral/SystemObserver", DoNotGenerateAcw=true)]
	public partial class SystemObserver : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/field[@name='BLANK']"
		[Register ("BLANK")]
		public const string Blank = (string) "bnc_no_value";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/branch/referral/SystemObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SystemObserver); }
		}

		protected SystemObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/constructor[@name='SystemObserver' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public SystemObserver (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SystemObserver)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_getAppVersion;
#pragma warning disable 0169
		static Delegate GetGetAppVersionHandler ()
		{
			if (cb_getAppVersion == null)
				cb_getAppVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppVersion);
			return cb_getAppVersion;
		}

		static IntPtr n_GetAppVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getAppVersion;
		public virtual string AppVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getAppVersion' and count(parameter)=0]"
			[Register ("getAppVersion", "()Ljava/lang/String;", "GetGetAppVersionHandler")]
			get {
				if (id_getAppVersion == IntPtr.Zero)
					id_getAppVersion = JNIEnv.GetMethodID (class_ref, "getAppVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBluetoothPresent;
#pragma warning disable 0169
		static Delegate GetGetBluetoothPresentHandler ()
		{
			if (cb_getBluetoothPresent == null)
				cb_getBluetoothPresent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetBluetoothPresent);
			return cb_getBluetoothPresent;
		}

		static bool n_GetBluetoothPresent (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BluetoothPresent;
		}
#pragma warning restore 0169

		static IntPtr id_getBluetoothPresent;
		public virtual bool BluetoothPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getBluetoothPresent' and count(parameter)=0]"
			[Register ("getBluetoothPresent", "()Z", "GetGetBluetoothPresentHandler")]
			get {
				if (id_getBluetoothPresent == IntPtr.Zero)
					id_getBluetoothPresent = JNIEnv.GetMethodID (class_ref, "getBluetoothPresent", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getBluetoothPresent);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBluetoothPresent", "()Z"));
			}
		}

		static Delegate cb_getBluetoothVersion;
#pragma warning disable 0169
		static Delegate GetGetBluetoothVersionHandler ()
		{
			if (cb_getBluetoothVersion == null)
				cb_getBluetoothVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBluetoothVersion);
			return cb_getBluetoothVersion;
		}

		static IntPtr n_GetBluetoothVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BluetoothVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getBluetoothVersion;
		public virtual string BluetoothVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getBluetoothVersion' and count(parameter)=0]"
			[Register ("getBluetoothVersion", "()Ljava/lang/String;", "GetGetBluetoothVersionHandler")]
			get {
				if (id_getBluetoothVersion == IntPtr.Zero)
					id_getBluetoothVersion = JNIEnv.GetMethodID (class_ref, "getBluetoothVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBluetoothVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBluetoothVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCarrier;
#pragma warning disable 0169
		static Delegate GetGetCarrierHandler ()
		{
			if (cb_getCarrier == null)
				cb_getCarrier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCarrier);
			return cb_getCarrier;
		}

		static IntPtr n_GetCarrier (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Carrier);
		}
#pragma warning restore 0169

		static IntPtr id_getCarrier;
		public virtual string Carrier {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getCarrier' and count(parameter)=0]"
			[Register ("getCarrier", "()Ljava/lang/String;", "GetGetCarrierHandler")]
			get {
				if (id_getCarrier == IntPtr.Zero)
					id_getCarrier = JNIEnv.GetMethodID (class_ref, "getCarrier", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCarrier), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCarrier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNFCPresent;
#pragma warning disable 0169
		static Delegate GetGetNFCPresentHandler ()
		{
			if (cb_getNFCPresent == null)
				cb_getNFCPresent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetNFCPresent);
			return cb_getNFCPresent;
		}

		static bool n_GetNFCPresent (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NFCPresent;
		}
#pragma warning restore 0169

		static IntPtr id_getNFCPresent;
		public virtual bool NFCPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getNFCPresent' and count(parameter)=0]"
			[Register ("getNFCPresent", "()Z", "GetGetNFCPresentHandler")]
			get {
				if (id_getNFCPresent == IntPtr.Zero)
					id_getNFCPresent = JNIEnv.GetMethodID (class_ref, "getNFCPresent", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getNFCPresent);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNFCPresent", "()Z"));
			}
		}

		static Delegate cb_getOS;
#pragma warning disable 0169
		static Delegate GetGetOSHandler ()
		{
			if (cb_getOS == null)
				cb_getOS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOS);
			return cb_getOS;
		}

		static IntPtr n_GetOS (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OS);
		}
#pragma warning restore 0169

		static IntPtr id_getOS;
		public virtual string OS {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getOS' and count(parameter)=0]"
			[Register ("getOS", "()Ljava/lang/String;", "GetGetOSHandler")]
			get {
				if (id_getOS == IntPtr.Zero)
					id_getOS = JNIEnv.GetMethodID (class_ref, "getOS", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOS), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOS", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOSVersion;
#pragma warning disable 0169
		static Delegate GetGetOSVersionHandler ()
		{
			if (cb_getOSVersion == null)
				cb_getOSVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOSVersion);
			return cb_getOSVersion;
		}

		static int n_GetOSVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OSVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getOSVersion;
		public virtual int OSVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getOSVersion' and count(parameter)=0]"
			[Register ("getOSVersion", "()I", "GetGetOSVersionHandler")]
			get {
				if (id_getOSVersion == IntPtr.Zero)
					id_getOSVersion = JNIEnv.GetMethodID (class_ref, "getOSVersion", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getOSVersion);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOSVersion", "()I"));
			}
		}

		static Delegate cb_getPhoneBrand;
#pragma warning disable 0169
		static Delegate GetGetPhoneBrandHandler ()
		{
			if (cb_getPhoneBrand == null)
				cb_getPhoneBrand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneBrand);
			return cb_getPhoneBrand;
		}

		static IntPtr n_GetPhoneBrand (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PhoneBrand);
		}
#pragma warning restore 0169

		static IntPtr id_getPhoneBrand;
		public virtual string PhoneBrand {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getPhoneBrand' and count(parameter)=0]"
			[Register ("getPhoneBrand", "()Ljava/lang/String;", "GetGetPhoneBrandHandler")]
			get {
				if (id_getPhoneBrand == IntPtr.Zero)
					id_getPhoneBrand = JNIEnv.GetMethodID (class_ref, "getPhoneBrand", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPhoneBrand), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoneBrand", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPhoneModel;
#pragma warning disable 0169
		static Delegate GetGetPhoneModelHandler ()
		{
			if (cb_getPhoneModel == null)
				cb_getPhoneModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneModel);
			return cb_getPhoneModel;
		}

		static IntPtr n_GetPhoneModel (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PhoneModel);
		}
#pragma warning restore 0169

		static IntPtr id_getPhoneModel;
		public virtual string PhoneModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getPhoneModel' and count(parameter)=0]"
			[Register ("getPhoneModel", "()Ljava/lang/String;", "GetGetPhoneModelHandler")]
			get {
				if (id_getPhoneModel == IntPtr.Zero)
					id_getPhoneModel = JNIEnv.GetMethodID (class_ref, "getPhoneModel", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPhoneModel), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoneModel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScreenDisplay;
#pragma warning disable 0169
		static Delegate GetGetScreenDisplayHandler ()
		{
			if (cb_getScreenDisplay == null)
				cb_getScreenDisplay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScreenDisplay);
			return cb_getScreenDisplay;
		}

		static IntPtr n_GetScreenDisplay (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScreenDisplay);
		}
#pragma warning restore 0169

		static IntPtr id_getScreenDisplay;
		public virtual global::Android.Util.DisplayMetrics ScreenDisplay {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getScreenDisplay' and count(parameter)=0]"
			[Register ("getScreenDisplay", "()Landroid/util/DisplayMetrics;", "GetGetScreenDisplayHandler")]
			get {
				if (id_getScreenDisplay == IntPtr.Zero)
					id_getScreenDisplay = JNIEnv.GetMethodID (class_ref, "getScreenDisplay", "()Landroid/util/DisplayMetrics;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Util.DisplayMetrics> (JNIEnv.CallObjectMethod  (Handle, id_getScreenDisplay), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Util.DisplayMetrics> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScreenDisplay", "()Landroid/util/DisplayMetrics;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTelephonePresent;
#pragma warning disable 0169
		static Delegate GetGetTelephonePresentHandler ()
		{
			if (cb_getTelephonePresent == null)
				cb_getTelephonePresent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTelephonePresent);
			return cb_getTelephonePresent;
		}

		static bool n_GetTelephonePresent (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TelephonePresent;
		}
#pragma warning restore 0169

		static IntPtr id_getTelephonePresent;
		public virtual bool TelephonePresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getTelephonePresent' and count(parameter)=0]"
			[Register ("getTelephonePresent", "()Z", "GetGetTelephonePresentHandler")]
			get {
				if (id_getTelephonePresent == IntPtr.Zero)
					id_getTelephonePresent = JNIEnv.GetMethodID (class_ref, "getTelephonePresent", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getTelephonePresent);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTelephonePresent", "()Z"));
			}
		}

		static Delegate cb_getUniqueID;
#pragma warning disable 0169
		static Delegate GetGetUniqueIDHandler ()
		{
			if (cb_getUniqueID == null)
				cb_getUniqueID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUniqueID);
			return cb_getUniqueID;
		}

		static IntPtr n_GetUniqueID (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UniqueID);
		}
#pragma warning restore 0169

		static IntPtr id_getUniqueID;
		public virtual string UniqueID {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getUniqueID' and count(parameter)=0]"
			[Register ("getUniqueID", "()Ljava/lang/String;", "GetGetUniqueIDHandler")]
			get {
				if (id_getUniqueID == IntPtr.Zero)
					id_getUniqueID = JNIEnv.GetMethodID (class_ref, "getUniqueID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUniqueID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUniqueID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUpdateState;
#pragma warning disable 0169
		static Delegate GetGetUpdateStateHandler ()
		{
			if (cb_getUpdateState == null)
				cb_getUpdateState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUpdateState);
			return cb_getUpdateState;
		}

		static int n_GetUpdateState (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateState;
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateState;
		public virtual int UpdateState {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getUpdateState' and count(parameter)=0]"
			[Register ("getUpdateState", "()I", "GetGetUpdateStateHandler")]
			get {
				if (id_getUpdateState == IntPtr.Zero)
					id_getUpdateState = JNIEnv.GetMethodID (class_ref, "getUpdateState", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getUpdateState);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateState", "()I"));
			}
		}

		static Delegate cb_getWifiConnected;
#pragma warning disable 0169
		static Delegate GetGetWifiConnectedHandler ()
		{
			if (cb_getWifiConnected == null)
				cb_getWifiConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWifiConnected);
			return cb_getWifiConnected;
		}

		static bool n_GetWifiConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.SystemObserver __this = global::Java.Lang.Object.GetObject<global::BranchSDK.SystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WifiConnected;
		}
#pragma warning restore 0169

		static IntPtr id_getWifiConnected;
		public virtual bool WifiConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='SystemObserver']/method[@name='getWifiConnected' and count(parameter)=0]"
			[Register ("getWifiConnected", "()Z", "GetGetWifiConnectedHandler")]
			get {
				if (id_getWifiConnected == IntPtr.Zero)
					id_getWifiConnected = JNIEnv.GetMethodID (class_ref, "getWifiConnected", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getWifiConnected);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWifiConnected", "()Z"));
			}
		}

	}
}
