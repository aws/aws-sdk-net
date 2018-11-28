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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes parameters for how a Java-based Kinesis Data Analytics application executes
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
        /// Analytics service. 
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
        /// Describes the current number of parallel tasks that a Java-based Kinesis Data Analytics
        /// application can perform.
        /// </para>
        /// </summary>
        public int CurrentParallelism
        {
            get { return this._currentParallelism.GetValueOrDefault(); }
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
        /// Describes the initial number of parallel tasks that a Java-based Kinesis Data Analytics
        /// application can perform. 
        /// </para>
        /// </summary>
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
        /// Describes the number of parallel tasks that a Java-based Kinesis Data Analytics application
        /// can perform per Kinesis Processing Unit (KPU) used by the application.
        /// </para>
        /// </summary>
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