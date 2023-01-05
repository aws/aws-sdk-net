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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the GetDatalakeStatus operation.
    /// Retrieves a snapshot of the current Region, including whether Amazon Security Lake
    /// is enabled for those accounts and which sources Security Lake is collecting data from.
    /// </summary>
    public partial class GetDatalakeStatusRequest : AmazonSecurityLakeRequest
    {
        private List<string> _accountSet = new List<string>();
        private int? _maxAccountResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountSet. 
        /// <para>
        /// The Amazon Web Services account ID for which a static snapshot of the current Amazon
        /// Web Services Region, including enabled accounts and log sources, is retrieved.
        /// </para>
        /// </summary>
        public List<string> AccountSet
        {
            get { return this._accountSet; }
            set { this._accountSet = value; }
        }

        // Check to see if AccountSet property is set
        internal bool IsSetAccountSet()
        {
            return this._accountSet != null && this._accountSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxAccountResults. 
        /// <para>
        /// The maximum limit of accounts for which the static snapshot of the current Region,
        /// including enabled accounts and log sources, is retrieved.
        /// </para>
        /// </summary>
        public int MaxAccountResults
        {
            get { return this._maxAccountResults.GetValueOrDefault(); }
            set { this._maxAccountResults = value; }
        }

        // Check to see if MaxAccountResults property is set
        internal bool IsSetMaxAccountResults()
        {
            return this._maxAccountResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Lists if there are more results available. The value of nextToken is a unique pagination
        /// token for each page. Repeat the call using the returned token to retrieve the next
        /// page. Keep all other arguments unchanged. 
        /// </para>
        ///  
        /// <para>
        /// Each pagination token expires after 24 hours. Using an expired pagination token will
        /// return an HTTP 400 InvalidToken error.
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

    }
}