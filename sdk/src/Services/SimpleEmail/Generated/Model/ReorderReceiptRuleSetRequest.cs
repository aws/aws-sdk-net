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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the ReorderReceiptRuleSet operation.
    /// Reorders the receipt rules within a receipt rule set.
    /// 
    ///  <note> 
    /// <para>
    /// All of the rules in the rule set must be represented in this request. That is, this
    /// API will return an error if the reorder request doesn't explicitly position all of
    /// the rules.
    /// </para>
    ///  </note> 
    /// <para>
    /// For information about managing receipt rule sets, see the <i> <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
    /// SES Developer Guide</a>.</i> 
    /// </para>
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class ReorderReceiptRuleSetRequest : AmazonSimpleEmailServiceRequest
    {
        private List<string> _ruleNames = new List<string>();
        private string _ruleSetName;

        /// <summary>
        /// Gets and sets the property RuleNames. 
        /// <para>
        /// A list of the specified receipt rule set's receipt rules in the order that you want
        /// to put them.
        /// </para>
        /// </summary>
        public List<string> RuleNames
        {
            get { return this._ruleNames; }
            set { this._ruleNames = value; }
        }

        // Check to see if RuleNames property is set
        internal bool IsSetRuleNames()
        {
            return this._ruleNames != null && this._ruleNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// The name of the receipt rule set to reorder.
        /// </para>
        /// </summary>
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