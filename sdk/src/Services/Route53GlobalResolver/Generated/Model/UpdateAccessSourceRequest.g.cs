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
    /// Container for the parameters to the UpdateAccessSource operation. Updates the configuration
    /// of an access source. <important> <para> Route 53 Global Resolver is a global service
    /// that supports resolvers in multiple Amazon Web Services Regions but you must specify
    /// the US East (Ohio) Region to create, update, or otherwise work with Route 53 Global
    /// Resolver resources. That is, for example, specify <c>--region us-east-2</c> on Amazon
    /// Web Services CLI commands. </para> </important>
    /// </summary>
    public partial class UpdateAccessSourceRequest : AmazonRoute53GlobalResolverRequest
    {
        /// <summary>
        /// Gets and sets the property AccessSourceId. 
        /// <para>
        /// The unique identifier of the access source to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AccessSourceId { get; set; }

        /// <summary>
        /// Checks to see if the AccessSourceId property is set.
        /// </summary>
        internal bool IsSetAccessSourceId() => this.AccessSourceId != null;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR block for the access source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 43)]
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the access source.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the access source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for the access source.
        /// </para>
        /// </summary>
        public DnsProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;
    }
}
