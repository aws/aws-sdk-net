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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the GetNetworkRoutes operation.
    /// Gets the network routes of the specified global network.
    /// </summary>
    public partial class GetNetworkRoutesRequest : AmazonNetworkManagerRequest
    {
        private Dictionary<string, List<string>> _destinationFilters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private List<string> _exactCidrMatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _globalNetworkId;
        private List<string> _longestPrefixMatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _prefixListIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RouteTableIdentifier _routeTableIdentifier;
        private List<string> _states = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetOfMatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supernetOfMatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _types = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DestinationFilters. 
        /// <para>
        /// Filter by route table destination. Possible Values: TRANSIT_GATEWAY_ATTACHMENT_ID,
        /// RESOURCE_ID, or RESOURCE_TYPE.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> DestinationFilters
        {
            get { return this._destinationFilters; }
            set { this._destinationFilters = value; }
        }

        // Check to see if DestinationFilters property is set
        internal bool IsSetDestinationFilters()
        {
            return this._destinationFilters != null && (this._destinationFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExactCidrMatches. 
        /// <para>
        /// An exact CIDR block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExactCidrMatches
        {
            get { return this._exactCidrMatches; }
            set { this._exactCidrMatches = value; }
        }

        // Check to see if ExactCidrMatches property is set
        internal bool IsSetExactCidrMatches()
        {
            return this._exactCidrMatches != null && (this._exactCidrMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string GlobalNetworkId
        {
            get { return this._globalNetworkId; }
            set { this._globalNetworkId = value; }
        }

        // Check to see if GlobalNetworkId property is set
        internal bool IsSetGlobalNetworkId()
        {
            return this._globalNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property LongestPrefixMatches. 
        /// <para>
        /// The most specific route that matches the traffic (longest prefix match).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LongestPrefixMatches
        {
            get { return this._longestPrefixMatches; }
            set { this._longestPrefixMatches = value; }
        }

        // Check to see if LongestPrefixMatches property is set
        internal bool IsSetLongestPrefixMatches()
        {
            return this._longestPrefixMatches != null && (this._longestPrefixMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrefixListIds. 
        /// <para>
        /// The IDs of the prefix lists.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrefixListIds
        {
            get { return this._prefixListIds; }
            set { this._prefixListIds = value; }
        }

        // Check to see if PrefixListIds property is set
        internal bool IsSetPrefixListIds()
        {
            return this._prefixListIds != null && (this._prefixListIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RouteTableIdentifier. 
        /// <para>
        /// The ID of the route table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteTableIdentifier RouteTableIdentifier
        {
            get { return this._routeTableIdentifier; }
            set { this._routeTableIdentifier = value; }
        }

        // Check to see if RouteTableIdentifier property is set
        internal bool IsSetRouteTableIdentifier()
        {
            return this._routeTableIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property States. 
        /// <para>
        /// The route states.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> States
        {
            get { return this._states; }
            set { this._states = value; }
        }

        // Check to see if States property is set
        internal bool IsSetStates()
        {
            return this._states != null && (this._states.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetOfMatches. 
        /// <para>
        /// The routes with a subnet that match the specified CIDR filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetOfMatches
        {
            get { return this._subnetOfMatches; }
            set { this._subnetOfMatches = value; }
        }

        // Check to see if SubnetOfMatches property is set
        internal bool IsSetSubnetOfMatches()
        {
            return this._subnetOfMatches != null && (this._subnetOfMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupernetOfMatches. 
        /// <para>
        /// The routes with a CIDR that encompasses the CIDR filter. Example: If you specify 10.0.1.0/30,
        /// then the result returns 10.0.1.0/29.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupernetOfMatches
        {
            get { return this._supernetOfMatches; }
            set { this._supernetOfMatches = value; }
        }

        // Check to see if SupernetOfMatches property is set
        internal bool IsSetSupernetOfMatches()
        {
            return this._supernetOfMatches != null && (this._supernetOfMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// The route types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && (this._types.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}