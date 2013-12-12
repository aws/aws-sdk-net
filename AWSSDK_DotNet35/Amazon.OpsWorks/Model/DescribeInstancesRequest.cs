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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstances operation.
    /// <para>Requests a description of a set of instances.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
    /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
    /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class DescribeInstancesRequest : AmazonOpsWorksRequest
    {
        private string stackId;
        private string layerId;
        private List<string> instanceIds = new List<string>();


        /// <summary>
        /// A stack ID. If you use this parameter, <c>DescribeInstances</c> returns descriptions of the instances associated with the specified stack.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// A layer ID. If you use this parameter, <c>DescribeInstances</c> returns descriptions of the instances associated with the specified layer.
        ///  
        /// </summary>
        public string LayerId
        {
            get { return this.layerId; }
            set { this.layerId = value; }
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this.layerId != null;
        }

        /// <summary>
        /// An array of instance IDs to be described. If you use this parameter, <c>DescribeInstances</c> returns a description of the specified
        /// instances. Otherwise, it returns a description of every instance.
        ///  
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this.instanceIds; }
            set { this.instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this.instanceIds.Count > 0;
        }

    }
}
    
