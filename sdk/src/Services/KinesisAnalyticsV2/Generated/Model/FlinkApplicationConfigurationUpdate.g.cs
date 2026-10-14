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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CheckpointConfigurationUpdate. 
        /// <para>
        /// Describes updates to an application's checkpointing configuration. Checkpointing is
        /// the process of persisting application state for fault tolerance.
        /// </para>
        /// </summary>
        public CheckpointConfigurationUpdate CheckpointConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the CheckpointConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetCheckpointConfigurationUpdate() => this.CheckpointConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property MonitoringConfigurationUpdate. 
        /// <para>
        /// Describes updates to the configuration parameters for Amazon CloudWatch logging for
        /// an application.
        /// </para>
        /// </summary>
        public MonitoringConfigurationUpdate MonitoringConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetMonitoringConfigurationUpdate() => this.MonitoringConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property ParallelismConfigurationUpdate. 
        /// <para>
        /// Describes updates to the parameters for how an application executes multiple tasks
        /// simultaneously.
        /// </para>
        /// </summary>
        public ParallelismConfigurationUpdate ParallelismConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ParallelismConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetParallelismConfigurationUpdate() => this.ParallelismConfigurationUpdate != null;
    }
}
