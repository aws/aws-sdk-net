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
    /// This is the response object from the CreateFirewallRule operation.
    /// </summary>
    public partial class CreateFirewallRuleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that DNS Firewall takes on DNS queries that match this rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallRuleAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property BlockOverrideDnsType. 
        /// <para>
        /// The DNS record type for the custom response when blockResponse is OVERRIDE.
        /// </para>
        /// </summary>
        public BlockOverrideDnsQueryType BlockOverrideDnsType { get; set; }

        /// <summary>
        /// Checks to see if the BlockOverrideDnsType property is set.
        /// </summary>
        internal bool IsSetBlockOverrideDnsType() => this.BlockOverrideDnsType != null;

        /// <summary>
        /// Gets and sets the property BlockOverrideDomain. 
        /// <para>
        /// The custom domain to return when the action is BLOCK and blockResponse is OVERRIDE.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string BlockOverrideDomain { get; set; }

        /// <summary>
        /// Checks to see if the BlockOverrideDomain property is set.
        /// </summary>
        internal bool IsSetBlockOverrideDomain() => this.BlockOverrideDomain != null;

        /// <summary>
        /// Gets and sets the property BlockOverrideTtl. 
        /// <para>
        /// The time-to-live (TTL) value for the custom response when blockResponse is OVERRIDE.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 604800)]
        public int? BlockOverrideTtl { get; set; }

        /// <summary>
        /// Checks to see if the BlockOverrideTtl property is set.
        /// </summary>
        internal bool IsSetBlockOverrideTtl() => this.BlockOverrideTtl.HasValue;

        /// <summary>
        /// Gets and sets the property BlockResponse. 
        /// <para>
        /// The response to return when the action is BLOCK.
        /// </para>
        /// </summary>
        public FirewallBlockResponse BlockResponse { get; set; }

        /// <summary>
        /// Checks to see if the BlockResponse property is set.
        /// </summary>
        internal bool IsSetBlockResponse() => this.BlockResponse != null;

        /// <summary>
        /// Gets and sets the property ConfidenceThreshold. 
        /// <para>
        /// The confidence threshold for advanced threat detection.
        /// </para>
        /// </summary>
        public ConfidenceThreshold ConfidenceThreshold { get; set; }

        /// <summary>
        /// Checks to see if the ConfidenceThreshold property is set.
        /// </summary>
        internal bool IsSetConfidenceThreshold() => this.ConfidenceThreshold != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the firewall rule was created.
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
        /// The description of the firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DnsAdvancedProtection. 
        /// <para>
        /// Whether advanced DNS threat protection is enabled for this rule.
        /// </para>
        /// </summary>
        public DnsAdvancedProtection DnsAdvancedProtection { get; set; }

        /// <summary>
        /// Checks to see if the DnsAdvancedProtection property is set.
        /// </summary>
        internal bool IsSetDnsAdvancedProtection() => this.DnsAdvancedProtection != null;

        /// <summary>
        /// Gets and sets the property DnsViewId. 
        /// <para>
        /// The ID of the DNS view associated with this firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DnsViewId { get; set; }

        /// <summary>
        /// Checks to see if the DnsViewId property is set.
        /// </summary>
        internal bool IsSetDnsViewId() => this.DnsViewId != null;

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the firewall domain list used in this rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FirewallDomainListId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallDomainListId property is set.
        /// </summary>
        internal bool IsSetFirewallDomainListId() => this.FirewallDomainListId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the firewall rule.
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
        /// The name of the firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10000)]
        public long? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property QueryType. 
        /// <para>
        /// The DNS query type that this rule matches.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public string QueryType { get; set; }

        /// <summary>
        /// Checks to see if the QueryType property is set.
        /// </summary>
        internal bool IsSetQueryType() => this.QueryType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The operational status of the firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CRResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the firewall rule was last updated.
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
