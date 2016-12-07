/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.Runtime.InteropServices;

namespace Amazon.Util.Internal
{
    public static partial class InternalSDKUtils
    {
        static string _userAgentBaseName = "aws-sdk-dotnet-coreclr";
        private readonly static string _unknown = "Unknown";
        
        public static string GetValidSubstringOrUnknown(string str, int start, int end)
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
            return _unknown;
        }

        public static string DetermineRuntime()
        {
            try
            {
                string desc = RuntimeInformation.FrameworkDescription.Trim();
                return GetValidSubstringOrUnknown(desc, 0, desc.LastIndexOf(' '));
            }
            catch
            {
                return _unknown;
            }
        }

        public static string DetermineFramework()
        {
            try
            {
                string desc = RuntimeInformation.FrameworkDescription.Trim();
                return GetValidSubstringOrUnknown(desc, desc.LastIndexOf(' ') + 1, desc.Length);
            }
            catch
            {
                return _unknown;
            }
        }

        public static string DetermineOS()
        {
            try
            { 
                string desc = RuntimeInformation.OSDescription.Trim();
                return GetValidSubstringOrUnknown(desc, 0, desc.LastIndexOf(' '));
            }
            catch
            {
                return _unknown;
            }
        }

        public static string DetermineOSVersion()
        {
            try
            {
                string desc = RuntimeInformation.OSDescription.Trim();
                return GetValidSubstringOrUnknown(desc, desc.LastIndexOf(' ') + 1, desc.Length);
            }
            catch
            {
                return _unknown;
            }
        }

        public static string PlatformUserAgent()
        {
            try
            {
                string desc = RuntimeInformation.OSDescription;
                if (!string.IsNullOrWhiteSpace(desc))
                {
                    return desc.Trim().Replace(' ', '_');
                }
                return _unknown;
            }
            catch
            {
                return _unknown;
            }
        }
    }
}
