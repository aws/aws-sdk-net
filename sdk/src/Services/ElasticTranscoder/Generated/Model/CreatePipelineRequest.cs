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
    /// Container for the parameters to the CreatePipeline operation.
    /// The CreatePipeline operation creates a pipeline with settings that you specify.
    /// </summary>
    public partial class CreatePipelineRequest : AmazonElasticTranscoderRequest
    {
        private string _awsKmsKeyArn;
        private PipelineOutputConfig _contentConfig;
        private string _inputBucket;
        private string _name;
        private Notifications _notifications;
        private string _outputBucket;
        private string _role;
        private PipelineOutputConfig _thumbnailConfig;

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
        /// The optional <c>ContentConfig</c> object specifies information about the Amazon S3
        /// bucket in which you want Elastic Transcoder to save transcoded files and playlists:
        /// which bucket to use, which users you want to have access to the files, the type of
        /// access you want users to have, and the storage class that you want to assign to the
        /// files.
        /// </para>
        ///  
        /// <para>
        /// If you specify values for <c>ContentConfig</c>, you must also specify values for <c>ThumbnailConfig</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify values for <c>ContentConfig</c> and <c>ThumbnailConfig</c>, omit the
        /// <c>OutputBucket</c> object.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Bucket</b>: The Amazon S3 bucket in which you want Elastic Transcoder to save
        /// transcoded files and playlists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Permissions</b> (Optional): The Permissions object specifies which users you want
        /// to have access to transcoded files and the type of access you want them to have. You
        /// can grant permissions to a maximum of 30 users and/or predefined Amazon S3 groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Grantee Type</b>: Specify the type of value that appears in the <c>Grantee</c>
        /// object: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Canonical</b>: The value in the <c>Grantee</c> object is either the canonical
        /// user ID for an AWS account or an origin access identity for an Amazon CloudFront distribution.
        /// For more information about canonical user IDs, see Access Control List (ACL) Overview
        /// in the Amazon Simple Storage Service Developer Guide. For more information about using
        /// CloudFront origin access identities to require that users use CloudFront URLs instead
        /// of Amazon S3 URLs, see Using an Origin Access Identity to Restrict Access to Your
        /// Amazon S3 Content.
        /// </para>
        ///  <important> 
        /// <para>
        /// A canonical user ID is not the same as an AWS account number.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <b>Email</b>: The value in the <c>Grantee</c> object is the registered email address
        /// of an AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Group</b>: The value in the <c>Grantee</c> object is one of the following predefined
        /// Amazon S3 groups: <c>AllUsers</c>, <c>AuthenticatedUsers</c>, or <c>LogDelivery</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Grantee</b>: The AWS user or group that you want to have access to transcoded
        /// files and playlists. To identify the user or group, you can specify the canonical
        /// user ID for an AWS account, an origin access identity for a CloudFront distribution,
        /// the registered email address of an AWS account, or a predefined Amazon S3 group 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access</b>: The permission that you want to give to the AWS user that you specified
        /// in <c>Grantee</c>. Permissions are granted on the files that Elastic Transcoder adds
        /// to the bucket, including playlists and video files. Valid values include: 
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
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>StorageClass</b>: The Amazon S3 storage class, <c>Standard</c> or <c>ReducedRedundancy</c>,
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
        /// Gets and sets the property InputBucket. 
        /// <para>
        /// The Amazon S3 bucket in which you saved the media files that you want to transcode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Constraints: Maximum 40 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
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
        ///  <b>Progressing</b>: The topic ARN for the Amazon Simple Notification Service (Amazon
        /// SNS) topic that you want to notify when Elastic Transcoder has started to process
        /// a job in this pipeline. This is the ARN that Amazon SNS returned when you created
        /// the topic. For more information, see Create a Topic in the Amazon Simple Notification
        /// Service Developer Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Complete</b>: The topic ARN for the Amazon SNS topic that you want to notify when
        /// Elastic Transcoder has finished processing a job in this pipeline. This is the ARN
        /// that Amazon SNS returned when you created the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Warning</b>: The topic ARN for the Amazon SNS topic that you want to notify when
        /// Elastic Transcoder encounters a warning condition while processing a job in this pipeline.
        /// This is the ARN that Amazon SNS returned when you created the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Error</b>: The topic ARN for the Amazon SNS topic that you want to notify when
        /// Elastic Transcoder encounters an error condition while processing a job in this pipeline.
        /// This is the ARN that Amazon SNS returned when you created the topic.
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
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save the transcoded files.
        /// (Use this, or use ContentConfig:Bucket plus ThumbnailConfig:Bucket.)
        /// </para>
        ///  
        /// <para>
        /// Specify this value when all of the following are true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You want to save transcoded files, thumbnails (if any), and playlists (if any) together
        /// in one bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You do not want to specify the users or groups who have access to the transcoded files,
        /// thumbnails, and playlists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You do not want to specify the permissions that Elastic Transcoder grants to the files.
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        /// When Elastic Transcoder saves files in <c>OutputBucket</c>, it grants full control
        /// over the files only to the AWS account that owns the role that is specified by <c>Role</c>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// You want to associate the transcoded files and thumbnails with the Amazon S3 Standard
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you want to save transcoded files and playlists in one bucket and thumbnails in
        /// another bucket, specify which users can access the transcoded files or the permissions
        /// the users have, or change the Amazon S3 storage class, omit <c>OutputBucket</c> and
        /// specify values for <c>ContentConfig</c> and <c>ThumbnailConfig</c> instead.
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
        /// The IAM Amazon Resource Name (ARN) for the role that you want Elastic Transcoder to
        /// use to create the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ThumbnailConfig. 
        /// <para>
        /// The <c>ThumbnailConfig</c> object specifies several values, including the Amazon S3
        /// bucket in which you want Elastic Transcoder to save thumbnail files, which users you
        /// want to have access to the files, the type of access you want users to have, and the
        /// storage class that you want to assign to the files.
        /// </para>
        ///  
        /// <para>
        /// If you specify values for <c>ContentConfig</c>, you must also specify values for <c>ThumbnailConfig</c>
        /// even if you don't want to create thumbnails.
        /// </para>
        ///  
        /// <para>
        /// If you specify values for <c>ContentConfig</c> and <c>ThumbnailConfig</c>, omit the
        /// <c>OutputBucket</c> object.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Bucket</b>: The Amazon S3 bucket in which you want Elastic Transcoder to save
        /// thumbnail files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Permissions</b> (Optional): The <c>Permissions</c> object specifies which users
        /// and/or predefined Amazon S3 groups you want to have access to thumbnail files, and
        /// the type of access you want them to have. You can grant permissions to a maximum of
        /// 30 users and/or predefined Amazon S3 groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GranteeType</b>: Specify the type of value that appears in the Grantee object:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Canonical</b>: The value in the <c>Grantee</c> object is either the canonical
        /// user ID for an AWS account or an origin access identity for an Amazon CloudFront distribution.
        /// </para>
        ///  <important> 
        /// <para>
        /// A canonical user ID is not the same as an AWS account number.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <b>Email</b>: The value in the <c>Grantee</c> object is the registered email address
        /// of an AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Group</b>: The value in the <c>Grantee</c> object is one of the following predefined
        /// Amazon S3 groups: <c>AllUsers</c>, <c>AuthenticatedUsers</c>, or <c>LogDelivery</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Grantee</b>: The AWS user or group that you want to have access to thumbnail files.
        /// To identify the user or group, you can specify the canonical user ID for an AWS account,
        /// an origin access identity for a CloudFront distribution, the registered email address
        /// of an AWS account, or a predefined Amazon S3 group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access</b>: The permission that you want to give to the AWS user that you specified
        /// in <c>Grantee</c>. Permissions are granted on the thumbnail files that Elastic Transcoder
        /// adds to the bucket. Valid values include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>READ</c>: The grantee can read the thumbnails and metadata for objects that Elastic
        /// Transcoder adds to the Amazon S3 bucket.
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
        ///  <c>FULL_CONTROL</c>: The grantee has <c>READ</c>, <c>READ_ACP</c>, and <c>WRITE_ACP</c>
        /// permissions for the thumbnails that Elastic Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>StorageClass</b>: The Amazon S3 storage class, <c>Standard</c> or <c>ReducedRedundancy</c>,
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