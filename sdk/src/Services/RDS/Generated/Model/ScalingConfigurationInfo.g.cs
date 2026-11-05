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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// The scaling configuration for an Aurora DB cluster in <c>serverless</c> DB engine
    /// mode.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html">Using
    /// Amazon Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ScalingConfigurationInfo
    {
        /// <summary>
        /// Gets and sets the property AutoPause. 
        /// <para>
        /// Indicates whether automatic pause is allowed for the Aurora DB cluster in <c>serverless</c>
        /// DB engine mode.
        /// </para>
        ///  
        /// <para>
        /// When the value is set to false for an Aurora Serverless v1 DB cluster, the DB cluster
        /// automatically resumes.
        /// </para>
        /// </summary>
        public bool? AutoPause { get; set; }

        /// <summary>
        /// Checks to see if the AutoPause property is set.
        /// </summary>
        internal bool IsSetAutoPause() => this.AutoPause.HasValue;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum capacity for an Aurora DB cluster in <c>serverless</c> DB engine mode.
        /// </para>
        /// </summary>
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// The minimum capacity for an Aurora DB cluster in <c>serverless</c> DB engine mode.
        /// </para>
        /// </summary>
        public int? MinCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MinCapacity property is set.
        /// </summary>
        internal bool IsSetMinCapacity() => this.MinCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property SecondsBeforeTimeout. 
        /// <para>
        /// The number of seconds before scaling times out. What happens when an attempted scaling
        /// action times out is determined by the <c>TimeoutAction</c> setting.
        /// </para>
        /// </summary>
        public int? SecondsBeforeTimeout { get; set; }

        /// <summary>
        /// Checks to see if the SecondsBeforeTimeout property is set.
        /// </summary>
        internal bool IsSetSecondsBeforeTimeout() => this.SecondsBeforeTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property SecondsUntilAutoPause. 
        /// <para>
        /// The remaining amount of time, in seconds, before the Aurora DB cluster in <c>serverless</c>
        /// mode is paused. A DB cluster can be paused only when it's idle (it has no connections).
        /// </para>
        /// </summary>
        public int? SecondsUntilAutoPause { get; set; }

        /// <summary>
        /// Checks to see if the SecondsUntilAutoPause property is set.
        /// </summary>
        internal bool IsSetSecondsUntilAutoPause() => this.SecondsUntilAutoPause.HasValue;

        /// <summary>
        /// Gets and sets the property TimeoutAction. 
        /// <para>
        /// The action that occurs when Aurora times out while attempting to change the capacity
        /// of an Aurora Serverless v1 cluster. The value is either <c>ForceApplyCapacityChange</c>
        /// or <c>RollbackCapacityChange</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>ForceApplyCapacityChange</c>, the default, sets the capacity to the specified
        /// value as soon as possible.
        /// </para>
        ///  
        /// <para>
        ///  <c>RollbackCapacityChange</c> ignores the capacity change if a scaling point isn't
        /// found in the timeout period.
        /// </para>
        /// </summary>
        public string TimeoutAction { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutAction property is set.
        /// </summary>
        internal bool IsSetTimeoutAction() => this.TimeoutAction != null;
    }
}
