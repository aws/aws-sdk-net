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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Account.Model
{
    /// <summary>
    /// Container for the parameters to the ListRegions operation.
    /// Lists all the Regions for a given account and their respective opt-in statuses. Optionally,
    /// this list can be filtered by the <code>region-opt-status-contains</code> parameter.
    /// </summary>
    public partial class ListRegionsRequest : AmazonAccountRequest
    {
        private string _accountId;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _regionOptStatusContains = new List<string>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Specifies the 12-digit account ID number of the Amazon Web Services account that you
        /// want to access or modify with this operation. If you don't specify this parameter,
        /// it defaults to the Amazon Web Services account of the identity used to call the operation.
        /// To use this parameter, the caller must be an identity in the <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#account">organization's
        /// management account</a> or a delegated administrator account. The specified account
        /// ID must also be a member account in the same organization. The organization must have
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">all
        /// features enabled</a>, and the organization must have <a href="https://docs.aws.amazon.com/organizations/latest/userguide/using-orgs-trusted-access.html">trusted
        /// access</a> enabled for the Account Management service, and optionally a <a href="https://docs.aws.amazon.com/organizations/latest/userguide/using-orgs-delegated-admin.html">delegated
        /// admin</a> account assigned.
        /// </para>
        ///  <note> 
        /// <para>
        /// The management account can't specify its own <code>AccountId</code>. It must call
        /// the operation in standalone context by not including the <code>AccountId</code> parameter.
        /// </para>
        ///  </note> 
        /// <para>
        /// To call this operation on an account that is not a member of an organization, don't
        /// specify this parameter. Instead, call the operation using an identity belonging to
        /// the account whose contacts you wish to retrieve or modify.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The total number of items to return in the command’s output. If the total number of
        /// items available is more than the value specified, a <code>NextToken</code> is provided
        /// in the command’s output. To resume pagination, provide the <code>NextToken</code>
        /// value in the <code>starting-token</code> argument of a subsequent command. Do not
        /// use the <code>NextToken</code> response element directly outside of the Amazon Web
        /// Services CLI. For usage examples, see <a href="http://docs.aws.amazon.com/cli/latest/userguide/pagination.html">Pagination</a>
        /// in the <i>Amazon Web Services Command Line Interface User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token used to specify where to start paginating. This is the <code>NextToken</code>
        /// from a previously truncated response. For usage examples, see <a href="http://docs.aws.amazon.com/cli/latest/userguide/pagination.html">Pagination</a>
        /// in the <i>Amazon Web Services Command Line Interface User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RegionOptStatusContains. 
        /// <para>
        /// A list of Region statuses (Enabling, Enabled, Disabling, Disabled, Enabled_by_default)
        /// to use to filter the list of Regions for a given account. For example, passing in
        /// a value of ENABLING will only return a list of Regions with a Region status of ENABLING.
        /// </para>
        /// </summary>
        public List<string> RegionOptStatusContains
        {
            get { return this._regionOptStatusContains; }
            set { this._regionOptStatusContains = value; }
        }

        // Check to see if RegionOptStatusContains property is set
        internal bool IsSetRegionOptStatusContains()
        {
            return this._regionOptStatusContains != null && this._regionOptStatusContains.Count > 0; 
        }

    }
}