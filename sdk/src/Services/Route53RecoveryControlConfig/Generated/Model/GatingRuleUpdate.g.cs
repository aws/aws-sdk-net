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

namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// Update to a gating rule. You can update the name or the evaluation period (wait period).
    /// If you don't specify one of the items to update, the item is unchanged.
    /// </summary>
    public partial class GatingRuleUpdate
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the gating rule. You can use any non-white space character in the name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SafetyRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gating rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SafetyRuleArn { get; set; }

        /// <summary>
        /// Checks to see if the SafetyRuleArn property is set.
        /// </summary>
        internal bool IsSetSafetyRuleArn() => this.SafetyRuleArn != null;

        /// <summary>
        /// Gets and sets the property WaitPeriodMs. 
        /// <para>
        /// An evaluation period, in milliseconds (ms), during which any request against the target
        /// routing controls will fail. This helps prevent "flapping" of state. The wait period
        /// is 5000 ms by default, but you can choose a custom value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? WaitPeriodMs { get; set; }

        /// <summary>
        /// Checks to see if the WaitPeriodMs property is set.
        /// </summary>
        internal bool IsSetWaitPeriodMs() => this.WaitPeriodMs.HasValue;
    }
}
