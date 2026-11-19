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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Container for the parameters to the ListUpdates operation. Lists the updates on a
    /// gateway. Results are paginated. Use <c>nextToken</c> to get the next page.
    /// </summary>
    public partial class ListUpdatesRequest : AmazonRTBFabricRequest
    {
        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 32)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property LinkId. 
        /// <para>
        /// The ID of a link on this gateway, to list only that link's updates. Omit both <c>linkId</c>
        /// and <c>ruleId</c> to list the gateway's own updates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 30)]
        public string LinkId { get; set; }

        /// <summary>
        /// Checks to see if the LinkId property is set.
        /// </summary>
        internal bool IsSetLinkId() => this.LinkId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If nextToken is returned, there are more results available. Make the call again using
        /// the returned token to retrieve the next page. Keep all other arguments unchanged.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The ID of a routing rule, to list only that rule's updates. Requires <c>linkId</c>,
        /// because you address a rule through its link. A <c>ruleId</c> without <c>linkId</c>
        /// fails with ValidationException.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 30)]
        public string RuleId { get; set; }

        /// <summary>
        /// Checks to see if the RuleId property is set.
        /// </summary>
        internal bool IsSetRuleId() => this.RuleId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Lists only updates in this status.
        /// </para>
        /// </summary>
        public UpdateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Lists only updates of this type.
        /// </para>
        /// </summary>
        public UpdateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
