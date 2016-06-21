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
    /// Container for the parameters to the DeregisterEcsCluster operation.
    /// Deregisters a specified Amazon ECS cluster from a stack. For more information, see
    /// <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-ecscluster.html#workinglayers-ecscluster-delete">
    /// Resource Management</a>.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack or an attached policy that explicitly grants permissions. For
    /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html</a>.
    /// </para>
    /// </summary>
    public partial class DeregisterEcsClusterRequest : AmazonOpsWorksRequest
    {
        private string _ecsClusterArn;

        /// <summary>
        /// Gets and sets the property EcsClusterArn. 
        /// <para>
        /// The cluster's ARN.
        /// </para>
        /// </summary>
        public string EcsClusterArn
        {
            get { return this._ecsClusterArn; }
            set { this._ecsClusterArn = value; }
        }

        // Check to see if EcsClusterArn property is set
        internal bool IsSetEcsClusterArn()
        {
            return this._ecsClusterArn != null;
        }

    }
}