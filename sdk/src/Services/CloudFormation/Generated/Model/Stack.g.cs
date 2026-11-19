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
    /// The <c>Stack</c> data type.
    /// </summary>
    public partial class Stack
    {
        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The alias assigned to the stack, if one has been set. An alias is an alternative name
        /// that can be used in place of the stack name in any CloudFormation API call that accepts
        /// the <c>StackName</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities allowed in the stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null && (this.Capabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// The unique ID of the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetId property is set.
        /// </summary>
        internal bool IsSetChangeSetId() => this.ChangeSetId != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the stack was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        public DeletionMode DeletionMode { get; set; }

        /// <summary>
        /// Checks to see if the DeletionMode property is set.
        /// </summary>
        internal bool IsSetDeletionMode() => this.DeletionMode != null;

        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The time the stack was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeletionTime { get; set; }

        /// <summary>
        /// Checks to see if the DeletionTime property is set.
        /// </summary>
        internal bool IsSetDeletionTime() => this.DeletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The deployment configuration for the stack, including the deployment mode used for
        /// stack operations.
        /// </para>
        /// </summary>
        public DeploymentConfig DeploymentConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfig property is set.
        /// </summary>
        internal bool IsSetDeploymentConfig() => this.DeploymentConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-defined description associated with the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        public DetailedStatus DetailedStatus { get; set; }

        /// <summary>
        /// Checks to see if the DetailedStatus property is set.
        /// </summary>
        internal bool IsSetDetailedStatus() => this.DetailedStatus != null;

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
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// Checks to see if the DisableRollback property is set.
        /// </summary>
        internal bool IsSetDisableRollback() => this.DisableRollback.HasValue;

        /// <summary>
        /// Gets and sets the property DriftInformation. 
        /// <para>
        /// Information about whether a stack's actual configuration differs, or has <i>drifted</i>,
        /// from its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
        /// unmanaged configuration changes to stacks and resources with drift detection</a>.
        /// </para>
        /// </summary>
        public StackDriftInformation DriftInformation { get; set; }

        /// <summary>
        /// Checks to see if the DriftInformation property is set.
        /// </summary>
        internal bool IsSetDriftInformation() => this.DriftInformation != null;

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
        public bool? EnableTerminationProtection { get; set; }

        /// <summary>
        /// Checks to see if the EnableTerminationProtection property is set.
        /// </summary>
        internal bool IsSetEnableTerminationProtection() => this.EnableTerminationProtection.HasValue;

        /// <summary>
        /// Gets and sets the property LastOperations. 
        /// <para>
        /// Information about the most recent operations performed on this stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OperationEntry> LastOperations { get; set; } = AWSConfigs.InitializeCollections ? new List<OperationEntry>() : null;

        /// <summary>
        /// Checks to see if the LastOperations property is set.
        /// </summary>
        internal bool IsSetLastOperations() => this.LastOperations != null && (this.LastOperations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the stack was last updated. This field will only be returned if the stack
        /// has been updated at least once.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// Amazon SNS topic Amazon Resource Names (ARNs) to which stack related events are published.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> NotificationARNs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NotificationARNs property is set.
        /// </summary>
        internal bool IsSetNotificationARNs() => this.NotificationARNs != null && (this.NotificationARNs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// A list of output structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Output> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<Output>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <c>Parameter</c> structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Parameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public string ParentId { get; set; }

        /// <summary>
        /// Checks to see if the ParentId property is set.
        /// </summary>
        internal bool IsSetParentId() => this.ParentId != null;

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
        public bool? RetainExceptOnCreate { get; set; }

        /// <summary>
        /// Checks to see if the RetainExceptOnCreate property is set.
        /// </summary>
        internal bool IsSetRetainExceptOnCreate() => this.RetainExceptOnCreate.HasValue;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that's associated with the stack. During
        /// a stack operation, CloudFormation uses this role's credentials to make calls on your
        /// behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property RollbackConfiguration. 
        /// <para>
        /// The rollback triggers for CloudFormation to monitor during stack creation and updating
        /// operations, and for the specified monitoring period afterwards.
        /// </para>
        /// </summary>
        public RollbackConfiguration RollbackConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RollbackConfiguration property is set.
        /// </summary>
        internal bool IsSetRollbackConfiguration() => this.RollbackConfiguration != null;

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
        public string RootId { get; set; }

        /// <summary>
        /// Checks to see if the RootId property is set.
        /// </summary>
        internal bool IsSetRootId() => this.RootId != null;

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// Unique identifier of the stack.
        /// </para>
        /// </summary>
        public string StackId { get; set; }

        /// <summary>
        /// Checks to see if the StackId property is set.
        /// </summary>
        internal bool IsSetStackId() => this.StackId != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name associated with the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property StackStatus. 
        /// <para>
        /// Current status of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StackStatus StackStatus { get; set; }

        /// <summary>
        /// Checks to see if the StackStatus property is set.
        /// </summary>
        internal bool IsSetStackStatus() => this.StackStatus != null;

        /// <summary>
        /// Gets and sets the property StackStatusReason. 
        /// <para>
        /// Success/failure message associated with the stack status.
        /// </para>
        /// </summary>
        public string StackStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StackStatusReason property is set.
        /// </summary>
        internal bool IsSetStackStatusReason() => this.StackStatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <c>Tag</c>s that specify information about the stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The amount of time within which stack creation should complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutInMinutes() => this.TimeoutInMinutes.HasValue;
    }
}
