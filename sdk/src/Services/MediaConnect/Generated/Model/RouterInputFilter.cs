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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A filter that can be used to retrieve a list of router inputs.
    /// </summary>
    public partial class RouterInputFilter
    {
        private List<string> _inputTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _nameContains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _networkInterfaceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _regionNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _routingScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property InputTypes. 
        /// <para>
        /// The types of router inputs to include in the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InputTypes
        {
            get { return this._inputTypes; }
            set { this._inputTypes = value; }
        }

        // Check to see if InputTypes property is set
        internal bool IsSetInputTypes()
        {
            return this._inputTypes != null && (this._inputTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// The names of the router inputs to include in the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null && (this._nameContains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the network interfaces associated with the router
        /// inputs to include in the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkInterfaceArns
        {
            get { return this._networkInterfaceArns; }
            set { this._networkInterfaceArns = value; }
        }

        // Check to see if NetworkInterfaceArns property is set
        internal bool IsSetNetworkInterfaceArns()
        {
            return this._networkInterfaceArns != null && (this._networkInterfaceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegionNames. 
        /// <para>
        /// The AWS Regions of the router inputs to include in the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RegionNames
        {
            get { return this._regionNames; }
            set { this._regionNames = value; }
        }

        // Check to see if RegionNames property is set
        internal bool IsSetRegionNames()
        {
            return this._regionNames != null && (this._regionNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoutingScopes. 
        /// <para>
        /// Filter criteria to list router inputs based on their routing scope (REGIONAL or GLOBAL).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RoutingScopes
        {
            get { return this._routingScopes; }
            set { this._routingScopes = value; }
        }

        // Check to see if RoutingScopes property is set
        internal bool IsSetRoutingScopes()
        {
            return this._routingScopes != null && (this._routingScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}