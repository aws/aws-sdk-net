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
    /// Container for the parameters to the CreateWebACL operation.
    /// Creates a <code>WebACL</code>, which contains the <code>Rules</code> that identify
    /// the CloudFront web requests that you want to allow, block, or count. AWS WAF evaluates
    /// <code>Rules</code> in order based on the value of <code>Priority</code> for each <code>Rule</code>.
    /// 
    ///  
    /// <para>
    /// You also specify a default action, either <code>ALLOW</code> or <code>BLOCK</code>.
    /// If a web request doesn't match any of the <code>Rules</code> in a <code>WebACL</code>,
    /// AWS WAF responds to the request with the default action. 
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <code>WebACL</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create and update the <code>ByteMatchSet</code> objects and other predicates that
    /// you want to include in <code>Rules</code>. For more information, see <a>CreateByteMatchSet</a>,
    /// <a>UpdateByteMatchSet</a>, <a>CreateIPSet</a>, <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>,
    /// and <a>UpdateSqlInjectionMatchSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create and update the <code>Rules</code> that you want to include in the <code>WebACL</code>.
    /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of a <code>CreateWebACL</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <code>CreateWebACL</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <a>UpdateWebACL</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <a>UpdateWebACL</a> request to specify the <code>Rules</code> that you want
    /// to include in the <code>WebACL</code>, to specify the default action, and to associate
    /// the <code>WebACL</code> with a CloudFront distribution.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
    /// WAF Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateWebACLRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private WafAction _defaultAction;
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
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The action that you want AWS WAF to take when a request doesn't match the criteria
        /// specified in any of the <code>Rule</code> objects that are associated with the <code>WebACL</code>.
        /// </para>
        /// </summary>
        public WafAction DefaultAction
        {
            get { return this._defaultAction; }
            set { this._defaultAction = value; }
        }

        // Check to see if DefaultAction property is set
        internal bool IsSetDefaultAction()
        {
            return this._defaultAction != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for this <code>WebACL</code>. The name
        /// can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't contain white
        /// space. You can't change <code>MetricName</code> after you create the <code>WebACL</code>.
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
        /// A friendly name or description of the <a>WebACL</a>. You can't change <code>Name</code>
        /// after you create the <code>WebACL</code>.
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