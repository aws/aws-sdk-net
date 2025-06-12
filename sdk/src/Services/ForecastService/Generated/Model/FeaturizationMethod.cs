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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides information about the method that featurizes (transforms) a dataset field.
    /// The method is part of the <c>FeaturizationPipeline</c> of the <a>Featurization</a>
    /// object. 
    /// 
    ///  
    /// <para>
    /// The following is an example of how you specify a <c>FeaturizationMethod</c> object.
    /// </para>
    ///  
    /// <para>
    ///  <c>{</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>"FeaturizationMethodName": "filling",</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>"FeaturizationMethodParameters": {"aggregation": "sum", "middlefill": "zero",
    /// "backfill": "zero"}</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>}</c> 
    /// </para>
    /// </summary>
    public partial class FeaturizationMethod
    {
        private FeaturizationMethodName _featurizationMethodName;
        private Dictionary<string, string> _featurizationMethodParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property FeaturizationMethodName. 
        /// <para>
        /// The name of the method. The "filling" method is the only supported method.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeaturizationMethodName FeaturizationMethodName
        {
            get { return this._featurizationMethodName; }
            set { this._featurizationMethodName = value; }
        }

        // Check to see if FeaturizationMethodName property is set
        internal bool IsSetFeaturizationMethodName()
        {
            return this._featurizationMethodName != null;
        }

        /// <summary>
        /// Gets and sets the property FeaturizationMethodParameters. 
        /// <para>
        /// The method parameters (key-value pairs), which are a map of override parameters. Specify
        /// these parameters to override the default values. Related Time Series attributes do
        /// not accept aggregation parameters.
        /// </para>
        ///  
        /// <para>
        /// The following list shows the parameters and their valid values for the "filling" featurization
        /// method for a <b>Target Time Series</b> dataset. Bold signifies the default value.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aggregation</c>: <b>sum</b>, <c>avg</c>, <c>first</c>, <c>min</c>, <c>max</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>frontfill</c>: <b>none</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>middlefill</c>: <b>zero</b>, <c>nan</c> (not a number), <c>value</c>, <c>median</c>,
        /// <c>mean</c>, <c>min</c>, <c>max</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>backfill</c>: <b>zero</b>, <c>nan</c>, <c>value</c>, <c>median</c>, <c>mean</c>,
        /// <c>min</c>, <c>max</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following list shows the parameters and their valid values for a <b>Related Time
        /// Series</b> featurization method (there are no defaults):
        /// </para>
        ///  <ul> <li> 
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
        /// To set a filling method to a specific value, set the fill parameter to <c>value</c>
        /// and define the value in a corresponding <c>_value</c> parameter. For example, to set
        /// backfilling to a value of 2, include the following: <c>"backfill": "value"</c> and
        /// <c>"backfill_value":"2"</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public Dictionary<string, string> FeaturizationMethodParameters
        {
            get { return this._featurizationMethodParameters; }
            set { this._featurizationMethodParameters = value; }
        }

        // Check to see if FeaturizationMethodParameters property is set
        internal bool IsSetFeaturizationMethodParameters()
        {
            return this._featurizationMethodParameters != null && (this._featurizationMethodParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}