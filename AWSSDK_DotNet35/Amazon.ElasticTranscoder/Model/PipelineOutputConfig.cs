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
    /// <para>The <c>PipelineOutputConfig</c> structure.</para>
    /// </summary>
    public class PipelineOutputConfig
    {
        
        private string bucket;
        private string storageClass;
        private List<Permission> permissions = new List<Permission>();


        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save the transcoded files. Specify this value when all of the following are
        /// true: <ul> <li>You want to save transcoded files, thumbnails (if any), and playlists (if any) together in one bucket.</li> <li>You do not
        /// want to specify the users or groups who have access to the transcoded files, thumbnails, and playlists.</li> <li>You do not want to specify
        /// the permissions that Elastic Transcoder grants to the files. </li> <li>You want to associate the transcoded files and thumbnails with the
        /// Amazon S3 Standard storage class.</li> </ul> If you want to save transcoded files and playlists in one bucket and thumbnails in another
        /// bucket, specify which users can access the transcoded files or the permissions the users have, or change the Amazon S3 storage class, omit
        /// OutputBucket and specify values for <c>ContentConfig</c> and <c>ThumbnailConfig</c> instead.
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
        public string Bucket
        {
            get { return this.bucket; }
            set { this.bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this.bucket != null;
        }

        /// <summary>
        /// The Amazon S3 storage class, <c>Standard</c> or <c>ReducedRedundancy</c>, that you want Elastic Transcoder to assign to the video files and
        /// playlists that it stores in your Amazon S3 bucket.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^ReducedRedundancy$)|(^Standard$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }

        /// <summary>
        /// Optional. The <c>Permissions</c> object specifies which users and/or predefined Amazon S3 groups you want to have access to transcoded files
        /// and playlists, and the type of access you want them to have. You can grant permissions to a maximum of 30 users and/or predefined Amazon S3
        /// groups. If you include <c>Permissions</c>, Elastic Transcoder grants only the permissions that you specify. It does not grant full
        /// permissions to the owner of the role specified by <c>Role</c>. If you want that user to have full control, you must explicitly grant full
        /// control to the user. If you omit <c>Permissions</c>, Elastic Transcoder grants full control over the transcoded files and playlists to the
        /// owner of the role specified by <c>Role</c>, and grants no other permissions to any other user or group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<Permission> Permissions
        {
            get { return this.permissions; }
            set { this.permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this.permissions.Count > 0;
        }
    }
}
