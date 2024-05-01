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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the RestoreSnapshotTier operation.
    /// </summary>
    public partial class RestoreSnapshotTierResponse : AmazonWebServiceResponse
    {
        private bool? _isPermanentRestore;
        private int? _restoreDuration;
        private DateTime? _restoreStartTime;
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property IsPermanentRestore. 
        /// <para>
        /// Indicates whether the snapshot is permanently restored. <c>true</c> indicates a permanent
        /// restore. <c>false</c> indicates a temporary restore.
        /// </para>
        /// </summary>
        public bool? IsPermanentRestore
        {
            get { return this._isPermanentRestore; }
            set { this._isPermanentRestore = value; }
        }

        // Check to see if IsPermanentRestore property is set
        internal bool IsSetIsPermanentRestore()
        {
            return this._isPermanentRestore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreDuration. 
        /// <para>
        /// For temporary restores only. The number of days for which the archived snapshot is
        /// temporarily restored.
        /// </para>
        /// </summary>
        public int? RestoreDuration
        {
            get { return this._restoreDuration; }
            set { this._restoreDuration = value; }
        }

        // Check to see if RestoreDuration property is set
        internal bool IsSetRestoreDuration()
        {
            return this._restoreDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreStartTime. 
        /// <para>
        /// The date and time when the snapshot restore process started.
        /// </para>
        /// </summary>
        public DateTime? RestoreStartTime
        {
            get { return this._restoreStartTime; }
            set { this._restoreStartTime = value; }
        }

        // Check to see if RestoreStartTime property is set
        internal bool IsSetRestoreStartTime()
        {
            return this._restoreStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

    }
}