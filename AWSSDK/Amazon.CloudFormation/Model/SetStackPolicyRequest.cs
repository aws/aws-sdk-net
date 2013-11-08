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
    /// Container for the parameters to the SetStackPolicy operation.
    /// <para>Sets a stack policy for a specified stack.</para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.SetStackPolicy"/>
    public class SetStackPolicyRequest : AmazonWebServiceRequest
    {
        private string stackName;
        private string stackPolicyBody;
        private string stackPolicyURL;

        /// <summary>
        /// The name or stack ID that you want to associate a policy with.
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
        public SetStackPolicyRequest WithStackName(string stackName)
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
        /// Structure containing the stack policy body. (For more information, go to the <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/protect-stack-resources.html"> AWS CloudFormation User Guide</a>.) You
        /// must pass <c>StackPolicyBody</c> or <c>StackPolicyURL</c>. If both are passed, only <c>StackPolicyBody</c> is used.
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

        /// <summary>
        /// Sets the StackPolicyBody property
        /// </summary>
        /// <param name="stackPolicyBody">The value to set for the StackPolicyBody property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetStackPolicyRequest WithStackPolicyBody(string stackPolicyBody)
        {
            this.stackPolicyBody = stackPolicyBody;
            return this;
        }
            

        // Check to see if StackPolicyBody property is set
        internal bool IsSetStackPolicyBody()
        {
            return this.stackPolicyBody != null;
        }

        /// <summary>
        /// Location of a file containing the stack policy. The URL must point to a policy (max size: 16KB) located in an S3 bucket in the same region
        /// as the stack. You must pass <c>StackPolicyBody</c> or <c>StackPolicyURL</c>. If both are passed, only <c>StackPolicyBody</c> is used.
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

        /// <summary>
        /// Sets the StackPolicyURL property
        /// </summary>
        /// <param name="stackPolicyURL">The value to set for the StackPolicyURL property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetStackPolicyRequest WithStackPolicyURL(string stackPolicyURL)
        {
            this.stackPolicyURL = stackPolicyURL;
            return this;
        }
            

        // Check to see if StackPolicyURL property is set
        internal bool IsSetStackPolicyURL()
        {
            return this.stackPolicyURL != null;
        }
    }
}
    
