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
    /// Dataset.
    /// </summary>
    public partial class DataSet
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ColumnGroups. 
        /// <para>
        /// Groupings of columns that work together in certain Quick Sight features. Currently,
        /// only geospatial hierarchy is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public List<ColumnGroup> ColumnGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ColumnGroup>() : null;

        /// <summary>
        /// Checks to see if the ColumnGroups property is set.
        /// </summary>
        internal bool IsSetColumnGroups() => this.ColumnGroups != null && (this.ColumnGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ColumnLevelPermissionRules. 
        /// <para>
        /// A set of one or more definitions of a <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_ColumnLevelPermissionRule.html">ColumnLevelPermissionRule</a>
        /// </c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ColumnLevelPermissionRule> ColumnLevelPermissionRules { get; set; } = AWSConfigs.InitializeCollections ? new List<ColumnLevelPermissionRule>() : null;

        /// <summary>
        /// Checks to see if the ColumnLevelPermissionRules property is set.
        /// </summary>
        internal bool IsSetColumnLevelPermissionRules() => this.ColumnLevelPermissionRules != null && (this.ColumnLevelPermissionRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConsumedSpiceCapacityInBytes. 
        /// <para>
        /// The amount of SPICE capacity used by this dataset. This is 0 if the dataset isn't
        /// imported into SPICE.
        /// </para>
        /// </summary>
        public long? ConsumedSpiceCapacityInBytes { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedSpiceCapacityInBytes property is set.
        /// </summary>
        internal bool IsSetConsumedSpiceCapacityInBytes() => this.ConsumedSpiceCapacityInBytes.HasValue;

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
        /// Gets and sets the property DataPrepConfiguration. 
        /// <para>
        /// The data preparation configuration associated with this dataset.
        /// </para>
        /// </summary>
        public DataPrepConfiguration DataPrepConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataPrepConfiguration property is set.
        /// </summary>
        internal bool IsSetDataPrepConfiguration() => this.DataPrepConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The ID of the dataset. Limited to 96 characters.
        /// </para>
        /// </summary>
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property DataSetUsageConfiguration. 
        /// <para>
        /// The usage configuration to apply to child datasets that reference this dataset as
        /// a source.
        /// </para>
        /// </summary>
        public DataSetUsageConfiguration DataSetUsageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataSetUsageConfiguration property is set.
        /// </summary>
        internal bool IsSetDataSetUsageConfiguration() => this.DataSetUsageConfiguration != null;

        /// <summary>
        /// Gets and sets the property DatasetParameters. 
        /// <para>
        /// The parameters that are declared in a dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public List<DatasetParameter> DatasetParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<DatasetParameter>() : null;

        /// <summary>
        /// Checks to see if the DatasetParameters property is set.
        /// </summary>
        internal bool IsSetDatasetParameters() => this.DatasetParameters != null && (this.DatasetParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FieldFolders. 
        /// <para>
        /// The folder that contains fields and nested subfolders for your dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FieldFolder> FieldFolders { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, FieldFolder>() : null;

        /// <summary>
        /// Checks to see if the FieldFolders property is set.
        /// </summary>
        internal bool IsSetFieldFolders() => this.FieldFolders != null && (this.FieldFolders.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property LogicalTableMap. 
        /// <para>
        /// Configures the combination and transformation of the data from the physical tables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public Dictionary<string, LogicalTable> LogicalTableMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, LogicalTable>() : null;

        /// <summary>
        /// Checks to see if the LogicalTableMap property is set.
        /// </summary>
        internal bool IsSetLogicalTableMap() => this.LogicalTableMap != null && (this.LogicalTableMap.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property OutputColumns. 
        /// <para>
        /// The list of columns after all transforms. These columns are available in templates,
        /// analyses, and dashboards.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputColumn> OutputColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputColumn>() : null;

        /// <summary>
        /// Checks to see if the OutputColumns property is set.
        /// </summary>
        internal bool IsSetOutputColumns() => this.OutputColumns != null && (this.OutputColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PerformanceConfiguration. 
        /// <para>
        /// The performance optimization configuration of a dataset.
        /// </para>
        /// </summary>
        public PerformanceConfiguration PerformanceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceConfiguration property is set.
        /// </summary>
        internal bool IsSetPerformanceConfiguration() => this.PerformanceConfiguration != null;

        /// <summary>
        /// Gets and sets the property PhysicalTableMap. 
        /// <para>
        /// Declares the physical tables that are available in the underlying data sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public Dictionary<string, PhysicalTable> PhysicalTableMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, PhysicalTable>() : null;

        /// <summary>
        /// Checks to see if the PhysicalTableMap property is set.
        /// </summary>
        internal bool IsSetPhysicalTableMap() => this.PhysicalTableMap != null && (this.PhysicalTableMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RowLevelPermissionDataSet. 
        /// <para>
        /// The row-level security configuration for the dataset.
        /// </para>
        /// </summary>
        public RowLevelPermissionDataSet RowLevelPermissionDataSet { get; set; }

        /// <summary>
        /// Checks to see if the RowLevelPermissionDataSet property is set.
        /// </summary>
        internal bool IsSetRowLevelPermissionDataSet() => this.RowLevelPermissionDataSet != null;

        /// <summary>
        /// Gets and sets the property RowLevelPermissionTagConfiguration. 
        /// <para>
        /// The element you can use to define tags for row-level security.
        /// </para>
        /// </summary>
        public RowLevelPermissionTagConfiguration RowLevelPermissionTagConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RowLevelPermissionTagConfiguration property is set.
        /// </summary>
        internal bool IsSetRowLevelPermissionTagConfiguration() => this.RowLevelPermissionTagConfiguration != null;

        /// <summary>
        /// Gets and sets the property SemanticModelConfiguration. 
        /// <para>
        /// The semantic model configuration associated with this dataset.
        /// </para>
        /// </summary>
        public SemanticModelConfiguration SemanticModelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SemanticModelConfiguration property is set.
        /// </summary>
        internal bool IsSetSemanticModelConfiguration() => this.SemanticModelConfiguration != null;

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
