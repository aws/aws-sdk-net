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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Details of the AWS Firewall Manager policy.
    /// </summary>
    public partial class PolicySummary
    {
        private string _policyArn;
        private string _policyId;
        private string _policyName;
        private bool? _remediationEnabled;
        private string _resourceType;
        private SecurityServiceType _securityServiceType;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the specified policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the specified policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the specified policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property RemediationEnabled. 
        /// <para>
        /// Indicates if the policy should be automatically applied to new resources.
        /// </para>
        /// </summary>
        public bool RemediationEnabled
        {
            get { return this._remediationEnabled.GetValueOrDefault(); }
            set { this._remediationEnabled = value; }
        }

        // Check to see if RemediationEnabled property is set
        internal bool IsSetRemediationEnabled()
        {
            return this._remediationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource protected by or in scope of the policy. This is in the format
        /// shown in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">AWS
        /// Resource Types Reference</a>. For AWS WAF and Shield Advanced, examples include <code>AWS::ElasticLoadBalancingV2::LoadBalancer</code>
        /// and <code>AWS::CloudFront::Distribution</code>. For a security group common policy,
        /// valid values are <code>AWS::EC2::NetworkInterface</code> and <code>AWS::EC2::Instance</code>.
        /// For a security group content audit policy, valid values are <code>AWS::EC2::SecurityGroup</code>,
        /// <code>AWS::EC2::NetworkInterface</code>, and <code>AWS::EC2::Instance</code>. For
        /// a security group usage audit policy, the value is <code>AWS::EC2::SecurityGroup</code>.
        /// For an AWS Network Firewall policy, the value is <code>AWS::EC2::VPC</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityServiceType. 
        /// <para>
        /// The service that the policy is using to protect the resources. This specifies the
        /// type of policy that is created, either an AWS WAF policy, a Shield Advanced policy,
        /// or a security group policy.
        /// </para>
        /// </summary>
        public SecurityServiceType SecurityServiceType
        {
            get { return this._securityServiceType; }
            set { this._securityServiceType = value; }
        }

        // Check to see if SecurityServiceType property is set
        internal bool IsSetSecurityServiceType()
        {
            return this._securityServiceType != null;
        }

    }
}