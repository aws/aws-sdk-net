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
    /// Container for the parameters to the ListIPSets operation.
    /// Returns an array of <a>IPSetSummary</a> objects in the response.
    /// </summary>
    public partial class ListIPSetsRequest : AmazonWAFRegionalRequest
    {
        private int? _limit;
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies the number of <code>IPSet</code> objects that you want AWS WAF to return
        /// for this request. If you have more <code>IPSet</code> objects than the number you
        /// specify for <code>Limit</code>, the response includes a <code>NextMarker</code> value
        /// that you can use to get another batch of <code>IPSet</code> objects.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If you specify a value for <code>Limit</code> and you have more <code>IPSets</code>
        /// than the value of <code>Limit</code>, AWS WAF returns a <code>NextMarker</code> value
        /// in the response that allows you to list another group of <code>IPSets</code>. For
        /// the second and subsequent <code>ListIPSets</code> requests, specify the value of <code>NextMarker</code>
        /// from the previous response to get information about another batch of <code>ByteMatchSets</code>.
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

    }
}