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
    /// The Stack data type.
    /// </summary>
    public partial class Stack
    {
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _changeSetId;
        private DateTime? _creationTime;
        private DeletionMode _deletionMode;
        private DateTime? _deletionTime;
        private string _description;
        private DetailedStatus _detailedStatus;
        private bool? _disableRollback;
        private StackDriftInformation _driftInformation;
        private bool? _enableTerminationProtection;
        private DateTime? _lastUpdatedTime;
        private List<string> _notificationARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Output> _outputs = AWSConfigs.InitializeCollections ? new List<Output>() : null;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private string _parentId;
        private bool? _retainExceptOnCreate;
        private string _roleARN;
        private RollbackConfiguration _rollbackConfiguration;
        private string _rootId;
        private string _stackId;
        private string _stackName;
        private StackStatus _stackStatus;
        private string _stackStatusReason;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities allowed in the stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && (this._capabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// The unique ID of the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ChangeSetId
        {
            get { return this._changeSetId; }
            set { this._changeSetId = value; }
        }

        // Check to see if ChangeSetId property is set
        internal bool IsSetChangeSetId()
        {
            return this._changeSetId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the stack was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionMode. 
        /// <para>
        /// Specifies the deletion mode for the stack. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STANDARD</c> - Use the standard behavior. Specifying this value is the same as
        /// not specifying this parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORCE_DELETE_STACK</c> - Delete the stack if it's stuck in a <c>DELETE_FAILED</c>
        /// state due to resource deletion failure.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeletionMode DeletionMode
        {
            get { return this._deletionMode; }
            set { this._deletionMode = value; }
        }

        // Check to see if DeletionMode property is set
        internal bool IsSetDeletionMode()
        {
            return this._deletionMode != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The time the stack was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeletionTime
        {
            get { return this._deletionTime; }
            set { this._deletionTime = value; }
        }

        // Check to see if DeletionTime property is set
        internal bool IsSetDeletionTime()
        {
            return this._deletionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-defined description associated with the stack.
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
        /// Gets and sets the property DetailedStatus. 
        /// <para>
        /// The detailed status of the resource or stack. If <c>CONFIGURATION_COMPLETE</c> is
        /// present, the resource or resource configuration phase has completed and the stabilization
        /// of the resources is in progress. The StackSets <c>CONFIGURATION_COMPLETE</c> when
        /// all of the resources in the stack have reached that event. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">Understand
        /// CloudFormation stack creation events</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public DetailedStatus DetailedStatus
        {
            get { return this._detailedStatus; }
            set { this._detailedStatus = value; }
        }

        // Check to see if DetailedStatus property is set
        internal bool IsSetDetailedStatus()
        {
            return this._detailedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DisableRollback. 
        /// <para>
        /// Boolean to enable or disable rollback on stack creation failures:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c>: disable rollback.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c>: enable rollback.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? DisableRollback
        {
            get { return this._disableRollback; }
            set { this._disableRollback = value; }
        }

        // Check to see if DisableRollback property is set
        internal bool IsSetDisableRollback()
        {
            return this._disableRollback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DriftInformation. 
        /// <para>
        /// Information about whether a stack's actual configuration differs, or has <i>drifted</i>,
        /// from its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
        /// unmanaged configuration changes to stacks and resources with drift detection</a>.
        /// </para>
        /// </summary>
        public StackDriftInformation DriftInformation
        {
            get { return this._driftInformation; }
            set { this._driftInformation = value; }
        }

        // Check to see if DriftInformation property is set
        internal bool IsSetDriftInformation()
        {
            return this._driftInformation != null;
        }

        /// <summary>
        /// Gets and sets the property EnableTerminationProtection. 
        /// <para>
        /// Whether termination protection is enabled for the stack.
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">nested
        /// stacks</a>, termination protection is set on the root stack and can't be changed directly
        /// on the nested stack. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protect
        /// a CloudFormation stack from being deleted</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnableTerminationProtection
        {
            get { return this._enableTerminationProtection; }
            set { this._enableTerminationProtection = value; }
        }

        // Check to see if EnableTerminationProtection property is set
        internal bool IsSetEnableTerminationProtection()
        {
            return this._enableTerminationProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the stack was last updated. This field will only be returned if the stack
        /// has been updated at least once.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// Amazon SNS topic Amazon Resource Names (ARNs) to which stack related events are published.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> NotificationARNs
        {
            get { return this._notificationARNs; }
            set { this._notificationARNs = value; }
        }

        // Check to see if NotificationARNs property is set
        internal bool IsSetNotificationARNs()
        {
            return this._notificationARNs != null && (this._notificationARNs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// A list of output structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Output> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <c>Parameter</c> structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// For nested stacks, the stack ID of the direct parent of this stack. For the first
        /// level of nested stacks, the root stack is also the parent stack.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">Nested
        /// stacks</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RetainExceptOnCreate. 
        /// <para>
        /// When set to <c>true</c>, newly created resources are deleted when the operation rolls
        /// back. This includes newly created resources marked with a deletion policy of <c>Retain</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? RetainExceptOnCreate
        {
            get { return this._retainExceptOnCreate; }
            set { this._retainExceptOnCreate = value; }
        }

        // Check to see if RetainExceptOnCreate property is set
        internal bool IsSetRetainExceptOnCreate()
        {
            return this._retainExceptOnCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that's associated with the stack. During
        /// a stack operation, CloudFormation uses this role's credentials to make calls on your
        /// behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackConfiguration. 
        /// <para>
        /// The rollback triggers for CloudFormation to monitor during stack creation and updating
        /// operations, and for the specified monitoring period afterwards.
        /// </para>
        /// </summary>
        public RollbackConfiguration RollbackConfiguration
        {
            get { return this._rollbackConfiguration; }
            set { this._rollbackConfiguration = value; }
        }

        // Check to see if RollbackConfiguration property is set
        internal bool IsSetRollbackConfiguration()
        {
            return this._rollbackConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RootId. 
        /// <para>
        /// For nested stacks, the stack ID of the top-level stack to which the nested stack ultimately
        /// belongs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">Nested
        /// stacks</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public string RootId
        {
            get { return this._rootId; }
            set { this._rootId = value; }
        }

        // Check to see if RootId property is set
        internal bool IsSetRootId()
        {
            return this._rootId != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// Unique identifier of the stack.
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
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name associated with the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property StackStatus. 
        /// <para>
        /// Current status of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StackStatus StackStatus
        {
            get { return this._stackStatus; }
            set { this._stackStatus = value; }
        }

        // Check to see if StackStatus property is set
        internal bool IsSetStackStatus()
        {
            return this._stackStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StackStatusReason. 
        /// <para>
        /// Success/failure message associated with the stack status.
        /// </para>
        /// </summary>
        public string StackStatusReason
        {
            get { return this._stackStatusReason; }
            set { this._stackStatusReason = value; }
        }

        // Check to see if StackStatusReason property is set
        internal bool IsSetStackStatusReason()
        {
            return this._stackStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <c>Tag</c>s that specify information about the stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The amount of time within which stack creation should complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? TimeoutInMinutes
        {
            get { return this._timeoutInMinutes; }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

    }
}