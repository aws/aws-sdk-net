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
    /// Describes an additional detail for a path analysis. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/reachability/additional-detail-codes.html">Reachability
    /// Analyzer additional detail codes</a>.
    /// </summary>
    public partial class AdditionalDetail
    {
        /// <summary>
        /// Gets and sets the property AdditionalDetailType. 
        /// <para>
        /// The additional detail code.
        /// </para>
        /// </summary>
        public string AdditionalDetailType { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalDetailType property is set.
        /// </summary>
        internal bool IsSetAdditionalDetailType() => this.AdditionalDetailType != null;

        /// <summary>
        /// Gets and sets the property Component. 
        /// <para>
        /// The path component.
        /// </para>
        /// </summary>
        public AnalysisComponent Component { get; set; }

        /// <summary>
        /// Checks to see if the Component property is set.
        /// </summary>
        internal bool IsSetComponent() => this.Component != null;

        /// <summary>
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// The load balancers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalysisComponent> LoadBalancers { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalysisComponent>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancers property is set.
        /// </summary>
        internal bool IsSetLoadBalancers() => this.LoadBalancers != null && (this.LoadBalancers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleGroupRuleOptionsPairs. 
        /// <para>
        /// The rule options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleGroupRuleOptionsPair> RuleGroupRuleOptionsPairs { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleGroupRuleOptionsPair>() : null;

        /// <summary>
        /// Checks to see if the RuleGroupRuleOptionsPairs property is set.
        /// </summary>
        internal bool IsSetRuleGroupRuleOptionsPairs() => this.RuleGroupRuleOptionsPairs != null && (this.RuleGroupRuleOptionsPairs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleGroupTypePairs. 
        /// <para>
        /// The rule group type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleGroupTypePair> RuleGroupTypePairs { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleGroupTypePair>() : null;

        /// <summary>
        /// Checks to see if the RuleGroupTypePairs property is set.
        /// </summary>
        internal bool IsSetRuleGroupTypePairs() => this.RuleGroupTypePairs != null && (this.RuleGroupTypePairs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleOptions. 
        /// <para>
        /// The rule options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleOption> RuleOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleOption>() : null;

        /// <summary>
        /// Checks to see if the RuleOptions property is set.
        /// </summary>
        internal bool IsSetRuleOptions() => this.RuleOptions != null && (this.RuleOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the VPC endpoint service.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointService. 
        /// <para>
        /// The VPC endpoint service.
        /// </para>
        /// </summary>
        public AnalysisComponent VpcEndpointService { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointService property is set.
        /// </summary>
        internal bool IsSetVpcEndpointService() => this.VpcEndpointService != null;
    }
}
