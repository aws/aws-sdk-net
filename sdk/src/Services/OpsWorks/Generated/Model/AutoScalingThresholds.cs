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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes a load-based auto scaling upscaling or downscaling threshold configuration,
    /// which specifies when AWS OpsWorks starts or stops load-based instances.
    /// </summary>
    public partial class AutoScalingThresholds
    {
        private List<string> _alarms = new List<string>();
        private double? _cpuThreshold;
        private int? _ignoreMetricsTime;
        private int? _instanceCount;
        private double? _loadThreshold;
        private double? _memoryThreshold;
        private int? _thresholdsWaitTime;

        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// Custom Cloudwatch auto scaling alarms, to be used as thresholds. This parameter takes
        /// a list of up to five alarm names, which are case sensitive and must be in the same
        /// region as the stack.
        /// </para>
        ///  <note>To use custom alarms, you must update your service role to allow <code>cloudwatch:DescribeAlarms</code>.
        /// You can either have AWS OpsWorks update the role for you when you first use this feature
        /// or you can edit the role manually. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-servicerole.html">Allowing
        /// AWS OpsWorks to Act on Your Behalf</a>.</note>
        /// </summary>
        public List<string> Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null && this._alarms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CpuThreshold. 
        /// <para>
        /// The CPU utilization threshold, as a percent of the available CPU. A value of -1 disables
        /// the threshold.
        /// </para>
        /// </summary>
        public double CpuThreshold
        {
            get { return this._cpuThreshold.GetValueOrDefault(); }
            set { this._cpuThreshold = value; }
        }

        // Check to see if CpuThreshold property is set
        internal bool IsSetCpuThreshold()
        {
            return this._cpuThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IgnoreMetricsTime. 
        /// <para>
        /// The amount of time (in minutes) after a scaling event occurs that AWS OpsWorks should
        /// ignore metrics and suppress additional scaling events. For example, AWS OpsWorks adds
        /// new instances following an upscaling event but the instances won't start reducing
        /// the load until they have been booted and configured. There is no point in raising
        /// additional scaling events during that operation, which typically takes several minutes.
        /// <code>IgnoreMetricsTime</code> allows you to direct AWS OpsWorks to suppress scaling
        /// events long enough to get the new instances online.
        /// </para>
        /// </summary>
        public int IgnoreMetricsTime
        {
            get { return this._ignoreMetricsTime.GetValueOrDefault(); }
            set { this._ignoreMetricsTime = value; }
        }

        // Check to see if IgnoreMetricsTime property is set
        internal bool IsSetIgnoreMetricsTime()
        {
            return this._ignoreMetricsTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances to add or remove when the load exceeds a threshold.
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadThreshold. 
        /// <para>
        /// The load threshold. A value of -1 disables the threshold. For more information about
        /// how load is computed, see <a href="http://en.wikipedia.org/wiki/Load_%28computing%29">Load
        /// (computing)</a>.
        /// </para>
        /// </summary>
        public double LoadThreshold
        {
            get { return this._loadThreshold.GetValueOrDefault(); }
            set { this._loadThreshold = value; }
        }

        // Check to see if LoadThreshold property is set
        internal bool IsSetLoadThreshold()
        {
            return this._loadThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryThreshold. 
        /// <para>
        /// The memory utilization threshold, as a percent of the available memory. A value of
        /// -1 disables the threshold.
        /// </para>
        /// </summary>
        public double MemoryThreshold
        {
            get { return this._memoryThreshold.GetValueOrDefault(); }
            set { this._memoryThreshold = value; }
        }

        // Check to see if MemoryThreshold property is set
        internal bool IsSetMemoryThreshold()
        {
            return this._memoryThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThresholdsWaitTime. 
        /// <para>
        /// The amount of time, in minutes, that the load must exceed a threshold before more
        /// instances are added or removed.
        /// </para>
        /// </summary>
        public int ThresholdsWaitTime
        {
            get { return this._thresholdsWaitTime.GetValueOrDefault(); }
            set { this._thresholdsWaitTime = value; }
        }

        // Check to see if ThresholdsWaitTime property is set
        internal bool IsSetThresholdsWaitTime()
        {
            return this._thresholdsWaitTime.HasValue; 
        }

    }
}