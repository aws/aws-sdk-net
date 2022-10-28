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
        private StackSetOperationPreferences _operationPreferences;
        private StackSetOperationStatus _status;
        private StackSetOperationStatusDetails _statusDetails;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of operation: <code>CREATE</code>, <code>UPDATE</code>, or <code>DELETE</code>.
        /// Create and delete operations affect only the specified stack instances that are associated
        /// with the specified stack set. Update operations affect both the stack set itself and
        /// <i>all</i> associated stack set instances.
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
        /// This is because CloudFormation needs to perform preparatory work for the operation,
        /// such as dispatching the work to the requested Regions, before actually creating the
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
        /// The time at which the stack set operation ended, across all accounts and Regions specified.
        /// Note that this doesn't necessarily mean that the stack set operation was successful,
        /// or even attempted, in each account or Region.
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
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property OperationPreferences.
        /// </summary>
        public StackSetOperationPreferences OperationPreferences
        {
            get { return this._operationPreferences; }
            set { this._operationPreferences = value; }
        }

        // Check to see if OperationPreferences property is set
        internal bool IsSetOperationPreferences()
        {
            return this._operationPreferences != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The overall status of the operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FAILED</code>: The operation exceeded the specified failure tolerance. The
        /// failure tolerance value that you've set for an operation is applied for each Region
        /// during stack create and update operations. If the number of failed stacks within a
        /// Region exceeds the failure tolerance, the status of the operation in the Region is
        /// set to <code>FAILED</code>. This in turn sets the status of the operation as a whole
        /// to <code>FAILED</code>, and CloudFormation cancels the operation in any remaining
        /// Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>QUEUED</code>: [Service-managed permissions] For automatic deployments that
        /// require a sequence of operations, the operation is queued to be performed. For more
        /// information, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-concepts.html#stackset-status-codes">stack
        /// set operation status codes</a> in the CloudFormation User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RUNNING</code>: The operation is currently being performed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPED</code>: The user has canceled the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPING</code>: The operation is in the process of stopping, at user request.
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

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Detailed information about the stack set operation.
        /// </para>
        /// </summary>
        public StackSetOperationStatusDetails StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The status of the operation in details.
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