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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketPolicy operation.
    /// <para>Replaces a policy on a bucket. If the bucket already has a policy, the one in this request completely replaces it.</para>
    /// </summary>
    public partial class PutBucketPolicyRequest : AmazonWebServiceRequest
    {
        private bool? confirmRemoveSelfBucketAccess;
        private string expectedBucketOwner;
        /// <summary>
        /// The name of the bucket.
        /// </summary>
        public string BucketName { get; set; }

        // Check to see if BucketName property is set
        internal bool IsSetBucket()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// The base64 encoded 128-bit MD5 digest of the message (without the headers) according to RFC 1864. 
        /// </summary>
        /// <remarks>
        /// This header can be used as a message integrity check to verify that the data is the same data that was originally sent. 
        /// Although it is optional, we recommend using the Content-MD5 mechanism as an end-to-end integrity check. 
        /// </remarks>
        public string ContentMD5 { get; set; }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this.ContentMD5 != null;
        }

        /// <summary>
        /// The bucket policy as a JSON document.
        /// </summary>
        public string Policy { get; set; }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this.Policy != null;
        }
        /// <summary>
        /// Set this parameter to true to confirm that you want to remove your 
        /// permissions to change this bucket policy in the future.
        /// </summary>
        public bool ConfirmRemoveSelfBucketAccess
        {
            get
            {
                return this.confirmRemoveSelfBucketAccess.GetValueOrDefault();
            }
            set
            {
                this.confirmRemoveSelfBucketAccess = value;
            }
        }
        // Check to see if ConfirmRemoveSelfBucketAccess property is set
        internal bool IsSetConfirmRemoveSelfBucketAccess()
        {
            return this.confirmRemoveSelfBucketAccess.HasValue;
        }

        /// <summary>
        /// Overriden to turn off sending SHA256 header.
        /// </summary>
        protected override bool IncludeSHA256Header
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// The account id of the expected bucket owner. 
        /// If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }
    }
}
    
