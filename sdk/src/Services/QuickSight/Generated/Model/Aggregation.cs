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
    /// Defines an aggregation function to be applied to grouped data, creating a new column
    /// with the calculated result.
    /// </summary>
    public partial class Aggregation
    {
        private DataPrepAggregationFunction _aggregationFunction;
        private string _newColumnId;
        private string _newColumnName;

        /// <summary>
        /// Gets and sets the property AggregationFunction. 
        /// <para>
        /// The aggregation function to apply, such as <c>SUM</c>, <c>COUNT</c>, <c>AVERAGE</c>,
        /// <c>MIN</c>, <c>MAX</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataPrepAggregationFunction AggregationFunction
        {
            get { return this._aggregationFunction; }
            set { this._aggregationFunction = value; }
        }

        // Check to see if AggregationFunction property is set
        internal bool IsSetAggregationFunction()
        {
            return this._aggregationFunction != null;
        }

        /// <summary>
        /// Gets and sets the property NewColumnId. 
        /// <para>
        /// A unique identifier for the new column that will contain the aggregated values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string NewColumnId
        {
            get { return this._newColumnId; }
            set { this._newColumnId = value; }
        }

        // Check to see if NewColumnId property is set
        internal bool IsSetNewColumnId()
        {
            return this._newColumnId != null;
        }

        /// <summary>
        /// Gets and sets the property NewColumnName. 
        /// <para>
        /// The name for the new column that will contain the aggregated values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string NewColumnName
        {
            get { return this._newColumnName; }
            set { this._newColumnName = value; }
        }

        // Check to see if NewColumnName property is set
        internal bool IsSetNewColumnName()
        {
            return this._newColumnName != null;
        }

    }
}