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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
    /// Describes the results of specified commands.
    /// 
    ///  <note> 
    /// <para>
    /// You must specify at least one of the parameters.
    /// </para>
    ///  </note> 
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack, or an attached policy that explicitly grants
    /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DescribeCommandsRequest : AmazonOpsWorksRequest
    {
        private List<string> _commandIds = new List<string>();
        private string _deploymentId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property CommandIds. 
        /// <para>
        /// An array of command IDs. If you include this parameter, <code>DescribeCommands</code>
        /// returns a description of the specified commands. Otherwise, it returns a description
        /// of every command.
        /// </para>
        /// </summary>
        public List<string> CommandIds
        {
            get { return this._commandIds; }
            set { this._commandIds = value; }
        }

        // Check to see if CommandIds property is set
        internal bool IsSetCommandIds()
        {
            return this._commandIds != null && this._commandIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The deployment ID. If you include this parameter, <code>DescribeCommands</code> returns
        /// a description of the commands associated with the specified deployment.
        /// </para>
        /// </summary>
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID. If you include this parameter, <code>DescribeCommands</code> returns
        /// a description of the commands associated with the specified instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}