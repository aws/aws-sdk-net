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
    /// Container for the parameters to the ListAttachmentNatConfigurations operation. Returns
    /// the NAT configurations of core network attachments. You must specify either a core
    /// network ID or an attachment ID. Only the core network owner can list NAT configurations.
    /// </summary>
    public partial class ListAttachmentNatConfigurationsRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of an attachment. Returns the NAT configuration of the specified attachment.
        /// If you specify both an attachment ID and a core network ID, the attachment ID is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network. Returns the NAT configurations of attachments in the core
        /// network that support NAT.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string CoreNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkId property is set.
        /// </summary>
        internal bool IsSetCoreNetworkId() => this.CoreNetworkId != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters to apply to the results. Values for the same filter are joined with OR,
        /// and different filters are joined with AND. You can specify up to 10 filter values
        /// in total. The following filters are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>nat-gateway-support</c>: The state of NAT gateway support on the attachment, for
        /// example <c>ENABLED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nat-system-route-support</c>: Whether system routes are installed for the attachment,
        /// <c>true</c> or <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rule-number</c>: The rule number of a NAT rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>match-source-cidr</c>: The source CIDR block of a NAT rule. The value must exactly
        /// match the CIDR block of the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nat-cidr</c>: The NAT CIDR block of a NAT rule. The value must exactly match the
        /// CIDR block of the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nat-rule-state</c>: The state of a NAT rule, for example <c>ACTIVATED</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Filters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
