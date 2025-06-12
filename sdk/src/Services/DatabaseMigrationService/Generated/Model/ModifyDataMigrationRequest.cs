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
    /// Container for the parameters to the ModifyDataMigration operation.
    /// Modifies an existing DMS data migration.
    /// </summary>
    public partial class ModifyDataMigrationRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _dataMigrationIdentifier;
        private string _dataMigrationName;
        private MigrationTypeValue _dataMigrationType;
        private bool? _enableCloudwatchLogs;
        private int? _numberOfJobs;
        private string _selectionRules;
        private string _serviceAccessRoleArn;
        private List<SourceDataSetting> _sourceDataSettings = AWSConfigs.InitializeCollections ? new List<SourceDataSetting>() : null;
        private List<TargetDataSetting> _targetDataSettings = AWSConfigs.InitializeCollections ? new List<TargetDataSetting>() : null;

        /// <summary>
        /// Gets and sets the property DataMigrationIdentifier. 
        /// <para>
        /// The identifier (name or ARN) of the data migration to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataMigrationIdentifier
        {
            get { return this._dataMigrationIdentifier; }
            set { this._dataMigrationIdentifier = value; }
        }

        // Check to see if DataMigrationIdentifier property is set
        internal bool IsSetDataMigrationIdentifier()
        {
            return this._dataMigrationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DataMigrationName. 
        /// <para>
        /// The new name for the data migration.
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
        /// Gets and sets the property DataMigrationType. 
        /// <para>
        /// The new migration type for the data migration.
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
        /// Gets and sets the property EnableCloudwatchLogs. 
        /// <para>
        /// Whether to enable Cloudwatch logs for the data migration.
        /// </para>
        /// </summary>
        public bool? EnableCloudwatchLogs
        {
            get { return this._enableCloudwatchLogs; }
            set { this._enableCloudwatchLogs = value; }
        }

        // Check to see if EnableCloudwatchLogs property is set
        internal bool IsSetEnableCloudwatchLogs()
        {
            return this._enableCloudwatchLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfJobs. 
        /// <para>
        /// The number of parallel jobs that trigger parallel threads to unload the tables from
        /// the source, and then load them to the target.
        /// </para>
        /// </summary>
        public int? NumberOfJobs
        {
            get { return this._numberOfJobs; }
            set { this._numberOfJobs = value; }
        }

        // Check to see if NumberOfJobs property is set
        internal bool IsSetNumberOfJobs()
        {
            return this._numberOfJobs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelectionRules. 
        /// <para>
        /// A JSON-formatted string that defines what objects to include and exclude from the
        /// migration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SelectionRules
        {
            get { return this._selectionRules; }
            set { this._selectionRules = value; }
        }

        // Check to see if SelectionRules property is set
        internal bool IsSetSelectionRules()
        {
            return this._selectionRules != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The new service access role ARN for the data migration.
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
        /// The new information about the source data provider for the data migration.
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
        /// Gets and sets the property TargetDataSettings. 
        /// <para>
        /// The new information about the target data provider for the data migration.
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