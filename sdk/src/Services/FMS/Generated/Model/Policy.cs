/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// An AWS Firewall Manager policy.
    /// </summary>
    public partial class Policy
    {
        private Dictionary<string, List<string>> _excludeMap = new Dictionary<string, List<string>>();
        private bool? _excludeResourceTags;
        private Dictionary<string, List<string>> _includeMap = new Dictionary<string, List<string>>();
        private string _policyId;
        private string _policyName;
        private string _policyUpdateToken;
        private bool? _remediationEnabled;
        private List<ResourceTag> _resourceTags = new List<ResourceTag>();
        private string _resourceType;
        private SecurityServicePolicyData _securityServicePolicyData;

        /// <summary>
        /// Gets and sets the property ExcludeMap. 
        /// <para>
        /// Specifies the AWS account IDs to exclude from the policy. The <code>IncludeMap</code>
        /// values are evaluated first, with all of the appropriate account IDs added to the policy.
        /// Then the accounts listed in <code>ExcludeMap</code> are removed, resulting in the
        /// final list of accounts to add to the policy.
        /// </para>
        ///  
        /// <para>
        /// The key to the map is <code>ACCOUNT</code>. For example, a valid <code>ExcludeMap</code>
        /// would be <code>{“ACCOUNT” : [“accountID1”, “accountID2”]}</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> ExcludeMap
        {
            get { return this._excludeMap; }
            set { this._excludeMap = value; }
        }

        // Check to see if ExcludeMap property is set
        internal bool IsSetExcludeMap()
        {
            return this._excludeMap != null && this._excludeMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeResourceTags. 
        /// <para>
        /// If set to <code>True</code>, resources with the tags that are specified in the <code>ResourceTag</code>
        /// array are not protected by the policy. If set to <code>False</code>, and the <code>ResourceTag</code>
        /// array is not null, only resources with the specified tags are associated with the
        /// policy.
        /// </para>
        /// </summary>
        public bool ExcludeResourceTags
        {
            get { return this._excludeResourceTags.GetValueOrDefault(); }
            set { this._excludeResourceTags = value; }
        }

        // Check to see if ExcludeResourceTags property is set
        internal bool IsSetExcludeResourceTags()
        {
            return this._excludeResourceTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeMap. 
        /// <para>
        /// Specifies the AWS account IDs to include in the policy. If <code>IncludeMap</code>
        /// is null, all accounts in the AWS Organization are included in the policy. If <code>IncludeMap</code>
        /// is not null, only values listed in <code>IncludeMap</code> will be included in the
        /// policy.
        /// </para>
        ///  
        /// <para>
        /// The key to the map is <code>ACCOUNT</code>. For example, a valid <code>IncludeMap</code>
        /// would be <code>{“ACCOUNT” : [“accountID1”, “accountID2”]}</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> IncludeMap
        {
            get { return this._includeMap; }
            set { this._includeMap = value; }
        }

        // Check to see if IncludeMap property is set
        internal bool IsSetIncludeMap()
        {
            return this._includeMap != null && this._includeMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the AWS Firewall Manager policy.
        /// </para>
        /// </summary>
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
        /// The friendly name of the AWS Firewall Manager policy.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PolicyUpdateToken. 
        /// <para>
        /// A unique identifier for each update to the policy. When issuing a <code>PutPolicy</code>
        /// request, the <code>PolicyUpdateToken</code> in the request must match the <code>PolicyUpdateToken</code>
        /// of the current policy version. To get the <code>PolicyUpdateToken</code> of the current
        /// policy version, use a <code>GetPolicy</code> request.
        /// </para>
        /// </summary>
        public string PolicyUpdateToken
        {
            get { return this._policyUpdateToken; }
            set { this._policyUpdateToken = value; }
        }

        // Check to see if PolicyUpdateToken property is set
        internal bool IsSetPolicyUpdateToken()
        {
            return this._policyUpdateToken != null;
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
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// An array of <code>ResourceTag</code> objects.
        /// </para>
        /// </summary>
        public List<ResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && this._resourceTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to protect with the policy, either an Application Load Balancer
        /// or a CloudFront distribution. This is in the format shown in <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">AWS
        /// Resource Types Reference</a>. Valid values are <code>AWS::ElasticLoadBalancingV2::LoadBalancer</code>
        /// or <code>AWS::CloudFront::Distribution</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SecurityServicePolicyData. 
        /// <para>
        /// Details about the security service that is being used to protect the resources.
        /// </para>
        /// </summary>
        public SecurityServicePolicyData SecurityServicePolicyData
        {
            get { return this._securityServicePolicyData; }
            set { this._securityServicePolicyData = value; }
        }

        // Check to see if SecurityServicePolicyData property is set
        internal bool IsSetSecurityServicePolicyData()
        {
            return this._securityServicePolicyData != null;
        }

    }
}