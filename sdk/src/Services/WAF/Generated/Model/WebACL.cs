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
    /// Contains the <code>Rules</code> that identify the requests that you want to allow,
    /// block, or count. In a <code>WebACL</code>, you also specify a default action (<code>ALLOW</code>
    /// or <code>BLOCK</code>), and the action for each <code>Rule</code> that you add to
    /// a <code>WebACL</code>, for example, block requests from specified IP addresses or
    /// block requests from specified referrers. You also associate the <code>WebACL</code>
    /// with a CloudFront distribution to identify the requests that you want AWS WAF to filter.
    /// If you add more than one <code>Rule</code> to a <code>WebACL</code>, a request needs
    /// to match only one of the specifications to be allowed, blocked, or counted. For more
    /// information, see <a>UpdateWebACL</a>.
    /// </summary>
    public partial class WebACL
    {
        private WafAction _defaultAction;
        private string _metricName;
        private string _name;
        private List<ActivatedRule> _rules = new List<ActivatedRule>();
        private string _webACLId;

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The action to perform if none of the <code>Rules</code> contained in the <code>WebACL</code>
        /// match. The action is specified by the <a>WafAction</a> object.
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
        /// A friendly name or description of the <code>WebACL</code>. You can't change the name
        /// of a <code>WebACL</code> after you create it.
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

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// An array that contains the action for each <code>Rule</code> in a <code>WebACL</code>,
        /// the priority of the <code>Rule</code>, and the ID of the <code>Rule</code>.
        /// </para>
        /// </summary>
        public List<ActivatedRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WebACLId. 
        /// <para>
        /// A unique identifier for a <code>WebACL</code>. You use <code>WebACLId</code> to get
        /// information about a <code>WebACL</code> (see <a>GetWebACL</a>), update a <code>WebACL</code>
        /// (see <a>UpdateWebACL</a>, and delete a <code>WebACL</code> from AWS WAF (see <a>DeleteWebACL</a>).
        /// </para>
        ///  
        /// <para>
        /// <code>WebACLId</code> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.
        /// </para>
        /// </summary>
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