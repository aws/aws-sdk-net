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
    /// Describes updates to the checkpointing parameters for a Java-based Amazon Kinesis
    /// Data Analytics application.
    /// </summary>
    public partial class CheckpointConfigurationUpdate
    {
        private bool? _checkpointingEnabledUpdate;
        private long? _checkpointIntervalUpdate;
        private ConfigurationType _configurationTypeUpdate;
        private long? _minPauseBetweenCheckpointsUpdate;

        /// <summary>
        /// Gets and sets the property CheckpointingEnabledUpdate. 
        /// <para>
        /// Describes updates to whether checkpointing is enabled for an application.
        /// </para>
        /// </summary>
        public bool CheckpointingEnabledUpdate
        {
            get { return this._checkpointingEnabledUpdate.GetValueOrDefault(); }
            set { this._checkpointingEnabledUpdate = value; }
        }

        // Check to see if CheckpointingEnabledUpdate property is set
        internal bool IsSetCheckpointingEnabledUpdate()
        {
            return this._checkpointingEnabledUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CheckpointIntervalUpdate. 
        /// <para>
        /// Describes updates to the interval in milliseconds between checkpoint operations.
        /// </para>
        /// </summary>
        public long CheckpointIntervalUpdate
        {
            get { return this._checkpointIntervalUpdate.GetValueOrDefault(); }
            set { this._checkpointIntervalUpdate = value; }
        }

        // Check to see if CheckpointIntervalUpdate property is set
        internal bool IsSetCheckpointIntervalUpdate()
        {
            return this._checkpointIntervalUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationTypeUpdate. 
        /// <para>
        /// Describes updates to whether the application uses the default checkpointing behavior
        /// of Kinesis Data Analytics.
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
        /// Gets and sets the property MinPauseBetweenCheckpointsUpdate. 
        /// <para>
        /// Describes updates to the minimum time in milliseconds after a checkpoint operation
        /// completes that a new checkpoint operation can start.
        /// </para>
        /// </summary>
        public long MinPauseBetweenCheckpointsUpdate
        {
            get { return this._minPauseBetweenCheckpointsUpdate.GetValueOrDefault(); }
            set { this._minPauseBetweenCheckpointsUpdate = value; }
        }

        // Check to see if MinPauseBetweenCheckpointsUpdate property is set
        internal bool IsSetMinPauseBetweenCheckpointsUpdate()
        {
            return this._minPauseBetweenCheckpointsUpdate.HasValue; 
        }

    }
}