/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Updates a stack as specified in the template. After the call completes successfully, the stack update starts. You can check the status
    /// of the stack via the DescribeStacks action.</para> <para> <b>Note: </b> You cannot update <a
    /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html" >AWS::S3::Bucket</a> resources, for
    /// example, to add or modify tags.</para> <para>To get a copy of the template for an existing stack, you can use the GetTemplate
    /// action.</para> <para>Tags that were associated with this stack during creation time will still be associated with the stack after an
    /// <c>UpdateStack</c> operation.</para> <para>For more information about creating an update template, updating a stack, and monitoring the
    /// progress of the update, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html" >Updating
    /// a Stack</a> .</para>
    /// </summary>
    public partial class UpdateStackRequest : AmazonCloudFormationRequest
    {
        private string stackName;
        private string templateBody;
        private string templateURL;
        private string stackPolicyDuringUpdateBody;
        private string stackPolicyDuringUpdateURL;
        private List<Parameter> parameters = new List<Parameter>();
        private List<string> capabilities = new List<string>();
        private string stackPolicyBody;
        private string stackPolicyURL;


        /// <summary>
        /// The name or stack ID of the stack to update. <note> Must contain only alphanumeric characters (case sensitive) and start with an alpha
        /// character. Maximum length of the name is 255 characters. </note>
        ///  
        /// </summary>
        public string StackName
        {
            get { return this.stackName; }
            set { this.stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this.stackName != null;
        }

        /// <summary>
        /// Structure containing the template body. (For more information, go to the <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a>.) Conditional: You must pass
        /// <c>TemplateBody</c> or <c>TemplateURL</c>. If both are passed, only <c>TemplateBody</c> is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateBody
        {
            get { return this.templateBody; }
            set { this.templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this.templateBody != null;
        }

        /// <summary>
        /// Location of file containing the template body. The URL must point to a template located in an S3 bucket in the same region as the stack. For
        /// more information, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a>.
        /// Conditional: You must pass <c>TemplateURL</c> or <c>TemplateBody</c>. If both are passed, only <c>TemplateBody</c> is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateURL
        {
            get { return this.templateURL; }
            set { this.templateURL = value; }
        }

        // Check to see if TemplateURL property is set
        internal bool IsSetTemplateURL()
        {
            return this.templateURL != null;
        }

        /// <summary>
        /// Structure containing the temporary overriding stack policy body. If you pass <c>StackPolicyDuringUpdateBody</c> and
        /// <c>StackPolicyDuringUpdateURL</c>, only <c>StackPolicyDuringUpdateBody</c> is used. If you want to update protected resources, specify a
        /// temporary overriding stack policy during this update. If you do not specify a stack policy, the current policy that associated with the
        /// stack will be used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 16384</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StackPolicyDuringUpdateBody
        {
            get { return this.stackPolicyDuringUpdateBody; }
            set { this.stackPolicyDuringUpdateBody = value; }
        }

        // Check to see if StackPolicyDuringUpdateBody property is set
        internal bool IsSetStackPolicyDuringUpdateBody()
        {
            return this.stackPolicyDuringUpdateBody != null;
        }

        /// <summary>
        /// Location of a file containing the temporary overriding stack policy. The URL must point to a policy (max size: 16KB) located in an S3 bucket
        /// in the same region as the stack. If you pass <c>StackPolicyDuringUpdateBody</c> and <c>StackPolicyDuringUpdateURL</c>, only
        /// <c>StackPolicyDuringUpdateBody</c> is used. If you want to update protected resources, specify a temporary overriding stack policy during
        /// this update. If you do not specify a stack policy, the current policy that is associated with the stack will be used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1350</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StackPolicyDuringUpdateURL
        {
            get { return this.stackPolicyDuringUpdateURL; }
            set { this.stackPolicyDuringUpdateURL = value; }
        }

        // Check to see if StackPolicyDuringUpdateURL property is set
        internal bool IsSetStackPolicyDuringUpdateURL()
        {
            return this.stackPolicyDuringUpdateURL != null;
        }

        /// <summary>
        /// A list of <c>Parameter</c> structures that specify input parameters for the stack.
        ///  
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;
        }

        /// <summary>
        /// The list of capabilities that you want to allow in the stack. If your stack contains IAM resources, you must specify the CAPABILITY_IAM
        /// value for this parameter; otherwise, this action returns an InsufficientCapabilities error. IAM resources are the following: <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html">AWS::IAM::AccessKey</a>, <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">AWS::IAM::Group</a>, <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html">AWS::IAM::Policy</a>, <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html">AWS::IAM::User</a>, and <a
        /// ef="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html">AWS::IAM::UserToGroupAddition</a>.
        ///  
        /// </summary>
        public List<string> Capabilities
        {
            get { return this.capabilities; }
            set { this.capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this.capabilities.Count > 0;
        }

        /// <summary>
        /// Structure containing the updated stack policy body. If you pass <c>StackPolicyBody</c> and <c>StackPolicyURL</c>, only
        /// <c>StackPolicyBody</c> is used. If you want to update a stack policy during a stack update, specify an updated stack policy. For example,
        /// you can include an updated stack policy to protect a new resource created in the stack update. If you do not specify a stack policy, the
        /// current policy that is associated with the stack is unchanged.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 16384</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StackPolicyBody
        {
            get { return this.stackPolicyBody; }
            set { this.stackPolicyBody = value; }
        }

        // Check to see if StackPolicyBody property is set
        internal bool IsSetStackPolicyBody()
        {
            return this.stackPolicyBody != null;
        }

        /// <summary>
        /// Location of a file containing the updated stack policy. The URL must point to a policy (max size: 16KB) located in an S3 bucket in the same
        /// region as the stack. If you pass <c>StackPolicyBody</c> and <c>StackPolicyURL</c>, only <c>StackPolicyBody</c> is used. If you want to
        /// update a stack policy during a stack update, specify an updated stack policy. For example, you can include an updated stack policy to
        /// protect a new resource created in the stack update. If you do not specify a stack policy, the current policy that is associated with the
        /// stack is unchanged.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1350</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StackPolicyURL
        {
            get { return this.stackPolicyURL; }
            set { this.stackPolicyURL = value; }
        }

        // Check to see if StackPolicyURL property is set
        internal bool IsSetStackPolicyURL()
        {
            return this.stackPolicyURL != null;
        }

    }
}
    
