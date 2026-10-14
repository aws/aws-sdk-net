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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// An Firewall Manager policy.
    /// </summary>
    public partial class Policy
    {
        /// <summary>
        /// Gets and sets the property DeleteUnusedFMManagedResources. 
        /// <para>
        /// Indicates whether Firewall Manager should automatically remove protections from resources
        /// that leave the policy scope and clean up resources that Firewall Manager is managing
        /// for accounts when those accounts leave policy scope. For example, Firewall Manager
        /// will disassociate a Firewall Manager managed web ACL from a protected customer resource
        /// when the customer resource leaves policy scope. 
        /// </para>
        ///  
        /// <para>
        /// By default, Firewall Manager doesn't remove protections or delete Firewall Manager
        /// managed resources. 
        /// </para>
        ///  
        /// <para>
        /// This option is not available for Shield Advanced or WAF Classic policies.
        /// </para>
        /// </summary>
        public bool? DeleteUnusedFMManagedResources { get; set; }

        /// <summary>
        /// Checks to see if the DeleteUnusedFMManagedResources property is set.
        /// </summary>
        internal bool IsSetDeleteUnusedFMManagedResources() => this.DeleteUnusedFMManagedResources.HasValue;

        /// <summary>
        /// Gets and sets the property ExcludeMap. 
        /// <para>
        /// Specifies the Amazon Web Services account IDs and Organizations organizational units
        /// (OUs) to exclude from the policy. Specifying an OU is the equivalent of specifying
        /// all accounts in the OU and in any of its child OUs, including any child OUs and accounts
        /// that are added at a later time.
        /// </para>
        ///  
        /// <para>
        /// You can specify inclusions or exclusions, but not both. If you specify an <c>IncludeMap</c>,
        /// Firewall Manager applies the policy to all accounts specified by the <c>IncludeMap</c>,
        /// and does not evaluate any <c>ExcludeMap</c> specifications. If you do not specify
        /// an <c>IncludeMap</c>, then Firewall Manager applies the policy to all accounts except
        /// for those specified by the <c>ExcludeMap</c>.
        /// </para>
        ///  
        /// <para>
        /// You can specify account IDs, OUs, or a combination: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify account IDs by setting the key to <c>ACCOUNT</c>. For example, the following
        /// is a valid map: <c>{“ACCOUNT” : [“accountID1”, “accountID2”]}</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify OUs by setting the key to <c>ORG_UNIT</c>. For example, the following is a
        /// valid map: <c>{“ORG_UNIT” : [“ouid111”, “ouid112”]}</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify accounts and OUs together in a single map, separated with a comma. For example,
        /// the following is a valid map: <c>{“ACCOUNT” : [“accountID1”, “accountID2”], “ORG_UNIT”
        /// : [“ouid111”, “ouid112”]}</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> ExcludeMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the ExcludeMap property is set.
        /// </summary>
        internal bool IsSetExcludeMap() => this.ExcludeMap != null && (this.ExcludeMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExcludeResourceTags. 
        /// <para>
        /// If set to <c>True</c>, resources with the tags that are specified in the <c>ResourceTag</c>
        /// array are not in scope of the policy. If set to <c>False</c>, and the <c>ResourceTag</c>
        /// array is not null, only resources with the specified tags are in scope of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ExcludeResourceTags { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeResourceTags property is set.
        /// </summary>
        internal bool IsSetExcludeResourceTags() => this.ExcludeResourceTags.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeMap. 
        /// <para>
        /// Specifies the Amazon Web Services account IDs and Organizations organizational units
        /// (OUs) to include in the policy. Specifying an OU is the equivalent of specifying all
        /// accounts in the OU and in any of its child OUs, including any child OUs and accounts
        /// that are added at a later time.
        /// </para>
        ///  
        /// <para>
        /// You can specify inclusions or exclusions, but not both. If you specify an <c>IncludeMap</c>,
        /// Firewall Manager applies the policy to all accounts specified by the <c>IncludeMap</c>,
        /// and does not evaluate any <c>ExcludeMap</c> specifications. If you do not specify
        /// an <c>IncludeMap</c>, then Firewall Manager applies the policy to all accounts except
        /// for those specified by the <c>ExcludeMap</c>.
        /// </para>
        ///  
        /// <para>
        /// You can specify account IDs, OUs, or a combination: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify account IDs by setting the key to <c>ACCOUNT</c>. For example, the following
        /// is a valid map: <c>{“ACCOUNT” : [“accountID1”, “accountID2”]}</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify OUs by setting the key to <c>ORG_UNIT</c>. For example, the following is a
        /// valid map: <c>{“ORG_UNIT” : [“ouid111”, “ouid112”]}</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify accounts and OUs together in a single map, separated with a comma. For example,
        /// the following is a valid map: <c>{“ACCOUNT” : [“accountID1”, “accountID2”], “ORG_UNIT”
        /// : [“ouid111”, “ouid112”]}</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> IncludeMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the IncludeMap property is set.
        /// </summary>
        internal bool IsSetIncludeMap() => this.IncludeMap != null && (this.IncludeMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyDescription. 
        /// <para>
        /// Your description of the Firewall Manager policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDescription property is set.
        /// </summary>
        internal bool IsSetPolicyDescription() => this.PolicyDescription != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the Firewall Manager policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the Firewall Manager policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property PolicyStatus. 
        /// <para>
        /// Indicates whether the policy is in or out of an admin's policy or Region scope.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The administrator can manage and delete the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUT_OF_ADMIN_SCOPE</c> - The administrator can view the policy, but they can't
        /// edit or delete the policy. Existing policy protections stay in place. Any new resources
        /// that come into scope of the policy won't be protected.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CustomerPolicyStatus PolicyStatus { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStatus property is set.
        /// </summary>
        internal bool IsSetPolicyStatus() => this.PolicyStatus != null;

        /// <summary>
        /// Gets and sets the property PolicyUpdateToken. 
        /// <para>
        /// A unique identifier for each update to the policy. When issuing a <c>PutPolicy</c>
        /// request, the <c>PolicyUpdateToken</c> in the request must match the <c>PolicyUpdateToken</c>
        /// of the current policy version. To get the <c>PolicyUpdateToken</c> of the current
        /// policy version, use a <c>GetPolicy</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PolicyUpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the PolicyUpdateToken property is set.
        /// </summary>
        internal bool IsSetPolicyUpdateToken() => this.PolicyUpdateToken != null;

        /// <summary>
        /// Gets and sets the property RemediationEnabled. 
        /// <para>
        /// Indicates if the policy should be automatically applied to new resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? RemediationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the RemediationEnabled property is set.
        /// </summary>
        internal bool IsSetRemediationEnabled() => this.RemediationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceSetIds. 
        /// <para>
        /// The unique identifiers of the resource sets used by the policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceSetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceSetIds property is set.
        /// </summary>
        internal bool IsSetResourceSetIds() => this.ResourceSetIds != null && (this.ResourceSetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTagLogicalOperator. 
        /// <para>
        /// Specifies whether to combine multiple resource tags with AND, so that a resource must
        /// have all tags to be included or excluded, or OR, so that a resource must have at least
        /// one tag.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>AND</c> 
        /// </para>
        /// </summary>
        public ResourceTagLogicalOperator ResourceTagLogicalOperator { get; set; }

        /// <summary>
        /// Checks to see if the ResourceTagLogicalOperator property is set.
        /// </summary>
        internal bool IsSetResourceTagLogicalOperator() => this.ResourceTagLogicalOperator != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// An array of <c>ResourceTag</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource protected by or in scope of the policy. This is in the format
        /// shown in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services Resource Types Reference</a>. To apply this policy to multiple resource
        /// types, specify a resource type of <c>ResourceTypeList</c> and then specify the resource
        /// types in a <c>ResourceTypeList</c>.
        /// </para>
        ///  
        /// <para>
        /// The following are valid resource types for each Firewall Manager policy type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services WAF Classic - <c>AWS::ApiGateway::Stage</c>, <c>AWS::CloudFront::Distribution</c>,
        /// and <c>AWS::ElasticLoadBalancingV2::LoadBalancer</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAF - <c>AWS::ApiGateway::Stage</c>, <c>AWS::ElasticLoadBalancingV2::LoadBalancer</c>,
        /// and <c>AWS::CloudFront::Distribution</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Shield Advanced - <c>AWS::ElasticLoadBalancingV2::LoadBalancer</c>, <c>AWS::ElasticLoadBalancing::LoadBalancer</c>,
        /// <c>AWS::EC2::EIP</c>, and <c>AWS::CloudFront::Distribution</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Network ACL - <c>AWS::EC2::Subnet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Security group usage audit - <c>AWS::EC2::SecurityGroup</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Security group content audit - <c>AWS::EC2::SecurityGroup</c>, <c>AWS::EC2::NetworkInterface</c>,
        /// and <c>AWS::EC2::Instance</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DNS Firewall, Network Firewall, and third-party firewall - <c>AWS::EC2::VPC</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ResourceTypeList. 
        /// <para>
        /// An array of <c>ResourceType</c> objects. Use this only to specify multiple resource
        /// types. To specify a single resource type, use <c>ResourceType</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypeList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypeList property is set.
        /// </summary>
        internal bool IsSetResourceTypeList() => this.ResourceTypeList != null && (this.ResourceTypeList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityServicePolicyData. 
        /// <para>
        /// Details about the security service that is being used to protect the resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SecurityServicePolicyData SecurityServicePolicyData { get; set; }

        /// <summary>
        /// Checks to see if the SecurityServicePolicyData property is set.
        /// </summary>
        internal bool IsSetSecurityServicePolicyData() => this.SecurityServicePolicyData != null;
    }
}
