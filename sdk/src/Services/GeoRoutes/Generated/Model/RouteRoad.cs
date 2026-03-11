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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// The road on the route.
    /// </summary>
    public partial class RouteRoad
    {
        private List<LocalizedString> _roadName = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;
        private List<RouteNumber> _routeNumber = AWSConfigs.InitializeCollections ? new List<RouteNumber>() : null;
        private List<LocalizedString> _towards = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;
        private RouteRoadType _type;

        /// <summary>
        /// Gets and sets the property RoadName. 
        /// <para>
        /// Name of the road (localized).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LocalizedString> RoadName
        {
            get { return this._roadName; }
            set { this._roadName = value; }
        }

        // Check to see if RoadName property is set
        internal bool IsSetRoadName()
        {
            return this._roadName != null && (this._roadName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RouteNumber. 
        /// <para>
        /// Route number of the road.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteNumber> RouteNumber
        {
            get { return this._routeNumber; }
            set { this._routeNumber = value; }
        }

        // Check to see if RouteNumber property is set
        internal bool IsSetRouteNumber()
        {
            return this._routeNumber != null && (this._routeNumber.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Towards. 
        /// <para>
        /// Names of destinations that can be reached when traveling on the road.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LocalizedString> Towards
        {
            get { return this._towards; }
            set { this._towards = value; }
        }

        // Check to see if Towards property is set
        internal bool IsSetTowards()
        {
            return this._towards != null && (this._towards.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of road.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteRoadType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}