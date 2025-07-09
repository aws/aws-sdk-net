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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private string _arn;
        private List<ColumnGroup> _columnGroups = AWSConfigs.InitializeCollections ? new List<ColumnGroup>() : null;
        private List<ColumnLevelPermissionRule> _columnLevelPermissionRules = AWSConfigs.InitializeCollections ? new List<ColumnLevelPermissionRule>() : null;
        private long? _consumedSpiceCapacityInBytes;
        private DateTime? _createdTime;
        private string _dataSetId;
        private List<DatasetParameter> _datasetParameters = AWSConfigs.InitializeCollections ? new List<DatasetParameter>() : null;
        private DataSetUsageConfiguration _dataSetUsageConfiguration;
        private Dictionary<string, FieldFolder> _fieldFolders = AWSConfigs.InitializeCollections ? new Dictionary<string, FieldFolder>() : null;
        private DataSetImportMode _importMode;
        private DateTime? _lastUpdatedTime;
        private Dictionary<string, LogicalTable> _logicalTableMap = AWSConfigs.InitializeCollections ? new Dictionary<string, LogicalTable>() : null;
        private string _name;
        private List<OutputColumn> _outputColumns = AWSConfigs.InitializeCollections ? new List<OutputColumn>() : null;
        private PerformanceConfiguration _performanceConfiguration;
        private Dictionary<string, PhysicalTable> _physicalTableMap = AWSConfigs.InitializeCollections ? new Dictionary<string, PhysicalTable>() : null;
        private RowLevelPermissionDataSet _rowLevelPermissionDataSet;
        private RowLevelPermissionTagConfiguration _rowLevelPermissionTagConfiguration;
        private DataSetUseAs _useAs;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnGroups. 
        /// <para>
        /// Groupings of columns that work together in certain Amazon QuickSight features. Currently,
        /// only geospatial hierarchy is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public List<ColumnGroup> ColumnGroups
        {
            get { return this._columnGroups; }
            set { this._columnGroups = value; }
        }

        // Check to see if ColumnGroups property is set
        internal bool IsSetColumnGroups()
        {
            return this._columnGroups != null && (this._columnGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ColumnLevelPermissionRules. 
        /// <para>
        /// A set of one or more definitions of a <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_ColumnLevelPermissionRule.html">ColumnLevelPermissionRule</a>
        /// </c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ColumnLevelPermissionRule> ColumnLevelPermissionRules
        {
            get { return this._columnLevelPermissionRules; }
            set { this._columnLevelPermissionRules = value; }
        }

        // Check to see if ColumnLevelPermissionRules property is set
        internal bool IsSetColumnLevelPermissionRules()
        {
            return this._columnLevelPermissionRules != null && (this._columnLevelPermissionRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConsumedSpiceCapacityInBytes. 
        /// <para>
        /// The amount of SPICE capacity used by this dataset. This is 0 if the dataset isn't
        /// imported into SPICE.
        /// </para>
        /// </summary>
        public long? ConsumedSpiceCapacityInBytes
        {
            get { return this._consumedSpiceCapacityInBytes; }
            set { this._consumedSpiceCapacityInBytes = value; }
        }

        // Check to see if ConsumedSpiceCapacityInBytes property is set
        internal bool IsSetConsumedSpiceCapacityInBytes()
        {
            return this._consumedSpiceCapacityInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that this dataset was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The ID of the dataset. Limited to 96 characters.
        /// </para>
        /// </summary>
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetParameters. 
        /// <para>
        /// The parameters that are declared in a dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<DatasetParameter> DatasetParameters
        {
            get { return this._datasetParameters; }
            set { this._datasetParameters = value; }
        }

        // Check to see if DatasetParameters property is set
        internal bool IsSetDatasetParameters()
        {
            return this._datasetParameters != null && (this._datasetParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataSetUsageConfiguration. 
        /// <para>
        /// The usage configuration to apply to child datasets that reference this dataset as
        /// a source.
        /// </para>
        /// </summary>
        public DataSetUsageConfiguration DataSetUsageConfiguration
        {
            get { return this._dataSetUsageConfiguration; }
            set { this._dataSetUsageConfiguration = value; }
        }

        // Check to see if DataSetUsageConfiguration property is set
        internal bool IsSetDataSetUsageConfiguration()
        {
            return this._dataSetUsageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FieldFolders. 
        /// <para>
        /// The folder that contains fields and nested subfolders for your dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FieldFolder> FieldFolders
        {
            get { return this._fieldFolders; }
            set { this._fieldFolders = value; }
        }

        // Check to see if FieldFolders property is set
        internal bool IsSetFieldFolders()
        {
            return this._fieldFolders != null && (this._fieldFolders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImportMode. 
        /// <para>
        /// A value that indicates whether you want to import the data into SPICE.
        /// </para>
        /// </summary>
        public DataSetImportMode ImportMode
        {
            get { return this._importMode; }
            set { this._importMode = value; }
        }

        // Check to see if ImportMode property is set
        internal bool IsSetImportMode()
        {
            return this._importMode != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that this dataset was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogicalTableMap. 
        /// <para>
        /// Configures the combination and transformation of the data from the physical tables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public Dictionary<string, LogicalTable> LogicalTableMap
        {
            get { return this._logicalTableMap; }
            set { this._logicalTableMap = value; }
        }

        // Check to see if LogicalTableMap property is set
        internal bool IsSetLogicalTableMap()
        {
            return this._logicalTableMap != null && (this._logicalTableMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property OutputColumns. 
        /// <para>
        /// The list of columns after all transforms. These columns are available in templates,
        /// analyses, and dashboards.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputColumn> OutputColumns
        {
            get { return this._outputColumns; }
            set { this._outputColumns = value; }
        }

        // Check to see if OutputColumns property is set
        internal bool IsSetOutputColumns()
        {
            return this._outputColumns != null && (this._outputColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PerformanceConfiguration. 
        /// <para>
        /// The performance optimization configuration of a dataset.
        /// </para>
        /// </summary>
        public PerformanceConfiguration PerformanceConfiguration
        {
            get { return this._performanceConfiguration; }
            set { this._performanceConfiguration = value; }
        }

        // Check to see if PerformanceConfiguration property is set
        internal bool IsSetPerformanceConfiguration()
        {
            return this._performanceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalTableMap. 
        /// <para>
        /// Declares the physical tables that are available in the underlying data sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public Dictionary<string, PhysicalTable> PhysicalTableMap
        {
            get { return this._physicalTableMap; }
            set { this._physicalTableMap = value; }
        }

        // Check to see if PhysicalTableMap property is set
        internal bool IsSetPhysicalTableMap()
        {
            return this._physicalTableMap != null && (this._physicalTableMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RowLevelPermissionDataSet. 
        /// <para>
        /// The row-level security configuration for the dataset.
        /// </para>
        /// </summary>
        public RowLevelPermissionDataSet RowLevelPermissionDataSet
        {
            get { return this._rowLevelPermissionDataSet; }
            set { this._rowLevelPermissionDataSet = value; }
        }

        // Check to see if RowLevelPermissionDataSet property is set
        internal bool IsSetRowLevelPermissionDataSet()
        {
            return this._rowLevelPermissionDataSet != null;
        }

        /// <summary>
        /// Gets and sets the property RowLevelPermissionTagConfiguration. 
        /// <para>
        /// The element you can use to define tags for row-level security.
        /// </para>
        /// </summary>
        public RowLevelPermissionTagConfiguration RowLevelPermissionTagConfiguration
        {
            get { return this._rowLevelPermissionTagConfiguration; }
            set { this._rowLevelPermissionTagConfiguration = value; }
        }

        // Check to see if RowLevelPermissionTagConfiguration property is set
        internal bool IsSetRowLevelPermissionTagConfiguration()
        {
            return this._rowLevelPermissionTagConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UseAs. 
        /// <para>
        /// The usage of the dataset.
        /// </para>
        /// </summary>
        public DataSetUseAs UseAs
        {
            get { return this._useAs; }
            set { this._useAs = value; }
        }

        // Check to see if UseAs property is set
        internal bool IsSetUseAs()
        {
            return this._useAs != null;
        }

    }
}