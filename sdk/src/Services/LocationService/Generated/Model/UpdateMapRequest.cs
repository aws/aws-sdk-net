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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMap operation.
    /// <important> 
    /// <para>
    /// This operation is no longer current and may be deprecated in the future. We recommend
    /// upgrading to the Maps API V2 unless you require <c>Grab</c> data.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>UpdateMap</c> is part of a previous Amazon Location Service Maps API (version
    /// 1) which has been superseded by a more intuitive, powerful, and complete API (version
    /// 2).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Maps API version 2 has a simplified interface that can be used without creating
    /// or managing map resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are using an AWS SDK or the AWS CLI, note that the Maps API version 2 is found
    /// under <c>geo-maps</c> or <c>geo_maps</c>, not under <c>location</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Since <c>Grab</c> is not yet fully supported in Maps API version 2, we recommend you
    /// continue using API version 1 when using <c>Grab</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Start your version 2 API journey with the <a href="https://docs.aws.amazon.com/location/latest/APIReference/API_Operations_Amazon_Location_Service_Maps_V2.html">Maps
    /// V2 API Reference</a> or the <a href="https://docs.aws.amazon.com/location/latest/developerguide/maps.html">Developer
    /// Guide</a>.
    /// </para>
    ///  </li> </ul> </important> 
    /// <para>
    /// Updates the specified properties of a given map resource.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class UpdateMapRequest : AmazonLocationServiceRequest
    {
        private MapConfigurationUpdate _configurationUpdate;
        private string _description;
        private string _mapName;
        private PricingPlan _pricingPlan;

        /// <summary>
        /// Gets and sets the property ConfigurationUpdate. 
        /// <para>
        /// Updates the parts of the map configuration that can be updated, including the political
        /// view.
        /// </para>
        /// </summary>
        public MapConfigurationUpdate ConfigurationUpdate
        {
            get { return this._configurationUpdate; }
            set { this._configurationUpdate = value; }
        }

        // Check to see if ConfigurationUpdate property is set
        internal bool IsSetConfigurationUpdate()
        {
            return this._configurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Updates the description for the map resource.
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
        /// The name of the map resource to update.
        /// </para>
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
        /// No longer used. If included, the only allowed value is <c>RequestBasedUsage</c>.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. If included, the only allowed value is RequestBasedUsage.")]
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