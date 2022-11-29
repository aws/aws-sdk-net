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
    /// This is the response object from the ListDatalakeExceptions operation.
    /// </summary>
    public partial class ListDatalakeExceptionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<FailuresResponse> _nonRetryableFailures = new List<FailuresResponse>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// List if there are more results available. if nextToken is returned, You can make the
        /// call again using the returned token to retrieve the next page
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
        /// Gets and sets the property NonRetryableFailures. 
        /// <para>
        /// Lists the non-retryable failures in the current region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FailuresResponse> NonRetryableFailures
        {
            get { return this._nonRetryableFailures; }
            set { this._nonRetryableFailures = value; }
        }

        // Check to see if NonRetryableFailures property is set
        internal bool IsSetNonRetryableFailures()
        {
            return this._nonRetryableFailures != null && this._nonRetryableFailures.Count > 0; 
        }

    }
}