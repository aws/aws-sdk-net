/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Amazon.Util.Internal
{        
    /// <summary>
    /// An interface for <see cref="RuntimeInformationWrapper"/> which allows for mocking the <see cref="RuntimeInformation"/> class.
    /// A wrapper is necessary because the class is static.
    /// </summary>
    internal interface IRuntimeInformationWrapper
    {
        string FrameworkDescription { get; }
    }

    internal class RuntimeInformationWrapper : IRuntimeInformationWrapper
    {
        public string FrameworkDescription => RuntimeInformation.FrameworkDescription;
    }

    public static partial class InternalSDKUtils
    {
        private const string UnknownPlaceholder = "Unknown";
        private const string UnknownPlatform = "unknown_platform";

        private static string _userAgentBaseName = "aws-sdk-dotnet-coreclr";

        private static IRuntimeInformationWrapper _runtimeInformationWrapper = new RuntimeInformationWrapper();


        private static string GetValidSubstringOrUnknown(string str, int start, int end)
        {
            if ((start != -1) && (end != -1) &&
                (0 <= start) && (end <= str.Length))
            {
                string substr = str.Substring(start, end-start);
                if (!string.IsNullOrWhiteSpace(substr))
                {
                    return substr.Trim().Replace(' ', '_');
                }

            }
            return UnknownPlaceholder;
        }

        /// <summary>
        /// Returns the type of platform and version using the InteropServices RuntimeInformation for
        /// the OSDescription and trims off the OS name.
        /// </summary>
        public static string DetermineFramework()
        {
            try
            {
                var desc = _runtimeInformationWrapper.FrameworkDescription.Trim();
                var version = GetValidSubstringOrUnknown(desc, desc.LastIndexOf(' ') + 1, desc.Length);
                if (!Version.TryParse(version, out var _))
                {
                    return "Unknown" + $" md/framework-raw-version#{desc.Replace(' ', '_')}";
                }
                return string.Format(CultureInfo.InvariantCulture, ".NET_Core#{0}", version);
            }
            catch
            {
                return UnknownPlaceholder;
            }
        }


        /// <summary>
        /// Returns the OS.
        /// </summary>
        public static string DetermineOS()
        {
            try
            {
                var desc = RuntimeInformation.OSDescription.Trim();
                return GetValidSubstringOrUnknown(desc, 0, desc.LastIndexOf(' '));
            }
            catch
            {
                return UnknownPlaceholder;
            }
        }

        /// <summary>
        /// Returns the platform description that should be added to the user agent.
        /// </summary>
        public static string PlatformUserAgent()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    sb.AppendFormat("linux#{0}", Environment.OSVersion.Version);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    sb.AppendFormat("windows#{0}", Environment.OSVersion.Version);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    sb.AppendFormat("macos#{0}", Environment.OSVersion.Version);
                }
                else
                {
                    sb.AppendFormat("other md/{0}#{1}", RuntimeInformation.OSDescription, Environment.OSVersion.Version);
                }

                sb.AppendFormat(" md/ARCH#{0}", RuntimeInformation.OSArchitecture);

                return sb.ToString();
            }
            catch
            {
                return UnknownPlaceholder;
            }
        }
        // Method to set the runtime information wrapper for testing
        internal static void SetRuntimeInformationWrapper(IRuntimeInformationWrapper wrapper)
        {
            _runtimeInformationWrapper = wrapper;
        }

        internal static void ResetRuntimeInformationWrapper()
        {
            _runtimeInformationWrapper = new RuntimeInformationWrapper();
        }
    }
}
