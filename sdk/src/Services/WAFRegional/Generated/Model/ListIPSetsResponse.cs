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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// This is the response object from the ListIPSets operation.
    /// </summary>
    public partial class ListIPSetsResponse : AmazonWebServiceResponse
    {
        private List<IPSetSummary> _ipSets = new List<IPSetSummary>();
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property IPSets. 
        /// <para>
        /// An array of <a>IPSetSummary</a> objects.
        /// </para>
        /// </summary>
        public List<IPSetSummary> IPSets
        {
            get { return this._ipSets; }
            set { this._ipSets = value; }
        }

        // Check to see if IPSets property is set
        internal bool IsSetIPSets()
        {
            return this._ipSets != null && this._ipSets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// To list more <code>IPSet</code> objects, submit another <code>ListIPSets</code> request,
        /// and in the next request use the <code>NextMarker</code> response value as the <code>NextMarker</code>
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
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