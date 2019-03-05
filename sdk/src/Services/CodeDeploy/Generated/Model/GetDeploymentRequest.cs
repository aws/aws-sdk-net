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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the GetDeployment operation.
    /// Gets information about a deployment.
    /// 
    ///  <note> 
    /// <para>
    ///  The <code>content</code> property of the <code>appSpecContent</code> object in the
    /// returned revision is always null. Use <code>GetApplicationRevision</code> and the
    /// <code>sha256</code> property of the returned <code>appSpecContent</code> object to
    /// get the content of the deployment’s AppSpec file. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDeploymentRequest : AmazonCodeDeployRequest
    {
        private string _deploymentId;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment associated with the IAM user or AWS account. 
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

    }
}