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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The output for the GetStackPolicy action.</para>
    /// </summary>
    public partial class GetStackPolicyResult
    {
        
        private string stackPolicyBody;

        /// <summary>
        /// Structure containing the stack policy body. (For more information, go to <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/protect-stack-resources.html"> Prevent Updates to Stack Resources</a> in
        /// the AWS CloudFormation User Guide.)
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
        public GetStackPolicyResult WithStackPolicyBody(string stackPolicyBody)
        {
            this.stackPolicyBody = stackPolicyBody;
            return this;
        }
            

        // Check to see if StackPolicyBody property is set
        internal bool IsSetStackPolicyBody()
        {
            return this.stackPolicyBody != null;
        }
    }
}
