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
    /// A simple aggregation function that performs standard statistical operations on a column.
    /// </summary>
    public partial class DataPrepSimpleAggregationFunction
    {
        private DataPrepSimpleAggregationFunctionType _functionType;
        private string _inputColumnName;

        /// <summary>
        /// Gets and sets the property FunctionType. 
        /// <para>
        /// The type of aggregation function to perform, such as <c>COUNT</c>, <c>SUM</c>, <c>AVERAGE</c>,
        /// <c>MIN</c>, <c>MAX</c>, <c>MEDIAN</c>, <c>VARIANCE</c>, or <c>STANDARD_DEVIATION</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataPrepSimpleAggregationFunctionType FunctionType
        {
            get { return this._functionType; }
            set { this._functionType = value; }
        }

        // Check to see if FunctionType property is set
        internal bool IsSetFunctionType()
        {
            return this._functionType != null;
        }

        /// <summary>
        /// Gets and sets the property InputColumnName. 
        /// <para>
        /// The name of the column on which to perform the aggregation function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string InputColumnName
        {
            get { return this._inputColumnName; }
            set { this._inputColumnName = value; }
        }

        // Check to see if InputColumnName property is set
        internal bool IsSetInputColumnName()
        {
            return this._inputColumnName != null;
        }

    }
}