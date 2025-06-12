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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreTable operation.
    /// Restores the table to the specified point in time within the <c>earliest_restorable_timestamp</c>
    /// and the current time. For more information about restore points, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery_HowItWorks.html#howitworks_backup_window">
    /// Time window for PITR continuous backups</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// Any number of users can execute up to 4 concurrent restores (any type of restore)
    /// in a given account.
    /// </para>
    ///  
    /// <para>
    /// When you restore using point in time recovery, Amazon Keyspaces restores your source
    /// table's schema and data to the state based on the selected timestamp <c>(day:hour:minute:second)</c>
    /// to a new table. The Time to Live (TTL) settings are also restored to the state based
    /// on the selected timestamp.
    /// </para>
    ///  
    /// <para>
    /// In addition to the table's schema, data, and TTL settings, <c>RestoreTable</c> restores
    /// the capacity mode, auto scaling settings, encryption settings, and point-in-time recovery
    /// settings from the source table. Unlike the table's schema data and TTL settings, which
    /// are restored based on the selected timestamp, these settings are always restored based
    /// on the table's settings as of the current time or when the table was deleted.
    /// </para>
    ///  
    /// <para>
    /// You can also overwrite these settings during restore:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Read/write capacity mode
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provisioned throughput capacity units
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Auto scaling settings
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Point-in-time (PITR) settings
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tags
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery_HowItWorks.html#howitworks_backup_settings">PITR
    /// restore settings</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Note that the following settings are not restored, and you must configure them manually
    /// for the new table:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Identity and Access Management (IAM) policies
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon CloudWatch metrics and alarms
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RestoreTableRequest : AmazonKeyspacesRequest
    {
        private AutoScalingSpecification _autoScalingSpecification;
        private CapacitySpecification _capacitySpecificationOverride;
        private EncryptionSpecification _encryptionSpecificationOverride;
        private PointInTimeRecovery _pointInTimeRecoveryOverride;
        private List<ReplicaSpecification> _replicaSpecifications = AWSConfigs.InitializeCollections ? new List<ReplicaSpecification>() : null;
        private DateTime? _restoreTimestamp;
        private string _sourceKeyspaceName;
        private string _sourceTableName;
        private List<Tag> _tagsOverride = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetKeyspaceName;
        private string _targetTableName;

        /// <summary>
        /// Gets and sets the property AutoScalingSpecification. 
        /// <para>
        /// The optional auto scaling settings for the restored table in provisioned capacity
        /// mode. Specifies if the service can manage throughput capacity of a provisioned table
        /// automatically on your behalf. Amazon Keyspaces auto scaling helps you provision throughput
        /// capacity for variable workloads efficiently by increasing and decreasing your table's
        /// read and write capacity automatically in response to application traffic.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/autoscaling.html">Managing
        /// throughput capacity automatically with Amazon Keyspaces auto scaling</a> in the <i>Amazon
        /// Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public AutoScalingSpecification AutoScalingSpecification
        {
            get { return this._autoScalingSpecification; }
            set { this._autoScalingSpecification = value; }
        }

        // Check to see if AutoScalingSpecification property is set
        internal bool IsSetAutoScalingSpecification()
        {
            return this._autoScalingSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property CapacitySpecificationOverride. 
        /// <para>
        /// Specifies the read/write throughput capacity mode for the target table. The options
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>throughputMode:PAY_PER_REQUEST</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>throughputMode:PROVISIONED</c> - Provisioned capacity mode requires <c>readCapacityUnits</c>
        /// and <c>writeCapacityUnits</c> as input.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>throughput_mode:PAY_PER_REQUEST</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/ReadWriteCapacityMode.html">Read/write
        /// capacity modes</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public CapacitySpecification CapacitySpecificationOverride
        {
            get { return this._capacitySpecificationOverride; }
            set { this._capacitySpecificationOverride = value; }
        }

        // Check to see if CapacitySpecificationOverride property is set
        internal bool IsSetCapacitySpecificationOverride()
        {
            return this._capacitySpecificationOverride != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionSpecificationOverride. 
        /// <para>
        /// Specifies the encryption settings for the target table. You can choose one of the
        /// following KMS key (KMS key):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>type:AWS_OWNED_KMS_KEY</c> - This key is owned by Amazon Keyspaces. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type:CUSTOMER_MANAGED_KMS_KEY</c> - This key is stored in your account and is
        /// created, owned, and managed by you. This option requires the <c>kms_key_identifier</c>
        /// of the KMS key in Amazon Resource Name (ARN) format as input. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>type:AWS_OWNED_KMS_KEY</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/EncryptionAtRest.html">Encryption
        /// at rest</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public EncryptionSpecification EncryptionSpecificationOverride
        {
            get { return this._encryptionSpecificationOverride; }
            set { this._encryptionSpecificationOverride = value; }
        }

        // Check to see if EncryptionSpecificationOverride property is set
        internal bool IsSetEncryptionSpecificationOverride()
        {
            return this._encryptionSpecificationOverride != null;
        }

        /// <summary>
        /// Gets and sets the property PointInTimeRecoveryOverride. 
        /// <para>
        /// Specifies the <c>pointInTimeRecovery</c> settings for the target table. The options
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>status=ENABLED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status=DISABLED</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If it's not specified, the default is <c>status=DISABLED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery.html">Point-in-time
        /// recovery</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public PointInTimeRecovery PointInTimeRecoveryOverride
        {
            get { return this._pointInTimeRecoveryOverride; }
            set { this._pointInTimeRecoveryOverride = value; }
        }

        // Check to see if PointInTimeRecoveryOverride property is set
        internal bool IsSetPointInTimeRecoveryOverride()
        {
            return this._pointInTimeRecoveryOverride != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaSpecifications. 
        /// <para>
        /// The optional Region specific settings of a multi-Regional table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ReplicaSpecification> ReplicaSpecifications
        {
            get { return this._replicaSpecifications; }
            set { this._replicaSpecifications = value; }
        }

        // Check to see if ReplicaSpecifications property is set
        internal bool IsSetReplicaSpecifications()
        {
            return this._replicaSpecifications != null && (this._replicaSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RestoreTimestamp. 
        /// <para>
        /// The restore timestamp in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? RestoreTimestamp
        {
            get { return this._restoreTimestamp; }
            set { this._restoreTimestamp = value; }
        }

        // Check to see if RestoreTimestamp property is set
        internal bool IsSetRestoreTimestamp()
        {
            return this._restoreTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceKeyspaceName. 
        /// <para>
        /// The keyspace name of the source table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string SourceKeyspaceName
        {
            get { return this._sourceKeyspaceName; }
            set { this._sourceKeyspaceName = value; }
        }

        // Check to see if SourceKeyspaceName property is set
        internal bool IsSetSourceKeyspaceName()
        {
            return this._sourceKeyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTableName. 
        /// <para>
        /// The name of the source table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string SourceTableName
        {
            get { return this._sourceTableName; }
            set { this._sourceTableName = value; }
        }

        // Check to see if SourceTableName property is set
        internal bool IsSetSourceTableName()
        {
            return this._sourceTableName != null;
        }

        /// <summary>
        /// Gets and sets the property TagsOverride. 
        /// <para>
        /// A list of key-value pair tags to be attached to the restored table. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html">Adding
        /// tags and labels to Amazon Keyspaces resources</a> in the <i>Amazon Keyspaces Developer
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public List<Tag> TagsOverride
        {
            get { return this._tagsOverride; }
            set { this._tagsOverride = value; }
        }

        // Check to see if TagsOverride property is set
        internal bool IsSetTagsOverride()
        {
            return this._tagsOverride != null && (this._tagsOverride.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetKeyspaceName. 
        /// <para>
        /// The name of the target keyspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string TargetKeyspaceName
        {
            get { return this._targetKeyspaceName; }
            set { this._targetKeyspaceName = value; }
        }

        // Check to see if TargetKeyspaceName property is set
        internal bool IsSetTargetKeyspaceName()
        {
            return this._targetKeyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTableName. 
        /// <para>
        /// The name of the target table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string TargetTableName
        {
            get { return this._targetTableName; }
            set { this._targetTableName = value; }
        }

        // Check to see if TargetTableName property is set
        internal bool IsSetTargetTableName()
        {
            return this._targetTableName != null;
        }

    }
}