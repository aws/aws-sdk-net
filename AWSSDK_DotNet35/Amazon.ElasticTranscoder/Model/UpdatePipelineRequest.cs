/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the UpdatePipeline operation.
    /// <para> Use the <c>UpdatePipeline</c> operation to update settings for a pipeline. <para><b>IMPORTANT:</b>When you change pipeline settings,
    /// your changes take effect immediately. Jobs that you have already submitted and that Elastic Transcoder has not started to process are
    /// affected in addition to jobs that you submit after you change settings. </para> </para>
    /// </summary>
    public partial class UpdatePipelineRequest : AmazonElasticTranscoderRequest
    {
        private string id;
        private string name;
        private string inputBucket;
        private string role;
        private Notifications notifications;
        private PipelineOutputConfig contentConfig;
        private PipelineOutputConfig thumbnailConfig;


        /// <summary>
        /// The ID of the pipeline that you want to update.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The name of the pipeline. We recommend that the name be unique within the AWS account, but uniqueness is not enforced. Constraints: Maximum
        /// 40 characters
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 40</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The Amazon S3 bucket in which you saved the media files that you want to transcode and the graphics that you want to use as watermarks.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^(\w|\.|-){1,255}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InputBucket
        {
            get { return this.inputBucket; }
            set { this.inputBucket = value; }
        }

        // Check to see if InputBucket property is set
        internal bool IsSetInputBucket()
        {
            return this.inputBucket != null;
        }

        /// <summary>
        /// The IAM Amazon Resource Name (ARN) for the role that you want Elastic Transcoder to use to transcode jobs for this pipeline.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^arn:aws:iam::\w{12}:role/.+$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this.role != null;
        }

        /// <summary>
        /// The Amazon Simple Notification Service (Amazon SNS) topic or topics to notify in order to report job status. <important>To receive
        /// notifications, you must also subscribe to the new topic in the Amazon SNS console.</important>
        ///  
        /// </summary>
        public Notifications Notifications
        {
            get { return this.notifications; }
            set { this.notifications = value; }
        }

        // Check to see if Notifications property is set
        internal bool IsSetNotifications()
        {
            return this.notifications != null;
        }

        /// <summary>
        /// The optional <c>ContentConfig</c> object specifies information about the Amazon S3 bucket in which you want Elastic Transcoder to save
        /// transcoded files and playlists: which bucket to use, which users you want to have access to the files, the type of access you want users to
        /// have, and the storage class that you want to assign to the files. If you specify values for <c>ContentConfig</c>, you must also specify
        /// values for <c>ThumbnailConfig</c>. If you specify values for <c>ContentConfig</c> and <c>ThumbnailConfig</c>, omit the <c>OutputBucket</c>
        /// object. <ul> <li><b>Bucket</b>: The Amazon S3 bucket in which you want Elastic Transcoder to save transcoded files and playlists.</li>
        /// <li><b>Permissions</b> (Optional): The Permissions object specifies which users you want to have access to transcoded files and the type of
        /// access you want them to have. You can grant permissions to a maximum of 30 users and/or predefined Amazon S3 groups.</li> <li><b>Grantee
        /// Type</b>: Specify the type of value that appears in the <c>Grantee</c> object: <ul> <li><b>Canonical</b>: The value in the <c>Grantee</c>
        /// object is either the canonical user ID for an AWS account or an origin access identity for an Amazon CloudFront distribution. For more
        /// information about canonical user IDs, see Access Control List (ACL) Overview in the Amazon Simple Storage Service Developer Guide. For more
        /// information about using CloudFront origin access identities to require that users use CloudFront URLs instead of Amazon S3 URLs, see Using
        /// an Origin Access Identity to Restrict Access to Your Amazon S3 Content. <important>A canonical user ID is not the same as an AWS account
        /// number.</important> </li> <li><b>Email</b>: The value in the <c>Grantee</c> object is the registered email address of an AWS account.</li>
        /// <li><b>Group</b>: The value in the <c>Grantee</c> object is one of the following predefined Amazon S3 groups: <c>AllUsers</c>,
        /// <c>AuthenticatedUsers</c>, or <c>LogDelivery</c>.</li> </ul> </li> <li> <b>Grantee</b>: The AWS user or group that you want to have access
        /// to transcoded files and playlists. To identify the user or group, you can specify the canonical user ID for an AWS account, an origin access
        /// identity for a CloudFront distribution, the registered email address of an AWS account, or a predefined Amazon S3 group </li> <li>
        /// <b>Access</b>: The permission that you want to give to the AWS user that you specified in <c>Grantee</c>. Permissions are granted on the
        /// files that Elastic Transcoder adds to the bucket, including playlists and video files. Valid values include: <ul> <li><c>READ</c>: The
        /// grantee can read the objects and metadata for objects that Elastic Transcoder adds to the Amazon S3 bucket.</li> <li><c>READ_ACP</c>: The
        /// grantee can read the object ACL for objects that Elastic Transcoder adds to the Amazon S3 bucket. </li> <li><c>WRITE_ACP</c>: The grantee
        /// can write the ACL for the objects that Elastic Transcoder adds to the Amazon S3 bucket.</li> <li><c>FULL_CONTROL</c>: The grantee has
        /// <c>READ</c>, <c>READ_ACP</c>, and <c>WRITE_ACP</c> permissions for the objects that Elastic Transcoder adds to the Amazon S3 bucket.</li>
        /// </ul> </li> <li> <b>StorageClass</b>: The Amazon S3 storage class, <c>Standard</c> or <c>ReducedRedundancy</c>, that you want Elastic
        /// Transcoder to assign to the video files and playlists that it stores in your Amazon S3 bucket.</li> </ul>
        ///  
        /// </summary>
        public PipelineOutputConfig ContentConfig
        {
            get { return this.contentConfig; }
            set { this.contentConfig = value; }
        }

        // Check to see if ContentConfig property is set
        internal bool IsSetContentConfig()
        {
            return this.contentConfig != null;
        }

        /// <summary>
        /// The <c>ThumbnailConfig</c> object specifies several values, including the Amazon S3 bucket in which you want Elastic Transcoder to save
        /// thumbnail files, which users you want to have access to the files, the type of access you want users to have, and the storage class that you
        /// want to assign to the files. If you specify values for <c>ContentConfig</c>, you must also specify values for <c>ThumbnailConfig</c> even if
        /// you don't want to create thumbnails. If you specify values for <c>ContentConfig</c> and <c>ThumbnailConfig</c>, omit the <c>OutputBucket</c>
        /// object. <ul> <li><b>Bucket</b>: The Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files.</li>
        /// <li><b>Permissions</b> (Optional): The <c>Permissions</c> object specifies which users and/or predefined Amazon S3 groups you want to have
        /// access to thumbnail files, and the type of access you want them to have. You can grant permissions to a maximum of 30 users and/or
        /// predefined Amazon S3 groups.</li> <li> <b>GranteeType</b>: Specify the type of value that appears in the Grantee object: <ul> <li>
        /// <b>Canonical</b>: The value in the <c>Grantee</c> object is either the canonical user ID for an AWS account or an origin access identity for
        /// an Amazon CloudFront distribution. <important>A canonical user ID is not the same as an AWS account number.</important></li>
        /// <li><b>Email</b>: The value in the <c>Grantee</c> object is the registered email address of an AWS account. </li> <li><b>Group</b>: The
        /// value in the <c>Grantee</c> object is one of the following predefined Amazon S3 groups: <c>AllUsers</c>, <c>AuthenticatedUsers</c>, or
        /// <c>LogDelivery</c>.</li> </ul> </li> <li> <b>Grantee</b>: The AWS user or group that you want to have access to thumbnail files. To identify
        /// the user or group, you can specify the canonical user ID for an AWS account, an origin access identity for a CloudFront distribution, the
        /// registered email address of an AWS account, or a predefined Amazon S3 group. </li> <li> <b>Access</b>: The permission that you want to give
        /// to the AWS user that you specified in <c>Grantee</c>. Permissions are granted on the thumbnail files that Elastic Transcoder adds to the
        /// bucket. Valid values include: <ul> <li><c>READ</c>: The grantee can read the thumbnails and metadata for objects that Elastic Transcoder
        /// adds to the Amazon S3 bucket.</li> <li><c>READ_ACP</c>: The grantee can read the object ACL for thumbnails that Elastic Transcoder adds to
        /// the Amazon S3 bucket. </li> <li><c>WRITE_ACP</c>: The grantee can write the ACL for the thumbnails that Elastic Transcoder adds to the
        /// Amazon S3 bucket.</li> <li><c>FULL_CONTROL</c>: The grantee has <c>READ</c>, <c>READ_ACP</c>, and <c>WRITE_ACP</c> permissions for the
        /// thumbnails that Elastic Transcoder adds to the Amazon S3 bucket. </li> </ul> </li> <li> <b>StorageClass</b>: The Amazon S3 storage class,
        /// <c>Standard</c> or <c>ReducedRedundancy</c>, that you want Elastic Transcoder to assign to the thumbnails that it stores in your Amazon S3
        /// bucket.</li> </ul>
        ///  
        /// </summary>
        public PipelineOutputConfig ThumbnailConfig
        {
            get { return this.thumbnailConfig; }
            set { this.thumbnailConfig = value; }
        }

        // Check to see if ThumbnailConfig property is set
        internal bool IsSetThumbnailConfig()
        {
            return this.thumbnailConfig != null;
        }

    }
}
    
