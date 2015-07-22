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
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using Amazon.Util.Internal.PlatformServices;

namespace Amazon.Util.Internal
{
    public static partial class InternalSDKUtils
    {
        static string _userAgentBaseName = "aws-sdk-dotnet-pcl";        
        private const string UnknownMonoVersion = "Mono/Unknown";
#if __IOS__ || __ANDROID__

        

        public static string GetMonoRuntimeVersion()
        {
            Type type = Type.GetType("Mono.Runtime");
            if (type != null)
            {
                MethodInfo displayName = type.GetMethod("GetDisplayName");
                if (displayName != null)
                {
                    var version = (string)displayName.Invoke(null, null);
                    // Replace "/" from the version string as it's a
                    // seperator in the user agent format
                    version = version.Replace("/", ":").Replace(" ",string.Empty);
                    return "Mono/" + version;
                }
            }

            return UnknownMonoVersion;
        }
#endif
    }
}
