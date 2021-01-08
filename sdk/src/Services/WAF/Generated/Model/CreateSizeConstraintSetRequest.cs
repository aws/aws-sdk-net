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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSizeConstraintSet operation.
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates a <code>SizeConstraintSet</code>. You then use <a>UpdateSizeConstraintSet</a>
    /// to identify the part of a web request that you want AWS WAF to check for length, such
    /// as the length of the <code>User-Agent</code> header or the length of the query string.
    /// For example, you can create a <code>SizeConstraintSet</code> that matches any requests
    /// that have a query string that is longer than 100 bytes. You can then configure AWS
    /// WAF to reject those requests.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <code>SizeConstraintSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of a <code>CreateSizeConstraintSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <code>CreateSizeConstraintSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <code>UpdateSizeConstraintSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <a>UpdateSizeConstraintSet</a> request to specify the part of the request
    /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
    /// that you want AWS WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateSizeConstraintSetRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _name;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>SizeConstraintSet</a>. You can't change <code>Name</code>
        /// after you create a <code>SizeConstraintSet</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}