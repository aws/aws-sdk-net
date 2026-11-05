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
    /// Contains the scaling configuration of an Aurora Serverless v1 DB cluster.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html">Using
    /// Amazon Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ScalingConfiguration
    {
        /// <summary>
        /// Gets and sets the property AutoPause. 
        /// <para>
        /// Indicates whether to allow or disallow automatic pause for an Aurora DB cluster in
        /// <c>serverless</c> DB engine mode. A DB cluster can be paused only when it's idle (it
        /// has no connections).
        /// </para>
        ///  <note> 
        /// <para>
        /// If a DB cluster is paused for more than seven days, the DB cluster might be backed
        /// up with a snapshot. In this case, the DB cluster is restored when there is a request
        /// to connect to it.
        /// </para>
        ///  </note>
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
        ///  
        /// <para>
        /// For Aurora MySQL, valid capacity values are <c>1</c>, <c>2</c>, <c>4</c>, <c>8</c>,
        /// <c>16</c>, <c>32</c>, <c>64</c>, <c>128</c>, and <c>256</c>.
        /// </para>
        ///  
        /// <para>
        /// For Aurora PostgreSQL, valid capacity values are <c>2</c>, <c>4</c>, <c>8</c>, <c>16</c>,
        /// <c>32</c>, <c>64</c>, <c>192</c>, and <c>384</c>.
        /// </para>
        ///  
        /// <para>
        /// The maximum capacity must be greater than or equal to the minimum capacity.
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
        ///  
        /// <para>
        /// For Aurora MySQL, valid capacity values are <c>1</c>, <c>2</c>, <c>4</c>, <c>8</c>,
        /// <c>16</c>, <c>32</c>, <c>64</c>, <c>128</c>, and <c>256</c>.
        /// </para>
        ///  
        /// <para>
        /// For Aurora PostgreSQL, valid capacity values are <c>2</c>, <c>4</c>, <c>8</c>, <c>16</c>,
        /// <c>32</c>, <c>64</c>, <c>192</c>, and <c>384</c>.
        /// </para>
        ///  
        /// <para>
        /// The minimum capacity must be less than or equal to the maximum capacity.
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
        /// The amount of time, in seconds, that Aurora Serverless v1 tries to find a scaling
        /// point to perform seamless scaling before enforcing the timeout action. The default
        /// is 300.
        /// </para>
        ///  
        /// <para>
        /// Specify a value between 60 and 600 seconds.
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
        /// The time, in seconds, before an Aurora DB cluster in <c>serverless</c> mode is paused.
        /// </para>
        ///  
        /// <para>
        /// Specify a value between 300 and 86,400 seconds.
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
        /// The action to take when the timeout is reached, either <c>ForceApplyCapacityChange</c>
        /// or <c>RollbackCapacityChange</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>ForceApplyCapacityChange</c> sets the capacity to the specified value as soon
        /// as possible.
        /// </para>
        ///  
        /// <para>
        ///  <c>RollbackCapacityChange</c>, the default, ignores the capacity change if a scaling
        /// point isn't found in the timeout period.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify <c>ForceApplyCapacityChange</c>, connections that prevent Aurora Serverless
        /// v1 from finding a scaling point might be dropped.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.how-it-works.html#aurora-serverless.how-it-works.auto-scaling">
        /// Autoscaling for Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public string TimeoutAction { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutAction property is set.
        /// </summary>
        internal bool IsSetTimeoutAction() => this.TimeoutAction != null;
    }
}
