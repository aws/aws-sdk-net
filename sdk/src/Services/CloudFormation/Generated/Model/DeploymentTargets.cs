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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// [Service-managed permissions] The Organizations accounts to which StackSets deploys.
    /// StackSets doesn't deploy stack instances to the organization management account, even
    /// if the organization management account is in your organization or in an OU in your
    /// organization.
    /// 
    ///  
    /// <para>
    /// For update operations, you can specify either <c>Accounts</c> or <c>OrganizationalUnitIds</c>.
    /// For create and delete operations, specify <c>OrganizationalUnitIds</c>.
    /// </para>
    /// </summary>
    public partial class DeploymentTargets
    {
        private AccountFilterType _accountFilterType;
        private List<string> _accounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _accountsUrl;
        private List<string> _organizationalUnitIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccountFilterType. 
        /// <para>
        /// Limit deployment targets to individual accounts or include additional accounts with
        /// provided OUs.
        /// </para>
        ///  
        /// <para>
        /// The following is a list of possible values for the <c>AccountFilterType</c> operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INTERSECTION</c>: StackSets deploys to the accounts specified in <c>Accounts</c>
        /// parameter. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIFFERENCE</c>: StackSets excludes the accounts specified in <c>Accounts</c> parameter.
        /// This enables user to avoid certain accounts within an OU such as suspended accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNION</c>: StackSets includes additional accounts deployment targets. 
        /// </para>
        ///  
        /// <para>
        /// This is the default value if <c>AccountFilterType</c> is not provided. This enables
        /// user to update an entire OU and individual accounts from a different OU in one request,
        /// which used to be two separate requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: Deploys to all the accounts in specified organizational units (OU).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AccountFilterType AccountFilterType
        {
            get { return this._accountFilterType; }
            set { this._accountFilterType = value; }
        }

        // Check to see if AccountFilterType property is set
        internal bool IsSetAccountFilterType()
        {
            return this._accountFilterType != null;
        }

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// The names of one or more Amazon Web Services accounts for which you want to deploy
        /// stack set updates.
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
            return this._accounts != null && (this._accounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AccountsUrl. 
        /// <para>
        /// Returns the value of the <c>AccountsUrl</c> property.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5120)]
        public string AccountsUrl
        {
            get { return this._accountsUrl; }
            set { this._accountsUrl = value; }
        }

        // Check to see if AccountsUrl property is set
        internal bool IsSetAccountsUrl()
        {
            return this._accountsUrl != null;
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
            return this._organizationalUnitIds != null && (this._organizationalUnitIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}