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
    /// Container for the parameters to the CreateReceiptRuleSet operation.
    /// Creates an empty receipt rule set.
    /// 
    ///  
    /// <para>
    /// For information about setting up receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-receipt-rule-set.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    /// </summary>
    public partial class CreateReceiptRuleSetRequest : AmazonSimpleEmailServiceRequest
    {
        private string _ruleSetName;

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// The name of the rule set to create. The name must:
        /// </para>
        ///  <ul> <li>Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores
        /// (_), or dashes (-).</li> <li>Start and end with a letter or number.</li> <li>Contain
        /// less than 64 characters.</li> </ul>
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