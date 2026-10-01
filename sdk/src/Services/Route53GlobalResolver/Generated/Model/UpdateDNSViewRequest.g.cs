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
    /// Container for the parameters to the UpdateDNSView operation. Updates the configuration
    /// of a DNS view. <important> <para> Route 53 Global Resolver is a global service that
    /// supports resolvers in multiple Amazon Web Services Regions but you must specify the
    /// US East (Ohio) Region to create, update, or otherwise work with Route 53 Global Resolver
    /// resources. That is, for example, specify <c>--region us-east-2</c> on Amazon Web Services
    /// CLI commands. </para> </important>
    /// </summary>
    public partial class UpdateDNSViewRequest : AmazonRoute53GlobalResolverRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DnsViewId. 
        /// <para>
        /// The unique identifier of the DNS view to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DnsViewId { get; set; }

        /// <summary>
        /// Checks to see if the DnsViewId property is set.
        /// </summary>
        internal bool IsSetDnsViewId() => this.DnsViewId != null;

        /// <summary>
        /// Gets and sets the property DnssecValidation. 
        /// <para>
        /// Whether to enable DNSSEC validation for the DNS view.
        /// </para>
        /// </summary>
        public DnsSecValidationType DnssecValidation { get; set; }

        /// <summary>
        /// Checks to see if the DnssecValidation property is set.
        /// </summary>
        internal bool IsSetDnssecValidation() => this.DnssecValidation != null;

        /// <summary>
        /// Gets and sets the property EdnsClientSubnet. 
        /// <para>
        /// Whether to enable EDNS Client Subnet injection for the DNS view.
        /// </para>
        /// </summary>
        public EdnsClientSubnetType EdnsClientSubnet { get; set; }

        /// <summary>
        /// Checks to see if the EdnsClientSubnet property is set.
        /// </summary>
        internal bool IsSetEdnsClientSubnet() => this.EdnsClientSubnet != null;

        /// <summary>
        /// Gets and sets the property FirewallRulesFailOpen. 
        /// <para>
        /// Whether firewall rules should fail open when they cannot be evaluated.
        /// </para>
        /// </summary>
        public FirewallRulesFailOpenType FirewallRulesFailOpen { get; set; }

        /// <summary>
        /// Checks to see if the FirewallRulesFailOpen property is set.
        /// </summary>
        internal bool IsSetFirewallRulesFailOpen() => this.FirewallRulesFailOpen != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
