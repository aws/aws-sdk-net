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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// This is the response object from the ListFraudsters operation.
    /// </summary>
    public partial class ListFraudstersResponse : AmazonWebServiceResponse
    {
        private List<FraudsterSummary> _fraudsterSummaries = new List<FraudsterSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FraudsterSummaries. 
        /// <para>
        /// A list that contains details about each fraudster in the Amazon Web Services account.
        /// 
        /// </para>
        /// </summary>
        public List<FraudsterSummary> FraudsterSummaries
        {
            get { return this._fraudsterSummaries; }
            set { this._fraudsterSummaries = value; }
        }

        // Check to see if FraudsterSummaries property is set
        internal bool IsSetFraudsterSummaries()
        {
            return this._fraudsterSummaries != null && this._fraudsterSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <code>NextToken</code> is returned, there are more results available. The value
        /// of <code>NextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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