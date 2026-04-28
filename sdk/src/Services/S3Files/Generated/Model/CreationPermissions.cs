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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
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
namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Specifies the permissions to set on newly created directories within the file system.
    /// </summary>
    public partial class CreationPermissions
    {
        private long? _ownerGid;
        private long? _ownerUid;
        private string _permissions;

        /// <summary>
        /// Gets and sets the property OwnerGid. 
        /// <para>
        /// The POSIX group ID to assign to newly created directories.
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
        /// The POSIX user ID to assign to newly created directories.
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
        /// The octal permissions to assign to newly created directories.
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