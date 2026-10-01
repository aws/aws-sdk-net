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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AsPath. 
        /// <para>
        /// The BGP AS path for the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AsPath { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AsPath property is set.
        /// </summary>
        internal bool IsSetAsPath() => this.AsPath != null && (this.AsPath.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Communities. 
        /// <para>
        /// The BGP community values for the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Communities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Communities property is set.
        /// </summary>
        internal bool IsSetCommunities() => this.Communities != null && (this.Communities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocalPreference. 
        /// <para>
        /// The BGP local preference value for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string LocalPreference { get; set; }

        /// <summary>
        /// Checks to see if the LocalPreference property is set.
        /// </summary>
        internal bool IsSetLocalPreference() => this.LocalPreference != null;

        /// <summary>
        /// Gets and sets the property Med. 
        /// <para>
        /// The BGP Multi-Exit Discriminator (MED) value for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Med { get; set; }

        /// <summary>
        /// Checks to see if the Med property is set.
        /// </summary>
        internal bool IsSetMed() => this.Med != null;

        /// <summary>
        /// Gets and sets the property NextHop. 
        /// <para>
        /// The next hop information for the route.
        /// </para>
        /// </summary>
        public RoutingInformationNextHop NextHop { get; set; }

        /// <summary>
        /// Checks to see if the NextHop property is set.
        /// </summary>
        internal bool IsSetNextHop() => this.NextHop != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The IP prefix for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;
    }
}
