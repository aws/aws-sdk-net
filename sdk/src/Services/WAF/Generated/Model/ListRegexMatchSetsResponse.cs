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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// This is the response object from the ListRegexMatchSets operation.
    /// </summary>
    public partial class ListRegexMatchSetsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<RegexMatchSetSummary> _regexMatchSets = new List<RegexMatchSetSummary>();

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If you have more <code>RegexMatchSet</code> objects than the number that you specified
        /// for <code>Limit</code> in the request, the response includes a <code>NextMarker</code>
        /// value. To list more <code>RegexMatchSet</code> objects, submit another <code>ListRegexMatchSets</code>
        /// request, and specify the <code>NextMarker</code> value from the response in the <code>NextMarker</code>
        /// value in the next request.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property RegexMatchSets. 
        /// <para>
        /// An array of <a>RegexMatchSetSummary</a> objects.
        /// </para>
        /// </summary>
        public List<RegexMatchSetSummary> RegexMatchSets
        {
            get { return this._regexMatchSets; }
            set { this._regexMatchSets = value; }
        }

        // Check to see if RegexMatchSets property is set
        internal bool IsSetRegexMatchSets()
        {
            return this._regexMatchSets != null && this._regexMatchSets.Count > 0; 
        }

    }
}