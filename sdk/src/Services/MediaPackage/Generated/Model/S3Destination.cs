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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
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
namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// Configuration parameters for where in an S3 bucket to place the harvested content
    /// </summary>
    public partial class S3Destination
    {
        private string _bucketName;
        private string _manifestKey;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property BucketName. The name of an S3 bucket within which harvested
        /// content will be exported
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestKey. The key in the specified S3 bucket where the
        /// harvested top-level manifest will be placed.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManifestKey
        {
            get { return this._manifestKey; }
            set { this._manifestKey = value; }
        }

        // Check to see if ManifestKey property is set
        internal bool IsSetManifestKey()
        {
            return this._manifestKey != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. The IAM role used to write to the specified S3
        /// bucket
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}