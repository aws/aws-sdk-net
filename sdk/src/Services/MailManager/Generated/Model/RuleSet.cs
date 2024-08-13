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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// A rule set contains a list of rules that are evaluated in order. Each rule is evaluated
    /// sequentially for each email.
    /// </summary>
    public partial class RuleSet
    {
        private DateTime? _lastModificationDate;
        private string _ruleSetId;
        private string _ruleSetName;

        /// <summary>
        /// Gets and sets the property LastModificationDate. 
        /// <para>
        /// The last modification date of the rule set.
        /// </para>
        /// </summary>
        public DateTime? LastModificationDate
        {
            get { return this._lastModificationDate; }
            set { this._lastModificationDate = value; }
        }

        // Check to see if LastModificationDate property is set
        internal bool IsSetLastModificationDate()
        {
            return this._lastModificationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleSetId. 
        /// <para>
        /// The identifier of the rule set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RuleSetId
        {
            get { return this._ruleSetId; }
            set { this._ruleSetId = value; }
        }

        // Check to see if RuleSetId property is set
        internal bool IsSetRuleSetId()
        {
            return this._ruleSetId != null;
        }

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// A user-friendly name for the rule set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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