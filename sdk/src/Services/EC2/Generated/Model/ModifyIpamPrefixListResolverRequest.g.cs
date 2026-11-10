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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyIpamPrefixListResolver operation. Modifies
    /// an IPAM prefix list resolver. You can update the description and CIDR selection rules.
    /// Changes to rules will trigger re-evaluation and potential updates to associated prefix
    /// lists.
    /// </summary>
    public partial class ModifyIpamPrefixListResolverRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the IPAM prefix list resolver.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamPrefixListResolverId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPrefixListResolverId property is set.
        /// </summary>
        internal bool IsSetIpamPrefixListResolverId() => this.IpamPrefixListResolverId != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The updated CIDR selection rules for the resolver. These rules replace the existing
        /// rules entirely.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamPrefixListResolverRuleRequest> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<IpamPrefixListResolverRuleRequest>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
