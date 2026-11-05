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
    /// The structures that contain summary information about the specified StackSet.
    /// </summary>
    public partial class StackSetSummary
    {
        /// <summary>
        /// Gets and sets the property AutoDeployment. 
        /// <para>
        /// [Service-managed permissions] Describes whether StackSets automatically deploys to
        /// Organizations accounts that are added to a target organizational unit (OU).
        /// </para>
        /// </summary>
        public AutoDeployment AutoDeployment { get; set; }

        /// <summary>
        /// Checks to see if the AutoDeployment property is set.
        /// </summary>
        internal bool IsSetAutoDeployment() => this.AutoDeployment != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the StackSet that you specify when the StackSet is created or updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DriftStatus. 
        /// <para>
        /// Status of the StackSet's actual configuration compared to its expected template and
        /// parameter configuration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DRIFTED</c>: One or more of the stack instances belonging to the StackSet differs
        /// from the expected template and parameter configuration. A stack instance is considered
        /// to have drifted if one or more of the resources in the associated stack have drifted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKED</c>: CloudFormation hasn't checked the StackSet for drift.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c>: All the stack instances belonging to the StackSet match the expected
        /// template and parameter configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN</c>: This value is reserved for future use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackDriftStatus DriftStatus { get; set; }

        /// <summary>
        /// Checks to see if the DriftStatus property is set.
        /// </summary>
        internal bool IsSetDriftStatus() => this.DriftStatus != null;

        /// <summary>
        /// Gets and sets the property LastDriftCheckTimestamp. 
        /// <para>
        /// Most recent time when CloudFormation performed a drift detection operation on the
        /// StackSet. This value will be <c>NULL</c> for any StackSet that drift detection hasn't
        /// yet been performed on.
        /// </para>
        /// </summary>
        public DateTime? LastDriftCheckTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastDriftCheckTimestamp property is set.
        /// </summary>
        internal bool IsSetLastDriftCheckTimestamp() => this.LastDriftCheckTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedExecution. 
        /// <para>
        /// Describes whether StackSets performs non-conflicting operations concurrently and queues
        /// conflicting operations.
        /// </para>
        /// </summary>
        public ManagedExecution ManagedExecution { get; set; }

        /// <summary>
        /// Checks to see if the ManagedExecution property is set.
        /// </summary>
        internal bool IsSetManagedExecution() => this.ManagedExecution != null;

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// Describes how the IAM roles required for StackSet operations are created.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With <c>self-managed</c> permissions, you must create the administrator and execution
        /// roles required to deploy to target accounts. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs-self-managed.html">Grant
        /// self-managed permissions</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With <c>service-managed</c> permissions, StackSets automatically creates the IAM roles
        /// required to deploy to accounts managed by Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-activate-trusted-access.html">Activate
        /// trusted access for StackSets with Organizations</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionModels PermissionModel { get; set; }

        /// <summary>
        /// Checks to see if the PermissionModel property is set.
        /// </summary>
        internal bool IsSetPermissionModel() => this.PermissionModel != null;

        /// <summary>
        /// Gets and sets the property StackSetId. 
        /// <para>
        /// The ID of the StackSet.
        /// </para>
        /// </summary>
        public string StackSetId { get; set; }

        /// <summary>
        /// Checks to see if the StackSetId property is set.
        /// </summary>
        internal bool IsSetStackSetId() => this.StackSetId != null;

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name of the StackSet.
        /// </para>
        /// </summary>
        public string StackSetName { get; set; }

        /// <summary>
        /// Checks to see if the StackSetName property is set.
        /// </summary>
        internal bool IsSetStackSetName() => this.StackSetName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the StackSet.
        /// </para>
        /// </summary>
        public StackSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
