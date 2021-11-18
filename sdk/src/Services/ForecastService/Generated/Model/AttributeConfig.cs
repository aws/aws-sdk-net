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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides information about the method used to transform attributes.
    /// 
    ///  
    /// <para>
    /// The following is an example using the RETAIL domain:
    /// </para>
    ///  
    /// <para>
    ///  <code>{</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"AttributeName": "demand",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"Transformations": {"aggregation": "sum", "middlefill": "zero", "backfill":
    /// "zero"}</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>}</code> 
    /// </para>
    /// </summary>
    public partial class AttributeConfig
    {
        private string _attributeName;
        private Dictionary<string, string> _transformations = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the attribute as specified in the schema. Amazon Forecast supports the
        /// target field of the target time series and the related time series datasets. For example,
        /// for the RETAIL domain, the target is <code>demand</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property Transformations. 
        /// <para>
        /// The method parameters (key-value pairs), which are a map of override parameters. Specify
        /// these parameters to override the default values. Related Time Series attributes do
        /// not accept aggregation parameters.
        /// </para>
        ///  
        /// <para>
        /// The following list shows the parameters and their valid values for the "filling" featurization
        /// method for a <b>Target Time Series</b> dataset. Default values are bolded.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aggregation</code>: <b>sum</b>, <code>avg</code>, <code>first</code>, <code>min</code>,
        /// <code>max</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>frontfill</code>: <b>none</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>middlefill</code>: <b>zero</b>, <code>nan</code> (not a number), <code>value</code>,
        /// <code>median</code>, <code>mean</code>, <code>min</code>, <code>max</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>backfill</code>: <b>zero</b>, <code>nan</code>, <code>value</code>, <code>median</code>,
        /// <code>mean</code>, <code>min</code>, <code>max</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following list shows the parameters and their valid values for a <b>Related Time
        /// Series</b> featurization method (there are no defaults):
        /// </para>
        ///  <ul> <li> 
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
        /// To set a filling method to a specific value, set the fill parameter to <code>value</code>
        /// and define the value in a corresponding <code>_value</code> parameter. For example,
        /// to set backfilling to a value of 2, include the following: <code>"backfill": "value"</code>
        /// and <code>"backfill_value":"2"</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public Dictionary<string, string> Transformations
        {
            get { return this._transformations; }
            set { this._transformations = value; }
        }

        // Check to see if Transformations property is set
        internal bool IsSetTransformations()
        {
            return this._transformations != null && this._transformations.Count > 0; 
        }

    }
}