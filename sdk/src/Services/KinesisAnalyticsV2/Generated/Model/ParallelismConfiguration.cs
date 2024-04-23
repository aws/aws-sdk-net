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
    /// Describes parameters for how a Managed Service for Apache Flink application executes
    /// multiple tasks simultaneously. For more information about parallelism, see <a href="https://nightlies.apache.org/flink/flink-docs-release-1.18/dev/parallel.html">Parallel
    /// Execution</a> in the <a href="https://nightlies.apache.org/flink/flink-docs-release-1.18/">Apache
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
        /// Describes whether the Managed Service for Apache Flink service can increase the parallelism
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
        /// Describes whether the application uses the default parallelism for the Managed Service
        /// for Apache Flink service. You must set this property to <c>CUSTOM</c> in order to
        /// change your application's <c>AutoScalingEnabled</c>, <c>Parallelism</c>, or <c>ParallelismPerKPU</c>
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
        /// Describes the initial number of parallel tasks that a Managed Service for Apache Flink
        /// application can perform. If <c>AutoScalingEnabled</c> is set to True, Managed Service
        /// for Apache Flink increases the <c>CurrentParallelism</c> value in response to application
        /// load. The service can increase the <c>CurrentParallelism</c> value up to the maximum
        /// parallelism, which is <c>ParalellismPerKPU</c> times the maximum KPUs for the application.
        /// The maximum KPUs for an application is 32 by default, and can be increased by requesting
        /// a limit increase. If application load is reduced, the service can reduce the <c>CurrentParallelism</c>
        /// value down to the <c>Parallelism</c> setting.
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
        /// Describes the number of parallel tasks that a Managed Service for Apache Flink application
        /// can perform per Kinesis Processing Unit (KPU) used by the application. For more information
        /// about KPUs, see <a href="http://aws.amazon.com/kinesis/data-analytics/pricing/">Amazon
        /// Managed Service for Apache Flink Pricing</a>.
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