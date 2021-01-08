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
        private List<string> _resourceTypeList = new List<string>();
        private SecurityServicePolicyData _securityServicePolicyData;

        /// <summary>
        /// Gets and sets the property ExcludeMap. 
        /// <para>
        /// Specifies the AWS account IDs and AWS Organizations organizational units (OUs) to
        /// exclude from the policy. Specifying an OU is the equivalent of specifying all accounts
        /// in the OU and in any of its child OUs, including any child OUs and accounts that are
        /// added at a later time.
        /// </para>
        ///  
        /// <para>
        /// You can specify inclusions or exclusions, but not both. If you specify an <code>IncludeMap</code>,
        /// AWS Firewall Manager applies the policy to all accounts specified by the <code>IncludeMap</code>,
        /// and does not evaluate any <code>ExcludeMap</code> specifications. If you do not specify
        /// an <code>IncludeMap</code>, then Firewall Manager applies the policy to all accounts
        /// except for those specified by the <code>ExcludeMap</code>.
        /// </para>
        ///  
        /// <para>
        /// You can specify account IDs, OUs, or a combination: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify account IDs by setting the key to <code>ACCOUNT</code>. For example, the following
        /// is a valid map: <code>{“ACCOUNT” : [“accountID1”, “accountID2”]}</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify OUs by setting the key to <code>ORG_UNIT</code>. For example, the following
        /// is a valid map: <code>{“ORG_UNIT” : [“ouid111”, “ouid112”]}</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify accounts and OUs together in a single map, separated with a comma. For example,
        /// the following is a valid map: <code>{“ACCOUNT” : [“accountID1”, “accountID2”], “ORG_UNIT”
        /// : [“ouid111”, “ouid112”]}</code>.
        /// </para>
        ///  </li> </ul>
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
        /// array are not in scope of the policy. If set to <code>False</code>, and the <code>ResourceTag</code>
        /// array is not null, only resources with the specified tags are in scope of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Specifies the AWS account IDs and AWS Organizations organizational units (OUs) to
        /// include in the policy. Specifying an OU is the equivalent of specifying all accounts
        /// in the OU and in any of its child OUs, including any child OUs and accounts that are
        /// added at a later time.
        /// </para>
        ///  
        /// <para>
        /// You can specify inclusions or exclusions, but not both. If you specify an <code>IncludeMap</code>,
        /// AWS Firewall Manager applies the policy to all accounts specified by the <code>IncludeMap</code>,
        /// and does not evaluate any <code>ExcludeMap</code> specifications. If you do not specify
        /// an <code>IncludeMap</code>, then Firewall Manager applies the policy to all accounts
        /// except for those specified by the <code>ExcludeMap</code>.
        /// </para>
        ///  
        /// <para>
        /// You can specify account IDs, OUs, or a combination: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify account IDs by setting the key to <code>ACCOUNT</code>. For example, the following
        /// is a valid map: <code>{“ACCOUNT” : [“accountID1”, “accountID2”]}</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify OUs by setting the key to <code>ORG_UNIT</code>. For example, the following
        /// is a valid map: <code>{“ORG_UNIT” : [“ouid111”, “ouid112”]}</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify accounts and OUs together in a single map, separated with a comma. For example,
        /// the following is a valid map: <code>{“ACCOUNT” : [“accountID1”, “accountID2”], “ORG_UNIT”
        /// : [“ouid111”, “ouid112”]}</code>.
        /// </para>
        ///  </li> </ul>
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
        /// The name of the AWS Firewall Manager policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        [AWSProperty(Min=1, Max=1024)]
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Min=0, Max=8)]
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
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ResourceTypeList. 
        /// <para>
        /// An array of <code>ResourceType</code>.
        /// </para>
        /// </summary>
        public List<string> ResourceTypeList
        {
            get { return this._resourceTypeList; }
            set { this._resourceTypeList = value; }
        }

        // Check to see if ResourceTypeList property is set
        internal bool IsSetResourceTypeList()
        {
            return this._resourceTypeList != null && this._resourceTypeList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityServicePolicyData. 
        /// <para>
        /// Details about the security service that is being used to protect the resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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