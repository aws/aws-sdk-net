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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// This is the response object from the ListRateBasedRules operation.
    /// </summary>
    public partial class ListRateBasedRulesResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<RuleSummary> _rules = new List<RuleSummary>();

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If you have more <code>Rules</code> than the number that you specified for <code>Limit</code>
        /// in the request, the response includes a <code>NextMarker</code> value. To list more
        /// <code>Rules</code>, submit another <code>ListRateBasedRules</code> request, and specify
        /// the <code>NextMarker</code> value from the response in the <code>NextMarker</code>
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
        /// Gets and sets the property Rules. 
        /// <para>
        /// An array of <a>RuleSummary</a> objects.
        /// </para>
        /// </summary>
        public List<RuleSummary> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

    }
}