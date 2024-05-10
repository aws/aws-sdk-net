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
    /// A single action condition for a <a>Condition</a> in a logging filter.
    /// </summary>
    public partial class ActionCondition
    {
        private ActionValue _action;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action setting that a log record must contain in order to meet the condition.
        /// This is the action that WAF applied to the web request. 
        /// </para>
        ///  
        /// <para>
        /// For rule groups, this is either the configured rule action setting, or if you've applied
        /// a rule action override to the rule, it's the override action. The value <c>EXCLUDED_AS_COUNT</c>
        /// matches on excluded rules and also on rules that have a rule action override of Count.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionValue Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

    }
}