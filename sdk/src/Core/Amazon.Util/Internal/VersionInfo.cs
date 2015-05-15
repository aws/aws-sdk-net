/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Amazon.Util.Internal
{
    /// <summary>
    /// A utility class that provides version information for the SDK.
    /// </summary>
    public class VersionInfo
    {
        /// <summary>
        /// The file version of the assembly.
        /// </summary>
        public string FileVersion { get; private set; }

        public VersionInfo()
        {
            var callingAssembly = Assembly.GetCallingAssembly();
            var attributes = callingAssembly.GetCustomAttributes(
                typeof(AssemblyFileVersionAttribute), false);
            if (attributes.Length == 0)
            {
                throw new AmazonClientException(
                    string.Format("The assembly {0} does not define an AssemblyFileVersion attribute.",
                    callingAssembly.FullName));
            }

            this.FileVersion = ((AssemblyFileVersionAttribute)attributes[0]).Version;
        }
    }
}
