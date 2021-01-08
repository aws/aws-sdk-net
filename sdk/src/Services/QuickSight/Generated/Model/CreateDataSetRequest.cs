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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataSet operation.
    /// Creates a dataset.
    /// </summary>
    public partial class CreateDataSetRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private List<ColumnGroup> _columnGroups = new List<ColumnGroup>();
        private List<ColumnLevelPermissionRule> _columnLevelPermissionRules = new List<ColumnLevelPermissionRule>();
        private string _dataSetId;
        private DataSetImportMode _importMode;
        private Dictionary<string, LogicalTable> _logicalTableMap = new Dictionary<string, LogicalTable>();
        private string _name;
        private List<ResourcePermission> _permissions = new List<ResourcePermission>();
        private Dictionary<string, PhysicalTable> _physicalTableMap = new Dictionary<string, PhysicalTable>();
        private RowLevelPermissionDataSet _rowLevelPermissionDataSet;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnGroups. 
        /// <para>
        /// Groupings of columns that work together in certain QuickSight features. Currently,
        /// only geospatial hierarchy is supported.
        /// </para>
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
            return this._columnGroups != null && this._columnGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ColumnLevelPermissionRules. 
        /// <para>
        /// A set of one or more definitions of a <code> <a>ColumnLevelPermissionRule</a> </code>.
        /// </para>
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
            return this._columnLevelPermissionRules != null && this._columnLevelPermissionRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// An ID for the dataset that you want to create. This ID is unique per AWS Region for
        /// each AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ImportMode. 
        /// <para>
        /// Indicates whether you want to import the data into SPICE.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LogicalTableMap. 
        /// <para>
        /// Configures the combination and transformation of the data from the physical tables.
        /// </para>
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
            return this._logicalTableMap != null && this._logicalTableMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A list of resource permissions on the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public List<ResourcePermission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PhysicalTableMap. 
        /// <para>
        /// Declares the physical tables that are available in the underlying data sources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public Dictionary<string, PhysicalTable> PhysicalTableMap
        {
            get { return this._physicalTableMap; }
            set { this._physicalTableMap = value; }
        }

        // Check to see if PhysicalTableMap property is set
        internal bool IsSetPhysicalTableMap()
        {
            return this._physicalTableMap != null && this._physicalTableMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RowLevelPermissionDataSet. 
        /// <para>
        /// The row-level security configuration for the data that you want to create.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}