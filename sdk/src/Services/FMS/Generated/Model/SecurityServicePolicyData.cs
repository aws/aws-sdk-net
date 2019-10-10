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
    /// Details about the security service that is being used to protect the resources.
    /// </summary>
    public partial class SecurityServicePolicyData
    {
        private string _managedServiceData;
        private SecurityServiceType _type;

        /// <summary>
        /// Gets and sets the property ManagedServiceData. 
        /// <para>
        /// Details about the service that are specific to the service type, in JSON format. For
        /// service type <code>SHIELD_ADVANCED</code>, this is an empty string.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Example: <code>WAF</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ManagedServiceData": "{\"type\": \"WAF\", \"ruleGroups\": [{\"id\": \"12345678-1bcd-9012-efga-0987654321ab\",
        /// \"overrideAction\" : {\"type\": \"COUNT\"}}], \"defaultAction\": {\"type\": \"BLOCK\"}}</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>SECURITY_GROUPS_COMMON</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"SecurityServicePolicyData":{"Type":"SECURITY_GROUPS_COMMON","ManagedServiceData":"{\"type\":\"SECURITY_GROUPS_COMMON\",\"revertManualSecurityGroupChanges\":false,\"exclusiveResourceSecurityGroupManagement\":false,\"securityGroups\":[{\"id\":\"
        /// sg-000e55995d61a06bd\"}]}"},"RemediationEnabled":false,"ResourceType":"AWS::EC2::NetworkInterface"}</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>SECURITY_GROUPS_CONTENT_AUDIT</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"SecurityServicePolicyData":{"Type":"SECURITY_GROUPS_CONTENT_AUDIT","ManagedServiceData":"{\"type\":\"SECURITY_GROUPS_CONTENT_AUDIT\",\"securityGroups\":[{\"id\":\"
        /// sg-000e55995d61a06bd \"}],\"securityGroupAction\":{\"type\":\"ALLOW\"}}"},"RemediationEnabled":false,"ResourceType":"AWS::EC2::NetworkInterface"}</code>
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
        ///  <code>"SecurityServicePolicyData":{"Type":"SECURITY_GROUPS_USAGE_AUDIT","ManagedServiceData":"{\"type\":\"SECURITY_GROUPS_USAGE_AUDIT\",\"deleteUnusedSecurityGroups\":true,\"coalesceRedundantSecurityGroups\":true}"},"RemediationEnabled":false,"Resou
        /// rceType":"AWS::EC2::SecurityGroup"}</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The service that the policy is using to protect the resources. This specifies the
        /// type of policy that is created, either an AWS WAF policy, a Shield Advanced policy,
        /// or a security group policy. For security group policies, Firewall Manager supports
        /// one security group for each common policy and for each content audit policy. This
        /// is an adjustable limit that you can increase by contacting AWS Support.
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