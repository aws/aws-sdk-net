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
    /// This is the response object from the ListAdminAccountsForOrganization operation.
    /// </summary>
    public partial class ListAdminAccountsForOrganizationResponse : AmazonWebServiceResponse
    {
        private List<AdminAccountSummary> _adminAccounts = AWSConfigs.InitializeCollections ? new List<AdminAccountSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AdminAccounts. 
        /// <para>
        /// A list of Firewall Manager administrator accounts within the organization that were
        /// onboarded as administrators by <a>AssociateAdminAccount</a> or <a>PutAdminAccount</a>.
        /// </para>
        /// </summary>
        public List<AdminAccountSummary> AdminAccounts
        {
            get { return this._adminAccounts; }
            set { this._adminAccounts = value; }
        }

        // Check to see if AdminAccounts property is set
        internal bool IsSetAdminAccounts()
        {
            return this._adminAccounts != null && (this._adminAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When you request a list of objects with a <c>MaxResults</c> setting, if the number
        /// of objects that are still available for retrieval exceeds the maximum you requested,
        /// Firewall Manager returns a <c>NextToken</c> value in the response. To retrieve the
        /// next batch of objects, use the token returned from the prior request in your next
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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

    }
}