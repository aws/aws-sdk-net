/*
 * Copyright 2010-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketRequestPayment operation.
    /// <para>Creates a new server-side encryption configuration (or replaces an existing one, if present).</para>
    /// </summary>
    public class PutBucketEncryptionRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string contentMD5;
        private ServerSideEncryptionConfiguration serverSideEncryptionConfiguration;

        /// <summary>
        /// The name of the bucket for which the server-side encryption configuration is set.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return !(string.IsNullOrEmpty(this.bucketName));
        }

        /// <summary>
        /// The base64-encoded 128-bit MD5 digest of the server-side encryption configuration.
        /// </summary>
        /// <remarks>
        /// This header can be used as a message integrity check to verify that the data is the same data that was originally sent. 
        /// Although it is optional, we recommend using the Content-MD5 mechanism as an end-to-end integrity check. 
        /// </remarks>
        public string ContentMD5
        {
            get { return this.contentMD5; }
            set { this.contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this.contentMD5 != null;
        }

        /// <summary>
        /// Container for server-side encryption configuration rules. Currently S3 supports one rule only.
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this.serverSideEncryptionConfiguration; }
            set { this.serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this.serverSideEncryptionConfiguration != null;
        }
    }
}