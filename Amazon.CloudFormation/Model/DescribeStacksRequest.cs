/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeStacks operation.
    /// <para> Returns the description for the specified stack; if no stack
    /// name was specified, then it returns the description for all the stacks
    /// created. </para> <para><b>NOTE:</b> If a specified stack does not
    /// exist or has been successfully deleted, a ValidationError is returned.
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStacks"/>
    public class DescribeStacksRequest : AmazonWebServiceRequest
    {
        private string stackName;

        /// <summary>
        /// The name or the unique identifier associated with the stack. Default: <c>null</c>
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
        public DescribeStacksRequest WithStackName(string stackName)
        {
            this.stackName = stackName;
            return this;
        }
            

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this.stackName != null;       
        }
    }
}
    
