/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChangeSet operation.
    /// Creates a list of changes that will be applied to a stack so that you can review the
    /// changes before executing them. You can create a change set for a stack that doesn't
    /// exist or an existing stack. If you create a change set for a stack that doesn't exist,
    /// the change set shows all of the resources that AWS CloudFormation will create. If
    /// you create a change set for an existing stack, AWS CloudFormation compares the stack's
    /// information with the information that you submit in the change set and lists the differences.
    /// Use change sets to understand which resources AWS CloudFormation will create or change,
    /// and how it will change resources in an existing stack, before you create or update
    /// a stack.
    /// 
    ///  
    /// <para>
    /// To create a change set for a stack that doesn't exist, for the <code>ChangeSetType</code>
    /// parameter, specify <code>CREATE</code>. To create a change set for an existing stack,
    /// specify <code>UPDATE</code> for the <code>ChangeSetType</code> parameter. After the
    /// <code>CreateChangeSet</code> call successfully completes, AWS CloudFormation starts
    /// creating the change set. To check the status of the change set or to review it, use
    /// the <a>DescribeChangeSet</a> action.
    /// </para>
    ///  
    /// <para>
    /// When you are satisfied with the changes the change set will make, execute the change
    /// set by using the <a>ExecuteChangeSet</a> action. AWS CloudFormation doesn't make changes
    /// until you execute the change set.
    /// </para>
    /// </summary>
    public partial class CreateChangeSetRequest : AmazonCloudFormationRequest
    {
        private List<string> _capabilities = new List<string>();
        private string _changeSetName;
        private ChangeSetType _changeSetType;
        private string _clientToken;
        private string _description;
        private List<string> _notificationARNs = new List<string>();
        private List<Parameter> _parameters = new List<Parameter>();
        private List<string> _resourceTypes = new List<string>();
        private string _roleARN;
        private RollbackConfiguration _rollbackConfiguration;
        private string _stackName;
        private List<Tag> _tags = new List<Tag>();
        private string _templateBody;
        private string _templateURL;
        private bool? _usePreviousTemplate;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// In some cases, you must explicity acknowledge that your stack template contains certain
        /// capabilities in order for AWS CloudFormation to create the stack.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CAPABILITY_IAM</code> and <code>CAPABILITY_NAMED_IAM</code> 
        /// </para>
        ///  
        /// <para>
        /// Some stack templates might include resources that can affect permissions in your AWS
        /// account; for example, by creating new AWS Identity and Access Management (IAM) users.
        /// For those stacks, you must explicitly acknowledge this by specifying one of these
        /// capabilities.
        /// </para>
        ///  
        /// <para>
        /// The following IAM resources require you to specify either the <code>CAPABILITY_IAM</code>
        /// or <code>CAPABILITY_NAMED_IAM</code> capability.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have IAM resources, you can specify either capability. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have IAM resources with custom names, you <i>must</i> specify <code>CAPABILITY_NAMED_IAM</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify either of these capabilities, AWS CloudFormation returns an <code>InsufficientCapabilities</code>
        /// error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If your stack template contains these resources, we recommend that you review all
        /// permissions associated with them and edit their permissions if necessary.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html">
        /// AWS::IAM::AccessKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">
        /// AWS::IAM::Group</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html">
        /// AWS::IAM::InstanceProfile</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html">
        /// AWS::IAM::Policy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html">
        /// AWS::IAM::Role</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html">
        /// AWS::IAM::User</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html">
        /// AWS::IAM::UserToGroupAddition</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-iam-template.html#capabilities">Acknowledging
        /// IAM Resources in AWS CloudFormation Templates</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CAPABILITY_AUTO_EXPAND</code> 
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
        /// this capability. This includes the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/create-reusable-transform-function-snippets-and-add-to-your-template-with-aws-include-transform.html">AWS::Include</a>
        /// and <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/transform-aws-serverless.html">AWS::Serverless</a>
        /// transforms, which are macros hosted by AWS CloudFormation.
        /// </para>
        ///  <note> 
        /// <para>
        /// This capacity does not apply to creating change sets, and specifying it when creating
        /// change sets has no effect.
        /// </para>
        ///  
        /// <para>
        /// Also, change sets do not currently support nested stacks. If you want to create a
        /// stack from a stack template that contains macros <i>and</i> nested stacks, you must
        /// create or update the stack directly from the template using the <a>CreateStack</a>
        /// or <a>UpdateStack</a> action, and specifying this capability.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on macros, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-macros.html">Using
        /// AWS CloudFormation Macros to Perform Custom Processing on Templates</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && this._capabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name of the change set. The name must be unique among all change sets that are
        /// associated with the specified stack.
        /// </para>
        ///  
        /// <para>
        /// A change set name can contain only alphanumeric, case sensitive characters and hyphens.
        /// It must start with an alphabetic character and cannot exceed 128 characters.
        /// </para>
        /// </summary>
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
        /// <code>CREATE</code>. To create a change set for an existing stack, specify <code>UPDATE</code>.
        /// </para>
        ///  
        /// <para>
        /// If you create a change set for a new stack, AWS Cloudformation creates a stack with
        /// a unique stack ID, but no template or resources. The stack will be in the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-describing-stacks.html#d0e11995">
        /// <code>REVIEW_IN_PROGRESS</code> </a> state until you execute the change set.
        /// </para>
        ///  
        /// <para>
        /// By default, AWS CloudFormation specifies <code>UPDATE</code>. You can't use the <code>UPDATE</code>
        /// type to create a change set for a new stack or the <code>CREATE</code> type to create
        /// a change set for an existing stack.
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
        /// A unique identifier for this <code>CreateChangeSet</code> request. Specify this token
        /// if you plan to retry requests so that AWS CloudFormation knows that you're not attempting
        /// to create another change set with the same name. You might retry <code>CreateChangeSet</code>
        /// requests to ensure that AWS CloudFormation successfully received them.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Amazon Simple Notification Service (Amazon SNS)
        /// topics that AWS CloudFormation associates with the stack. To remove all associated
        /// notification topics, specify an empty list.
        /// </para>
        /// </summary>
        public List<string> NotificationARNs
        {
            get { return this._notificationARNs; }
            set { this._notificationARNs = value; }
        }

        // Check to see if NotificationARNs property is set
        internal bool IsSetNotificationARNs()
        {
            return this._notificationARNs != null && this._notificationARNs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <code>Parameter</code> structures that specify input parameters for the
        /// change set. For more information, see the <a>Parameter</a> data type.
        /// </para>
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The template resource types that you have permissions to work with if you execute
        /// this change set, such as <code>AWS::EC2::Instance</code>, <code>AWS::EC2::*</code>,
        /// or <code>Custom::MyCustomInstance</code>.
        /// </para>
        ///  
        /// <para>
        /// If the list of resource types doesn't include a resource type that you're updating,
        /// the stack update fails. By default, AWS CloudFormation grants permissions to all resource
        /// types. AWS Identity and Access Management (IAM) uses this parameter for condition
        /// keys in IAM policies for AWS CloudFormation. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-iam-template.html">Controlling
        /// Access with AWS Identity and Access Management</a> in the AWS CloudFormation User
        /// Guide.
        /// </para>
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role
        /// that AWS CloudFormation assumes when executing the change set. AWS CloudFormation
        /// uses the role's credentials to make calls on your behalf. AWS CloudFormation uses
        /// this role for all future operations on the stack. As long as users have permission
        /// to operate on the stack, AWS CloudFormation uses this role even if the users don't
        /// have permission to pass it. Ensure that the role grants least privilege.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, AWS CloudFormation uses the role that was previously
        /// associated with the stack. If no role is available, AWS CloudFormation uses a temporary
        /// session that is generated from your user credentials.
        /// </para>
        /// </summary>
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
        /// The rollback triggers for AWS CloudFormation to monitor during stack creation and
        /// updating operations, and for the specified monitoring period afterwards.
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
        /// The name or the unique ID of the stack for which you are creating a change set. AWS
        /// CloudFormation generates the change set by comparing this stack's information with
        /// the information that you submit, such as a modified template or different parameter
        /// input values.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to associate with this stack. AWS CloudFormation also propagates these
        /// tags to resources in the stack. You can specify a maximum of 50 tags.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// A structure that contains the body of the revised template, with a minimum length
        /// of 1 byte and a maximum length of 51,200 bytes. AWS CloudFormation generates the change
        /// set by comparing this template with the template of the stack that you specified.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only <code>TemplateBody</code> or <code>TemplateURL</code>.
        /// </para>
        /// </summary>
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
        /// The location of the file that contains the revised template. The URL must point to
        /// a template (max size: 460,800 bytes) that is located in an S3 bucket. AWS CloudFormation
        /// generates the change set by comparing this template with the stack that you specified.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only <code>TemplateBody</code> or <code>TemplateURL</code>.
        /// </para>
        /// </summary>
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
        /// Whether to reuse the template that is associated with the stack to create the change
        /// set.
        /// </para>
        /// </summary>
        public bool UsePreviousTemplate
        {
            get { return this._usePreviousTemplate.GetValueOrDefault(); }
            set { this._usePreviousTemplate = value; }
        }

        // Check to see if UsePreviousTemplate property is set
        internal bool IsSetUsePreviousTemplate()
        {
            return this._usePreviousTemplate.HasValue; 
        }

    }
}