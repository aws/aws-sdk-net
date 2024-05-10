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

/*
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Proposed access control configuration for an Amazon S3 directory bucket. You can propose
    /// a configuration for a new Amazon S3 directory bucket or an existing Amazon S3 directory
    /// bucket that you own by specifying the Amazon S3 bucket policy. If the configuration
    /// is for an existing Amazon S3 directory bucket and you do not specify the Amazon S3
    /// bucket policy, the access preview uses the existing policy attached to the directory
    /// bucket. If the access preview is for a new resource and you do not specify the Amazon
    /// S3 bucket policy, the access preview assumes an directory bucket without a policy.
    /// To propose deletion of an existing bucket policy, you can specify an empty string.
    /// For more information about Amazon S3 directory bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-example-bucket-policies.html">Example
    /// directory bucket policies for S3 Express One Zone</a>.
    /// </summary>
    public partial class S3ExpressDirectoryBucketConfiguration
    {
        private string _bucketPolicy;

        /// <summary>
        /// Gets and sets the property BucketPolicy. 
        /// <para>
        /// The proposed bucket policy for the Amazon S3 directory bucket.
        /// </para>
        /// </summary>
        public string BucketPolicy
        {
            get { return this._bucketPolicy; }
            set { this._bucketPolicy = value; }
        }

        // Check to see if BucketPolicy property is set
        internal bool IsSetBucketPolicy()
        {
            return this._bucketPolicy != null;
        }

    }
}