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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// The filters used to limit the routes returned by <a>ListVirtualInterfaceRoutes</a>.
    /// </summary>
    public partial class RouteFilters
    {
        private AddressFamily _addressFamily;
        private List<long> _asPath = AWSConfigs.InitializeCollections ? new List<long>() : null;
        private List<string> _cidrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _communities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RouteDirection _routeDirection;

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family of the routes to return.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>ipv4</c> and <c>ipv6</c>.
        /// </para>
        /// </summary>
        public AddressFamily AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property AsPath. 
        /// <para>
        /// The autonomous system (AS) numbers used to filter the routes by their AS path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<long> AsPath
        {
            get { return this._asPath; }
            set { this._asPath = value; }
        }

        // Check to see if AsPath property is set
        internal bool IsSetAsPath()
        {
            return this._asPath != null && (this._asPath.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Cidrs. 
        /// <para>
        /// The CIDRs (prefixes) used to filter the routes. You can specify up to 10 CIDRs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Cidrs
        {
            get { return this._cidrs; }
            set { this._cidrs = value; }
        }

        // Check to see if Cidrs property is set
        internal bool IsSetCidrs()
        {
            return this._cidrs != null && (this._cidrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Communities. 
        /// <para>
        /// The BGP communities used to filter the routes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Communities
        {
            get { return this._communities; }
            set { this._communities = value; }
        }

        // Check to see if Communities property is set
        internal bool IsSetCommunities()
        {
            return this._communities != null && (this._communities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RouteDirection. 
        /// <para>
        /// The direction of the routes to return.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>accepted</c> (routes received from the customer network) and
        /// <c>advertised</c> (routes advertised to the customer network).
        /// </para>
        /// </summary>
        public RouteDirection RouteDirection
        {
            get { return this._routeDirection; }
            set { this._routeDirection = value; }
        }

        // Check to see if RouteDirection property is set
        internal bool IsSetRouteDirection()
        {
            return this._routeDirection != null;
        }

    }
}