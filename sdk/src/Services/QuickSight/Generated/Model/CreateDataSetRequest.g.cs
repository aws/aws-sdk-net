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
    /// Container for the parameters to the CreateDataSet operation. Creates a dataset.
    /// </summary>
    public partial class CreateDataSetRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property ColumnGroups. 
        /// <para>
        /// Groupings of columns that work together in certain Amazon Quick Sight features. Currently,
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
        /// Gets and sets the property DataPrepConfiguration. 
        /// <para>
        /// The data preparation configuration for the dataset. This configuration defines the
        /// source tables, transformation steps, and destination tables used to prepare the data.
        /// Required when using the new data preparation experience.
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
        /// An ID for the dataset that you want to create. This ID is unique per Amazon Web Services
        /// Region for each Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property DataSetUsageConfiguration.
        /// </summary>
        public DataSetUsageConfiguration DataSetUsageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataSetUsageConfiguration property is set.
        /// </summary>
        internal bool IsSetDataSetUsageConfiguration() => this.DataSetUsageConfiguration != null;

        /// <summary>
        /// Gets and sets the property DatasetParameters. 
        /// <para>
        /// The parameter declarations of the dataset.
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
        /// Gets and sets the property FolderArns. 
        /// <para>
        /// When you create the dataset, Amazon Quick Sight adds the dataset to these folders.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> FolderArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FolderArns property is set.
        /// </summary>
        internal bool IsSetFolderArns() => this.FolderArns != null && (this.FolderArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImportMode. 
        /// <para>
        /// Indicates whether you want to import the data into SPICE.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSetImportMode ImportMode { get; set; }

        /// <summary>
        /// Checks to see if the ImportMode property is set.
        /// </summary>
        internal bool IsSetImportMode() => this.ImportMode != null;

        /// <summary>
        /// Gets and sets the property LogicalTableMap. 
        /// <para>
        /// Configures the combination and transformation of the data from the physical tables.
        /// This parameter is used with the legacy data preparation experience.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Only used in the legacy data preparation experience.")]
        [AWSProperty(Min = 1, Max = 64)]
        public Dictionary<string, LogicalTable> LogicalTableMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, LogicalTable>() : null;

        /// <summary>
        /// Checks to see if the LogicalTableMap property is set.
        /// </summary>
        internal bool IsSetLogicalTableMap() => this.LogicalTableMap != null && (this.LogicalTableMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PerformanceConfiguration. 
        /// <para>
        /// The configuration for the performance optimization of the dataset that contains a
        /// <c>UniqueKey</c> configuration.
        /// </para>
        /// </summary>
        public PerformanceConfiguration PerformanceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceConfiguration property is set.
        /// </summary>
        internal bool IsSetPerformanceConfiguration() => this.PerformanceConfiguration != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A list of resource permissions on the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public List<ResourcePermission> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public Dictionary<string, PhysicalTable> PhysicalTableMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, PhysicalTable>() : null;

        /// <summary>
        /// Checks to see if the PhysicalTableMap property is set.
        /// </summary>
        internal bool IsSetPhysicalTableMap() => this.PhysicalTableMap != null && (this.PhysicalTableMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RowLevelPermissionDataSet. 
        /// <para>
        /// The row-level security configuration for the data that you want to create. This parameter
        /// is used with the legacy data preparation experience.
        /// </para>
        /// </summary>
        [Obsolete("Only used in the legacy data preparation experience.")]
        public RowLevelPermissionDataSet RowLevelPermissionDataSet { get; set; }

        /// <summary>
        /// Checks to see if the RowLevelPermissionDataSet property is set.
        /// </summary>
        internal bool IsSetRowLevelPermissionDataSet() => this.RowLevelPermissionDataSet != null;

        /// <summary>
        /// Gets and sets the property RowLevelPermissionTagConfiguration. 
        /// <para>
        /// The configuration of tags on a dataset to set row-level security. Row-level security
        /// tags are currently supported for anonymous embedding only. This parameter is used
        /// with the legacy data preparation experience.
        /// </para>
        /// </summary>
        [Obsolete("Only used in the legacy data preparation experience.")]
        public RowLevelPermissionTagConfiguration RowLevelPermissionTagConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RowLevelPermissionTagConfiguration property is set.
        /// </summary>
        internal bool IsSetRowLevelPermissionTagConfiguration() => this.RowLevelPermissionTagConfiguration != null;

        /// <summary>
        /// Gets and sets the property SemanticModelConfiguration. 
        /// <para>
        /// The semantic model configuration for the dataset. This configuration defines how the
        /// prepared data is structured for an analysis, including table mappings and row-level
        /// security configurations. Required when using the new data preparation experience.
        /// </para>
        /// </summary>
        public SemanticModelConfiguration SemanticModelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SemanticModelConfiguration property is set.
        /// </summary>
        internal bool IsSetSemanticModelConfiguration() => this.SemanticModelConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseAs. 
        /// <para>
        /// The usage of the dataset. <c>RLS_RULES</c> must be specified for RLS permission datasets.
        /// </para>
        /// </summary>
        public DataSetUseAs UseAs { get; set; }

        /// <summary>
        /// Checks to see if the UseAs property is set.
        /// </summary>
        internal bool IsSetUseAs() => this.UseAs != null;
    }
}
