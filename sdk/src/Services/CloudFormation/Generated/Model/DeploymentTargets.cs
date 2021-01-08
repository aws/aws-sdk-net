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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// [<code>Service-managed</code> permissions] The AWS Organizations accounts to which
    /// StackSets deploys. StackSets does not deploy stack instances to the organization management
    /// account, even if the organization management account is in your organization or in
    /// an OU in your organization.
    /// 
    ///  
    /// <para>
    /// For update operations, you can specify either <code>Accounts</code> or <code>OrganizationalUnitIds</code>.
    /// For create and delete operations, specify <code>OrganizationalUnitIds</code>.
    /// </para>
    /// </summary>
    public partial class DeploymentTargets
    {
        private List<string> _accounts = new List<string>();
        private List<string> _organizationalUnitIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// The names of one or more AWS accounts for which you want to deploy stack set updates.
        /// </para>
        /// </summary>
        public List<string> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && this._accounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitIds. 
        /// <para>
        /// The organization root ID or organizational unit (OU) IDs to which StackSets deploys.
        /// </para>
        /// </summary>
        public List<string> OrganizationalUnitIds
        {
            get { return this._organizationalUnitIds; }
            set { this._organizationalUnitIds = value; }
        }

        // Check to see if OrganizationalUnitIds property is set
        internal bool IsSetOrganizationalUnitIds()
        {
            return this._organizationalUnitIds != null && this._organizationalUnitIds.Count > 0; 
        }

    }
}