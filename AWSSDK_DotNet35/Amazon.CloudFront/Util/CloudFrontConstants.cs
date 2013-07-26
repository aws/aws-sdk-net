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
 *  API Version: 2010-11-01
 *
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.CloudFront.Util
{
    internal static class CloudFrontConstants
    {
        // Commonly used headers
        internal const string AmzRequestIdHeader = "x-amzn-RequestId";
        internal const string AmzDateHeader = "x-amz-date";
        internal const string AuthorizationHeader = "Authorization";

        // Accepted HTTP Verbs
        internal static readonly string[] Verbs = { "GET", "POST", "PUT", "DELETE" };
        internal static readonly string GetVerb = Verbs[0];
        internal static readonly string PostVerb = Verbs[1];
        internal static readonly string PutVerb = Verbs[2];
        internal static readonly string DeleteVerb = Verbs[3];

        // Often used strings
        internal const string ServiceResource = "/2010-11-01/";
        internal const string ConfigQuery = "/config";
        internal const string RequestParam = "request";
    }
}