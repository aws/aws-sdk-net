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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// The full POSIX identity, including user ID (<c>Uid</c>), group ID (<c>Gid</c>), and
    /// any secondary groups IDs (<c>SecondaryGids</c>), that controls your users' access
    /// to your Amazon EFS file systems. The POSIX permissions that are set on files and directories
    /// in your file system determine the level of access your users get when transferring
    /// files into and out of your Amazon EFS file systems.
    /// </summary>
    public partial class PosixProfile
    {
        private long? _gid;
        private List<long> _secondaryGids = AWSConfigs.InitializeCollections ? new List<long>() : null;
        private long? _uid;

        /// <summary>
        /// Gets and sets the property Gid. 
        /// <para>
        /// The POSIX group ID used for all EFS operations by this user.
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
        /// The secondary POSIX group IDs used for all EFS operations by this user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
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
        /// The POSIX user ID used for all EFS operations by this user.
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