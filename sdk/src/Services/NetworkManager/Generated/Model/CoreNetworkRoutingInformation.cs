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
    /// Routing information for a core network, including route details and BGP attributes.
    /// </summary>
    public partial class CoreNetworkRoutingInformation
    {
        private List<string> _asPath = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _communities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _localPreference;
        private string _med;
        private RoutingInformationNextHop _nextHop;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property AsPath. 
        /// <para>
        /// The BGP AS path for the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AsPath
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
        /// Gets and sets the property Communities. 
        /// <para>
        /// The BGP community values for the route.
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
        /// Gets and sets the property LocalPreference. 
        /// <para>
        /// The BGP local preference value for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string LocalPreference
        {
            get { return this._localPreference; }
            set { this._localPreference = value; }
        }

        // Check to see if LocalPreference property is set
        internal bool IsSetLocalPreference()
        {
            return this._localPreference != null;
        }

        /// <summary>
        /// Gets and sets the property Med. 
        /// <para>
        /// The BGP Multi-Exit Discriminator (MED) value for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Med
        {
            get { return this._med; }
            set { this._med = value; }
        }

        // Check to see if Med property is set
        internal bool IsSetMed()
        {
            return this._med != null;
        }

        /// <summary>
        /// Gets and sets the property NextHop. 
        /// <para>
        /// The next hop information for the route.
        /// </para>
        /// </summary>
        public RoutingInformationNextHop NextHop
        {
            get { return this._nextHop; }
            set { this._nextHop = value; }
        }

        // Check to see if NextHop property is set
        internal bool IsSetNextHop()
        {
            return this._nextHop != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The IP prefix for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}