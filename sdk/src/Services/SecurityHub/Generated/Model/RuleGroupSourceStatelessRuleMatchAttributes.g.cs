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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Criteria for the stateless rule.
    /// </summary>
    public partial class RuleGroupSourceStatelessRuleMatchAttributes
    {
        /// <summary>
        /// Gets and sets the property DestinationPorts. 
        /// <para>
        /// A list of port ranges to specify the destination ports to inspect for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleGroupSourceStatelessRuleMatchAttributesDestinationPorts> DestinationPorts { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleGroupSourceStatelessRuleMatchAttributesDestinationPorts>() : null;

        /// <summary>
        /// Checks to see if the DestinationPorts property is set.
        /// </summary>
        internal bool IsSetDestinationPorts() => this.DestinationPorts != null && (this.DestinationPorts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// The destination IP addresses and address ranges to inspect for, in CIDR notation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleGroupSourceStatelessRuleMatchAttributesDestinations> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleGroupSourceStatelessRuleMatchAttributesDestinations>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols to inspect for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Protocols { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Protocols property is set.
        /// </summary>
        internal bool IsSetProtocols() => this.Protocols != null && (this.Protocols.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourcePorts. 
        /// <para>
        /// A list of port ranges to specify the source ports to inspect for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleGroupSourceStatelessRuleMatchAttributesSourcePorts> SourcePorts { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleGroupSourceStatelessRuleMatchAttributesSourcePorts>() : null;

        /// <summary>
        /// Checks to see if the SourcePorts property is set.
        /// </summary>
        internal bool IsSetSourcePorts() => this.SourcePorts != null && (this.SourcePorts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The source IP addresses and address ranges to inspect for, in CIDR notation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleGroupSourceStatelessRuleMatchAttributesSources> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleGroupSourceStatelessRuleMatchAttributesSources>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TcpFlags. 
        /// <para>
        /// The TCP flags and masks to inspect for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleGroupSourceStatelessRuleMatchAttributesTcpFlags> TcpFlags { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleGroupSourceStatelessRuleMatchAttributesTcpFlags>() : null;

        /// <summary>
        /// Checks to see if the TcpFlags property is set.
        /// </summary>
        internal bool IsSetTcpFlags() => this.TcpFlags != null && (this.TcpFlags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
