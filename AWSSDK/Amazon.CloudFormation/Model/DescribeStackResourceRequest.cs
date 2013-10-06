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
    /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackResource"/>
    public class DescribeStackResourceRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the StackName property
        /// </summary>
        /// <param name="stackName">The value to set for the StackName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStackResourceRequest WithStackName(string stackName)
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
        /// The logical name of the resource as specified in the template. Default: There is no default value.
        ///  
        /// </summary>
        public string LogicalResourceId
        {
            get { return this.logicalResourceId; }
            set { this.logicalResourceId = value; }
        }

        /// <summary>
        /// Sets the LogicalResourceId property
        /// </summary>
        /// <param name="logicalResourceId">The value to set for the LogicalResourceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStackResourceRequest WithLogicalResourceId(string logicalResourceId)
        {
            this.logicalResourceId = logicalResourceId;
            return this;
        }
            

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this.logicalResourceId != null;
        }
    }
}
    
