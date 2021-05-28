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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRouteCalculator operation.
    /// Creates a route calculator resource in your AWS account.
    /// 
    ///  
    /// <para>
    /// You can send requests to a route calculator resource to estimate travel time, distance,
    /// and get directions. A route calculator sources traffic and road network data from
    /// your chosen data provider.
    /// </para>
    /// </summary>
    public partial class CreateRouteCalculatorRequest : AmazonLocationServiceRequest
    {
        private string _calculatorName;
        private string _dataSource;
        private string _description;
        private PricingPlan _pricingPlan;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CalculatorName. 
        /// <para>
        /// The name of the route calculator resource. 
        /// </para>
        ///  
        /// <para>
        /// Requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can use alphanumeric characters (A–Z, a–z, 0–9) , hyphens (-), periods (.), and underscores
        /// (_).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be a unique Route calculator resource name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed. For example, <code>ExampleRouteCalculator</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CalculatorName
        {
            get { return this._calculatorName; }
            set { this._calculatorName = value; }
        }

        // Check to see if CalculatorName property is set
        internal bool IsSetCalculatorName()
        {
            return this._calculatorName != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// Specifies the data provider of traffic and road network data.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is case-sensitive. Enter the valid values as shown. For example, entering
        /// <code>HERE</code> returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <code>Esri</code> | <code>Here</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information about data providers, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/what-is-data-provider.html">Amazon
        /// Location Service data providers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for the route calculator resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// Specifies the pricing plan for your route calculator resource.
        /// </para>
        ///  
        /// <para>
        /// For additional details and restrictions on each pricing plan option, see <a href="https://aws.amazon.com/location/pricing/">Amazon
        /// Location Service pricing</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingPlan PricingPlan
        {
            get { return this._pricingPlan; }
            set { this._pricingPlan = value; }
        }

        // Check to see if PricingPlan property is set
        internal bool IsSetPricingPlan()
        {
            return this._pricingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Applies one or more tags to the route calculator resource. A tag is a key-value pair
        /// helps manage, identify, search, and filter your resources by labelling them.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example: { <code>"tag1" : "value1"</code>, <code>"tag2" : "value2"</code>}
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Format: <code>"key" : "value"</code> 
        /// </para>
        ///  
        /// <para>
        /// Restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum 50 tags per resource
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource tag must be unique with a maximum of one value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length: 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length: 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can use alphanumeric characters (A–Z, a–z, 0–9), and the following characters: + -
        /// = . _ : / @. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}