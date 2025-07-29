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
    /// API Restrictions on the allowed actions, resources, and referers for an API key resource.
    /// </summary>
    public partial class ApiKeyRestrictions
    {
        private List<string> _allowActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowReferers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowResources = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowActions. 
        /// <para>
        /// A list of allowed actions that an API key resource grants permissions to perform.
        /// You must have at least one action for each type of resource. For example, if you have
        /// a place resource, you must include at least one place action.
        /// </para>
        ///  
        /// <para>
        /// The following are valid values for the actions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Map actions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>geo:GetMap*</c> - Allows all actions needed for map rendering.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-maps:GetTile</c> - Allows retrieving map tiles.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-maps:GetStaticMap</c> - Allows retrieving static map images.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-maps:*</c> - Allows all actions related to map functionalities.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Place actions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>geo:SearchPlaceIndexForText</c> - Allows geocoding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo:SearchPlaceIndexForPosition</c> - Allows reverse geocoding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo:SearchPlaceIndexForSuggestions</c> - Allows generating suggestions from text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GetPlace</c> - Allows finding a place by place ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-places:Geocode</c> - Allows geocoding using place information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-places:ReverseGeocode</c> - Allows reverse geocoding from location coordinates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-places:SearchNearby</c> - Allows searching for places near a location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-places:SearchText</c> - Allows searching for places based on text input.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-places:Autocomplete</c> - Allows auto-completion of place names based on text
        /// input.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-places:Suggest</c> - Allows generating suggestions for places based on partial
        /// input.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-places:GetPlace</c> - Allows finding a place by its ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-places:*</c> - Allows all actions related to place services.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Route actions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>geo:CalculateRoute</c> - Allows point to point routing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo:CalculateRouteMatrix</c> - Allows calculating a matrix of routes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-routes:CalculateRoutes</c> - Allows calculating multiple routes between points.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-routes:CalculateRouteMatrix</c> - Allows calculating a matrix of routes between
        /// points.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-routes:CalculateIsolines</c> - Allows calculating isolines for a given area.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-routes:OptimizeWaypoints</c> - Allows optimizing the order of waypoints in
        /// a route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-routes:SnapToRoads</c> - Allows snapping a route to the nearest roads.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>geo-routes:*</c> - Allows all actions related to routing functionalities.
        /// </para>
        ///  </li> </ul> </li> </ul> <note> 
        /// <para>
        /// You must use these strings exactly. For example, to provide access to map rendering,
        /// the only valid action is <c>geo:GetMap*</c> as an input to the list. <c>["geo:GetMap*"]</c>
        /// is valid but <c>["geo:GetMapTile"]</c> is not. Similarly, you cannot use <c>["geo:SearchPlaceIndexFor*"]</c>
        /// - you must list each of the Place actions separately.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=24)]
        public List<string> AllowActions
        {
            get { return this._allowActions; }
            set { this._allowActions = value; }
        }

        // Check to see if AllowActions property is set
        internal bool IsSetAllowActions()
        {
            return this._allowActions != null && (this._allowActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowReferers. 
        /// <para>
        /// An optional list of allowed HTTP referers for which requests must originate from.
        /// Requests using this API key from other domains will not be allowed.
        /// </para>
        ///  
        /// <para>
        /// Requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only alphanumeric characters (A–Z, a–z, 0–9) or any symbols in this list <c>$\-._+!*`(),;/?:@=&amp;</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// May contain a percent (%) if followed by 2 hexadecimal digits (A-F, a-f, 0-9); this
        /// is used for URL encoding purposes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// May contain wildcard characters question mark (?) and asterisk (*).
        /// </para>
        ///  
        /// <para>
        /// Question mark (?) will replace any single character (including hexadecimal digits).
        /// </para>
        ///  
        /// <para>
        /// Asterisk (*) will replace any multiple characters (including multiple hexadecimal
        /// digits).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed. For example, <c>https://example.com</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> AllowReferers
        {
            get { return this._allowReferers; }
            set { this._allowReferers = value; }
        }

        // Check to see if AllowReferers property is set
        internal bool IsSetAllowReferers()
        {
            return this._allowReferers != null && (this._allowReferers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowResources. 
        /// <para>
        /// A list of allowed resource ARNs that a API key bearer can perform actions on.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The ARN must be the correct ARN for a map, place, or route ARN. You may include wildcards
        /// in the resource-id to match multiple resources of the same type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resources must be in the same <c>partition</c>, <c>region</c>, and <c>account-id</c>
        /// as the key that is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Other than wildcards, you must include the full ARN, including the <c>arn</c>, <c>partition</c>,
        /// <c>service</c>, <c>region</c>, <c>account-id</c> and <c>resource-id</c> delimited
        /// by colons (:).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed, even with wildcards. For example, <c>arn:aws:geo:region:<i>account-id</i>:map/ExampleMap*</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about ARN format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
        public List<string> AllowResources
        {
            get { return this._allowResources; }
            set { this._allowResources = value; }
        }

        // Check to see if AllowResources property is set
        internal bool IsSetAllowResources()
        {
            return this._allowResources != null && (this._allowResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}