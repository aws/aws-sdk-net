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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
    /// Information about an operation within a durable execution.
    /// </summary>
    public partial class Operation
    {
        private CallbackDetails _callbackDetails;
        private ChainedInvokeDetails _chainedInvokeDetails;
        private ContextDetails _contextDetails;
        private DateTime? _endTimestamp;
        private ExecutionDetails _executionDetails;
        private string _id;
        private string _name;
        private string _parentId;
        private DateTime? _startTimestamp;
        private OperationStatus _status;
        private StepDetails _stepDetails;
        private string _subType;
        private OperationType _type;
        private WaitDetails _waitDetails;

        /// <summary>
        /// Gets and sets the property CallbackDetails.
        /// </summary>
        public CallbackDetails CallbackDetails
        {
            get { return this._callbackDetails; }
            set { this._callbackDetails = value; }
        }

        // Check to see if CallbackDetails property is set
        internal bool IsSetCallbackDetails()
        {
            return this._callbackDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ChainedInvokeDetails.
        /// </summary>
        public ChainedInvokeDetails ChainedInvokeDetails
        {
            get { return this._chainedInvokeDetails; }
            set { this._chainedInvokeDetails = value; }
        }

        // Check to see if ChainedInvokeDetails property is set
        internal bool IsSetChainedInvokeDetails()
        {
            return this._chainedInvokeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ContextDetails. 
        /// <para>
        /// Details about the context, if this operation represents a context.
        /// </para>
        /// </summary>
        public ContextDetails ContextDetails
        {
            get { return this._contextDetails; }
            set { this._contextDetails = value; }
        }

        // Check to see if ContextDetails property is set
        internal bool IsSetContextDetails()
        {
            return this._contextDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The date and time when the operation ended, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        public DateTime EndTimestamp
        {
            get { return this._endTimestamp.GetValueOrDefault(); }
            set { this._endTimestamp = value; }
        }

        // Check to see if EndTimestamp property is set
        internal bool IsSetEndTimestamp()
        {
            return this._endTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionDetails. 
        /// <para>
        /// Details about the execution, if this operation represents an execution.
        /// </para>
        /// </summary>
        public ExecutionDetails ExecutionDetails
        {
            get { return this._executionDetails; }
            set { this._executionDetails = value; }
        }

        // Check to see if ExecutionDetails property is set
        internal bool IsSetExecutionDetails()
        {
            return this._executionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-provided name for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The unique identifier of the parent operation, if this operation is running within
        /// a child context.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ParentId
        {
            get { return this._parentId; }
            set { this._parentId = value; }
        }

        // Check to see if ParentId property is set
        internal bool IsSetParentId()
        {
            return this._parentId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The date and time when the operation started, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTimestamp
        {
            get { return this._startTimestamp.GetValueOrDefault(); }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StepDetails. 
        /// <para>
        /// Details about the step, if this operation represents a step.
        /// </para>
        /// </summary>
        public StepDetails StepDetails
        {
            get { return this._stepDetails; }
            set { this._stepDetails = value; }
        }

        // Check to see if StepDetails property is set
        internal bool IsSetStepDetails()
        {
            return this._stepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// The subtype of the operation, providing additional categorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string SubType
        {
            get { return this._subType; }
            set { this._subType = value; }
        }

        // Check to see if SubType property is set
        internal bool IsSetSubType()
        {
            return this._subType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property WaitDetails. 
        /// <para>
        /// Details about the wait operation, if this operation represents a wait.
        /// </para>
        /// </summary>
        public WaitDetails WaitDetails
        {
            get { return this._waitDetails; }
            set { this._waitDetails = value; }
        }

        // Check to see if WaitDetails property is set
        internal bool IsSetWaitDetails()
        {
            return this._waitDetails != null;
        }

    }
}