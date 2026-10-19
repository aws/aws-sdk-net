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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The action to use in the place of the action that results from the rule group evaluation.
    /// Set the override action to none to leave the result of the rule group alone. Set it
    /// to count to override the result to count only. 
    /// 
    ///  
    /// <para>
    /// You can only use this for rule statements that reference a rule group, like <c>RuleGroupReferenceStatement</c>
    /// and <c>ManagedRuleGroupStatement</c>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// This option is usually set to none. It does not affect how the rules in the rule group
    /// are evaluated. If you want the rules in the rule group to only count matches, do not
    /// use this and instead use the rule action override option, with <c>Count</c> action,
    /// in your rule group reference statement settings. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class OverrideAction
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// Override the rule group evaluation result to count only. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This option is usually set to none. It does not affect how the rules in the rule group
        /// are evaluated. If you want the rules in the rule group to only count matches, do not
        /// use this and instead use the rule action override option, with <c>Count</c> action,
        /// in your rule group reference statement settings. 
        /// </para>
        ///  </note>
        /// </summary>
        public CountAction Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count != null;

        /// <summary>
        /// Gets and sets the property None. 
        /// <para>
        /// Don't override the rule group evaluation result. This is the most common setting.
        /// </para>
        /// </summary>
        public NoneAction None { get; set; }

        /// <summary>
        /// Checks to see if the None property is set.
        /// </summary>
        internal bool IsSetNone() => this.None != null;
    }
}
