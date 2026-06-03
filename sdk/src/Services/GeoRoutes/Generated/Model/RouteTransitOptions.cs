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
    /// Options related to transit routing.
    /// 
    ///  <note> 
    /// <para>
    /// Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
    /// customers.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RouteTransitOptions
    {
        private List<string> _accessibilityAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _excludedModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxTransfers;
        private RouteTransitPedestrianOptions _pedestrian;

        /// <summary>
        /// Gets and sets the property AccessibilityAttributes. 
        /// <para>
        /// Accessibility attributes to consider when calculating the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> AccessibilityAttributes
        {
            get { return this._accessibilityAttributes; }
            set { this._accessibilityAttributes = value; }
        }

        // Check to see if AccessibilityAttributes property is set
        internal bool IsSetAccessibilityAttributes()
        {
            return this._accessibilityAttributes != null && (this._accessibilityAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedModes. 
        /// <para>
        /// Allowed transit transport modes when calculating the route. By default, all transport
        /// modes are allowed. Cannot be used together with <c>ExcludedModes</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public List<string> AllowedModes
        {
            get { return this._allowedModes; }
            set { this._allowedModes = value; }
        }

        // Check to see if AllowedModes property is set
        internal bool IsSetAllowedModes()
        {
            return this._allowedModes != null && (this._allowedModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludedModes. 
        /// <para>
        /// Excluded transit transport modes when calculating the route. By default, all transport
        /// modes are allowed. Cannot be used together with <c>AllowedModes</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public List<string> ExcludedModes
        {
            get { return this._excludedModes; }
            set { this._excludedModes = value; }
        }

        // Check to see if ExcludedModes property is set
        internal bool IsSetExcludedModes()
        {
            return this._excludedModes != null && (this._excludedModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxTransfers. 
        /// <para>
        /// Maximum number of transfers allowed when calculating the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public int? MaxTransfers
        {
            get { return this._maxTransfers; }
            set { this._maxTransfers = value; }
        }

        // Check to see if MaxTransfers property is set
        internal bool IsSetMaxTransfers()
        {
            return this._maxTransfers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pedestrian. 
        /// <para>
        /// Options for the pedestrian leg of the transit route.
        /// </para>
        /// </summary>
        public RouteTransitPedestrianOptions Pedestrian
        {
            get { return this._pedestrian; }
            set { this._pedestrian = value; }
        }

        // Check to see if Pedestrian property is set
        internal bool IsSetPedestrian()
        {
            return this._pedestrian != null;
        }

    }
}