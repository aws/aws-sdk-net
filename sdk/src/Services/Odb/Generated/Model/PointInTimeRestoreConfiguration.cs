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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The configuration for creating an Autonomous Database by restoring to a point in time.
    /// </summary>
    public partial class PointInTimeRestoreConfiguration
    {
        private List<int> _cloneTableSpaceList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private CloneType _cloneType;
        private string _sourceAutonomousDatabaseId;
        private DateTime? _timestamp;
        private bool? _useLatestAvailableBackupTimestamp;

        /// <summary>
        /// Gets and sets the property CloneTableSpaceList. 
        /// <para>
        /// The list of tablespace identifiers to clone from the point-in-time restore.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> CloneTableSpaceList
        {
            get { return this._cloneTableSpaceList; }
            set { this._cloneTableSpaceList = value; }
        }

        // Check to see if CloneTableSpaceList property is set
        internal bool IsSetCloneTableSpaceList()
        {
            return this._cloneTableSpaceList != null && (this._cloneTableSpaceList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CloneType. 
        /// <para>
        /// The type of clone to create from the point-in-time restore.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CloneType CloneType
        {
            get { return this._cloneType; }
            set { this._cloneType = value; }
        }

        // Check to see if CloneType property is set
        internal bool IsSetCloneType()
        {
            return this._cloneType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the source Autonomous Database to restore from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string SourceAutonomousDatabaseId
        {
            get { return this._sourceAutonomousDatabaseId; }
            set { this._sourceAutonomousDatabaseId = value; }
        }

        // Check to see if SourceAutonomousDatabaseId property is set
        internal bool IsSetSourceAutonomousDatabaseId()
        {
            return this._sourceAutonomousDatabaseId != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time to which to restore the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseLatestAvailableBackupTimestamp. 
        /// <para>
        /// Indicates whether to use the latest available backup timestamp for the restore.
        /// </para>
        /// </summary>
        public bool? UseLatestAvailableBackupTimestamp
        {
            get { return this._useLatestAvailableBackupTimestamp; }
            set { this._useLatestAvailableBackupTimestamp = value; }
        }

        // Check to see if UseLatestAvailableBackupTimestamp property is set
        internal bool IsSetUseLatestAvailableBackupTimestamp()
        {
            return this._useLatestAvailableBackupTimestamp.HasValue; 
        }

    }
}