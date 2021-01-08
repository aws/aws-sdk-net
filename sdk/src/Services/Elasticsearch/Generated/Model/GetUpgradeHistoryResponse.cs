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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for response returned by <code> <a>GetUpgradeHistory</a> </code> operation.
    /// </summary>
    public partial class GetUpgradeHistoryResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<UpgradeHistory> _upgradeHistories = new List<UpgradeHistory>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token that needs to be supplied to the next call to get the next page of
        /// results
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
        ///  A list of <code> <a>UpgradeHistory</a> </code> objects corresponding to each Upgrade
        /// or Upgrade Eligibility Check performed on a domain returned as part of <code> <a>GetUpgradeHistoryResponse</a>
        /// </code> object. 
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
            return this._upgradeHistories != null && this._upgradeHistories.Count > 0; 
        }

    }
}