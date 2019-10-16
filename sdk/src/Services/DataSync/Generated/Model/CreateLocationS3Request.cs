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
    /// </para>
    ///  
    /// <para>
    /// For more information, see https://docs.aws.amazon.com/datasync/latest/userguide/working-with-locations.html#create-s3-location
    /// in the <i>AWS DataSync User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class CreateLocationS3Request : AmazonDataSyncRequest
    {
        private string _s3BucketArn;
        private S3Config _s3Config;
        private S3StorageClass _s3StorageClass;
        private string _subdirectory;
        private List<TagListEntry> _tags = new List<TagListEntry>();

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=76)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property S3StorageClass. 
        /// <para>
        /// The Amazon S3 storage class that you want to store your files in when this location
        /// is used as a task destination. For more information about S3 storage classes, see
        /// <a href="https://aws.amazon.com/s3/storage-classes/">Amazon S3 Storage Classes</a>
        /// in the <i>Amazon Simple Storage Service Developer Guide</i>. Some storage classes
        /// have behaviors that can affect your S3 storage cost. For detailed information, see
        /// <a>using-storage-classes</a>.
        /// </para>
        /// </summary>
        public S3StorageClass S3StorageClass
        {
            get { return this._s3StorageClass; }
            set { this._s3StorageClass = value; }
        }

        // Check to see if S3StorageClass property is set
        internal bool IsSetS3StorageClass()
        {
            return this._s3StorageClass != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// A subdirectory in the Amazon S3 bucket. This subdirectory in Amazon S3 is used to
        /// read data from the S3 source location or write data to the S3 destination.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
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
        [AWSProperty(Min=0, Max=55)]
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