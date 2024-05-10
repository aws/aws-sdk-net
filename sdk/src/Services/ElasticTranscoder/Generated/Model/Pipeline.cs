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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The pipeline (queue) that is used to manage jobs.
    /// </summary>
    public partial class Pipeline
    {
        private string _arn;
        private string _awsKmsKeyArn;
        private PipelineOutputConfig _contentConfig;
        private string _id;
        private string _inputBucket;
        private string _name;
        private Notifications _notifications;
        private string _outputBucket;
        private string _role;
        private string _status;
        private PipelineOutputConfig _thumbnailConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the pipeline.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AwsKmsKeyArn. 
        /// <para>
        /// The AWS Key Management Service (AWS KMS) key that you want to use with this pipeline.
        /// </para>
        ///  
        /// <para>
        /// If you use either <c>s3</c> or <c>s3-aws-kms</c> as your <c>Encryption:Mode</c>, you
        /// don't need to provide a key with your job because a default key, known as an AWS-KMS
        /// key, is created for you automatically. You need to provide an AWS-KMS key only if
        /// you want to use a non-default AWS-KMS key, or if you are using an <c>Encryption:Mode</c>
        /// of <c>aes-cbc-pkcs7</c>, <c>aes-ctr</c>, or <c>aes-gcm</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string AwsKmsKeyArn
        {
            get { return this._awsKmsKeyArn; }
            set { this._awsKmsKeyArn = value; }
        }

        // Check to see if AwsKmsKeyArn property is set
        internal bool IsSetAwsKmsKeyArn()
        {
            return this._awsKmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContentConfig. 
        /// <para>
        /// Information about the Amazon S3 bucket in which you want Elastic Transcoder to save
        /// transcoded files and playlists. Either you specify both <c>ContentConfig</c> and <c>ThumbnailConfig</c>,
        /// or you specify <c>OutputBucket</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Bucket</b>: The Amazon S3 bucket in which you want Elastic Transcoder to save
        /// transcoded files and playlists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Permissions</b>: A list of the users and/or predefined Amazon S3 groups you want
        /// to have access to transcoded files and playlists, and the type of access that you
        /// want them to have. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// GranteeType: The type of value that appears in the <c>Grantee</c> object: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Canonical</c>: Either the canonical user ID for an AWS account or an origin access
        /// identity for an Amazon CloudFront distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Email</c>: The registered email address of an AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Group</c>: One of the following predefined Amazon S3 groups: <c>AllUsers</c>,
        /// <c>AuthenticatedUsers</c>, or <c>LogDelivery</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>Grantee</c>: The AWS user or group that you want to have access to transcoded
        /// files and playlists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Access</c>: The permission that you want to give to the AWS user that is listed
        /// in <c>Grantee</c>. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>READ</c>: The grantee can read the objects and metadata for objects that Elastic
        /// Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READ_ACP</c>: The grantee can read the object ACL for objects that Elastic Transcoder
        /// adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WRITE_ACP</c>: The grantee can write the ACL for the objects that Elastic Transcoder
        /// adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FULL_CONTROL</c>: The grantee has <c>READ</c>, <c>READ_ACP</c>, and <c>WRITE_ACP</c>
        /// permissions for the objects that Elastic Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <b>StorageClass</b>: The Amazon S3 storage class, Standard or ReducedRedundancy,
        /// that you want Elastic Transcoder to assign to the video files and playlists that it
        /// stores in your Amazon S3 bucket. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PipelineOutputConfig ContentConfig
        {
            get { return this._contentConfig; }
            set { this._contentConfig = value; }
        }

        // Check to see if ContentConfig property is set
        internal bool IsSetContentConfig()
        {
            return this._contentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the pipeline. You use this value to identify the pipeline in which
        /// you want to perform a variety of operations, such as creating a job or a preset.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InputBucket. 
        /// <para>
        /// The Amazon S3 bucket from which Elastic Transcoder gets media files for transcoding
        /// and the graphics files, if any, that you want to use for watermarks.
        /// </para>
        /// </summary>
        public string InputBucket
        {
            get { return this._inputBucket; }
            set { this._inputBucket = value; }
        }

        // Check to see if InputBucket property is set
        internal bool IsSetInputBucket()
        {
            return this._inputBucket != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the pipeline. We recommend that the name be unique within the AWS account,
        /// but uniqueness is not enforced.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 40 characters
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Notifications. 
        /// <para>
        /// The Amazon Simple Notification Service (Amazon SNS) topic that you want to notify
        /// to report job status.
        /// </para>
        ///  <important> 
        /// <para>
        /// To receive notifications, you must also subscribe to the new topic in the Amazon SNS
        /// console.
        /// </para>
        ///  </important> <ul> <li> 
        /// <para>
        ///  <b>Progressing</b> (optional): The Amazon Simple Notification Service (Amazon SNS)
        /// topic that you want to notify when Elastic Transcoder has started to process the job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Complete</b> (optional): The Amazon SNS topic that you want to notify when Elastic
        /// Transcoder has finished processing the job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Warning</b> (optional): The Amazon SNS topic that you want to notify when Elastic
        /// Transcoder encounters a warning condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Error</b> (optional): The Amazon SNS topic that you want to notify when Elastic
        /// Transcoder encounters an error condition.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Notifications Notifications
        {
            get { return this._notifications; }
            set { this._notifications = value; }
        }

        // Check to see if Notifications property is set
        internal bool IsSetNotifications()
        {
            return this._notifications != null;
        }

        /// <summary>
        /// Gets and sets the property OutputBucket. 
        /// <para>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save transcoded files,
        /// thumbnails, and playlists. Either you specify this value, or you specify both <c>ContentConfig</c>
        /// and <c>ThumbnailConfig</c>.
        /// </para>
        /// </summary>
        public string OutputBucket
        {
            get { return this._outputBucket; }
            set { this._outputBucket = value; }
        }

        // Check to see if OutputBucket property is set
        internal bool IsSetOutputBucket()
        {
            return this._outputBucket != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM Amazon Resource Name (ARN) for the role that Elastic Transcoder uses to transcode
        /// jobs for this pipeline.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the pipeline:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Active</c>: The pipeline is processing jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Paused</c>: The pipeline is not currently processing jobs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailConfig. 
        /// <para>
        /// Information about the Amazon S3 bucket in which you want Elastic Transcoder to save
        /// thumbnail files. Either you specify both <c>ContentConfig</c> and <c>ThumbnailConfig</c>,
        /// or you specify <c>OutputBucket</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Bucket</c>: The Amazon S3 bucket in which you want Elastic Transcoder to save
        /// thumbnail files. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Permissions</c>: A list of the users and/or predefined Amazon S3 groups you want
        /// to have access to thumbnail files, and the type of access that you want them to have.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// GranteeType: The type of value that appears in the Grantee object:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Canonical</c>: Either the canonical user ID for an AWS account or an origin access
        /// identity for an Amazon CloudFront distribution.
        /// </para>
        ///  <important> 
        /// <para>
        /// A canonical user ID is not the same as an AWS account number.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <c>Email</c>: The registered email address of an AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Group</c>: One of the following predefined Amazon S3 groups: <c>AllUsers</c>,
        /// <c>AuthenticatedUsers</c>, or <c>LogDelivery</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>Grantee</c>: The AWS user or group that you want to have access to thumbnail files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Access: The permission that you want to give to the AWS user that is listed in Grantee.
        /// Valid values include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>READ</c>: The grantee can read the thumbnails and metadata for thumbnails that
        /// Elastic Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READ_ACP</c>: The grantee can read the object ACL for thumbnails that Elastic
        /// Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WRITE_ACP</c>: The grantee can write the ACL for the thumbnails that Elastic Transcoder
        /// adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FULL_CONTROL</c>: The grantee has READ, READ_ACP, and WRITE_ACP permissions for
        /// the thumbnails that Elastic Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <c>StorageClass</c>: The Amazon S3 storage class, <c>Standard</c> or <c>ReducedRedundancy</c>,
        /// that you want Elastic Transcoder to assign to the thumbnails that it stores in your
        /// Amazon S3 bucket.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PipelineOutputConfig ThumbnailConfig
        {
            get { return this._thumbnailConfig; }
            set { this._thumbnailConfig = value; }
        }

        // Check to see if ThumbnailConfig property is set
        internal bool IsSetThumbnailConfig()
        {
            return this._thumbnailConfig != null;
        }

    }
}