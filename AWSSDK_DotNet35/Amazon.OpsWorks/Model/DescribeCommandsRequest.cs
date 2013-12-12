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
    /// Container for the parameters to the DescribeCommands operation.
    /// <para>Describes the results of specified commands.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
    /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
    /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class DescribeCommandsRequest : AmazonOpsWorksRequest
    {
        private string deploymentId;
        private string instanceId;
        private List<string> commandIds = new List<string>();


        /// <summary>
        /// The deployment ID. If you include this parameter, <c>DescribeCommands</c> returns a description of the commands associated with the
        /// specified deployment.
        ///  
        /// </summary>
        public string DeploymentId
        {
            get { return this.deploymentId; }
            set { this.deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this.deploymentId != null;
        }

        /// <summary>
        /// The instance ID. If you include this parameter, <c>DescribeCommands</c> returns a description of the commands associated with the specified
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
        /// An array of command IDs. If you include this parameter, <c>DescribeCommands</c> returns a description of the specified commands. Otherwise,
        /// it returns a description of every command.
        ///  
        /// </summary>
        public List<string> CommandIds
        {
            get { return this.commandIds; }
            set { this.commandIds = value; }
        }

        // Check to see if CommandIds property is set
        internal bool IsSetCommandIds()
        {
            return this.commandIds.Count > 0;
        }

    }
}
    
