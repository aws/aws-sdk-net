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
    /// This is the response object from the GetDNSView operation.
    /// </summary>
    public partial class GetDNSViewResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency. This means that making
        /// the same request multiple times with the same <c>clientToken</c> has the same result
        /// every time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time and date the DNS view was creates on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DnssecValidation. 
        /// <para>
        /// Specifies whether DNSSEC is enabled or disabled for the DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DnsSecValidationType DnssecValidation { get; set; }

        /// <summary>
        /// Checks to see if the DnssecValidation property is set.
        /// </summary>
        internal bool IsSetDnssecValidation() => this.DnssecValidation != null;

        /// <summary>
        /// Gets and sets the property EdnsClientSubnet. 
        /// <para>
        /// Specifies whether edns0 client subnet is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EdnsClientSubnetType EdnsClientSubnet { get; set; }

        /// <summary>
        /// Checks to see if the EdnsClientSubnet property is set.
        /// </summary>
        internal bool IsSetEdnsClientSubnet() => this.EdnsClientSubnet != null;

        /// <summary>
        /// Gets and sets the property FirewallRulesFailOpen. 
        /// <para>
        /// Specifies the DNS Firewall failure mode configuration. When enabled, the DNS Firewall
        /// allows DNS queries to proceed if it's unable to properly evaluate them. When disabled,
        /// the DNS Firewall blocks DNS queries it's unable to evaluate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallRulesFailOpenType FirewallRulesFailOpen { get; set; }

        /// <summary>
        /// Checks to see if the FirewallRulesFailOpen property is set.
        /// </summary>
        internal bool IsSetFirewallRulesFailOpen() => this.FirewallRulesFailOpen != null;

        /// <summary>
        /// Gets and sets the property GlobalResolverId. 
        /// <para>
        /// ID of the Global Resolver the DNS view is associated to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string GlobalResolverId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalResolverId property is set.
        /// </summary>
        internal bool IsSetGlobalResolverId() => this.GlobalResolverId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID of the DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Operational status of the DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProfileResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time and date the DNS view was updated on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
