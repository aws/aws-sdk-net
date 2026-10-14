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

namespace Amazon.SageMakerTrainingSessionRuntime.Model
{
    /// <summary>
    /// This is the response object from the GetSamplingOperationResult operation.
    /// </summary>
    public partial class GetSamplingOperationResultResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// A message describing why the sample operation failed. The service populates this field
        /// only when the status is <c>Failed</c>.
        /// </para>
        /// </summary>
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property OperationResult. 
        /// <para>
        /// The result payload of the sample operation. The service populates this field only
        /// when the status is <c>Completed</c>.
        /// </para>
        /// </summary>
        public SampleOperationResult OperationResult { get; set; }

        /// <summary>
        /// Checks to see if the OperationResult property is set.
        /// </summary>
        internal bool IsSetOperationResult() => this.OperationResult != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the sample operation. Possible values are <c>Pending</c>, <c>InProgress</c>,
        /// <c>Completed</c>, or <c>Failed</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
