using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BranchSDK {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']"
	[global::Android.Runtime.Register ("io/branch/referral/ApkParser", DoNotGenerateAcw=true)]
	public partial class ApkParser : global::Java.Lang.Object {


		static IntPtr endDocTag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']/field[@name='endDocTag']"
		[Register ("endDocTag")]
		public static int EndDocTag {
			get {
				if (endDocTag_jfieldId == IntPtr.Zero)
					endDocTag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "endDocTag", "I");
				return JNIEnv.GetStaticIntField (class_ref, endDocTag_jfieldId);
			}
			set {
				if (endDocTag_jfieldId == IntPtr.Zero)
					endDocTag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "endDocTag", "I");
				JNIEnv.SetStaticField (class_ref, endDocTag_jfieldId, value);
			}
		}

		static IntPtr endTag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']/field[@name='endTag']"
		[Register ("endTag")]
		public static int EndTag {
			get {
				if (endTag_jfieldId == IntPtr.Zero)
					endTag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "endTag", "I");
				return JNIEnv.GetStaticIntField (class_ref, endTag_jfieldId);
			}
			set {
				if (endTag_jfieldId == IntPtr.Zero)
					endTag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "endTag", "I");
				JNIEnv.SetStaticField (class_ref, endTag_jfieldId, value);
			}
		}

		static IntPtr spaces_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']/field[@name='spaces']"
		[Register ("spaces")]
		public static string Spaces {
			get {
				if (spaces_jfieldId == IntPtr.Zero)
					spaces_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "spaces", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, spaces_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (spaces_jfieldId == IntPtr.Zero)
					spaces_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "spaces", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, spaces_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr startTag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']/field[@name='startTag']"
		[Register ("startTag")]
		public static int StartTag {
			get {
				if (startTag_jfieldId == IntPtr.Zero)
					startTag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "startTag", "I");
				return JNIEnv.GetStaticIntField (class_ref, startTag_jfieldId);
			}
			set {
				if (startTag_jfieldId == IntPtr.Zero)
					startTag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "startTag", "I");
				JNIEnv.SetStaticField (class_ref, startTag_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/branch/referral/ApkParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApkParser); }
		}

		protected ApkParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']/constructor[@name='ApkParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ApkParser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ApkParser)) {
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

		static Delegate cb_LEW_arrayBI;
#pragma warning disable 0169
		static Delegate GetLEW_arrayBIHandler ()
		{
			if (cb_LEW_arrayBI == null)
				cb_LEW_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_LEW_arrayBI);
			return cb_LEW_arrayBI;
		}

		static int n_LEW_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BranchSDK.ApkParser __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ApkParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.LEW (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_LEW_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']/method[@name='LEW' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("LEW", "([BI)I", "GetLEW_arrayBIHandler")]
		public virtual int LEW (byte[] p0, int p1)
		{
			if (id_LEW_arrayBI == IntPtr.Zero)
				id_LEW_arrayBI = JNIEnv.GetMethodID (class_ref, "LEW", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_LEW_arrayBI, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LEW", "([BI)I"), new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_compXmlString_arrayBIII;
#pragma warning disable 0169
		static Delegate GetCompXmlString_arrayBIIIHandler ()
		{
			if (cb_compXmlString_arrayBIII == null)
				cb_compXmlString_arrayBIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, IntPtr>) n_CompXmlString_arrayBIII);
			return cb_compXmlString_arrayBIII;
		}

		static IntPtr n_CompXmlString_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::BranchSDK.ApkParser __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ApkParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.CompXmlString (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compXmlString_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']/method[@name='compXmlString' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("compXmlString", "([BIII)Ljava/lang/String;", "GetCompXmlString_arrayBIIIHandler")]
		public virtual string CompXmlString (byte[] p0, int p1, int p2, int p3)
		{
			if (id_compXmlString_arrayBIII == IntPtr.Zero)
				id_compXmlString_arrayBIII = JNIEnv.GetMethodID (class_ref, "compXmlString", "([BIII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_compXmlString_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compXmlString", "([BIII)Ljava/lang/String;"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_compXmlStringAt_arrayBI;
#pragma warning disable 0169
		static Delegate GetCompXmlStringAt_arrayBIHandler ()
		{
			if (cb_compXmlStringAt_arrayBI == null)
				cb_compXmlStringAt_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CompXmlStringAt_arrayBI);
			return cb_compXmlStringAt_arrayBI;
		}

		static IntPtr n_CompXmlStringAt_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BranchSDK.ApkParser __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ApkParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.CompXmlStringAt (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compXmlStringAt_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']/method[@name='compXmlStringAt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("compXmlStringAt", "([BI)Ljava/lang/String;", "GetCompXmlStringAt_arrayBIHandler")]
		public virtual string CompXmlStringAt (byte[] p0, int p1)
		{
			if (id_compXmlStringAt_arrayBI == IntPtr.Zero)
				id_compXmlStringAt_arrayBI = JNIEnv.GetMethodID (class_ref, "compXmlStringAt", "([BI)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_compXmlStringAt_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compXmlStringAt", "([BI)Ljava/lang/String;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_decompressXML_arrayB;
#pragma warning disable 0169
		static Delegate GetDecompressXML_arrayBHandler ()
		{
			if (cb_decompressXML_arrayB == null)
				cb_decompressXML_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecompressXML_arrayB);
			return cb_decompressXML_arrayB;
		}

		static IntPtr n_DecompressXML_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BranchSDK.ApkParser __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ApkParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.DecompressXML (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decompressXML_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']/method[@name='decompressXML' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decompressXML", "([B)Ljava/lang/String;", "GetDecompressXML_arrayBHandler")]
		public virtual string DecompressXML (byte[] p0)
		{
			if (id_decompressXML_arrayB == IntPtr.Zero)
				id_decompressXML_arrayB = JNIEnv.GetMethodID (class_ref, "decompressXML", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_decompressXML_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decompressXML", "([B)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_prtIndent_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrtIndent_ILjava_lang_String_Handler ()
		{
			if (cb_prtIndent_ILjava_lang_String_ == null)
				cb_prtIndent_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_PrtIndent_ILjava_lang_String_);
			return cb_prtIndent_ILjava_lang_String_;
		}

		static void n_PrtIndent_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::BranchSDK.ApkParser __this = global::Java.Lang.Object.GetObject<global::BranchSDK.ApkParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrtIndent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_prtIndent_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='ApkParser']/method[@name='prtIndent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("prtIndent", "(ILjava/lang/String;)V", "GetPrtIndent_ILjava_lang_String_Handler")]
		public virtual void PrtIndent (int p0, string p1)
		{
			if (id_prtIndent_ILjava_lang_String_ == IntPtr.Zero)
				id_prtIndent_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "prtIndent", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_prtIndent_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prtIndent", "(ILjava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
