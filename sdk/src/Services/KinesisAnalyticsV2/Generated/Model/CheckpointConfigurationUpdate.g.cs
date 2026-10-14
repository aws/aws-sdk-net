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
    /// Describes updates to the checkpointing parameters for a Managed Service for Apache
    /// Flink application.
    /// </summary>
    public partial class CheckpointConfigurationUpdate
    {
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
        [AWSProperty(Min = 1)]
        public long? CheckpointIntervalUpdate { get; set; }

        /// <summary>
        /// Checks to see if the CheckpointIntervalUpdate property is set.
        /// </summary>
        internal bool IsSetCheckpointIntervalUpdate() => this.CheckpointIntervalUpdate.HasValue;

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
        public bool? CheckpointingEnabledUpdate { get; set; }

        /// <summary>
        /// Checks to see if the CheckpointingEnabledUpdate property is set.
        /// </summary>
        internal bool IsSetCheckpointingEnabledUpdate() => this.CheckpointingEnabledUpdate.HasValue;

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
        public ConfigurationType ConfigurationTypeUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationTypeUpdate property is set.
        /// </summary>
        internal bool IsSetConfigurationTypeUpdate() => this.ConfigurationTypeUpdate != null;

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
        [AWSProperty(Min = 0)]
        public long? MinPauseBetweenCheckpointsUpdate { get; set; }

        /// <summary>
        /// Checks to see if the MinPauseBetweenCheckpointsUpdate property is set.
        /// </summary>
        internal bool IsSetMinPauseBetweenCheckpointsUpdate() => this.MinPauseBetweenCheckpointsUpdate.HasValue;
    }
}
