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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies the Amazon Resource Name (ARN) of the Identity and Access Management (IAM)
    /// role that DataSync uses to access your S3 bucket.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-access">Providing
    /// DataSync access to S3 buckets</a>.
    /// </para>
    /// </summary>
    public partial class S3Config
    {
        private string _bucketAccessRoleArn;

        /// <summary>
        /// Gets and sets the property BucketAccessRoleArn. 
        /// <para>
        /// Specifies the ARN of the IAM role that DataSync uses to access your S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string BucketAccessRoleArn
        {
            get { return this._bucketAccessRoleArn; }
            set { this._bucketAccessRoleArn = value; }
        }

        // Check to see if BucketAccessRoleArn property is set
        internal bool IsSetBucketAccessRoleArn()
        {
            return this._bucketAccessRoleArn != null;
        }

    }
}