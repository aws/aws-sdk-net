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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Provides additional selections for named shadows and geolocation data. 
    /// 
    ///  
    /// <para>
    /// To add named shadows to your fleet indexing configuration, set <c>namedShadowIndexingMode</c>
    /// to be ON and specify your shadow names in <c>namedShadowNames</c> filter.
    /// </para>
    ///  
    /// <para>
    /// To add geolocation data to your fleet indexing configuration: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you store geolocation data in a class/unnamed shadow, set <c>thingIndexingMode</c>
    /// to be <c>REGISTRY_AND_SHADOW</c> and specify your geolocation data in <c>geoLocations</c>
    /// filter. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you store geolocation data in a named shadow, set <c>namedShadowIndexingMode</c>
    /// to be <c>ON</c>, add the shadow name in <c>namedShadowNames</c> filter, and specify
    /// your geolocation data in <c>geoLocations</c> filter. For more information, see <a
    /// href="https://docs.aws.amazon.com/iot/latest/developerguide/managing-fleet-index.html">Managing
    /// fleet indexing</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class IndexingFilter
    {
        private List<GeoLocationTarget> _geoLocations = AWSConfigs.InitializeCollections ? new List<GeoLocationTarget>() : null;
        private List<string> _namedShadowNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property GeoLocations. 
        /// <para>
        /// The list of geolocation targets that you select to index. The default maximum number
        /// of geolocation targets for indexing is <c>1</c>. To increase the limit, see <a href="https://docs.aws.amazon.com/general/latest/gr/iot_device_management.html#fleet-indexing-limits">Amazon
        /// Web Services IoT Device Management Quotas</a> in the <i>Amazon Web Services General
        /// Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GeoLocationTarget> GeoLocations
        {
            get { return this._geoLocations; }
            set { this._geoLocations = value; }
        }

        // Check to see if GeoLocations property is set
        internal bool IsSetGeoLocations()
        {
            return this._geoLocations != null && (this._geoLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NamedShadowNames. 
        /// <para>
        /// The shadow names that you select to index. The default maximum number of shadow names
        /// for indexing is 10. To increase the limit, see <a href="https://docs.aws.amazon.com/general/latest/gr/iot_device_management.html#fleet-indexing-limits">Amazon
        /// Web Services IoT Device Management Quotas</a> in the <i>Amazon Web Services General
        /// Reference</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NamedShadowNames
        {
            get { return this._namedShadowNames; }
            set { this._namedShadowNames = value; }
        }

        // Check to see if NamedShadowNames property is set
        internal bool IsSetNamedShadowNames()
        {
            return this._namedShadowNames != null && (this._namedShadowNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}