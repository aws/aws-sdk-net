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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains parameters for a Lambda function that runs on IoT Greengrass.
    /// </summary>
    public partial class LambdaExecutionParameters
    {
        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The map of environment variables that are available to the Lambda function when it
        /// runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventSources. 
        /// <para>
        /// The list of event sources to which to subscribe to receive work messages. The Lambda
        /// function runs when it receives a message from an event source. You can subscribe this
        /// function to local publish/subscribe messages and Amazon Web Services IoT Core MQTT
        /// messages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaEventSource> EventSources { get; set; } = AWSConfigs.InitializeCollections ? new List<LambdaEventSource>() : null;

        /// <summary>
        /// Checks to see if the EventSources property is set.
        /// </summary>
        internal bool IsSetEventSources() => this.EventSources != null && (this.EventSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecArgs. 
        /// <para>
        /// The list of arguments to pass to the Lambda function when it runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExecArgs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExecArgs property is set.
        /// </summary>
        internal bool IsSetExecArgs() => this.ExecArgs != null && (this.ExecArgs.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public LambdaInputPayloadEncodingType InputPayloadEncodingType { get; set; }

        /// <summary>
        /// Checks to see if the InputPayloadEncodingType property is set.
        /// </summary>
        internal bool IsSetInputPayloadEncodingType() => this.InputPayloadEncodingType != null;

        /// <summary>
        /// Gets and sets the property LinuxProcessParams. 
        /// <para>
        /// The parameters for the Linux process that contains the Lambda function.
        /// </para>
        /// </summary>
        public LambdaLinuxProcessParams LinuxProcessParams { get; set; }

        /// <summary>
        /// Checks to see if the LinuxProcessParams property is set.
        /// </summary>
        internal bool IsSetLinuxProcessParams() => this.LinuxProcessParams != null;

        /// <summary>
        /// Gets and sets the property MaxIdleTimeInSeconds. 
        /// <para>
        /// The maximum amount of time in seconds that a non-pinned Lambda function can idle before
        /// the IoT Greengrass Core software stops its process.
        /// </para>
        /// </summary>
        public int? MaxIdleTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxIdleTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetMaxIdleTimeInSeconds() => this.MaxIdleTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MaxInstancesCount. 
        /// <para>
        /// The maximum number of instances that a non-pinned Lambda function can run at the same
        /// time.
        /// </para>
        /// </summary>
        public int? MaxInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxInstancesCount property is set.
        /// </summary>
        internal bool IsSetMaxInstancesCount() => this.MaxInstancesCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaxQueueSize. 
        /// <para>
        /// The maximum size of the message queue for the Lambda function component. The IoT Greengrass
        /// core stores messages in a FIFO (first-in-first-out) queue until it can run the Lambda
        /// function to consume each message.
        /// </para>
        /// </summary>
        public int? MaxQueueSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxQueueSize property is set.
        /// </summary>
        internal bool IsSetMaxQueueSize() => this.MaxQueueSize.HasValue;

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
        public bool? Pinned { get; set; }

        /// <summary>
        /// Checks to see if the Pinned property is set.
        /// </summary>
        internal bool IsSetPinned() => this.Pinned.HasValue;

        /// <summary>
        /// Gets and sets the property StatusTimeoutInSeconds. 
        /// <para>
        /// The interval in seconds at which a pinned (also known as long-lived) Lambda function
        /// component sends status updates to the Lambda manager component.
        /// </para>
        /// </summary>
        public int? StatusTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the StatusTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetStatusTimeoutInSeconds() => this.StatusTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The maximum amount of time in seconds that the Lambda function can process a work
        /// item.
        /// </para>
        /// </summary>
        public int? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutInSeconds() => this.TimeoutInSeconds.HasValue;
    }
}
