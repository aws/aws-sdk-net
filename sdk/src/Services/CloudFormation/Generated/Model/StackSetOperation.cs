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
    /// The structure that contains information about a stack set operation.
    /// </summary>
    public partial class StackSetOperation
    {
        private StackSetOperationAction _action;
        private string _administrationRoleARN;
        private DateTime? _creationTimestamp;
        private DeploymentTargets _deploymentTargets;
        private DateTime? _endTimestamp;
        private string _executionRoleName;
        private string _operationId;
        private StackSetOperationPreferences _operationPreferences;
        private bool? _retainStacks;
        private StackSetDriftDetectionDetails _stackSetDriftDetectionDetails;
        private string _stackSetId;
        private StackSetOperationStatus _status;
        private StackSetOperationStatusDetails _statusDetails;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of stack set operation: <code>CREATE</code>, <code>UPDATE</code>, or <code>DELETE</code>.
        /// Create and delete operations affect only the specified stack set instances that are
        /// associated with the specified stack set. Update operations affect both the stack set
        /// itself, in addition to <i>all</i> associated stack set instances.
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
        /// Gets and sets the property AdministrationRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used to perform this stack set operation.
        /// </para>
        ///  
        /// <para>
        /// Use customized administrator roles to control which users or groups can manage specific
        /// stack sets within the same administrator account. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs.html">Define
        /// Permissions for Multiple Administrators</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AdministrationRoleARN
        {
            get { return this._administrationRoleARN; }
            set { this._administrationRoleARN = value; }
        }

        // Check to see if AdministrationRoleARN property is set
        internal bool IsSetAdministrationRoleARN()
        {
            return this._administrationRoleARN != null;
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
        /// Gets and sets the property DeploymentTargets. 
        /// <para>
        /// [Service-managed permissions] The Organizations accounts affected by the stack operation.
        /// </para>
        /// </summary>
        public DeploymentTargets DeploymentTargets
        {
            get { return this._deploymentTargets; }
            set { this._deploymentTargets = value; }
        }

        // Check to see if DeploymentTargets property is set
        internal bool IsSetDeploymentTargets()
        {
            return this._deploymentTargets != null;
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
        /// Gets and sets the property ExecutionRoleName. 
        /// <para>
        /// The name of the IAM execution role used to create or update the stack set.
        /// </para>
        ///  
        /// <para>
        /// Use customized execution roles to control which stack resources users and groups can
        /// include in their stack sets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ExecutionRoleName
        {
            get { return this._executionRoleName; }
            set { this._executionRoleName = value; }
        }

        // Check to see if ExecutionRoleName property is set
        internal bool IsSetExecutionRoleName()
        {
            return this._executionRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique ID of a stack set operation.
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
        /// <para>
        /// The preferences for how CloudFormation performs this stack set operation.
        /// </para>
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
        /// Gets and sets the property RetainStacks. 
        /// <para>
        /// For stack set operations of action type <code>DELETE</code>, specifies whether to
        /// remove the stack instances from the specified stack set, but doesn't delete the stacks.
        /// You can't re-associate a retained stack, or add an existing, saved stack to a new
        /// stack set.
        /// </para>
        /// </summary>
        public bool RetainStacks
        {
            get { return this._retainStacks.GetValueOrDefault(); }
            set { this._retainStacks = value; }
        }

        // Check to see if RetainStacks property is set
        internal bool IsSetRetainStacks()
        {
            return this._retainStacks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackSetDriftDetectionDetails. 
        /// <para>
        /// Detailed information about the drift status of the stack set. This includes information
        /// about drift operations currently being performed on the stack set.
        /// </para>
        ///  
        /// <para>
        /// This information will only be present for stack set operations whose <code>Action</code>
        /// type is <code>DETECT_DRIFT</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">Detecting
        /// Unmanaged Changes in Stack Sets</a> in the CloudFormation User Guide.
        /// </para>
        /// </summary>
        public StackSetDriftDetectionDetails StackSetDriftDetectionDetails
        {
            get { return this._stackSetDriftDetectionDetails; }
            set { this._stackSetDriftDetectionDetails = value; }
        }

        // Check to see if StackSetDriftDetectionDetails property is set
        internal bool IsSetStackSetDriftDetectionDetails()
        {
            return this._stackSetDriftDetectionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetId. 
        /// <para>
        /// The ID of the stack set.
        /// </para>
        /// </summary>
        public string StackSetId
        {
            get { return this._stackSetId; }
            set { this._stackSetId = value; }
        }

        // Check to see if StackSetId property is set
        internal bool IsSetStackSetId()
        {
            return this._stackSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the operation.
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
        /// Detailed information about the StackSet operation.
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