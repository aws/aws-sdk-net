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
    /// The <code>PipelineOutputConfig</code> structure.
    /// </summary>
    public partial class PipelineOutputConfig
    {
        private string _bucket;
        private List<Permission> _permissions = new List<Permission>();
        private string _storageClass;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        ///  The Amazon S3 bucket in which you want Elastic Transcoder to save the transcoded
        /// files. Specify this            value when all of the following are true: <ul>    
        ///            <li>You want to save transcoded files, thumbnails (if any), and playlists
        /// (if any)                    together in one bucket.</li>                <li>You do
        /// not want to specify the users or groups who have access to the transcoded        
        ///            files, thumbnails, and playlists.</li>                <li>You do not want
        /// to specify the permissions that Elastic Transcoder grants to the files. </li>    
        ///            <li>You want to associate the transcoded files and thumbnails with the
        /// Amazon S3                    Standard storage class.</li>            </ul> If you
        /// want to save transcoded files and playlists in one bucket and thumbnails in      
        ///      another bucket, specify which users can access the transcoded files or the permissions
        ///            the users have, or change the Amazon S3 storage class, omit OutputBucket
        /// and specify            values for <code>ContentConfig</code> and <code>ThumbnailConfig</code>
        /// instead. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Permissions. 
        /// <para>
        /// Optional. The <code>Permissions</code> object specifies which users and/or predefined
        ///            Amazon S3 groups you want to have access to transcoded files and playlists,
        /// and the type            of access you want them to have. You can grant permissions
        /// to a maximum of 30 users            and/or predefined Amazon S3 groups.
        /// </para>
        ///         
        /// <para>
        /// If you include <code>Permissions</code>, Elastic Transcoder grants only the permissions
        /// that you            specify. It does not grant full permissions to the owner of the
        /// role specified by                <code>Role</code>. If you want that user to have
        /// full control, you must explicitly            grant full control to the user.
        /// </para>
        ///         
        /// <para>
        ///  If you omit <code>Permissions</code>, Elastic Transcoder grants full control over
        /// the transcoded files            and playlists to the owner of the role specified by
        /// <code>Role</code>, and grants no            other permissions to any other user or
        /// group.
        /// </para>
        /// </summary>
        public List<Permission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        ///  The Amazon S3 storage class, <code>Standard</code> or <code>ReducedRedundancy</code>,
        ///            that you want Elastic Transcoder to assign to the video files and playlists
        /// that it stores in your            Amazon S3 bucket. 
        /// </para>
        /// </summary>
        public string StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

    }
}