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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Transformations allowed on the dataset. Supported transformations are <code>Filling</code>
    /// and <code>Aggregation</code>. <code>Filling</code> specifies how to add values to
    /// missing values in the dataset. <code>Aggregation</code> defines how to aggregate data
    /// that does not align with forecast frequency.
    /// </summary>
    public partial class TimeSeriesTransformations
    {
        private Dictionary<string, string> _aggregation = new Dictionary<string, string>();
        private Dictionary<string, Dictionary<string, string>> _filling = new Dictionary<string, Dictionary<string, string>>();

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// A key value pair defining the aggregation method for a column, where the key is the
        /// column name and the value is the aggregation method.
        /// </para>
        ///  
        /// <para>
        /// The supported aggregation methods are <code>sum</code> (default), <code>avg</code>,
        /// <code>first</code>, <code>min</code>, <code>max</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Aggregation is only supported for the target column.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Aggregation
        {
            get { return this._aggregation; }
            set { this._aggregation = value; }
        }

        // Check to see if Aggregation property is set
        internal bool IsSetAggregation()
        {
            return this._aggregation != null && this._aggregation.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filling. 
        /// <para>
        /// A key value pair defining the filling method for a column, where the key is the column
        /// name and the value is an object which defines the filling logic. You can specify multiple
        /// filling methods for a single column.
        /// </para>
        ///  
        /// <para>
        /// The supported filling methods and their corresponding options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>frontfill</code>: <code>none</code> (Supported only for target column)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>middlefill</code>: <code>zero</code>, <code>value</code>, <code>median</code>,
        /// <code>mean</code>, <code>min</code>, <code>max</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>backfill</code>: <code>zero</code>, <code>value</code>, <code>median</code>,
        /// <code>mean</code>, <code>min</code>, <code>max</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>futurefill</code>: <code>zero</code>, <code>value</code>, <code>median</code>,
        /// <code>mean</code>, <code>min</code>, <code>max</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To set a filling method to a specific value, set the fill parameter to the chosen
        /// filling method value (for example <code>"backfill" : "value"</code>), and define the
        /// filling value in an additional parameter prefixed with "_value". For example, to set
        /// <code>backfill</code> to a value of <code>2</code>, you must include two parameters:
        /// <code>"backfill": "value"</code> and <code>"backfill_value":"2"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, Dictionary<string, string>> Filling
        {
            get { return this._filling; }
            set { this._filling = value; }
        }

        // Check to see if Filling property is set
        internal bool IsSetFilling()
        {
            return this._filling != null && this._filling.Count > 0; 
        }

    }
}