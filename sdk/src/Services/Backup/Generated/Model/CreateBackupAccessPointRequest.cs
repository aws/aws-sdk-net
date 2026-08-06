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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBackupAccessPoint operation.
    /// Creates a backup access point for an Amazon S3 recovery point. A backup access point
    /// provides on-demand, read-only access to the backup data in a recovery point through
    /// an Amazon S3 access point, without initiating a restore.
    /// 
    ///  
    /// <para>
    /// While a backup access point is active for a recovery point, Backup pauses lifecycle
    /// transitions and blocks deletion of that recovery point.
    /// </para>
    /// </summary>
    public partial class CreateBackupAccessPointRequest : AmazonBackupRequest
    {
        private Dictionary<string, string> _accessPointMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _accessPointPolicy;
        private string _name;
        private string _recoveryPointArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccessPointMetadata. 
        /// <para>
        /// Metadata for the backup access point. For continuous (point-in-time) recovery points,
        /// you must include an <c>AccessPointInTime</c> timestamp (in format <c>2021-11-27T03:30:27Z</c>).
        /// The access point provides access to the content present in the backup at that specific
        /// time. You can specify any time within the continuous backup's retention period, up
        /// to the latest restorable time. For snapshot recovery points, do not include <c>AccessPointInTime</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> AccessPointMetadata
        {
            get { return this._accessPointMetadata; }
            set { this._accessPointMetadata = value; }
        }

        // Check to see if AccessPointMetadata property is set
        internal bool IsSetAccessPointMetadata()
        {
            return this._accessPointMetadata != null && (this._accessPointMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AccessPointPolicy. 
        /// <para>
        /// An optional resource-based policy, in JSON format, to apply to the underlying Amazon
        /// S3 access point. The policy controls how backup data can be accessed through the access
        /// point. If you do not specify a policy, access is governed by the caller's IAM permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-policies.html">Configuring
        /// IAM policies for using access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200000)]
        public string AccessPointPolicy
        {
            get { return this._accessPointPolicy; }
            set { this._accessPointPolicy = value; }
        }

        // Check to see if AccessPointPolicy property is set
        internal bool IsSetAccessPointPolicy()
        {
            return this._accessPointPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the backup access point. This name is shared with the Amazon S3 access
        /// point namespace. It must be unique within your account and Region and cannot conflict
        /// with an existing Amazon S3 access point. For more information about access point naming,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-restrictions-limitations-naming-rules.html">Access
        /// points naming rules, restrictions, and limitations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recovery point for which to create the backup
        /// access point. The recovery point must be an Amazon S3 recovery point in the <c>AVAILABLE</c>,
        /// <c>STOPPED</c>, or <c>COMPLETED</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecoveryPointArn
        {
            get { return this._recoveryPointArn; }
            set { this._recoveryPointArn = value; }
        }

        // Check to see if RecoveryPointArn property is set
        internal bool IsSetRecoveryPointArn()
        {
            return this._recoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the backup access point.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}