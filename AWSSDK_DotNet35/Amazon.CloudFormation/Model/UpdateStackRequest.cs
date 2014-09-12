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
    /// Tags that were associated with this stack during creation time will still be associated
    /// with the stack after an <code>UpdateStack</code> operation.
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
        private List<string> _notificationARNs = new List<string>();
        private List<Parameter> _parameters = new List<Parameter>();
        private string _stackName;
        private string _stackPolicyBody;
        private string _stackPolicyDuringUpdateBody;
        private string _stackPolicyDuringUpdateURL;
        private string _stackPolicyURL;
        private string _templateBody;
        private string _templateURL;
        private bool? _usePreviousTemplate;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The list of capabilities that you want to allow in the stack. If your stack contains
        /// IAM resources, you must specify the CAPABILITY_IAM value for this parameter; otherwise,
        /// this action returns an InsufficientCapabilities error. IAM resources are the following:
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html">AWS::IAM::AccessKey</a>,
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">AWS::IAM::Group</a>,
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html">AWS::IAM::Policy</a>,
        /// <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html">AWS::IAM::User</a>,
        /// and <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html">AWS::IAM::UserToGroupAddition</a>.
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
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// Update the ARNs for the Amazon SNS topics that are associated with the stack.
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
        /// stack.
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
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or stack ID of the stack to update.
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
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// Structure containing the template body with a minimum length of 1 byte and a maximum
        /// length of 51,200 bytes. (For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.)
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either the <code>TemplateBody</code> or the <code>TemplateURL</code>
        /// parameter, but not both.
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
        /// Location of file containing the template body. The URL must point to a template located
        /// in an S3 bucket in the same region as the stack. For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either the <code>TemplateBody</code> or the <code>TemplateURL</code>
        /// parameter, but not both.
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