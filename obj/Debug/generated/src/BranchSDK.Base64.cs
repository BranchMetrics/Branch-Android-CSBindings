using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BranchSDK {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']"
	[global::Android.Runtime.Register ("io/branch/referral/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/field[@name='CRLF']"
		[Register ("CRLF")]
		public const int Crlf = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public const int Default = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/field[@name='NO_CLOSE']"
		[Register ("NO_CLOSE")]
		public const int NoClose = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/field[@name='NO_PADDING']"
		[Register ("NO_PADDING")]
		public const int NoPadding = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/field[@name='NO_WRAP']"
		[Register ("NO_WRAP")]
		public const int NoWrap = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/field[@name='URL_SAFE']"
		[Register ("URL_SAFE")]
		public const int UrlSafe = (int) 8;
		// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Coder']"
		[global::Android.Runtime.Register ("io/branch/referral/Base64$Coder", DoNotGenerateAcw=true)]
		public abstract partial class Coder : global::Java.Lang.Object {


			static IntPtr op_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Coder']/field[@name='op']"
			[Register ("op")]
			public int Op {
				get {
					if (op_jfieldId == IntPtr.Zero)
						op_jfieldId = JNIEnv.GetFieldID (class_ref, "op", "I");
					return JNIEnv.GetIntField (Handle, op_jfieldId);
				}
				set {
					if (op_jfieldId == IntPtr.Zero)
						op_jfieldId = JNIEnv.GetFieldID (class_ref, "op", "I");
					JNIEnv.SetField (Handle, op_jfieldId, value);
				}
			}

			static IntPtr output_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Coder']/field[@name='output']"
			[Register ("output")]
			public IList<byte> Output {
				get {
					if (output_jfieldId == IntPtr.Zero)
						output_jfieldId = JNIEnv.GetFieldID (class_ref, "output", "[B");
					return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, output_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (output_jfieldId == IntPtr.Zero)
						output_jfieldId = JNIEnv.GetFieldID (class_ref, "output", "[B");
					IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, output_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/branch/referral/Base64$Coder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Coder); }
			}

			protected Coder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_maxOutputSize_I;
#pragma warning disable 0169
			static Delegate GetMaxOutputSize_IHandler ()
			{
				if (cb_maxOutputSize_I == null)
					cb_maxOutputSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_MaxOutputSize_I);
				return cb_maxOutputSize_I;
			}

			static int n_MaxOutputSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::BranchSDK.Base64.Coder __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Base64.Coder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxOutputSize (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Coder']/method[@name='maxOutputSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("maxOutputSize", "(I)I", "GetMaxOutputSize_IHandler")]
			public abstract int MaxOutputSize (int p0);

			static Delegate cb_process_arrayBIIZ;
#pragma warning disable 0169
			static Delegate GetProcess_arrayBIIZHandler ()
			{
				if (cb_process_arrayBIIZ == null)
					cb_process_arrayBIIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool, bool>) n_Process_arrayBIIZ);
				return cb_process_arrayBIIZ;
			}

			static bool n_Process_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
			{
				global::BranchSDK.Base64.Coder __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Base64.Coder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.Process (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Coder']/method[@name='process' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("process", "([BIIZ)Z", "GetProcess_arrayBIIZHandler")]
			public abstract bool Process (byte[] p0, int p1, int p2, bool p3);

		}

		[global::Android.Runtime.Register ("io/branch/referral/Base64$Coder", DoNotGenerateAcw=true)]
		internal partial class CoderInvoker : Coder {

			public CoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (CoderInvoker); }
			}

			static IntPtr id_maxOutputSize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Coder']/method[@name='maxOutputSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("maxOutputSize", "(I)I", "GetMaxOutputSize_IHandler")]
			public override int MaxOutputSize (int p0)
			{
				if (id_maxOutputSize_I == IntPtr.Zero)
					id_maxOutputSize_I = JNIEnv.GetMethodID (class_ref, "maxOutputSize", "(I)I");
				return JNIEnv.CallIntMethod  (Handle, id_maxOutputSize_I, new JValue (p0));
			}

			static IntPtr id_process_arrayBIIZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Coder']/method[@name='process' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("process", "([BIIZ)Z", "GetProcess_arrayBIIZHandler")]
			public override bool Process (byte[] p0, int p1, int p2, bool p3)
			{
				if (id_process_arrayBIIZ == IntPtr.Zero)
					id_process_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "process", "([BIIZ)Z");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_process_arrayBIIZ, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Decoder']"
		[global::Android.Runtime.Register ("io/branch/referral/Base64$Decoder", DoNotGenerateAcw=true)]
		public partial class Decoder : global::BranchSDK.Base64.Coder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/branch/referral/Base64$Decoder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Decoder); }
			}

			protected Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IarrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Decoder']/constructor[@name='Base64.Decoder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register (".ctor", "(I[B)V", "")]
			public Decoder (int p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);;
				if (GetType () != typeof (Decoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I[B)V", new JValue (p0), new JValue (native_p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I[B)V", new JValue (p0), new JValue (native_p1));
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					return;
				}

				if (id_ctor_IarrayB == IntPtr.Zero)
					id_ctor_IarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(I[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayB, new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IarrayB, new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_maxOutputSize_I;
#pragma warning disable 0169
			static Delegate GetMaxOutputSize_IHandler ()
			{
				if (cb_maxOutputSize_I == null)
					cb_maxOutputSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_MaxOutputSize_I);
				return cb_maxOutputSize_I;
			}

			static int n_MaxOutputSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::BranchSDK.Base64.Decoder __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Base64.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxOutputSize (p0);
			}
#pragma warning restore 0169

			static IntPtr id_maxOutputSize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Decoder']/method[@name='maxOutputSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("maxOutputSize", "(I)I", "GetMaxOutputSize_IHandler")]
			public override int MaxOutputSize (int p0)
			{
				if (id_maxOutputSize_I == IntPtr.Zero)
					id_maxOutputSize_I = JNIEnv.GetMethodID (class_ref, "maxOutputSize", "(I)I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_maxOutputSize_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maxOutputSize", "(I)I"), new JValue (p0));
			}

			static Delegate cb_process_arrayBIIZ;
#pragma warning disable 0169
			static Delegate GetProcess_arrayBIIZHandler ()
			{
				if (cb_process_arrayBIIZ == null)
					cb_process_arrayBIIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool, bool>) n_Process_arrayBIIZ);
				return cb_process_arrayBIIZ;
			}

			static bool n_Process_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
			{
				global::BranchSDK.Base64.Decoder __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Base64.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.Process (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_process_arrayBIIZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Decoder']/method[@name='process' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("process", "([BIIZ)Z", "GetProcess_arrayBIIZHandler")]
			public override bool Process (byte[] p0, int p1, int p2, bool p3)
			{
				if (id_process_arrayBIIZ == IntPtr.Zero)
					id_process_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "process", "([BIIZ)Z");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_process_arrayBIIZ, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "([BIIZ)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Encoder']"
		[global::Android.Runtime.Register ("io/branch/referral/Base64$Encoder", DoNotGenerateAcw=true)]
		public partial class Encoder : global::BranchSDK.Base64.Coder {


			// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Encoder']/field[@name='LINE_GROUPS']"
			[Register ("LINE_GROUPS")]
			public const int LineGroups = (int) 19;

			static IntPtr do_cr_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Encoder']/field[@name='do_cr']"
			[Register ("do_cr")]
			public bool DoCr {
				get {
					if (do_cr_jfieldId == IntPtr.Zero)
						do_cr_jfieldId = JNIEnv.GetFieldID (class_ref, "do_cr", "Z");
					return JNIEnv.GetBooleanField (Handle, do_cr_jfieldId);
				}
				set {
					if (do_cr_jfieldId == IntPtr.Zero)
						do_cr_jfieldId = JNIEnv.GetFieldID (class_ref, "do_cr", "Z");
					JNIEnv.SetField (Handle, do_cr_jfieldId, value);
				}
			}

			static IntPtr do_newline_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Encoder']/field[@name='do_newline']"
			[Register ("do_newline")]
			public bool DoNewline {
				get {
					if (do_newline_jfieldId == IntPtr.Zero)
						do_newline_jfieldId = JNIEnv.GetFieldID (class_ref, "do_newline", "Z");
					return JNIEnv.GetBooleanField (Handle, do_newline_jfieldId);
				}
				set {
					if (do_newline_jfieldId == IntPtr.Zero)
						do_newline_jfieldId = JNIEnv.GetFieldID (class_ref, "do_newline", "Z");
					JNIEnv.SetField (Handle, do_newline_jfieldId, value);
				}
			}

			static IntPtr do_padding_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Encoder']/field[@name='do_padding']"
			[Register ("do_padding")]
			public bool DoPadding {
				get {
					if (do_padding_jfieldId == IntPtr.Zero)
						do_padding_jfieldId = JNIEnv.GetFieldID (class_ref, "do_padding", "Z");
					return JNIEnv.GetBooleanField (Handle, do_padding_jfieldId);
				}
				set {
					if (do_padding_jfieldId == IntPtr.Zero)
						do_padding_jfieldId = JNIEnv.GetFieldID (class_ref, "do_padding", "Z");
					JNIEnv.SetField (Handle, do_padding_jfieldId, value);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/branch/referral/Base64$Encoder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Encoder); }
			}

			protected Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IarrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Encoder']/constructor[@name='Base64.Encoder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register (".ctor", "(I[B)V", "")]
			public Encoder (int p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);;
				if (GetType () != typeof (Encoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I[B)V", new JValue (p0), new JValue (native_p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I[B)V", new JValue (p0), new JValue (native_p1));
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					return;
				}

				if (id_ctor_IarrayB == IntPtr.Zero)
					id_ctor_IarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(I[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayB, new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IarrayB, new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_maxOutputSize_I;
#pragma warning disable 0169
			static Delegate GetMaxOutputSize_IHandler ()
			{
				if (cb_maxOutputSize_I == null)
					cb_maxOutputSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_MaxOutputSize_I);
				return cb_maxOutputSize_I;
			}

			static int n_MaxOutputSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::BranchSDK.Base64.Encoder __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Base64.Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxOutputSize (p0);
			}
#pragma warning restore 0169

			static IntPtr id_maxOutputSize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Encoder']/method[@name='maxOutputSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("maxOutputSize", "(I)I", "GetMaxOutputSize_IHandler")]
			public override int MaxOutputSize (int p0)
			{
				if (id_maxOutputSize_I == IntPtr.Zero)
					id_maxOutputSize_I = JNIEnv.GetMethodID (class_ref, "maxOutputSize", "(I)I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_maxOutputSize_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maxOutputSize", "(I)I"), new JValue (p0));
			}

			static Delegate cb_process_arrayBIIZ;
#pragma warning disable 0169
			static Delegate GetProcess_arrayBIIZHandler ()
			{
				if (cb_process_arrayBIIZ == null)
					cb_process_arrayBIIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool, bool>) n_Process_arrayBIIZ);
				return cb_process_arrayBIIZ;
			}

			static bool n_Process_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
			{
				global::BranchSDK.Base64.Encoder __this = global::Java.Lang.Object.GetObject<global::BranchSDK.Base64.Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.Process (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_process_arrayBIIZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64.Encoder']/method[@name='process' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("process", "([BIIZ)Z", "GetProcess_arrayBIIZHandler")]
			public override bool Process (byte[] p0, int p1, int p2, bool p3)
			{
				if (id_process_arrayBIIZ == IntPtr.Zero)
					id_process_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "process", "([BIIZ)Z");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_process_arrayBIIZ, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "([BIIZ)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/branch/referral/Base64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64); }
		}

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_decode_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decode", "([BI)[B", "")]
		public static byte[] Decode (byte[] p0, int p1)
		{
			if (id_decode_arrayBI == IntPtr.Zero)
				id_decode_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "decode", "([BI)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_decode_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/method[@name='decode' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("decode", "([BIII)[B", "")]
		public static byte[] Decode (byte[] p0, int p1, int p2, int p3)
		{
			if (id_decode_arrayBIII == IntPtr.Zero)
				id_decode_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "decode", "([BIII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_decode_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("decode", "(Ljava/lang/String;I)[B", "")]
		public static byte[] Decode (string p0, int p1)
		{
			if (id_decode_Ljava_lang_String_I == IntPtr.Zero)
				id_decode_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Ljava/lang/String;I)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_encode_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("encode", "([BI)[B", "")]
		public static byte[] Encode (byte[] p0, int p1)
		{
			if (id_encode_arrayBI == IntPtr.Zero)
				id_encode_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "encode", "([BI)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encode_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/method[@name='encode' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encode", "([BIII)[B", "")]
		public static byte[] Encode (byte[] p0, int p1, int p2, int p3)
		{
			if (id_encode_arrayBIII == IntPtr.Zero)
				id_encode_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "encode", "([BIII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeToString_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/method[@name='encodeToString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("encodeToString", "([BI)Ljava/lang/String;", "")]
		public static string EncodeToString (byte[] p0, int p1)
		{
			if (id_encodeToString_arrayBI == IntPtr.Zero)
				id_encodeToString_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "encodeToString", "([BI)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeToString_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeToString_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.branch.referral']/class[@name='Base64']/method[@name='encodeToString' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encodeToString", "([BIII)Ljava/lang/String;", "")]
		public static string EncodeToString (byte[] p0, int p1, int p2, int p3)
		{
			if (id_encodeToString_arrayBIII == IntPtr.Zero)
				id_encodeToString_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "encodeToString", "([BIII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeToString_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
