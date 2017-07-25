/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The structures that contain summary information about the specified operation.
    /// </summary>
    public partial class StackSetOperationSummary
    {
        private StackSetOperationAction _action;
        private DateTime? _creationTimestamp;
        private DateTime? _endTimestamp;
        private string _operationId;
        private StackSetOperationStatus _status;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of operation: <code>CREATE</code>, <code>UPDATE</code>, or <code>DELETE</code>.
        /// Create and delete operations affect only the specified stack instances that are associated
        /// with the specified stack set. Update operations affect both the stack set itself as
        /// well as <i>all</i> associated stack set instances.
        /// </para>
        /// </summary>
        public StackSetOperationAction Action
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
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The time at which the operation was initiated. Note that the creation times for the
        /// stack set operation might differ from the creation time of the individual stacks themselves.
        /// This is because AWS CloudFormation needs to perform preparatory work for the operation,
        /// such as dispatching the work to the requested regions, before actually creating the
        /// first stacks.
        /// </para>
        /// </summary>
        public DateTime CreationTimestamp
        {
            get { return this._creationTimestamp.GetValueOrDefault(); }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The time at which the stack set operation ended, across all accounts and regions specified.
        /// Note that this doesn't necessarily mean that the stack set operation was successful,
        /// or even attempted, in each account or region.
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
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique ID of the stack set operation.
        /// </para>
        /// </summary>
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The overall status of the operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FAILED</code>: The operation exceeded the specified failure tolerance. The
        /// failure tolerance value that you've set for an operation is applied for each region
        /// during stack create and update operations. If the number of failed stacks within a
        /// region exceeds the failure tolerance, the status of the operation in the region is
        /// set to <code>FAILED</code>. This in turn sets the status of the operation as a whole
        /// to <code>FAILED</code>, and AWS CloudFormation cancels the operation in any remaining
        /// regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RUNNING</code>: The operation is currently being performed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPED</code>: The user has cancelled the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPING</code>: The operation is in the process of stopping, at user request.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCEEDED</code>: The operation completed creating or updating all the specified
        /// stacks without exceeding the failure tolerance for the operation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackSetOperationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}