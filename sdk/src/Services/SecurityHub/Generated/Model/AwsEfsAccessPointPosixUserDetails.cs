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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details for all file system operations using this Amazon EFS access point.
    /// </summary>
    public partial class AwsEfsAccessPointPosixUserDetails
    {
        private string _gid;
        private List<string> _secondaryGids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _uid;

        /// <summary>
        /// Gets and sets the property Gid. 
        /// <para>
        /// The POSIX group ID used for all file system operations using this access point. 
        /// </para>
        /// </summary>
        public string Gid
        {
            get { return this._gid; }
            set { this._gid = value; }
        }

        // Check to see if Gid property is set
        internal bool IsSetGid()
        {
            return this._gid != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryGids. 
        /// <para>
        /// Secondary POSIX group IDs used for all file system operations using this access point.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecondaryGids
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
        /// The POSIX user ID used for all file system operations using this access point. 
        /// </para>
        /// </summary>
        public string Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

    }
}