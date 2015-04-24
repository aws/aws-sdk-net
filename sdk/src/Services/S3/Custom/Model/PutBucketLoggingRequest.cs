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
    /// Container for the parameters to the PutBucketLoggingRequest operation.
    /// <para>Set the logging parameters for a bucket and to specify permissions for who can view and modify the logging parameters. To set the
    /// logging status of a bucket, you must be the bucket owner.</para>
    /// </summary>
    public partial class PutBucketLoggingRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName { get; set; }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// Gets and sets the LoggingConfig property.
        /// </summary>
        public S3BucketLoggingConfig LoggingConfig { get; set; }

        // Check to see if BucketLoggingStatus property is set
        internal bool IsSetLoggingConfig()
        {
            return this.LoggingConfig != null;
        }
    }
}
    
