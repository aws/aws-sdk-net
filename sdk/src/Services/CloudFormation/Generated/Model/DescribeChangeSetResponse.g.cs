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
    /// This is the response object from the DescribeChangeSet operation.
    /// </summary>
    public partial class DescribeChangeSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// If you execute the change set, the list of capabilities that were explicitly acknowledged
        /// when the change set was created.
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
        /// The Amazon Resource Name (ARN) of the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetId property is set.
        /// </summary>
        internal bool IsSetChangeSetId() => this.ChangeSetId != null;

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name of the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ChangeSetName { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetName property is set.
        /// </summary>
        internal bool IsSetChangeSetName() => this.ChangeSetName != null;

        /// <summary>
        /// Gets and sets the property Changes. 
        /// <para>
        /// A list of <c>Change</c> structures that describes the resources CloudFormation changes
        /// if you execute the change set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Change> Changes { get; set; } = AWSConfigs.InitializeCollections ? new List<Change>() : null;

        /// <summary>
        /// Checks to see if the Changes property is set.
        /// </summary>
        internal bool IsSetChanges() => this.Changes != null && (this.Changes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The start time when the change set was created, in UTC.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The deployment configuration specified when the change set was created.
        /// </para>
        /// </summary>
        public DeploymentConfig DeploymentConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfig property is set.
        /// </summary>
        internal bool IsSetDeploymentConfig() => this.DeploymentConfig != null;

        /// <summary>
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        /// The deployment mode specified when the change set was created. Valid value is <c>REVERT_DRIFT</c>.
        /// Only present for drift-aware change sets.
        /// </para>
        /// </summary>
        public DeploymentMode DeploymentMode { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentMode property is set.
        /// </summary>
        internal bool IsSetDeploymentMode() => this.DeploymentMode != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// If the change set execution status is <c>AVAILABLE</c>, you can execute the change
        /// set. If you can't execute the change set, the status indicates why. For example, a
        /// change set might be in an <c>UNAVAILABLE</c> state because CloudFormation is still
        /// creating it or in an <c>OBSOLETE</c> state because the stack was already updated.
        /// </para>
        /// </summary>
        public ExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property ImportExistingResources. 
        /// <para>
        /// Indicates if the change set imports resources that already exist.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter can only import resources that have <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-properties-name.html">custom
        /// names</a> in templates. To import resources that do not accept custom names, such
        /// as EC2 instances, use the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import.html">resource
        /// import</a> feature instead.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ImportExistingResources { get; set; }

        /// <summary>
        /// Checks to see if the ImportExistingResources property is set.
        /// </summary>
        internal bool IsSetImportExistingResources() => this.ImportExistingResources.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeNestedStacks. 
        /// <para>
        /// Verifies if <c>IncludeNestedStacks</c> is set to <c>True</c>.
        /// </para>
        /// </summary>
        public bool? IncludeNestedStacks { get; set; }

        /// <summary>
        /// Checks to see if the IncludeNestedStacks property is set.
        /// </summary>
        internal bool IsSetIncludeNestedStacks() => this.IncludeNestedStacks.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the output exceeds 1 MB, a string that identifies the next page of changes. If
        /// there is no additional page, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// The ARNs of the Amazon SNS topics that will be associated with the stack if you execute
        /// the change set.
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
        /// Gets and sets the property OnStackFailure. 
        /// <para>
        /// Determines what action will be taken if stack creation fails. When this parameter
        /// is specified, the <c>DisableRollback</c> parameter to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ExecuteChangeSet.html">ExecuteChangeSet</a>
        /// API operation must not be specified. This must be one of these values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETE</c> - Deletes the change set if the stack creation fails. This is only
        /// valid when the <c>ChangeSetType</c> parameter is set to <c>CREATE</c>. If the deletion
        /// of the stack fails, the status of the stack is <c>DELETE_FAILED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DO_NOTHING</c> - if the stack creation fails, do nothing. This is equivalent to
        /// specifying <c>true</c> for the <c>DisableRollback</c> parameter to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ExecuteChangeSet.html">ExecuteChangeSet</a>
        /// API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLBACK</c> - if the stack creation fails, roll back the stack. This is equivalent
        /// to specifying <c>false</c> for the <c>DisableRollback</c> parameter to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ExecuteChangeSet.html">ExecuteChangeSet</a>
        /// API operation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OnStackFailure OnStackFailure { get; set; }

        /// <summary>
        /// Checks to see if the OnStackFailure property is set.
        /// </summary>
        internal bool IsSetOnStackFailure() => this.OnStackFailure != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <c>Parameter</c> structures that describes the input parameters and their
        /// values used to create the change set. For more information, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_Parameter.html">Parameter</a>
        /// data type.
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
        /// Gets and sets the property ParentChangeSetId. 
        /// <para>
        /// Specifies the change set ID of the parent change set in the current nested change
        /// set hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ParentChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the ParentChangeSetId property is set.
        /// </summary>
        internal bool IsSetParentChangeSetId() => this.ParentChangeSetId != null;

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
        /// Gets and sets the property RootChangeSetId. 
        /// <para>
        /// Specifies the change set ID of the root change set in the current nested change set
        /// hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string RootChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the RootChangeSetId property is set.
        /// </summary>
        internal bool IsSetRootChangeSetId() => this.RootChangeSetId != null;

        /// <summary>
        /// Gets and sets the property StackDriftStatus. 
        /// <para>
        /// The drift status of the stack when the change set was created. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DRIFTED</c> – The stack has drifted from its last deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c> – The stack is in sync with its last deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKED</c> – CloudFormation doesn’t currently return this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN</c> – The drift status could not be determined.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only present for drift-aware change sets.
        /// </para>
        /// </summary>
        public StackDriftStatus StackDriftStatus { get; set; }

        /// <summary>
        /// Checks to see if the StackDriftStatus property is set.
        /// </summary>
        internal bool IsSetStackDriftStatus() => this.StackDriftStatus != null;

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stack that's associated with the change set.
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
        /// The name of the stack that's associated with the change set.
        /// </para>
        /// </summary>
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the change set, such as <c>CREATE_PENDING</c>, <c>CREATE_COMPLETE</c>,
        /// or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ChangeSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A description of the change set's status. For example, if your attempt to create a
        /// change set failed, CloudFormation shows the error message.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// If you execute the change set, the tags that will be associated with the stack.
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
    }
}
