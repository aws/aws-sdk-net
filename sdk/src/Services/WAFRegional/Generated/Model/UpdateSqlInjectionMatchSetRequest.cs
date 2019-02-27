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
    /// Container for the parameters to the UpdateSqlInjectionMatchSet operation.
    /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
    /// For each <code>SqlInjectionMatchTuple</code> object, you specify the following values:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>Action</code>: Whether to insert the object into or delete the object from
    /// the array. To change a <code>SqlInjectionMatchTuple</code>, you delete the existing
    /// object and add a new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>FieldToMatch</code>: The part of web requests that you want AWS WAF to inspect
    /// and, if you want AWS WAF to inspect a header or custom query parameter, the name of
    /// the header or parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TextTransformation</code>: Which text transformation, if any, to perform on
    /// the web request before inspecting the request for snippets of malicious SQL code.
    /// </para>
    ///  
    /// <para>
    /// You can only specify a single type of TextTransformation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You use <code>SqlInjectionMatchSet</code> objects to specify which CloudFront requests
    /// that you want to allow, block, or count. For example, if you're receiving requests
    /// that contain snippets of SQL code in the query string and you want to block the requests,
    /// you can create a <code>SqlInjectionMatchSet</code> with the applicable settings, and
    /// then configure AWS WAF to block the requests. 
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
    /// steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <a>UpdateIPSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <code>UpdateSqlInjectionMatchSet</code> request to specify the parts of
    /// web requests that you want AWS WAF to inspect for snippets of SQL code.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateSqlInjectionMatchSetRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _sqlInjectionMatchSetId;
        private List<SqlInjectionMatchSetUpdate> _updates = new List<SqlInjectionMatchSetUpdate>();

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
        /// Gets and sets the property SqlInjectionMatchSetId. 
        /// <para>
        /// The <code>SqlInjectionMatchSetId</code> of the <code>SqlInjectionMatchSet</code> that
        /// you want to update. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a>
        /// and by <a>ListSqlInjectionMatchSets</a>.
        /// </para>
        /// </summary>
        public string SqlInjectionMatchSetId
        {
            get { return this._sqlInjectionMatchSetId; }
            set { this._sqlInjectionMatchSetId = value; }
        }

        // Check to see if SqlInjectionMatchSetId property is set
        internal bool IsSetSqlInjectionMatchSetId()
        {
            return this._sqlInjectionMatchSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <code>SqlInjectionMatchSetUpdate</code> objects that you want to insert
        /// into or delete from a <a>SqlInjectionMatchSet</a>. For more information, see the applicable
        /// data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>SqlInjectionMatchSetUpdate</a>: Contains <code>Action</code> and <code>SqlInjectionMatchTuple</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SqlInjectionMatchTuple</a>: Contains <code>FieldToMatch</code> and <code>TextTransformation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<SqlInjectionMatchSetUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

    }
}