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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The summary of a stack refactor operation.
    /// </summary>
    public partial class StackRefactorSummary
    {
        private string _description;
        private StackRefactorExecutionStatus _executionStatus;
        private string _executionStatusReason;
        private string _stackRefactorId;
        private StackRefactorStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description to help you identify the refactor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The operation status that's provided after calling the <a>ExecuteStackRefactor</a>
        /// action.
        /// </para>
        /// </summary>
        public StackRefactorExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatusReason. 
        /// <para>
        /// A detailed explanation for the stack refactor <c>ExecutionStatus</c>.
        /// </para>
        /// </summary>
        public string ExecutionStatusReason
        {
            get { return this._executionStatusReason; }
            set { this._executionStatusReason = value; }
        }

        // Check to see if ExecutionStatusReason property is set
        internal bool IsSetExecutionStatusReason()
        {
            return this._executionStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StackRefactorId. 
        /// <para>
        /// The ID associated with the stack refactor created from the <a>CreateStackRefactor</a>
        /// action.
        /// </para>
        /// </summary>
        public string StackRefactorId
        {
            get { return this._stackRefactorId; }
            set { this._stackRefactorId = value; }
        }

        // Check to see if StackRefactorId property is set
        internal bool IsSetStackRefactorId()
        {
            return this._stackRefactorId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The stack refactor operation status that's provided after calling the <a>CreateStackRefactor</a>
        /// action.
        /// </para>
        /// </summary>
        public StackRefactorStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A detailed explanation for the stack refactor <c>Status</c>.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}