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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the response returned by the <c>GetUpgradeHistory</c> operation.
    /// </summary>
    public partial class GetUpgradeHistoryResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<UpgradeHistory> _upgradeHistories = AWSConfigs.InitializeCollections ? new List<UpgradeHistory>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When <c>nextToken</c> is returned, there are more results available. The value of
        /// <c>nextToken</c> is a unique pagination token for each page. Send the request again
        /// using the returned token to retrieve the next page.
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
        /// Gets and sets the property UpgradeHistories. 
        /// <para>
        /// A list of objects corresponding to each upgrade or upgrade eligibility check performed
        /// on a domain.
        /// </para>
        /// </summary>
        public List<UpgradeHistory> UpgradeHistories
        {
            get { return this._upgradeHistories; }
            set { this._upgradeHistories = value; }
        }

        // Check to see if UpgradeHistories property is set
        internal bool IsSetUpgradeHistories()
        {
            return this._upgradeHistories != null && (this._upgradeHistories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}