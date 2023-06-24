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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the ConvertRecoveryPointToSnapshot operation.
    /// Converts a recovery point to a snapshot. For more information about recovery points
    /// and snapshots, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-snapshots-recovery.html">Working
    /// with snapshots and recovery points</a>.
    /// </summary>
    public partial class ConvertRecoveryPointToSnapshotRequest : AmazonRedshiftServerlessRequest
    {
        private string _recoveryPointId;
        private int? _retentionPeriod;
        private string _snapshotName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property RecoveryPointId. 
        /// <para>
        /// The unique identifier of the recovery point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecoveryPointId
        {
            get { return this._recoveryPointId; }
            set { this._recoveryPointId = value; }
        }

        // Check to see if RecoveryPointId property is set
        internal bool IsSetRecoveryPointId()
        {
            return this._recoveryPointId != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// How long to retain the snapshot.
        /// </para>
        /// </summary>
        public int RetentionPeriod
        {
            get { return this._retentionPeriod.GetValueOrDefault(); }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of <a href="https://docs.aws.amazon.com/redshift-serverless/latest/APIReference/API_Tag.html">Tag
        /// objects</a> to associate with the created snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}