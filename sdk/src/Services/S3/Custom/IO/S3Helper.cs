/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.Util;

namespace Amazon.S3.IO
{
    internal static class S3Helper
    {
        internal static string EncodeKey(string key)
        {
            return key.Replace('\\', '/');
        }
        internal static string DecodeKey(string key)
        {
            return key.Replace('/', '\\');
        }

        internal static void FileIORequestEventHandler(object sender, RequestEventArgs args)
        {
            WebServiceRequestEventArgs wsArgs = args as WebServiceRequestEventArgs;
            if (wsArgs != null)
            {
                string currentUserAgent = wsArgs.Headers[AWSSDKUtils.UserAgentHeader];
                wsArgs.Headers[AWSSDKUtils.UserAgentHeader] = currentUserAgent + " FileIO";
            }
        }

    }
}
