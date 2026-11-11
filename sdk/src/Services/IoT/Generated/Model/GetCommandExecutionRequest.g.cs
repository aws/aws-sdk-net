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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the GetCommandExecution operation. Gets information
    /// about the specific command execution on a single device.
    /// </summary>
    public partial class GetCommandExecutionRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The unique identifier for the command execution. This information is returned as a
        /// response of the <c>StartCommandExecution</c> API request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property IncludeResult. 
        /// <para>
        /// Can be used to specify whether to include the result of the command execution in the
        /// <c>GetCommandExecution</c> API response. Your device can use this field to provide
        /// additional information about the command execution. You only need to specify this
        /// field when using the <c>AWS-IoT</c> namespace.
        /// </para>
        /// </summary>
        public bool? IncludeResult { get; set; }

        /// <summary>
        /// Checks to see if the IncludeResult property is set.
        /// </summary>
        internal bool IsSetIncludeResult() => this.IncludeResult.HasValue;

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the device on which the command execution is being
        /// performed.
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
