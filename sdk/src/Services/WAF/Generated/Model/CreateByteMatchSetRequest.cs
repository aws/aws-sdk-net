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
    /// Container for the parameters to the CreateByteMatchSet operation.
    /// Creates a <code>ByteMatchSet</code>. You then use <a>UpdateByteMatchSet</a> to identify
    /// the part of a web request that you want AWS WAF to inspect, such as the values of
    /// the <code>User-Agent</code> header or the query string. For example, you can create
    /// a <code>ByteMatchSet</code> that matches any requests with <code>User-Agent</code>
    /// headers that contain the string <code>BadBot</code>. You can then configure AWS WAF
    /// to reject those requests.
    /// 
    ///  
    /// <para>
    /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of a <code>CreateByteMatchSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <code>CreateByteMatchSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <code>UpdateByteMatchSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <a>UpdateByteMatchSet</a> request to specify the part of the request that
    /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
    /// you want AWS WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateByteMatchSetRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _name;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>ByteMatchSet</a>. You can't change <code>Name</code>
        /// after you create a <code>ByteMatchSet</code>.
        /// </para>
        /// </summary>
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