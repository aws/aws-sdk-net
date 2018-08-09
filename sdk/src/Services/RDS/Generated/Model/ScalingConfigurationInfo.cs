/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Shows the scaling configuration for an Aurora DB cluster in <code>serverless</code>
    /// DB engine mode.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/aurora-serverless.html">Using
    /// Amazon Aurora Serverless</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ScalingConfigurationInfo
    {
        private bool? _autoPause;
        private int? _maxCapacity;
        private int? _minCapacity;
        private int? _secondsUntilAutoPause;

        /// <summary>
        /// Gets and sets the property AutoPause. 
        /// <para>
        /// A value that indicates whether automatic pause is allowed for the Aurora DB cluster
        /// in <code>serverless</code> DB engine mode. 
        /// </para>
        /// </summary>
        public bool AutoPause
        {
            get { return this._autoPause.GetValueOrDefault(); }
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
        /// The maximum capacity for an Aurora DB cluster in <code>serverless</code> DB engine
        /// mode.
        /// </para>
        /// </summary>
        public int MaxCapacity
        {
            get { return this._maxCapacity.GetValueOrDefault(); }
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
        /// The maximum capacity for the Aurora DB cluster in <code>serverless</code> DB engine
        /// mode.
        /// </para>
        /// </summary>
        public int MinCapacity
        {
            get { return this._minCapacity.GetValueOrDefault(); }
            set { this._minCapacity = value; }
        }

        // Check to see if MinCapacity property is set
        internal bool IsSetMinCapacity()
        {
            return this._minCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondsUntilAutoPause. 
        /// <para>
        /// The remaining amount of time, in seconds, before the Aurora DB cluster in <code>serverless</code>
        /// mode is paused. A DB cluster can be paused only when it's idle (it has no connections).
        /// </para>
        /// </summary>
        public int SecondsUntilAutoPause
        {
            get { return this._secondsUntilAutoPause.GetValueOrDefault(); }
            set { this._secondsUntilAutoPause = value; }
        }

        // Check to see if SecondsUntilAutoPause property is set
        internal bool IsSetSecondsUntilAutoPause()
        {
            return this._secondsUntilAutoPause.HasValue; 
        }

    }
}