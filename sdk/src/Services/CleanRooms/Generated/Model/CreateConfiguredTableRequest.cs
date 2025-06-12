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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfiguredTable operation.
    /// Creates a new configured table resource.
    /// </summary>
    public partial class CreateConfiguredTableRequest : AmazonCleanRoomsRequest
    {
        private List<string> _allowedColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AnalysisMethod _analysisMethod;
        private string _description;
        private string _name;
        private List<string> _selectedAnalysisMethods = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TableReference _tableReference;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedColumns. 
        /// <para>
        /// The columns of the underlying table that can be used by collaborations or analysis
        /// rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> AllowedColumns
        {
            get { return this._allowedColumns; }
            set { this._allowedColumns = value; }
        }

        // Check to see if AllowedColumns property is set
        internal bool IsSetAllowedColumns()
        {
            return this._allowedColumns != null && (this._allowedColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AnalysisMethod. 
        /// <para>
        /// The analysis method allowed for the configured tables.
        /// </para>
        ///  
        /// <para>
        ///  <c>DIRECT_QUERY</c> allows SQL queries to be run directly on this table.
        /// </para>
        ///  
        /// <para>
        ///  <c>DIRECT_JOB</c> allows PySpark jobs to be run directly on this table.
        /// </para>
        ///  
        /// <para>
        ///  <c>MULTIPLE</c> allows both SQL queries and PySpark jobs to be run directly on this
        /// table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalysisMethod AnalysisMethod
        {
            get { return this._analysisMethod; }
            set { this._analysisMethod = value; }
        }

        // Check to see if AnalysisMethod property is set
        internal bool IsSetAnalysisMethod()
        {
            return this._analysisMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property SelectedAnalysisMethods. 
        /// <para>
        ///  The analysis methods to enable for the configured table. When configured, you must
        /// specify at least two analysis methods.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SelectedAnalysisMethods
        {
            get { return this._selectedAnalysisMethods; }
            set { this._selectedAnalysisMethods = value; }
        }

        // Check to see if SelectedAnalysisMethods property is set
        internal bool IsSetSelectedAnalysisMethods()
        {
            return this._selectedAnalysisMethods != null && (this._selectedAnalysisMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableReference. 
        /// <para>
        /// A reference to the table being configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableReference TableReference
        {
            get { return this._tableReference; }
            set { this._tableReference = value; }
        }

        // Check to see if TableReference property is set
        internal bool IsSetTableReference()
        {
            return this._tableReference != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}