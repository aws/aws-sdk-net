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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Dataset summary.
    /// </summary>
    public partial class DataSetSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ColumnLevelPermissionRulesApplied. 
        /// <para>
        /// A value that indicates if the dataset has column level permission configured.
        /// </para>
        /// </summary>
        public bool? ColumnLevelPermissionRulesApplied { get; set; }

        /// <summary>
        /// Checks to see if the ColumnLevelPermissionRulesApplied property is set.
        /// </summary>
        internal bool IsSetColumnLevelPermissionRulesApplied() => this.ColumnLevelPermissionRulesApplied.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that this dataset was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The ID of the dataset.
        /// </para>
        /// </summary>
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property ImportMode. 
        /// <para>
        /// A value that indicates whether you want to import the data into SPICE.
        /// </para>
        /// </summary>
        public DataSetImportMode ImportMode { get; set; }

        /// <summary>
        /// Checks to see if the ImportMode property is set.
        /// </summary>
        internal bool IsSetImportMode() => this.ImportMode != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that this dataset was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RowLevelPermissionDataSet. 
        /// <para>
        /// The row-level security configuration for the dataset in the legacy data preparation
        /// experience.
        /// </para>
        /// </summary>
        public RowLevelPermissionDataSet RowLevelPermissionDataSet { get; set; }

        /// <summary>
        /// Checks to see if the RowLevelPermissionDataSet property is set.
        /// </summary>
        internal bool IsSetRowLevelPermissionDataSet() => this.RowLevelPermissionDataSet != null;

        /// <summary>
        /// Gets and sets the property RowLevelPermissionDataSetMap. 
        /// <para>
        /// The row-level security configuration for the dataset in the new data preparation experience.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, RowLevelPermissionDataSet> RowLevelPermissionDataSetMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, RowLevelPermissionDataSet>() : null;

        /// <summary>
        /// Checks to see if the RowLevelPermissionDataSetMap property is set.
        /// </summary>
        internal bool IsSetRowLevelPermissionDataSetMap() => this.RowLevelPermissionDataSetMap != null && (this.RowLevelPermissionDataSetMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RowLevelPermissionTagConfigurationApplied. 
        /// <para>
        /// Whether or not the row level permission tags are applied.
        /// </para>
        /// </summary>
        public bool? RowLevelPermissionTagConfigurationApplied { get; set; }

        /// <summary>
        /// Checks to see if the RowLevelPermissionTagConfigurationApplied property is set.
        /// </summary>
        internal bool IsSetRowLevelPermissionTagConfigurationApplied() => this.RowLevelPermissionTagConfigurationApplied.HasValue;

        /// <summary>
        /// Gets and sets the property UseAs. 
        /// <para>
        /// The usage of the dataset.
        /// </para>
        /// </summary>
        public DataSetUseAs UseAs { get; set; }

        /// <summary>
        /// Checks to see if the UseAs property is set.
        /// </summary>
        internal bool IsSetUseAs() => this.UseAs != null;
    }
}
