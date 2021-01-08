/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Xml.Serialization;
using Amazon.Runtime;
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters for a pre-signed URL to a bucket or object as a string. 
    /// </summary>
    /// <remarks>
    /// For more information, refer to: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/S3_QSAuth.html"/>.
    /// </remarks>
    public class GetPreSignedUrlResponse : AmazonWebServiceResponse
    {
        
        /// <summary>
        /// The PreSignedURL as a string
        /// </summary>
        public string Url { get; internal set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">A url returned from GetPreSignedUrlRequest</param>
        public GetPreSignedUrlResponse(string url)
        {
            this.Url = url;
        }
    }
}
