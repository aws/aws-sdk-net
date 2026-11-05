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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateReceiptRule operation. Creates a receipt
    /// rule. <para> For information about setting up receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
    /// SES Developer Guide</a>. </para> <para> You can execute this operation no more than
    /// once per second. </para>
    /// </summary>
    public partial class CreateReceiptRuleRequest : AmazonSimpleEmailServiceRequest
    {
        /// <summary>
        /// Gets and sets the property After. 
        /// <para>
        /// The name of an existing rule after which the new rule is placed. If this parameter
        /// is null, the new rule is inserted at the beginning of the rule list.
        /// </para>
        /// </summary>
        public string After { get; set; }

        /// <summary>
        /// Checks to see if the After property is set.
        /// </summary>
        internal bool IsSetAfter() => this.After != null;

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// A data structure that contains the specified rule's name, actions, recipients, domains,
        /// enabled status, scan status, and TLS policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReceiptRule Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// The name of the rule set where the receipt rule is added.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RuleSetName { get; set; }

        /// <summary>
        /// Checks to see if the RuleSetName property is set.
        /// </summary>
        internal bool IsSetRuleSetName() => this.RuleSetName != null;
    }
}
