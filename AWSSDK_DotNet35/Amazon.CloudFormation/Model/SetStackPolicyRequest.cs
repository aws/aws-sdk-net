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
    /// Container for the parameters to the SetStackPolicy operation.
    /// Sets a stack policy for a specified stack.
    /// </summary>
    public partial class SetStackPolicyRequest : AmazonCloudFormationRequest
    {
        private string _stackName;
        private string _stackPolicyBody;
        private string _stackPolicyURL;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or unique stack ID that you want to associate a policy with.
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
        /// Structure containing the stack policy body. For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/protect-stack-resources.html">
        /// Prevent Updates to Stack Resources</a> in the AWS CloudFormation User Guide. You can
        /// specify either the <code>StackPolicyBody</code> or the <code>StackPolicyURL</code>
        /// parameter, but not both.
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
        /// Gets and sets the property StackPolicyURL. 
        /// <para>
        /// Location of a file containing the stack policy. The URL must point to a policy (max
        /// size: 16KB) located in an S3 bucket in the same region as the stack. You can specify
        /// either the <code>StackPolicyBody</code> or the <code>StackPolicyURL</code> parameter,
        /// but not both.
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

    }
}