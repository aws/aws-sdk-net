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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Describes the status of the job flow.
    /// </summary>
    public partial class JobFlowExecutionStatusDetail
    {
        private DateTime? _creationDateTime;
        private DateTime? _endDateTime;
        private string _lastStateChangeReason;
        private DateTime? _readyDateTime;
        private DateTime? _startDateTime;
        private JobFlowExecutionState _state;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public JobFlowExecutionStatusDetail() { }

        /// <summary>
        /// Instantiates JobFlowExecutionStatusDetail with the parameterized properties
        /// </summary>
        /// <param name="state">The state of the job flow.</param>
        /// <param name="creationDateTime">The creation date and time of the job flow.</param>
        public JobFlowExecutionStatusDetail(JobFlowExecutionState state, DateTime creationDateTime)
        {
            _state = state;
            _creationDateTime = creationDateTime;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation date and time of the job flow.
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The completion date and time of the job flow.
        /// </para>
        /// </summary>
        public DateTime EndDateTime
        {
            get { return this._endDateTime.GetValueOrDefault(); }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastStateChangeReason. 
        /// <para>
        /// Description of the job flow last changed state.
        /// </para>
        /// </summary>
        public string LastStateChangeReason
        {
            get { return this._lastStateChangeReason; }
            set { this._lastStateChangeReason = value; }
        }

        // Check to see if LastStateChangeReason property is set
        internal bool IsSetLastStateChangeReason()
        {
            return this._lastStateChangeReason != null;
        }

        /// <summary>
        /// Gets and sets the property ReadyDateTime. 
        /// <para>
        /// The date and time when the job flow was ready to start running bootstrap actions.
        /// </para>
        /// </summary>
        public DateTime ReadyDateTime
        {
            get { return this._readyDateTime.GetValueOrDefault(); }
            set { this._readyDateTime = value; }
        }

        // Check to see if ReadyDateTime property is set
        internal bool IsSetReadyDateTime()
        {
            return this._readyDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The start date and time of the job flow.
        /// </para>
        /// </summary>
        public DateTime StartDateTime
        {
            get { return this._startDateTime.GetValueOrDefault(); }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the job flow.
        /// </para>
        /// </summary>
        public JobFlowExecutionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}