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
    /// Container for the parameters to the GetChangeTokenStatus operation.
    /// Returns the status of a <code>ChangeToken</code> that you got by calling <a>GetChangeToken</a>.
    /// <code>ChangeTokenStatus</code> is one of the following values:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>PROVISIONED</code>: You requested the change token by calling <code>GetChangeToken</code>,
    /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PENDING</code>: AWS WAF is propagating the create, update, or delete request
    /// to all AWS WAF servers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>IN_SYNC</code>: Propagation is complete.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetChangeTokenStatusRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The change token for which you want to get the status. This change token was previously
        /// returned in the <code>GetChangeToken</code> response.
        /// </para>
        /// </summary>
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

    }
}