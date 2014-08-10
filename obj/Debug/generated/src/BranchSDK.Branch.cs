using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BranchSDK {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']"
	[global::Android.Runtime.Register ("io/branch/referral/Branch", DoNotGenerateAcw=true)]
	public partial class Branch : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='io.branch.referral']/interface[@name='Branch.BranchLinkCreateListener']"
		[Register ("io/branch/referral/Branch$BranchLinkCreateListener", "", "BranchSDK.Branch/IBranchLinkCreateListenerInvoker")]
		public partial interface IBranchLinkCreateListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/interface[@name='Branch.BranchLinkCreateListener']/method[@name='onLinkCreate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onLinkCreate", "(Ljava/lang/String;)V", "GetOnLinkCreate_Ljava_lang_String_Handler:BranchSDK.Branch/IBranchLinkCreateListenerInvoker, Branch-Android-CSBindings")]
			void OnLinkCreate (string p0);

		}

		[global::Android.Runtime.Register ("io/branch/referral/Branch$BranchLinkCreateListener", DoNotGenerateAcw=true)]
		internal class IBranchLinkCreateListenerInvoker : global::Java.Lang.Object, IBranchLinkCreateListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("io/branch/referral/Branch$BranchLinkCreateListener");
			IntPtr class_ref;

			public static IBranchLinkCreateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBranchLinkCreateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "io.branch.referral.Branch.BranchLinkCreateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBranchLinkCreateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IBranchLinkCreateListenerInvoker); }
			}

			static Delegate cb_onLinkCreate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnLinkCreate_Ljava_lang_String_Handler ()
			{
				if (cb_onLinkCreate_Ljava_lang_String_ == null)
					cb_onLinkCreate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLinkCreate_Ljava_lang_String_);
				return cb_onLinkCreate_Ljava_lang_String_;
			}

			static void n_OnLinkCreate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::BranchSDK.Branch.IBranchLinkCreateListener __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchLinkCreateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLinkCreate (p0);
			}
#pragma warning restore 0169

			IntPtr id_onLinkCreate_Ljava_lang_String_;
			public void OnLinkCreate (string p0)
			{
				if (id_onLinkCreate_Ljava_lang_String_ == IntPtr.Zero)
					id_onLinkCreate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onLinkCreate", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_onLinkCreate_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class BranchLinkCreateEventArgs : global::System.EventArgs {

			public BranchLinkCreateEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/io/branch/referral/Branch_BranchLinkCreateListenerImplementor")]
		internal sealed class IBranchLinkCreateListenerImplementor : global::Java.Lang.Object, IBranchLinkCreateListener {

			object sender;

			public IBranchLinkCreateListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/io/branch/referral/Branch_BranchLinkCreateListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BranchLinkCreateEventArgs> Handler;
#pragma warning restore 0649

			public void OnLinkCreate (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new BranchLinkCreateEventArgs (p0));
			}

			internal static bool __IsEmpty (IBranchLinkCreateListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='io.branch.referral']/interface[@name='Branch.BranchReferralInitListener']"
		[Register ("io/branch/referral/Branch$BranchReferralInitListener", "", "BranchSDK.Branch/IBranchReferralInitListenerInvoker")]
		public partial interface IBranchReferralInitListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/interface[@name='Branch.BranchReferralInitListener']/method[@name='onInitFinished' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("onInitFinished", "(Lorg/json/JSONObject;)V", "GetOnInitFinished_Lorg_json_JSONObject_Handler:BranchSDK.Branch/IBranchReferralInitListenerInvoker, Branch-Android-CSBindings")]
			void OnInitFinished (global::Org.Json.JSONObject p0);

		}

		[global::Android.Runtime.Register ("io/branch/referral/Branch$BranchReferralInitListener", DoNotGenerateAcw=true)]
		internal class IBranchReferralInitListenerInvoker : global::Java.Lang.Object, IBranchReferralInitListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("io/branch/referral/Branch$BranchReferralInitListener");
			IntPtr class_ref;

			public static IBranchReferralInitListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBranchReferralInitListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "io.branch.referral.Branch.BranchReferralInitListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBranchReferralInitListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IBranchReferralInitListenerInvoker); }
			}

			static Delegate cb_onInitFinished_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetOnInitFinished_Lorg_json_JSONObject_Handler ()
			{
				if (cb_onInitFinished_Lorg_json_JSONObject_ == null)
					cb_onInitFinished_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInitFinished_Lorg_json_JSONObject_);
				return cb_onInitFinished_Lorg_json_JSONObject_;
			}

			static void n_OnInitFinished_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::BranchSDK.Branch.IBranchReferralInitListener __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchReferralInitListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInitFinished (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInitFinished_Lorg_json_JSONObject_;
			public void OnInitFinished (global::Org.Json.JSONObject p0)
			{
				if (id_onInitFinished_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_onInitFinished_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onInitFinished", "(Lorg/json/JSONObject;)V");
				JNIEnv.CallVoidMethod (Handle, id_onInitFinished_Lorg_json_JSONObject_, new JValue (p0));
			}

		}

		public partial class BranchReferralInitEventArgs : global::System.EventArgs {

			public BranchReferralInitEventArgs (global::Org.Json.JSONObject p0)
			{
				this.p0 = p0;
			}

			global::Org.Json.JSONObject p0;
			public global::Org.Json.JSONObject P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/io/branch/referral/Branch_BranchReferralInitListenerImplementor")]
		internal sealed class IBranchReferralInitListenerImplementor : global::Java.Lang.Object, IBranchReferralInitListener {

			object sender;

			public IBranchReferralInitListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/io/branch/referral/Branch_BranchReferralInitListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BranchReferralInitEventArgs> Handler;
#pragma warning restore 0649

			public void OnInitFinished (global::Org.Json.JSONObject p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new BranchReferralInitEventArgs (p0));
			}

			internal static bool __IsEmpty (IBranchReferralInitListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='io.branch.referral']/interface[@name='Branch.BranchReferralStateChangedListener']"
		[Register ("io/branch/referral/Branch$BranchReferralStateChangedListener", "", "BranchSDK.Branch/IBranchReferralStateChangedListenerInvoker")]
		public partial interface IBranchReferralStateChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/interface[@name='Branch.BranchReferralStateChangedListener']/method[@name='onStateChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onStateChanged", "(Z)V", "GetOnStateChanged_ZHandler:BranchSDK.Branch/IBranchReferralStateChangedListenerInvoker, Branch-Android-CSBindings")]
			void OnStateChanged (bool p0);

		}

		[global::Android.Runtime.Register ("io/branch/referral/Branch$BranchReferralStateChangedListener", DoNotGenerateAcw=true)]
		internal class IBranchReferralStateChangedListenerInvoker : global::Java.Lang.Object, IBranchReferralStateChangedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("io/branch/referral/Branch$BranchReferralStateChangedListener");
			IntPtr class_ref;

			public static IBranchReferralStateChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBranchReferralStateChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "io.branch.referral.Branch.BranchReferralStateChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBranchReferralStateChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IBranchReferralStateChangedListenerInvoker); }
			}

			static Delegate cb_onStateChanged_Z;
#pragma warning disable 0169
			static Delegate GetOnStateChanged_ZHandler ()
			{
				if (cb_onStateChanged_Z == null)
					cb_onStateChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnStateChanged_Z);
				return cb_onStateChanged_Z;
			}

			static void n_OnStateChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::BranchSDK.Branch.IBranchReferralStateChangedListener __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchReferralStateChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStateChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStateChanged_Z;
			public void OnStateChanged (bool p0)
			{
				if (id_onStateChanged_Z == IntPtr.Zero)
					id_onStateChanged_Z = JNIEnv.GetMethodID (class_ref, "onStateChanged", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_onStateChanged_Z, new JValue (p0));
			}

		}

		public partial class BranchReferralStateChangedEventArgs : global::System.EventArgs {

			public BranchReferralStateChangedEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/io/branch/referral/Branch_BranchReferralStateChangedListenerImplementor")]
		internal sealed class IBranchReferralStateChangedListenerImplementor : global::Java.Lang.Object, IBranchReferralStateChangedListener {

			object sender;

			public IBranchReferralStateChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/io/branch/referral/Branch_BranchReferralStateChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BranchReferralStateChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnStateChanged (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new BranchReferralStateChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IBranchReferralStateChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch.ReferralNetworkCallback']"
		[global::Android.Runtime.Register ("io/branch/referral/Branch$ReferralNetworkCallback", DoNotGenerateAcw=true)]
		public partial class ReferralNetworkCallback : global::Java.Lang.Object, global::BranchSDK.INetworkCallback {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/branch/referral/Branch$ReferralNetworkCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ReferralNetworkCallback); }
			}

			protected ReferralNetworkCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lio_branch_referral_Branch_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch.ReferralNetworkCallback']/constructor[@name='Branch.ReferralNetworkCallback' and count(parameter)=1 and parameter[1][@type='io.branch.referral.Branch']]"
			[Register (".ctor", "(Lio/branch/referral/Branch;)V", "")]
			public ReferralNetworkCallback (global::BranchSDK.Branch __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ReferralNetworkCallback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lio_branch_referral_Branch_ == IntPtr.Zero)
					id_ctor_Lio_branch_referral_Branch_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/branch/referral/Branch;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_branch_referral_Branch_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lio_branch_referral_Branch_, new JValue (__self));
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
				global::BranchSDK.Branch.ReferralNetworkCallback __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.ReferralNetworkCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Finished (p0);
			}
#pragma warning restore 0169

			static IntPtr id_finished_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch.ReferralNetworkCallback']/method[@name='finished' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("finished", "(Lorg/json/JSONObject;)V", "GetFinished_Lorg_json_JSONObject_Handler")]
			public virtual void Finished (global::Org.Json.JSONObject p0)
			{
				if (id_finished_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_finished_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "finished", "(Lorg/json/JSONObject;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_finished_Lorg_json_JSONObject_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finished", "(Lorg/json/JSONObject;)V"), new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/branch/referral/Branch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Branch); }
		}

		protected Branch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCredits;
#pragma warning disable 0169
		static Delegate GetGetCreditsHandler ()
		{
			if (cb_getCredits == null)
				cb_getCredits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCredits);
			return cb_getCredits;
		}

		static int n_GetCredits (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Credits;
		}
#pragma warning restore 0169

		static IntPtr id_getCredits;
		public virtual int Credits {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getCredits' and count(parameter)=0]"
			[Register ("getCredits", "()I", "GetGetCreditsHandler")]
			get {
				if (id_getCredits == IntPtr.Zero)
					id_getCredits = JNIEnv.GetMethodID (class_ref, "getCredits", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCredits);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCredits", "()I"));
			}
		}

		static Delegate cb_hasIdentity;
#pragma warning disable 0169
		static Delegate GetHasIdentityHandler ()
		{
			if (cb_hasIdentity == null)
				cb_hasIdentity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasIdentity);
			return cb_hasIdentity;
		}

		static bool n_HasIdentity (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasIdentity;
		}
#pragma warning restore 0169

		static IntPtr id_hasIdentity;
		public virtual bool HasIdentity {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='hasIdentity' and count(parameter)=0]"
			[Register ("hasIdentity", "()Z", "GetHasIdentityHandler")]
			get {
				if (id_hasIdentity == IntPtr.Zero)
					id_hasIdentity = JNIEnv.GetMethodID (class_ref, "hasIdentity", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasIdentity);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasIdentity", "()Z"));
			}
		}

		static Delegate cb_getInstallReferringParams;
#pragma warning disable 0169
		static Delegate GetGetInstallReferringParamsHandler ()
		{
			if (cb_getInstallReferringParams == null)
				cb_getInstallReferringParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInstallReferringParams);
			return cb_getInstallReferringParams;
		}

		static IntPtr n_GetInstallReferringParams (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InstallReferringParams);
		}
#pragma warning restore 0169

		static IntPtr id_getInstallReferringParams;
		public virtual global::Org.Json.JSONObject InstallReferringParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getInstallReferringParams' and count(parameter)=0]"
			[Register ("getInstallReferringParams", "()Lorg/json/JSONObject;", "GetGetInstallReferringParamsHandler")]
			get {
				if (id_getInstallReferringParams == IntPtr.Zero)
					id_getInstallReferringParams = JNIEnv.GetMethodID (class_ref, "getInstallReferringParams", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getInstallReferringParams), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInstallReferringParams", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLongURL;
#pragma warning disable 0169
		static Delegate GetGetLongURLHandler ()
		{
			if (cb_getLongURL == null)
				cb_getLongURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLongURL);
			return cb_getLongURL;
		}

		static IntPtr n_GetLongURL (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LongURL);
		}
#pragma warning restore 0169

		static IntPtr id_getLongURL;
		public virtual string LongURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getLongURL' and count(parameter)=0]"
			[Register ("getLongURL", "()Ljava/lang/String;", "GetGetLongURLHandler")]
			get {
				if (id_getLongURL == IntPtr.Zero)
					id_getLongURL = JNIEnv.GetMethodID (class_ref, "getLongURL", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLongURL), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongURL", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReferringParams;
#pragma warning disable 0169
		static Delegate GetGetReferringParamsHandler ()
		{
			if (cb_getReferringParams == null)
				cb_getReferringParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReferringParams);
			return cb_getReferringParams;
		}

		static IntPtr n_GetReferringParams (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReferringParams);
		}
#pragma warning restore 0169

		static IntPtr id_getReferringParams;
		public virtual global::Org.Json.JSONObject ReferringParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getReferringParams' and count(parameter)=0]"
			[Register ("getReferringParams", "()Lorg/json/JSONObject;", "GetGetReferringParamsHandler")]
			get {
				if (id_getReferringParams == IntPtr.Zero)
					id_getReferringParams = JNIEnv.GetMethodID (class_ref, "getReferringParams", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getReferringParams), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReferringParams", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clearUser;
#pragma warning disable 0169
		static Delegate GetClearUserHandler ()
		{
			if (cb_clearUser == null)
				cb_clearUser = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearUser);
			return cb_clearUser;
		}

		static void n_ClearUser (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearUser ();
		}
#pragma warning restore 0169

		static IntPtr id_clearUser;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='clearUser' and count(parameter)=0]"
		[Register ("clearUser", "()V", "GetClearUserHandler")]
		public virtual void ClearUser ()
		{
			if (id_clearUser == IntPtr.Zero)
				id_clearUser = JNIEnv.GetMethodID (class_ref, "clearUser", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearUser);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearUser", "()V"));
		}

		static Delegate cb_closeSession;
#pragma warning disable 0169
		static Delegate GetCloseSessionHandler ()
		{
			if (cb_closeSession == null)
				cb_closeSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseSession);
			return cb_closeSession;
		}

		static void n_CloseSession (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseSession ();
		}
#pragma warning restore 0169

		static IntPtr id_closeSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='closeSession' and count(parameter)=0]"
		[Register ("closeSession", "()V", "GetCloseSessionHandler")]
		public virtual void CloseSession ()
		{
			if (id_closeSession == IntPtr.Zero)
				id_closeSession = JNIEnv.GetMethodID (class_ref, "closeSession", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_closeSession);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeSession", "()V"));
		}

		static Delegate cb_getCreditsForBucket_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCreditsForBucket_Ljava_lang_String_Handler ()
		{
			if (cb_getCreditsForBucket_Ljava_lang_String_ == null)
				cb_getCreditsForBucket_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetCreditsForBucket_Ljava_lang_String_);
			return cb_getCreditsForBucket_Ljava_lang_String_;
		}

		static int n_GetCreditsForBucket_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetCreditsForBucket (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCreditsForBucket_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getCreditsForBucket' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCreditsForBucket", "(Ljava/lang/String;)I", "GetGetCreditsForBucket_Ljava_lang_String_Handler")]
		public virtual int GetCreditsForBucket (string p0)
		{
			if (id_getCreditsForBucket_Ljava_lang_String_ == IntPtr.Zero)
				id_getCreditsForBucket_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCreditsForBucket", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getCreditsForBucket_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreditsForBucket", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lio/branch/referral/Branch;", "")]
		public static global::BranchSDK.Branch GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lio/branch/referral/Branch;");
			global::BranchSDK.Branch __ret = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getInstance_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInstance", "(Landroid/content/Context;Ljava/lang/String;)Lio/branch/referral/Branch;", "")]
		public static global::BranchSDK.Branch GetInstance (global::Android.Content.Context p0, string p1)
		{
			if (id_getInstance_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Ljava/lang/String;)Lio/branch/referral/Branch;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::BranchSDK.Branch __ret = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getLongURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLongURL_Ljava_lang_String_Handler ()
		{
			if (cb_getLongURL_Ljava_lang_String_ == null)
				cb_getLongURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLongURL_Ljava_lang_String_);
			return cb_getLongURL_Ljava_lang_String_;
		}

		static IntPtr n_GetLongURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLongURL (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLongURL_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getLongURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLongURL", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLongURL_Ljava_lang_String_Handler")]
		public virtual string GetLongURL (string p0)
		{
			if (id_getLongURL_Ljava_lang_String_ == IntPtr.Zero)
				id_getLongURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLongURL", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLongURL_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongURL", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLongURL_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetLongURL_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getLongURL_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_getLongURL_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLongURL_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_getLongURL_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetLongURL_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLongURL (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLongURL_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getLongURL' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getLongURL", "(Ljava/lang/String;Lorg/json/JSONObject;)Ljava/lang/String;", "GetGetLongURL_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public virtual string GetLongURL (string p0, global::Org.Json.JSONObject p1)
		{
			if (id_getLongURL_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getLongURL_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getLongURL", "(Ljava/lang/String;Lorg/json/JSONObject;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLongURL_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongURL", "(Ljava/lang/String;Lorg/json/JSONObject;)Ljava/lang/String;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLongURL_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetLongURL_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getLongURL_Lorg_json_JSONObject_ == null)
				cb_getLongURL_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLongURL_Lorg_json_JSONObject_);
			return cb_getLongURL_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetLongURL_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLongURL (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLongURL_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getLongURL' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getLongURL", "(Lorg/json/JSONObject;)Ljava/lang/String;", "GetGetLongURL_Lorg_json_JSONObject_Handler")]
		public virtual string GetLongURL (global::Org.Json.JSONObject p0)
		{
			if (id_getLongURL_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getLongURL_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getLongURL", "(Lorg/json/JSONObject;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLongURL_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongURL", "(Lorg/json/JSONObject;)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_;
#pragma warning disable 0169
		static Delegate GetGetShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_Handler ()
		{
			if (cb_getShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_ == null)
				cb_getShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_);
			return cb_getShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_;
		}

		static void n_GetShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchLinkCreateListener p0 = (global::BranchSDK.Branch.IBranchLinkCreateListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchLinkCreateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetShortUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getShortUrl' and count(parameter)=1 and parameter[1][@type='io.branch.referral.Branch.BranchLinkCreateListener']]"
		[Register ("getShortUrl", "(Lio/branch/referral/Branch$BranchLinkCreateListener;)V", "GetGetShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_Handler")]
		public virtual void GetShortUrl (global::BranchSDK.Branch.IBranchLinkCreateListener p0)
		{
			if (id_getShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_ == IntPtr.Zero)
				id_getShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_ = JNIEnv.GetMethodID (class_ref, "getShortUrl", "(Lio/branch/referral/Branch$BranchLinkCreateListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getShortUrl_Lio_branch_referral_Branch_BranchLinkCreateListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShortUrl", "(Lio/branch/referral/Branch$BranchLinkCreateListener;)V"), new JValue (p0));
		}

		static Delegate cb_getShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_;
#pragma warning disable 0169
		static Delegate GetGetShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_Handler ()
		{
			if (cb_getShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_ == null)
				cb_getShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_);
			return cb_getShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_;
		}

		static void n_GetShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchLinkCreateListener p1 = (global::BranchSDK.Branch.IBranchLinkCreateListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchLinkCreateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetShortUrl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getShortUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='io.branch.referral.Branch.BranchLinkCreateListener']]"
		[Register ("getShortUrl", "(Ljava/lang/String;Lio/branch/referral/Branch$BranchLinkCreateListener;)V", "GetGetShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_Handler")]
		public virtual void GetShortUrl (string p0, global::BranchSDK.Branch.IBranchLinkCreateListener p1)
		{
			if (id_getShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_ == IntPtr.Zero)
				id_getShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_ = JNIEnv.GetMethodID (class_ref, "getShortUrl", "(Ljava/lang/String;Lio/branch/referral/Branch$BranchLinkCreateListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getShortUrl_Ljava_lang_String_Lio_branch_referral_Branch_BranchLinkCreateListener_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShortUrl", "(Ljava/lang/String;Lio/branch/referral/Branch$BranchLinkCreateListener;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_;
#pragma warning disable 0169
		static Delegate GetGetShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_Handler ()
		{
			if (cb_getShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_ == null)
				cb_getShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_);
			return cb_getShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_;
		}

		static void n_GetShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchLinkCreateListener p2 = (global::BranchSDK.Branch.IBranchLinkCreateListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchLinkCreateListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetShortUrl (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_getShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getShortUrl' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='io.branch.referral.Branch.BranchLinkCreateListener']]"
		[Register ("getShortUrl", "(Ljava/lang/String;Lorg/json/JSONObject;Lio/branch/referral/Branch$BranchLinkCreateListener;)V", "GetGetShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_Handler")]
		public virtual void GetShortUrl (string p0, global::Org.Json.JSONObject p1, global::BranchSDK.Branch.IBranchLinkCreateListener p2)
		{
			if (id_getShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_ == IntPtr.Zero)
				id_getShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_ = JNIEnv.GetMethodID (class_ref, "getShortUrl", "(Ljava/lang/String;Lorg/json/JSONObject;Lio/branch/referral/Branch$BranchLinkCreateListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getShortUrl_Ljava_lang_String_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShortUrl", "(Ljava/lang/String;Lorg/json/JSONObject;Lio/branch/referral/Branch$BranchLinkCreateListener;)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_;
#pragma warning disable 0169
		static Delegate GetGetShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_Handler ()
		{
			if (cb_getShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_ == null)
				cb_getShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_);
			return cb_getShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_;
		}

		static void n_GetShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchLinkCreateListener p1 = (global::BranchSDK.Branch.IBranchLinkCreateListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchLinkCreateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetShortUrl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getShortUrl' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='io.branch.referral.Branch.BranchLinkCreateListener']]"
		[Register ("getShortUrl", "(Lorg/json/JSONObject;Lio/branch/referral/Branch$BranchLinkCreateListener;)V", "GetGetShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_Handler")]
		public virtual void GetShortUrl (global::Org.Json.JSONObject p0, global::BranchSDK.Branch.IBranchLinkCreateListener p1)
		{
			if (id_getShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_ == IntPtr.Zero)
				id_getShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_ = JNIEnv.GetMethodID (class_ref, "getShortUrl", "(Lorg/json/JSONObject;Lio/branch/referral/Branch$BranchLinkCreateListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getShortUrl_Lorg_json_JSONObject_Lio_branch_referral_Branch_BranchLinkCreateListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShortUrl", "(Lorg/json/JSONObject;Lio/branch/referral/Branch$BranchLinkCreateListener;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getTotalCountsForAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTotalCountsForAction_Ljava_lang_String_Handler ()
		{
			if (cb_getTotalCountsForAction_Ljava_lang_String_ == null)
				cb_getTotalCountsForAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetTotalCountsForAction_Ljava_lang_String_);
			return cb_getTotalCountsForAction_Ljava_lang_String_;
		}

		static int n_GetTotalCountsForAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetTotalCountsForAction (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalCountsForAction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getTotalCountsForAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTotalCountsForAction", "(Ljava/lang/String;)I", "GetGetTotalCountsForAction_Ljava_lang_String_Handler")]
		public virtual int GetTotalCountsForAction (string p0)
		{
			if (id_getTotalCountsForAction_Ljava_lang_String_ == IntPtr.Zero)
				id_getTotalCountsForAction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTotalCountsForAction", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getTotalCountsForAction_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalCountsForAction", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getUniqueCountsForAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUniqueCountsForAction_Ljava_lang_String_Handler ()
		{
			if (cb_getUniqueCountsForAction_Ljava_lang_String_ == null)
				cb_getUniqueCountsForAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetUniqueCountsForAction_Ljava_lang_String_);
			return cb_getUniqueCountsForAction_Ljava_lang_String_;
		}

		static int n_GetUniqueCountsForAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetUniqueCountsForAction (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUniqueCountsForAction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='getUniqueCountsForAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUniqueCountsForAction", "(Ljava/lang/String;)I", "GetGetUniqueCountsForAction_Ljava_lang_String_Handler")]
		public virtual int GetUniqueCountsForAction (string p0)
		{
			if (id_getUniqueCountsForAction_Ljava_lang_String_ == IntPtr.Zero)
				id_getUniqueCountsForAction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getUniqueCountsForAction", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getUniqueCountsForAction_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUniqueCountsForAction", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_identifyUser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIdentifyUser_Ljava_lang_String_Handler ()
		{
			if (cb_identifyUser_Ljava_lang_String_ == null)
				cb_identifyUser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_IdentifyUser_Ljava_lang_String_);
			return cb_identifyUser_Ljava_lang_String_;
		}

		static void n_IdentifyUser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IdentifyUser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_identifyUser_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='identifyUser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("identifyUser", "(Ljava/lang/String;)V", "GetIdentifyUser_Ljava_lang_String_Handler")]
		public virtual void IdentifyUser (string p0)
		{
			if (id_identifyUser_Ljava_lang_String_ == IntPtr.Zero)
				id_identifyUser_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "identifyUser", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_identifyUser_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "identifyUser", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_identifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_;
#pragma warning disable 0169
		static Delegate GetIdentifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_Handler ()
		{
			if (cb_identifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_ == null)
				cb_identifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_IdentifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_);
			return cb_identifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_;
		}

		static void n_IdentifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchReferralInitListener p1 = (global::BranchSDK.Branch.IBranchReferralInitListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchReferralInitListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.IdentifyUser (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_identifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='identifyUser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='io.branch.referral.Branch.BranchReferralInitListener']]"
		[Register ("identifyUser", "(Ljava/lang/String;Lio/branch/referral/Branch$BranchReferralInitListener;)V", "GetIdentifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_Handler")]
		public virtual void IdentifyUser (string p0, global::BranchSDK.Branch.IBranchReferralInitListener p1)
		{
			if (id_identifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_ == IntPtr.Zero)
				id_identifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_ = JNIEnv.GetMethodID (class_ref, "identifyUser", "(Ljava/lang/String;Lio/branch/referral/Branch$BranchReferralInitListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_identifyUser_Ljava_lang_String_Lio_branch_referral_Branch_BranchReferralInitListener_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "identifyUser", "(Ljava/lang/String;Lio/branch/referral/Branch$BranchReferralInitListener;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_initUserSession;
#pragma warning disable 0169
		static Delegate GetInitUserSessionHandler ()
		{
			if (cb_initUserSession == null)
				cb_initUserSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitUserSession);
			return cb_initUserSession;
		}

		static void n_InitUserSession (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitUserSession ();
		}
#pragma warning restore 0169

		static IntPtr id_initUserSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='initUserSession' and count(parameter)=0]"
		[Register ("initUserSession", "()V", "GetInitUserSessionHandler")]
		public virtual void InitUserSession ()
		{
			if (id_initUserSession == IntPtr.Zero)
				id_initUserSession = JNIEnv.GetMethodID (class_ref, "initUserSession", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initUserSession);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initUserSession", "()V"));
		}

		static Delegate cb_initUserSession_Z;
#pragma warning disable 0169
		static Delegate GetInitUserSession_ZHandler ()
		{
			if (cb_initUserSession_Z == null)
				cb_initUserSession_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_InitUserSession_Z);
			return cb_initUserSession_Z;
		}

		static void n_InitUserSession_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitUserSession (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initUserSession_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='initUserSession' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("initUserSession", "(Z)V", "GetInitUserSession_ZHandler")]
		public virtual void InitUserSession (bool p0)
		{
			if (id_initUserSession_Z == IntPtr.Zero)
				id_initUserSession_Z = JNIEnv.GetMethodID (class_ref, "initUserSession", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initUserSession_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initUserSession", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_;
#pragma warning disable 0169
		static Delegate GetInitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Handler ()
		{
			if (cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ == null)
				cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_);
			return cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_;
		}

		static void n_InitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchReferralInitListener p0 = (global::BranchSDK.Branch.IBranchReferralInitListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchReferralInitListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitUserSession (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='initUserSession' and count(parameter)=1 and parameter[1][@type='io.branch.referral.Branch.BranchReferralInitListener']]"
		[Register ("initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;)V", "GetInitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Handler")]
		public virtual void InitUserSession (global::BranchSDK.Branch.IBranchReferralInitListener p0)
		{
			if (id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ == IntPtr.Zero)
				id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ = JNIEnv.GetMethodID (class_ref, "initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;)V"), new JValue (p0));
		}

		static Delegate cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetInitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_Handler ()
		{
			if (cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_ == null)
				cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_);
			return cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_;
		}

		static void n_InitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchReferralInitListener p0 = (global::BranchSDK.Branch.IBranchReferralInitListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchReferralInitListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InitUserSession (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='initUserSession' and count(parameter)=2 and parameter[1][@type='io.branch.referral.Branch.BranchReferralInitListener'] and parameter[2][@type='android.net.Uri']]"
		[Register ("initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;Landroid/net/Uri;)V", "GetInitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_Handler")]
		public virtual void InitUserSession (global::BranchSDK.Branch.IBranchReferralInitListener p0, global::Android.Net.Uri p1)
		{
			if (id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_ == IntPtr.Zero)
				id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;Landroid/net/Uri;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;Landroid/net/Uri;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Z;
#pragma warning disable 0169
		static Delegate GetInitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZHandler ()
		{
			if (cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Z == null)
				cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_InitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Z);
			return cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Z;
		}

		static void n_InitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchReferralInitListener p0 = (global::BranchSDK.Branch.IBranchReferralInitListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchReferralInitListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitUserSession (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='initUserSession' and count(parameter)=2 and parameter[1][@type='io.branch.referral.Branch.BranchReferralInitListener'] and parameter[2][@type='boolean']]"
		[Register ("initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;Z)V", "GetInitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZHandler")]
		public virtual void InitUserSession (global::BranchSDK.Branch.IBranchReferralInitListener p0, bool p1)
		{
			if (id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Z == IntPtr.Zero)
				id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Z = JNIEnv.GetMethodID (class_ref, "initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetInitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_Handler ()
		{
			if (cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_ == null)
				cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_InitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_);
			return cb_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_;
		}

		static void n_InitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchReferralInitListener p0 = (global::BranchSDK.Branch.IBranchReferralInitListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchReferralInitListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p2 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.InitUserSession (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='initUserSession' and count(parameter)=3 and parameter[1][@type='io.branch.referral.Branch.BranchReferralInitListener'] and parameter[2][@type='boolean'] and parameter[3][@type='android.net.Uri']]"
		[Register ("initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;ZLandroid/net/Uri;)V", "GetInitUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_Handler")]
		public virtual void InitUserSession (global::BranchSDK.Branch.IBranchReferralInitListener p0, bool p1, global::Android.Net.Uri p2)
		{
			if (id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_ == IntPtr.Zero)
				id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;ZLandroid/net/Uri;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initUserSession_Lio_branch_referral_Branch_BranchReferralInitListener_ZLandroid_net_Uri_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initUserSession", "(Lio/branch/referral/Branch$BranchReferralInitListener;ZLandroid/net/Uri;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_initUserSessionWithData_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetInitUserSessionWithData_Landroid_net_Uri_Handler ()
		{
			if (cb_initUserSessionWithData_Landroid_net_Uri_ == null)
				cb_initUserSessionWithData_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitUserSessionWithData_Landroid_net_Uri_);
			return cb_initUserSessionWithData_Landroid_net_Uri_;
		}

		static void n_InitUserSessionWithData_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitUserSessionWithData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initUserSessionWithData_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='initUserSessionWithData' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("initUserSessionWithData", "(Landroid/net/Uri;)V", "GetInitUserSessionWithData_Landroid_net_Uri_Handler")]
		public virtual void InitUserSessionWithData (global::Android.Net.Uri p0)
		{
			if (id_initUserSessionWithData_Landroid_net_Uri_ == IntPtr.Zero)
				id_initUserSessionWithData_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "initUserSessionWithData", "(Landroid/net/Uri;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initUserSessionWithData_Landroid_net_Uri_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initUserSessionWithData", "(Landroid/net/Uri;)V"), new JValue (p0));
		}

		static Delegate cb_loadActionCounts;
#pragma warning disable 0169
		static Delegate GetLoadActionCountsHandler ()
		{
			if (cb_loadActionCounts == null)
				cb_loadActionCounts = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadActionCounts);
			return cb_loadActionCounts;
		}

		static void n_LoadActionCounts (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadActionCounts ();
		}
#pragma warning restore 0169

		static IntPtr id_loadActionCounts;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='loadActionCounts' and count(parameter)=0]"
		[Register ("loadActionCounts", "()V", "GetLoadActionCountsHandler")]
		public virtual void LoadActionCounts ()
		{
			if (id_loadActionCounts == IntPtr.Zero)
				id_loadActionCounts = JNIEnv.GetMethodID (class_ref, "loadActionCounts", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadActionCounts);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadActionCounts", "()V"));
		}

		static Delegate cb_loadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_;
#pragma warning disable 0169
		static Delegate GetLoadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_Handler ()
		{
			if (cb_loadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_ == null)
				cb_loadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_);
			return cb_loadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_;
		}

		static void n_LoadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchReferralStateChangedListener p0 = (global::BranchSDK.Branch.IBranchReferralStateChangedListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchReferralStateChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadActionCounts (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='loadActionCounts' and count(parameter)=1 and parameter[1][@type='io.branch.referral.Branch.BranchReferralStateChangedListener']]"
		[Register ("loadActionCounts", "(Lio/branch/referral/Branch$BranchReferralStateChangedListener;)V", "GetLoadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_Handler")]
		public virtual void LoadActionCounts (global::BranchSDK.Branch.IBranchReferralStateChangedListener p0)
		{
			if (id_loadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_ == IntPtr.Zero)
				id_loadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_ = JNIEnv.GetMethodID (class_ref, "loadActionCounts", "(Lio/branch/referral/Branch$BranchReferralStateChangedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadActionCounts_Lio_branch_referral_Branch_BranchReferralStateChangedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadActionCounts", "(Lio/branch/referral/Branch$BranchReferralStateChangedListener;)V"), new JValue (p0));
		}

		static Delegate cb_loadRewards;
#pragma warning disable 0169
		static Delegate GetLoadRewardsHandler ()
		{
			if (cb_loadRewards == null)
				cb_loadRewards = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadRewards);
			return cb_loadRewards;
		}

		static void n_LoadRewards (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadRewards ();
		}
#pragma warning restore 0169

		static IntPtr id_loadRewards;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='loadRewards' and count(parameter)=0]"
		[Register ("loadRewards", "()V", "GetLoadRewardsHandler")]
		public virtual void LoadRewards ()
		{
			if (id_loadRewards == IntPtr.Zero)
				id_loadRewards = JNIEnv.GetMethodID (class_ref, "loadRewards", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadRewards);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadRewards", "()V"));
		}

		static Delegate cb_loadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_;
#pragma warning disable 0169
		static Delegate GetLoadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_Handler ()
		{
			if (cb_loadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_ == null)
				cb_loadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_);
			return cb_loadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_;
		}

		static void n_LoadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.Branch.IBranchReferralStateChangedListener p0 = (global::BranchSDK.Branch.IBranchReferralStateChangedListener)global::Java.Lang.Object.GetObject<global::BranchSDK.Branch.IBranchReferralStateChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadRewards (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='loadRewards' and count(parameter)=1 and parameter[1][@type='io.branch.referral.Branch.BranchReferralStateChangedListener']]"
		[Register ("loadRewards", "(Lio/branch/referral/Branch$BranchReferralStateChangedListener;)V", "GetLoadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_Handler")]
		public virtual void LoadRewards (global::BranchSDK.Branch.IBranchReferralStateChangedListener p0)
		{
			if (id_loadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_ == IntPtr.Zero)
				id_loadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_ = JNIEnv.GetMethodID (class_ref, "loadRewards", "(Lio/branch/referral/Branch$BranchReferralStateChangedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadRewards_Lio_branch_referral_Branch_BranchReferralStateChangedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadRewards", "(Lio/branch/referral/Branch$BranchReferralStateChangedListener;)V"), new JValue (p0));
		}

		static Delegate cb_redeemRewards_I;
#pragma warning disable 0169
		static Delegate GetRedeemRewards_IHandler ()
		{
			if (cb_redeemRewards_I == null)
				cb_redeemRewards_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RedeemRewards_I);
			return cb_redeemRewards_I;
		}

		static void n_RedeemRewards_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RedeemRewards (p0);
		}
#pragma warning restore 0169

		static IntPtr id_redeemRewards_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='redeemRewards' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("redeemRewards", "(I)V", "GetRedeemRewards_IHandler")]
		public virtual void RedeemRewards (int p0)
		{
			if (id_redeemRewards_I == IntPtr.Zero)
				id_redeemRewards_I = JNIEnv.GetMethodID (class_ref, "redeemRewards", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_redeemRewards_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "redeemRewards", "(I)V"), new JValue (p0));
		}

		static Delegate cb_redeemRewards_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetRedeemRewards_Ljava_lang_String_IHandler ()
		{
			if (cb_redeemRewards_Ljava_lang_String_I == null)
				cb_redeemRewards_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_RedeemRewards_Ljava_lang_String_I);
			return cb_redeemRewards_Ljava_lang_String_I;
		}

		static void n_RedeemRewards_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RedeemRewards (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_redeemRewards_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='redeemRewards' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("redeemRewards", "(Ljava/lang/String;I)V", "GetRedeemRewards_Ljava_lang_String_IHandler")]
		public virtual void RedeemRewards (string p0, int p1)
		{
			if (id_redeemRewards_Ljava_lang_String_I == IntPtr.Zero)
				id_redeemRewards_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "redeemRewards", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_redeemRewards_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "redeemRewards", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_resetUserSession;
#pragma warning disable 0169
		static Delegate GetResetUserSessionHandler ()
		{
			if (cb_resetUserSession == null)
				cb_resetUserSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetUserSession);
			return cb_resetUserSession;
		}

		static void n_ResetUserSession (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetUserSession ();
		}
#pragma warning restore 0169

		static IntPtr id_resetUserSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='resetUserSession' and count(parameter)=0]"
		[Register ("resetUserSession", "()V", "GetResetUserSessionHandler")]
		public virtual void ResetUserSession ()
		{
			if (id_resetUserSession == IntPtr.Zero)
				id_resetUserSession = JNIEnv.GetMethodID (class_ref, "resetUserSession", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resetUserSession);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetUserSession", "()V"));
		}

		static Delegate cb_userCompletedAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUserCompletedAction_Ljava_lang_String_Handler ()
		{
			if (cb_userCompletedAction_Ljava_lang_String_ == null)
				cb_userCompletedAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UserCompletedAction_Ljava_lang_String_);
			return cb_userCompletedAction_Ljava_lang_String_;
		}

		static void n_UserCompletedAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserCompletedAction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_userCompletedAction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='userCompletedAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("userCompletedAction", "(Ljava/lang/String;)V", "GetUserCompletedAction_Ljava_lang_String_Handler")]
		public virtual void UserCompletedAction (string p0)
		{
			if (id_userCompletedAction_Ljava_lang_String_ == IntPtr.Zero)
				id_userCompletedAction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "userCompletedAction", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_userCompletedAction_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "userCompletedAction", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_userCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetUserCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_userCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_userCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UserCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_userCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static void n_UserCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BranchSDK.Branch __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Branch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UserCompletedAction (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_userCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Branch']/method[@name='userCompletedAction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("userCompletedAction", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "GetUserCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public virtual void UserCompletedAction (string p0, global::Org.Json.JSONObject p1)
		{
			if (id_userCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_userCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "userCompletedAction", "(Ljava/lang/String;Lorg/json/JSONObject;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_userCompletedAction_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "userCompletedAction", "(Ljava/lang/String;Lorg/json/JSONObject;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
