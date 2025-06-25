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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The FSx for OpenZFS file system user that is used for authorizing all file access
    /// requests that are made using the S3 access point.
    /// </summary>
    public partial class OpenZFSPosixFileSystemUser
    {
        private long? _gid;
        private List<long> _secondaryGids = AWSConfigs.InitializeCollections ? new List<long>() : null;
        private long? _uid;

        /// <summary>
        /// Gets and sets the property Gid. 
        /// <para>
        /// The GID of the file system user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4294967295)]
        public long? Gid
        {
            get { return this._gid; }
            set { this._gid = value; }
        }

        // Check to see if Gid property is set
        internal bool IsSetGid()
        {
            return this._gid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryGids. 
        /// <para>
        /// The list of secondary GIDs for the file system user. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=15)]
        public List<long> SecondaryGids
        {
            get { return this._secondaryGids; }
            set { this._secondaryGids = value; }
        }

        // Check to see if SecondaryGids property is set
        internal bool IsSetSecondaryGids()
        {
            return this._secondaryGids != null && (this._secondaryGids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The UID of the file system user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4294967295)]
        public long? Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid.HasValue; 
        }

    }
}