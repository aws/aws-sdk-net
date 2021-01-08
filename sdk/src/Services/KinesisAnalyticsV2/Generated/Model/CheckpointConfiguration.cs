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
    /// Describes an application's checkpointing configuration. Checkpointing is the process
    /// of persisting application state for fault tolerance. For more information, see <a
    /// href="https://ci.apache.org/projects/flink/flink-docs-release-1.8/concepts/programming-model.html#checkpoints-for-fault-tolerance">
    /// Checkpoints for Fault Tolerance</a> in the <a href="https://ci.apache.org/projects/flink/flink-docs-release-1.8/">Apache
    /// Flink Documentation</a>.
    /// </summary>
    public partial class CheckpointConfiguration
    {
        private bool? _checkpointingEnabled;
        private long? _checkpointInterval;
        private ConfigurationType _configurationType;
        private long? _minPauseBetweenCheckpoints;

        /// <summary>
        /// Gets and sets the property CheckpointingEnabled. 
        /// <para>
        /// Describes whether checkpointing is enabled for a Flink-based Kinesis Data Analytics
        /// application.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>CheckpointConfiguration.ConfigurationType</code> is <code>DEFAULT</code>,
        /// the application will use a <code>CheckpointingEnabled</code> value of <code>true</code>,
        /// even if this value is set to another value using this API or in application code.
        /// </para>
        ///  </note>
        /// </summary>
        public bool CheckpointingEnabled
        {
            get { return this._checkpointingEnabled.GetValueOrDefault(); }
            set { this._checkpointingEnabled = value; }
        }

        // Check to see if CheckpointingEnabled property is set
        internal bool IsSetCheckpointingEnabled()
        {
            return this._checkpointingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CheckpointInterval. 
        /// <para>
        /// Describes the interval in milliseconds between checkpoint operations. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>CheckpointConfiguration.ConfigurationType</code> is <code>DEFAULT</code>,
        /// the application will use a <code>CheckpointInterval</code> vaue of 60000, even if
        /// this value is set to another value using this API or in application code.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1)]
        public long CheckpointInterval
        {
            get { return this._checkpointInterval.GetValueOrDefault(); }
            set { this._checkpointInterval = value; }
        }

        // Check to see if CheckpointInterval property is set
        internal bool IsSetCheckpointInterval()
        {
            return this._checkpointInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        /// Describes whether the application uses Kinesis Data Analytics' default checkpointing
        /// behavior. You must set this property to <code>CUSTOM</code> in order to set the <code>CheckpointingEnabled</code>,
        /// <code>CheckpointInterval</code>, or <code>MinPauseBetweenCheckpoints</code> parameters.
        /// </para>
        ///  <note> 
        /// <para>
        /// If this value is set to <code>DEFAULT</code>, the application will use the following
        /// values, even if they are set to other values using APIs or application code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>CheckpointingEnabled:</b> true
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CheckpointInterval:</b> 60000
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MinPauseBetweenCheckpoints:</b> 5000
        /// </para>
        ///  </li> </ul> </note>
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
        /// Gets and sets the property MinPauseBetweenCheckpoints. 
        /// <para>
        /// Describes the minimum time in milliseconds after a checkpoint operation completes
        /// that a new checkpoint operation can start. If a checkpoint operation takes longer
        /// than the <code>CheckpointInterval</code>, the application otherwise performs continual
        /// checkpoint operations. For more information, see <a href="https://ci.apache.org/projects/flink/flink-docs-release-1.8/ops/state/large_state_tuning.html#tuning-checkpointing">
        /// Tuning Checkpointing</a> in the <a href="https://ci.apache.org/projects/flink/flink-docs-release-1.8/">Apache
        /// Flink Documentation</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>CheckpointConfiguration.ConfigurationType</code> is <code>DEFAULT</code>,
        /// the application will use a <code>MinPauseBetweenCheckpoints</code> value of 5000,
        /// even if this value is set using this API or in application code.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
        public long MinPauseBetweenCheckpoints
        {
            get { return this._minPauseBetweenCheckpoints.GetValueOrDefault(); }
            set { this._minPauseBetweenCheckpoints = value; }
        }

        // Check to see if MinPauseBetweenCheckpoints property is set
        internal bool IsSetMinPauseBetweenCheckpoints()
        {
            return this._minPauseBetweenCheckpoints.HasValue; 
        }

    }
}