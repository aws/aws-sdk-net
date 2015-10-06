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
    /// Container for the parameters to the CreateRule operation.
    /// Creates a <code>Rule</code>, which contains the <code>IPSet</code> objects, <code>ByteMatchSet</code>
    /// objects, and other predicates that identify the requests that you want to block. If
    /// you add more than one predicate to a <code>Rule</code>, a request must match all of
    /// the specifications to be allowed or blocked. For example, suppose you add the following
    /// to a <code>Rule</code>:
    /// 
    ///  <ul> <li>An <code>IPSet</code> that matches the IP address <code>192.0.2.44/32</code>
    /// </li> <li>A <code>ByteMatchSet</code> that matches <code>BadBot</code> in the <code>User-Agent</code>
    /// header</li> </ul> 
    /// <para>
    /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
    /// to blocks requests that satisfy the <code>Rule</code>. For a request to be blocked,
    /// it must come from the IP address 192.0.2.44 <i>and</i> the <code>User-Agent</code>
    /// header in the request must contain the value <code>BadBot</code>.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <code>Rule</code>, perform the following steps:
    /// </para>
    ///  <ol> <li>Create and update the predicates that you want to include in the <code>Rule</code>.
    /// For more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.</li>
    /// <li>Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of a <code>CreateRule</code> request.</li> <li>Submit a <code>CreateRule</code>
    /// request.</li> <li>Use <code>GetChangeToken</code> to get the change token that you
    /// provide in the <code>ChangeToken</code> parameter of an <a>UpdateRule</a> request.</li>
    /// <li>Submit an <code>UpdateRule</code> request to specify the predicates that you want
    /// to include in the <code>Rule</code>.</li> <li>Create and update a <code>WebACL</code>
    /// that contains the <code>Rule</code>. For more information, see <a>CreateWebACL</a>.</li>
    /// </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateRuleRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _metricName;
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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for this <code>Rule</code>. The name
        /// can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't contain whitespace.
        /// You can't change the name of the metric after you create the <code>Rule</code>.
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>Rule</a>. You can't change the name of a
        /// <code>Rule</code> after you create it.
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