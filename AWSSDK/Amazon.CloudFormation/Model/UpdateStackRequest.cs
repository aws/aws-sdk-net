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
    /// of the stack via the DescribeStacks action.</para> <para>To get a copy of the template for an existing stack, you can use the GetTemplate
    /// action.</para> <para>Tags that were associated with this stack during creation time will still be associated with the stack after an
    /// <c>UpdateStack</c> operation.</para> <para>For more information about creating an update template, updating a stack, and monitoring the
    /// progress of the update, see Updating a Stack.</para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.UpdateStack"/>
    public class UpdateStackRequest : AmazonWebServiceRequest
    {
        private string stackName;
        private string templateBody;
        private string templateURL;
        private List<Parameter> parameters = new List<Parameter>();
        private List<string> capabilities = new List<string>();

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

        /// <summary>
        /// Sets the StackName property
        /// </summary>
        /// <param name="stackName">The value to set for the StackName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStackRequest WithStackName(string stackName)
        {
            this.stackName = stackName;
            return this;
        }
            

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this.stackName != null;
        }

        /// <summary>
        /// Structure containing the template body. (For more information, go to the <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a>.) Conditional: You must pass
        /// <c>TemplateBody</c> or <c>TemplateURL</c>. If both are passed, only <c>TemplateBody</c> is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 51200</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateBody
        {
            get { return this.templateBody; }
            set { this.templateBody = value; }
        }

        /// <summary>
        /// Sets the TemplateBody property
        /// </summary>
        /// <param name="templateBody">The value to set for the TemplateBody property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStackRequest WithTemplateBody(string templateBody)
        {
            this.templateBody = templateBody;
            return this;
        }
            

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this.templateBody != null;
        }

        /// <summary>
        /// Location of file containing the template body. The URL must point to a template located in an S3 bucket in the same region as the stack. For
        /// more information, go to the <a href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User
        /// Guide</a>. Conditional: You must pass <c>TemplateURL</c> or <c>TemplateBody</c>. If both are passed, only <c>TemplateBody</c> is used.
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

        /// <summary>
        /// Sets the TemplateURL property
        /// </summary>
        /// <param name="templateURL">The value to set for the TemplateURL property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStackRequest WithTemplateURL(string templateURL)
        {
            this.templateURL = templateURL;
            return this;
        }
            

        // Check to see if TemplateURL property is set
        internal bool IsSetTemplateURL()
        {
            return this.templateURL != null;
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
        /// <summary>
        /// Adds elements to the Parameters collection
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStackRequest WithParameters(params Parameter[] parameters)
        {
            foreach (Parameter element in parameters)
            {
                this.parameters.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Parameters collection
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStackRequest WithParameters(IEnumerable<Parameter> parameters)
        {
            foreach (Parameter element in parameters)
            {
                this.parameters.Add(element);
            }

            return this;
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;
        }

        /// <summary>
        /// The list of capabilities that you want to allow in the stack. If your stack contains IAM resources, you must specify the CAPABILITY_IAM
        /// value for this parameter; otherwise, this action returns an InsufficientCapabilities error. IAM resources are the following: <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html">AWS::IAM::AccessKey</a>, <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">AWS::IAM::Group</a>, <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html">AWS::IAM::Policy</a>, <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user.html">AWS::IAM::User</a>, and <a
        /// href="http://docs.amazon
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// webservices.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html">AWS::IAM::UserToGroupAddition</a>.
        ///  
        /// </summary>
        public List<string> Capabilities
        {
            get { return this.capabilities; }
            set { this.capabilities = value; }
        }
        /// <summary>
        /// Adds elements to the Capabilities collection
        /// </summary>
        /// <param name="capabilities">The values to add to the Capabilities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStackRequest WithCapabilities(params string[] capabilities)
        {
            foreach (string element in capabilities)
            {
                this.capabilities.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Capabilities collection
        /// </summary>
        /// <param name="capabilities">The values to add to the Capabilities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStackRequest WithCapabilities(IEnumerable<string> capabilities)
        {
            foreach (string element in capabilities)
            {
                this.capabilities.Add(element);
            }

            return this;
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this.capabilities.Count > 0;
        }
    }
}
    
