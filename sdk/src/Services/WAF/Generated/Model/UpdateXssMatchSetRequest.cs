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
    /// Container for the parameters to the UpdateXssMatchSet operation.
    /// Inserts or deletes <a>XssMatchTuple</a> objects (filters) in an <a>XssMatchSet</a>.
    /// For each <code>XssMatchTuple</code> object, you specify the following values:
    /// 
    ///  <ul> <li><code>Action</code>: Whether to insert the object into or delete the object
    /// from the array. To change a <code>XssMatchTuple</code>, you delete the existing object
    /// and add a new one.</li> <li><code>FieldToMatch</code>: The part of web requests that
    /// you want AWS WAF to inspect and, if you want AWS WAF to inspect a header, the name
    /// of the header.</li> <li><code>TextTransformation</code>: Which text transformation,
    /// if any, to perform on the web request before inspecting the request for cross-site
    /// scripting attacks.</li> </ul> 
    /// <para>
    /// You use <code>XssMatchSet</code> objects to specify which CloudFront requests you
    /// want to allow, block, or count. For example, if you're receiving requests that contain
    /// cross-site scripting attacks in the request body and you want to block the requests,
    /// you can create an <code>XssMatchSet</code> with the applicable settings, and then
    /// configure AWS WAF to block the requests. 
    /// </para>
    ///  
    /// <para>
    /// To create and configure an <code>XssMatchSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li>Submit a <a>CreateXssMatchSet</a> request.</li> <li>Use <a>GetChangeToken</a>
    /// to get the change token that you provide in the <code>ChangeToken</code> parameter
    /// of an <a>UpdateIPSet</a> request.</li> <li>Submit an <code>UpdateXssMatchSet</code>
    /// request to specify the parts of web requests that you want AWS WAF to inspect for
    /// cross-site scripting attacks.</li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateXssMatchSetRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private List<XssMatchSetUpdate> _updates = new List<XssMatchSetUpdate>();
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
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <code>XssMatchSetUpdate</code> objects that you want to insert into or
        /// delete from a <a>XssMatchSet</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li><a>XssMatchSetUpdate</a>: Contains <code>Action</code> and <code>XssMatchTuple</code></li>
        /// <li><a>XssMatchTuple</a>: Contains <code>FieldToMatch</code> and <code>TextTransformation</code></li>
        /// <li><a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code></li> </ul>
        /// </summary>
        public List<XssMatchSetUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property XssMatchSetId. 
        /// <para>
        /// The <code>XssMatchSetId</code> of the <code>XssMatchSet</code> that you want to update.
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