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
    /// Container for the parameters to the PutPolicy operation.
    /// Creates an Firewall Manager policy.
    /// 
    ///  
    /// <para>
    /// A Firewall Manager policy is specific to the individual policy type. If you want to
    /// enforce multiple policy types across accounts, you can create multiple policies. You
    /// can create more than one policy for each type. 
    /// </para>
    ///  
    /// <para>
    /// If you add a new account to an organization that you created with Organizations, Firewall
    /// Manager automatically applies the policy to the resources in that account that are
    /// within scope of the policy. 
    /// </para>
    ///  
    /// <para>
    /// Firewall Manager provides the following types of policies: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>WAF policy</b> - This policy applies WAF web ACL protections to specified accounts
    /// and resources. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Shield Advanced policy</b> - This policy applies Shield Advanced protection to
    /// specified accounts and resources. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Security Groups policy</b> - This type of policy gives you control over security
    /// groups that are in use throughout your organization in Organizations and lets you
    /// enforce a baseline set of rules across your organization. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Network ACL policy</b> - This type of policy gives you control over the network
    /// ACLs that are in use throughout your organization in Organizations and lets you enforce
    /// a baseline set of first and last network ACL rules across your organization. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Network Firewall policy</b> - This policy applies Network Firewall protection
    /// to your organization's VPCs. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>DNS Firewall policy</b> - This policy applies Amazon Route 53 Resolver DNS Firewall
    /// protections to your organization's VPCs. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Third-party firewall policy</b> - This policy applies third-party firewall protections.
    /// Third-party firewalls are available by subscription through the Amazon Web Services
    /// Marketplace console at <a href="http://aws.amazon.com/marketplace">Amazon Web Services
    /// Marketplace</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Palo Alto Networks Cloud NGFW policy</b> - This policy applies Palo Alto Networks
    /// Cloud Next Generation Firewall (NGFW) protections and Palo Alto Networks Cloud NGFW
    /// rulestacks to your organization's VPCs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Fortigate CNF policy</b> - This policy applies Fortigate Cloud Native Firewall
    /// (CNF) protections. Fortigate CNF is a cloud-centered solution that blocks Zero-Day
    /// threats and secures cloud infrastructures with industry-leading advanced threat prevention,
    /// smart web application firewalls (WAF), and API protection.
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class PutPolicyRequest : AmazonFMSRequest
    {
        private Policy _policy;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The details of the Firewall Manager policy to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Policy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The tags to add to the Amazon Web Services resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}