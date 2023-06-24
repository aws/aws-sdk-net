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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private HandlerErrorCode _errorCode;
        private DateTime? _eventTime;
        private string _identifier;
        private Operation _operation;
        private OperationStatus _operationStatus;
        private string _requestToken;
        private string _resourceModel;
        private DateTime? _retryAfter;
        private string _statusMessage;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// For requests with a status of <code>FAILED</code>, the associated error code.
        /// </para>
        ///  
        /// <para>
        /// For error code definitions, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-test-contract-errors.html">Handler
        /// error codes</a> in the <i>CloudFormation Command Line Interface User Guide for Extension
        /// Development</i>.
        /// </para>
        /// </summary>
        public HandlerErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// When the resource operation request was initiated.
        /// </para>
        /// </summary>
        public DateTime EventTime
        {
            get { return this._eventTime.GetValueOrDefault(); }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The primary identifier for the resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// In some cases, the resource identifier may be available before the resource operation
        /// has reached a status of <code>SUCCESS</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The resource operation type.
        /// </para>
        /// </summary>
        public Operation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property OperationStatus. 
        /// <para>
        /// The current status of the resource operation request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code>: The resource operation hasn't yet started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code>: The resource operation is currently in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCESS</code>: The resource operation has successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code>: The resource operation has failed. Refer to the error code and
        /// status message for more information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCEL_IN_PROGRESS</code>: The resource operation is in the process of being
        /// canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCEL_COMPLETE</code>: The resource operation has been canceled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OperationStatus OperationStatus
        {
            get { return this._operationStatus; }
            set { this._operationStatus = value; }
        }

        // Check to see if OperationStatus property is set
        internal bool IsSetOperationStatus()
        {
            return this._operationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RequestToken. 
        /// <para>
        /// The unique token representing this resource operation request.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>RequestToken</code> with <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
        /// to return the current status of a resource operation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RequestToken
        {
            get { return this._requestToken; }
            set { this._requestToken = value; }
        }

        // Check to see if RequestToken property is set
        internal bool IsSetRequestToken()
        {
            return this._requestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceModel. 
        /// <para>
        /// A JSON string containing the resource model, consisting of each resource property
        /// and its current value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=65536)]
        public string ResourceModel
        {
            get { return this._resourceModel; }
            set { this._resourceModel = value; }
        }

        // Check to see if ResourceModel property is set
        internal bool IsSetResourceModel()
        {
            return this._resourceModel != null;
        }

        /// <summary>
        /// Gets and sets the property RetryAfter. 
        /// <para>
        /// When to next request the status of this resource operation request.
        /// </para>
        /// </summary>
        public DateTime RetryAfter
        {
            get { return this._retryAfter.GetValueOrDefault(); }
            set { this._retryAfter = value; }
        }

        // Check to see if RetryAfter property is set
        internal bool IsSetRetryAfter()
        {
            return this._retryAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Any message explaining the current status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the resource type used in the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=196)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}