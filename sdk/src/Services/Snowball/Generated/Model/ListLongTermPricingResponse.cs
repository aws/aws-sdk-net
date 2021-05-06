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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the ListLongTermPricing operation.
    /// </summary>
    public partial class ListLongTermPricingResponse : AmazonWebServiceResponse
    {
        private List<LongTermPricingListEntry> _longTermPricingEntries = new List<LongTermPricingListEntry>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LongTermPricingEntries. 
        /// <para>
        /// Each <code>LongTermPricingEntry</code> object contains a status, ID, and other information
        /// about the <code>LongTermPricing</code> type. 
        /// </para>
        /// </summary>
        public List<LongTermPricingListEntry> LongTermPricingEntries
        {
            get { return this._longTermPricingEntries; }
            set { this._longTermPricingEntries = value; }
        }

        // Check to see if LongTermPricingEntries property is set
        internal bool IsSetLongTermPricingEntries()
        {
            return this._longTermPricingEntries != null && this._longTermPricingEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Because HTTP requests are stateless, this is the starting point for your next list
        /// of returned <code>ListLongTermPricing</code> list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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