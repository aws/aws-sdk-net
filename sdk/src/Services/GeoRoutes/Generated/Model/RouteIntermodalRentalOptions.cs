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
    /// Options for the rental leg of the intermodal route.
    /// </summary>
    public partial class RouteIntermodalRentalOptions
    {
        private List<string> _allowedModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _enabledFor = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _excludedModes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedModes. 
        /// <para>
        /// Allowed rental transport modes when calculating the route. By default, all transport
        /// modes are allowed. Cannot be used together with <c>ExcludedModes</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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
        /// Gets and sets the property EnabledFor. 
        /// <para>
        /// Specifies the portion of the route for which this leg type is enabled. By default,
        /// the leg type is enabled for all legs. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FirstLeg</c> - Enable this leg type for the first non-pedestrian leg of the route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LastLeg</c> - Enable this leg type for the last non-pedestrian leg of the route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EntireRoute</c> - Enable this leg type for the entire route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>None</c> - Disable this leg type entirely.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> EnabledFor
        {
            get { return this._enabledFor; }
            set { this._enabledFor = value; }
        }

        // Check to see if EnabledFor property is set
        internal bool IsSetEnabledFor()
        {
            return this._enabledFor != null && (this._enabledFor.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludedModes. 
        /// <para>
        /// Excluded rental transport modes when calculating the route. By default, all transport
        /// modes are allowed. Cannot be used together with <c>AllowedModes</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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

    }
}