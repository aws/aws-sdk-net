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

namespace Amazon.IoTJobsDataPlane.Model
{
    /// <summary>
    /// Container for the parameters to the StartCommandExecution operation. Using the command
    /// created with the <c>CreateCommand</c> API, start a command execution on a specific
    /// device.
    /// </summary>
    public partial class StartCommandExecutionRequest : AmazonIoTJobsDataPlaneRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token is used to implement idempotency. It ensures that the request completes
        /// no more than one time. If you retry a request with the same token and the same parameters,
        /// the request will complete successfully. However, if you retry the request using the
        /// same token but different parameters, an HTTP 409 conflict occurs. If you omit this
        /// value, Amazon Web Services SDKs will automatically generate a unique client request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CommandArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the command. For example, <c>arn:aws:iot:&lt;region&gt;:&lt;accountid&gt;:command/&lt;commandName&gt;</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CommandArn { get; set; }

        /// <summary>
        /// Checks to see if the CommandArn property is set.
        /// </summary>
        internal bool IsSetCommandArn() => this.CommandArn != null;

        /// <summary>
        /// Gets and sets the property ExecutionTimeoutSeconds. 
        /// <para>
        /// Specifies the amount of time in second the device has to finish the command execution.
        /// A timer is started as soon as the command execution is created. If the command execution
        /// status is not set to another terminal state before the timer expires, it will automatically
        /// update to <c>TIMED_OUT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ExecutionTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetExecutionTimeoutSeconds() => this.ExecutionTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of parameters that are required by the <c>StartCommandExecution</c> API when
        /// performing the command on a device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public Dictionary<string, CommandParameterValue> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CommandParameterValue>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the device where the command execution is occurring.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}
