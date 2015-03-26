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
    /// Container for the parameters to the PutBucketRequestPayment operation.
    /// <para>Sets the request payment configuration for a bucket. By default, the bucket owner pays for downloads from the bucket. This
    /// configuration parameter enables the bucket owner (only) to specify that the person requesting the download will be charged for the
    /// download.</para>
    /// </summary>
    public partial class PutBucketRequestPaymentRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private RequestPaymentConfiguration requestPaymentConfiguration;

        /// <summary>
        /// The name of the bucket to set payment config.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets request payment configuration
        /// </summary>
        public RequestPaymentConfiguration RequestPaymentConfiguration
        {
            get { return this.requestPaymentConfiguration; }
            set { this.requestPaymentConfiguration = value; }
        }

        // Check to see if RequestPaymentConfiguration property is set
        internal bool IsSetRequestPaymentConfiguration()
        {
            return this.requestPaymentConfiguration != null;
        }

    }
}
    
