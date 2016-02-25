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
    /// This is the response object from the ListWebACLs operation.
    /// </summary>
    public partial class ListWebACLsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<WebACLSummary> _webACLs = new List<WebACLSummary>();

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If you have more <code>WebACL</code> objects than the number that you specified for
        /// <code>Limit</code> in the request, the response includes a <code>NextMarker</code>
        /// value. To list more <code>WebACL</code> objects, submit another <code>ListWebACLs</code>
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
        /// Gets and sets the property WebACLs. 
        /// <para>
        /// An array of <a>WebACLSummary</a> objects.
        /// </para>
        /// </summary>
        public List<WebACLSummary> WebACLs
        {
            get { return this._webACLs; }
            set { this._webACLs = value; }
        }

        // Check to see if WebACLs property is set
        internal bool IsSetWebACLs()
        {
            return this._webACLs != null && this._webACLs.Count > 0; 
        }

    }
}