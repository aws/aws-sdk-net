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
    /// The contents of a dashboard.
    /// </summary>
    public partial class DashboardVersionDefinition
    {
        private AnalysisDefaults _analysisDefaults;
        private List<CalculatedField> _calculatedFields = new List<CalculatedField>();
        private List<ColumnConfiguration> _columnConfigurations = new List<ColumnConfiguration>();
        private List<DataSetIdentifierDeclaration> _dataSetIdentifierDeclarations = new List<DataSetIdentifierDeclaration>();
        private List<FilterGroup> _filterGroups = new List<FilterGroup>();
        private List<ParameterDeclaration> _parameterDeclarations = new List<ParameterDeclaration>();
        private List<SheetDefinition> _sheets = new List<SheetDefinition>();

        /// <summary>
        /// Gets and sets the property AnalysisDefaults.
        /// </summary>
        public AnalysisDefaults AnalysisDefaults
        {
            get { return this._analysisDefaults; }
            set { this._analysisDefaults = value; }
        }

        // Check to see if AnalysisDefaults property is set
        internal bool IsSetAnalysisDefaults()
        {
            return this._analysisDefaults != null;
        }

        /// <summary>
        /// Gets and sets the property CalculatedFields. 
        /// <para>
        /// An array of calculated field definitions for the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<CalculatedField> CalculatedFields
        {
            get { return this._calculatedFields; }
            set { this._calculatedFields = value; }
        }

        // Check to see if CalculatedFields property is set
        internal bool IsSetCalculatedFields()
        {
            return this._calculatedFields != null && this._calculatedFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ColumnConfigurations. 
        /// <para>
        /// An array of dashboard-level column configurations. Column configurations are used
        /// to set the default formatting for a column that is used throughout a dashboard. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<ColumnConfiguration> ColumnConfigurations
        {
            get { return this._columnConfigurations; }
            set { this._columnConfigurations = value; }
        }

        // Check to see if ColumnConfigurations property is set
        internal bool IsSetColumnConfigurations()
        {
            return this._columnConfigurations != null && this._columnConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataSetIdentifierDeclarations. 
        /// <para>
        /// An array of dataset identifier declarations. With this mapping,you can use dataset
        /// identifiers instead of dataset Amazon Resource Names (ARNs) throughout the dashboard's
        /// sub-structures.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<DataSetIdentifierDeclaration> DataSetIdentifierDeclarations
        {
            get { return this._dataSetIdentifierDeclarations; }
            set { this._dataSetIdentifierDeclarations = value; }
        }

        // Check to see if DataSetIdentifierDeclarations property is set
        internal bool IsSetDataSetIdentifierDeclarations()
        {
            return this._dataSetIdentifierDeclarations != null && this._dataSetIdentifierDeclarations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FilterGroups. 
        /// <para>
        /// The filter definitions for a dashboard.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/adding-a-filter.html">Filtering
        /// Data in Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
        public List<FilterGroup> FilterGroups
        {
            get { return this._filterGroups; }
            set { this._filterGroups = value; }
        }

        // Check to see if FilterGroups property is set
        internal bool IsSetFilterGroups()
        {
            return this._filterGroups != null && this._filterGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ParameterDeclarations. 
        /// <para>
        /// The parameter declarations for a dashboard. Parameters are named variables that can
        /// transfer a value for use by an action or an object.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/parameters-in-quicksight.html">Parameters
        /// in Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<ParameterDeclaration> ParameterDeclarations
        {
            get { return this._parameterDeclarations; }
            set { this._parameterDeclarations = value; }
        }

        // Check to see if ParameterDeclarations property is set
        internal bool IsSetParameterDeclarations()
        {
            return this._parameterDeclarations != null && this._parameterDeclarations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Sheets. 
        /// <para>
        /// An array of sheet definitions for a dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<SheetDefinition> Sheets
        {
            get { return this._sheets; }
            set { this._sheets = value; }
        }

        // Check to see if Sheets property is set
        internal bool IsSetSheets()
        {
            return this._sheets != null && this._sheets.Count > 0; 
        }

    }
}