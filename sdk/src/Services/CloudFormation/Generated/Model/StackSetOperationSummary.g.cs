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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The structures that contain summary information about the specified operation.
    /// </summary>
    public partial class StackSetOperationSummary
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of operation: <c>CREATE</c>, <c>UPDATE</c>, or <c>DELETE</c>. Create and
        /// delete operations affect only the specified stack instances that are associated with
        /// the specified StackSet. Update operations affect both the StackSet itself and <i>all</i>
        /// associated StackSet instances.
        /// </para>
        /// </summary>
        public StackSetOperationAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The time at which the operation was initiated. Note that the creation times for the
        /// StackSet operation might differ from the creation time of the individual stacks themselves.
        /// This is because CloudFormation needs to perform preparatory work for the operation,
        /// such as dispatching the work to the requested Regions, before actually creating the
        /// first stacks.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The time at which the StackSet operation ended, across all accounts and Regions specified.
        /// Note that this doesn't necessarily mean that the StackSet operation was successful,
        /// or even attempted, in each account or Region.
        /// </para>
        /// </summary>
        public DateTime? EndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestamp property is set.
        /// </summary>
        internal bool IsSetEndTimestamp() => this.EndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique ID of the StackSet operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string OperationId { get; set; }

        /// <summary>
        /// Checks to see if the OperationId property is set.
        /// </summary>
        internal bool IsSetOperationId() => this.OperationId != null;

        /// <summary>
        /// Gets and sets the property OperationPreferences. 
        /// <para>
        /// The user-specified preferences for how CloudFormation performs a StackSet operation.
        /// </para>
        ///  
        /// <para>
        /// For more information about maximum concurrent accounts and failure tolerance, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-concepts.html#stackset-ops-options">StackSet
        /// operation options</a>.
        /// </para>
        /// </summary>
        public StackSetOperationPreferences OperationPreferences { get; set; }

        /// <summary>
        /// Checks to see if the OperationPreferences property is set.
        /// </summary>
        internal bool IsSetOperationPreferences() => this.OperationPreferences != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The overall status of the operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FAILED</c>: The operation exceeded the specified failure tolerance. The failure
        /// tolerance value that you've set for an operation is applied for each Region during
        /// stack create and update operations. If the number of failed stacks within a Region
        /// exceeds the failure tolerance, the status of the operation in the Region is set to
        /// <c>FAILED</c>. This in turn sets the status of the operation as a whole to <c>FAILED</c>,
        /// and CloudFormation cancels the operation in any remaining Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUEUED</c>: [Service-managed permissions] For automatic deployments that require
        /// a sequence of operations, the operation is queued to be performed. For more information,
        /// see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-concepts.html#stackset-status-codes">StackSet
        /// status codes</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c>: The operation is currently being performed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c>: The user has canceled the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPING</c>: The operation is in the process of stopping, at user request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>: The operation completed creating or updating all the specified
        /// stacks without exceeding the failure tolerance for the operation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackSetOperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Detailed information about the StackSet operation.
        /// </para>
        /// </summary>
        public StackSetOperationStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The status of the operation in details.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
