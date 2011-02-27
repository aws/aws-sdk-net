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
    /// Container for the parameters to the DescribeStackResources operation.
    /// <para> Returns AWS resource descriptions. If <c>StackName</c> is
    /// specified, all the associated resources that are part of the stack are
    /// returned. If <c>PhysicalResourceId</c> is specified, all the
    /// associated resources of the stack the resource belongs to are
    /// returned. </para> <para> You can use <c>LogicalResourceId</c> to
    /// filter the returned result. For more information about resources, the
    /// <c>LogicalResourceId</c> and <c>PhysicalResourceId</c> , go to the AWS
    /// CloudFormation User Guide. </para> <para><b>NOTE:</b> If the stack
    /// does not exist or the stack has been successfully deleted, a
    /// ValidationError is returned. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackResources"/>
    public class DescribeStackResourcesRequest : AmazonWebServiceRequest
    {
        private string stackName;
        private string logicalResourceId;
        private string physicalResourceId;

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
        public DescribeStackResourcesRequest WithStackName(string stackName)
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
        /// The logical name of the resource specified in the template. Default: <c>null</c>
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
        public DescribeStackResourcesRequest WithLogicalResourceId(string logicalResourceId)
        {
            this.logicalResourceId = logicalResourceId;
            return this;
        }
            

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this.logicalResourceId != null;       
        }

        /// <summary>
        /// The name or unique identifier that corresponds to a physical instance ID of a resource supported by AWS CloudFormation. For example, for an
        /// Amazon Elastic Compute Cloud (EC2) instance, <c>PhysicalResourceId</c> corresponds to the <c>InstanceId</c>. You can pass the EC2
        /// <c>InstanceId</c> to <c>DescribeStackResources</c> to find what stack the instance belongs to and what other resources are part of the
        /// stack. Default: <c>null</c>
        ///  
        /// </summary>
        public string PhysicalResourceId
        {
            get { return this.physicalResourceId; }
            set { this.physicalResourceId = value; }
        }

        /// <summary>
        /// Sets the PhysicalResourceId property
        /// </summary>
        /// <param name="physicalResourceId">The value to set for the PhysicalResourceId property </param>
        /// <returns>this instance</returns>
        public DescribeStackResourcesRequest WithPhysicalResourceId(string physicalResourceId)
        {
            this.physicalResourceId = physicalResourceId;
            return this;
        }
            

        // Check to see if PhysicalResourceId property is set
        internal bool IsSetPhysicalResourceId()
        {
            return this.physicalResourceId != null;       
        }
    }
}
    
