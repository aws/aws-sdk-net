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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
    /// is used to access an Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    /// For detailed information about using such a role, see Creating a Location for Amazon
    /// S3 in the <i>DataSync User Guide</i>.
    /// </para>
    /// </summary>
    public partial class S3Config
    {
        private string _bucketAccessRoleArn;

        /// <summary>
        /// Gets and sets the property BucketAccessRoleArn. 
        /// <para>
        /// The Amazon S3 bucket to access. This bucket is used as a parameter in the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_CreateLocationS3.html">CreateLocationS3</a>
        /// operation. 
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