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
    /// Container for the parameters to the DescribeDeployments operation.
    /// Requests a description of a specified set of deployments.
    /// 
    ///  <note> 
    /// <para>
    /// This call accepts only one resource-identifying parameter.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack, or an attached policy that explicitly grants
    /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DescribeDeploymentsRequest : AmazonOpsWorksRequest
    {
        private string _appId;
        private List<string> _deploymentIds = new List<string>();
        private string _stackId;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID. If you include this parameter, the command returns a description of the
        /// commands associated with the specified app.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentIds. 
        /// <para>
        /// An array of deployment IDs to be described. If you include this parameter, the command
        /// returns a description of the specified deployments. Otherwise, it returns a description
        /// of every deployment.
        /// </para>
        /// </summary>
        public List<string> DeploymentIds
        {
            get { return this._deploymentIds; }
            set { this._deploymentIds = value; }
        }

        // Check to see if DeploymentIds property is set
        internal bool IsSetDeploymentIds()
        {
            return this._deploymentIds != null && this._deploymentIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID. If you include this parameter, the command returns a description of
        /// the commands associated with the specified stack.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}