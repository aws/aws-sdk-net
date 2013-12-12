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
    /// Container for the parameters to the DescribeServiceErrors operation.
    /// <para>Describes AWS OpsWorks service errors.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show,
    /// Deploy, or Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user
    /// permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a>
    /// .</para>
    /// </summary>
    public partial class DescribeServiceErrorsRequest : AmazonOpsWorksRequest
    {
        private string stackId;
        private string instanceId;
        private List<string> serviceErrorIds = new List<string>();


        /// <summary>
        /// The stack ID. If you use this parameter, <c>DescribeServiceErrors</c> returns descriptions of the errors associated with the specified
        /// stack.
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
        /// The instance ID. If you use this parameter, <c>DescribeServiceErrors</c> returns descriptions of the errors associated with the specified
        /// instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// An array of service error IDs. If you use this parameter, <c>DescribeServiceErrors</c> returns descriptions of the specified errors.
        /// Otherwise, it returns a description of every error.
        ///  
        /// </summary>
        public List<string> ServiceErrorIds
        {
            get { return this.serviceErrorIds; }
            set { this.serviceErrorIds = value; }
        }

        // Check to see if ServiceErrorIds property is set
        internal bool IsSetServiceErrorIds()
        {
            return this.serviceErrorIds.Count > 0;
        }

    }
}
    
