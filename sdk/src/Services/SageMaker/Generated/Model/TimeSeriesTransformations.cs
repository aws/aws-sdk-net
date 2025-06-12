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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Transformations allowed on the dataset. Supported transformations are <c>Filling</c>
    /// and <c>Aggregation</c>. <c>Filling</c> specifies how to add values to missing values
    /// in the dataset. <c>Aggregation</c> defines how to aggregate data that does not align
    /// with forecast frequency.
    /// </summary>
    public partial class TimeSeriesTransformations
    {
        private Dictionary<string, string> _aggregation = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, Dictionary<string, string>> _filling = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// A key value pair defining the aggregation method for a column, where the key is the
        /// column name and the value is the aggregation method.
        /// </para>
        ///  
        /// <para>
        /// The supported aggregation methods are <c>sum</c> (default), <c>avg</c>, <c>first</c>,
        /// <c>min</c>, <c>max</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Aggregation is only supported for the target column.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._aggregation != null && (this._aggregation.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        ///  <c>frontfill</c>: <c>none</c> (Supported only for target column)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>middlefill</c>: <c>zero</c>, <c>value</c>, <c>median</c>, <c>mean</c>, <c>min</c>,
        /// <c>max</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>backfill</c>: <c>zero</c>, <c>value</c>, <c>median</c>, <c>mean</c>, <c>min</c>,
        /// <c>max</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>futurefill</c>: <c>zero</c>, <c>value</c>, <c>median</c>, <c>mean</c>, <c>min</c>,
        /// <c>max</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To set a filling method to a specific value, set the fill parameter to the chosen
        /// filling method value (for example <c>"backfill" : "value"</c>), and define the filling
        /// value in an additional parameter prefixed with "_value". For example, to set <c>backfill</c>
        /// to a value of <c>2</c>, you must include two parameters: <c>"backfill": "value"</c>
        /// and <c>"backfill_value":"2"</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._filling != null && (this._filling.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}