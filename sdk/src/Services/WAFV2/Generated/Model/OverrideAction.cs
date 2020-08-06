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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The override action to apply to the rules in a rule group. Used only for rule statements
    /// that reference a rule group, like <code>RuleGroupReferenceStatement</code> and <code>ManagedRuleGroupStatement</code>.
    /// 
    /// 
    ///  
    /// <para>
    /// Set the override action to none to leave the rule actions in effect. Set it to count
    /// to only count matches, regardless of the rule action settings. 
    /// </para>
    ///  
    /// <para>
    /// In a <a>Rule</a>, you must specify either this <code>OverrideAction</code> setting
    /// or the rule <code>Action</code> setting, but not both:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the rule statement references a rule group, use this override action setting and
    /// not the action setting. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the rule statement does not reference a rule group, use the rule action setting
    /// and not this rule override action setting. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class OverrideAction
    {
        private CountAction _count;
        private NoneAction _none;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// Override the rule action setting to count.
        /// </para>
        /// </summary>
        public CountAction Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count != null;
        }

        /// <summary>
        /// Gets and sets the property None. 
        /// <para>
        /// Don't override the rule action setting.
        /// </para>
        /// </summary>
        public NoneAction None
        {
            get { return this._none; }
            set { this._none = value; }
        }

        // Check to see if None property is set
        internal bool IsSetNone()
        {
            return this._none != null;
        }

    }
}