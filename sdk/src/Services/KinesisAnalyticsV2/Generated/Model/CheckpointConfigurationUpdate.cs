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
    /// Describes updates to the checkpointing parameters for a Managed Service for Apache
    /// Flink application.
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
        ///  <note> 
        /// <para>
        /// If <c>CheckpointConfiguration.ConfigurationType</c> is <c>DEFAULT</c>, the application
        /// will use a <c>CheckpointingEnabled</c> value of <c>true</c>, even if this value is
        /// set to another value using this API or in application code.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? CheckpointingEnabledUpdate
        {
            get { return this._checkpointingEnabledUpdate; }
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
        ///  <note> 
        /// <para>
        /// If <c>CheckpointConfiguration.ConfigurationType</c> is <c>DEFAULT</c>, the application
        /// will use a <c>CheckpointInterval</c> value of 60000, even if this value is set to
        /// another value using this API or in application code.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? CheckpointIntervalUpdate
        {
            get { return this._checkpointIntervalUpdate; }
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
        /// of Managed Service for Apache Flink. You must set this property to <c>CUSTOM</c> in
        /// order to set the <c>CheckpointingEnabled</c>, <c>CheckpointInterval</c>, or <c>MinPauseBetweenCheckpoints</c>
        /// parameters. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If this value is set to <c>DEFAULT</c>, the application will use the following values,
        /// even if they are set to other values using APIs or application code:
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
        ///  <note> 
        /// <para>
        /// If <c>CheckpointConfiguration.ConfigurationType</c> is <c>DEFAULT</c>, the application
        /// will use a <c>MinPauseBetweenCheckpoints</c> value of 5000, even if this value is
        /// set using this API or in application code.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? MinPauseBetweenCheckpointsUpdate
        {
            get { return this._minPauseBetweenCheckpointsUpdate; }
            set { this._minPauseBetweenCheckpointsUpdate = value; }
        }

        // Check to see if MinPauseBetweenCheckpointsUpdate property is set
        internal bool IsSetMinPauseBetweenCheckpointsUpdate()
        {
            return this._minPauseBetweenCheckpointsUpdate.HasValue; 
        }

    }
}