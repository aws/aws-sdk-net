/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes a load-based auto scaling upscaling or downscaling threshold configuration, which specifies when AWS OpsWorks starts or
    /// stops load-based instances.</para>
    /// </summary>
    public class AutoScalingThresholds
    {
        
        private int? instanceCount;
        private int? thresholdsWaitTime;
        private int? ignoreMetricsTime;
        private double? cpuThreshold;
        private double? memoryThreshold;
        private double? loadThreshold;


        /// <summary>
        /// The number of instances to add or remove when the load exceeds a threshold.
        ///  
        /// </summary>
        public int InstanceCount
        {
            get { return this.instanceCount ?? default(int); }
            set { this.instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this.instanceCount.HasValue;
        }

        /// <summary>
        /// The amount of time, in minutes, that the load must exceed a threshold before more instances are added or removed.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int ThresholdsWaitTime
        {
            get { return this.thresholdsWaitTime ?? default(int); }
            set { this.thresholdsWaitTime = value; }
        }

        // Check to see if ThresholdsWaitTime property is set
        internal bool IsSetThresholdsWaitTime()
        {
            return this.thresholdsWaitTime.HasValue;
        }

        /// <summary>
        /// The amount of time (in minutes) after a scaling event occurs that AWS OpsWorks should ignore metrics and not raise any additional scaling
        /// events. For example, AWS OpsWorks adds new instances following an upscaling event but the instances won't start reducing the load until they
        /// have been booted and configured. There is no point in raising additional scaling events during that operation, which typically takes several
        /// minutes. <c>IgnoreMetricsTime</c> allows you to direct AWS OpsWorks to not raise any scaling events long enough to get the new instances
        /// online.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int IgnoreMetricsTime
        {
            get { return this.ignoreMetricsTime ?? default(int); }
            set { this.ignoreMetricsTime = value; }
        }

        // Check to see if IgnoreMetricsTime property is set
        internal bool IsSetIgnoreMetricsTime()
        {
            return this.ignoreMetricsTime.HasValue;
        }

        /// <summary>
        /// The CPU utilization threshold, as a percent of the available CPU.
        ///  
        /// </summary>
        public double CpuThreshold
        {
            get { return this.cpuThreshold ?? default(double); }
            set { this.cpuThreshold = value; }
        }

        // Check to see if CpuThreshold property is set
        internal bool IsSetCpuThreshold()
        {
            return this.cpuThreshold.HasValue;
        }

        /// <summary>
        /// The memory utilization threshold, as a percent of the available memory.
        ///  
        /// </summary>
        public double MemoryThreshold
        {
            get { return this.memoryThreshold ?? default(double); }
            set { this.memoryThreshold = value; }
        }

        // Check to see if MemoryThreshold property is set
        internal bool IsSetMemoryThreshold()
        {
            return this.memoryThreshold.HasValue;
        }

        /// <summary>
        /// The load threshold. For more information about how load is computed, see <a href="http://en.wikipedia.org/wiki/Load_%28computing%29">Load
        /// (computing)</a>.
        ///  
        /// </summary>
        public double LoadThreshold
        {
            get { return this.loadThreshold ?? default(double); }
            set { this.loadThreshold = value; }
        }

        // Check to see if LoadThreshold property is set
        internal bool IsSetLoadThreshold()
        {
            return this.loadThreshold.HasValue;
        }
    }
}
