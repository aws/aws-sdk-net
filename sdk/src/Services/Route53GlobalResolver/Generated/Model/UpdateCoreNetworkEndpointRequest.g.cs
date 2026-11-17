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

namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCoreNetworkEndpoint operation. Updates the
    /// configuration of a core network endpoint. You can change the name and modify the IP
    /// addresses that the endpoint uses for DNS resolution. <important> <para> Route 53 Global
    /// Resolver is a global service that supports resolvers in multiple Amazon Web Services
    /// Regions, but you must specify the US East (Ohio) Region to create, update, or otherwise
    /// work with Route 53 Global Resolver resources. That is, for example, specify <c>--region
    /// us-east-2</c> on Amazon Web Services CLI commands. </para> </important>
    /// </summary>
    public partial class UpdateCoreNetworkEndpointRequest : AmazonRoute53GlobalResolverRequest
    {
        /// <summary>
        /// Gets and sets the property CoreNetworkEndpointId. 
        /// <para>
        /// The unique identifier of the core network endpoint to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CoreNetworkEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkEndpointId property is set.
        /// </summary>
        internal bool IsSetCoreNetworkEndpointId() => this.CoreNetworkEndpointId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the core network endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property UpdateIpAddresses. 
        /// <para>
        /// The IP address changes to apply to the core network endpoint. Use this parameter to
        /// add or remove the IP addresses that the endpoint uses to resolve DNS queries within
        /// the Amazon Web Services Cloud WAN core network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpdateIpAddressEntry> UpdateIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<UpdateIpAddressEntry>() : null;

        /// <summary>
        /// Checks to see if the UpdateIpAddresses property is set.
        /// </summary>
        internal bool IsSetUpdateIpAddresses() => this.UpdateIpAddresses != null && (this.UpdateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
