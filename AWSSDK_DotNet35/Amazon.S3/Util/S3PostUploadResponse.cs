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
 *
 */

using System.Linq;
using System.Net;
using Amazon.Util;

namespace Amazon.S3.Util
{
    public class S3PostUploadResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string RequestId { get; set; }
        public string HostId { get; set; }

        internal static S3PostUploadResponse FromWebResponse(HttpWebResponse response)
        {
            var postResponse = new S3PostUploadResponse{ StatusCode = response.StatusCode };
            if (response.Headers.AllKeys.Contains(HeaderKeys.XAmzRequestIdHeader))
                postResponse.RequestId = response.Headers[HeaderKeys.XAmzRequestIdHeader];
            if (response.Headers.AllKeys.Contains(HeaderKeys.XAmzId2Header))
                postResponse.HostId = response.Headers[HeaderKeys.XAmzId2Header];

            return postResponse;
        }
    }
}