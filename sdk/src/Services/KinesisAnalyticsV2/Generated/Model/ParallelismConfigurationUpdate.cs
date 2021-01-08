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
    /// Describes updates to parameters for how a Flink-based Kinesis Data Analytics application
    /// executes multiple tasks simultaneously.
    /// </summary>
    public partial class ParallelismConfigurationUpdate
    {
        private bool? _autoScalingEnabledUpdate;
        private ConfigurationType _configurationTypeUpdate;
        private int? _parallelismPerKPUUpdate;
        private int? _parallelismUpdate;

        /// <summary>
        /// Gets and sets the property AutoScalingEnabledUpdate. 
        /// <para>
        /// Describes updates to whether the Kinesis Data Analytics service can increase the parallelism
        /// of the application in response to increased throughput.
        /// </para>
        /// </summary>
        public bool AutoScalingEnabledUpdate
        {
            get { return this._autoScalingEnabledUpdate.GetValueOrDefault(); }
            set { this._autoScalingEnabledUpdate = value; }
        }

        // Check to see if AutoScalingEnabledUpdate property is set
        internal bool IsSetAutoScalingEnabledUpdate()
        {
            return this._autoScalingEnabledUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationTypeUpdate. 
        /// <para>
        /// Describes updates to whether the application uses the default parallelism for the
        /// Kinesis Data Analytics service, or if a custom parallelism is used. You must set this
        /// property to <code>CUSTOM</code> in order to change your application's <code>AutoScalingEnabled</code>,
        /// <code>Parallelism</code>, or <code>ParallelismPerKPU</code> properties.
        /// </para>
        /// </summary>
        public ConfigurationType ConfigurationTypeUpdate
        {
            get { return this._configurationTypeUpdate; }
            set { this._configurationTypeUpdate = value; }
        }

        // Check to see if ConfigurationTypeUpdate property is set
        internal bool IsSetConfigurationTypeUpdate()
        {
            return this._configurationTypeUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelismPerKPUUpdate. 
        /// <para>
        /// Describes updates to the number of parallel tasks an application can perform per Kinesis
        /// Processing Unit (KPU) used by the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int ParallelismPerKPUUpdate
        {
            get { return this._parallelismPerKPUUpdate.GetValueOrDefault(); }
            set { this._parallelismPerKPUUpdate = value; }
        }

        // Check to see if ParallelismPerKPUUpdate property is set
        internal bool IsSetParallelismPerKPUUpdate()
        {
            return this._parallelismPerKPUUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParallelismUpdate. 
        /// <para>
        /// Describes updates to the initial number of parallel tasks an application can perform.
        /// If <code>AutoScalingEnabled</code> is set to True, then Kinesis Data Analytics can
        /// increase the <code>CurrentParallelism</code> value in response to application load.
        /// The service can increase <code>CurrentParallelism</code> up to the maximum parallelism,
        /// which is <code>ParalellismPerKPU</code> times the maximum KPUs for the application.
        /// The maximum KPUs for an application is 32 by default, and can be increased by requesting
        /// a limit increase. If application load is reduced, the service will reduce <code>CurrentParallelism</code>
        /// down to the <code>Parallelism</code> setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int ParallelismUpdate
        {
            get { return this._parallelismUpdate.GetValueOrDefault(); }
            set { this._parallelismUpdate = value; }
        }

        // Check to see if ParallelismUpdate property is set
        internal bool IsSetParallelismUpdate()
        {
            return this._parallelismUpdate.HasValue; 
        }

    }
}