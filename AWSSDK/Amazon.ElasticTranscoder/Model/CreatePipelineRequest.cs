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
    /// Container for the parameters to the CreatePipeline operation.
    /// <para>To create a pipeline, send a POST request to the <c>2012-09-25/pipelines</c> resource.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreatePipeline"/>
    public class CreatePipelineRequest : AmazonWebServiceRequest
    {
        private string name;
        private string inputBucket;
        private string outputBucket;
        private string role;
        private Notifications notifications;
        private PipelineOutputConfig contentConfig;
        private PipelineOutputConfig thumbnailConfig;

        /// <summary>
        /// The name of the pipeline. We recommend that the name be unique within the AWS account, but uniqueness is not enforced. Constraints: Maximum
        /// 40 characters.
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

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public CreatePipelineRequest WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The Amazon S3 bucket in which you saved the media files that you want to transcode.
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

        /// <summary>
        /// Sets the InputBucket property
        /// </summary>
        /// <param name="inputBucket">The value to set for the InputBucket property </param>
        /// <returns>this instance</returns>
        public CreatePipelineRequest WithInputBucket(string inputBucket)
        {
            this.inputBucket = inputBucket;
            return this;
        }
            

        // Check to see if InputBucket property is set
        internal bool IsSetInputBucket()
        {
            return this.inputBucket != null;
        }

        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save the transcoded files. (Use this, or use ContentConfig:Bucket plus
        /// ThumbnailConfig:Bucket.) Specify this value when all of the following are true: <ul> <li>You want to save transcoded files, thumbnails (if
        /// any), and playlists (if any) together in one bucket.</li> <li>You do not want to specify the users or groups who have access to the
        /// transcoded files, thumbnails, and playlists.</li> <li>You do not want to specify the permissions that Elastic Transcoder grants to the
        /// files. <important>When Elastic Transcoder saves files in <c>OutputBucket</c>, it grants full control over the files only to the AWS account
        /// that owns the role that is specified by <c>Role</c>.</important></li> <li>You want to associate the transcoded files and thumbnails with the
        /// Amazon S3 Standard storage class.</li> </ul> If you want to save transcoded files and playlists in one bucket and thumbnails in another
        /// bucket, specify which users can access the transcoded files or the permissions the users have, or change the Amazon S3 storage class, omit
        /// <c>OutputBucket</c> and specify values for <c>ContentConfig</c> and <c>ThumbnailConfig</c> instead.
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
        public string OutputBucket
        {
            get { return this.outputBucket; }
            set { this.outputBucket = value; }
        }

        /// <summary>
        /// Sets the OutputBucket property
        /// </summary>
        /// <param name="outputBucket">The value to set for the OutputBucket property </param>
        /// <returns>this instance</returns>
        public CreatePipelineRequest WithOutputBucket(string outputBucket)
        {
            this.outputBucket = outputBucket;
            return this;
        }
            

        // Check to see if OutputBucket property is set
        internal bool IsSetOutputBucket()
        {
            return this.outputBucket != null;
        }

        /// <summary>
        /// The IAM Amazon Resource Name (ARN) for the role that you want Elastic Transcoder to use to create the pipeline.
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

        /// <summary>
        /// Sets the Role property
        /// </summary>
        /// <param name="role">The value to set for the Role property </param>
        /// <returns>this instance</returns>
        public CreatePipelineRequest WithRole(string role)
        {
            this.role = role;
            return this;
        }
            

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this.role != null;
        }

        /// <summary>
        /// The Amazon Simple Notification Service (Amazon SNS) topic that you want to notify to report job status. <important>To receive notifications,
        /// you must also subscribe to the new topic in the Amazon SNS console.</important> <ul> <li><b>Progressing</b>: The topic ARN for the Amazon
        /// Simple Notification Service (Amazon SNS) topic that you want to notify when Elastic Transcoder has started to process a job in this
        /// pipeline. This is the ARN that Amazon SNS returned when you created the topic. For more information, see Create a Topic in the Amazon Simple
        /// Notification Service Developer Guide.</li> <li><b>Completed</b>: The topic ARN for the Amazon SNS topic that you want to notify when Elastic
        /// Transcoder has finished processing a job in this pipeline. This is the ARN that Amazon SNS returned when you created the topic.</li>
        /// <li><b>Warning</b>: The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder encounters a warning condition
        /// while processing a job in this pipeline. This is the ARN that Amazon SNS returned when you created the topic.</li> <li><b>Error</b>: The
        /// topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder encounters an error condition while processing a job in
        /// this pipeline. This is the ARN that Amazon SNS returned when you created the topic.</li> </ul>
        ///  
        /// </summary>
        public Notifications Notifications
        {
            get { return this.notifications; }
            set { this.notifications = value; }
        }

        /// <summary>
        /// Sets the Notifications property
        /// </summary>
        /// <param name="notifications">The value to set for the Notifications property </param>
        /// <returns>this instance</returns>
        public CreatePipelineRequest WithNotifications(Notifications notifications)
        {
            this.notifications = notifications;
            return this;
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

        /// <summary>
        /// Sets the ContentConfig property
        /// </summary>
        /// <param name="contentConfig">The value to set for the ContentConfig property </param>
        /// <returns>this instance</returns>
        public CreatePipelineRequest WithContentConfig(PipelineOutputConfig contentConfig)
        {
            this.contentConfig = contentConfig;
            return this;
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
        /// bucket. </li> </ul>
        ///  
        /// </summary>
        public PipelineOutputConfig ThumbnailConfig
        {
            get { return this.thumbnailConfig; }
            set { this.thumbnailConfig = value; }
        }

        /// <summary>
        /// Sets the ThumbnailConfig property
        /// </summary>
        /// <param name="thumbnailConfig">The value to set for the ThumbnailConfig property </param>
        /// <returns>this instance</returns>
        public CreatePipelineRequest WithThumbnailConfig(PipelineOutputConfig thumbnailConfig)
        {
            this.thumbnailConfig = thumbnailConfig;
            return this;
        }
            

        // Check to see if ThumbnailConfig property is set
        internal bool IsSetThumbnailConfig()
        {
            return this.thumbnailConfig != null;
        }
    }
}
    
