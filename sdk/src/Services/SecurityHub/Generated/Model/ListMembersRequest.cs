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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListMembers operation.
    /// Lists details about all member accounts for the current Security Hub administrator
    /// account.
    /// 
    ///  
    /// <para>
    /// The results include both member accounts that belong to an organization and member
    /// accounts that were invited manually.
    /// </para>
    /// </summary>
    public partial class ListMembersRequest : AmazonSecurityHubRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private bool? _onlyAssociated;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in the response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// The token that is required for pagination. On your first call to the <c>ListMembers</c>
        /// operation, set the value of this parameter to <c>NULL</c>.
        /// </para>
        ///  
        /// <para>
        /// For subsequent calls to the operation, to continue listing data, set the value of
        /// this parameter to the value returned from the previous response.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OnlyAssociated. 
        /// <para>
        /// Specifies which member accounts to include in the response based on their relationship
        /// status with the administrator account. The default value is <c>TRUE</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>OnlyAssociated</c> is set to <c>TRUE</c>, the response includes member accounts
        /// whose relationship status with the administrator account is set to <c>ENABLED</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>OnlyAssociated</c> is set to <c>FALSE</c>, the response includes all existing
        /// member accounts. 
        /// </para>
        /// </summary>
        public bool? OnlyAssociated
        {
            get { return this._onlyAssociated; }
            set { this._onlyAssociated = value; }
        }

        // Check to see if OnlyAssociated property is set
        internal bool IsSetOnlyAssociated()
        {
            return this._onlyAssociated.HasValue; 
        }

    }
}