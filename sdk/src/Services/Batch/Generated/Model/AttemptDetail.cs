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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents a job attempt.
    /// </summary>
    public partial class AttemptDetail
    {
        private AttemptContainerDetail _container;
        private long? _startedAt;
        private string _statusReason;
        private long? _stoppedAt;
        private List<AttemptEcsTaskDetails> _taskProperties = AWSConfigs.InitializeCollections ? new List<AttemptEcsTaskDetails>() : null;

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// The details for the container in this job attempt.
        /// </para>
        /// </summary>
        public AttemptContainerDetail Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the attempt was started (when the attempt
        /// transitioned from the <c>STARTING</c> state to the <c>RUNNING</c> state).
        /// </para>
        /// </summary>
        public long? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide additional details for the current status
        /// of the job attempt.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the attempt was stopped (when the attempt
        /// transitioned from the <c>RUNNING</c> state to a terminal state, such as <c>SUCCEEDED</c>
        /// or <c>FAILED</c>).
        /// </para>
        /// </summary>
        public long? StoppedAt
        {
            get { return this._stoppedAt; }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskProperties. 
        /// <para>
        /// The properties for a task definition that describes the container and volume definitions
        /// of an Amazon ECS task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttemptEcsTaskDetails> TaskProperties
        {
            get { return this._taskProperties; }
            set { this._taskProperties = value; }
        }

        // Check to see if TaskProperties property is set
        internal bool IsSetTaskProperties()
        {
            return this._taskProperties != null && (this._taskProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}