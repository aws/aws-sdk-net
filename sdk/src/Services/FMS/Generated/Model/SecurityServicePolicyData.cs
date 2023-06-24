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
        /// Example: <code>DNS_FIREWALL</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"DNS_FIREWALL\",\"preProcessRuleGroups\":[{\"ruleGroupId\":\"rslvr-frg-1\",\"priority\":10}],\"postProcessRuleGroups\":[{\"ruleGroupId\":\"rslvr-frg-2\",\"priority\":9911}]}"</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid values for <code>preProcessRuleGroups</code> are between 1 and 99. Valid values
        /// for <code>postProcessRuleGroups</code> are between 9901 and 10000.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Example: <code>IMPORT_NETWORK_FIREWALL</code> <code>"{\"type\":\"IMPORT_NETWORK_FIREWALL\",\"awsNetworkFirewallConfig\":{\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-west-2:000000000000:stateless-rulegroup\/rg1\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:drop\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:pass\"],\"networkFirewallStatelessCustomActions\":[],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-west-2:aws-managed:stateful-rulegroup\/ThreatSignaturesEmergingEventsStrictOrder\",\"priority\":8}],\"networkFirewallStatefulEngineOptions\":{\"ruleOrder\":\"STRICT_ORDER\"},\"networkFirewallStatefulDefaultActions\":[\"aws:drop_strict\"]}}"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"DNS_FIREWALL\",\"preProcessRuleGroups\":[{\"ruleGroupId\":\"rslvr-frg-1\",\"priority\":10}],\"postProcessRuleGroups\":[{\"ruleGroupId\":\"rslvr-frg-2\",\"priority\":9911}]}"</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid values for <code>preProcessRuleGroups</code> are between 1 and 99. Valid values
        /// for <code>postProcessRuleGroups</code> are between 9901 and 10000.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Example: <code>NETWORK_FIREWALL</code> - Centralized deployment model
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"NETWORK_FIREWALL\",\"awsNetworkFirewallConfig\":{\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateless-rulegroup/test\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessCustomActions\":[{\"actionName\":\"customActionName\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"metricdimensionvalue\"}]}}}],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateful-rulegroup/test\"}],\"networkFirewallLoggingConfiguration\":{\"logDestinationConfigs\":[{\"logDestinationType\":\"S3\",\"logType\":\"ALERT\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}},{\"logDestinationType\":\"S3\",\"logType\":\"FLOW\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}}],\"overrideExistingConfig\":true}},\"firewallDeploymentModel\":{\"centralizedFirewallDeploymentModel\":{\"centralizedFirewallOrchestrationConfig\":{\"inspectionVpcIds\":[{\"resourceId\":\"vpc-1234\",\"accountId\":\"123456789011\"}],\"firewallCreationConfig\":{\"endpointLocation\":{\"availabilityZoneConfigList\":[{\"availabilityZoneId\":null,\"availabilityZoneName\":\"us-east-1a\",\"allowedIPV4CidrList\":[\"10.0.0.0/28\"]}]}},\"allowedIPV4CidrList\":[]}}}}"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  To use the centralized deployment model, you must set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <code>CENTRALIZED</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>NETWORK_FIREWALL</code> - Distributed deployment model with automatic
        /// Availability Zone configuration
        /// </para>
        ///  
        /// <para>
        ///  <code> "{\"type\":\"NETWORK_FIREWALL\",\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateless-rulegroup/test\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessCustomActions\":[{\"actionName\":\"customActionName\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"metricdimensionvalue\"}]}}}],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateful-rulegroup/test\"}],\"networkFirewallOrchestrationConfig\":{\"singleFirewallEndpointPerVPC\":false,\"allowedIPV4CidrList\":[\"10.0.0.0/28\",\"192.168.0.0/28\"],\"routeManagementAction\":\"OFF\"},\"networkFirewallLoggingConfiguration\":{\"logDestinationConfigs\":[{\"logDestinationType\":\"S3\",\"logType\":\"ALERT\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}},{\"logDestinationType\":\"S3\",\"logType\":\"FLOW\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}}],\"overrideExistingConfig\":true}}"
        /// </code> 
        /// </para>
        ///  
        /// <para>
        ///  With automatic Availbility Zone configuration, Firewall Manager chooses which Availability
        /// Zones to create the endpoints in. To use the distributed deployment model, you must
        /// set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <code>NULL</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>NETWORK_FIREWALL</code> - Distributed deployment model with automatic
        /// Availability Zone configuration and route management
        /// </para>
        ///  
        /// <para>
        ///  <code> "{\"type\":\"NETWORK_FIREWALL\",\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateless-rulegroup/test\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessCustomActions\":[{\"actionName\":\"customActionName\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"metricdimensionvalue\"}]}}}],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateful-rulegroup/test\"}],\"networkFirewallOrchestrationConfig\":{\"singleFirewallEndpointPerVPC\":false,\"allowedIPV4CidrList\":[\"10.0.0.0/28\",\"192.168.0.0/28\"],\"routeManagementAction\":\"MONITOR\",\"routeManagementTargetTypes\":[\"InternetGateway\"]},\"networkFirewallLoggingConfiguration\":{\"logDestinationConfigs\":[{\"logDestinationType\":\"S3\",\"logType\":\"ALERT\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}},{\"logDestinationType\":\"S3\",\"logType\":
        /// \"FLOW\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}}],\"overrideExistingConfig\":true}}"
        /// </code> 
        /// </para>
        ///  
        /// <para>
        /// To use the distributed deployment model, you must set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <code>NULL</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>NETWORK_FIREWALL</code> - Distributed deployment model with custom
        /// Availability Zone configuration
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"NETWORK_FIREWALL\",\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateless-rulegroup/test\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:forward_to_sfe\",\"fragmentcustomactionname\"],\"networkFirewallStatelessCustomActions\":[{\"actionName\":\"customActionName\",
        /// \"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"metricdimensionvalue\"}]}}},{\"actionName\":\"fragmentcustomactionname\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"fragmentmetricdimensionvalue\"}]}}}],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateful-rulegroup/test\"}],\"networkFirewallOrchestrationConfig\":{\"firewallCreationConfig\":{
        /// \"endpointLocation\":{\"availabilityZoneConfigList\":[{\"availabilityZoneName\":\"us-east-1a\",\"allowedIPV4CidrList\":[\"10.0.0.0/28\"]},{\"availabilityZoneName\":\"us-east-1b\",\"allowedIPV4CidrList\":[
        /// \"10.0.0.0/28\"]}]} },\"singleFirewallEndpointPerVPC\":false,\"allowedIPV4CidrList\":null,\"routeManagementAction\":\"OFF\",\"networkFirewallLoggingConfiguration\":{\"logDestinationConfigs\":[{\"logDestinationType\":\"S3\",\"logType\":\"ALERT\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}},{\"logDestinationType\":\"S3\",\"logType\":\"FLOW\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}}],\"overrideExistingConfig\":boolean}}"
        /// </code> 
        /// </para>
        ///  
        /// <para>
        ///  With custom Availability Zone configuration, you define which specific Availability
        /// Zones to create endpoints in by configuring <code>firewallCreationConfig</code>. To
        /// configure the Availability Zones in <code>firewallCreationConfig</code>, specify either
        /// the <code>availabilityZoneName</code> or <code>availabilityZoneId</code> parameter,
        /// not both parameters. 
        /// </para>
        ///  
        /// <para>
        /// To use the distributed deployment model, you must set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <code>NULL</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>NETWORK_FIREWALL</code> - Distributed deployment model with custom
        /// Availability Zone configuration and route management
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"NETWORK_FIREWALL\",\"networkFirewallStatelessRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateless-rulegroup/test\",\"priority\":1}],\"networkFirewallStatelessDefaultActions\":[\"aws:forward_to_sfe\",\"customActionName\"],\"networkFirewallStatelessFragmentDefaultActions\":[\"aws:forward_to_sfe\",\"fragmentcustomactionname\"],\"networkFirewallStatelessCustomActions\":[{\"actionName\":\"customActionName\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"metricdimensionvalue\"}]}}},{\"actionName\":\"fragmentcustomactionname\",\"actionDefinition\":{\"publishMetricAction\":{\"dimensions\":[{\"value\":\"fragmentmetricdimensionvalue\"}]}}}],\"networkFirewallStatefulRuleGroupReferences\":[{\"resourceARN\":\"arn:aws:network-firewall:us-east-1:123456789011:stateful-rulegroup/test\"}],\"networkFirewallOrchestrationConfig\":{\"firewallCreationConfig\":{\"endpointLocation\":{\"availabilityZoneConfigList\":[{\"availabilityZoneName\":\"us-east-1a\",\"allowedIPV4CidrList\":[\"10.0.0.0/28\"]},{\"availabilityZoneName\":\"us-east-1b\",\"allowedIPV4CidrList\":[\"10.0.0.0/28\"]}]}},\"singleFirewallEndpointPerVPC\":false,\"allowedIPV4CidrList\":null,\"routeManagementAction\":\"MONITOR\",\"routeManagementTargetTypes\":[\"InternetGateway\"],\"routeManagementConfig\":{\"allowCrossAZTrafficIfNoEndpoint\":true}},\"networkFirewallLoggingConfiguration\":{\"logDestinationConfigs\":[{\"logDestinationType\":\"S3\",\"logType\":\"ALERT\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}},{\"logDestinationType\":\"S3\",\"logType\":\"FLOW\",\"logDestination\":{\"bucketName\":\"s3-bucket-name\"}}],\"overrideExistingConfig\":boolean}}"
        /// </code> 
        /// </para>
        ///  
        /// <para>
        /// To use the distributed deployment model, you must set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <code>NULL</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>THIRD_PARTY_FIREWALL</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{ "type":"THIRD_PARTY_FIREWALL", "thirdPartyFirewall":"PALO_ALTO_NETWORKS_CLOUD_NGFW",
        /// "thirdPartyFirewallConfig":{ "thirdPartyFirewallPolicyList":["global-1"] }, "firewallDeploymentModel":{
        /// "distributedFirewallDeploymentModel":{ "distributedFirewallOrchestrationConfig":{
        /// "firewallCreationConfig":{ "endpointLocation":{ "availabilityZoneConfigList":[ { "availabilityZoneName":"${AvailabilityZone}"
        /// } ] } }, "allowedIPV4CidrList":[ ] } } } }"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>SECURITY_GROUPS_COMMON</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"SECURITY_GROUPS_COMMON\",\"revertManualSecurityGroupChanges\":false,\"exclusiveResourceSecurityGroupManagement\":false,
        /// \"applyToAllEC2InstanceENIs\":false,\"securityGroups\":[{\"id\":\" sg-000e55995d61a06bd\"}]}"</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>SECURITY_GROUPS_COMMON</code> - Security group tag distribution 
        /// </para>
        ///  
        /// <para>
        ///  <code>""{\"type\":\"SECURITY_GROUPS_COMMON\",\"securityGroups\":[{\"id\":\"sg-000e55995d61a06bd\"}],\"revertManualSecurityGroupChanges\":true,\"exclusiveResourceSecurityGroupManagement\":false,\"applyToAllEC2InstanceENIs\":false,\"includeSharedVPC\":false,\"enableTagDistribution\":true}""</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Firewall Manager automatically distributes tags from the primary group to the security
        /// groups created by this policy. To use security group tag distribution, you must also
        /// set <code>revertManualSecurityGroupChanges</code> to <code>true</code>, otherwise
        /// Firewall Manager won't be able to create the policy. When you enable <code>revertManualSecurityGroupChanges</code>,
        /// Firewall Manager identifies and reports when the security groups created by this policy
        /// become non-compliant. 
        /// </para>
        ///  
        /// <para>
        ///  Firewall Manager won't distrubute system tags added by Amazon Web Services services
        /// into the replica security groups. System tags begin with the <code>aws:</code> prefix.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: Shared VPCs. Apply the preceding policy to resources in shared VPCs as well
        /// as to those in VPCs that the account owns 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"SECURITY_GROUPS_COMMON\",\"revertManualSecurityGroupChanges\":false,\"exclusiveResourceSecurityGroupManagement\":false,
        /// \"applyToAllEC2InstanceENIs\":false,\"includeSharedVPC\":true,\"securityGroups\":[{\"id\":\"
        /// sg-000e55995d61a06bd\"}]}"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>SECURITY_GROUPS_CONTENT_AUDIT</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"SECURITY_GROUPS_CONTENT_AUDIT\",\"securityGroups\":[{\"id\":\"sg-000e55995d61a06bd\"}],\"securityGroupAction\":{\"type\":\"ALLOW\"}}"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The security group action for content audit can be <code>ALLOW</code> or <code>DENY</code>.
        /// For <code>ALLOW</code>, all in-scope security group rules must be within the allowed
        /// range of the policy's security group rules. For <code>DENY</code>, all in-scope security
        /// group rules must not contain a value or a range that matches a rule value or range
        /// in the policy security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>SECURITY_GROUPS_USAGE_AUDIT</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"SECURITY_GROUPS_USAGE_AUDIT\",\"deleteUnusedSecurityGroups\":true,\"coalesceRedundantSecurityGroups\":true}"</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specification for <code>SHIELD_ADVANCED</code> for Amazon CloudFront distributions
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"SHIELD_ADVANCED\",\"automaticResponseConfiguration\": {\"automaticResponseStatus\":\"ENABLED|IGNORED|DISABLED\",
        /// \"automaticResponseAction\":\"BLOCK|COUNT\"}, \"overrideCustomerWebaclClassic\":true|false}"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example: <code>"{\"type\":\"SHIELD_ADVANCED\",\"automaticResponseConfiguration\":
        /// {\"automaticResponseStatus\":\"ENABLED\", \"automaticResponseAction\":\"COUNT\"}}"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The default value for <code>automaticResponseStatus</code> is <code>IGNORED</code>.
        /// The value for <code>automaticResponseAction</code> is only required when <code>automaticResponseStatus</code>
        /// is set to <code>ENABLED</code>. The default value for <code>overrideCustomerWebaclClassic</code>
        /// is <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// For other resource types that you can protect with a Shield Advanced policy, this
        /// <code>ManagedServiceData</code> configuration is an empty string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>WAFV2</code> - Account takeover prevention and Bot Control managed
        /// rule groups, and rule action override 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"WAFV2\",\"preProcessRuleGroups\":[{\"ruleGroupArn\":null,\"overrideAction\":{\"type\":\"NONE\"},\"managedRuleGroupIdentifier\":{\"versionEnabled\":null,\"version\":null,\"vendorName\":\"AWS\",\"managedRuleGroupName\":\"AWSManagedRulesATPRuleSet\",\"managedRuleGroupConfigs\":[{\"awsmanagedRulesATPRuleSet\":{\"loginPath\":\"/loginpath\",\"requestInspection\":{\"payloadType\":\"FORM_ENCODED|JSON\",\"usernameField\":{\"identifier\":\"/form/username\"},\"passwordField\":{\"identifier\":\"/form/password\"}}}}]},\"ruleGroupType\":\"ManagedRuleGroup\",\"excludeRules\":[],\"sampledRequestsEnabled\":true},{\"ruleGroupArn\":null,\"overrideAction\":{\"type\":\"NONE\"},\"managedRuleGroupIdentifier\":{\"versionEnabled\":null,\"version\":null,\"vendorName\":\"AWS\",\"managedRuleGroupName\":\"AWSManagedRulesBotControlRuleSet\",\"managedRuleGroupConfigs\":[{\"awsmanagedRulesBotControlRuleSet\":{\"inspectionLevel\":\"TARGETED|COMMON\"}}]},\"ruleGroupType\":\"ManagedRuleGroup\",\"excludeRules\":[],\"sampledRequestsEnabled\":true,\"ruleActionOverrides\":[{\"name\":\"Rule1\",\"actionToUse\":{\"allow|block|count|captcha|challenge\":{}}},{\"name\":\"Rule2\",\"actionToUse\":{\"allow|block|count|captcha|challenge\":{}}}]}],\"postProcessRuleGroups\":[],\"defaultAction\":{\"type\":\"ALLOW\"},\"customRequestHandling\":null,\"customResponse\":null,\"overrideCustomerWebACLAssociation\":false,\"loggingConfiguration\":null,\"sampledRequestsEnabledForDefaultActions\":true}"</code>
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Fraud Control account takeover prevention (ATP) - For information about the properties
        /// available for <code>AWSManagedRulesATPRuleSet</code> managed rule groups, see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_AWSManagedRulesATPRuleSet.html">AWSManagedRulesATPRuleSet</a>
        /// in the <i>WAF API Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Bot Control - For information about <code>AWSManagedRulesBotControlRuleSet</code>
        /// managed rule groups, see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_AWSManagedRulesBotControlRuleSet.html">AWSManagedRulesBotControlRuleSet</a>
        /// in the <i>WAF API Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rule action overrides - Firewall Manager supports rule action overrides only for managed
        /// rule groups. To configure a <code>RuleActionOverrides</code> add the <code>Name</code>
        /// of the rule to override, and <code>ActionToUse</code>, which is the new action to
        /// use for the rule. For information about using rule action override, see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_RuleActionOverride.html">RuleActionOverride</a>
        /// in the <i>WAF API Reference</i>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Example: <code>WAFV2</code> - <code>CAPTCHA</code> and <code>Challenge</code> configs
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"WAFV2\",\"preProcessRuleGroups\":[{\"ruleGroupArn\":null,\"overrideAction\":{\"type\":\"NONE\"},\"managedRuleGroupIdentifier\":{\"versionEnabled\":null,\"version\":null,\"vendorName\":\"AWS\",\"managedRuleGroupName\":\"AWSManagedRulesAdminProtectionRuleSet\"},\"ruleGroupType\":\"ManagedRuleGroup\",\"excludeRules\":[],\"sampledRequestsEnabled\":true}],\"postProcessRuleGroups\":[],\"defaultAction\":{\"type\":\"ALLOW\"},\"customRequestHandling\":null,\"customResponse\":null,\"overrideCustomerWebACLAssociation\":false,\"loggingConfiguration\":null,\"sampledRequestsEnabledForDefaultActions\":true,\"captchaConfig\":{\"immunityTimeProperty\":{\"immunityTime\":500}},\"challengeConfig\":{\"immunityTimeProperty\":{\"immunityTime\":800}},\"tokenDomains\":[\"google.com\",\"amazon.com\"]}"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you update the policy's values for <code>captchaConfig</code>, <code>challengeConfig</code>,
        /// or <code>tokenDomains</code>, Firewall Manager will overwrite your local web ACLs
        /// to contain the new value(s). However, if you don't update the policy's <code>captchaConfig</code>,
        /// <code>challengeConfig</code>, or <code>tokenDomains</code> values, the values in your
        /// local web ACLs will remain unchanged. For information about CAPTCHA and Challenge
        /// configs, see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_CaptchaConfig.html">CaptchaConfig</a>
        /// and <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_ChallengeConfig.html">ChallengeConfig</a>
        /// in the <i>WAF API Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>WAFV2</code> - Firewall Manager support for WAF managed rule group
        /// versioning 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"WAFV2\",\"preProcessRuleGroups\":[{\"ruleGroupArn\":null,\"overrideAction\":{\"type\":\"NONE\"},\"managedRuleGroupIdentifier\":{\"versionEnabled\":true,\"version\":\"Version_2.0\",\"vendorName\":\"AWS\",\"managedRuleGroupName\":\"AWSManagedRulesCommonRuleSet\"},\"ruleGroupType\":\"ManagedRuleGroup\",\"excludeRules\":[{\"name\":\"NoUserAgent_HEADER\"}]}],\"postProcessRuleGroups\":[],\"defaultAction\":{\"type\":\"ALLOW\"},\"overrideCustomerWebACLAssociation\":false,\"loggingConfiguration\":{\"logDestinationConfigs\":[\"arn:aws:firehose:us-west-2:12345678912:deliverystream/aws-waf-logs-fms-admin-destination\"],\"redactedFields\":[{\"redactedFieldType\":\"SingleHeader\",\"redactedFieldValue\":\"Cookies\"},{\"redactedFieldType\":\"Method\"}]}}"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  To use a specific version of a WAF managed rule group in your Firewall Manager policy,
        /// you must set <code>versionEnabled</code> to <code>true</code>, and set <code>version</code>
        /// to the version you'd like to use. If you don't set <code>versionEnabled</code> to
        /// <code>true</code>, or if you omit <code>versionEnabled</code>, then Firewall Manager
        /// uses the default version of the WAF managed rule group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>WAFV2</code> - Logging configurations 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\":\"WAFV2\",\"preProcessRuleGroups\":[{\"ruleGroupArn\":null, \"overrideAction\":{\"type\":\"NONE\"},\"managedRuleGroupIdentifier\":
        /// {\"versionEnabled\":null,\"version\":null,\"vendorName\":\"AWS\", \"managedRuleGroupName\":\"AWSManagedRulesAdminProtectionRuleSet\"}
        /// ,\"ruleGroupType\":\"ManagedRuleGroup\",\"excludeRules\":[], \"sampledRequestsEnabled\":true}],\"postProcessRuleGroups\":[],
        /// \"defaultAction\":{\"type\":\"ALLOW\"},\"customRequestHandling\" :null,\"customResponse\":null,\"overrideCustomerWebACLAssociation\"
        /// :false,\"loggingConfiguration\":{\"logDestinationConfigs\": [\"arn:aws:s3:::aws-waf-logs-example-bucket\"]
        /// ,\"redactedFields\":[],\"loggingFilterConfigs\":{\"defaultBehavior\":\"KEEP\", \"filters\":[{\"behavior\":\"KEEP\",\"requirement\":\"MEETS_ALL\",
        /// \"conditions\":[{\"actionCondition\":\"CAPTCHA\"},{\"actionCondition\": \"CHALLENGE\"},
        /// {\"actionCondition\":\"EXCLUDED_AS_COUNT\"}]}]}},\"sampledRequestsEnabledForDefaultActions\":true}"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Firewall Manager supports Amazon Kinesis Data Firehose and Amazon S3 as the <code>logDestinationConfigs</code>
        /// in your <code>loggingConfiguration</code>. For information about WAF logging configurations,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/APIReference/API_LoggingConfiguration.html">LoggingConfiguration</a>
        /// in the <i>WAF API Reference</i> 
        /// </para>
        ///  
        /// <para>
        /// In the <code>loggingConfiguration</code>, you can specify one <code>logDestinationConfigs</code>.
        /// Optionally provide as many as 20 <code>redactedFields</code>. The <code>RedactedFieldType</code>
        /// must be one of <code>URI</code>, <code>QUERY_STRING</code>, <code>HEADER</code>, or
        /// <code>METHOD</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>WAF Classic</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"type\": \"WAF\", \"ruleGroups\": [{\"id\":\"12345678-1bcd-9012-efga-0987654321ab\",
        /// \"overrideAction\" : {\"type\": \"COUNT\"}}], \"defaultAction\": {\"type\": \"BLOCK\"}}"</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
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
        /// Contains the Network Firewall firewall policy options to configure a centralized deployment
        /// model.
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