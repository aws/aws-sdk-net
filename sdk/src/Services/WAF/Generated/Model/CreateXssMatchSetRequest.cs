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
    /// Container for the parameters to the CreateXssMatchSet operation.
    /// Creates an <a>XssMatchSet</a>, which you use to allow, block, or count requests that
    /// contain cross-site scripting attacks in the specified part of web requests. AWS WAF
    /// searches for character sequences that are likely to be malicious strings.
    /// 
    ///  
    /// <para>
    /// To create and configure an <code>XssMatchSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li>Use <a>GetChangeToken</a> to get the change token that you provide in the
    /// <code>ChangeToken</code> parameter of a <code>CreateXssMatchSet</code> request.</li>
    /// <li>Submit a <code>CreateXssMatchSet</code> request.</li> <li>Use <code>GetChangeToken</code>
    /// to get the change token that you provide in the <code>ChangeToken</code> parameter
    /// of an <a>UpdateXssMatchSet</a> request.</li> <li>Submit an <a>UpdateXssMatchSet</a>
    /// request to specify the parts of web requests in which you want to allow, block, or
    /// count cross-site scripting attacks.</li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateXssMatchSetRequest : AmazonWAFRequest
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
        /// A friendly name or description for the <a>XssMatchSet</a> that you're creating. You
        /// can't change <code>Name</code> after you create the <code>XssMatchSet</code>.
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