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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This object provides information about a DMS data migration.
    /// </summary>
    public partial class DataMigration
    {
        /// <summary>
        /// Gets and sets the property DataMigrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies this replication.
        /// </para>
        /// </summary>
        public string DataMigrationArn { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationArn property is set.
        /// </summary>
        internal bool IsSetDataMigrationArn() => this.DataMigrationArn != null;

        /// <summary>
        /// Gets and sets the property DataMigrationCidrBlocks. 
        /// <para>
        /// The CIDR blocks of the endpoints for the data migration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DataMigrationCidrBlocks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DataMigrationCidrBlocks property is set.
        /// </summary>
        internal bool IsSetDataMigrationCidrBlocks() => this.DataMigrationCidrBlocks != null && (this.DataMigrationCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataMigrationCreateTime. 
        /// <para>
        /// The UTC time when DMS created the data migration.
        /// </para>
        /// </summary>
        public DateTime? DataMigrationCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationCreateTime property is set.
        /// </summary>
        internal bool IsSetDataMigrationCreateTime() => this.DataMigrationCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataMigrationEndTime. 
        /// <para>
        /// The UTC time when data migration ended.
        /// </para>
        /// </summary>
        public DateTime? DataMigrationEndTime { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationEndTime property is set.
        /// </summary>
        internal bool IsSetDataMigrationEndTime() => this.DataMigrationEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataMigrationName. 
        /// <para>
        /// The user-friendly name for the data migration.
        /// </para>
        /// </summary>
        public string DataMigrationName { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationName property is set.
        /// </summary>
        internal bool IsSetDataMigrationName() => this.DataMigrationName != null;

        /// <summary>
        /// Gets and sets the property DataMigrationSettings. 
        /// <para>
        /// Specifies CloudWatch settings and selection rules for the data migration.
        /// </para>
        /// </summary>
        public DataMigrationSettings DataMigrationSettings { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationSettings property is set.
        /// </summary>
        internal bool IsSetDataMigrationSettings() => this.DataMigrationSettings != null;

        /// <summary>
        /// Gets and sets the property DataMigrationStartTime. 
        /// <para>
        /// The UTC time when DMS started the data migration.
        /// </para>
        /// </summary>
        public DateTime? DataMigrationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationStartTime property is set.
        /// </summary>
        internal bool IsSetDataMigrationStartTime() => this.DataMigrationStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataMigrationStatistics. 
        /// <para>
        /// Provides information about the data migration's run, including start and stop time,
        /// latency, and data migration progress.
        /// </para>
        /// </summary>
        public DataMigrationStatistics DataMigrationStatistics { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationStatistics property is set.
        /// </summary>
        internal bool IsSetDataMigrationStatistics() => this.DataMigrationStatistics != null;

        /// <summary>
        /// Gets and sets the property DataMigrationStatus. 
        /// <para>
        /// The current status of the data migration. 
        /// </para>
        /// </summary>
        public string DataMigrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationStatus property is set.
        /// </summary>
        internal bool IsSetDataMigrationStatus() => this.DataMigrationStatus != null;

        /// <summary>
        /// Gets and sets the property DataMigrationType. 
        /// <para>
        /// Specifies whether the data migration is full-load only, change data capture (CDC)
        /// only, or full-load and CDC.
        /// </para>
        /// </summary>
        public MigrationTypeValue DataMigrationType { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationType property is set.
        /// </summary>
        internal bool IsSetDataMigrationType() => this.DataMigrationType != null;

        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// Information about the data migration's most recent error or failure.
        /// </para>
        /// </summary>
        public string LastFailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastFailureMessage property is set.
        /// </summary>
        internal bool IsSetLastFailureMessage() => this.LastFailureMessage != null;

        /// <summary>
        /// Gets and sets the property MigrationProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data migration's associated migration project.
        /// </para>
        /// </summary>
        public string MigrationProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the MigrationProjectArn property is set.
        /// </summary>
        internal bool IsSetMigrationProjectArn() => this.MigrationProjectArn != null;

        /// <summary>
        /// Gets and sets the property PublicIpAddresses. 
        /// <para>
        /// The IP addresses of the endpoints for the data migration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<string> PublicIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PublicIpAddresses property is set.
        /// </summary>
        internal bool IsSetPublicIpAddresses() => this.PublicIpAddresses != null && (this.PublicIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The IAM role that the data migration uses to access Amazon Web Services resources.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccessRoleArn() => this.ServiceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SourceDataSettings. 
        /// <para>
        /// Specifies information about the data migration's source data provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceDataSetting> SourceDataSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceDataSetting>() : null;

        /// <summary>
        /// Checks to see if the SourceDataSettings property is set.
        /// </summary>
        internal bool IsSetSourceDataSettings() => this.SourceDataSettings != null && (this.SourceDataSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StopReason. 
        /// <para>
        /// The reason the data migration last stopped.
        /// </para>
        /// </summary>
        public string StopReason { get; set; }

        /// <summary>
        /// Checks to see if the StopReason property is set.
        /// </summary>
        internal bool IsSetStopReason() => this.StopReason != null;

        /// <summary>
        /// Gets and sets the property TargetDataSettings. 
        /// <para>
        /// Specifies information about the data migration's target data provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetDataSetting> TargetDataSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetDataSetting>() : null;

        /// <summary>
        /// Checks to see if the TargetDataSettings property is set.
        /// </summary>
        internal bool IsSetTargetDataSettings() => this.TargetDataSettings != null && (this.TargetDataSettings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
