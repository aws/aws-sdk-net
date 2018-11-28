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
    /// Describes configuration parameters for a Java-based Amazon Kinesis Data Analytics
    /// application.
    /// </summary>
    public partial class FlinkApplicationConfiguration
    {
        private CheckpointConfiguration _checkpointConfiguration;
        private MonitoringConfiguration _monitoringConfiguration;
        private ParallelismConfiguration _parallelismConfiguration;

        /// <summary>
        /// Gets and sets the property CheckpointConfiguration. 
        /// <para>
        /// Describes an application's checkpointing configuration. Checkpointing is the process
        /// of persisting application state for fault tolerance. For more information, see <a
        /// href="https://ci.apache.org/projects/flink/flink-docs-release-1.6/concepts/programming-model.html#checkpoints-for-fault-tolerance">
        /// Checkpoints for Fault Tolerance</a> in the <a href="https://ci.apache.org/projects/flink/flink-docs-release-1.6/">Apache
        /// Flink Documentation</a>. 
        /// </para>
        /// </summary>
        public CheckpointConfiguration CheckpointConfiguration
        {
            get { return this._checkpointConfiguration; }
            set { this._checkpointConfiguration = value; }
        }

        // Check to see if CheckpointConfiguration property is set
        internal bool IsSetCheckpointConfiguration()
        {
            return this._checkpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringConfiguration. 
        /// <para>
        /// Describes configuration parameters for Amazon CloudWatch logging for an application.
        /// </para>
        /// </summary>
        public MonitoringConfiguration MonitoringConfiguration
        {
            get { return this._monitoringConfiguration; }
            set { this._monitoringConfiguration = value; }
        }

        // Check to see if MonitoringConfiguration property is set
        internal bool IsSetMonitoringConfiguration()
        {
            return this._monitoringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelismConfiguration. 
        /// <para>
        /// Describes parameters for how an application executes multiple tasks simultaneously.
        /// </para>
        /// </summary>
        public ParallelismConfiguration ParallelismConfiguration
        {
            get { return this._parallelismConfiguration; }
            set { this._parallelismConfiguration = value; }
        }

        // Check to see if ParallelismConfiguration property is set
        internal bool IsSetParallelismConfiguration()
        {
            return this._parallelismConfiguration != null;
        }

    }
}