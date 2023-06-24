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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about a task scheduled during an execution.
    /// </summary>
    public partial class TaskScheduledEventDetails
    {
        private long? _heartbeatInSeconds;
        private string _parameters;
        private string _region;
        private string _resource;
        private string _resourceType;
        private TaskCredentials _taskCredentials;
        private long? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property HeartbeatInSeconds. 
        /// <para>
        /// The maximum allowed duration between two heartbeats for the task.
        /// </para>
        /// </summary>
        public long HeartbeatInSeconds
        {
            get { return this._heartbeatInSeconds.GetValueOrDefault(); }
            set { this._heartbeatInSeconds = value; }
        }

        // Check to see if HeartbeatInSeconds property is set
        internal bool IsSetHeartbeatInSeconds()
        {
            return this._heartbeatInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The JSON data passed to the resource referenced in a task state. Length constraints
        /// apply to the payload size, and are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=262144)]
        public string Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The region of the scheduled task
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The action of the resource called by a task state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The service name of the resource in a task state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TaskCredentials. 
        /// <para>
        /// The credentials that Step Functions uses for the task.
        /// </para>
        /// </summary>
        public TaskCredentials TaskCredentials
        {
            get { return this._taskCredentials; }
            set { this._taskCredentials = value; }
        }

        // Check to see if TaskCredentials property is set
        internal bool IsSetTaskCredentials()
        {
            return this._taskCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The maximum allowed duration of the task.
        /// </para>
        /// </summary>
        public long TimeoutInSeconds
        {
            get { return this._timeoutInSeconds.GetValueOrDefault(); }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}