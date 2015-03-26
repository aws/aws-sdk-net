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
    /// Container for the parameters to the DescribeStackResources operation.
    /// Returns AWS resource descriptions for running and deleted stacks. If <code>StackName</code>
    /// is specified, all the associated resources that are part of the stack are returned.
    /// If <code>PhysicalResourceId</code> is specified, the associated resources of the stack
    /// that the resource belongs to are returned.
    /// 
    ///  <note>Only the first 100 resources will be returned. If your stack has more resources
    /// than this, you should use <code>ListStackResources</code> instead.</note> 
    /// <para>
    /// For deleted stacks, <code>DescribeStackResources</code> returns resource information
    /// for up to 90 days after the stack has been deleted.
    /// </para>
    ///  
    /// <para>
    /// You must specify either <code>StackName</code> or <code>PhysicalResourceId</code>,
    /// but not both. In addition, you can specify <code>LogicalResourceId</code> to filter
    /// the returned result. For more information about resources, the <code>LogicalResourceId</code>
    /// and <code>PhysicalResourceId</code>, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS
    /// CloudFormation User Guide</a>.
    /// </para>
    ///  <note>A <code>ValidationError</code> is returned if you specify both <code>StackName</code>
    /// and <code>PhysicalResourceId</code> in the same request.</note>
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
        ///  
        /// <para>
        /// Default: There is no default value.
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
        /// supported by AWS CloudFormation.
        /// </para>
        ///  
        /// <para>
        /// For example, for an Amazon Elastic Compute Cloud (EC2) instance, <code>PhysicalResourceId</code>
        /// corresponds to the <code>InstanceId</code>. You can pass the EC2 <code>InstanceId</code>
        /// to <code>DescribeStackResources</code> to find which stack the instance belongs to
        /// and what other resources are part of the stack.
        /// </para>
        ///  
        /// <para>
        /// Required: Conditional. If you do not specify <code>PhysicalResourceId</code>, you
        /// must specify <code>StackName</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: There is no default value.
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
        /// The name or the unique identifier associated with the stack, which are not always
        /// interchangeable:
        /// </para>
        ///  <ul> <li>Running stacks: You can specify either the stack's name or its unique stack
        /// ID.</li> <li>Deleted stacks: You must specify the unique stack ID.</li> </ul> 
        /// <para>
        /// Default: There is no default value.
        /// </para>
        ///  
        /// <para>
        /// Required: Conditional. If you do not specify <code>StackName</code>, you must specify
        /// <code>PhysicalResourceId</code>.
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