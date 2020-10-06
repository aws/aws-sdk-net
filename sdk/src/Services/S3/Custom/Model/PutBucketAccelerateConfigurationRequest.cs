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
    /// Container for the parameters to the PutBucketAccelerateConfiguration request.
    /// </summary>
    public partial class PutBucketAccelerateConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private AccelerateConfiguration accelerateConfiguration;
        private string expectedBucketOwner;

        /// <summary>
        /// <para>The name of the bucket for which the accelerate configuration is set.</para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// Accelerate configuration for the bucket.
        /// </summary>
        public AccelerateConfiguration AccelerateConfiguration
        {
            get { return this.accelerateConfiguration; }
            set { this.accelerateConfiguration = value; }
        }

        // Check to see if AccelerateConfiguration property is set
        internal bool IsSetAccelerateConfiguration()
        {
            return this.AccelerateConfiguration != null;
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
    
