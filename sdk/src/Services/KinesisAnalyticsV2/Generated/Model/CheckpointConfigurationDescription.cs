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
    /// Describes checkpointing parameters for a Managed Service for Apache Flink application.
    /// </summary>
    public partial class CheckpointConfigurationDescription
    {
        private bool? _checkpointingEnabled;
        private long? _checkpointInterval;
        private ConfigurationType _configurationType;
        private long? _minPauseBetweenCheckpoints;

        /// <summary>
        /// Gets and sets the property CheckpointingEnabled. 
        /// <para>
        /// Describes whether checkpointing is enabled for a Managed Service for Apache Flink
        /// application.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>CheckpointConfiguration.ConfigurationType</c> is <c>DEFAULT</c>, the application
        /// will use a <c>CheckpointingEnabled</c> value of <c>true</c>, even if this value is
        /// set to another value using this API or in application code.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? CheckpointingEnabled
        {
            get { return this._checkpointingEnabled; }
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
        /// If <c>CheckpointConfiguration.ConfigurationType</c> is <c>DEFAULT</c>, the application
        /// will use a <c>CheckpointInterval</c> value of 60000, even if this value is set to
        /// another value using this API or in application code.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? CheckpointInterval
        {
            get { return this._checkpointInterval; }
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
        /// Describes whether the application uses the default checkpointing behavior in Managed
        /// Service for Apache Flink. 
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
        /// that a new checkpoint operation can start. 
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
        public long? MinPauseBetweenCheckpoints
        {
            get { return this._minPauseBetweenCheckpoints; }
            set { this._minPauseBetweenCheckpoints = value; }
        }

        // Check to see if MinPauseBetweenCheckpoints property is set
        internal bool IsSetMinPauseBetweenCheckpoints()
        {
            return this._minPauseBetweenCheckpoints.HasValue; 
        }

    }
}