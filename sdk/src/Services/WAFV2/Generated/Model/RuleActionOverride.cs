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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Action setting to use in the place of a rule action that is configured inside the
    /// rule group. You specify one override for each rule whose action you want to change.
    /// 
    /// 
    ///  <note> 
    /// <para>
    /// Verify the rule names in your overrides carefully. With managed rule groups, WAF silently
    /// ignores any override that uses an invalid rule name. With customer-owned rule groups,
    /// invalid rule names in your overrides will cause web ACL updates to fail. An invalid
    /// rule name is any name that doesn't exactly match the case-sensitive name of an existing
    /// rule in the rule group.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can use overrides for testing, for example you can override all of rule actions
    /// to <c>Count</c> and then monitor the resulting count metrics to understand how the
    /// rule group would handle your web traffic. You can also permanently override some or
    /// all actions, to modify how the rule group manages your web traffic.
    /// </para>
    /// </summary>
    public partial class RuleActionOverride
    {
        private RuleAction _actionToUse;
        private string _name;

        /// <summary>
        /// Gets and sets the property ActionToUse. 
        /// <para>
        /// The override action to use, in place of the configured action of the rule in the rule
        /// group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleAction ActionToUse
        {
            get { return this._actionToUse; }
            set { this._actionToUse = value; }
        }

        // Check to see if ActionToUse property is set
        internal bool IsSetActionToUse()
        {
            return this._actionToUse != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule to override.
        /// </para>
        ///  <note> 
        /// <para>
        /// Verify the rule names in your overrides carefully. With managed rule groups, WAF silently
        /// ignores any override that uses an invalid rule name. With customer-owned rule groups,
        /// invalid rule names in your overrides will cause web ACL updates to fail. An invalid
        /// rule name is any name that doesn't exactly match the case-sensitive name of an existing
        /// rule in the rule group.
        /// </para>
        ///  </note>
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

    }
}