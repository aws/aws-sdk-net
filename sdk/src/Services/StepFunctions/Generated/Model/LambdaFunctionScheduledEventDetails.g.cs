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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about a Lambda function scheduled during an execution.
    /// </summary>
    public partial class LambdaFunctionScheduledEventDetails
    {
        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The JSON data input to the Lambda function. Length constraints apply to the payload
        /// size, and are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property InputDetails. 
        /// <para>
        /// Contains details about input for an execution history event.
        /// </para>
        /// </summary>
        public HistoryEventExecutionDataDetails InputDetails { get; set; }

        /// <summary>
        /// Checks to see if the InputDetails property is set.
        /// </summary>
        internal bool IsSetInputDetails() => this.InputDetails != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scheduled Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property TaskCredentials. 
        /// <para>
        /// The credentials that Step Functions uses for the task.
        /// </para>
        /// </summary>
        public TaskCredentials TaskCredentials { get; set; }

        /// <summary>
        /// Checks to see if the TaskCredentials property is set.
        /// </summary>
        internal bool IsSetTaskCredentials() => this.TaskCredentials != null;

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The maximum allowed duration of the Lambda function.
        /// </para>
        /// </summary>
        public long? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutInSeconds() => this.TimeoutInSeconds.HasValue;
    }
}
