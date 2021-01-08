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
    /// Container for the parameters to the CreateMap operation.
    /// Creates a map resource in your AWS account, which provides map tiles of different
    /// styles sourced from global location data providers.
    /// 
    ///  <note> 
    /// <para>
    /// By using Maps, you agree that AWS may transmit your API queries to your selected third
    /// party provider for processing, which may be outside the AWS region you are currently
    /// using. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
    /// Service Terms</a> for Amazon Location Service. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateMapRequest : AmazonLocationServiceRequest
    {
        private MapConfiguration _configuration;
        private string _description;
        private string _mapName;
        private PricingPlan _pricingPlan;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies the map style selected from an available data provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MapConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the map resource.
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
        /// Gets and sets the property MapName. 
        /// <para>
        /// The name for the map resource.
        /// </para>
        ///  
        /// <para>
        /// Requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain only alphanumeric characters (A–Z, a–z, 0–9), hyphens (-), and underscores
        /// (_). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be a unique map resource name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed. For example, <code>ExampleMap</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string MapName
        {
            get { return this._mapName; }
            set { this._mapName = value; }
        }

        // Check to see if MapName property is set
        internal bool IsSetMapName()
        {
            return this._mapName != null;
        }

        /// <summary>
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// Specifies the pricing plan for your map resource. There's three pricing plan options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RequestBasedUsage</code> — Selects the "Request-Based Usage" pricing plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MobileAssetTracking</code> — Selects the "Mobile Asset Tracking" pricing plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MobileAssetManagement</code> — Selects the "Mobile Asset Management" pricing
        /// plan.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For additional details and restrictions on each pricing plan option, see the <a href="https://aws.amazon.com/location/pricing/">Amazon
        /// Location Service pricing page</a>.
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

    }
}