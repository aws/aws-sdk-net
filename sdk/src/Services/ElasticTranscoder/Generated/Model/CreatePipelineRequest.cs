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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        /// If you use either <code>S3</code> or <code>S3-AWS-KMS</code> as your <code>Encryption:Mode</code>,
        /// you don't need to provide a key with your job because a default key, known as an AWS-KMS
        /// key, is created for you automatically. You need to provide an AWS-KMS key only if
        /// you want to use a non-default AWS-KMS key, or if you are using an <code>Encryption:Mode</code>
        /// of <code>AES-PKCS7</code>, <code>AES-CTR</code>, or <code>AES-GCM</code>.
        /// </para>
        /// </summary>
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
        /// The optional <code>ContentConfig</code> object specifies information about the Amazon
        /// S3 bucket in which you want Elastic Transcoder to save transcoded files and playlists:
        /// which bucket to use, which users you want to have access to the files, the type of
        /// access you want users to have, and the storage class that you want to assign to the
        /// files.
        /// </para>
        ///  
        /// <para>
        /// If you specify values for <code>ContentConfig</code>, you must also specify values
        /// for <code>ThumbnailConfig</code>.
        /// </para>
        ///  
        /// <para>
        /// If you specify values for <code>ContentConfig</code> and <code>ThumbnailConfig</code>,
        /// omit the <code>OutputBucket</code> object.
        /// </para>
        ///  <ul> <li><b>Bucket</b>: The Amazon S3 bucket in which you want Elastic Transcoder
        /// to save transcoded files and playlists.</li> <li><b>Permissions</b> (Optional): The
        /// Permissions object specifies which users you want to have access to transcoded files
        /// and the type of access you want them to have. You can grant permissions to a maximum
        /// of 30 users and/or predefined Amazon S3 groups.</li> <li><b>Grantee Type</b>: Specify
        /// the type of value that appears in the <code>Grantee</code> object: <ul> <li><b>Canonical</b>:
        /// The value in the <code>Grantee</code> object is either the canonical user ID for an
        /// AWS account or an origin access identity for an Amazon CloudFront distribution. For
        /// more information about canonical user IDs, see Access Control List (ACL) Overview
        /// in the Amazon Simple Storage Service Developer Guide. For more information about using
        /// CloudFront origin access identities to require that users use CloudFront URLs instead
        /// of Amazon S3 URLs, see Using an Origin Access Identity to Restrict Access to Your
        /// Amazon S3 Content. <important>A canonical user ID is not the same as an AWS account
        /// number.</important> </li> <li><b>Email</b>: The value in the <code>Grantee</code>
        /// object is the registered email address of an AWS account.</li> <li><b>Group</b>: The
        /// value in the <code>Grantee</code> object is one of the following predefined Amazon
        /// S3 groups: <code>AllUsers</code>, <code>AuthenticatedUsers</code>, or <code>LogDelivery</code>.</li>
        /// </ul> </li> <li> <b>Grantee</b>: The AWS user or group that you want to have access
        /// to transcoded files and playlists. To identify the user or group, you can specify
        /// the canonical user ID for an AWS account, an origin access identity for a CloudFront
        /// distribution, the registered email address of an AWS account, or a predefined Amazon
        /// S3 group </li> <li> <b>Access</b>: The permission that you want to give to the AWS
        /// user that you specified in <code>Grantee</code>. Permissions are granted on the files
        /// that Elastic Transcoder adds to the bucket, including playlists and video files. Valid
        /// values include: <ul> <li><code>READ</code>: The grantee can read the objects and metadata
        /// for objects that Elastic Transcoder adds to the Amazon S3 bucket.</li> <li><code>READ_ACP</code>:
        /// The grantee can read the object ACL for objects that Elastic Transcoder adds to the
        /// Amazon S3 bucket. </li> <li><code>WRITE_ACP</code>: The grantee can write the ACL
        /// for the objects that Elastic Transcoder adds to the Amazon S3 bucket.</li> <li><code>FULL_CONTROL</code>:
        /// The grantee has <code>READ</code>, <code>READ_ACP</code>, and <code>WRITE_ACP</code>
        /// permissions for the objects that Elastic Transcoder adds to the Amazon S3 bucket.</li>
        /// </ul> </li> <li> <b>StorageClass</b>: The Amazon S3 storage class, <code>Standard</code>
        /// or <code>ReducedRedundancy</code>, that you want Elastic Transcoder to assign to the
        /// video files and playlists that it stores in your Amazon S3 bucket.</li> </ul>
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
        ///  <important>To receive notifications, you must also subscribe to the new topic in
        /// the Amazon SNS console.</important> <ul> <li><b>Progressing</b>: The topic ARN for
        /// the Amazon Simple Notification Service (Amazon SNS) topic that you want to notify
        /// when Elastic Transcoder has started to process a job in this pipeline. This is the
        /// ARN that Amazon SNS returned when you created the topic. For more information, see
        /// Create a Topic in the Amazon Simple Notification Service Developer Guide.</li> <li><b>Completed</b>:
        /// The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder
        /// has finished processing a job in this pipeline. This is the ARN that Amazon SNS returned
        /// when you created the topic.</li> <li><b>Warning</b>: The topic ARN for the Amazon
        /// SNS topic that you want to notify when Elastic Transcoder encounters a warning condition
        /// while processing a job in this pipeline. This is the ARN that Amazon SNS returned
        /// when you created the topic.</li> <li><b>Error</b>: The topic ARN for the Amazon SNS
        /// topic that you want to notify when Elastic Transcoder encounters an error condition
        /// while processing a job in this pipeline. This is the ARN that Amazon SNS returned
        /// when you created the topic.</li> </ul>
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
        /// Specify this value when all of the following are true: <ul> <li>You want to save transcoded
        /// files, thumbnails (if any), and playlists (if any) together in one bucket.</li> <li>You
        /// do not want to specify the users or groups who have access to the transcoded files,
        /// thumbnails, and playlists.</li> <li>You do not want to specify the permissions that
        /// Elastic Transcoder grants to the files. <important>When Elastic Transcoder saves files
        /// in <code>OutputBucket</code>, it grants full control over the files only to the AWS
        /// account that owns the role that is specified by <code>Role</code>.</important></li>
        /// <li>You want to associate the transcoded files and thumbnails with the Amazon S3 Standard
        /// storage class.</li> </ul>
        /// </para>
        ///  
        /// <para>
        /// If you want to save transcoded files and playlists in one bucket and thumbnails in
        /// another bucket, specify which users can access the transcoded files or the permissions
        /// the users have, or change the Amazon S3 storage class, omit <code>OutputBucket</code>
        /// and specify values for <code>ContentConfig</code> and <code>ThumbnailConfig</code>
        /// instead.
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
        /// The <code>ThumbnailConfig</code> object specifies several values, including the Amazon
        /// S3 bucket in which you want Elastic Transcoder to save thumbnail files, which users
        /// you want to have access to the files, the type of access you want users to have, and
        /// the storage class that you want to assign to the files.
        /// </para>
        ///  
        /// <para>
        /// If you specify values for <code>ContentConfig</code>, you must also specify values
        /// for <code>ThumbnailConfig</code> even if you don't want to create thumbnails.
        /// </para>
        ///  
        /// <para>
        /// If you specify values for <code>ContentConfig</code> and <code>ThumbnailConfig</code>,
        /// omit the <code>OutputBucket</code> object.
        /// </para>
        ///  <ul> <li><b>Bucket</b>: The Amazon S3 bucket in which you want Elastic Transcoder
        /// to save thumbnail files.</li> <li><b>Permissions</b> (Optional): The <code>Permissions</code>
        /// object specifies which users and/or predefined Amazon S3 groups you want to have access
        /// to thumbnail files, and the type of access you want them to have. You can grant permissions
        /// to a maximum of 30 users and/or predefined Amazon S3 groups.</li> <li> <b>GranteeType</b>:
        /// Specify the type of value that appears in the Grantee object: <ul> <li> <b>Canonical</b>:
        /// The value in the <code>Grantee</code> object is either the canonical user ID for an
        /// AWS account or an origin access identity for an Amazon CloudFront distribution. <important>A
        /// canonical user ID is not the same as an AWS account number.</important></li> <li><b>Email</b>:
        /// The value in the <code>Grantee</code> object is the registered email address of an
        /// AWS account. </li> <li><b>Group</b>: The value in the <code>Grantee</code> object
        /// is one of the following predefined Amazon S3 groups: <code>AllUsers</code>, <code>AuthenticatedUsers</code>,
        /// or <code>LogDelivery</code>.</li> </ul> </li> <li> <b>Grantee</b>: The AWS user or
        /// group that you want to have access to thumbnail files. To identify the user or group,
        /// you can specify the canonical user ID for an AWS account, an origin access identity
        /// for a CloudFront distribution, the registered email address of an AWS account, or
        /// a predefined Amazon S3 group. </li> <li> <b>Access</b>: The permission that you want
        /// to give to the AWS user that you specified in <code>Grantee</code>. Permissions are
        /// granted on the thumbnail files that Elastic Transcoder adds to the bucket. Valid values
        /// include: <ul> <li><code>READ</code>: The grantee can read the thumbnails and metadata
        /// for objects that Elastic Transcoder adds to the Amazon S3 bucket.</li> <li><code>READ_ACP</code>:
        /// The grantee can read the object ACL for thumbnails that Elastic Transcoder adds to
        /// the Amazon S3 bucket. </li> <li><code>WRITE_ACP</code>: The grantee can write the
        /// ACL for the thumbnails that Elastic Transcoder adds to the Amazon S3 bucket.</li>
        /// <li><code>FULL_CONTROL</code>: The grantee has <code>READ</code>, <code>READ_ACP</code>,
        /// and <code>WRITE_ACP</code> permissions for the thumbnails that Elastic Transcoder
        /// adds to the Amazon S3 bucket. </li> </ul> </li> <li> <b>StorageClass</b>: The Amazon
        /// S3 storage class, <code>Standard</code> or <code>ReducedRedundancy</code>, that you
        /// want Elastic Transcoder to assign to the thumbnails that it stores in your Amazon
        /// S3 bucket.</li> </ul>
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