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
    /// Details of the Firewall Manager policy.
    /// </summary>
    public partial class PolicySummary
    {
        private bool? _deleteUnusedFMManagedResources;
        private string _policyArn;
        private string _policyId;
        private string _policyName;
        private CustomerPolicyStatus _policyStatus;
        private bool? _remediationEnabled;
        private string _resourceType;
        private SecurityServiceType _securityServiceType;

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
        public bool? DeleteUnusedFMManagedResources
        {
            get { return this._deleteUnusedFMManagedResources; }
            set { this._deleteUnusedFMManagedResources = value; }
        }

        // Check to see if DeleteUnusedFMManagedResources property is set
        internal bool IsSetDeleteUnusedFMManagedResources()
        {
            return this._deleteUnusedFMManagedResources.HasValue; 
        }

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
        public CustomerPolicyStatus PolicyStatus
        {
            get { return this._policyStatus; }
            set { this._policyStatus = value; }
        }

        // Check to see if PolicyStatus property is set
        internal bool IsSetPolicyStatus()
        {
            return this._policyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RemediationEnabled. 
        /// <para>
        /// Indicates if the policy should be automatically applied to new resources.
        /// </para>
        /// </summary>
        public bool? RemediationEnabled
        {
            get { return this._remediationEnabled; }
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
        /// shown in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services Resource Types Reference</a>. 
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
        /// type of policy that is created, either an WAF policy, a Shield Advanced policy, or
        /// a security group policy.
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