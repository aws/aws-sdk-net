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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReceiptRule operation.
    /// Creates a receipt rule.
    /// 
    ///  
    /// <para>
    /// For information about setting up receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class CreateReceiptRuleRequest : AmazonSimpleEmailServiceRequest
    {
        private string _after;
        private ReceiptRule _rule;
        private string _ruleSetName;

        /// <summary>
        /// Gets and sets the property After. 
        /// <para>
        /// The name of an existing rule after which the new rule is placed. If this parameter
        /// is null, the new rule is inserted at the beginning of the rule list.
        /// </para>
        /// </summary>
        public string After
        {
            get { return this._after; }
            set { this._after = value; }
        }

        // Check to see if After property is set
        internal bool IsSetAfter()
        {
            return this._after != null;
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// A data structure that contains the specified rule's name, actions, recipients, domains,
        /// enabled status, scan status, and TLS policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReceiptRule Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// The name of the rule set where the receipt rule is added.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RuleSetName
        {
            get { return this._ruleSetName; }
            set { this._ruleSetName = value; }
        }

        // Check to see if RuleSetName property is set
        internal bool IsSetRuleSetName()
        {
            return this._ruleSetName != null;
        }

    }
}