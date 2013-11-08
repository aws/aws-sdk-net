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
    /// Container for the parameters to the CancelUpdateStack operation.
    /// <para>Cancels an update on the specified stack. If the call completes successfully, the stack will roll back the update and revert to the
    /// previous stack configuration.</para> <para><b>NOTE:</b>Only stacks that are in the UPDATE_IN_PROGRESS state can be canceled.</para>
    /// </summary>
    public partial class CancelUpdateStackRequest : AmazonCloudFormationRequest
    {
        private string stackName;


        /// <summary>
        /// The name or the unique identifier associated with the stack.
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

    }
}
    
