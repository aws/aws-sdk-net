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
    /// Container for the parameters to the CreateDataMigration operation. Creates a data
    /// migration using the provided settings.
    /// </summary>
    public partial class CreateDataMigrationRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DataMigrationName. 
        /// <para>
        /// A user-friendly name for the data migration. Data migration names have the following
        /// constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must begin with a letter, and can only contain ASCII letters, digits, and hyphens.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Length must be from 1 to 255 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DataMigrationName { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationName property is set.
        /// </summary>
        internal bool IsSetDataMigrationName() => this.DataMigrationName != null;

        /// <summary>
        /// Gets and sets the property DataMigrationType. 
        /// <para>
        /// Specifies if the data migration is full-load only, change data capture (CDC) only,
        /// or full-load and CDC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MigrationTypeValue DataMigrationType { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationType property is set.
        /// </summary>
        internal bool IsSetDataMigrationType() => this.DataMigrationType != null;

        /// <summary>
        /// Gets and sets the property EnableCloudwatchLogs. 
        /// <para>
        /// Specifies whether to enable CloudWatch logs for the data migration.
        /// </para>
        /// </summary>
        public bool? EnableCloudwatchLogs { get; set; }

        /// <summary>
        /// Checks to see if the EnableCloudwatchLogs property is set.
        /// </summary>
        internal bool IsSetEnableCloudwatchLogs() => this.EnableCloudwatchLogs.HasValue;

        /// <summary>
        /// Gets and sets the property MigrationProjectIdentifier. 
        /// <para>
        /// An identifier for the migration project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MigrationProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MigrationProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetMigrationProjectIdentifier() => this.MigrationProjectIdentifier != null;

        /// <summary>
        /// Gets and sets the property NumberOfJobs. 
        /// <para>
        /// The number of parallel jobs that trigger parallel threads to unload the tables from
        /// the source, and then load them to the target.
        /// </para>
        /// </summary>
        public int? NumberOfJobs { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfJobs property is set.
        /// </summary>
        internal bool IsSetNumberOfJobs() => this.NumberOfJobs.HasValue;

        /// <summary>
        /// Gets and sets the property SelectionRules. 
        /// <para>
        /// An optional JSON string specifying what tables, views, and schemas to include or exclude
        /// from the migration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SelectionRules { get; set; }

        /// <summary>
        /// Checks to see if the SelectionRules property is set.
        /// </summary>
        internal bool IsSetSelectionRules() => this.SelectionRules != null;

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the service access role that you want to use to
        /// create the data migration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccessRoleArn() => this.ServiceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SourceDataSettings. 
        /// <para>
        /// Specifies information about the source data provider.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the data migration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetDataSettings. 
        /// <para>
        /// Specifies information about the target data provider.
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
