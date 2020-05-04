/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the ListFaqs operation.
    /// </summary>
    public partial class ListFaqsResponse : AmazonWebServiceResponse
    {
        private List<FaqSummary> _faqSummaryItems = new List<FaqSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FaqSummaryItems. 
        /// <para>
        /// information about the FAQs associated with the specified index.
        /// </para>
        /// </summary>
        public List<FaqSummary> FaqSummaryItems
        {
            get { return this._faqSummaryItems; }
            set { this._faqSummaryItems = value; }
        }

        // Check to see if FaqSummaryItems property is set
        internal bool IsSetFaqSummaryItems()
        {
            return this._faqSummaryItems != null && this._faqSummaryItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>ListFaqs</code> operation returns a page of FAQs at a time. The maximum
        /// size of the page is set by the <code>MaxResults</code> parameter. If there are more
        /// jobs in the list than the page size, Amazon Kendra returns the <code>NextPage</code>
        /// token. Include the token in the next request to the <code>ListFaqs</code> operation
        /// to return the next page of FAQs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
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