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
    /// A transform operation that groups rows by specified columns and applies aggregation
    /// functions to calculate summary values.
    /// </summary>
    public partial class AggregateOperation
    {
        private List<Aggregation> _aggregations = AWSConfigs.InitializeCollections ? new List<Aggregation>() : null;
        private string _alias;
        private List<string> _groupByColumnNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TransformOperationSource _source;

        /// <summary>
        /// Gets and sets the property Aggregations. 
        /// <para>
        /// The list of aggregation functions to apply to the grouped data, such as <c>SUM</c>,
        /// <c>COUNT</c>, or <c>AVERAGE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public List<Aggregation> Aggregations
        {
            get { return this._aggregations; }
            set { this._aggregations = value; }
        }

        // Check to see if Aggregations property is set
        internal bool IsSetAggregations()
        {
            return this._aggregations != null && (this._aggregations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property GroupByColumnNames. 
        /// <para>
        /// The list of column names to group by when performing the aggregation. Rows with the
        /// same values in these columns will be grouped together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public List<string> GroupByColumnNames
        {
            get { return this._groupByColumnNames; }
            set { this._groupByColumnNames = value; }
        }

        // Check to see if GroupByColumnNames property is set
        internal bool IsSetGroupByColumnNames()
        {
            return this._groupByColumnNames != null && (this._groupByColumnNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source transform operation that provides input data for the aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformOperationSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}