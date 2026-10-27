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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNetwork operation. Change the settings for
    /// a Network.
    /// </summary>
    public partial class UpdateNetworkRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property IpPools. Include this parameter only if you want to change
        /// the pool of IP addresses in the network. An array of IpPoolCreateRequests that identify
        /// a collection of IP addresses in this network that you want to reserve for use in MediaLive
        /// Anywhere. MediaLive Anywhere uses these IP addresses for Push inputs (in both Bridge
        /// and NAT networks) and for output destinations (only in Bridge networks). Each IpPoolUpdateRequest
        /// specifies one CIDR block.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpPoolUpdateRequest> IpPools { get; set; } = AWSConfigs.InitializeCollections ? new List<IpPoolUpdateRequest>() : null;

        /// <summary>
        /// Checks to see if the IpPools property is set.
        /// </summary>
        internal bool IsSetIpPools() => this.IpPools != null && (this.IpPools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. Include this parameter only if you want to change
        /// the name of the Network. Specify a name that is unique in the AWS account. Names are
        /// case-sensitive.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkId. The ID of the network
        /// </summary>
        [AWSProperty(Required = true)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property Routes. Include this parameter only if you want to change
        /// or add routes in the Network. An array of Routes that MediaLive Anywhere needs to
        /// know about in order to route encoding traffic.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteUpdateRequest> Routes { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteUpdateRequest>() : null;

        /// <summary>
        /// Checks to see if the Routes property is set.
        /// </summary>
        internal bool IsSetRoutes() => this.Routes != null && (this.Routes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
