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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Details about the security service that is being used to protect the resources.
    /// </summary>
    public partial class SecurityServicePolicyData
    {
        private string _managedServiceData;
        private PolicyOption _policyOption;
        private SecurityServiceType _type;

        /// <summary>
        /// Gets and sets the property ManagedServiceData. 
        /// <para>
        /// Details about the service that are specific to the service type, in JSON format. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Example: <c>DNS_FIREWALL</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"DNS_FIREWALL\",\"preProcessRuleGroups\":[{\"ruleGroupId\":\"rslvr-frg-1\",\"priority\":10}],\"postProcessRuleGroups\":[{\"ruleGroupId\":\"rslvr-frg-2\",\"priority\":9911}]}"</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid values for <c>preProcessRuleGroups</c> are between 1 and 99. Valid values for
        /// <c>postProcessRuleGroups</c> are between 9901 and 10000.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Example: <c>IMPORT_NETWORK_FIREWALL</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"IMPORT_NETWORK_FIREWALL\",\"awsNetworkFirewallConfig\":{\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-west-2:000000000000:stateless-rulegroup\/rg1\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:drop\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:pass\"],\"networkFirewallStatelessCustomActions\":[],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-west-2:aws-managed:stateful-rulegroup\/ThreatSignaturesEmergingEventsStrictOrder\",\"priority\":8}],\"networkFirewallStatefulEngineOptions\":{\"ruleOrder\":\"STRICT_ORDER\"},\"networkFirewallStatefulDefaultActions\":[\"aws:drop_strict\"]}}"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"DNS_FIREWALL\",\"preProcessRuleGroups\":[{\"ruleGroupId\":\"rslvr-frg-1\",\"priority\":10}],\"postProcessRuleGroups\":[{\"ruleGroupId\":\"rslvr-frg-2\",\"priority\":9911}]}"</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid values for <c>preProcessRuleGroups</c> are between 1 and 99. Valid values for
        /// <c>postProcessRuleGroups</c> are between 9901 and 10000.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Example: <c>NETWORK_FIREWALL</c> - Centralized deployment model
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"NETWORK_FIREWALL\",\"awsNetworkFirewallConfig\":{\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateless-rulegroup/test\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessCustomActions\":[{\"actionName\":\"customActionName\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"metricdimensionvalue\"}]}}}],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateful-rulegroup/test\"}],\"networkFirewallLoggingConfiguration\":{\"logDestinationConfigs\":[{\"logDestinationType\":\"S3\",\"logType\":\"ALERT\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}},{\"logDestinationType\":\"S3\",\"logType\":\"FLOW\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}}],\"overrideExistingConfig\":true}},\"firewallDeploymentModel\":{\"centralizedFirewallDeploymentModel\":{\"centralizedFirewallOrchestrationConfig\":{\"inspectionVpcIds\":[{\"resourceId\":\"vpc-1234\",\"accountId\":\"123456789011\"}],\"firewallCreationConfig\":{\"endpointLocation\":{\"availabilityZoneConfigList\":[{\"availabilityZoneId\":null,\"availabilityZoneName\":\"us-east-1a\",\"allowedIPV4CidrList\":[\"10.0.0.0/28\"]}]}},\"allowedIPV4CidrList\":[]}}}}"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  To use the centralized deployment model, you must set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <c>CENTRALIZED</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>NETWORK_FIREWALL</c> - Distributed deployment model with automatic Availability
        /// Zone configuration
        /// </para>
        ///  
        /// <para>
        ///  <c> "{\"type\":\"NETWORK_FIREWALL\",\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateless-rulegroup/test\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessCustomActions\":[{\"actionName\":\"customActionName\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"metricdimensionvalue\"}]}}}],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateful-rulegroup/test\"}],\"networkFirewallOrchestrationConfig\":{\"singleFirewallEndpointPerVPC\":false,\"allowedIPV4CidrList\":[\"10.0.0.0/28\",\"192.168.0.0/28\"],\"routeManagementAction\":\"OFF\"},\"networkFirewallLoggingConfiguration\":{\"logDestinationConfigs\":[{\"logDestinationType\":\"S3\",\"logType\":\"ALERT\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}},{\"logDestinationType\":\"S3\",\"logType\":\"FLOW\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}}],\"overrideExistingConfig\":true}}"
        /// </c> 
        /// </para>
        ///  
        /// <para>
        ///  With automatic Availbility Zone configuration, Firewall Manager chooses which Availability
        /// Zones to create the endpoints in. To use the distributed deployment model, you must
        /// set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <c>NULL</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>NETWORK_FIREWALL</c> - Distributed deployment model with automatic Availability
        /// Zone configuration and route management
        /// </para>
        ///  
        /// <para>
        ///  <c> "{\"type\":\"NETWORK_FIREWALL\",\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateless-rulegroup/test\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessCustomActions\":[{\"actionName\":\"customActionName\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"metricdimensionvalue\"}]}}}],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateful-rulegroup/test\"}],\"networkFirewallOrchestrationConfig\":{\"singleFirewallEndpointPerVPC\":false,\"allowedIPV4CidrList\":[\"10.0.0.0/28\",\"192.168.0.0/28\"],\"routeManagementAction\":\"MONITOR\",\"routeManagementTargetTypes\":[\"InternetGateway\"]},\"networkFirewallLoggingConfiguration\":{\"logDestinationConfigs\":[{\"logDestinationType\":\"S3\",\"logType\":\"ALERT\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}},{\"logDestinationType\":\"S3\",\"logType\":
        /// \"FLOW\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}}],\"overrideExistingConfig\":true}}"
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// To use the distributed deployment model, you must set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <c>NULL</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>NETWORK_FIREWALL</c> - Distributed deployment model with custom Availability
        /// Zone configuration
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"NETWORK_FIREWALL\",\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateless-rulegroup/test\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:forward_to_sfe\",\"fragmentcustomactionname\"],\"networkFirewallStatelessCustomActions\":[{\"actionName\":\"customActionName\",
        /// \"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"metricdimensionvalue\"}]}}},{\"actionName\":\"fragmentcustomactionname\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"fragmentmetricdimensionvalue\"}]}}}],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateful-rulegroup/test\"}],\"networkFirewallOrchestrationConfig\":{\"firewallCreationConfig\":{
        /// \"endpointLocation\":{\"availabilityZoneConfigList\":[{\"availabilityZoneName\":\"us-east-1a\",\"allowedIPV4CidrList\":[\"10.0.0.0/28\"]},{\"availabilityZoneName\":\"us-east-1b\",\"allowedIPV4CidrList\":[
        /// \"10.0.0.0/28\"]}]} },\"singleFirewallEndpointPerVPC\":false,\"allowedIPV4CidrList\":null,\"routeManagementAction\":\"OFF\",\"networkFirewallLoggingConfiguration\":{\"logDestinationConfigs\":[{\"logDestinationType\":\"S3\",\"logType\":\"ALERT\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}},{\"logDestinationType\":\"S3\",\"logType\":\"FLOW\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}}],\"overrideExistingConfig\":boolean}}"
        /// </c> 
        /// </para>
        ///  
        /// <para>
        ///  With custom Availability Zone configuration, you define which specific Availability
        /// Zones to create endpoints in by configuring <c>firewallCreationConfig</c>. To configure
        /// the Availability Zones in <c>firewallCreationConfig</c>, specify either the <c>availabilityZoneName</c>
        /// or <c>availabilityZoneId</c> parameter, not both parameters. 
        /// </para>
        ///  
        /// <para>
        /// To use the distributed deployment model, you must set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <c>NULL</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>NETWORK_FIREWALL</c> - Distributed deployment model with custom Availability
        /// Zone configuration and route management
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"NETWORK_FIREWALL\",\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateless-rulegroup/test\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:forward_to_sfe\",\"fragmentcustomactionname\"],\"networkFirewallStatelessCustomActions\":[{\"actionName\":\"customActionName\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"metricdimensionvalue\"}]}}},{\"actionName\":\"fragmentcustomactionname\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"fragmentmetricdimensionvalue\"}]}}}],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateful-rulegroup/test\"}],\"networkFirewallOrchestrationConfig\":{\"firewallCreationConfig\":{\"endpointLocation\":{\"availabilityZoneConfigList\":[{\"availabilityZoneName\":\"us-east-1a\",\"allowedIPV4CidrList\":[\"10.0.0.0/28\"]},{\"availabilityZoneName\":\"us-east-1b\",\"allowedIPV4CidrList\":[\"10.0.0.0/28\"]}]}},\"singleFirewallEndpointPerVPC\":false,\"allowedIPV4CidrList\":null,\"routeManagementAction\":\"MONITOR\",\"routeManagementTargetTypes\":[\"InternetGateway\"],\"routeManagementConfig\":{\"allowCrossAZTrafficIfNoEndpoint\":true}},\"networkFirewallLoggingConfiguration\":{\"logDestinationConfigs\":[{\"logDestinationType\":\"S3\",\"logType\":\"ALERT\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}},{\"logDestinationType\":\"S3\",\"logType\":\"FLOW\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}}],\"overrideExistingConfig\":boolean}}"
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// To use the distributed deployment model, you must set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <c>NULL</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>SECURITY_GROUPS_COMMON</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"SECURITY_GROUPS_COMMON\",\"securityGroups\":[{\"id\":\"sg-03b1f67d69ed00197\"}],\"revertManualSecurityGroupChanges\":true,\"exclusiveResourceSecurityGroupManagement\":true,\"applyToAllEC2InstanceENIs\":false,\"includeSharedVPC\":true,\"enableSecurityGroupReferencesDistribution\":true}"</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>SECURITY_GROUPS_COMMON</c> - Security group tag distribution 
        /// </para>
        ///  
        /// <para>
        ///  <c>""{\"type\":\"SECURITY_GROUPS_COMMON\",\"securityGroups\":[{\"id\":\"sg-000e55995d61a06bd\"}],\"revertManualSecurityGroupChanges\":true,\"exclusiveResourceSecurityGroupManagement\":false,\"applyToAllEC2InstanceENIs\":false,\"includeSharedVPC\":false,\"enableTagDistribution\":true}""</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Firewall Manager automatically distributes tags from the primary group to the security
        /// groups created by this policy. To use security group tag distribution, you must also
        /// set <c>revertManualSecurityGroupChanges</c> to <c>true</c>, otherwise Firewall Manager
        /// won't be able to create the policy. When you enable <c>revertManualSecurityGroupChanges</c>,
        /// Firewall Manager identifies and reports when the security groups created by this policy
        /// become non-compliant. 
        /// </para>
        ///  
        /// <para>
        ///  Firewall Manager won't distribute system tags added by Amazon Web Services services
        /// into the replica security groups. System tags begin with the <c>aws:</c> prefix. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: Shared VPCs. Apply the preceding policy to resources in shared VPCs as well
        /// as to those in VPCs that the account owns 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"SECURITY_GROUPS_COMMON\",\"revertManualSecurityGroupChanges\":false,\"exclusiveResourceSecurityGroupManagement\":false,
        /// \"applyToAllEC2InstanceENIs\":false,\"includeSharedVPC\":true,\"securityGroups\":[{\"id\":\"
        /// sg-000e55995d61a06bd\"}]}"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>SECURITY_GROUPS_CONTENT_AUDIT</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"SECURITY_GROUPS_CONTENT_AUDIT\",\"preManagedOptions\":[{\"denyProtocolAllValue\":true},{\"auditSgDirection\":{\"type\":\"ALL\"}}],\"securityGroups\":[{\"id\":\"sg-049b2393a25468971\"}],\"securityGroupAction\":{\"type\":\"ALLOW\"}}"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The security group action for content audit can be <c>ALLOW</c> or <c>DENY</c>. For
        /// <c>ALLOW</c>, all in-scope security group rules must be within the allowed range of
        /// the policy's security group rules. For <c>DENY</c>, all in-scope security group rules
        /// must not contain a value or a range that matches a rule value or range in the policy
        /// security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>SECURITY_GROUPS_USAGE_AUDIT</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"SECURITY_GROUPS_USAGE_AUDIT\",\"deleteUnusedSecurityGroups\":true,\"coalesceRedundantSecurityGroups\":true,\"optionalDelayForUnusedInMinutes\":60}"</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>SHIELD_ADVANCED</c> with web ACL management
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"SHIELD_ADVANCED\",\"optimizeUnassociatedWebACL\":true}"</c> 
        /// </para>
        ///  
        /// <para>
        /// If you set <c>optimizeUnassociatedWebACL</c> to <c>true</c>, Firewall Manager creates
        /// web ACLs in accounts within the policy scope if the web ACLs will be used by at least
        /// one resource. Firewall Manager creates web ACLs in the accounts within policy scope
        /// only if the web ACLs will be used by at least one resource. If at any time an account
        /// comes into policy scope, Firewall Manager automatically creates a web ACL in the account
        /// if at least one resource will use the web ACL.
        /// </para>
        ///  
        /// <para>
        /// Upon enablement, Firewall Manager performs a one-time cleanup of unused web ACLs in
        /// your account. The cleanup process can take several hours. If a resource leaves policy
        /// scope after Firewall Manager creates a web ACL, Firewall Manager doesn't disassociate
        /// the resource from the web ACL. If you want Firewall Manager to clean up the web ACL,
        /// you must first manually disassociate the resources from the web ACL, and then enable
        /// the manage unused web ACLs option in your policy.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>optimizeUnassociatedWebACL</c> to <c>false</c>, and Firewall Manager
        /// automatically creates an empty web ACL in each account that's within policy scope.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specification for <c>SHIELD_ADVANCED</c> for Amazon CloudFront distributions 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"SHIELD_ADVANCED\",\"automaticResponseConfiguration\": {\"automaticResponseStatus\":\"ENABLED|IGNORED|DISABLED\",
        /// \"automaticResponseAction\":\"BLOCK|COUNT\"}, \"overrideCustomerWebaclClassic\":true|false,
        /// \"optimizeUnassociatedWebACL\":true|false}"</c> 
        /// </para>
        ///  
        /// <para>
        /// For example: <c>"{\"type\":\"SHIELD_ADVANCED\",\"automaticResponseConfiguration\":
        /// {\"automaticResponseStatus\":\"ENABLED\", \"automaticResponseAction\":\"COUNT\"}}"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The default value for <c>automaticResponseStatus</c> is <c>IGNORED</c>. The value
        /// for <c>automaticResponseAction</c> is only required when <c>automaticResponseStatus</c>
        /// is set to <c>ENABLED</c>. The default value for <c>overrideCustomerWebaclClassic</c>
        /// is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// For other resource types that you can protect with a Shield Advanced policy, this
        /// <c>ManagedServiceData</c> configuration is an empty string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>THIRD_PARTY_FIREWALL</c> 
        /// </para>
        ///  
        /// <para>
        /// Replace <c>THIRD_PARTY_FIREWALL_NAME</c> with the name of the third-party firewall.
        /// </para>
        ///  
        /// <para>
        ///  <c>"{ "type":"THIRD_PARTY_FIREWALL", "thirdPartyFirewall":"THIRD_PARTY_FIREWALL_NAME",
        /// "thirdPartyFirewallConfig":{ "thirdPartyFirewallPolicyList":["global-1"] }, "firewallDeploymentModel":{
        /// "distributedFirewallDeploymentModel":{ "distributedFirewallOrchestrationConfig":{
        /// "firewallCreationConfig":{ "endpointLocation":{ "availabilityZoneConfigList":[ { "availabilityZoneName":"${AvailabilityZone}"
        /// } ] } }, "allowedIPV4CidrList":[ ] } } } }"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>WAFV2</c> - Account takeover prevention, Bot Control managed rule groups,
        /// optimize unassociated web ACL, and rule action override 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"WAFV2\",\"preProcessRuleGroups\":[{\"ruleGroupArn\":null,\"overrideAction\":{\"type\":\"NONE\"},\"managedRuleGroupIdentifier\":{\"versionEnabled\":null,\"version\":null,\"vendorName\":\"AWS\",\"managedRuleGroupName\":\"AWSManagedRulesATPRuleSet\",\"managedRuleGroupConfigs\":[{\"awsmanagedRulesATPRuleSet\":{\"loginPath\":\"/loginpath\",\"requestInspection\":{\"payloadType\":\"FORM_ENCODED|JSON\",\"usernameField\":{\"identifier\":\"/form/username\"},\"passwordField\":{\"identifier\":\"/form/password\"}}}}]},\"ruleGroupType\":\"ManagedRuleGroup\",\"excludeRules\":[],\"sampledRequestsEnabled\":true},{\"ruleGroupArn\":null,\"overrideAction\":{\"type\":\"NONE\"},\"managedRuleGroupIdentifier\":{\"versionEnabled\":null,\"version\":null,\"vendorName\":\"AWS\",\"managedRuleGroupName\":\"AWSManagedRulesBotControlRuleSet\",\"managedRuleGroupConfigs\":[{\"awsmanagedRulesBotControlRuleSet\":{\"inspectionLevel\":\"TARGETED|COMMON\"}}]},\"ruleGroupType\":\"ManagedRuleGroup\",\"excludeRules\":[],\"sampledRequestsEnabled\":true,\"ruleActionOverrides\":[{\"name\":\"Rule1\",\"actionToUse\":{\"allow|block|count|captcha|challenge\":{}}},{\"name\":\"Rule2\",\"actionToUse\":{\"allow|block|count|captcha|challenge\":{}}}]}],\"postProcessRuleGroups\":[],\"defaultAction\":{\"type\":\"ALLOW\"},\"customRequestHandling\":null,\"customResponse\":null,\"overrideCustomerWebACLAssociation\":false,\"loggingConfiguration\":null,\"sampledRequestsEnabledForDefaultActions\":true,\"optimizeUnassociatedWebACL\":true}"</c>
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Bot Control - For information about <c>AWSManagedRulesBotControlRuleSet</c> managed
        /// rule groups, see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_AWSManagedRulesBotControlRuleSet.html">AWSManagedRulesBotControlRuleSet</a>
        /// in the <i>WAF API Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fraud Control account takeover prevention (ATP) - For information about the properties
        /// available for <c>AWSManagedRulesATPRuleSet</c> managed rule groups, see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_AWSManagedRulesATPRuleSet.html">AWSManagedRulesATPRuleSet</a>
        /// in the <i>WAF API Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optimize unassociated web ACL - If you set <c>optimizeUnassociatedWebACL</c> to <c>true</c>,
        /// Firewall Manager creates web ACLs in accounts within the policy scope if the web ACLs
        /// will be used by at least one resource. Firewall Manager creates web ACLs in the accounts
        /// within policy scope only if the web ACLs will be used by at least one resource. If
        /// at any time an account comes into policy scope, Firewall Manager automatically creates
        /// a web ACL in the account if at least one resource will use the web ACL.
        /// </para>
        ///  
        /// <para>
        /// Upon enablement, Firewall Manager performs a one-time cleanup of unused web ACLs in
        /// your account. The cleanup process can take several hours. If a resource leaves policy
        /// scope after Firewall Manager creates a web ACL, Firewall Manager disassociates the
        /// resource from the web ACL, but won't clean up the unused web ACL. Firewall Manager
        /// only cleans up unused web ACLs when you first enable management of unused web ACLs
        /// in a policy.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>optimizeUnassociatedWebACL</c> to <c>false</c> Firewall Manager doesn't
        /// manage unused web ACLs, and Firewall Manager automatically creates an empty web ACL
        /// in each account that's within policy scope.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rule action overrides - Firewall Manager supports rule action overrides only for managed
        /// rule groups. To configure a <c>RuleActionOverrides</c> add the <c>Name</c> of the
        /// rule to override, and <c>ActionToUse</c>, which is the new action to use for the rule.
        /// For information about using rule action override, see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_RuleActionOverride.html">RuleActionOverride</a>
        /// in the <i>WAF API Reference</i>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Example: <c>WAFV2</c> - <c>CAPTCHA</c> and <c>Challenge</c> configs 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"WAFV2\",\"preProcessRuleGroups\":[{\"ruleGroupArn\":null,\"overrideAction\":{\"type\":\"NONE\"},\"managedRuleGroupIdentifier\":{\"versionEnabled\":null,\"version\":null,\"vendorName\":\"AWS\",\"managedRuleGroupName\":\"AWSManagedRulesAdminProtectionRuleSet\"},\"ruleGroupType\":\"ManagedRuleGroup\",\"excludeRules\":[],\"sampledRequestsEnabled\":true}],\"postProcessRuleGroups\":[],\"defaultAction\":{\"type\":\"ALLOW\"},\"customRequestHandling\":null,\"customResponse\":null,\"overrideCustomerWebACLAssociation\":false,\"loggingConfiguration\":null,\"sampledRequestsEnabledForDefaultActions\":true,\"captchaConfig\":{\"immunityTimeProperty\":{\"immunityTime\":500}},\"challengeConfig\":{\"immunityTimeProperty\":{\"immunityTime\":800}},\"tokenDomains\":[\"google.com\",\"amazon.com\"],\"associationConfig\":{\"requestBody\":{\"CLOUDFRONT\":{\"defaultSizeInspectionLimit\":\"KB_16\"}}}}"</c>
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CAPTCHA</c> and <c>Challenge</c> configs - If you update the policy's values for
        /// <c>associationConfig</c>, <c>captchaConfig</c>, <c>challengeConfig</c>, or <c>tokenDomains</c>,
        /// Firewall Manager will overwrite your local web ACLs to contain the new value(s). However,
        /// if you don't update the policy's <c>associationConfig</c>, <c>captchaConfig</c>, <c>challengeConfig</c>,
        /// or <c>tokenDomains</c> values, the values in your local web ACLs will remain unchanged.
        /// For information about association configs, see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_AssociationConfig.html">AssociationConfig</a>.
        /// For information about CAPTCHA and Challenge configs, see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_CaptchaConfig.html">CaptchaConfig</a>
        /// and <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_ChallengeConfig.html">ChallengeConfig</a>
        /// in the <i>WAF API Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>defaultSizeInspectionLimit</c> - Specifies the maximum size of the web request
        /// body component that an associated Amazon CloudFront distribution should send to WAF
        /// for inspection. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_RequestBodyAssociatedResourceTypeConfig.html#WAF-Type-RequestBodyAssociatedResourceTypeConfig-DefaultSizeInspectionLimit">DefaultSizeInspectionLimit</a>
        /// in the <i>WAF API Reference</i>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Example: <c>WAFV2</c> - Firewall Manager support for WAF managed rule group versioning
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"preProcessRuleGroups\":[{\"ruleGroupType\":\"ManagedRuleGroup\",\"overrideAction\":{\"type\":\"NONE\"},\"sampledRequestsEnabled\":true,\"managedRuleGroupIdentifier\":{\"managedRuleGroupName\":\"AWSManagedRulesAdminProtectionRuleSet\",\"vendorName\":\"AWS\",\"managedRuleGroupConfigs\":null}}],\"postProcessRuleGroups\":[],\"defaultAction\":{\"type\":\"ALLOW\"},\"customRequestHandling\":null,\"tokenDomains\":null,\"customResponse\":null,\"type\":\"WAFV2\",\"overrideCustomerWebACLAssociation\":false,\"sampledRequestsEnabledForDefaultActions\":true,\"optimizeUnassociatedWebACL\":true,\"webACLSource\":\"RETROFIT_EXISTING\"}"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  To use a specific version of a WAF managed rule group in your Firewall Manager policy,
        /// you must set <c>versionEnabled</c> to <c>true</c>, and set <c>version</c> to the version
        /// you'd like to use. If you don't set <c>versionEnabled</c> to <c>true</c>, or if you
        /// omit <c>versionEnabled</c>, then Firewall Manager uses the default version of the
        /// WAF managed rule group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>WAFV2</c> - Logging configurations 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"type\":\"WAFV2\",\"preProcessRuleGroups\":[{\"ruleGroupArn\":null, \"overrideAction\":{\"type\":\"NONE\"},\"managedRuleGroupIdentifier\":
        /// {\"versionEnabled\":null,\"version\":null,\"vendorName\":\"AWS\", \"managedRuleGroupName\":\"AWSManagedRulesAdminProtectionRuleSet\"}
        /// ,\"ruleGroupType\":\"ManagedRuleGroup\",\"excludeRules\":[], \"sampledRequestsEnabled\":true}],\"postProcessRuleGroups\":[],
        /// \"defaultAction\":{\"type\":\"ALLOW\"},\"customRequestHandling\" :null,\"customResponse\":null,\"overrideCustomerWebACLAssociation\"
        /// :false,\"loggingConfiguration\":{\"logDestinationConfigs\": [\"arn:aws:s3:::aws-waf-logs-example-bucket\"]
        /// ,\"redactedFields\":[],\"loggingFilterConfigs\":{\"defaultBehavior\":\"KEEP\", \"filters\":[{\"behavior\":\"KEEP\",\"requirement\":\"MEETS_ALL\",
        /// \"conditions\":[{\"actionCondition\":\"CAPTCHA\"},{\"actionCondition\": \"CHALLENGE\"},
        /// {\"actionCondition\":\"EXCLUDED_AS_COUNT\"}]}]}},\"sampledRequestsEnabledForDefaultActions\":true}"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Firewall Manager supports Amazon Kinesis Data Firehose and Amazon S3 as the <c>logDestinationConfigs</c>
        /// in your <c>loggingConfiguration</c>. For information about WAF logging configurations,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_LoggingConfiguration.html">LoggingConfiguration</a>
        /// in the <i>WAF API Reference</i> 
        /// </para>
        ///  
        /// <para>
        /// In the <c>loggingConfiguration</c>, you can specify one <c>logDestinationConfigs</c>.
        /// Optionally provide as many as 20 <c>redactedFields</c>. The <c>RedactedFieldType</c>
        /// must be one of <c>URI</c>, <c>QUERY_STRING</c>, <c>HEADER</c>, or <c>METHOD</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>WAF Classic</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"ruleGroups\":[{\"id\":\"78cb36c0-1b5e-4d7d-82b2-cf48d3ad9659\",\"overrideAction\":{\"type\":\"NONE\"}}],\"overrideCustomerWebACLAssociation\":true,\"defaultAction\":{\"type\":\"ALLOW\"},\"type\":\"WAF\"}"</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=30000)]
        public string ManagedServiceData
        {
            get { return this._managedServiceData; }
            set { this._managedServiceData = value; }
        }

        // Check to see if ManagedServiceData property is set
        internal bool IsSetManagedServiceData()
        {
            return this._managedServiceData != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyOption. 
        /// <para>
        /// Contains the settings to configure a network ACL policy, a Network Firewall firewall
        /// policy deployment model, or a third-party firewall policy.
        /// </para>
        /// </summary>
        public PolicyOption PolicyOption
        {
            get { return this._policyOption; }
            set { this._policyOption = value; }
        }

        // Check to see if PolicyOption property is set
        internal bool IsSetPolicyOption()
        {
            return this._policyOption != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The service that the policy is using to protect the resources. This specifies the
        /// type of policy that is created, either an WAF policy, a Shield Advanced policy, or
        /// a security group policy. For security group policies, Firewall Manager supports one
        /// security group for each common policy and for each content audit policy. This is an
        /// adjustable limit that you can increase by contacting Amazon Web Services Support.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SecurityServiceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}