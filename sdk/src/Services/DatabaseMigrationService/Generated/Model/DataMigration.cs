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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This object provides information about a DMS data migration.
    /// </summary>
    public partial class DataMigration
    {
        private string _dataMigrationArn;
        private List<string> _dataMigrationCidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _dataMigrationCreateTime;
        private DateTime? _dataMigrationEndTime;
        private string _dataMigrationName;
        private DataMigrationSettings _dataMigrationSettings;
        private DateTime? _dataMigrationStartTime;
        private DataMigrationStatistics _dataMigrationStatistics;
        private string _dataMigrationStatus;
        private MigrationTypeValue _dataMigrationType;
        private string _lastFailureMessage;
        private string _migrationProjectArn;
        private List<string> _publicIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serviceAccessRoleArn;
        private List<SourceDataSetting> _sourceDataSettings = AWSConfigs.InitializeCollections ? new List<SourceDataSetting>() : null;
        private string _stopReason;
        private List<TargetDataSetting> _targetDataSettings = AWSConfigs.InitializeCollections ? new List<TargetDataSetting>() : null;

        /// <summary>
        /// Gets and sets the property DataMigrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies this replication.
        /// </para>
        /// </summary>
        public string DataMigrationArn
        {
            get { return this._dataMigrationArn; }
            set { this._dataMigrationArn = value; }
        }

        // Check to see if DataMigrationArn property is set
        internal bool IsSetDataMigrationArn()
        {
            return this._dataMigrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataMigrationCidrBlocks. 
        /// <para>
        /// The CIDR blocks of the endpoints for the data migration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DataMigrationCidrBlocks
        {
            get { return this._dataMigrationCidrBlocks; }
            set { this._dataMigrationCidrBlocks = value; }
        }

        // Check to see if DataMigrationCidrBlocks property is set
        internal bool IsSetDataMigrationCidrBlocks()
        {
            return this._dataMigrationCidrBlocks != null && (this._dataMigrationCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataMigrationCreateTime. 
        /// <para>
        /// The UTC time when DMS created the data migration.
        /// </para>
        /// </summary>
        public DateTime? DataMigrationCreateTime
        {
            get { return this._dataMigrationCreateTime; }
            set { this._dataMigrationCreateTime = value; }
        }

        // Check to see if DataMigrationCreateTime property is set
        internal bool IsSetDataMigrationCreateTime()
        {
            return this._dataMigrationCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataMigrationEndTime. 
        /// <para>
        /// The UTC time when data migration ended.
        /// </para>
        /// </summary>
        public DateTime? DataMigrationEndTime
        {
            get { return this._dataMigrationEndTime; }
            set { this._dataMigrationEndTime = value; }
        }

        // Check to see if DataMigrationEndTime property is set
        internal bool IsSetDataMigrationEndTime()
        {
            return this._dataMigrationEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataMigrationName. 
        /// <para>
        /// The user-friendly name for the data migration.
        /// </para>
        /// </summary>
        public string DataMigrationName
        {
            get { return this._dataMigrationName; }
            set { this._dataMigrationName = value; }
        }

        // Check to see if DataMigrationName property is set
        internal bool IsSetDataMigrationName()
        {
            return this._dataMigrationName != null;
        }

        /// <summary>
        /// Gets and sets the property DataMigrationSettings. 
        /// <para>
        /// Specifies CloudWatch settings and selection rules for the data migration.
        /// </para>
        /// </summary>
        public DataMigrationSettings DataMigrationSettings
        {
            get { return this._dataMigrationSettings; }
            set { this._dataMigrationSettings = value; }
        }

        // Check to see if DataMigrationSettings property is set
        internal bool IsSetDataMigrationSettings()
        {
            return this._dataMigrationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DataMigrationStartTime. 
        /// <para>
        /// The UTC time when DMS started the data migration.
        /// </para>
        /// </summary>
        public DateTime? DataMigrationStartTime
        {
            get { return this._dataMigrationStartTime; }
            set { this._dataMigrationStartTime = value; }
        }

        // Check to see if DataMigrationStartTime property is set
        internal bool IsSetDataMigrationStartTime()
        {
            return this._dataMigrationStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataMigrationStatistics. 
        /// <para>
        /// Provides information about the data migration's run, including start and stop time,
        /// latency, and data migration progress.
        /// </para>
        /// </summary>
        public DataMigrationStatistics DataMigrationStatistics
        {
            get { return this._dataMigrationStatistics; }
            set { this._dataMigrationStatistics = value; }
        }

        // Check to see if DataMigrationStatistics property is set
        internal bool IsSetDataMigrationStatistics()
        {
            return this._dataMigrationStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property DataMigrationStatus. 
        /// <para>
        /// The current status of the data migration. 
        /// </para>
        /// </summary>
        public string DataMigrationStatus
        {
            get { return this._dataMigrationStatus; }
            set { this._dataMigrationStatus = value; }
        }

        // Check to see if DataMigrationStatus property is set
        internal bool IsSetDataMigrationStatus()
        {
            return this._dataMigrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DataMigrationType. 
        /// <para>
        /// Specifies whether the data migration is full-load only, change data capture (CDC)
        /// only, or full-load and CDC.
        /// </para>
        /// </summary>
        public MigrationTypeValue DataMigrationType
        {
            get { return this._dataMigrationType; }
            set { this._dataMigrationType = value; }
        }

        // Check to see if DataMigrationType property is set
        internal bool IsSetDataMigrationType()
        {
            return this._dataMigrationType != null;
        }

        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// Information about the data migration's most recent error or failure.
        /// </para>
        /// </summary>
        public string LastFailureMessage
        {
            get { return this._lastFailureMessage; }
            set { this._lastFailureMessage = value; }
        }

        // Check to see if LastFailureMessage property is set
        internal bool IsSetLastFailureMessage()
        {
            return this._lastFailureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data migration's associated migration project.
        /// </para>
        /// </summary>
        public string MigrationProjectArn
        {
            get { return this._migrationProjectArn; }
            set { this._migrationProjectArn = value; }
        }

        // Check to see if MigrationProjectArn property is set
        internal bool IsSetMigrationProjectArn()
        {
            return this._migrationProjectArn != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIpAddresses. 
        /// <para>
        /// The IP addresses of the endpoints for the data migration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> PublicIpAddresses
        {
            get { return this._publicIpAddresses; }
            set { this._publicIpAddresses = value; }
        }

        // Check to see if PublicIpAddresses property is set
        internal bool IsSetPublicIpAddresses()
        {
            return this._publicIpAddresses != null && (this._publicIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The IAM role that the data migration uses to access Amazon Web Services resources.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDataSettings. 
        /// <para>
        /// Specifies information about the data migration's source data provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceDataSetting> SourceDataSettings
        {
            get { return this._sourceDataSettings; }
            set { this._sourceDataSettings = value; }
        }

        // Check to see if SourceDataSettings property is set
        internal bool IsSetSourceDataSettings()
        {
            return this._sourceDataSettings != null && (this._sourceDataSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StopReason. 
        /// <para>
        /// The reason the data migration last stopped.
        /// </para>
        /// </summary>
        public string StopReason
        {
            get { return this._stopReason; }
            set { this._stopReason = value; }
        }

        // Check to see if StopReason property is set
        internal bool IsSetStopReason()
        {
            return this._stopReason != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDataSettings. 
        /// <para>
        /// Specifies information about the data migration's target data provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetDataSetting> TargetDataSettings
        {
            get { return this._targetDataSettings; }
            set { this._targetDataSettings = value; }
        }

        // Check to see if TargetDataSettings property is set
        internal bool IsSetTargetDataSettings()
        {
            return this._targetDataSettings != null && (this._targetDataSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}