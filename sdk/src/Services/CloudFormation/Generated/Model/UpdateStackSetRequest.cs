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
    /// Container for the parameters to the UpdateStackSet operation.
    /// Updates the StackSet and associated stack instances in the specified accounts and
    /// Amazon Web Services Regions.
    /// 
    ///  
    /// <para>
    /// Even if the StackSet operation created by updating the StackSet fails (completely
    /// or partially, below or above a specified failure tolerance), the StackSet is updated
    /// with your changes. Subsequent <a>CreateStackInstances</a> calls on the specified StackSet
    /// use the updated StackSet.
    /// </para>
    ///  <note> 
    /// <para>
    /// The maximum number of organizational unit (OUs) supported by a <c>UpdateStackSet</c>
    /// operation is 50.
    /// </para>
    ///  
    /// <para>
    /// If you need more than 50, consider the following options:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Batch processing:</i> If you don't want to expose your OU hierarchy, split up
    /// the operations into multiple calls with less than 50 OUs each.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Parent OU strategy:</i> If you don't mind exposing the OU hierarchy, target a
    /// parent OU that contains all desired child OUs.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class UpdateStackSetRequest : AmazonCloudFormationRequest
    {
        private List<string> _accounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _administrationRoleARN;
        private AutoDeployment _autoDeployment;
        private CallAs _callAs;
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DeploymentTargets _deploymentTargets;
        private string _description;
        private string _executionRoleName;
        private ManagedExecution _managedExecution;
        private string _operationId;
        private StackSetOperationPreferences _operationPreferences;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private PermissionModels _permissionModel;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _stackSetName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _templateBody;
        private string _templateURL;
        private bool? _usePreviousTemplate;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// [Self-managed permissions] The accounts in which to update associated stack instances.
        /// If you specify accounts, you must also specify the Amazon Web Services Regions in
        /// which to update StackSet instances.
        /// </para>
        ///  
        /// <para>
        /// To update <i>all</i> the stack instances associated with this StackSet, don't specify
        /// the <c>Accounts</c> or <c>Regions</c> properties.
        /// </para>
        ///  
        /// <para>
        /// If the StackSet update includes changes to the template (that is, if the <c>TemplateBody</c>
        /// or <c>TemplateURL</c> properties are specified), or the <c>Parameters</c> property,
        /// CloudFormation marks all stack instances with a status of <c>OUTDATED</c> prior to
        /// updating the stack instances in the specified accounts and Amazon Web Services Regions.
        /// If the StackSet update does not include changes to the template or parameters, CloudFormation
        /// updates the stack instances in the specified accounts and Amazon Web Services Regions,
        /// while leaving all other stack instances with their existing stack instance status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && (this._accounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdministrationRoleARN. 
        /// <para>
        /// [Self-managed permissions] The Amazon Resource Name (ARN) of the IAM role to use to
        /// update this StackSet.
        /// </para>
        ///  
        /// <para>
        /// Specify an IAM role only if you are using customized administrator roles to control
        /// which users or groups can manage specific StackSets within the same administrator
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs-self-managed.html">Grant
        /// self-managed permissions</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specified a customized administrator role when you created the StackSet, you
        /// must specify a customized administrator role, even if it is the same customized administrator
        /// role used with this StackSet previously.
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
        /// Gets and sets the property AutoDeployment. 
        /// <para>
        /// [Service-managed permissions] Describes whether StackSets automatically deploys to
        /// Organizations accounts that are added to a target organization or organizational unit
        /// (OU). For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-manage-auto-deployment.html">Enable
        /// or disable automatic deployments for StackSets in Organizations</a> in the <i>CloudFormation
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>AutoDeployment</c>, don't specify <c>DeploymentTargets</c> or <c>Regions</c>.
        /// </para>
        /// </summary>
        public AutoDeployment AutoDeployment
        {
            get { return this._autoDeployment; }
            set { this._autoDeployment = value; }
        }

        // Check to see if AutoDeployment property is set
        internal bool IsSetAutoDeployment()
        {
            return this._autoDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// [Service-managed permissions] Specifies whether you are acting as an account administrator
        /// in the organization's management account or as a delegated administrator in a member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>SELF</c> is specified. Use <c>SELF</c> for StackSets with self-managed
        /// permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <c>SELF</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <c>DELEGATED_ADMIN</c>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs
        {
            get { return this._callAs; }
            set { this._callAs = value; }
        }

        // Check to see if CallAs property is set
        internal bool IsSetCallAs()
        {
            return this._callAs != null;
        }

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// In some cases, you must explicitly acknowledge that your stack template contains certain
        /// capabilities in order for CloudFormation to update the StackSet and its associated
        /// stack instances.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CAPABILITY_IAM</c> and <c>CAPABILITY_NAMED_IAM</c> 
        /// </para>
        ///  
        /// <para>
        /// Some stack templates might include resources that can affect permissions in your Amazon
        /// Web Services account, for example, by creating new IAM users. For those stacks sets,
        /// you must explicitly acknowledge this by specifying one of these capabilities.
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
        /// If your stack template contains these resources, we recommend that you review all
        /// permissions associated with them and edit their permissions if necessary.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-accesskey.html">AWS::IAM::AccessKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-group.html">AWS::IAM::Group</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-instanceprofile.html">AWS::IAM::InstanceProfile</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-policy.html">AWS::IAM::Policy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-role.html">AWS::IAM::Role</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/aws-resource-iam-user.html">AWS::IAM::User</a>
        /// 
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
        /// Some templates reference macros. If your StackSet template references one or more
        /// macros, you must update the StackSet directly from the processed template, without
        /// first reviewing the resulting changes in a change set. To update the StackSet directly,
        /// you must acknowledge this capability. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-macros.html">Perform
        /// custom processing on CloudFormation templates with template macros</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// StackSets with service-managed permissions do not currently support the use of macros
        /// in templates. (This includes the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/transform-aws-include.html">AWS::Include</a>
        /// and <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/transform-aws-serverless.html">AWS::Serverless</a>
        /// transforms, which are macros hosted by CloudFormation.) Even if you specify this capability
        /// for a StackSet with service-managed permissions, if you reference a macro in your
        /// template the StackSet operation will fail.
        /// </para>
        ///  </important> </li> </ul>
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
        /// Gets and sets the property DeploymentTargets. 
        /// <para>
        /// [Service-managed permissions] The Organizations accounts in which to update associated
        /// stack instances.
        /// </para>
        ///  
        /// <para>
        /// To update all the stack instances associated with this StackSet, do not specify <c>DeploymentTargets</c>
        /// or <c>Regions</c>.
        /// </para>
        ///  
        /// <para>
        /// If the StackSet update includes changes to the template (that is, if <c>TemplateBody</c>
        /// or <c>TemplateURL</c> is specified), or the <c>Parameters</c>, CloudFormation marks
        /// all stack instances with a status of <c>OUTDATED</c> prior to updating the stack instances
        /// in the specified accounts and Amazon Web Services Regions. If the StackSet update
        /// doesn't include changes to the template or parameters, CloudFormation updates the
        /// stack instances in the specified accounts and Regions, while leaving all other stack
        /// instances with their existing stack instance status.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of updates that you are making.
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
        /// Gets and sets the property ExecutionRoleName. 
        /// <para>
        /// [Self-managed permissions] The name of the IAM execution role to use to update the
        /// stack set. If you do not specify an execution role, CloudFormation uses the <c>AWSCloudFormationStackSetExecutionRole</c>
        /// role for the StackSet operation.
        /// </para>
        ///  
        /// <para>
        /// Specify an IAM role only if you are using customized execution roles to control which
        /// stack resources users and groups can include in their StackSets.
        /// </para>
        ///  
        /// <para>
        /// If you specify a customized execution role, CloudFormation uses that role to update
        /// the stack. If you do not specify a customized execution role, CloudFormation performs
        /// the update using the role previously associated with the StackSet, so long as you
        /// have permissions to perform operations on the StackSet.
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
        /// Gets and sets the property ManagedExecution. 
        /// <para>
        /// Describes whether CloudFormation performs non-conflicting operations concurrently
        /// and queues conflicting operations.
        /// </para>
        /// </summary>
        public ManagedExecution ManagedExecution
        {
            get { return this._managedExecution; }
            set { this._managedExecution = value; }
        }

        // Check to see if ManagedExecution property is set
        internal bool IsSetManagedExecution()
        {
            return this._managedExecution != null;
        }

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique ID for this StackSet operation.
        /// </para>
        ///  
        /// <para>
        /// The operation ID also functions as an idempotency token, to ensure that CloudFormation
        /// performs the StackSet operation only once, even if you retry the request multiple
        /// times. You might retry StackSet operation requests to ensure that CloudFormation successfully
        /// received them.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an operation ID, CloudFormation generates one automatically.
        /// </para>
        ///  
        /// <para>
        /// Repeating this StackSet operation with a new operation ID retries all stack instances
        /// whose status is <c>OUTDATED</c>.
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
        /// Preferences for how CloudFormation performs this StackSet operation.
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of input parameters for the StackSet template.
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
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// Describes how the IAM roles required for StackSet operations are created. You cannot
        /// modify <c>PermissionModel</c> if there are stack instances associated with your stack
        /// set.
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
        public PermissionModels PermissionModel
        {
            get { return this._permissionModel; }
            set { this._permissionModel = value; }
        }

        // Check to see if PermissionModel property is set
        internal bool IsSetPermissionModel()
        {
            return this._permissionModel != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Amazon Web Services Regions in which to update associated stack instances. If
        /// you specify Regions, you must also specify accounts in which to update StackSet instances.
        /// </para>
        ///  
        /// <para>
        /// To update <i>all</i> the stack instances associated with this StackSet, do not specify
        /// the <c>Accounts</c> or <c>Regions</c> properties.
        /// </para>
        ///  
        /// <para>
        /// If the StackSet update includes changes to the template (that is, if the <c>TemplateBody</c>
        /// or <c>TemplateURL</c> properties are specified), or the <c>Parameters</c> property,
        /// CloudFormation marks all stack instances with a status of <c>OUTDATED</c> prior to
        /// updating the stack instances in the specified accounts and Regions. If the StackSet
        /// update does not include changes to the template or parameters, CloudFormation updates
        /// the stack instances in the specified accounts and Regions, while leaving all other
        /// stack instances with their existing stack instance status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the StackSet that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs to associate with this StackSet and the stacks created from it.
        /// CloudFormation also propagates these tags to supported resources that are created
        /// in the stacks. You can specify a maximum number of 50 tags.
        /// </para>
        ///  
        /// <para>
        /// If you specify tags for this parameter, those tags replace any list of tags that are
        /// currently associated with this StackSet. This means:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you don't specify this parameter, CloudFormation doesn't modify the stack's tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <i>any</i> tags using this parameter, you must specify <i>all</i> the
        /// tags that you want associated with this StackSet, even tags you've specified before
        /// (for example, when creating the StackSet or during a previous update of the StackSet.).
        /// Any tags that you don't include in the updated list of tags are removed from the StackSet,
        /// and therefore from the stacks and resources as well.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify an empty value, CloudFormation removes all currently associated tags.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify new tags as part of an <c>UpdateStackSet</c> action, CloudFormation
        /// checks to see if you have the required IAM permission to tag resources. If you omit
        /// tags that are currently associated with the StackSet from the list of tags you specify,
        /// CloudFormation assumes that you want to remove those tags from the StackSet, and checks
        /// to see if you have permission to untag resources. If you don't have the necessary
        /// permission(s), the entire <c>UpdateStackSet</c> action fails with an <c>access denied</c>
        /// error, and the StackSet is not updated.
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
        /// The structure that contains the template body, with a minimum length of 1 byte and
        /// a maximum length of 51,200 bytes.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <c>TemplateBody</c>
        /// or <c>TemplateURL</c>—or set <c>UsePreviousTemplate</c> to true.
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
        /// The URL of a file that contains the template body. The URL must point to a template
        /// (maximum size: 1 MB) that is located in an Amazon S3 bucket or a Systems Manager document.
        /// The location for an Amazon S3 bucket must start with <c>https://</c>. S3 static website
        /// URLs are not supported.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <c>TemplateBody</c>
        /// or <c>TemplateURL</c>—or set <c>UsePreviousTemplate</c> to true.
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
        /// Use the existing template that's associated with the StackSet that you're updating.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <c>TemplateBody</c>
        /// or <c>TemplateURL</c>—or set <c>UsePreviousTemplate</c> to true.
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