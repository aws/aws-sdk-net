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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about rules in a rule group. A rule identifies web requests that
    /// you want to allow, block, or count. Each rule includes one top-level Statement that
    /// WAF uses to identify matching web requests, and parameters that govern how WAF handles
    /// them.
    /// </summary>
    public partial class AwsWafv2RulesDetails
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        ///  The action that WAF should take on a web request when it matches the rule statement.
        /// Settings at the web ACL level can override the rule action setting. 
        /// </para>
        /// </summary>
        public AwsWafv2RulesActionDetails Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the rule. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OverrideAction. 
        /// <para>
        ///  The action to use in the place of the action that results from the rule group evaluation.
        /// 
        /// </para>
        /// </summary>
        public string OverrideAction { get; set; }

        /// <summary>
        /// Checks to see if the OverrideAction property is set.
        /// </summary>
        internal bool IsSetOverrideAction() => this.OverrideAction != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        ///  If you define more than one Rule in a WebACL, WAF evaluates each request against
        /// the Rules in order based on the value of <c>Priority</c>. WAF processes rules with
        /// lower priority first. The priorities don't need to be consecutive, but they must all
        /// be different. 
        /// </para>
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property VisibilityConfig. 
        /// <para>
        ///  Defines and enables Amazon CloudWatch metrics and web request sample collection.
        /// 
        /// </para>
        /// </summary>
        public AwsWafv2VisibilityConfigDetails VisibilityConfig { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityConfig property is set.
        /// </summary>
        internal bool IsSetVisibilityConfig() => this.VisibilityConfig != null;
    }
}
