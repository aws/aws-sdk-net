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
    /// Specifies the S3 bucket where you're hosting the manifest that you want DataSync to
    /// use. For more information and configuration examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html">Specifying
    /// what DataSync transfers by using a manifest</a>.
    /// </summary>
    public partial class S3ManifestConfig
    {
        private string _bucketAccessRoleArn;
        private string _manifestObjectPath;
        private string _manifestObjectVersionId;
        private string _s3BucketArn;

        /// <summary>
        /// Gets and sets the property BucketAccessRoleArn. 
        /// <para>
        /// Specifies the Identity and Access Management (IAM) role that allows DataSync to access
        /// your manifest. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html#transferring-with-manifest-access">Providing
        /// DataSync access to your manifest</a>.
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

        /// <summary>
        /// Gets and sets the property ManifestObjectPath. 
        /// <para>
        /// Specifies the Amazon S3 object key of your manifest. This can include a prefix (for
        /// example, <c>prefix/my-manifest.csv</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4096)]
        public string ManifestObjectPath
        {
            get { return this._manifestObjectPath; }
            set { this._manifestObjectPath = value; }
        }

        // Check to see if ManifestObjectPath property is set
        internal bool IsSetManifestObjectPath()
        {
            return this._manifestObjectPath != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestObjectVersionId. 
        /// <para>
        /// Specifies the object version ID of the manifest that you want DataSync to use. If
        /// you don't set this, DataSync uses the latest version of the object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ManifestObjectVersionId
        {
            get { return this._manifestObjectVersionId; }
            set { this._manifestObjectVersionId = value; }
        }

        // Check to see if ManifestObjectVersionId property is set
        internal bool IsSetManifestObjectVersionId()
        {
            return this._manifestObjectVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the S3 bucket where you're hosting your
        /// manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=268)]
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

    }
}