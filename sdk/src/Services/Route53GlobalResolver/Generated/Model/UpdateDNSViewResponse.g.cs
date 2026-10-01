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
    /// This is the response object from the UpdateDNSView operation.
    /// </summary>
    public partial class UpdateDNSViewResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the updated DNS view.
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
        /// The unique string that identifies the request and ensures idempotency.
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
        /// The date and time when the DNS view was originally created.
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
        /// The description of the updated DNS view.
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
        /// Whether DNSSEC validation is enabled for the updated DNS view.
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
        /// Whether EDNS Client Subnet injection is enabled for the updated DNS view.
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
        /// Whether firewall rules fail open when they cannot be evaluated for the updated DNS
        /// view.
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
        /// The ID of the global resolver associated with the updated DNS view.
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
        /// The unique identifier of the updated DNS view.
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
        /// The name of the updated DNS view.
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
        /// The current status of the updated DNS view.
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
        /// The date and time when the DNS view was last updated.
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
