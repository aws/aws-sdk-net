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
    /// Container for the parameters to the UpdateByteMatchSet operation.
    /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
    /// For each <code>ByteMatchTuple</code> object, you specify the following values: 
    /// 
    ///  <ul> <li>Whether to insert or delete the object from the array. If you want to change
    /// a <code>ByteMatchSetUpdate</code> object, you delete the existing object and add a
    /// new one.</li> <li>The part of a web request that you want AWS WAF to inspect, such
    /// as a query string or the value of the <code>User-Agent</code> header. </li> <li>The
    /// bytes (typically a string that corresponds with ASCII characters) that you want AWS
    /// WAF to look for. For more information, including how you specify the values for the
    /// AWS WAF API and the AWS CLI or SDKs, see <code>TargetString</code> in the <a>ByteMatchTuple</a>
    /// data type. </li> <li>Where to look, such as at the beginning or the end of a query
    /// string.</li> <li>Whether to perform any conversions on the request, such as converting
    /// it to lowercase, before inspecting it for the specified string.</li> </ul> 
    /// <para>
    /// For example, you can add a <code>ByteMatchSetUpdate</code> object that matches web
    /// requests in which <code>User-Agent</code> headers contain the string <code>BadBot</code>.
    /// You can then configure AWS WAF to block those requests.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li>Create a <code>ByteMatchSet.</code> For more information, see <a>CreateByteMatchSet</a>.</li>
    /// <li>Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <code>UpdateByteMatchSet</code> request.</li> <li>Submit an <code>UpdateByteMatchSet</code>
    /// request to specify the part of the request that you want AWS WAF to inspect (for example,
    /// the header or the URI) and the value that you want AWS WAF to watch for.</li> </ol>
    /// 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateByteMatchSetRequest : AmazonWAFRequest
    {
        private string _byteMatchSetId;
        private string _changeToken;
        private List<ByteMatchSetUpdate> _updates = new List<ByteMatchSetUpdate>();

        /// <summary>
        /// Gets and sets the property ByteMatchSetId. 
        /// <para>
        /// The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to update.
        /// <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.
        /// </para>
        /// </summary>
        public string ByteMatchSetId
        {
            get { return this._byteMatchSetId; }
            set { this._byteMatchSetId = value; }
        }

        // Check to see if ByteMatchSetId property is set
        internal bool IsSetByteMatchSetId()
        {
            return this._byteMatchSetId != null;
        }

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
        /// An array of <code>ByteMatchSetUpdate</code> objects that you want to insert into or
        /// delete from a <a>ByteMatchSet</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> <a>ByteMatchSetUpdate</a>: Contains <code>Action</code> and <code>ByteMatchTuple</code>
        /// </li> <li> <a>ByteMatchTuple</a>: Contains <code>FieldToMatch</code>, <code>PositionalConstraint</code>,
        /// <code>TargetString</code>, and <code>TextTransformation</code> </li> <li> <a>FieldToMatch</a>:
        /// Contains <code>Data</code> and <code>Type</code> </li> </ul>
        /// </summary>
        public List<ByteMatchSetUpdate> Updates
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