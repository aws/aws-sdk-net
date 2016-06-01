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
    /// Container for the parameters to the DeleteXssMatchSet operation.
    /// Permanently deletes an <a>XssMatchSet</a>. You can't delete an <code>XssMatchSet</code>
    /// if it's still used in any <code>Rules</code> or if it still contains any <a>XssMatchTuple</a>
    /// objects.
    /// 
    ///  
    /// <para>
    /// If you just want to remove an <code>XssMatchSet</code> from a <code>Rule</code>, use
    /// <a>UpdateRule</a>.
    /// </para>
    ///  
    /// <para>
    /// To permanently delete an <code>XssMatchSet</code> from AWS WAF, perform the following
    /// steps:
    /// </para>
    ///  <ol> <li>Update the <code>XssMatchSet</code> to remove filters, if any. For more
    /// information, see <a>UpdateXssMatchSet</a>.</li> <li>Use <a>GetChangeToken</a> to get
    /// the change token that you provide in the <code>ChangeToken</code> parameter of a <code>DeleteXssMatchSet</code>
    /// request.</li> <li>Submit a <code>DeleteXssMatchSet</code> request.</li> </ol>
    /// </summary>
    public partial class DeleteXssMatchSetRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _xssMatchSetId;

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
        /// Gets and sets the property XssMatchSetId. 
        /// <para>
        /// The <code>XssMatchSetId</code> of the <a>XssMatchSet</a> that you want to delete.
        /// <code>XssMatchSetId</code> is returned by <a>CreateXssMatchSet</a> and by <a>ListXssMatchSets</a>.
        /// </para>
        /// </summary>
        public string XssMatchSetId
        {
            get { return this._xssMatchSetId; }
            set { this._xssMatchSetId = value; }
        }

        // Check to see if XssMatchSetId property is set
        internal bool IsSetXssMatchSetId()
        {
            return this._xssMatchSetId != null;
        }

    }
}