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
    /// Contains the <c>Rules</c> that identify the requests that you want to allow, block,
    /// or count. In a <c>WebACL</c>, you also specify a default action (<c>ALLOW</c> or <c>BLOCK</c>),
    /// and the action for each <c>Rule</c> that you add to a <c>WebACL</c>, for example,
    /// block requests from specified IP addresses or block requests from specified referrers.
    /// You also associate the <c>WebACL</c> with a CloudFront distribution to identify the
    /// requests that you want AWS WAF to filter. If you add more than one <c>Rule</c> to
    /// a <c>WebACL</c>, a request needs to match only one of the specifications to be allowed,
    /// blocked, or counted. For more information, see <a>UpdateWebACL</a>.
    /// </para>
    /// </summary>
    public partial class WebACL
    {
        private WafAction _defaultAction;
        private string _metricName;
        private string _name;
        private List<ActivatedRule> _rules = AWSConfigs.InitializeCollections ? new List<ActivatedRule>() : null;
        private string _webACLArn;
        private string _webACLId;

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The action to perform if none of the <c>Rules</c> contained in the <c>WebACL</c> match.
        /// The action is specified by the <a>WafAction</a> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A friendly name or description for the metrics for this <c>WebACL</c>. The name can
        /// contain only alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128 and
        /// minimum length one. It can't contain whitespace or metric names reserved for AWS WAF,
        /// including "All" and "Default_Action." You can't change <c>MetricName</c> after you
        /// create the <c>WebACL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// A friendly name or description of the <c>WebACL</c>. You can't change the name of
        /// a <c>WebACL</c> after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Rules. 
        /// <para>
        /// An array that contains the action for each <c>Rule</c> in a <c>WebACL</c>, the priority
        /// of the <c>Rule</c>, and the ID of the <c>Rule</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ActivatedRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WebACLArn. 
        /// <para>
        /// Tha Amazon Resource Name (ARN) of the web ACL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string WebACLArn
        {
            get { return this._webACLArn; }
            set { this._webACLArn = value; }
        }

        // Check to see if WebACLArn property is set
        internal bool IsSetWebACLArn()
        {
            return this._webACLArn != null;
        }

        /// <summary>
        /// Gets and sets the property WebACLId. 
        /// <para>
        /// A unique identifier for a <c>WebACL</c>. You use <c>WebACLId</c> to get information
        /// about a <c>WebACL</c> (see <a>GetWebACL</a>), update a <c>WebACL</c> (see <a>UpdateWebACL</a>),
        /// and delete a <c>WebACL</c> from AWS WAF (see <a>DeleteWebACL</a>).
        /// </para>
        ///  
        /// <para>
        ///  <c>WebACLId</c> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WebACLId
        {
            get { return this._webACLId; }
            set { this._webACLId = value; }
        }

        // Check to see if WebACLId property is set
        internal bool IsSetWebACLId()
        {
            return this._webACLId != null;
        }

    }
}