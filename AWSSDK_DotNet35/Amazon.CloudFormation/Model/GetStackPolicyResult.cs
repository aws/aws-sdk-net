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
    /// The output for the <a>GetStackPolicy</a> action.
    /// </summary>
    public partial class GetStackPolicyResult : AmazonWebServiceResponse
    {
        private string _stackPolicyBody;

        /// <summary>
        /// Gets and sets the property StackPolicyBody. 
        /// <para>
        /// Structure containing the stack policy body. (For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/protect-stack-resources.html">
        /// Prevent Updates to Stack Resources</a> in the AWS CloudFormation User Guide.)
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

    }
}