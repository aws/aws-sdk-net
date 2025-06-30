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
    /// Container for the parameters to the CreateChangeSet operation.
    /// Creates a list of changes that will be applied to a stack so that you can review the
    /// changes before executing them. You can create a change set for a stack that doesn't
    /// exist or an existing stack. If you create a change set for a stack that doesn't exist,
    /// the change set shows all of the resources that CloudFormation will create. If you
    /// create a change set for an existing stack, CloudFormation compares the stack's information
    /// with the information that you submit in the change set and lists the differences.
    /// Use change sets to understand which resources CloudFormation will create or change,
    /// and how it will change resources in an existing stack, before you create or update
    /// a stack.
    /// 
    ///  
    /// <para>
    /// To create a change set for a stack that doesn't exist, for the <c>ChangeSetType</c>
    /// parameter, specify <c>CREATE</c>. To create a change set for an existing stack, specify
    /// <c>UPDATE</c> for the <c>ChangeSetType</c> parameter. To create a change set for an
    /// import operation, specify <c>IMPORT</c> for the <c>ChangeSetType</c> parameter. After
    /// the <c>CreateChangeSet</c> call successfully completes, CloudFormation starts creating
    /// the change set. To check the status of the change set or to review it, use the <a>DescribeChangeSet</a>
    /// action.
    /// </para>
    ///  
    /// <para>
    /// When you are satisfied with the changes the change set will make, execute the change
    /// set by using the <a>ExecuteChangeSet</a> action. CloudFormation doesn't make changes
    /// until you execute the change set.
    /// </para>
    ///  
    /// <para>
    /// To create a change set for the entire stack hierarchy, set <c>IncludeNestedStacks</c>
    /// to <c>True</c>.
    /// </para>
    /// </summary>
    public partial class CreateChangeSetRequest : AmazonCloudFormationRequest
    {
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _changeSetName;
        private ChangeSetType _changeSetType;
        private string _clientToken;
        private string _description;
        private bool? _importExistingResources;
        private bool? _includeNestedStacks;
        private List<string> _notificationARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private OnStackFailure _onStackFailure;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private List<ResourceToImport> _resourcesToImport = AWSConfigs.InitializeCollections ? new List<ResourceToImport>() : null;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleARN;
        private RollbackConfiguration _rollbackConfiguration;
        private string _stackName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _templateBody;
        private string _templateURL;
        private bool? _usePreviousTemplate;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// In some cases, you must explicitly acknowledge that your stack template contains certain
        /// capabilities in order for CloudFormation to create the stack.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CAPABILITY_IAM</c> and <c>CAPABILITY_NAMED_IAM</c> 
        /// </para>
        ///  
        /// <para>
        /// Some stack templates might include resources that can affect permissions in your Amazon
        /// Web Services account; for example, by creating new IAM users. For those stacks, you
        /// must explicitly acknowledge this by specifying one of these capabilities.
        /// </para>
        ///  
        /// <para>
        /// The following IAM resources require you to specify either the <c>CAPABILITY_IAM</c>
        /// or <c>CAPABILITY_NAMED_IAM</c> capability.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have IAM resources, you can specify either capability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have IAM resources with custom names, you <i>must</i> specify <c>CAPABILITY_NAMED_IAM</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify either of these capabilities, CloudFormation returns an <c>InsufficientCapabilities</c>
        /// error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If your stack template contains these resources, we suggest that you review all permissions
        /// associated with them and edit their permissions if necessary.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-accesskey.html">
        /// AWS::IAM::AccessKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-group.html">
        /// AWS::IAM::Group</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-instanceprofile.html">AWS::IAM::InstanceProfile</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-managedpolicy.html">
        /// AWS::IAM::ManagedPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-policy.html">
        /// AWS::IAM::Policy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-role.html">
        /// AWS::IAM::Role</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-user.html">
        /// AWS::IAM::User</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-usertogroupaddition.html">AWS::IAM::UserToGroupAddition</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/control-access-with-iam.html#using-iam-capabilities">Acknowledging
        /// IAM resources in CloudFormation templates</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CAPABILITY_AUTO_EXPAND</c> 
        /// </para>
        ///  
        /// <para>
        /// Some template contain macros. Macros perform custom processing on templates; this
        /// can include simple actions like find-and-replace operations, all the way to extensive
        /// transformations of entire templates. Because of this, users typically create a change
        /// set from the processed template, so that they can review the changes resulting from
        /// the macros before actually creating the stack. If your stack template contains one
        /// or more macros, and you choose to create a stack directly from the processed template,
        /// without first reviewing the resulting changes in a change set, you must acknowledge
        /// this capability. This includes the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/transform-aws-include.html">AWS::Include</a>
        /// and <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/transform-aws-serverless.html">AWS::Serverless</a>
        /// transforms, which are macros hosted by CloudFormation.
        /// </para>
        ///  <note> 
        /// <para>
        /// This capacity doesn't apply to creating change sets, and specifying it when creating
        /// change sets has no effect.
        /// </para>
        ///  
        /// <para>
        /// If you want to create a stack from a stack template that contains macros <i>and</i>
        /// nested stacks, you must create or update the stack directly from the template using
        /// the <a>CreateStack</a> or <a>UpdateStack</a> action, and specifying this capability.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about macros, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-macros.html">Perform
        /// custom processing on CloudFormation templates with template macros</a>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Only one of the <c>Capabilities</c> and <c>ResourceType</c> parameters can be specified.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name of the change set. The name must be unique among all change sets that are
        /// associated with the specified stack.
        /// </para>
        ///  
        /// <para>
        /// A change set name can contain only alphanumeric, case sensitive characters, and hyphens.
        /// It must start with an alphabetical character and can't exceed 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ChangeSetType. 
        /// <para>
        /// The type of change set operation. To create a change set for a new stack, specify
        /// <c>CREATE</c>. To create a change set for an existing stack, specify <c>UPDATE</c>.
        /// To create a change set for an import operation, specify <c>IMPORT</c>.
        /// </para>
        ///  
        /// <para>
        /// If you create a change set for a new stack, CloudFormation creates a stack with a
        /// unique stack ID, but no template or resources. The stack will be in the <c>REVIEW_IN_PROGRESS</c>
        /// state until you execute the change set.
        /// </para>
        ///  
        /// <para>
        /// By default, CloudFormation specifies <c>UPDATE</c>. You can't use the <c>UPDATE</c>
        /// type to create a change set for a new stack or the <c>CREATE</c> type to create a
        /// change set for an existing stack.
        /// </para>
        /// </summary>
        public ChangeSetType ChangeSetType
        {
            get { return this._changeSetType; }
            set { this._changeSetType = value; }
        }

        // Check to see if ChangeSetType property is set
        internal bool IsSetChangeSetType()
        {
            return this._changeSetType != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for this <c>CreateChangeSet</c> request. Specify this token if
        /// you plan to retry requests so that CloudFormation knows that you're not attempting
        /// to create another change set with the same name. You might retry <c>CreateChangeSet</c>
        /// requests to ensure that CloudFormation successfully received them.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description to help you identify this change set.
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
        /// Gets and sets the property ImportExistingResources. 
        /// <para>
        /// Indicates if the change set auto-imports resources that already exist. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/import-resources-automatically.html">Import
        /// Amazon Web Services resources into a CloudFormation stack automatically</a> in the
        /// <i>CloudFormation User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter can only import resources that have custom names in templates. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-properties-name.html">name
        /// type</a> in the <i>CloudFormation User Guide</i>. To import resources that do not
        /// accept custom names, such as EC2 instances, use the <c>ResourcesToImport</c> parameter
        /// instead.
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
        /// Creates a change set for the all nested stacks specified in the template. The default
        /// behavior of this action is set to <c>False</c>. To include nested sets in a change
        /// set, specify <c>True</c>.
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
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Amazon SNS topics that CloudFormation associates
        /// with the stack. To remove all associated notification topics, specify an empty list.
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
        /// Determines what action will be taken if stack creation fails. If this parameter is
        /// specified, the <c>DisableRollback</c> parameter to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ExecuteChangeSet.html">ExecuteChangeSet</a>
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
        /// <para>
        /// For nested stacks, when the <c>OnStackFailure</c> parameter is set to <c>DELETE</c>
        /// for the change set for the parent stack, any failure in a child stack will cause the
        /// parent stack creation to fail and all stacks to be deleted.
        /// </para>
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
        /// A list of <c>Parameter</c> structures that specify input parameters for the change
        /// set. For more information, see the <a>Parameter</a> data type.
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
        /// Gets and sets the property ResourcesToImport. 
        /// <para>
        /// The resources to import into your stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<ResourceToImport> ResourcesToImport
        {
            get { return this._resourcesToImport; }
            set { this._resourcesToImport = value; }
        }

        // Check to see if ResourcesToImport property is set
        internal bool IsSetResourcesToImport()
        {
            return this._resourcesToImport != null && (this._resourcesToImport.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The template resource types that you have permissions to work with if you execute
        /// this change set, such as <c>AWS::EC2::Instance</c>, <c>AWS::EC2::*</c>, or <c>Custom::MyCustomInstance</c>.
        /// </para>
        ///  
        /// <para>
        /// If the list of resource types doesn't include a resource type that you're updating,
        /// the stack update fails. By default, CloudFormation grants permissions to all resource
        /// types. IAM uses this parameter for condition keys in IAM policies for CloudFormation.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/control-access-with-iam.html">Control
        /// access with Identity and Access Management</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only one of the <c>Capabilities</c> and <c>ResourceType</c> parameters can be specified.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that CloudFormation assumes when executing
        /// the change set. CloudFormation uses the role's credentials to make calls on your behalf.
        /// CloudFormation uses this role for all future operations on the stack. Provided that
        /// users have permission to operate on the stack, CloudFormation uses this role even
        /// if the users don't have permission to pass it. Ensure that the role grants least permission.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, CloudFormation uses the role that was previously associated
        /// with the stack. If no role is available, CloudFormation uses a temporary session that
        /// is generated from your user credentials.
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
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or the unique ID of the stack for which you are creating a change set. CloudFormation
        /// generates the change set by comparing this stack's information with the information
        /// that you submit, such as a modified template or different parameter input values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to associate with this stack. CloudFormation also propagates these
        /// tags to resources in the stack. You can specify a maximum of 50 tags.
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
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// A structure that contains the body of the revised template, with a minimum length
        /// of 1 byte and a maximum length of 51,200 bytes. CloudFormation generates the change
        /// set by comparing this template with the template of the stack that you specified.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only <c>TemplateBody</c> or <c>TemplateURL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateURL. 
        /// <para>
        /// The URL of the file that contains the revised template. The URL must point to a template
        /// (max size: 1 MB) that's located in an Amazon S3 bucket or a Systems Manager document.
        /// CloudFormation generates the change set by comparing this template with the stack
        /// that you specified. The location for an Amazon S3 bucket must start with <c>https://</c>.
        /// URLs from S3 static websites are not supported.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only <c>TemplateBody</c> or <c>TemplateURL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5120)]
        public string TemplateURL
        {
            get { return this._templateURL; }
            set { this._templateURL = value; }
        }

        // Check to see if TemplateURL property is set
        internal bool IsSetTemplateURL()
        {
            return this._templateURL != null;
        }

        /// <summary>
        /// Gets and sets the property UsePreviousTemplate. 
        /// <para>
        /// Whether to reuse the template that's associated with the stack to create the change
        /// set.
        /// </para>
        /// </summary>
        public bool? UsePreviousTemplate
        {
            get { return this._usePreviousTemplate; }
            set { this._usePreviousTemplate = value; }
        }

        // Check to see if UsePreviousTemplate property is set
        internal bool IsSetUsePreviousTemplate()
        {
            return this._usePreviousTemplate.HasValue; 
        }

    }
}