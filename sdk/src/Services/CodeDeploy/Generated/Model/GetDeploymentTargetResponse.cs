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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// This is the response object from the GetDeploymentTarget operation.
    /// </summary>
    public partial class GetDeploymentTargetResponse : AmazonWebServiceResponse
    {
        private DeploymentTarget _deploymentTarget;

        /// <summary>
        /// Gets and sets the property DeploymentTarget. 
        /// <para>
        ///  A deployment target that contains information about a deployment such as its status,
        /// lifecycle events, and when it was last updated. It also contains metadata about the
        /// deployment target. The deployment target metadata depends on the deployment target's
        /// type (<c>instanceTarget</c>, <c>lambdaTarget</c>, or <c>ecsTarget</c>). 
        /// </para>
        /// </summary>
        public DeploymentTarget DeploymentTarget
        {
            get { return this._deploymentTarget; }
            set { this._deploymentTarget = value; }
        }

        // Check to see if DeploymentTarget property is set
        internal bool IsSetDeploymentTarget()
        {
            return this._deploymentTarget != null;
        }

    }
}