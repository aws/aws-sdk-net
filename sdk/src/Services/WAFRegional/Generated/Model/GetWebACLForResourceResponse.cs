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
    /// This is the response object from the GetWebACLForResource operation.
    /// </summary>
    public partial class GetWebACLForResourceResponse : AmazonWebServiceResponse
    {
        private WebACLSummary _webACLSummary;

        /// <summary>
        /// Gets and sets the property WebACLSummary. 
        /// <para>
        /// Information about the web ACL that you specified in the <code>GetWebACLForResource</code>
        /// request. If there is no associated resource, a null WebACLSummary is returned.
        /// </para>
        /// </summary>
        public WebACLSummary WebACLSummary
        {
            get { return this._webACLSummary; }
            set { this._webACLSummary = value; }
        }

        // Check to see if WebACLSummary property is set
        internal bool IsSetWebACLSummary()
        {
            return this._webACLSummary != null;
        }

    }
}