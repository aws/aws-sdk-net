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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the Invoke operation.
    /// </summary>
    public partial class InvokeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DurableExecutionArn. 
        /// <para>
        /// The ARN of the durable execution that was started. This is returned when invoking
        /// a durable function and provides a unique identifier for tracking the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DurableExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the DurableExecutionArn property is set.
        /// </summary>
        internal bool IsSetDurableExecutionArn() => this.DurableExecutionArn != null;

        /// <summary>
        /// Gets and sets the property ExecutedVersion. 
        /// <para>
        /// The version of the function that executed. When you invoke a function with an alias,
        /// this indicates which version the alias resolved to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ExecutedVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExecutedVersion property is set.
        /// </summary>
        internal bool IsSetExecutedVersion() => this.ExecutedVersion != null;

        /// <summary>
        /// Gets and sets the property FunctionError. 
        /// <para>
        /// If present, indicates that an error occurred during function execution. Details about
        /// the error are included in the response payload.
        /// </para>
        /// </summary>
        public string FunctionError { get; set; }

        /// <summary>
        /// Checks to see if the FunctionError property is set.
        /// </summary>
        internal bool IsSetFunctionError() => this.FunctionError != null;

        /// <summary>
        /// Gets and sets the property LogResult. 
        /// <para>
        /// The last 4 KB of the execution log, which is base64-encoded.
        /// </para>
        /// </summary>
        public string LogResult { get; set; }

        /// <summary>
        /// Checks to see if the LogResult property is set.
        /// </summary>
        internal bool IsSetLogResult() => this.LogResult != null;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The response from the function, or an error object.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public MemoryStream Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code is in the 200 range for a successful request. For the <c>RequestResponse</c>
        /// invocation type, this status code is 200. For the <c>Event</c> invocation type, this
        /// status code is 202. For the <c>DryRun</c> invocation type, the status code is 204.
        /// </para>
        /// </summary>
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;
    }
}
