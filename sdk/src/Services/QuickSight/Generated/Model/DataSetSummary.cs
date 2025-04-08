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
    /// Dataset summary.
    /// </summary>
    public partial class DataSetSummary
    {
        private string _arn;
        private bool? _columnLevelPermissionRulesApplied;
        private DateTime? _createdTime;
        private string _dataSetId;
        private DataSetImportMode _importMode;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private RowLevelPermissionDataSet _rowLevelPermissionDataSet;
        private bool? _rowLevelPermissionTagConfigurationApplied;
        private DataSetUseAs _useAs;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset.
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
        /// Gets and sets the property ColumnLevelPermissionRulesApplied. 
        /// <para>
        /// A value that indicates if the dataset has column level permission configured.
        /// </para>
        /// </summary>
        public bool? ColumnLevelPermissionRulesApplied
        {
            get { return this._columnLevelPermissionRulesApplied; }
            set { this._columnLevelPermissionRulesApplied = value; }
        }

        // Check to see if ColumnLevelPermissionRulesApplied property is set
        internal bool IsSetColumnLevelPermissionRulesApplied()
        {
            return this._columnLevelPermissionRulesApplied.HasValue; 
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
        /// The ID of the dataset.
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
        /// Gets and sets the property RowLevelPermissionTagConfigurationApplied. 
        /// <para>
        /// Whether or not the row level permission tags are applied.
        /// </para>
        /// </summary>
        public bool? RowLevelPermissionTagConfigurationApplied
        {
            get { return this._rowLevelPermissionTagConfigurationApplied; }
            set { this._rowLevelPermissionTagConfigurationApplied = value; }
        }

        // Check to see if RowLevelPermissionTagConfigurationApplied property is set
        internal bool IsSetRowLevelPermissionTagConfigurationApplied()
        {
            return this._rowLevelPermissionTagConfigurationApplied.HasValue; 
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