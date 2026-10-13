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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the ConvertRecoveryPointToSnapshot operation. Converts
    /// a recovery point to a snapshot. For more information about recovery points and snapshots,
    /// see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-snapshots-recovery-points.html">Working
    /// with snapshots and recovery points</a>.
    /// </summary>
    public partial class ConvertRecoveryPointToSnapshotRequest : AmazonRedshiftServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property RecoveryPointId. 
        /// <para>
        /// The unique identifier of the recovery point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointId property is set.
        /// </summary>
        internal bool IsSetRecoveryPointId() => this.RecoveryPointId != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// How long to retain the snapshot.
        /// </para>
        /// </summary>
        public int? RetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriod property is set.
        /// </summary>
        internal bool IsSetRetentionPeriod() => this.RetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of <a href="https://docs.aws.amazon.com/redshift-serverless/latest/APIReference/API_Tag.html">Tag
        /// objects</a> to associate with the created snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
