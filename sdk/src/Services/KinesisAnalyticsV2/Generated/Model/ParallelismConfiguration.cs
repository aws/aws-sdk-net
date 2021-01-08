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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes parameters for how a Flink-based Kinesis Data Analytics application application
    /// executes multiple tasks simultaneously. For more information about parallelism, see
    /// <a href="https://ci.apache.org/projects/flink/flink-docs-release-1.8/dev/parallel.html">Parallel
    /// Execution</a> in the <a href="https://ci.apache.org/projects/flink/flink-docs-release-1.8/">Apache
    /// Flink Documentation</a>.
    /// </summary>
    public partial class ParallelismConfiguration
    {
        private bool? _autoScalingEnabled;
        private ConfigurationType _configurationType;
        private int? _parallelism;
        private int? _parallelismPerKPU;

        /// <summary>
        /// Gets and sets the property AutoScalingEnabled. 
        /// <para>
        /// Describes whether the Kinesis Data Analytics service can increase the parallelism
        /// of the application in response to increased throughput.
        /// </para>
        /// </summary>
        public bool AutoScalingEnabled
        {
            get { return this._autoScalingEnabled.GetValueOrDefault(); }
            set { this._autoScalingEnabled = value; }
        }

        // Check to see if AutoScalingEnabled property is set
        internal bool IsSetAutoScalingEnabled()
        {
            return this._autoScalingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        /// Describes whether the application uses the default parallelism for the Kinesis Data
        /// Analytics service. You must set this property to <code>CUSTOM</code> in order to change
        /// your application's <code>AutoScalingEnabled</code>, <code>Parallelism</code>, or <code>ParallelismPerKPU</code>
        /// properties.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationType ConfigurationType
        {
            get { return this._configurationType; }
            set { this._configurationType = value; }
        }

        // Check to see if ConfigurationType property is set
        internal bool IsSetConfigurationType()
        {
            return this._configurationType != null;
        }

        /// <summary>
        /// Gets and sets the property Parallelism. 
        /// <para>
        /// Describes the initial number of parallel tasks that a Flink-based Kinesis Data Analytics
        /// application can perform. If <code>AutoScalingEnabled</code> is set to True, Kinesis
        /// Data Analytics increases the <code>CurrentParallelism</code> value in response to
        /// application load. The service can increase the <code>CurrentParallelism</code> value
        /// up to the maximum parallelism, which is <code>ParalellismPerKPU</code> times the maximum
        /// KPUs for the application. The maximum KPUs for an application is 32 by default, and
        /// can be increased by requesting a limit increase. If application load is reduced, the
        /// service can reduce the <code>CurrentParallelism</code> value down to the <code>Parallelism</code>
        /// setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Parallelism
        {
            get { return this._parallelism.GetValueOrDefault(); }
            set { this._parallelism = value; }
        }

        // Check to see if Parallelism property is set
        internal bool IsSetParallelism()
        {
            return this._parallelism.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParallelismPerKPU. 
        /// <para>
        /// Describes the number of parallel tasks that a Flink-based Kinesis Data Analytics application
        /// can perform per Kinesis Processing Unit (KPU) used by the application. For more information
        /// about KPUs, see <a href="http://aws.amazon.com/kinesis/data-analytics/pricing/">Amazon
        /// Kinesis Data Analytics Pricing</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int ParallelismPerKPU
        {
            get { return this._parallelismPerKPU.GetValueOrDefault(); }
            set { this._parallelismPerKPU = value; }
        }

        // Check to see if ParallelismPerKPU property is set
        internal bool IsSetParallelismPerKPU()
        {
            return this._parallelismPerKPU.HasValue; 
        }

    }
}