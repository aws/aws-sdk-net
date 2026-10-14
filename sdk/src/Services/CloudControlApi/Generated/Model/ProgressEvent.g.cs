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

namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// Represents the current status of a resource operation request. For more information,
    /// see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html">Managing
    /// resource operation requests</a> in the <i>Amazon Web Services Cloud Control API User
    /// Guide</i>.
    /// </summary>
    public partial class ProgressEvent
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// For requests with a status of <c>FAILED</c>, the associated error code.
        /// </para>
        ///  
        /// <para>
        /// For error code definitions, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-test-contract-errors.html">Handler
        /// error codes</a> in the <i>CloudFormation Command Line Interface User Guide for Extension
        /// Development</i>.
        /// </para>
        /// </summary>
        public HandlerErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// When the resource operation request was initiated.
        /// </para>
        /// </summary>
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// Checks to see if the EventTime property is set.
        /// </summary>
        internal bool IsSetEventTime() => this.EventTime.HasValue;

        /// <summary>
        /// Gets and sets the property HooksRequestToken. 
        /// <para>
        /// The unique token representing the Hooks operation for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string HooksRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the HooksRequestToken property is set.
        /// </summary>
        internal bool IsSetHooksRequestToken() => this.HooksRequestToken != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The primary identifier for the resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// In some cases, the resource identifier may be available before the resource operation
        /// has reached a status of <c>SUCCESS</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The resource operation type.
        /// </para>
        /// </summary>
        public Operation Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property OperationStatus. 
        /// <para>
        /// The current status of the resource operation request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>: The resource operation hasn't yet started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c>: The resource operation is currently in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c>: The resource operation has successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The resource operation has failed. Refer to the error code and status
        /// message for more information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCEL_IN_PROGRESS</c>: The resource operation is in the process of being canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCEL_COMPLETE</c>: The resource operation has been canceled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OperationStatus OperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the OperationStatus property is set.
        /// </summary>
        internal bool IsSetOperationStatus() => this.OperationStatus != null;

        /// <summary>
        /// Gets and sets the property RequestToken. 
        /// <para>
        /// The unique token representing this resource operation request.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>RequestToken</c> with <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
        /// to return the current status of a resource operation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RequestToken { get; set; }

        /// <summary>
        /// Checks to see if the RequestToken property is set.
        /// </summary>
        internal bool IsSetRequestToken() => this.RequestToken != null;

        /// <summary>
        /// Gets and sets the property ResourceModel. 
        /// <para>
        /// A JSON string containing the resource model, consisting of each resource property
        /// and its current value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 262144)]
        public string ResourceModel { get; set; }

        /// <summary>
        /// Checks to see if the ResourceModel property is set.
        /// </summary>
        internal bool IsSetResourceModel() => this.ResourceModel != null;

        /// <summary>
        /// Gets and sets the property RetryAfter. 
        /// <para>
        /// When to next request the status of this resource operation request.
        /// </para>
        /// </summary>
        public DateTime? RetryAfter { get; set; }

        /// <summary>
        /// Checks to see if the RetryAfter property is set.
        /// </summary>
        internal bool IsSetRetryAfter() => this.RetryAfter.HasValue;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Any message explaining the current status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the resource type used in the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 196)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}
