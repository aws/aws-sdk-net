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
    /// Describes updates to the configuration parameters for a Managed Service for Apache
    /// Flink application.
    /// </summary>
    public partial class FlinkApplicationConfigurationUpdate
    {
        private CheckpointConfigurationUpdate _checkpointConfigurationUpdate;
        private MonitoringConfigurationUpdate _monitoringConfigurationUpdate;
        private ParallelismConfigurationUpdate _parallelismConfigurationUpdate;

        /// <summary>
        /// Gets and sets the property CheckpointConfigurationUpdate. 
        /// <para>
        /// Describes updates to an application's checkpointing configuration. Checkpointing is
        /// the process of persisting application state for fault tolerance.
        /// </para>
        /// </summary>
        public CheckpointConfigurationUpdate CheckpointConfigurationUpdate
        {
            get { return this._checkpointConfigurationUpdate; }
            set { this._checkpointConfigurationUpdate = value; }
        }

        // Check to see if CheckpointConfigurationUpdate property is set
        internal bool IsSetCheckpointConfigurationUpdate()
        {
            return this._checkpointConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringConfigurationUpdate. 
        /// <para>
        /// Describes updates to the configuration parameters for Amazon CloudWatch logging for
        /// an application.
        /// </para>
        /// </summary>
        public MonitoringConfigurationUpdate MonitoringConfigurationUpdate
        {
            get { return this._monitoringConfigurationUpdate; }
            set { this._monitoringConfigurationUpdate = value; }
        }

        // Check to see if MonitoringConfigurationUpdate property is set
        internal bool IsSetMonitoringConfigurationUpdate()
        {
            return this._monitoringConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelismConfigurationUpdate. 
        /// <para>
        /// Describes updates to the parameters for how an application executes multiple tasks
        /// simultaneously.
        /// </para>
        /// </summary>
        public ParallelismConfigurationUpdate ParallelismConfigurationUpdate
        {
            get { return this._parallelismConfigurationUpdate; }
            set { this._parallelismConfigurationUpdate = value; }
        }

        // Check to see if ParallelismConfigurationUpdate property is set
        internal bool IsSetParallelismConfigurationUpdate()
        {
            return this._parallelismConfigurationUpdate != null;
        }

    }
}