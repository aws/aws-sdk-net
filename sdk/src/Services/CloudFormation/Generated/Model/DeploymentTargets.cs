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
    /// Specifies the Organizations accounts where you want to create, update, or delete stack
    /// instances. You can target either your entire organization or specific accounts using
    /// organizational units (OUs) and account filter options.
    /// 
    ///  
    /// <para>
    /// CloudFormation doesn't deploy stack instances to the organization management account,
    /// even if the organization management account is in your organization or in an OU in
    /// your organization.
    /// </para>
    ///  
    /// <para>
    /// When performing create operations, if you specify both <c>OrganizationalUnitIds</c>
    /// and <c>Accounts</c>, you must also specify the <c>AccountFilterType</c> property.
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
        /// Refines which accounts will have stack operations performed on them by specifying
        /// how to use the <c>Accounts</c> and <c>OrganizationalUnitIds</c> properties together.
        /// </para>
        ///  
        /// <para>
        /// The following values determine how CloudFormation selects target accounts:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INTERSECTION</c>: Performs stack operations only on specific individual accounts
        /// within the selected OUs. Only accounts that are both specified in the <c>Accounts</c>
        /// property and belong to the specified OUs will be targeted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIFFERENCE</c>: Performs stack operations on all accounts in the selected OUs
        /// except for specific accounts listed in the <c>Accounts</c> property. This enables
        /// you to exclude certain accounts within an OU, such as suspended accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNION</c>: Performs stack operations on the specified OUs plus additional individual
        /// accounts listed in the <c>Accounts</c> property. This is the default value if <c>AccountFilterType</c>
        /// is not provided. This lets you target an entire OU and individual accounts from a
        /// different OU in one request. Note that <c>UNION</c> is not supported for <c>CreateStackInstances</c>
        /// operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: Performs stack operations on all accounts in the specified organizational
        /// units (OUs).
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
        /// The Amazon Web Services account IDs where you want to perform stack operations. How
        /// these accounts are used depends on the <c>AccountFilterType</c> property.
        /// </para>
        ///  
        /// <para>
        /// If you have many account numbers, you can provide those accounts using the <c>AccountsUrl</c>
        /// property instead.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// The Amazon S3 URL path to a file that contains a list of Amazon Web Services account
        /// IDs. The file format must be either <c>.csv</c> or <c>.txt</c>, and the data can be
        /// comma-separated or new-line-separated. There is currently a 10MB limit for the data
        /// (approximately 800,000 accounts).
        /// </para>
        ///  
        /// <para>
        /// This property serves the same purpose as <c>Accounts</c> but allows you to specify
        /// a large number of accounts.
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
        /// The organization root ID or organizational unit (OU) IDs where you want to perform
        /// stack operations. CloudFormation will perform operations on accounts within these
        /// OUs and their child OUs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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