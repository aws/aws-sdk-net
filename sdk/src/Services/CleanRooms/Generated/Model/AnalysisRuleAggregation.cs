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
    /// A type of analysis rule that enables query structure and specified queries that produce
    /// aggregate statistics.
    /// </summary>
    public partial class AnalysisRuleAggregation
    {
        private AdditionalAnalyses _additionalAnalyses;
        private List<AggregateColumn> _aggregateColumns = AWSConfigs.InitializeCollections ? new List<AggregateColumn>() : null;
        private List<string> _allowedJoinOperators = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _dimensionColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _joinColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private JoinRequiredOption _joinRequired;
        private List<AggregationConstraint> _outputConstraints = AWSConfigs.InitializeCollections ? new List<AggregationConstraint>() : null;
        private List<string> _scalarFunctions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalAnalyses. 
        /// <para>
        ///  An indicator as to whether additional analyses (such as Clean Rooms ML) can be applied
        /// to the output of the direct query. 
        /// </para>
        ///  
        /// <para>
        /// The <c>additionalAnalyses</c> parameter is currently supported for the list analysis
        /// rule (<c>AnalysisRuleList</c>) and the custom analysis rule (<c>AnalysisRuleCustom</c>).
        /// </para>
        /// </summary>
        public AdditionalAnalyses AdditionalAnalyses
        {
            get { return this._additionalAnalyses; }
            set { this._additionalAnalyses = value; }
        }

        // Check to see if AdditionalAnalyses property is set
        internal bool IsSetAdditionalAnalyses()
        {
            return this._additionalAnalyses != null;
        }

        /// <summary>
        /// Gets and sets the property AggregateColumns. 
        /// <para>
        /// The columns that query runners are allowed to use in aggregation queries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<AggregateColumn> AggregateColumns
        {
            get { return this._aggregateColumns; }
            set { this._aggregateColumns = value; }
        }

        // Check to see if AggregateColumns property is set
        internal bool IsSetAggregateColumns()
        {
            return this._aggregateColumns != null && (this._aggregateColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedJoinOperators. 
        /// <para>
        /// Which logical operators (if any) are to be used in an INNER JOIN match condition.
        /// Default is <c>AND</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> AllowedJoinOperators
        {
            get { return this._allowedJoinOperators; }
            set { this._allowedJoinOperators = value; }
        }

        // Check to see if AllowedJoinOperators property is set
        internal bool IsSetAllowedJoinOperators()
        {
            return this._allowedJoinOperators != null && (this._allowedJoinOperators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DimensionColumns. 
        /// <para>
        /// The columns that query runners are allowed to select, group by, or filter by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DimensionColumns
        {
            get { return this._dimensionColumns; }
            set { this._dimensionColumns = value; }
        }

        // Check to see if DimensionColumns property is set
        internal bool IsSetDimensionColumns()
        {
            return this._dimensionColumns != null && (this._dimensionColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JoinColumns. 
        /// <para>
        /// Columns in configured table that can be used in join statements and/or as aggregate
        /// columns. They can never be outputted directly.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> JoinColumns
        {
            get { return this._joinColumns; }
            set { this._joinColumns = value; }
        }

        // Check to see if JoinColumns property is set
        internal bool IsSetJoinColumns()
        {
            return this._joinColumns != null && (this._joinColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JoinRequired. 
        /// <para>
        /// Control that requires member who runs query to do a join with their configured table
        /// and/or other configured table in query.
        /// </para>
        /// </summary>
        public JoinRequiredOption JoinRequired
        {
            get { return this._joinRequired; }
            set { this._joinRequired = value; }
        }

        // Check to see if JoinRequired property is set
        internal bool IsSetJoinRequired()
        {
            return this._joinRequired != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConstraints. 
        /// <para>
        /// Columns that must meet a specific threshold value (after an aggregation function is
        /// applied to it) for each output row to be returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<AggregationConstraint> OutputConstraints
        {
            get { return this._outputConstraints; }
            set { this._outputConstraints = value; }
        }

        // Check to see if OutputConstraints property is set
        internal bool IsSetOutputConstraints()
        {
            return this._outputConstraints != null && (this._outputConstraints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScalarFunctions. 
        /// <para>
        /// Set of scalar functions that are allowed to be used on dimension columns and the output
        /// of aggregation of metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ScalarFunctions
        {
            get { return this._scalarFunctions; }
            set { this._scalarFunctions = value; }
        }

        // Check to see if ScalarFunctions property is set
        internal bool IsSetScalarFunctions()
        {
            return this._scalarFunctions != null && (this._scalarFunctions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}