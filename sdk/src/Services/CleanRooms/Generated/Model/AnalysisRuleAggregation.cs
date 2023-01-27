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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Enables query structure and specified queries that product aggregate statistics.
    /// </summary>
    public partial class AnalysisRuleAggregation
    {
        private List<AggregateColumn> _aggregateColumns = new List<AggregateColumn>();
        private List<string> _dimensionColumns = new List<string>();
        private List<string> _joinColumns = new List<string>();
        private JoinRequiredOption _joinRequired;
        private List<AggregationConstraint> _outputConstraints = new List<AggregationConstraint>();
        private List<string> _scalarFunctions = new List<string>();

        /// <summary>
        /// Gets and sets the property AggregateColumns. 
        /// <para>
        /// The columns that query runners are allowed to use in aggregation queries.
        /// </para>
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
            return this._aggregateColumns != null && this._aggregateColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DimensionColumns. 
        /// <para>
        /// The columns that query runners are allowed to select, group by, or filter by.
        /// </para>
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
            return this._dimensionColumns != null && this._dimensionColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JoinColumns. 
        /// <para>
        /// Columns in configured table that can be used in join statements and/or as aggregate
        /// columns. They can never be outputted directly.
        /// </para>
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
            return this._joinColumns != null && this._joinColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JoinRequired. 
        /// <para>
        /// Control that requires member who runs query to do a join with their configured table
        /// and/or other configured table in query
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
            return this._outputConstraints != null && this._outputConstraints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScalarFunctions. 
        /// <para>
        /// Set of scalar functions that are allowed to be used on dimension columns and the output
        /// of aggregation of metrics.
        /// </para>
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
            return this._scalarFunctions != null && this._scalarFunctions.Count > 0; 
        }

    }
}