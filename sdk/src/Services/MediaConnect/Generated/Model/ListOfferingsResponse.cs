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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// This is the response object from the ListOfferings operation.
    /// </summary>
    public partial class ListOfferingsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Offering> _offerings = new List<Offering>();

        /// <summary>
        /// Gets and sets the property NextToken. The token that identifies which batch of results
        /// that you want to see. For example, you submit a ListOfferings request with MaxResults
        /// set at 5. The service returns the first batch of results (up to 5) and a NextToken
        /// value. To see the next batch of results, you can submit the ListOfferings request
        /// a second time and specify the NextToken value.
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
        /// Gets and sets the property Offerings. A list of offerings that are available to this
        /// account in the current AWS Region.
        /// </summary>
        public List<Offering> Offerings
        {
            get { return this._offerings; }
            set { this._offerings = value; }
        }

        // Check to see if Offerings property is set
        internal bool IsSetOfferings()
        {
            return this._offerings != null && this._offerings.Count > 0; 
        }

    }
}