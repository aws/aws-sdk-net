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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePolicy operation.
    /// Creates a policy of a specified type that you can attach to a root, an organizational
    /// unit (OU), or an individual AWS account.
    /// 
    ///  
    /// <para>
    /// For more information about policies and their use, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies.html">Managing
    /// Organization Control Policies</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account.
    /// </para>
    /// </summary>
    public partial class CreatePolicyRequest : AmazonOrganizationsRequest
    {
        private string _content;
        private string _description;
        private string _name;
        private PolicyType _type;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The policy content to add to the new policy. For example, if you create a <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_scps.html">service
        /// control policy</a> (SCP), this string must be JSON text that specifies the permissions
        /// that admins in attached accounts can delegate to their users, groups, and roles. For
        /// more information about the SCP syntax, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_scps.html#scp_syntax">Syntax
        /// for SCPs</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description to assign to the policy.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name to assign to the policy.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> that is used to validate
        /// this parameter is a string of any of the characters in the ASCII character range.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of policy to create.
        /// </para>
        ///  <note> 
        /// <para>
        /// In the current release, the only type of policy that you can create is a service control
        /// policy (SCP).
        /// </para>
        ///  </note>
        /// </summary>
        public PolicyType Type
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