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
    /// Container for the parameters to the UpdateStack operation.
    /// Updates a stack as specified in the template. After the call completes successfully,
    /// the stack update starts. You can check the status of the stack via the <a>DescribeStacks</a>
    /// action.
    /// 
    ///  
    /// <para>
    /// To get a copy of the template for an existing stack, you can use the <a>GetTemplate</a>
    /// action.
    /// </para>
    ///  
    /// <para>
    /// For more information about creating an update template, updating a stack, and monitoring
    /// the progress of the update, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html">Updating
    /// a Stack</a>.
    /// </para>
    /// </summary>
    public partial class UpdateStackRequest : AmazonCloudFormationRequest
    {
        private List<string> _capabilities = new List<string>();
        private string _clientRequestToken;
        private List<string> _notificationARNs = new List<string>();
        private List<Parameter> _parameters = new List<Parameter>();
        private List<string> _resourceTypes = new List<string>();
        private string _roleARN;
        private RollbackConfiguration _rollbackConfiguration;
        private string _stackName;
        private string _stackPolicyBody;
        private string _stackPolicyDuringUpdateBody;
        private string _stackPolicyDuringUpdateURL;
        private string _stackPolicyURL;
        private List<Tag> _tags = new List<Tag>();
        private string _templateBody;
        private string _templateURL;
        private bool? _usePreviousTemplate;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// In some cases, you must explicity acknowledge that your stack template contains certain
        /// capabilities in order for AWS CloudFormation to update the stack.
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
        /// For more information, see <a href="http://docs.aws.amazon.com/http:/docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-iam-template.html#capabilities">Acknowledging
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
        /// the macros before actually updating the stack. If your stack template contains one
        /// or more macros, and you choose to update a stack directly from the processed template,
        /// without first reviewing the resulting changes in a change set, you must acknowledge
        /// this capability. This includes the <a href="http://docs.aws.amazon.com/http:/docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/create-reusable-transform-function-snippets-and-add-to-your-template-with-aws-include-transform.html">AWS::Include</a>
        /// and <a href="http://docs.aws.amazon.com/http:/docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/transform-aws-serverless.html">AWS::Serverless</a>
        /// transforms, which are macros hosted by AWS CloudFormation.
        /// </para>
        ///  
        /// <para>
        /// Change sets do not currently support nested stacks. If you want to update a stack
        /// from a stack template that contains macros <i>and</i> nested stacks, you must update
        /// the stack directly from the template using this capability.
        /// </para>
        ///  <important> 
        /// <para>
        /// You should only update stacks directly from a stack template that contains macros
        /// if you know what processing the macro performs.
        /// </para>
        ///  
        /// <para>
        /// Each macro relies on an underlying Lambda service function for processing stack templates.
        /// Be aware that the Lambda function owner can update the function operation without
        /// AWS CloudFormation being notified.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/http:/docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-macros.html">Using
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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for this <code>UpdateStack</code> request. Specify this token
        /// if you plan to retry requests so that AWS CloudFormation knows that you're not attempting
        /// to update a stack with the same name. You might retry <code>UpdateStack</code> requests
        /// to ensure that AWS CloudFormation successfully received them.
        /// </para>
        ///  
        /// <para>
        /// All events triggered by a given stack operation are assigned the same client request
        /// token, which you can use to track operations. For example, if you execute a <code>CreateStack</code>
        /// operation with the token <code>token1</code>, then all the <code>StackEvents</code>
        /// generated by that operation will have <code>ClientRequestToken</code> set as <code>token1</code>.
        /// </para>
        ///  
        /// <para>
        /// In the console, stack operations display the client request token on the Events tab.
        /// Stack operations that are initiated from the console use the token format <i>Console-StackOperation-ID</i>,
        /// which helps you easily identify the stack operation . For example, if you create a
        /// stack using the console, each stack event would be assigned the same token in the
        /// following format: <code>Console-CreateStack-7f59c3cf-00d2-40c7-b2ff-e75db0987002</code>.
        /// 
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// Amazon Simple Notification Service topic Amazon Resource Names (ARNs) that AWS CloudFormation
        /// associates with the stack. Specify an empty list to remove all notification topics.
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
        /// stack. For more information, see the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_Parameter.html">Parameter</a>
        /// data type.
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
        /// The template resource types that you have permissions to work with for this update
        /// stack action, such as <code>AWS::EC2::Instance</code>, <code>AWS::EC2::*</code>, or
        /// <code>Custom::MyCustomInstance</code>.
        /// </para>
        ///  
        /// <para>
        /// If the list of resource types doesn't include a resource that you're updating, the
        /// stack update fails. By default, AWS CloudFormation grants permissions to all resource
        /// types. AWS Identity and Access Management (IAM) uses this parameter for AWS CloudFormation-specific
        /// condition keys in IAM policies. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-iam-template.html">Controlling
        /// Access with AWS Identity and Access Management</a>.
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
        /// that AWS CloudFormation assumes to update the stack. AWS CloudFormation uses the role's
        /// credentials to make calls on your behalf. AWS CloudFormation always uses this role
        /// for all future operations on the stack. As long as users have permission to operate
        /// on the stack, AWS CloudFormation uses this role even if the users don't have permission
        /// to pass it. Ensure that the role grants least privilege.
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
        /// The name or unique stack ID of the stack to update.
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
        /// Gets and sets the property StackPolicyBody. 
        /// <para>
        /// Structure containing a new stack policy body. You can specify either the <code>StackPolicyBody</code>
        /// or the <code>StackPolicyURL</code> parameter, but not both.
        /// </para>
        ///  
        /// <para>
        /// You might update the stack policy, for example, in order to protect a new resource
        /// that you created during a stack update. If you do not specify a stack policy, the
        /// current policy that is associated with the stack is unchanged.
        /// </para>
        /// </summary>
        public string StackPolicyBody
        {
            get { return this._stackPolicyBody; }
            set { this._stackPolicyBody = value; }
        }

        // Check to see if StackPolicyBody property is set
        internal bool IsSetStackPolicyBody()
        {
            return this._stackPolicyBody != null;
        }

        /// <summary>
        /// Gets and sets the property StackPolicyDuringUpdateBody. 
        /// <para>
        /// Structure containing the temporary overriding stack policy body. You can specify either
        /// the <code>StackPolicyDuringUpdateBody</code> or the <code>StackPolicyDuringUpdateURL</code>
        /// parameter, but not both.
        /// </para>
        ///  
        /// <para>
        /// If you want to update protected resources, specify a temporary overriding stack policy
        /// during this update. If you do not specify a stack policy, the current policy that
        /// is associated with the stack will be used.
        /// </para>
        /// </summary>
        public string StackPolicyDuringUpdateBody
        {
            get { return this._stackPolicyDuringUpdateBody; }
            set { this._stackPolicyDuringUpdateBody = value; }
        }

        // Check to see if StackPolicyDuringUpdateBody property is set
        internal bool IsSetStackPolicyDuringUpdateBody()
        {
            return this._stackPolicyDuringUpdateBody != null;
        }

        /// <summary>
        /// Gets and sets the property StackPolicyDuringUpdateURL. 
        /// <para>
        /// Location of a file containing the temporary overriding stack policy. The URL must
        /// point to a policy (max size: 16KB) located in an S3 bucket in the same region as the
        /// stack. You can specify either the <code>StackPolicyDuringUpdateBody</code> or the
        /// <code>StackPolicyDuringUpdateURL</code> parameter, but not both.
        /// </para>
        ///  
        /// <para>
        /// If you want to update protected resources, specify a temporary overriding stack policy
        /// during this update. If you do not specify a stack policy, the current policy that
        /// is associated with the stack will be used.
        /// </para>
        /// </summary>
        public string StackPolicyDuringUpdateURL
        {
            get { return this._stackPolicyDuringUpdateURL; }
            set { this._stackPolicyDuringUpdateURL = value; }
        }

        // Check to see if StackPolicyDuringUpdateURL property is set
        internal bool IsSetStackPolicyDuringUpdateURL()
        {
            return this._stackPolicyDuringUpdateURL != null;
        }

        /// <summary>
        /// Gets and sets the property StackPolicyURL. 
        /// <para>
        /// Location of a file containing the updated stack policy. The URL must point to a policy
        /// (max size: 16KB) located in an S3 bucket in the same region as the stack. You can
        /// specify either the <code>StackPolicyBody</code> or the <code>StackPolicyURL</code>
        /// parameter, but not both.
        /// </para>
        ///  
        /// <para>
        /// You might update the stack policy, for example, in order to protect a new resource
        /// that you created during a stack update. If you do not specify a stack policy, the
        /// current policy that is associated with the stack is unchanged.
        /// </para>
        /// </summary>
        public string StackPolicyURL
        {
            get { return this._stackPolicyURL; }
            set { this._stackPolicyURL = value; }
        }

        // Check to see if StackPolicyURL property is set
        internal bool IsSetStackPolicyURL()
        {
            return this._stackPolicyURL != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to associate with this stack. AWS CloudFormation also propagates these
        /// tags to supported resources in the stack. You can specify a maximum number of 50 tags.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this parameter, AWS CloudFormation doesn't modify the stack's
        /// tags. If you specify an empty value, AWS CloudFormation removes all associated tags.
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
        /// Structure containing the template body with a minimum length of 1 byte and a maximum
        /// length of 51,200 bytes. (For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.)
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <code>TemplateBody</code>,
        /// <code>TemplateURL</code>, or set the <code>UsePreviousTemplate</code> to <code>true</code>.
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
        /// Location of file containing the template body. The URL must point to a template that
        /// is located in an Amazon S3 bucket. For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <code>TemplateBody</code>,
        /// <code>TemplateURL</code>, or set the <code>UsePreviousTemplate</code> to <code>true</code>.
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
        /// Reuse the existing template that is associated with the stack that you are updating.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <code>TemplateBody</code>,
        /// <code>TemplateURL</code>, or set the <code>UsePreviousTemplate</code> to <code>true</code>.
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