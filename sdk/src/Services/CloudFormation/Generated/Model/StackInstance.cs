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
    /// A CloudFormation stack, in a specific account and Region, that's part of a StackSet
    /// operation. A stack instance is a reference to an attempted or actual stack in a given
    /// account within a given Region. A stack instance can exist without a stack—for example,
    /// if the stack couldn't be created for some reason. A stack instance is associated with
    /// only one StackSet. Each stack instance contains the ID of its associated StackSet,
    /// in addition to the ID of the actual stack and the stack status.
    /// </summary>
    public partial class StackInstance
    {
        private string _account;
        private StackDriftStatus _driftStatus;
        private DateTime? _lastDriftCheckTimestamp;
        private string _lastOperationId;
        private string _organizationalUnitId;
        private List<Parameter> _parameterOverrides = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private string _region;
        private string _stackId;
        private StackInstanceComprehensiveStatus _stackInstanceStatus;
        private string _stackSetId;
        private StackInstanceStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// [Self-managed permissions] The name of the Amazon Web Services account that the stack
        /// instance is associated with.
        /// </para>
        /// </summary>
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property DriftStatus. 
        /// <para>
        /// Status of the stack instance's actual configuration compared to the expected template
        /// and parameter configuration of the StackSet it belongs to.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DRIFTED</c>: The stack differs from the expected template and parameter configuration
        /// of the StackSet it belongs to. A stack instance is considered to have drifted if one
        /// or more of the resources in the associated stack have drifted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKED</c>: CloudFormation hasn't checked if the stack instance differs from
        /// its expected StackSet configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c>: The stack instance's actual configuration matches its expected StackSset
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN</c>: This value is reserved for future use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackDriftStatus DriftStatus
        {
            get { return this._driftStatus; }
            set { this._driftStatus = value; }
        }

        // Check to see if DriftStatus property is set
        internal bool IsSetDriftStatus()
        {
            return this._driftStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastDriftCheckTimestamp. 
        /// <para>
        /// Most recent time when CloudFormation performed a drift detection operation on the
        /// stack instance. This value will be <c>NULL</c> for any stack instance that drift detection
        /// hasn't yet been performed on.
        /// </para>
        /// </summary>
        public DateTime? LastDriftCheckTimestamp
        {
            get { return this._lastDriftCheckTimestamp; }
            set { this._lastDriftCheckTimestamp = value; }
        }

        // Check to see if LastDriftCheckTimestamp property is set
        internal bool IsSetLastDriftCheckTimestamp()
        {
            return this._lastDriftCheckTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastOperationId. 
        /// <para>
        /// The last unique ID of a StackSet operation performed on a stack instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string LastOperationId
        {
            get { return this._lastOperationId; }
            set { this._lastOperationId = value; }
        }

        // Check to see if LastOperationId property is set
        internal bool IsSetLastOperationId()
        {
            return this._lastOperationId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// [Service-managed permissions] The organization root ID or organizational unit (OU)
        /// IDs that you specified for <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DeploymentTargets.html">DeploymentTargets</a>.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId
        {
            get { return this._organizationalUnitId; }
            set { this._organizationalUnitId = value; }
        }

        // Check to see if OrganizationalUnitId property is set
        internal bool IsSetOrganizationalUnitId()
        {
            return this._organizationalUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterOverrides. 
        /// <para>
        /// A list of parameters from the StackSet template whose values have been overridden
        /// in this stack instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Parameter> ParameterOverrides
        {
            get { return this._parameterOverrides; }
            set { this._parameterOverrides = value; }
        }

        // Check to see if ParameterOverrides property is set
        internal bool IsSetParameterOverrides()
        {
            return this._parameterOverrides != null && (this._parameterOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The name of the Amazon Web Services Region that the stack instance is associated with.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The ID of the stack instance.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property StackInstanceStatus. 
        /// <para>
        /// The detailed status of the stack instance.
        /// </para>
        /// </summary>
        public StackInstanceComprehensiveStatus StackInstanceStatus
        {
            get { return this._stackInstanceStatus; }
            set { this._stackInstanceStatus = value; }
        }

        // Check to see if StackInstanceStatus property is set
        internal bool IsSetStackInstanceStatus()
        {
            return this._stackInstanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetId. 
        /// <para>
        /// The name or unique ID of the StackSet that the stack instance is associated with.
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
        /// The status of the stack instance, in terms of its synchronization with its associated
        /// stack set.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INOPERABLE</c>: A <c>DeleteStackInstances</c> operation has failed and left the
        /// stack in an unstable state. Stacks in this state are excluded from further <c>UpdateStackSet</c>
        /// operations. You might need to perform a <c>DeleteStackInstances</c> operation, with
        /// <c>RetainStacks</c> set to <c>true</c>, to delete the stack instance, and then delete
        /// the stack manually. <c>INOPERABLE</c> can be returned here when the cause is a failed
        /// import. If it's due to a failed import, the operation can be retried once the failures
        /// are fixed. To see if this is due to a failed import, look at the <c>DetailedStatus</c>
        /// member in the <c>StackInstanceSummary</c> member that is a peer to this <c>Status</c>
        /// member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUTDATED</c>: The stack isn't currently up to date with the StackSet because:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The associated stack failed during a <c>CreateStackSet</c> or <c>UpdateStackSet</c>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The stack was part of a <c>CreateStackSet</c> or <c>UpdateStackSet</c> operation that
        /// failed or was stopped before the stack was created or updated.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CURRENT</c>: The stack is currently up to date with the StackSet.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackInstanceStatus Status
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
        /// The explanation for the specific status code that's assigned to this stack instance.
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