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
    /// An update to be applied to an operation during checkpointing.
    /// </summary>
    public partial class OperationUpdate
    {
        private OperationAction _action;
        private CallbackOptions _callbackOptions;
        private ChainedInvokeOptions _chainedInvokeOptions;
        private ContextOptions _contextOptions;
        private ErrorObject _error;
        private string _id;
        private string _name;
        private string _parentId;
        private string _payload;
        private StepOptions _stepOptions;
        private string _subType;
        private OperationType _type;
        private WaitOptions _waitOptions;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take on the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperationAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property CallbackOptions.
        /// </summary>
        public CallbackOptions CallbackOptions
        {
            get { return this._callbackOptions; }
            set { this._callbackOptions = value; }
        }

        // Check to see if CallbackOptions property is set
        internal bool IsSetCallbackOptions()
        {
            return this._callbackOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ChainedInvokeOptions.
        /// </summary>
        public ChainedInvokeOptions ChainedInvokeOptions
        {
            get { return this._chainedInvokeOptions; }
            set { this._chainedInvokeOptions = value; }
        }

        // Check to see if ChainedInvokeOptions property is set
        internal bool IsSetChainedInvokeOptions()
        {
            return this._chainedInvokeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ContextOptions. 
        /// <para>
        /// Options for context operations.
        /// </para>
        /// </summary>
        public ContextOptions ContextOptions
        {
            get { return this._contextOptions; }
            set { this._contextOptions = value; }
        }

        // Check to see if ContextOptions property is set
        internal bool IsSetContextOptions()
        {
            return this._contextOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error information for failed operations.
        /// </para>
        /// </summary>
        public ErrorObject Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
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
        /// Gets and sets the property Payload. 
        /// <para>
        /// The payload for successful operations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=6291456)]
        public string Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property StepOptions. 
        /// <para>
        /// Options for step operations.
        /// </para>
        /// </summary>
        public StepOptions StepOptions
        {
            get { return this._stepOptions; }
            set { this._stepOptions = value; }
        }

        // Check to see if StepOptions property is set
        internal bool IsSetStepOptions()
        {
            return this._stepOptions != null;
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
        /// The type of operation to update.
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
        /// Gets and sets the property WaitOptions. 
        /// <para>
        /// Options for wait operations.
        /// </para>
        /// </summary>
        public WaitOptions WaitOptions
        {
            get { return this._waitOptions; }
            set { this._waitOptions = value; }
        }

        // Check to see if WaitOptions property is set
        internal bool IsSetWaitOptions()
        {
            return this._waitOptions != null;
        }

    }
}