/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLocationS3 operation.
    /// Creates an endpoint for an Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    /// For AWS DataSync to access a destination S3 bucket, it needs an AWS Identity and Access
    /// Management (IAM) role that has the required permissions. You can set up the required
    /// permissions by creating an IAM policy that grants the required permissions and attaching
    /// the policy to the role. An example of such a policy is shown in the examples section.
    /// For more information, see <a href="https://docs.aws.amazon.com/sync-service/latest/userguide/configuring-s3-locations.html">Configuring
    /// Amazon S3 Location Settings</a> in the <i>AWS DataSync User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateLocationS3Request : AmazonDataSyncRequest
    {
        private string _s3BucketArn;
        private S3Config _s3Config;
        private string _subdirectory;
        private List<TagListEntry> _tags = new List<TagListEntry>();

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property S3Config.
        /// </summary>
        public S3Config S3Config
        {
            get { return this._s3Config; }
            set { this._s3Config = value; }
        }

        // Check to see if S3Config property is set
        internal bool IsSetS3Config()
        {
            return this._s3Config != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// A subdirectory in the Amazon S3 bucket. This subdirectory in Amazon S3 is used to
        /// read data from the S3 source location or write data to the S3 destination.
        /// </para>
        /// </summary>
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pair that represents the tag that you want to add to the location. The
        /// value can be an empty string. We recommend using tags to name your resources.
        /// </para>
        /// </summary>
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}