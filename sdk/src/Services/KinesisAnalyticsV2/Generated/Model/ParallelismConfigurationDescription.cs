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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes parameters for how a Managed Service for Apache Flink application executes
    /// multiple tasks simultaneously.
    /// </summary>
    public partial class ParallelismConfigurationDescription
    {
        private bool? _autoScalingEnabled;
        private ConfigurationType _configurationType;
        private int? _currentParallelism;
        private int? _parallelism;
        private int? _parallelismPerKPU;

        /// <summary>
        /// Gets and sets the property AutoScalingEnabled. 
        /// <para>
        /// Describes whether the Managed Service for Apache Flink service can increase the parallelism
        /// of the application in response to increased throughput.
        /// </para>
        /// </summary>
        public bool? AutoScalingEnabled
        {
            get { return this._autoScalingEnabled; }
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
        /// for Apache Flink service. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CurrentParallelism. 
        /// <para>
        /// Describes the current number of parallel tasks that a Managed Service for Apache Flink
        /// application can perform. If <c>AutoScalingEnabled</c> is set to True, Managed Service
        /// for Apache Flink can increase this value in response to application load. The service
        /// can increase this value up to the maximum parallelism, which is <c>ParalellismPerKPU</c>
        /// times the maximum KPUs for the application. The maximum KPUs for an application is
        /// 32 by default, and can be increased by requesting a limit increase. If application
        /// load is reduced, the service can reduce the <c>CurrentParallelism</c> value down to
        /// the <c>Parallelism</c> setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? CurrentParallelism
        {
            get { return this._currentParallelism; }
            set { this._currentParallelism = value; }
        }

        // Check to see if CurrentParallelism property is set
        internal bool IsSetCurrentParallelism()
        {
            return this._currentParallelism.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parallelism. 
        /// <para>
        /// Describes the initial number of parallel tasks that a Managed Service for Apache Flink
        /// application can perform. If <c>AutoScalingEnabled</c> is set to True, then Managed
        /// Service for Apache Flink can increase the <c>CurrentParallelism</c> value in response
        /// to application load. The service can increase <c>CurrentParallelism</c> up to the
        /// maximum parallelism, which is <c>ParalellismPerKPU</c> times the maximum KPUs for
        /// the application. The maximum KPUs for an application is 64 by default, and can be
        /// increased by requesting a limit increase. If application load is reduced, the service
        /// can reduce the <c>CurrentParallelism</c> value down to the <c>Parallelism</c> setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Parallelism
        {
            get { return this._parallelism; }
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
        /// can perform per Kinesis Processing Unit (KPU) used by the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? ParallelismPerKPU
        {
            get { return this._parallelismPerKPU; }
            set { this._parallelismPerKPU = value; }
        }

        // Check to see if ParallelismPerKPU property is set
        internal bool IsSetParallelismPerKPU()
        {
            return this._parallelismPerKPU.HasValue; 
        }

    }
}