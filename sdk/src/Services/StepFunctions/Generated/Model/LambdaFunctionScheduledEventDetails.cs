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
    /// Contains details about a Lambda function scheduled during an execution.
    /// </summary>
    public partial class LambdaFunctionScheduledEventDetails
    {
        private string _input;
        private HistoryEventExecutionDataDetails _inputDetails;
        private string _resource;
        private TaskCredentials _taskCredentials;
        private long? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The JSON data input to the Lambda function. Length constraints apply to the payload
        /// size, and are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property InputDetails. 
        /// <para>
        /// Contains details about input for an execution history event.
        /// </para>
        /// </summary>
        public HistoryEventExecutionDataDetails InputDetails
        {
            get { return this._inputDetails; }
            set { this._inputDetails = value; }
        }

        // Check to see if InputDetails property is set
        internal bool IsSetInputDetails()
        {
            return this._inputDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scheduled Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The maximum allowed duration of the Lambda function.
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