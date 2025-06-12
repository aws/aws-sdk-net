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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains parameters for a Lambda function that runs on IoT Greengrass.
    /// </summary>
    public partial class LambdaExecutionParameters
    {
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<LambdaEventSource> _eventSources = AWSConfigs.InitializeCollections ? new List<LambdaEventSource>() : null;
        private List<string> _execArgs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private LambdaInputPayloadEncodingType _inputPayloadEncodingType;
        private LambdaLinuxProcessParams _linuxProcessParams;
        private int? _maxIdleTimeInSeconds;
        private int? _maxInstancesCount;
        private int? _maxQueueSize;
        private bool? _pinned;
        private int? _statusTimeoutInSeconds;
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The map of environment variables that are available to the Lambda function when it
        /// runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventSources. 
        /// <para>
        /// The list of event sources to which to subscribe to receive work messages. The Lambda
        /// function runs when it receives a message from an event source. You can subscribe this
        /// function to local publish/subscribe messages and Amazon Web Services IoT Core MQTT
        /// messages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaEventSource> EventSources
        {
            get { return this._eventSources; }
            set { this._eventSources = value; }
        }

        // Check to see if EventSources property is set
        internal bool IsSetEventSources()
        {
            return this._eventSources != null && (this._eventSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecArgs. 
        /// <para>
        /// The list of arguments to pass to the Lambda function when it runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExecArgs
        {
            get { return this._execArgs; }
            set { this._execArgs = value; }
        }

        // Check to see if ExecArgs property is set
        internal bool IsSetExecArgs()
        {
            return this._execArgs != null && (this._execArgs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputPayloadEncodingType. 
        /// <para>
        /// The encoding type that the Lambda function supports.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>json</c> 
        /// </para>
        /// </summary>
        public LambdaInputPayloadEncodingType InputPayloadEncodingType
        {
            get { return this._inputPayloadEncodingType; }
            set { this._inputPayloadEncodingType = value; }
        }

        // Check to see if InputPayloadEncodingType property is set
        internal bool IsSetInputPayloadEncodingType()
        {
            return this._inputPayloadEncodingType != null;
        }

        /// <summary>
        /// Gets and sets the property LinuxProcessParams. 
        /// <para>
        /// The parameters for the Linux process that contains the Lambda function.
        /// </para>
        /// </summary>
        public LambdaLinuxProcessParams LinuxProcessParams
        {
            get { return this._linuxProcessParams; }
            set { this._linuxProcessParams = value; }
        }

        // Check to see if LinuxProcessParams property is set
        internal bool IsSetLinuxProcessParams()
        {
            return this._linuxProcessParams != null;
        }

        /// <summary>
        /// Gets and sets the property MaxIdleTimeInSeconds. 
        /// <para>
        /// The maximum amount of time in seconds that a non-pinned Lambda function can idle before
        /// the IoT Greengrass Core software stops its process.
        /// </para>
        /// </summary>
        public int? MaxIdleTimeInSeconds
        {
            get { return this._maxIdleTimeInSeconds; }
            set { this._maxIdleTimeInSeconds = value; }
        }

        // Check to see if MaxIdleTimeInSeconds property is set
        internal bool IsSetMaxIdleTimeInSeconds()
        {
            return this._maxIdleTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxInstancesCount. 
        /// <para>
        /// The maximum number of instances that a non-pinned Lambda function can run at the same
        /// time.
        /// </para>
        /// </summary>
        public int? MaxInstancesCount
        {
            get { return this._maxInstancesCount; }
            set { this._maxInstancesCount = value; }
        }

        // Check to see if MaxInstancesCount property is set
        internal bool IsSetMaxInstancesCount()
        {
            return this._maxInstancesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxQueueSize. 
        /// <para>
        /// The maximum size of the message queue for the Lambda function component. The IoT Greengrass
        /// core stores messages in a FIFO (first-in-first-out) queue until it can run the Lambda
        /// function to consume each message.
        /// </para>
        /// </summary>
        public int? MaxQueueSize
        {
            get { return this._maxQueueSize; }
            set { this._maxQueueSize = value; }
        }

        // Check to see if MaxQueueSize property is set
        internal bool IsSetMaxQueueSize()
        {
            return this._maxQueueSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pinned. 
        /// <para>
        /// Whether or not the Lambda function is pinned, or long-lived.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A pinned Lambda function starts when IoT Greengrass starts and keeps running in its
        /// own container.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A non-pinned Lambda function starts only when it receives a work item and exists after
        /// it idles for <c>maxIdleTimeInSeconds</c>. If the function has multiple work items,
        /// the IoT Greengrass Core software creates multiple instances of the function.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>true</c> 
        /// </para>
        /// </summary>
        public bool? Pinned
        {
            get { return this._pinned; }
            set { this._pinned = value; }
        }

        // Check to see if Pinned property is set
        internal bool IsSetPinned()
        {
            return this._pinned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusTimeoutInSeconds. 
        /// <para>
        /// The interval in seconds at which a pinned (also known as long-lived) Lambda function
        /// component sends status updates to the Lambda manager component.
        /// </para>
        /// </summary>
        public int? StatusTimeoutInSeconds
        {
            get { return this._statusTimeoutInSeconds; }
            set { this._statusTimeoutInSeconds = value; }
        }

        // Check to see if StatusTimeoutInSeconds property is set
        internal bool IsSetStatusTimeoutInSeconds()
        {
            return this._statusTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The maximum amount of time in seconds that the Lambda function can process a work
        /// item.
        /// </para>
        /// </summary>
        public int? TimeoutInSeconds
        {
            get { return this._timeoutInSeconds; }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}