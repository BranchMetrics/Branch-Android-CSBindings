using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BranchSDK {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='RemoteInterface']"
	[global::Android.Runtime.Register ("io/branch/referral/RemoteInterface", DoNotGenerateAcw=true)]
	public partial class RemoteInterface : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='RemoteInterface']/field[@name='KEY_SERVER_CALL_STATUS_CODE']"
		[Register ("KEY_SERVER_CALL_STATUS_CODE")]
		public const string KeyServerCallStatusCode = (string) "httpcode";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='RemoteInterface']/field[@name='KEY_SERVER_CALL_TAG']"
		[Register ("KEY_SERVER_CALL_TAG")]
		public const string KeyServerCallTag = (string) "server_call_tag";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='RemoteInterface']/field[@name='NO_TAG_VALUE']"
		[Register ("NO_TAG_VALUE")]
		public const string NoTagValue = (string) "no_tag";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/branch/referral/RemoteInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RemoteInterface); }
		}

		protected RemoteInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.branch.referral']/class[@name='RemoteInterface']/constructor[@name='RemoteInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RemoteInterface () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RemoteInterface)) {
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

		static Delegate cb_make_restful_get_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMake_restful_get_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_make_restful_get_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_make_restful_get_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Make_restful_get_Ljava_lang_String_Ljava_lang_String_);
			return cb_make_restful_get_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Make_restful_get_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BranchSDK.RemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.RemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Make_restful_get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_make_restful_get_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='RemoteInterface']/method[@name='make_restful_get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("make_restful_get", "(Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;", "GetMake_restful_get_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Org.Json.JSONObject Make_restful_get (string p0, string p1)
		{
			if (id_make_restful_get_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_make_restful_get_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "make_restful_get", "(Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Org.Json.JSONObject __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_make_restful_get_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "make_restful_get", "(Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_make_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMake_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_make_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_make_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Make_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_);
			return cb_make_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Make_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::BranchSDK.RemoteInterface __this = global::Java.Lang.Object.GetObject<global::BranchSDK.RemoteInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Make_restful_post (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_make_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='RemoteInterface']/method[@name='make_restful_post' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("make_restful_post", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;", "GetMake_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Org.Json.JSONObject Make_restful_post (global::Org.Json.JSONObject p0, string p1, string p2)
		{
			if (id_make_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_make_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "make_restful_post", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			global::Org.Json.JSONObject __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_make_restful_post_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "make_restful_post", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;"), new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}
}
