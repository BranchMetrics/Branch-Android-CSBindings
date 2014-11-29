using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BranchSDK {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']"
	[global::Android.Runtime.Register ("io/branch/referral/ServerRequestQueue", DoNotGenerateAcw=true)]
	public partial class ServerRequestQueue : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/branch/referral/ServerRequestQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServerRequestQueue); }
		}

		protected ServerRequestQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.ServerRequestQueue __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public virtual int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSize);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()I"));
			}
		}

		static Delegate cb_containsInstallOrOpen;
#pragma warning disable 0169
		static Delegate GetContainsInstallOrOpenHandler ()
		{
			if (cb_containsInstallOrOpen == null)
				cb_containsInstallOrOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ContainsInstallOrOpen);
			return cb_containsInstallOrOpen;
		}

		static bool n_ContainsInstallOrOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.ServerRequestQueue __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContainsInstallOrOpen ();
		}
#pragma warning restore 0169

		static IntPtr id_containsInstallOrOpen;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']/method[@name='containsInstallOrOpen' and count(parameter)=0]"
		[Register ("containsInstallOrOpen", "()Z", "GetContainsInstallOrOpenHandler")]
		public virtual bool ContainsInstallOrOpen ()
		{
			if (id_containsInstallOrOpen == IntPtr.Zero)
				id_containsInstallOrOpen = JNIEnv.GetMethodID (class_ref, "containsInstallOrOpen", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_containsInstallOrOpen);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsInstallOrOpen", "()Z"));
		}

		static Delegate cb_dequeue;
#pragma warning disable 0169
		static Delegate GetDequeueHandler ()
		{
			if (cb_dequeue == null)
				cb_dequeue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Dequeue);
			return cb_dequeue;
		}

		static IntPtr n_Dequeue (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.ServerRequestQueue __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dequeue ());
		}
#pragma warning restore 0169

		static IntPtr id_dequeue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']/method[@name='dequeue' and count(parameter)=0]"
		[Register ("dequeue", "()Lio/branch/referral/ServerRequest;", "GetDequeueHandler")]
		public virtual global::BranchSDK.ServerRequest Dequeue ()
		{
			if (id_dequeue == IntPtr.Zero)
				id_dequeue = JNIEnv.GetMethodID (class_ref, "dequeue", "()Lio/branch/referral/ServerRequest;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequest> (JNIEnv.CallObjectMethod  (Handle, id_dequeue), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dequeue", "()Lio/branch/referral/ServerRequest;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_enqueue_Lio_branch_referral_ServerRequest_;
#pragma warning disable 0169
		static Delegate GetEnqueue_Lio_branch_referral_ServerRequest_Handler ()
		{
			if (cb_enqueue_Lio_branch_referral_ServerRequest_ == null)
				cb_enqueue_Lio_branch_referral_ServerRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Enqueue_Lio_branch_referral_ServerRequest_);
			return cb_enqueue_Lio_branch_referral_ServerRequest_;
		}

		static void n_Enqueue_Lio_branch_referral_ServerRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.ServerRequestQueue __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.ServerRequest p0 = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Enqueue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enqueue_Lio_branch_referral_ServerRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']/method[@name='enqueue' and count(parameter)=1 and parameter[1][@type='io.branch.referral.ServerRequest']]"
		[Register ("enqueue", "(Lio/branch/referral/ServerRequest;)V", "GetEnqueue_Lio_branch_referral_ServerRequest_Handler")]
		public virtual void Enqueue (global::BranchSDK.ServerRequest p0)
		{
			if (id_enqueue_Lio_branch_referral_ServerRequest_ == IntPtr.Zero)
				id_enqueue_Lio_branch_referral_ServerRequest_ = JNIEnv.GetMethodID (class_ref, "enqueue", "(Lio/branch/referral/ServerRequest;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enqueue_Lio_branch_referral_ServerRequest_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enqueue", "(Lio/branch/referral/ServerRequest;)V"), new JValue (p0));
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lio/branch/referral/ServerRequestQueue;", "")]
		public static global::BranchSDK.ServerRequestQueue GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lio/branch/referral/ServerRequestQueue;");
			global::BranchSDK.ServerRequestQueue __ret = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequestQueue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_insert_Lio_branch_referral_ServerRequest_I;
#pragma warning disable 0169
		static Delegate GetInsert_Lio_branch_referral_ServerRequest_IHandler ()
		{
			if (cb_insert_Lio_branch_referral_ServerRequest_I == null)
				cb_insert_Lio_branch_referral_ServerRequest_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Insert_Lio_branch_referral_ServerRequest_I);
			return cb_insert_Lio_branch_referral_ServerRequest_I;
		}

		static void n_Insert_Lio_branch_referral_ServerRequest_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BranchSDK.ServerRequestQueue __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::BranchSDK.ServerRequest p0 = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_insert_Lio_branch_referral_ServerRequest_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='io.branch.referral.ServerRequest'] and parameter[2][@type='int']]"
		[Register ("insert", "(Lio/branch/referral/ServerRequest;I)V", "GetInsert_Lio_branch_referral_ServerRequest_IHandler")]
		public virtual void Insert (global::BranchSDK.ServerRequest p0, int p1)
		{
			if (id_insert_Lio_branch_referral_ServerRequest_I == IntPtr.Zero)
				id_insert_Lio_branch_referral_ServerRequest_I = JNIEnv.GetMethodID (class_ref, "insert", "(Lio/branch/referral/ServerRequest;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_insert_Lio_branch_referral_ServerRequest_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Lio/branch/referral/ServerRequest;I)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_moveInstallOrOpenToFront_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetMoveInstallOrOpenToFront_Ljava_lang_String_IHandler ()
		{
			if (cb_moveInstallOrOpenToFront_Ljava_lang_String_I == null)
				cb_moveInstallOrOpenToFront_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_MoveInstallOrOpenToFront_Ljava_lang_String_I);
			return cb_moveInstallOrOpenToFront_Ljava_lang_String_I;
		}

		static void n_MoveInstallOrOpenToFront_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BranchSDK.ServerRequestQueue __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveInstallOrOpenToFront (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_moveInstallOrOpenToFront_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']/method[@name='moveInstallOrOpenToFront' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("moveInstallOrOpenToFront", "(Ljava/lang/String;I)V", "GetMoveInstallOrOpenToFront_Ljava_lang_String_IHandler")]
		public virtual void MoveInstallOrOpenToFront (string p0, int p1)
		{
			if (id_moveInstallOrOpenToFront_Ljava_lang_String_I == IntPtr.Zero)
				id_moveInstallOrOpenToFront_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "moveInstallOrOpenToFront", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_moveInstallOrOpenToFront_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveInstallOrOpenToFront", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			global::BranchSDK.ServerRequestQueue __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Peek ());
		}
#pragma warning restore 0169

		static IntPtr id_peek;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Lio/branch/referral/ServerRequest;", "GetPeekHandler")]
		public virtual global::BranchSDK.ServerRequest Peek ()
		{
			if (id_peek == IntPtr.Zero)
				id_peek = JNIEnv.GetMethodID (class_ref, "peek", "()Lio/branch/referral/ServerRequest;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequest> (JNIEnv.CallObjectMethod  (Handle, id_peek), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peek", "()Lio/branch/referral/ServerRequest;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_peekAt_I;
#pragma warning disable 0169
		static Delegate GetPeekAt_IHandler ()
		{
			if (cb_peekAt_I == null)
				cb_peekAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PeekAt_I);
			return cb_peekAt_I;
		}

		static IntPtr n_PeekAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BranchSDK.ServerRequestQueue __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_peekAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']/method[@name='peekAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("peekAt", "(I)Lio/branch/referral/ServerRequest;", "GetPeekAt_IHandler")]
		public virtual global::BranchSDK.ServerRequest PeekAt (int p0)
		{
			if (id_peekAt_I == IntPtr.Zero)
				id_peekAt_I = JNIEnv.GetMethodID (class_ref, "peekAt", "(I)Lio/branch/referral/ServerRequest;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequest> (JNIEnv.CallObjectMethod  (Handle, id_peekAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekAt", "(I)Lio/branch/referral/ServerRequest;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveAt_IHandler ()
		{
			if (cb_removeAt_I == null)
				cb_removeAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RemoveAt_I);
			return cb_removeAt_I;
		}

		static IntPtr n_RemoveAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BranchSDK.ServerRequestQueue __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_removeAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ServerRequestQueue']/method[@name='removeAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeAt", "(I)Lio/branch/referral/ServerRequest;", "GetRemoveAt_IHandler")]
		public virtual global::BranchSDK.ServerRequest RemoveAt (int p0)
		{
			if (id_removeAt_I == IntPtr.Zero)
				id_removeAt_I = JNIEnv.GetMethodID (class_ref, "removeAt", "(I)Lio/branch/referral/ServerRequest;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequest> (JNIEnv.CallObjectMethod  (Handle, id_removeAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::BranchSDK.ServerRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAt", "(I)Lio/branch/referral/ServerRequest;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
