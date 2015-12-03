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
    /// Container for the parameters to the DeleteIPSet operation.
    /// Permanently deletes an <a>IPSet</a>. You can't delete an <code>IPSet</code> if it's
    /// still used in any <code>Rules</code> or if it still includes any IP addresses.
    /// 
    ///  
    /// <para>
    /// If you just want to remove an <code>IPSet</code> from a <code>Rule</code>, use <a>UpdateRule</a>.
    /// </para>
    ///  
    /// <para>
    /// To permanently delete an <code>IPSet</code> from AWS WAF, perform the following steps:
    /// </para>
    ///  <ol> <li>Update the <code>IPSet</code> to remove IP address ranges, if any. For more
    /// information, see <a>UpdateIPSet</a>.</li> <li>Use <a>GetChangeToken</a> to get the
    /// change token that you provide in the <code>ChangeToken</code> parameter of a <code>DeleteIPSet</code>
    /// request.</li> <li>Submit a <code>DeleteIPSet</code> request.</li> </ol>
    /// </summary>
    public partial class DeleteIPSetRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _ipSetId;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
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

        /// <summary>
        /// Gets and sets the property IPSetId. 
        /// <para>
        /// The <code>IPSetId</code> of the <a>IPSet</a> that you want to delete. <code>IPSetId</code>
        /// is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.
        /// </para>
        /// </summary>
        public string IPSetId
        {
            get { return this._ipSetId; }
            set { this._ipSetId = value; }
        }

        // Check to see if IPSetId property is set
        internal bool IsSetIPSetId()
        {
            return this._ipSetId != null;
        }

    }
}