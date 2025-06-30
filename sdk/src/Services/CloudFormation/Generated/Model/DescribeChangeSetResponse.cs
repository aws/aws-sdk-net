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
    /// The output for the <a>DescribeChangeSet</a> action.
    /// </summary>
    public partial class DescribeChangeSetResponse : AmazonWebServiceResponse
    {
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Change> _changes = AWSConfigs.InitializeCollections ? new List<Change>() : null;
        private string _changeSetId;
        private string _changeSetName;
        private DateTime? _creationTime;
        private string _description;
        private ExecutionStatus _executionStatus;
        private bool? _importExistingResources;
        private bool? _includeNestedStacks;
        private string _nextToken;
        private List<string> _notificationARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private OnStackFailure _onStackFailure;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private string _parentChangeSetId;
        private RollbackConfiguration _rollbackConfiguration;
        private string _rootChangeSetId;
        private string _stackId;
        private string _stackName;
        private ChangeSetStatus _status;
        private string _statusReason;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// If you execute the change set, the list of capabilities that were explicitly acknowledged
        /// when the change set was created.
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
        /// Gets and sets the property Changes. 
        /// <para>
        /// A list of <c>Change</c> structures that describes the resources CloudFormation changes
        /// if you execute the change set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Change> Changes
        {
            get { return this._changes; }
            set { this._changes = value; }
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this._changes != null && (this._changes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the change set.
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
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name of the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ChangeSetName
        {
            get { return this._changeSetName; }
            set { this._changeSetName = value; }
        }

        // Check to see if ChangeSetName property is set
        internal bool IsSetChangeSetName()
        {
            return this._changeSetName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The start time when the change set was created, in UTC.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the change set.
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
        /// If the change set execution status is <c>AVAILABLE</c>, you can execute the change
        /// set. If you can't execute the change set, the status indicates why. For example, a
        /// change set might be in an <c>UNAVAILABLE</c> state because CloudFormation is still
        /// creating it or in an <c>OBSOLETE</c> state because the stack was already updated.
        /// </para>
        /// </summary>
        public ExecutionStatus ExecutionStatus
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
        public bool? ImportExistingResources
        {
            get { return this._importExistingResources; }
            set { this._importExistingResources = value; }
        }

        // Check to see if ImportExistingResources property is set
        internal bool IsSetImportExistingResources()
        {
            return this._importExistingResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeNestedStacks. 
        /// <para>
        /// Verifies if <c>IncludeNestedStacks</c> is set to <c>True</c>.
        /// </para>
        /// </summary>
        public bool? IncludeNestedStacks
        {
            get { return this._includeNestedStacks; }
            set { this._includeNestedStacks = value; }
        }

        // Check to see if IncludeNestedStacks property is set
        internal bool IsSetIncludeNestedStacks()
        {
            return this._includeNestedStacks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the output exceeds 1 MB, a string that identifies the next page of changes. If
        /// there is no additional page, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// The ARNs of the Amazon SNS topics that will be associated with the stack if you execute
        /// the change set.
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
        public OnStackFailure OnStackFailure
        {
            get { return this._onStackFailure; }
            set { this._onStackFailure = value; }
        }

        // Check to see if OnStackFailure property is set
        internal bool IsSetOnStackFailure()
        {
            return this._onStackFailure != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <c>Parameter</c> structures that describes the input parameters and their
        /// values used to create the change set. For more information, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_Parameter.html">Parameter</a>
        /// data type.
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
        /// Gets and sets the property ParentChangeSetId. 
        /// <para>
        /// Specifies the change set ID of the parent change set in the current nested change
        /// set hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ParentChangeSetId
        {
            get { return this._parentChangeSetId; }
            set { this._parentChangeSetId = value; }
        }

        // Check to see if ParentChangeSetId property is set
        internal bool IsSetParentChangeSetId()
        {
            return this._parentChangeSetId != null;
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
        /// Gets and sets the property RootChangeSetId. 
        /// <para>
        /// Specifies the change set ID of the root change set in the current nested change set
        /// hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string RootChangeSetId
        {
            get { return this._rootChangeSetId; }
            set { this._rootChangeSetId = value; }
        }

        // Check to see if RootChangeSetId property is set
        internal bool IsSetRootChangeSetId()
        {
            return this._rootChangeSetId != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stack that's associated with the change set.
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
        /// The name of the stack that's associated with the change set.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the change set, such as <c>CREATE_PENDING</c>, <c>CREATE_COMPLETE</c>,
        /// or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ChangeSetStatus Status
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
        /// A description of the change set's status. For example, if your attempt to create a
        /// change set failed, CloudFormation shows the error message.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// If you execute the change set, the tags that will be associated with the stack.
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

    }
}