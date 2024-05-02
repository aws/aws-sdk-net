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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Required if the <c>RootDirectory</c> &gt; <c>Path</c> specified does not exist. Specifies
    /// the POSIX IDs and permissions to apply to the access point's <c>RootDirectory</c>
    /// &gt; <c>Path</c>. If the access point root directory does not exist, EFS creates it
    /// with these settings when a client connects to the access point. When specifying <c>CreationInfo</c>,
    /// you must include values for all properties. 
    /// 
    ///  
    /// <para>
    /// Amazon EFS creates a root directory only if you have provided the CreationInfo: OwnUid,
    /// OwnGID, and permissions for the directory. If you do not provide this information,
    /// Amazon EFS does not create the root directory. If the root directory does not exist,
    /// attempts to mount using the access point will fail.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you do not provide <c>CreationInfo</c> and the specified <c>RootDirectory</c> does
    /// not exist, attempts to mount the file system using the access point will fail.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreationInfo
    {
        private long? _ownerGid;
        private long? _ownerUid;
        private string _permissions;

        /// <summary>
        /// Gets and sets the property OwnerGid. 
        /// <para>
        /// Specifies the POSIX group ID to apply to the <c>RootDirectory</c>. Accepts values
        /// from 0 to 2^32 (4294967295).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4294967295)]
        public long? OwnerGid
        {
            get { return this._ownerGid; }
            set { this._ownerGid = value; }
        }

        // Check to see if OwnerGid property is set
        internal bool IsSetOwnerGid()
        {
            return this._ownerGid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerUid. 
        /// <para>
        /// Specifies the POSIX user ID to apply to the <c>RootDirectory</c>. Accepts values from
        /// 0 to 2^32 (4294967295).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4294967295)]
        public long? OwnerUid
        {
            get { return this._ownerUid; }
            set { this._ownerUid = value; }
        }

        // Check to see if OwnerUid property is set
        internal bool IsSetOwnerUid()
        {
            return this._ownerUid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// Specifies the POSIX permissions to apply to the <c>RootDirectory</c>, in the format
        /// of an octal number representing the file's mode bits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=4)]
        public string Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null;
        }

    }
}