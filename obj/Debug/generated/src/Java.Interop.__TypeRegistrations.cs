using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"io/branch/referral",
					},
					new Converter<string, Type>[]{
						lookup_io_branch_referral_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_io_branch_referral_mappings;
		static Type lookup_io_branch_referral_package (string klass)
		{
			if (package_io_branch_referral_mappings == null) {
				package_io_branch_referral_mappings = new string[]{
					"io/branch/referral/Base64:BranchSDK.Base64",
					"io/branch/referral/Base64$Coder:BranchSDK.Base64/Coder",
					"io/branch/referral/Base64$Decoder:BranchSDK.Base64/Decoder",
					"io/branch/referral/Base64$Encoder:BranchSDK.Base64/Encoder",
					"io/branch/referral/Branch:BranchSDK.Branch",
					"io/branch/referral/Branch$ReferralNetworkCallback:BranchSDK.Branch/ReferralNetworkCallback",
					"io/branch/referral/BranchRemoteInterface:BranchSDK.BranchRemoteInterface",
					"io/branch/referral/PrefHelper:BranchSDK.PrefHelper",
					"io/branch/referral/RemoteInterface:BranchSDK.RemoteInterface",
					"io/branch/referral/ServerRequest:BranchSDK.ServerRequest",
					"io/branch/referral/SystemObserver:BranchSDK.SystemObserver",
				};
			}

			return Lookup (package_io_branch_referral_mappings, klass);
		}
	}
}
