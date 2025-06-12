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
    /// The <c>PipelineOutputConfig</c> structure.
    /// </summary>
    public partial class PipelineOutputConfig
    {
        private string _bucket;
        private List<Permission> _permissions = AWSConfigs.InitializeCollections ? new List<Permission>() : null;
        private string _storageClass;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        ///  The Amazon S3 bucket in which you want Elastic Transcoder to save the transcoded
        /// files. Specify this value when all of the following are true:
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
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You want to associate the transcoded files and thumbnails with the Amazon S3 Standard
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you want to save transcoded files and playlists in one bucket and thumbnails in
        /// another bucket, specify which users can access the transcoded files or the permissions
        /// the users have, or change the Amazon S3 storage class, omit OutputBucket and specify
        /// values for <c>ContentConfig</c> and <c>ThumbnailConfig</c> instead. 
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
        /// Optional. The <c>Permissions</c> object specifies which users and/or predefined Amazon
        /// S3 groups you want to have access to transcoded files and playlists, and the type
        /// of access you want them to have. You can grant permissions to a maximum of 30 users
        /// and/or predefined Amazon S3 groups.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>Permissions</c>, Elastic Transcoder grants only the permissions
        /// that you specify. It does not grant full permissions to the owner of the role specified
        /// by <c>Role</c>. If you want that user to have full control, you must explicitly grant
        /// full control to the user.
        /// </para>
        ///  
        /// <para>
        ///  If you omit <c>Permissions</c>, Elastic Transcoder grants full control over the transcoded
        /// files and playlists to the owner of the role specified by <c>Role</c>, and grants
        /// no other permissions to any other user or group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public List<Permission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        ///  The Amazon S3 storage class, <c>Standard</c> or <c>ReducedRedundancy</c>, that you
        /// want Elastic Transcoder to assign to the video files and playlists that it stores
        /// in your Amazon S3 bucket. 
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