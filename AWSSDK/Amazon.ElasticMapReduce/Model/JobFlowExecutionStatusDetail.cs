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
        private string _state;


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


        /// <summary>
        /// Sets the CreationDateTime property
        /// </summary>
        /// <param name="creationDateTime">The value to set for the CreationDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobFlowExecutionStatusDetail WithCreationDateTime(DateTime creationDateTime)
        {
            this._creationDateTime = creationDateTime;
            return this;
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


        /// <summary>
        /// Sets the EndDateTime property
        /// </summary>
        /// <param name="endDateTime">The value to set for the EndDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobFlowExecutionStatusDetail WithEndDateTime(DateTime endDateTime)
        {
            this._endDateTime = endDateTime;
            return this;
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


        /// <summary>
        /// Sets the LastStateChangeReason property
        /// </summary>
        /// <param name="lastStateChangeReason">The value to set for the LastStateChangeReason property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobFlowExecutionStatusDetail WithLastStateChangeReason(string lastStateChangeReason)
        {
            this._lastStateChangeReason = lastStateChangeReason;
            return this;
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


        /// <summary>
        /// Sets the ReadyDateTime property
        /// </summary>
        /// <param name="readyDateTime">The value to set for the ReadyDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobFlowExecutionStatusDetail WithReadyDateTime(DateTime readyDateTime)
        {
            this._readyDateTime = readyDateTime;
            return this;
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


        /// <summary>
        /// Sets the StartDateTime property
        /// </summary>
        /// <param name="startDateTime">The value to set for the StartDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobFlowExecutionStatusDetail WithStartDateTime(DateTime startDateTime)
        {
            this._startDateTime = startDateTime;
            return this;
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
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }


        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">The value to set for the State property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobFlowExecutionStatusDetail WithState(string state)
        {
            this._state = state;
            return this;
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}