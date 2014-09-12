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
    /// The pipeline (queue) that is used to manage jobs.
    /// </summary>
    public partial class Pipeline
    {
        private string _arn;
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
        /// Gets and sets the property ContentConfig. 
        /// <para>
        /// Information about the Amazon S3 bucket in which you want Elastic Transcoder to save
        ///            transcoded files and playlists. Either you specify both <code>ContentConfig</code>
        /// and                <code>ThumbnailConfig</code>, or you specify <code>OutputBucket</code>.
        /// </para>
        ///         <ul>            <li><b>Bucket</b>: The Amazon S3 bucket in which you want
        /// Elastic Transcoder to save                transcoded files and playlists.</li>   
        ///         <li><b>Permissions</b>: A list of the users and/or predefined Amazon S3 groups
        /// you want                to have access to transcoded files and playlists, and the
        /// type of access that you                want them to have. <ul>                   
        /// <li>GranteeType: The type of value that appears in the <code>Grantee</code>      
        ///                  object: <ul>                            <li><code>Canonical</code>:
        /// Either the canonical user ID for an AWS                                account or
        /// an origin access identity for an Amazon CloudFront                               
        /// distribution.</li>                            <li><code>Email</code>: The registered
        /// email address of an AWS                                account.</li>             
        ///               <li><code>Group</code>: One of the following predefined Amazon S3  
        ///                              groups: <code>AllUsers</code>, <code>AuthenticatedUsers</code>,
        /// or                                    <code>LogDelivery</code>.</li>             
        ///           </ul>                    </li>                    <li><code>Grantee</code>:
        /// The AWS user or group that you want to have access to                        transcoded
        /// files and playlists.</li>                    <li><code>Access</code>: The permission
        /// that you want to give to the AWS user                        that is listed in <code>Grantee</code>.
        /// Valid values include: <ul>                            <li><code>READ</code>: The grantee
        /// can read the objects and metadata for                                objects that
        /// Elastic Transcoder adds to the Amazon S3 bucket.</li>                            <li><code>READ_ACP</code>:
        /// The grantee can read the object ACL for                                objects that
        /// Elastic Transcoder adds to the Amazon S3 bucket.</li>                            <li><code>WRITE_ACP</code>:
        /// The grantee can write the ACL for the                                objects that
        /// Elastic Transcoder adds to the Amazon S3 bucket.</li>                            <li><code>FULL_CONTROL</code>:
        /// The grantee has <code>READ</code>,                                    <code>READ_ACP</code>,
        /// and <code>WRITE_ACP</code> permissions                                for the objects
        /// that Elastic Transcoder adds to the Amazon S3                                bucket.</li>
        ///                        </ul>                    </li>                </ul>       
        ///     </li>            <li><b>StorageClass</b>: The Amazon S3 storage class, Standard
        /// or ReducedRedundancy,                that you want Elastic Transcoder to assign to
        /// the video files and playlists that it                stores in your Amazon S3 bucket.
        /// </li>        </ul>
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
        /// you            want to perform a variety of operations, such as creating a job or
        /// a preset. 
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
        /// and the            graphics files, if any, that you want to use for watermarks.
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
        ///            but uniqueness is not enforced.
        /// </para>
        ///         
        /// <para>
        /// Constraints: Maximum 40 characters
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
        ///         <important>To receive notifications, you must also subscribe to the new topic
        /// in the Amazon SNS            console.</important>        <ul>            <li><b>Progressing</b>
        /// (optional): The Amazon Simple Notification Service (Amazon SNS) topic that you want
        /// to notify                when Elastic Transcoder has started to process the job.</li>
        ///            <li><b>Completed</b> (optional): The Amazon SNS topic that you want to
        /// notify when Elastic Transcoder has                finished processing the job.</li>
        ///            <li><b>Warning</b> (optional): The Amazon SNS topic that you want to notify
        /// when Elastic Transcoder                encounters a warning condition.</li>      
        ///      <li><b>Error</b> (optional): The Amazon SNS topic that you want to notify when
        /// Elastic Transcoder                encounters an error condition.</li>        </ul>
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
        ///            thumbnails, and playlists. Either you specify this value, or you specify
        /// both                <code>ContentConfig</code> and <code>ThumbnailConfig</code>.
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
        ///            jobs for this pipeline.
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
        ///         <ul>            <li><code>Active</code>: The pipeline is processing jobs.</li>
        ///            <li><code>Paused</code>: The pipeline is not currently processing jobs.</li>
        ///        </ul>
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
        ///            thumbnail files. Either you specify both <code>ContentConfig</code> and
        ///                <code>ThumbnailConfig</code>, or you specify <code>OutputBucket</code>.
        /// </para>
        ///         <ul>            <li><code>Bucket</code>: The Amazon S3 bucket in which you
        /// want Elastic Transcoder to                save thumbnail files. </li>            <li><code>Permissions</code>:
        /// A list of the users and/or predefined Amazon S3 groups you                want to
        /// have access to thumbnail files, and the type of access that you want them to     
        ///           have. <ul>                    <li>GranteeType: The type of value that appears
        /// in the Grantee object: <ul>                            <li><code>Canonical</code>:
        /// Either the canonical user ID for an AWS                                account or
        /// an origin access identity for an Amazon CloudFront                               
        /// distribution. <important>A canonical user ID is not the same as an               
        ///                     AWS account number.</important></li>                         
        ///   <li><code>Email</code>: The registered email address of an AWS                 
        ///               account.</li>                            <li><code>Group</code>: One
        /// of the following predefined Amazon S3                                groups: <code>AllUsers</code>,
        /// <code>AuthenticatedUsers</code>, or                                    <code>LogDelivery</code>.</li>
        ///                        </ul>                    </li>                    <li><code>Grantee</code>:
        /// The AWS user or group that you want to have access to                        thumbnail
        /// files.</li>                    <li>Access: The permission that you want to give to
        /// the AWS user that is listed                        in Grantee. Valid values include:
        /// <ul>                            <li><code>READ</code>: The grantee can read the thumbnails
        /// and metadata                                for thumbnails that Elastic Transcoder
        /// adds to the Amazon S3                                bucket.</li>                
        ///            <li><code>READ_ACP</code>: The grantee can read the object ACL for    
        ///                            thumbnails that Elastic Transcoder adds to the Amazon S3
        ///                                bucket.</li>                            <li><code>WRITE_ACP</code>:
        /// The grantee can write the ACL for the                                thumbnails that
        /// Elastic Transcoder adds to the Amazon S3                                bucket.</li>
        ///                            <li><code>FULL_CONTROL</code>: The grantee has READ, READ_ACP,
        /// and                                WRITE_ACP permissions for the thumbnails that Elastic
        /// Transcoder                                adds to the Amazon S3 bucket.</li>     
        ///                   </ul>                    </li>                </ul>            </li>
        ///            <li><code>StorageClass</code>: The Amazon S3 storage class, <code>Standard</code>
        /// or                    <code>ReducedRedundancy</code>, that you want Elastic Transcoder
        /// to assign to                the thumbnails that it stores in your Amazon S3 bucket.</li>
        ///        </ul>
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