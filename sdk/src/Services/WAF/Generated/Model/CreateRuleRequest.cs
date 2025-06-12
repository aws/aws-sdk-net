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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRule operation.
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
    /// Creates a <c>Rule</c>, which contains the <c>IPSet</c> objects, <c>ByteMatchSet</c>
    /// objects, and other predicates that identify the requests that you want to block. If
    /// you add more than one predicate to a <c>Rule</c>, a request must match all of the
    /// specifications to be allowed or blocked. For example, suppose that you add the following
    /// to a <c>Rule</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to blocks
    /// requests that satisfy the <c>Rule</c>. For a request to be blocked, it must come from
    /// the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request must
    /// contain the value <c>BadBot</c>.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <c>Rule</c>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create and update the predicates that you want to include in the <c>Rule</c>. For
    /// more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
    /// parameter of a <c>CreateRule</c> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <c>CreateRule</c> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
    /// parameter of an <a>UpdateRule</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <c>UpdateRule</c> request to specify the predicates that you want to include
    /// in the <c>Rule</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. For more information,
    /// see <a>CreateWebACL</a>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateRuleRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _metricName;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for this <c>Rule</c>. The name can
        /// contain only alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128 and
        /// minimum length one. It can't contain whitespace or metric names reserved for AWS WAF,
        /// including "All" and "Default_Action." You can't change the name of the metric after
        /// you create the <c>Rule</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// <c>Rule</c> after you create it.
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

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}