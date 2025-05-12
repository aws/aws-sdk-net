/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStackResources operation.
    /// Returns Amazon Web Services resource descriptions for running and deleted stacks.
    /// If <c>StackName</c> is specified, all the associated resources that are part of the
    /// stack are returned. If <c>PhysicalResourceId</c> is specified, the associated resources
    /// of the stack that the resource belongs to are returned.
    /// 
    ///  <note> 
    /// <para>
    /// Only the first 100 resources will be returned. If your stack has more resources than
    /// this, you should use <c>ListStackResources</c> instead.
    /// </para>
    ///  </note> 
    /// <para>
    /// For deleted stacks, <c>DescribeStackResources</c> returns resource information for
    /// up to 90 days after the stack has been deleted.
    /// </para>
    ///  
    /// <para>
    /// You must specify either <c>StackName</c> or <c>PhysicalResourceId</c>, but not both.
    /// In addition, you can specify <c>LogicalResourceId</c> to filter the returned result.
    /// For more information about resources, the <c>LogicalResourceId</c> and <c>PhysicalResourceId</c>,
    /// see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/">CloudFormation
    /// User Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// A <c>ValidationError</c> is returned if you specify both <c>StackName</c> and <c>PhysicalResourceId</c>
    /// in the same request.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeStackResourcesRequest : AmazonCloudFormationRequest
    {
        private string _logicalResourceId;
        private string _physicalResourceId;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The logical name of the resource as specified in the template.
        /// </para>
        /// </summary>
        public string LogicalResourceId
        {
            get { return this._logicalResourceId; }
            set { this._logicalResourceId = value; }
        }

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this._logicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier that corresponds to a physical instance ID of a resource
        /// supported by CloudFormation.
        /// </para>
        ///  
        /// <para>
        /// For example, for an Amazon Elastic Compute Cloud (EC2) instance, <c>PhysicalResourceId</c>
        /// corresponds to the <c>InstanceId</c>. You can pass the EC2 <c>InstanceId</c> to <c>DescribeStackResources</c>
        /// to find which stack the instance belongs to and what other resources are part of the
        /// stack.
        /// </para>
        ///  
        /// <para>
        /// Required: Conditional. If you don't specify <c>PhysicalResourceId</c>, you must specify
        /// <c>StackName</c>.
        /// </para>
        /// </summary>
        public string PhysicalResourceId
        {
            get { return this._physicalResourceId; }
            set { this._physicalResourceId = value; }
        }

        // Check to see if PhysicalResourceId property is set
        internal bool IsSetPhysicalResourceId()
        {
            return this._physicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or the unique stack ID that is associated with the stack, which aren't always
        /// interchangeable:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Running stacks: You can specify either the stack's name or its unique stack ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted stacks: You must specify the unique stack ID.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Required: Conditional. If you don't specify <c>StackName</c>, you must specify <c>PhysicalResourceId</c>.
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

    }
}