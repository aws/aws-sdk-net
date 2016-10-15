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
    /// This is the response object from the GetWebACL operation.
    /// </summary>
    public partial class GetWebACLResponse : AmazonWebServiceResponse
    {
        private WebACL _webACL;

        /// <summary>
        /// Gets and sets the property WebACL. 
        /// <para>
        /// Information about the <a>WebACL</a> that you specified in the <code>GetWebACL</code>
        /// request. For more information, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>WebACL</a>: Contains <code>DefaultAction</code>, <code>MetricName</code>, <code>Name</code>,
        /// an array of <code>Rule</code> objects, and <code>WebACLId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DefaultAction</code> (Data type is <a>WafAction</a>): Contains <code>Type</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Rules</code>: Contains an array of <code>ActivatedRule</code> objects, which
        /// contain <code>Action</code>, <code>Priority</code>, and <code>RuleId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Action</code>: Contains <code>Type</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WebACL WebACL
        {
            get { return this._webACL; }
            set { this._webACL = value; }
        }

        // Check to see if WebACL property is set
        internal bool IsSetWebACL()
        {
            return this._webACL != null;
        }

    }
}