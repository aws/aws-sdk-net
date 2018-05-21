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
    /// Container for the parameters to the UpdateStackSet operation.
    /// Updates the stack set, and associated stack instances in the specified accounts and
    /// regions.
    /// 
    ///  
    /// <para>
    /// Even if the stack set operation created by updating the stack set fails (completely
    /// or partially, below or above a specified failure tolerance), the stack set is updated
    /// with your changes. Subsequent <a>CreateStackInstances</a> calls on the specified stack
    /// set use the updated stack set.
    /// </para>
    /// </summary>
    public partial class UpdateStackSetRequest : AmazonCloudFormationRequest
    {
        private List<string> _accounts = new List<string>();
        private string _administrationRoleARN;
        private List<string> _capabilities = new List<string>();
        private string _description;
        private string _executionRoleName;
        private string _operationId;
        private StackSetOperationPreferences _operationPreferences;
        private List<Parameter> _parameters = new List<Parameter>();
        private List<string> _regions = new List<string>();
        private string _stackSetName;
        private List<Tag> _tags = new List<Tag>();
        private string _templateBody;
        private string _templateURL;
        private bool? _usePreviousTemplate;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// The accounts in which to update associated stack instances. If you specify accounts,
        /// you must also specify the regions in which to update stack set instances.
        /// </para>
        ///  
        /// <para>
        /// To update <i>all</i> the stack instances associated with this stack set, do not specify
        /// the <code>Accounts</code> or <code>Regions</code> properties.
        /// </para>
        ///  
        /// <para>
        /// If the stack set update includes changes to the template (that is, if the <code>TemplateBody</code>
        /// or <code>TemplateURL</code> properties are specified), or the <code>Parameters</code>
        /// property, AWS CloudFormation marks all stack instances with a status of <code>OUTDATED</code>
        /// prior to updating the stack instances in the specified accounts and regions. If the
        /// stack set update does not include changes to the template or parameters, AWS CloudFormation
        /// updates the stack instances in the specified accounts and regions, while leaving all
        /// other stack instances with their existing stack instance status. 
        /// </para>
        /// </summary>
        public List<string> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && this._accounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AdministrationRoleARN. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the IAM role to use to update this stack set.
        /// </para>
        ///  
        /// <para>
        /// Specify an IAM role only if you are using customized administrator roles to control
        /// which users or groups can manage specific stack sets within the same administrator
        /// account. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs.html">Define
        /// Permissions for Multiple Administrators</a> in the <i>AWS CloudFormation User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  If you specify a customized administrator role, AWS CloudFormation uses that role
        /// to update the stack. If you do not specify a customized administrator role, AWS CloudFormation
        /// performs the update using the role previously associated with the stack set, so long
        /// as you have permissions to perform operations on the stack set.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// A list of values that you must specify before AWS CloudFormation can create certain
        /// stack sets. Some stack set templates might include resources that can affect permissions
        /// in your AWS account—for example, by creating new AWS Identity and Access Management
        /// (IAM) users. For those stack sets, you must explicitly acknowledge their capabilities
        /// by specifying this parameter.
        /// </para>
        ///  
        /// <para>
        /// The only valid values are CAPABILITY_IAM and CAPABILITY_NAMED_IAM. The following resources
        /// require you to specify this parameter: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS::IAM::AccessKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS::IAM::Group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS::IAM::InstanceProfile
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS::IAM::Policy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS::IAM::Role
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS::IAM::User
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS::IAM::UserToGroupAddition
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If your stack template contains these resources, we recommend that you review all
        /// permissions that are associated with them and edit their permissions if necessary.
        /// </para>
        ///  
        /// <para>
        /// If you have IAM resources, you can specify either capability. If you have IAM resources
        /// with custom names, you must specify CAPABILITY_NAMED_IAM. If you don't specify this
        /// parameter, this action returns an <code>InsufficientCapabilities</code> error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-iam-template.html#capabilities">Acknowledging
        /// IAM Resources in AWS CloudFormation Templates.</a> 
        /// </para>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of updates that you are making.
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
        /// Gets and sets the property ExecutionRoleName. 
        /// <para>
        /// The name of the IAM execution role to use to update the stack set. If you do not specify
        /// an execution role, AWS CloudFormation uses the <code>AWSCloudFormationStackSetExecutionRole</code>
        /// role for the stack set operation.
        /// </para>
        ///  
        /// <para>
        /// Specify an IAM role only if you are using customized execution roles to control which
        /// stack resources users and groups can include in their stack sets. 
        /// </para>
        ///  
        /// <para>
        ///  If you specify a customized execution role, AWS CloudFormation uses that role to
        /// update the stack. If you do not specify a customized execution role, AWS CloudFormation
        /// performs the update using the role previously associated with the stack set, so long
        /// as you have permissions to perform operations on the stack set.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique ID for this stack set operation. 
        /// </para>
        ///  
        /// <para>
        /// The operation ID also functions as an idempotency token, to ensure that AWS CloudFormation
        /// performs the stack set operation only once, even if you retry the request multiple
        /// times. You might retry stack set operation requests to ensure that AWS CloudFormation
        /// successfully received them.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an operation ID, AWS CloudFormation generates one automatically.
        /// </para>
        ///  
        /// <para>
        /// Repeating this stack set operation with a new operation ID retries all stack instances
        /// whose status is <code>OUTDATED</code>. 
        /// </para>
        /// </summary>
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
        /// Preferences for how AWS CloudFormation performs this stack set operation.
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
        /// A list of input parameters for the stack set template. 
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
        /// Gets and sets the property Regions. 
        /// <para>
        /// The regions in which to update associated stack instances. If you specify regions,
        /// you must also specify accounts in which to update stack set instances.
        /// </para>
        ///  
        /// <para>
        /// To update <i>all</i> the stack instances associated with this stack set, do not specify
        /// the <code>Accounts</code> or <code>Regions</code> properties.
        /// </para>
        ///  
        /// <para>
        /// If the stack set update includes changes to the template (that is, if the <code>TemplateBody</code>
        /// or <code>TemplateURL</code> properties are specified), or the <code>Parameters</code>
        /// property, AWS CloudFormation marks all stack instances with a status of <code>OUTDATED</code>
        /// prior to updating the stack instances in the specified accounts and regions. If the
        /// stack set update does not include changes to the template or parameters, AWS CloudFormation
        /// updates the stack instances in the specified accounts and regions, while leaving all
        /// other stack instances with their existing stack instance status. 
        /// </para>
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && this._regions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the stack set that you want to update.
        /// </para>
        /// </summary>
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
        /// in the stacks. You can specify a maximum number of 50 tags.
        /// </para>
        ///  
        /// <para>
        /// If you specify tags for this parameter, those tags replace any list of tags that are
        /// currently associated with this stack set. This means:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you don't specify this parameter, AWS CloudFormation doesn't modify the stack's
        /// tags. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <i>any</i> tags using this parameter, you must specify <i>all</i> the
        /// tags that you want associated with this stack set, even tags you've specifed before
        /// (for example, when creating the stack set or during a previous update of the stack
        /// set.). Any tags that you don't include in the updated list of tags are removed from
        /// the stack set, and therefore from the stacks and resources as well. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify an empty value, AWS CloudFormation removes all currently associated
        /// tags.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify new tags as part of an <code>UpdateStackSet</code> action, AWS CloudFormation
        /// checks to see if you have the required IAM permission to tag resources. If you omit
        /// tags that are currently associated with the stack set from the list of tags you specify,
        /// AWS CloudFormation assumes that you want to remove those tags from the stack set,
        /// and checks to see if you have permission to untag resources. If you don't have the
        /// necessary permission(s), the entire <code>UpdateStackSet</code> action fails with
        /// an <code>access denied</code> error, and the stack set is not updated.
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
        /// The structure that contains the template body, with a minimum length of 1 byte and
        /// a maximum length of 51,200 bytes. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <code>TemplateBody</code>
        /// or <code>TemplateURL</code>—or set <code>UsePreviousTemplate</code> to true.
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
        /// The location of the file that contains the template body. The URL must point to a
        /// template (maximum size: 460,800 bytes) that is located in an Amazon S3 bucket. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <code>TemplateBody</code>
        /// or <code>TemplateURL</code>—or set <code>UsePreviousTemplate</code> to true. 
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
        /// Use the existing template that's associated with the stack set that you're updating.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <code>TemplateBody</code>
        /// or <code>TemplateURL</code>—or set <code>UsePreviousTemplate</code> to true. 
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