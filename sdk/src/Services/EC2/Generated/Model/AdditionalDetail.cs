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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an additional detail for a path analysis. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/reachability/additional-detail-codes.html">Reachability
    /// Analyzer additional detail codes</a>.
    /// </summary>
    public partial class AdditionalDetail
    {
        private string _additionalDetailType;
        private AnalysisComponent _component;
        private List<AnalysisComponent> _loadBalancers = new List<AnalysisComponent>();
        private List<RuleGroupRuleOptionsPair> _ruleGroupRuleOptionsPairs = new List<RuleGroupRuleOptionsPair>();
        private List<RuleGroupTypePair> _ruleGroupTypePairs = new List<RuleGroupTypePair>();
        private List<RuleOption> _ruleOptions = new List<RuleOption>();
        private string _serviceName;
        private AnalysisComponent _vpcEndpointService;

        /// <summary>
        /// Gets and sets the property AdditionalDetailType. 
        /// <para>
        /// The additional detail code.
        /// </para>
        /// </summary>
        public string AdditionalDetailType
        {
            get { return this._additionalDetailType; }
            set { this._additionalDetailType = value; }
        }

        // Check to see if AdditionalDetailType property is set
        internal bool IsSetAdditionalDetailType()
        {
            return this._additionalDetailType != null;
        }

        /// <summary>
        /// Gets and sets the property Component. 
        /// <para>
        /// The path component.
        /// </para>
        /// </summary>
        public AnalysisComponent Component
        {
            get { return this._component; }
            set { this._component = value; }
        }

        // Check to see if Component property is set
        internal bool IsSetComponent()
        {
            return this._component != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// The load balancers.
        /// </para>
        /// </summary>
        public List<AnalysisComponent> LoadBalancers
        {
            get { return this._loadBalancers; }
            set { this._loadBalancers = value; }
        }

        // Check to see if LoadBalancers property is set
        internal bool IsSetLoadBalancers()
        {
            return this._loadBalancers != null && this._loadBalancers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleGroupRuleOptionsPairs. 
        /// <para>
        /// The rule options.
        /// </para>
        /// </summary>
        public List<RuleGroupRuleOptionsPair> RuleGroupRuleOptionsPairs
        {
            get { return this._ruleGroupRuleOptionsPairs; }
            set { this._ruleGroupRuleOptionsPairs = value; }
        }

        // Check to see if RuleGroupRuleOptionsPairs property is set
        internal bool IsSetRuleGroupRuleOptionsPairs()
        {
            return this._ruleGroupRuleOptionsPairs != null && this._ruleGroupRuleOptionsPairs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleGroupTypePairs. 
        /// <para>
        /// The rule group type.
        /// </para>
        /// </summary>
        public List<RuleGroupTypePair> RuleGroupTypePairs
        {
            get { return this._ruleGroupTypePairs; }
            set { this._ruleGroupTypePairs = value; }
        }

        // Check to see if RuleGroupTypePairs property is set
        internal bool IsSetRuleGroupTypePairs()
        {
            return this._ruleGroupTypePairs != null && this._ruleGroupTypePairs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleOptions. 
        /// <para>
        /// The rule options.
        /// </para>
        /// </summary>
        public List<RuleOption> RuleOptions
        {
            get { return this._ruleOptions; }
            set { this._ruleOptions = value; }
        }

        // Check to see if RuleOptions property is set
        internal bool IsSetRuleOptions()
        {
            return this._ruleOptions != null && this._ruleOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the VPC endpoint service.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointService. 
        /// <para>
        /// The VPC endpoint service.
        /// </para>
        /// </summary>
        public AnalysisComponent VpcEndpointService
        {
            get { return this._vpcEndpointService; }
            set { this._vpcEndpointService = value; }
        }

        // Check to see if VpcEndpointService property is set
        internal bool IsSetVpcEndpointService()
        {
            return this._vpcEndpointService != null;
        }

    }
}