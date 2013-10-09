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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>The pipeline (queue) that is used to manage jobs.</para>
    /// </summary>
    public class Pipeline
    {
        
        private string id;
        private string arn;
        private string name;
        private string status;
        private string inputBucket;
        private string outputBucket;
        private string role;
        private Notifications notifications;
        private PipelineOutputConfig contentConfig;
        private PipelineOutputConfig thumbnailConfig;

        /// <summary>
        /// The identifier for the pipeline. You use this value to identify the pipeline in which you want to perform a variety of operations, such as
        /// creating a job or a preset.
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

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Pipeline WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) for the pipeline.
        ///  
        /// </summary>
        public string Arn
        {
            get { return this.arn; }
            set { this.arn = value; }
        }

        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Pipeline WithArn(string arn)
        {
            this.arn = arn;
            return this;
        }
            

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;
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

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Pipeline WithName(string name)
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
        /// The current status of the pipeline: <ul> <li><c>Active</c>: The pipeline is processing jobs.</li> <li><c>Paused</c>: The pipeline is not
        /// currently processing jobs.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Active$)|(^Paused$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Pipeline WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The Amazon S3 bucket from which Elastic Transcoder gets media files for transcoding and the graphics files, if any, that you want to use for
        /// watermarks.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Pipeline WithInputBucket(string inputBucket)
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
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save transcoded files, thumbnails, and playlists. Either you specify this
        /// value, or you specify both <c>ContentConfig</c> and <c>ThumbnailConfig</c>.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Pipeline WithOutputBucket(string outputBucket)
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
        /// The IAM Amazon Resource Name (ARN) for the role that Elastic Transcoder uses to transcode jobs for this pipeline.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Pipeline WithRole(string role)
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
        /// you must also subscribe to the new topic in the Amazon SNS console.</important> <ul> <li><b>Progressing</b> (optional): The Amazon Simple
        /// Notification Service (Amazon SNS) topic that you want to notify when Elastic Transcoder has started to process the job.</li>
        /// <li><b>Completed</b> (optional): The Amazon SNS topic that you want to notify when Elastic Transcoder has finished processing the job.</li>
        /// <li><b>Warning</b> (optional): The Amazon SNS topic that you want to notify when Elastic Transcoder encounters a warning condition.</li>
        /// <li><b>Error</b> (optional): The Amazon SNS topic that you want to notify when Elastic Transcoder encounters an error condition.</li> </ul>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Pipeline WithNotifications(Notifications notifications)
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
        /// Information about the Amazon S3 bucket in which you want Elastic Transcoder to save transcoded files and playlists. Either you specify both
        /// <c>ContentConfig</c> and <c>ThumbnailConfig</c>, or you specify <c>OutputBucket</c>. <ul> <li><b>Bucket</b>: The Amazon S3 bucket in which
        /// you want Elastic Transcoder to save transcoded files and playlists.</li> <li><b>Permissions</b>: A list of the users and/or predefined
        /// Amazon S3 groups you want to have access to transcoded files and playlists, and the type of access that you want them to have. <ul>
        /// <li>GranteeType: The type of value that appears in the <c>Grantee</c> object: <ul> <li><c>Canonical</c>: Either the canonical user ID for an
        /// AWS account or an origin access identity for an Amazon CloudFront distribution.</li> <li><c>Email</c>: The registered email address of an
        /// AWS account.</li> <li><c>Group</c>: One of the following predefined Amazon S3 groups: <c>AllUsers</c>, <c>AuthenticatedUsers</c>, or
        /// <c>LogDelivery</c>.</li> </ul> </li> <li><c>Grantee</c>: The AWS user or group that you want to have access to transcoded files and
        /// playlists.</li> <li><c>Access</c>: The permission that you want to give to the AWS user that is listed in <c>Grantee</c>. Valid values
        /// include: <ul> <li><c>READ</c>: The grantee can read the objects and metadata for objects that Elastic Transcoder adds to the Amazon S3
        /// bucket.</li> <li><c>READ_ACP</c>: The grantee can read the object ACL for objects that Elastic Transcoder adds to the Amazon S3 bucket.</li>
        /// <li><c>WRITE_ACP</c>: The grantee can write the ACL for the objects that Elastic Transcoder adds to the Amazon S3 bucket.</li>
        /// <li><c>FULL_CONTROL</c>: The grantee has <c>READ</c>, <c>READ_ACP</c>, and <c>WRITE_ACP</c> permissions for the objects that Elastic
        /// Transcoder adds to the Amazon S3 bucket.</li> </ul> </li> </ul> </li> <li><b>StorageClass</b>: The Amazon S3 storage class, Standard or
        /// ReducedRedundancy, that you want Elastic Transcoder to assign to the video files and playlists that it stores in your Amazon S3 bucket.
        /// </li> </ul>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Pipeline WithContentConfig(PipelineOutputConfig contentConfig)
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
        /// Information about the Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files. Either you specify both
        /// <c>ContentConfig</c> and <c>ThumbnailConfig</c>, or you specify <c>OutputBucket</c>. <ul> <li><c>Bucket</c>: The Amazon S3 bucket in which
        /// you want Elastic Transcoder to save thumbnail files. </li> <li><c>Permissions</c>: A list of the users and/or predefined Amazon S3 groups
        /// you want to have access to thumbnail files, and the type of access that you want them to have. <ul> <li>GranteeType: The type of value that
        /// appears in the Grantee object: <ul> <li><c>Canonical</c>: Either the canonical user ID for an AWS account or an origin access identity for
        /// an Amazon CloudFront distribution. <important>A canonical user ID is not the same as an AWS account number.</important></li>
        /// <li><c>Email</c>: The registered email address of an AWS account.</li> <li><c>Group</c>: One of the following predefined Amazon S3 groups:
        /// <c>AllUsers</c>, <c>AuthenticatedUsers</c>, or <c>LogDelivery</c>.</li> </ul> </li> <li><c>Grantee</c>: The AWS user or group that you want
        /// to have access to thumbnail files.</li> <li>Access: The permission that you want to give to the AWS user that is listed in Grantee. Valid
        /// values include: <ul> <li><c>READ</c>: The grantee can read the thumbnails and metadata for thumbnails that Elastic Transcoder adds to the
        /// Amazon S3 bucket.</li> <li><c>READ_ACP</c>: The grantee can read the object ACL for thumbnails that Elastic Transcoder adds to the Amazon S3
        /// bucket.</li> <li><c>WRITE_ACP</c>: The grantee can write the ACL for the thumbnails that Elastic Transcoder adds to the Amazon S3
        /// bucket.</li> <li><c>FULL_CONTROL</c>: The grantee has READ, READ_ACP, and WRITE_ACP permissions for the thumbnails that Elastic Transcoder
        /// adds to the Amazon S3 bucket.</li> </ul> </li> </ul> </li> <li><c>StorageClass</c>: The Amazon S3 storage class, <c>Standard</c> or
        /// <c>ReducedRedundancy</c>, that you want Elastic Transcoder to assign to the thumbnails that it stores in your Amazon S3 bucket.</li> </ul>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Pipeline WithThumbnailConfig(PipelineOutputConfig thumbnailConfig)
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
