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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DisablePolicyType operation.
    /// Disables an organizational policy type in a root. A policy of a certain type can be
    /// attached to entities in a root only if that type is enabled in the root. After you
    /// perform this operation, you no longer can attach policies of the specified type to
    /// that root or to any organizational unit (OU) or account in that root. You can undo
    /// this by using the <a>EnablePolicyType</a> operation.
    /// 
    ///  
    /// <para>
    /// This is an asynchronous request that Amazon Web Services performs in the background.
    /// If you disable a policy type for a root, it still appears enabled for the organization
    /// if <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">all
    /// features</a> are enabled for the organization. Amazon Web Services recommends that
    /// you first use <a>ListRoots</a> to see the status of policy types for a specified root,
    /// and then use this operation.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's management account or by
    /// a member account that is a delegated administrator.
    /// </para>
    ///  
    /// <para>
    ///  To view the status of available policy types in the organization, use <a>ListRoots</a>.
    /// </para>
    /// </summary>
    public partial class DisablePolicyTypeRequest : AmazonOrganizationsRequest
    {
        private PolicyType _policyType;
        private string _rootId;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The policy type that you want to disable in this root. You can specify one of the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_scp.html">SERVICE_CONTROL_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_rcps.html">RESOURCE_CONTROL_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_declarative.html">DECLARATIVE_POLICY_EC2</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_backup.html">BACKUP_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">TAG_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_chatbot.html">CHATBOT_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_ai-opt-out.html">AISERVICES_OPT_OUT_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_security_hub.html">SECURITYHUB_POLICY</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property RootId. 
        /// <para>
        /// The unique identifier (ID) of the root in which you want to disable a policy type.
        /// You can get the ID from the <a>ListRoots</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a root ID string
        /// requires "r-" followed by from 4 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=34)]
        public string RootId
        {
            get { return this._rootId; }
            set { this._rootId = value; }
        }

        // Check to see if RootId property is set
        internal bool IsSetRootId()
        {
            return this._rootId != null;
        }

    }
}