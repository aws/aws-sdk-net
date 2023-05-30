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
    /// This is the response object from the ListDataLakeExceptions operation.
    /// </summary>
    public partial class ListDataLakeExceptionsResponse : AmazonWebServiceResponse
    {
        private List<DataLakeException> _exceptions = new List<DataLakeException>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Exceptions. 
        /// <para>
        /// Lists the failures that cannot be retried in the current Region.
        /// </para>
        /// </summary>
        public List<DataLakeException> Exceptions
        {
            get { return this._exceptions; }
            set { this._exceptions = value; }
        }

        // Check to see if Exceptions property is set
        internal bool IsSetExceptions()
        {
            return this._exceptions != null && this._exceptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// List if there are more results available. The value of nextToken is a unique pagination
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