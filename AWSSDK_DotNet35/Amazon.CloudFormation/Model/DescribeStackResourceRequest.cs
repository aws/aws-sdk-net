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
    /// Container for the parameters to the DescribeStackResource operation.
    /// <para>Returns a description of the specified resource in the specified stack.</para> <para>For deleted stacks, DescribeStackResource returns
    /// resource information for up to 90 days after the stack has been deleted.</para>
    /// </summary>
    public partial class DescribeStackResourceRequest : AmazonCloudFormationRequest
    {
        private string stackName;
        private string logicalResourceId;


        /// <summary>
        /// The name or the unique identifier associated with the stack. Default: There is no default value.
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
        /// The logical name of the resource as specified in the template. Default: There is no default value.
        ///  
        /// </summary>
        public string LogicalResourceId
        {
            get { return this.logicalResourceId; }
            set { this.logicalResourceId = value; }
        }

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this.logicalResourceId != null;
        }

    }
}
    
