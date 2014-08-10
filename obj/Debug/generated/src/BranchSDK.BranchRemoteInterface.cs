using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BranchSDK {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']"
	[global::Android.Runtime.Register ("io/branch/referral/BranchRemoteInterface", DoNotGenerateAcw=true)]
	public partial class BranchRemoteInterface : global::BranchSDK.RemoteInterface {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/field[@name='REQ_TAG_COMPLETE_ACTION']"
		[Register ("REQ_TAG_COMPLETE_ACTION")]
		public const string ReqTagCompleteAction = (string) "t_complete_action";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/field[@name='REQ_TAG_GET_CUSTOM_URL']"
		[Register ("REQ_TAG_GET_CUSTOM_URL")]
		public const string ReqTagGetCustomUrl = (string) "t_get_custom_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/field[@name='REQ_TAG_GET_REFERRAL_COUNTS']"
		[Register ("REQ_TAG_GET_REFERRAL_COUNTS")]
		public const string ReqTagGetReferralCounts = (string) "t_get_referral_counts";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/field[@name='REQ_TAG_GET_REWARDS']"
		[Register ("REQ_TAG_GET_REWARDS")]
		public const string ReqTagGetRewards = (string) "t_get_rewards";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/field[@name='REQ_TAG_IDENTIFY']"
		[Register ("REQ_TAG_IDENTIFY")]
		public const string ReqTagIdentify = (string) "t_identify_user";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/field[@name='REQ_TAG_LOGOUT']"
		[Register ("REQ_TAG_LOGOUT")]
		public const string ReqTagLogout = (string) "t_logout";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/field[@name='REQ_TAG_REDEEM_REWARDS']"
		[Register ("REQ_TAG_REDEEM_REWARDS")]
		public const string ReqTagRedeemRewards = (string) "t_redeem_rewards";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/field[@name='REQ_TAG_REGISTER_CLOSE']"
		[Register ("REQ_TAG_REGISTER_CLOSE")]
		public const string ReqTagRegisterClose = (string) "t_register_close";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/field[@name='REQ_TAG_REGISTER_INSTALL']"
		[Register ("REQ_TAG_REGISTER_INSTALL")]
		public const string ReqTagRegisterInstall = (string) "t_register_install";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/field[@name='REQ_TAG_REGISTER_OPEN']"
		[Register ("REQ_TAG_REGISTER_OPEN")]
		public const string ReqTagRegisterOpen = (string) "t_register_open";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/branch/referral/BranchRemoteInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BranchRemoteInterface); }
		}

		protected BranchRemoteInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/constructor[@name='BranchRemoteInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BranchRemoteInterface () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BranchRemoteInterface)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/constructor[@name='BranchRemoteInterface' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public BranchRemoteInterface (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BranchRemoteInterface)) {
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

		static Delegate cb_createCustomUrl_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetCreateCustomUrl_Lorg_json_JSONObject_Handler ()
		{
			if (cb_createCustomUrl_Lorg_json_JSONObject_ == null)
				cb_createCustomUrl_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateCustomUrl_Lorg_json_JSONObject_);
			return cb_createCustomUrl_Lorg_json_JSONObject_;
		}

		static void n_CreateCustomUrl_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateCustomUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_createCustomUrl_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='createCustomUrl' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createCustomUrl", "(Lorg/json/JSONObject;)V", "GetCreateCustomUrl_Lorg_json_JSONObject_Handler")]
		public virtual void CreateCustomUrl (global::Org.Json.JSONObject p0)
		{
			if (id_createCustomUrl_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_createCustomUrl_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "createCustomUrl", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_createCustomUrl_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createCustomUrl", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

		static Delegate cb_getReferralCounts;
#pragma warning disable 0169
		static Delegate GetGetReferralCountsHandler ()
		{
			if (cb_getReferralCounts == null)
				cb_getReferralCounts = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetReferralCounts);
			return cb_getReferralCounts;
		}

		static void n_GetReferralCounts (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetReferralCounts ();
		}
#pragma warning restore 0169

		static IntPtr id_getReferralCounts;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='getReferralCounts' and count(parameter)=0]"
		[Register ("getReferralCounts", "()V", "GetGetReferralCountsHandler")]
		public virtual void GetReferralCounts ()
		{
			if (id_getReferralCounts == IntPtr.Zero)
				id_getReferralCounts = JNIEnv.GetMethodID (class_ref, "getReferralCounts", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getReferralCounts);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReferralCounts", "()V"));
		}

		static Delegate cb_getRewards;
#pragma warning disable 0169
		static Delegate GetGetRewardsHandler ()
		{
			if (cb_getRewards == null)
				cb_getRewards = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetRewards);
			return cb_getRewards;
		}

		static void n_GetRewards (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetRewards ();
		}
#pragma warning restore 0169

		static IntPtr id_getRewards;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='getRewards' and count(parameter)=0]"
		[Register ("getRewards", "()V", "GetGetRewardsHandler")]
		public virtual void GetRewards ()
		{
			if (id_getRewards == IntPtr.Zero)
				id_getRewards = JNIEnv.GetMethodID (class_ref, "getRewards", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getRewards);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRewards", "()V"));
		}

		static Delegate cb_identifyUser_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetIdentifyUser_Lorg_json_JSONObject_Handler ()
		{
			if (cb_identifyUser_Lorg_json_JSONObject_ == null)
				cb_identifyUser_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_IdentifyUser_Lorg_json_JSONObject_);
			return cb_identifyUser_Lorg_json_JSONObject_;
		}

		static void n_IdentifyUser_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IdentifyUser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_identifyUser_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='identifyUser' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("identifyUser", "(Lorg/json/JSONObject;)V", "GetIdentifyUser_Lorg_json_JSONObject_Handler")]
		public virtual void IdentifyUser (global::Org.Json.JSONObject p0)
		{
			if (id_identifyUser_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_identifyUser_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "identifyUser", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_identifyUser_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "identifyUser", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

		static Delegate cb_logoutUser_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetLogoutUser_Lorg_json_JSONObject_Handler ()
		{
			if (cb_logoutUser_Lorg_json_JSONObject_ == null)
				cb_logoutUser_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LogoutUser_Lorg_json_JSONObject_);
			return cb_logoutUser_Lorg_json_JSONObject_;
		}

		static void n_LogoutUser_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LogoutUser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logoutUser_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='logoutUser' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("logoutUser", "(Lorg/json/JSONObject;)V", "GetLogoutUser_Lorg_json_JSONObject_Handler")]
		public virtual void LogoutUser (global::Org.Json.JSONObject p0)
		{
			if (id_logoutUser_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_logoutUser_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "logoutUser", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logoutUser_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logoutUser", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

		static Delegate cb_redeemRewards_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetRedeemRewards_Lorg_json_JSONObject_Handler ()
		{
			if (cb_redeemRewards_Lorg_json_JSONObject_ == null)
				cb_redeemRewards_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RedeemRewards_Lorg_json_JSONObject_);
			return cb_redeemRewards_Lorg_json_JSONObject_;
		}

		static void n_RedeemRewards_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RedeemRewards (p0);
		}
#pragma warning restore 0169

		static IntPtr id_redeemRewards_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='redeemRewards' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("redeemRewards", "(Lorg/json/JSONObject;)V", "GetRedeemRewards_Lorg_json_JSONObject_Handler")]
		public virtual void RedeemRewards (global::Org.Json.JSONObject p0)
		{
			if (id_redeemRewards_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_redeemRewards_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "redeemRewards", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_redeemRewards_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "redeemRewards", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

		static Delegate cb_registerClose;
#pragma warning disable 0169
		static Delegate GetRegisterCloseHandler ()
		{
			if (cb_registerClose == null)
				cb_registerClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterClose);
			return cb_registerClose;
		}

		static void n_RegisterClose (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterClose ();
		}
#pragma warning restore 0169

		static IntPtr id_registerClose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='registerClose' and count(parameter)=0]"
		[Register ("registerClose", "()V", "GetRegisterCloseHandler")]
		public virtual void RegisterClose ()
		{
			if (id_registerClose == IntPtr.Zero)
				id_registerClose = JNIEnv.GetMethodID (class_ref, "registerClose", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerClose);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerClose", "()V"));
		}

		static Delegate cb_registerInstall_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterInstall_Ljava_lang_String_Handler ()
		{
			if (cb_registerInstall_Ljava_lang_String_ == null)
				cb_registerInstall_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterInstall_Ljava_lang_String_);
			return cb_registerInstall_Ljava_lang_String_;
		}

		static void n_RegisterInstall_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterInstall (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerInstall_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='registerInstall' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerInstall", "(Ljava/lang/String;)V", "GetRegisterInstall_Ljava_lang_String_Handler")]
		public virtual void RegisterInstall (string p0)
		{
			if (id_registerInstall_Ljava_lang_String_ == IntPtr.Zero)
				id_registerInstall_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerInstall", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerInstall_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerInstall", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_registerOpen;
#pragma warning disable 0169
		static Delegate GetRegisterOpenHandler ()
		{
			if (cb_registerOpen == null)
				cb_registerOpen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterOpen);
			return cb_registerOpen;
		}

		static void n_RegisterOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterOpen ();
		}
#pragma warning restore 0169

		static IntPtr id_registerOpen;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='registerOpen' and count(parameter)=0]"
		[Register ("registerOpen", "()V", "GetRegisterOpenHandler")]
		public virtual void RegisterOpen ()
		{
			if (id_registerOpen == IntPtr.Zero)
				id_registerOpen = JNIEnv.GetMethodID (class_ref, "registerOpen", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerOpen);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerOpen", "()V"));
		}

		static Delegate cb_setNetworkCallbackListener_Lio_branch_referral_NetworkCallback_;
#pragma warning disable 0169
		static Delegate GetSetNetworkCallbackListener_Lio_branch_referral_NetworkCallback_Handler ()
		{
			if (cb_setNetworkCallbackListener_Lio_branch_referral_NetworkCallback_ == null)
				cb_setNetworkCallbackListener_Lio_branch_referral_NetworkCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetworkCallbackListener_Lio_branch_referral_NetworkCallback_);
			return cb_setNetworkCallbackListener_Lio_branch_referral_NetworkCallback_;
		}

		static void n_SetNetworkCallbackListener_Lio_branch_referral_NetworkCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.INetworkCallback p0 = (global::BranchSDK.INetworkCallback)global::Java.Lang.Object.GetObject<global::BranchSDK.INetworkCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNetworkCallbackListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNetworkCallbackListener_Lio_branch_referral_NetworkCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='setNetworkCallbackListener' and count(parameter)=1 and parameter[1][@type='io.branch.referral.NetworkCallback']]"
		[Register ("setNetworkCallbackListener", "(Lio/branch/referral/NetworkCallback;)V", "GetSetNetworkCallbackListener_Lio_branch_referral_NetworkCallback_Handler")]
		public virtual void SetNetworkCallbackListener (global::BranchSDK.INetworkCallback p0)
		{
			if (id_setNetworkCallbackListener_Lio_branch_referral_NetworkCallback_ == IntPtr.Zero)
				id_setNetworkCallbackListener_Lio_branch_referral_NetworkCallback_ = JNIEnv.GetMethodID (class_ref, "setNetworkCallbackListener", "(Lio/branch/referral/NetworkCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNetworkCallbackListener_Lio_branch_referral_NetworkCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkCallbackListener", "(Lio/branch/referral/NetworkCallback;)V"), new JValue (p0));
		}

		static Delegate cb_userCompletedAction_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetUserCompletedAction_Lorg_json_JSONObject_Handler ()
		{
			if (cb_userCompletedAction_Lorg_json_JSONObject_ == null)
				cb_userCompletedAction_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UserCompletedAction_Lorg_json_JSONObject_);
			return cb_userCompletedAction_Lorg_json_JSONObject_;
		}

		static void n_UserCompletedAction_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.BranchRemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.BranchRemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserCompletedAction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_userCompletedAction_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='BranchRemoteInterface']/method[@name='userCompletedAction' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("userCompletedAction", "(Lorg/json/JSONObject;)V", "GetUserCompletedAction_Lorg_json_JSONObject_Handler")]
		public virtual void UserCompletedAction (global::Org.Json.JSONObject p0)
		{
			if (id_userCompletedAction_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_userCompletedAction_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "userCompletedAction", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_userCompletedAction_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "userCompletedAction", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

	}
}
