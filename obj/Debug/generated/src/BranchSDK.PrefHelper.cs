using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BranchSDK {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']"
	[global::Android.Runtime.Register ("io/branch/referral/PrefHelper", DoNotGenerateAcw=true)]
	public partial class PrefHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/field[@name='LOG']"
		[Register ("LOG")]
		public const bool Log = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/field[@name='NO_STRING_VALUE']"
		[Register ("NO_STRING_VALUE")]
		public const string NoStringValue = (string) "bnc_no_value";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/branch/referral/PrefHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PrefHelper); }
		}

		protected PrefHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/constructor[@name='PrefHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PrefHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PrefHelper)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getAPIBaseUrl;
#pragma warning disable 0169
		static Delegate GetGetAPIBaseUrlHandler ()
		{
			if (cb_getAPIBaseUrl == null)
				cb_getAPIBaseUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAPIBaseUrl);
			return cb_getAPIBaseUrl;
		}

		static IntPtr n_GetAPIBaseUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.APIBaseUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getAPIBaseUrl;
		public virtual string APIBaseUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getAPIBaseUrl' and count(parameter)=0]"
			[Register ("getAPIBaseUrl", "()Ljava/lang/String;", "GetGetAPIBaseUrlHandler")]
			get {
				if (id_getAPIBaseUrl == IntPtr.Zero)
					id_getAPIBaseUrl = JNIEnv.GetMethodID (class_ref, "getAPIBaseUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAPIBaseUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAPIBaseUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAppKey;
#pragma warning disable 0169
		static Delegate GetGetAppKeyHandler ()
		{
			if (cb_getAppKey == null)
				cb_getAppKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppKey);
			return cb_getAppKey;
		}

		static IntPtr n_GetAppKey (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppKey);
		}
#pragma warning restore 0169

		static Delegate cb_setAppKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppKey_Ljava_lang_String_Handler ()
		{
			if (cb_setAppKey_Ljava_lang_String_ == null)
				cb_setAppKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppKey_Ljava_lang_String_);
			return cb_setAppKey_Ljava_lang_String_;
		}

		static void n_SetAppKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppKey;
		static IntPtr id_setAppKey_Ljava_lang_String_;
		public virtual string AppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getAppKey' and count(parameter)=0]"
			[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
			get {
				if (id_getAppKey == IntPtr.Zero)
					id_getAppKey = JNIEnv.GetMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setAppKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppKey", "(Ljava/lang/String;)V", "GetSetAppKey_Ljava_lang_String_Handler")]
			set {
				if (id_setAppKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppKey_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppKey", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getCreditCount;
#pragma warning disable 0169
		static Delegate GetGetCreditCountHandler ()
		{
			if (cb_getCreditCount == null)
				cb_getCreditCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCreditCount);
			return cb_getCreditCount;
		}

		static int n_GetCreditCount (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreditCount;
		}
#pragma warning restore 0169

		static Delegate cb_setCreditCount_I;
#pragma warning disable 0169
		static Delegate GetSetCreditCount_IHandler ()
		{
			if (cb_setCreditCount_I == null)
				cb_setCreditCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCreditCount_I);
			return cb_setCreditCount_I;
		}

		static void n_SetCreditCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreditCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreditCount;
		static IntPtr id_setCreditCount_I;
		public virtual int CreditCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getCreditCount' and count(parameter)=0]"
			[Register ("getCreditCount", "()I", "GetGetCreditCountHandler")]
			get {
				if (id_getCreditCount == IntPtr.Zero)
					id_getCreditCount = JNIEnv.GetMethodID (class_ref, "getCreditCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCreditCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreditCount", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setCreditCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCreditCount", "(I)V", "GetSetCreditCount_IHandler")]
			set {
				if (id_setCreditCount_I == IntPtr.Zero)
					id_setCreditCount_I = JNIEnv.GetMethodID (class_ref, "setCreditCount", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCreditCount_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreditCount", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getDeviceFingerPrintID;
#pragma warning disable 0169
		static Delegate GetGetDeviceFingerPrintIDHandler ()
		{
			if (cb_getDeviceFingerPrintID == null)
				cb_getDeviceFingerPrintID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceFingerPrintID);
			return cb_getDeviceFingerPrintID;
		}

		static IntPtr n_GetDeviceFingerPrintID (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceFingerPrintID);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceFingerPrintID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceFingerPrintID_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceFingerPrintID_Ljava_lang_String_ == null)
				cb_setDeviceFingerPrintID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceFingerPrintID_Ljava_lang_String_);
			return cb_setDeviceFingerPrintID_Ljava_lang_String_;
		}

		static void n_SetDeviceFingerPrintID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceFingerPrintID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceFingerPrintID;
		static IntPtr id_setDeviceFingerPrintID_Ljava_lang_String_;
		public virtual string DeviceFingerPrintID {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getDeviceFingerPrintID' and count(parameter)=0]"
			[Register ("getDeviceFingerPrintID", "()Ljava/lang/String;", "GetGetDeviceFingerPrintIDHandler")]
			get {
				if (id_getDeviceFingerPrintID == IntPtr.Zero)
					id_getDeviceFingerPrintID = JNIEnv.GetMethodID (class_ref, "getDeviceFingerPrintID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceFingerPrintID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceFingerPrintID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setDeviceFingerPrintID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceFingerPrintID", "(Ljava/lang/String;)V", "GetSetDeviceFingerPrintID_Ljava_lang_String_Handler")]
			set {
				if (id_setDeviceFingerPrintID_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceFingerPrintID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceFingerPrintID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDeviceFingerPrintID_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceFingerPrintID", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getIdentity;
#pragma warning disable 0169
		static Delegate GetGetIdentityHandler ()
		{
			if (cb_getIdentity == null)
				cb_getIdentity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentity);
			return cb_getIdentity;
		}

		static IntPtr n_GetIdentity (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Identity);
		}
#pragma warning restore 0169

		static Delegate cb_setIdentity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIdentity_Ljava_lang_String_Handler ()
		{
			if (cb_setIdentity_Ljava_lang_String_ == null)
				cb_setIdentity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIdentity_Ljava_lang_String_);
			return cb_setIdentity_Ljava_lang_String_;
		}

		static void n_SetIdentity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Identity = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIdentity;
		static IntPtr id_setIdentity_Ljava_lang_String_;
		public virtual string Identity {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getIdentity' and count(parameter)=0]"
			[Register ("getIdentity", "()Ljava/lang/String;", "GetGetIdentityHandler")]
			get {
				if (id_getIdentity == IntPtr.Zero)
					id_getIdentity = JNIEnv.GetMethodID (class_ref, "getIdentity", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIdentity), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentity", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setIdentity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIdentity", "(Ljava/lang/String;)V", "GetSetIdentity_Ljava_lang_String_Handler")]
			set {
				if (id_setIdentity_Ljava_lang_String_ == IntPtr.Zero)
					id_setIdentity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIdentity", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIdentity_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIdentity", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getIdentityID;
#pragma warning disable 0169
		static Delegate GetGetIdentityIDHandler ()
		{
			if (cb_getIdentityID == null)
				cb_getIdentityID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentityID);
			return cb_getIdentityID;
		}

		static IntPtr n_GetIdentityID (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdentityID);
		}
#pragma warning restore 0169

		static Delegate cb_setIdentityID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIdentityID_Ljava_lang_String_Handler ()
		{
			if (cb_setIdentityID_Ljava_lang_String_ == null)
				cb_setIdentityID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIdentityID_Ljava_lang_String_);
			return cb_setIdentityID_Ljava_lang_String_;
		}

		static void n_SetIdentityID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IdentityID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIdentityID;
		static IntPtr id_setIdentityID_Ljava_lang_String_;
		public virtual string IdentityID {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getIdentityID' and count(parameter)=0]"
			[Register ("getIdentityID", "()Ljava/lang/String;", "GetGetIdentityIDHandler")]
			get {
				if (id_getIdentityID == IntPtr.Zero)
					id_getIdentityID = JNIEnv.GetMethodID (class_ref, "getIdentityID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIdentityID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentityID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setIdentityID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIdentityID", "(Ljava/lang/String;)V", "GetSetIdentityID_Ljava_lang_String_Handler")]
			set {
				if (id_setIdentityID_Ljava_lang_String_ == IntPtr.Zero)
					id_setIdentityID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIdentityID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIdentityID_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIdentityID", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getInstallParams;
#pragma warning disable 0169
		static Delegate GetGetInstallParamsHandler ()
		{
			if (cb_getInstallParams == null)
				cb_getInstallParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInstallParams);
			return cb_getInstallParams;
		}

		static IntPtr n_GetInstallParams (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InstallParams);
		}
#pragma warning restore 0169

		static Delegate cb_setInstallParams_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInstallParams_Ljava_lang_String_Handler ()
		{
			if (cb_setInstallParams_Ljava_lang_String_ == null)
				cb_setInstallParams_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInstallParams_Ljava_lang_String_);
			return cb_setInstallParams_Ljava_lang_String_;
		}

		static void n_SetInstallParams_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InstallParams = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInstallParams;
		static IntPtr id_setInstallParams_Ljava_lang_String_;
		public virtual string InstallParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getInstallParams' and count(parameter)=0]"
			[Register ("getInstallParams", "()Ljava/lang/String;", "GetGetInstallParamsHandler")]
			get {
				if (id_getInstallParams == IntPtr.Zero)
					id_getInstallParams = JNIEnv.GetMethodID (class_ref, "getInstallParams", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInstallParams), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInstallParams", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setInstallParams' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInstallParams", "(Ljava/lang/String;)V", "GetSetInstallParams_Ljava_lang_String_Handler")]
			set {
				if (id_setInstallParams_Ljava_lang_String_ == IntPtr.Zero)
					id_setInstallParams_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInstallParams", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInstallParams_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInstallParams", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getIsReferrable;
#pragma warning disable 0169
		static Delegate GetGetIsReferrableHandler ()
		{
			if (cb_getIsReferrable == null)
				cb_getIsReferrable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIsReferrable);
			return cb_getIsReferrable;
		}

		static int n_GetIsReferrable (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReferrable;
		}
#pragma warning restore 0169

		static IntPtr id_getIsReferrable;
		public virtual int IsReferrable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getIsReferrable' and count(parameter)=0]"
			[Register ("getIsReferrable", "()I", "GetGetIsReferrableHandler")]
			get {
				if (id_getIsReferrable == IntPtr.Zero)
					id_getIsReferrable = JNIEnv.GetMethodID (class_ref, "getIsReferrable", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getIsReferrable);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsReferrable", "()I"));
			}
		}

		static Delegate cb_getLinkClickID;
#pragma warning disable 0169
		static Delegate GetGetLinkClickIDHandler ()
		{
			if (cb_getLinkClickID == null)
				cb_getLinkClickID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLinkClickID);
			return cb_getLinkClickID;
		}

		static IntPtr n_GetLinkClickID (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LinkClickID);
		}
#pragma warning restore 0169

		static Delegate cb_setLinkClickID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLinkClickID_Ljava_lang_String_Handler ()
		{
			if (cb_setLinkClickID_Ljava_lang_String_ == null)
				cb_setLinkClickID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLinkClickID_Ljava_lang_String_);
			return cb_setLinkClickID_Ljava_lang_String_;
		}

		static void n_SetLinkClickID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LinkClickID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLinkClickID;
		static IntPtr id_setLinkClickID_Ljava_lang_String_;
		public virtual string LinkClickID {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getLinkClickID' and count(parameter)=0]"
			[Register ("getLinkClickID", "()Ljava/lang/String;", "GetGetLinkClickIDHandler")]
			get {
				if (id_getLinkClickID == IntPtr.Zero)
					id_getLinkClickID = JNIEnv.GetMethodID (class_ref, "getLinkClickID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLinkClickID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLinkClickID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setLinkClickID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLinkClickID", "(Ljava/lang/String;)V", "GetSetLinkClickID_Ljava_lang_String_Handler")]
			set {
				if (id_setLinkClickID_Ljava_lang_String_ == IntPtr.Zero)
					id_setLinkClickID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLinkClickID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLinkClickID_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLinkClickID", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getLinkClickIdentifier;
#pragma warning disable 0169
		static Delegate GetGetLinkClickIdentifierHandler ()
		{
			if (cb_getLinkClickIdentifier == null)
				cb_getLinkClickIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLinkClickIdentifier);
			return cb_getLinkClickIdentifier;
		}

		static IntPtr n_GetLinkClickIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LinkClickIdentifier);
		}
#pragma warning restore 0169

		static Delegate cb_setLinkClickIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLinkClickIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setLinkClickIdentifier_Ljava_lang_String_ == null)
				cb_setLinkClickIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLinkClickIdentifier_Ljava_lang_String_);
			return cb_setLinkClickIdentifier_Ljava_lang_String_;
		}

		static void n_SetLinkClickIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LinkClickIdentifier = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLinkClickIdentifier;
		static IntPtr id_setLinkClickIdentifier_Ljava_lang_String_;
		public virtual string LinkClickIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getLinkClickIdentifier' and count(parameter)=0]"
			[Register ("getLinkClickIdentifier", "()Ljava/lang/String;", "GetGetLinkClickIdentifierHandler")]
			get {
				if (id_getLinkClickIdentifier == IntPtr.Zero)
					id_getLinkClickIdentifier = JNIEnv.GetMethodID (class_ref, "getLinkClickIdentifier", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLinkClickIdentifier), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLinkClickIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setLinkClickIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLinkClickIdentifier", "(Ljava/lang/String;)V", "GetSetLinkClickIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setLinkClickIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setLinkClickIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLinkClickIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLinkClickIdentifier_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLinkClickIdentifier", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getSessionID;
#pragma warning disable 0169
		static Delegate GetGetSessionIDHandler ()
		{
			if (cb_getSessionID == null)
				cb_getSessionID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionID);
			return cb_getSessionID;
		}

		static IntPtr n_GetSessionID (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionID);
		}
#pragma warning restore 0169

		static Delegate cb_setSessionID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSessionID_Ljava_lang_String_Handler ()
		{
			if (cb_setSessionID_Ljava_lang_String_ == null)
				cb_setSessionID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSessionID_Ljava_lang_String_);
			return cb_setSessionID_Ljava_lang_String_;
		}

		static void n_SetSessionID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SessionID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionID;
		static IntPtr id_setSessionID_Ljava_lang_String_;
		public virtual string SessionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getSessionID' and count(parameter)=0]"
			[Register ("getSessionID", "()Ljava/lang/String;", "GetGetSessionIDHandler")]
			get {
				if (id_getSessionID == IntPtr.Zero)
					id_getSessionID = JNIEnv.GetMethodID (class_ref, "getSessionID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSessionID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setSessionID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSessionID", "(Ljava/lang/String;)V", "GetSetSessionID_Ljava_lang_String_Handler")]
			set {
				if (id_setSessionID_Ljava_lang_String_ == IntPtr.Zero)
					id_setSessionID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSessionID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSessionID_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionID", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getSessionParams;
#pragma warning disable 0169
		static Delegate GetGetSessionParamsHandler ()
		{
			if (cb_getSessionParams == null)
				cb_getSessionParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionParams);
			return cb_getSessionParams;
		}

		static IntPtr n_GetSessionParams (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionParams);
		}
#pragma warning restore 0169

		static Delegate cb_setSessionParams_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSessionParams_Ljava_lang_String_Handler ()
		{
			if (cb_setSessionParams_Ljava_lang_String_ == null)
				cb_setSessionParams_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSessionParams_Ljava_lang_String_);
			return cb_setSessionParams_Ljava_lang_String_;
		}

		static void n_SetSessionParams_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SessionParams = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionParams;
		static IntPtr id_setSessionParams_Ljava_lang_String_;
		public virtual string SessionParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getSessionParams' and count(parameter)=0]"
			[Register ("getSessionParams", "()Ljava/lang/String;", "GetGetSessionParamsHandler")]
			get {
				if (id_getSessionParams == IntPtr.Zero)
					id_getSessionParams = JNIEnv.GetMethodID (class_ref, "getSessionParams", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSessionParams), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionParams", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setSessionParams' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSessionParams", "(Ljava/lang/String;)V", "GetSetSessionParams_Ljava_lang_String_Handler")]
			set {
				if (id_setSessionParams_Ljava_lang_String_ == IntPtr.Zero)
					id_setSessionParams_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSessionParams", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSessionParams_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionParams", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getUserURL;
#pragma warning disable 0169
		static Delegate GetGetUserURLHandler ()
		{
			if (cb_getUserURL == null)
				cb_getUserURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserURL);
			return cb_getUserURL;
		}

		static IntPtr n_GetUserURL (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserURL);
		}
#pragma warning restore 0169

		static Delegate cb_setUserURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserURL_Ljava_lang_String_Handler ()
		{
			if (cb_setUserURL_Ljava_lang_String_ == null)
				cb_setUserURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserURL_Ljava_lang_String_);
			return cb_setUserURL_Ljava_lang_String_;
		}

		static void n_SetUserURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserURL = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserURL;
		static IntPtr id_setUserURL_Ljava_lang_String_;
		public virtual string UserURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getUserURL' and count(parameter)=0]"
			[Register ("getUserURL", "()Ljava/lang/String;", "GetGetUserURLHandler")]
			get {
				if (id_getUserURL == IntPtr.Zero)
					id_getUserURL = JNIEnv.GetMethodID (class_ref, "getUserURL", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUserURL), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserURL", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setUserURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserURL", "(Ljava/lang/String;)V", "GetSetUserURL_Ljava_lang_String_Handler")]
			set {
				if (id_setUserURL_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserURL", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserURL_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserURL", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_clearIsReferrable;
#pragma warning disable 0169
		static Delegate GetClearIsReferrableHandler ()
		{
			if (cb_clearIsReferrable == null)
				cb_clearIsReferrable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearIsReferrable);
			return cb_clearIsReferrable;
		}

		static void n_ClearIsReferrable (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearIsReferrable ();
		}
#pragma warning restore 0169

		static IntPtr id_clearIsReferrable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='clearIsReferrable' and count(parameter)=0]"
		[Register ("clearIsReferrable", "()V", "GetClearIsReferrableHandler")]
		public virtual void ClearIsReferrable ()
		{
			if (id_clearIsReferrable == IntPtr.Zero)
				id_clearIsReferrable = JNIEnv.GetMethodID (class_ref, "clearIsReferrable", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearIsReferrable);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearIsReferrable", "()V"));
		}

		static Delegate cb_clearUserValues;
#pragma warning disable 0169
		static Delegate GetClearUserValuesHandler ()
		{
			if (cb_clearUserValues == null)
				cb_clearUserValues = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearUserValues);
			return cb_clearUserValues;
		}

		static void n_ClearUserValues (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearUserValues ();
		}
#pragma warning restore 0169

		static IntPtr id_clearUserValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='clearUserValues' and count(parameter)=0]"
		[Register ("clearUserValues", "()V", "GetClearUserValuesHandler")]
		public virtual void ClearUserValues ()
		{
			if (id_clearUserValues == IntPtr.Zero)
				id_clearUserValues = JNIEnv.GetMethodID (class_ref, "clearUserValues", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearUserValues);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearUserValues", "()V"));
		}

		static Delegate cb_getActionTotalCount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetActionTotalCount_Ljava_lang_String_Handler ()
		{
			if (cb_getActionTotalCount_Ljava_lang_String_ == null)
				cb_getActionTotalCount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetActionTotalCount_Ljava_lang_String_);
			return cb_getActionTotalCount_Ljava_lang_String_;
		}

		static int n_GetActionTotalCount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetActionTotalCount (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getActionTotalCount_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getActionTotalCount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getActionTotalCount", "(Ljava/lang/String;)I", "GetGetActionTotalCount_Ljava_lang_String_Handler")]
		public virtual int GetActionTotalCount (string p0)
		{
			if (id_getActionTotalCount_Ljava_lang_String_ == IntPtr.Zero)
				id_getActionTotalCount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getActionTotalCount", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getActionTotalCount_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionTotalCount", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getActionUniqueCount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetActionUniqueCount_Ljava_lang_String_Handler ()
		{
			if (cb_getActionUniqueCount_Ljava_lang_String_ == null)
				cb_getActionUniqueCount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetActionUniqueCount_Ljava_lang_String_);
			return cb_getActionUniqueCount_Ljava_lang_String_;
		}

		static int n_GetActionUniqueCount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetActionUniqueCount (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getActionUniqueCount_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getActionUniqueCount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getActionUniqueCount", "(Ljava/lang/String;)I", "GetGetActionUniqueCount_Ljava_lang_String_Handler")]
		public virtual int GetActionUniqueCount (string p0)
		{
			if (id_getActionUniqueCount_Ljava_lang_String_ == IntPtr.Zero)
				id_getActionUniqueCount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getActionUniqueCount", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getActionUniqueCount_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionUniqueCount", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getBool_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBool_Ljava_lang_String_Handler ()
		{
			if (cb_getBool_Ljava_lang_String_ == null)
				cb_getBool_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetBool_Ljava_lang_String_);
			return cb_getBool_Ljava_lang_String_;
		}

		static bool n_GetBool_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBool (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBool_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getBool' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBool", "(Ljava/lang/String;)Z", "GetGetBool_Ljava_lang_String_Handler")]
		public virtual bool GetBool (string p0)
		{
			if (id_getBool_Ljava_lang_String_ == IntPtr.Zero)
				id_getBool_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBool", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getBool_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBool", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getCreditCount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCreditCount_Ljava_lang_String_Handler ()
		{
			if (cb_getCreditCount_Ljava_lang_String_ == null)
				cb_getCreditCount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetCreditCount_Ljava_lang_String_);
			return cb_getCreditCount_Ljava_lang_String_;
		}

		static int n_GetCreditCount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetCreditCount (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCreditCount_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getCreditCount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCreditCount", "(Ljava/lang/String;)I", "GetGetCreditCount_Ljava_lang_String_Handler")]
		public virtual int GetCreditCount (string p0)
		{
			if (id_getCreditCount_Ljava_lang_String_ == IntPtr.Zero)
				id_getCreditCount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCreditCount", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getCreditCount_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreditCount", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getFloat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFloat_Ljava_lang_String_Handler ()
		{
			if (cb_getFloat_Ljava_lang_String_ == null)
				cb_getFloat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetFloat_Ljava_lang_String_);
			return cb_getFloat_Ljava_lang_String_;
		}

		static float n_GetFloat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetFloat (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFloat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getFloat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFloat", "(Ljava/lang/String;)F", "GetGetFloat_Ljava_lang_String_Handler")]
		public virtual float GetFloat (string p0)
		{
			if (id_getFloat_Ljava_lang_String_ == IntPtr.Zero)
				id_getFloat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFloat", "(Ljava/lang/String;)F");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			float __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallFloatMethod  (Handle, id_getFloat_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFloat", "(Ljava/lang/String;)F"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lio/branch/referral/PrefHelper;", "")]
		public static global::BranchSDK.PrefHelper GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lio/branch/referral/PrefHelper;");
			global::BranchSDK.PrefHelper __ret = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getInteger_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInteger_Ljava_lang_String_Handler ()
		{
			if (cb_getInteger_Ljava_lang_String_ == null)
				cb_getInteger_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetInteger_Ljava_lang_String_);
			return cb_getInteger_Ljava_lang_String_;
		}

		static int n_GetInteger_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInteger (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInteger_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getInteger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInteger", "(Ljava/lang/String;)I", "GetGetInteger_Ljava_lang_String_Handler")]
		public virtual int GetInteger (string p0)
		{
			if (id_getInteger_Ljava_lang_String_ == IntPtr.Zero)
				id_getInteger_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInteger", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getInteger_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInteger", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static long n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)J", "GetGetLong_Ljava_lang_String_Handler")]
		public virtual long GetLong (string p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_getLong_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLong", "(Ljava/lang/String;)J"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setActionTotalCount_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetActionTotalCount_Ljava_lang_String_IHandler ()
		{
			if (cb_setActionTotalCount_Ljava_lang_String_I == null)
				cb_setActionTotalCount_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetActionTotalCount_Ljava_lang_String_I);
			return cb_setActionTotalCount_Ljava_lang_String_I;
		}

		static void n_SetActionTotalCount_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActionTotalCount (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setActionTotalCount_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setActionTotalCount' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setActionTotalCount", "(Ljava/lang/String;I)V", "GetSetActionTotalCount_Ljava_lang_String_IHandler")]
		public virtual void SetActionTotalCount (string p0, int p1)
		{
			if (id_setActionTotalCount_Ljava_lang_String_I == IntPtr.Zero)
				id_setActionTotalCount_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setActionTotalCount", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setActionTotalCount_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionTotalCount", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setActionUniqueCount_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetActionUniqueCount_Ljava_lang_String_IHandler ()
		{
			if (cb_setActionUniqueCount_Ljava_lang_String_I == null)
				cb_setActionUniqueCount_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetActionUniqueCount_Ljava_lang_String_I);
			return cb_setActionUniqueCount_Ljava_lang_String_I;
		}

		static void n_SetActionUniqueCount_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActionUniqueCount (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setActionUniqueCount_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setActionUniqueCount' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setActionUniqueCount", "(Ljava/lang/String;I)V", "GetSetActionUniqueCount_Ljava_lang_String_IHandler")]
		public virtual void SetActionUniqueCount (string p0, int p1)
		{
			if (id_setActionUniqueCount_Ljava_lang_String_I == IntPtr.Zero)
				id_setActionUniqueCount_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setActionUniqueCount", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setActionUniqueCount_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionUniqueCount", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setBool_Ljava_lang_String_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetBool_Ljava_lang_String_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setBool_Ljava_lang_String_Ljava_lang_Boolean_ == null)
				cb_setBool_Ljava_lang_String_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBool_Ljava_lang_String_Ljava_lang_Boolean_);
			return cb_setBool_Ljava_lang_String_Ljava_lang_Boolean_;
		}

		static void n_SetBool_Ljava_lang_String_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetBool (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setBool_Ljava_lang_String_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setBool' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("setBool", "(Ljava/lang/String;Ljava/lang/Boolean;)V", "GetSetBool_Ljava_lang_String_Ljava_lang_Boolean_Handler")]
		public virtual void SetBool (string p0, global::Java.Lang.Boolean p1)
		{
			if (id_setBool_Ljava_lang_String_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setBool_Ljava_lang_String_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setBool", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setBool_Ljava_lang_String_Ljava_lang_Boolean_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBool", "(Ljava/lang/String;Ljava/lang/Boolean;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setCreditCount_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetCreditCount_Ljava_lang_String_IHandler ()
		{
			if (cb_setCreditCount_Ljava_lang_String_I == null)
				cb_setCreditCount_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetCreditCount_Ljava_lang_String_I);
			return cb_setCreditCount_Ljava_lang_String_I;
		}

		static void n_SetCreditCount_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCreditCount (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setCreditCount_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setCreditCount' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setCreditCount", "(Ljava/lang/String;I)V", "GetSetCreditCount_Ljava_lang_String_IHandler")]
		public virtual void SetCreditCount (string p0, int p1)
		{
			if (id_setCreditCount_Ljava_lang_String_I == IntPtr.Zero)
				id_setCreditCount_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setCreditCount", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCreditCount_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreditCount", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setFloat_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetSetFloat_Ljava_lang_String_FHandler ()
		{
			if (cb_setFloat_Ljava_lang_String_F == null)
				cb_setFloat_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_SetFloat_Ljava_lang_String_F);
			return cb_setFloat_Ljava_lang_String_F;
		}

		static void n_SetFloat_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFloat (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setFloat_Ljava_lang_String_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("setFloat", "(Ljava/lang/String;F)V", "GetSetFloat_Ljava_lang_String_FHandler")]
		public virtual void SetFloat (string p0, float p1)
		{
			if (id_setFloat_Ljava_lang_String_F == IntPtr.Zero)
				id_setFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "setFloat", "(Ljava/lang/String;F)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFloat_Ljava_lang_String_F, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloat", "(Ljava/lang/String;F)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setInteger_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetInteger_Ljava_lang_String_IHandler ()
		{
			if (cb_setInteger_Ljava_lang_String_I == null)
				cb_setInteger_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetInteger_Ljava_lang_String_I);
			return cb_setInteger_Ljava_lang_String_I;
		}

		static void n_SetInteger_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInteger (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setInteger_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setInteger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setInteger", "(Ljava/lang/String;I)V", "GetSetInteger_Ljava_lang_String_IHandler")]
		public virtual void SetInteger (string p0, int p1)
		{
			if (id_setInteger_Ljava_lang_String_I == IntPtr.Zero)
				id_setInteger_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setInteger", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInteger_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInteger", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setIsReferrable;
#pragma warning disable 0169
		static Delegate GetSetIsReferrableHandler ()
		{
			if (cb_setIsReferrable == null)
				cb_setIsReferrable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetIsReferrable);
			return cb_setIsReferrable;
		}

		static void n_SetIsReferrable (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIsReferrable ();
		}
#pragma warning restore 0169

		static IntPtr id_setIsReferrable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setIsReferrable' and count(parameter)=0]"
		[Register ("setIsReferrable", "()V", "GetSetIsReferrableHandler")]
		public virtual void SetIsReferrable ()
		{
			if (id_setIsReferrable == IntPtr.Zero)
				id_setIsReferrable = JNIEnv.GetMethodID (class_ref, "setIsReferrable", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setIsReferrable);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsReferrable", "()V"));
		}

		static Delegate cb_setLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetSetLong_Ljava_lang_String_JHandler ()
		{
			if (cb_setLong_Ljava_lang_String_J == null)
				cb_setLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_SetLong_Ljava_lang_String_J);
			return cb_setLong_Ljava_lang_String_J;
		}

		static void n_SetLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLong (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setLong_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("setLong", "(Ljava/lang/String;J)V", "GetSetLong_Ljava_lang_String_JHandler")]
		public virtual void SetLong (string p0, long p1)
		{
			if (id_setLong_Ljava_lang_String_J == IntPtr.Zero)
				id_setLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "setLong", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLong_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLong", "(Ljava/lang/String;J)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetString_Ljava_lang_String_Ljava_lang_String_);
			return cb_setString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BranchSDK.PrefHelper __this = global::Java.Lang.Object.GetObject<global::BranchSDK.PrefHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetString (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='PrefHelper']/method[@name='setString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SetString (string p0, string p1)
		{
			if (id_setString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setString", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
