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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStoreImageTask operation.
    /// Stores an AMI as a single object in an Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    /// To use this API, you must have the required permissions. For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html#ami-s3-permissions">Permissions
    /// for storing and restoring AMIs using Amazon S3</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html">Store
    /// and restore an AMI using Amazon S3</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateStoreImageTaskRequest : AmazonEC2Request
    {
        private string _bucket;
        private string _imageId;
        private List<S3ObjectTag> _s3ObjectTags = new List<S3ObjectTag>();

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket in which the AMI object will be stored. The bucket
        /// must be in the Region in which the request is being made. The AMI object appears in
        /// the bucket only after the upload task has completed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property S3ObjectTags. 
        /// <para>
        /// The tags to apply to the AMI object that will be stored in the Amazon S3 bucket. 
        /// </para>
        /// </summary>
        public List<S3ObjectTag> S3ObjectTags
        {
            get { return this._s3ObjectTags; }
            set { this._s3ObjectTags = value; }
        }

        // Check to see if S3ObjectTags property is set
        internal bool IsSetS3ObjectTags()
        {
            return this._s3ObjectTags != null && this._s3ObjectTags.Count > 0; 
        }

    }
}