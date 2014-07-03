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
    /// Use the <code>UpdatePipeline</code> operation to update settings for a pipeline.
    ///                <important>When you change pipeline settings, your changes take effect
    /// immediately.                Jobs that you have already submitted and that Elastic
    /// Transcoder has not started to process are                affected in addition to jobs
    /// that you submit after you change settings. </important>
    /// </summary>
    public partial class UpdatePipelineRequest : AmazonElasticTranscoderRequest
    {
        private PipelineOutputConfig _contentConfig;
        private string _id;
        private string _inputBucket;
        private string _name;
        private Notifications _notifications;
        private string _role;
        private PipelineOutputConfig _thumbnailConfig;


        /// <summary>
        /// Gets and sets the property ContentConfig. 
        /// <para>
        /// The optional <code>ContentConfig</code> object specifies information about the Amazon
        /// S3            bucket in which you want Elastic Transcoder to save transcoded files
        /// and playlists:            which bucket to use, which users you want to have access
        /// to the files, the type of            access you want users to have, and the storage
        /// class that you want to assign to the            files.
        /// </para>
        ///         
        /// <para>
        /// If you specify values for <code>ContentConfig</code>, you must also specify values
        /// for                <code>ThumbnailConfig</code>.
        /// </para>
        ///         
        /// <para>
        /// If you specify values for <code>ContentConfig</code> and <code>ThumbnailConfig</code>,
        ///            omit the <code>OutputBucket</code> object.
        /// </para>
        ///         <ul>            <li><b>Bucket</b>: The Amazon S3 bucket in which you want
        /// Elastic Transcoder to save                transcoded files and playlists.</li>   
        ///         <li><b>Permissions</b> (Optional): The Permissions object specifies which
        /// users you want                to have access to transcoded files and the type of access
        /// you want them to have. You                can grant permissions to a maximum of 30
        /// users and/or predefined Amazon S3                groups.</li>            <li><b>Grantee
        /// Type</b>: Specify the type of value that appears in the                    <code>Grantee</code>
        /// object: <ul>                    <li><b>Canonical</b>: The value in the <code>Grantee</code>
        /// object is either the                        canonical user ID for an AWS account or
        /// an origin access identity for an                        Amazon CloudFront distribution.
        /// For more information about canonical user                        IDs, see Access Control
        /// List (ACL) Overview in the Amazon Simple Storage                        Service Developer
        /// Guide. For more information about using CloudFront origin                        access
        /// identities to require that users use CloudFront URLs instead of                  
        ///      Amazon S3 URLs, see Using an Origin Access Identity to Restrict Access to   
        ///                     Your Amazon S3 Content. <important>A canonical user ID is not
        /// the same as an                            AWS account number.</important>        
        ///            </li>                    <li><b>Email</b>: The value in the <code>Grantee</code>
        /// object is the registered                        email address of an AWS account.</li>
        ///                    <li><b>Group</b>: The value in the <code>Grantee</code> object
        /// is one of the                        following predefined Amazon S3 groups: <code>AllUsers</code>,
        ///                            <code>AuthenticatedUsers</code>, or <code>LogDelivery</code>.</li>
        ///                </ul>            </li>            <li>                <b>Grantee</b>:
        /// The AWS user or group that you want to have access to transcoded                files
        /// and playlists. To identify the user or group, you can specify the canonical      
        ///          user ID for an AWS account, an origin access identity for a CloudFront distribution,
        ///                the registered email address of an AWS account, or a predefined Amazon
        /// S3 group </li>            <li>                <b>Access</b>: The permission that you
        /// want to give to the AWS user that you                specified in <code>Grantee</code>.
        /// Permissions are granted on the files that Elastic                Transcoder adds to
        /// the bucket, including playlists and video files. Valid values                include:
        /// <ul>                    <li><code>READ</code>: The grantee can read the objects and
        /// metadata for objects                        that Elastic Transcoder adds to the Amazon
        /// S3 bucket.</li>                    <li><code>READ_ACP</code>: The grantee can read
        /// the object ACL for objects that                        Elastic Transcoder adds to
        /// the Amazon S3 bucket. </li>                    <li><code>WRITE_ACP</code>: The grantee
        /// can write the ACL for the objects that                        Elastic Transcoder adds
        /// to the Amazon S3 bucket.</li>                    <li><code>FULL_CONTROL</code>: The
        /// grantee has <code>READ</code>,                            <code>READ_ACP</code>, and
        /// <code>WRITE_ACP</code> permissions for the                        objects that Elastic
        /// Transcoder adds to the Amazon S3 bucket.</li>                </ul>            </li>
        ///            <li>                <b>StorageClass</b>: The Amazon S3 storage class, <code>Standard</code>
        /// or                    <code>ReducedRedundancy</code>, that you want Elastic Transcoder
        /// to assign to                the video files and playlists that it stores in your Amazon
        /// S3 bucket.</li>        </ul>
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
        /// The ID of the pipeline that you want to update.
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
        /// The Amazon S3 bucket in which you saved the media files that you want to transcode
        /// and            the graphics that you want to use as watermarks.
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
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM Amazon Resource Name (ARN) for the role that you want Elastic Transcoder to
        /// use to transcode            jobs for this pipeline.
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
        /// S3            bucket in which you want Elastic Transcoder to save thumbnail files,
        /// which users you want to have            access to the files, the type of access you
        /// want users to have, and the storage class            that you want to assign to the
        /// files.
        /// </para>
        ///         
        /// <para>
        /// If you specify values for <code>ContentConfig</code>, you must also specify values
        /// for                <code>ThumbnailConfig</code> even if you don't want to create thumbnails.
        /// </para>
        ///         
        /// <para>
        /// If you specify values for <code>ContentConfig</code> and <code>ThumbnailConfig</code>,
        ///            omit the <code>OutputBucket</code> object.
        /// </para>
        ///         <ul>            <li><b>Bucket</b>: The Amazon S3 bucket in which you want
        /// Elastic Transcoder to save                thumbnail files.</li>            <li><b>Permissions</b>
        /// (Optional): The <code>Permissions</code> object specifies which                users
        /// and/or predefined Amazon S3 groups you want to have access to thumbnail files,   
        ///             and the type of access you want them to have. You can grant permissions
        /// to a maximum                of 30 users and/or predefined Amazon S3 groups.</li> 
        ///           <li>                <b>GranteeType</b>: Specify the type of value that appears
        /// in the Grantee object: <ul>                    <li>                        <b>Canonical</b>:
        /// The value in the <code>Grantee</code> object is either the                       
        /// canonical user ID for an AWS account or an origin access identity for an         
        ///               Amazon CloudFront distribution. <important>A canonical user ID is not
        /// the                            same as an AWS account number.</important></li>   
        ///                 <li><b>Email</b>: The value in the <code>Grantee</code> object is
        /// the registered                        email address of an AWS account. </li>     
        ///               <li><b>Group</b>: The value in the <code>Grantee</code> object is one
        /// of the                        following predefined Amazon S3 groups: <code>AllUsers</code>,
        ///                            <code>AuthenticatedUsers</code>, or <code>LogDelivery</code>.</li>
        ///                </ul>            </li>            <li>                <b>Grantee</b>:
        /// The AWS user or group that you want to have access to thumbnail                files.
        /// To identify the user or group, you can specify the canonical user ID for an      
        ///          AWS account, an origin access identity for a CloudFront distribution, the
        /// registered                email address of an AWS account, or a predefined Amazon
        /// S3 group. </li>            <li>                <b>Access</b>: The permission that
        /// you want to give to the AWS user that you                specified in <code>Grantee</code>.
        /// Permissions are granted on the thumbnail files                that Elastic Transcoder
        /// adds to the bucket. Valid values include: <ul>                    <li><code>READ</code>:
        /// The grantee can read the thumbnails and metadata for                        objects
        /// that Elastic Transcoder adds to the Amazon S3 bucket.</li>                    <li><code>READ_ACP</code>:
        /// The grantee can read the object ACL for thumbnails                        that Elastic
        /// Transcoder adds to the Amazon S3 bucket. </li>                    <li><code>WRITE_ACP</code>:
        /// The grantee can write the ACL for the thumbnails                        that Elastic
        /// Transcoder adds to the Amazon S3 bucket.</li>                    <li><code>FULL_CONTROL</code>:
        /// The grantee has <code>READ</code>,                            <code>READ_ACP</code>,
        /// and <code>WRITE_ACP</code> permissions for the                        thumbnails that
        /// Elastic Transcoder adds to the Amazon S3 bucket. </li>                </ul>      
        ///      </li>            <li>                <b>StorageClass</b>: The Amazon S3 storage
        /// class, <code>Standard</code> or                    <code>ReducedRedundancy</code>,
        /// that you want Elastic Transcoder to assign to                the thumbnails that it
        /// stores in your Amazon S3 bucket.</li>        </ul>
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