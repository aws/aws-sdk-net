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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
        private bool? _autoPause;
        private int? _maxCapacity;
        private int? _minCapacity;
        private int? _secondsBeforeTimeout;
        private int? _secondsUntilAutoPause;
        private string _timeoutAction;

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
        public bool? AutoPause
        {
            get { return this._autoPause; }
            set { this._autoPause = value; }
        }

        // Check to see if AutoPause property is set
        internal bool IsSetAutoPause()
        {
            return this._autoPause.HasValue; 
        }

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
        public int? MaxCapacity
        {
            get { return this._maxCapacity; }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

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
        public int? MinCapacity
        {
            get { return this._minCapacity; }
            set { this._minCapacity = value; }
        }

        // Check to see if MinCapacity property is set
        internal bool IsSetMinCapacity()
        {
            return this._minCapacity.HasValue; 
        }

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
        public int? SecondsBeforeTimeout
        {
            get { return this._secondsBeforeTimeout; }
            set { this._secondsBeforeTimeout = value; }
        }

        // Check to see if SecondsBeforeTimeout property is set
        internal bool IsSetSecondsBeforeTimeout()
        {
            return this._secondsBeforeTimeout.HasValue; 
        }

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
        public int? SecondsUntilAutoPause
        {
            get { return this._secondsUntilAutoPause; }
            set { this._secondsUntilAutoPause = value; }
        }

        // Check to see if SecondsUntilAutoPause property is set
        internal bool IsSetSecondsUntilAutoPause()
        {
            return this._secondsUntilAutoPause.HasValue; 
        }

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
        public string TimeoutAction
        {
            get { return this._timeoutAction; }
            set { this._timeoutAction = value; }
        }

        // Check to see if TimeoutAction property is set
        internal bool IsSetTimeoutAction()
        {
            return this._timeoutAction != null;
        }

    }
}