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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStackSet operation.
    /// Creates a stack set.
    /// </summary>
    public partial class CreateStackSetRequest : AmazonCloudFormationRequest
    {
        private string _administrationRoleARN;
        private AutoDeployment _autoDeployment;
        private List<string> _capabilities = new List<string>();
        private string _clientRequestToken;
        private string _description;
        private string _executionRoleName;
        private List<Parameter> _parameters = new List<Parameter>();
        private PermissionModels _permissionModel;
        private string _stackSetName;
        private List<Tag> _tags = new List<Tag>();
        private string _templateBody;
        private string _templateURL;

        /// <summary>
        /// Gets and sets the property AdministrationRoleARN. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the IAM role to use to create this stack set.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Specify an IAM role only if you are using customized administrator roles to control
        /// which users or groups can manage specific stack sets within the same administrator
        /// account. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs.html">Prerequisites:
        /// Granting Permissions for Stack Set Operations</a> in the <i>AWS CloudFormation User
        /// Guide</i>.
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
        /// Describes whether StackSets automatically deploys to AWS Organizations accounts that
        /// are added to the target organization or organizational unit (OU). Specify only if
        /// <code>PermissionModel</code> is <code>SERVICE_MANAGED</code>.
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
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// In some cases, you must explicitly acknowledge that your stack set template contains
        /// certain capabilities in order for AWS CloudFormation to create the stack set and related
        /// stack instances.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CAPABILITY_IAM</code> and <code>CAPABILITY_NAMED_IAM</code> 
        /// </para>
        ///  
        /// <para>
        /// Some stack templates might include resources that can affect permissions in your AWS
        /// account; for example, by creating new AWS Identity and Access Management (IAM) users.
        /// For those stack sets, you must explicitly acknowledge this by specifying one of these
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
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html">
        /// AWS::IAM::AccessKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">
        /// AWS::IAM::Group</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html">
        /// AWS::IAM::InstanceProfile</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html">
        /// AWS::IAM::Policy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html">
        /// AWS::IAM::Role</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html">
        /// AWS::IAM::User</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html">
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
        /// Some templates contain macros. If your stack template contains one or more macros,
        /// and you choose to create a stack directly from the processed template, without first
        /// reviewing the resulting changes in a change set, you must acknowledge this capability.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-macros.html">Using
        /// AWS CloudFormation Macros to Perform Custom Processing on Templates</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Stack sets do not currently support macros in stack templates. (This includes the
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/create-reusable-transform-function-snippets-and-add-to-your-template-with-aws-include-transform.html">AWS::Include</a>
        /// and <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/transform-aws-serverless.html">AWS::Serverless</a>
        /// transforms, which are macros hosted by AWS CloudFormation.) Even if you specify this
        /// capability, if you include a macro in your template the stack set operation will fail.
        /// </para>
        ///  </note> </li> </ul>
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
        /// A unique identifier for this <code>CreateStackSet</code> request. Specify this token
        /// if you plan to retry requests so that AWS CloudFormation knows that you're not attempting
        /// to create another stack set with the same name. You might retry <code>CreateStackSet</code>
        /// requests to ensure that AWS CloudFormation successfully received them.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an operation ID, the SDK generates one automatically. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the stack set. You can use the description to identify the stack
        /// set's purpose or other important information.
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
        /// The name of the IAM execution role to use to create the stack set. If you do not specify
        /// an execution role, AWS CloudFormation uses the <code>AWSCloudFormationStackSetExecutionRole</code>
        /// role for the stack set operation.
        /// </para>
        ///  
        /// <para>
        /// Specify an IAM role only if you are using customized execution roles to control which
        /// stack resources users and groups can include in their stack sets. 
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The input parameters for the stack set template. 
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
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// Describes how the IAM roles required for stack set operations are created. By default,
        /// <code>SELF-MANAGED</code> is specified.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With <code>self-managed</code> permissions, you must create the administrator and
        /// execution roles required to deploy to target accounts. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs-self-managed.html">Grant
        /// Self-Managed Stack Set Permissions</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With <code>service-managed</code> permissions, StackSets automatically creates the
        /// IAM roles required to deploy to accounts managed by AWS Organizations. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs-service-managed.html">Grant
        /// Service-Managed Stack Set Permissions</a>.
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
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name to associate with the stack set. The name must be unique in the Region where
        /// you create your stack set.
        /// </para>
        ///  <note> 
        /// <para>
        /// A stack name can contain only alphanumeric characters (case-sensitive) and hyphens.
        /// It must start with an alphabetic character and can't be longer than 128 characters.
        /// </para>
        ///  </note>
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
        /// The key-value pairs to associate with this stack set and the stacks created from it.
        /// AWS CloudFormation also propagates these tags to supported resources that are created
        /// in the stacks. A maximum number of 50 tags can be specified.
        /// </para>
        ///  
        /// <para>
        /// If you specify tags as part of a <code>CreateStackSet</code> action, AWS CloudFormation
        /// checks to see if you have the required IAM permission to tag resources. If you don't,
        /// the entire <code>CreateStackSet</code> action fails with an <code>access denied</code>
        /// error, and the stack set is not created.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The structure that contains the template body, with a minimum length of 1 byte and
        /// a maximum length of 51,200 bytes. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either the TemplateBody or the TemplateURL parameter,
        /// but not both.
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
        /// The location of the file that contains the template body. The URL must point to a
        /// template (maximum size: 460,800 bytes) that's located in an Amazon S3 bucket. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either the TemplateBody or the TemplateURL parameter,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

    }
}