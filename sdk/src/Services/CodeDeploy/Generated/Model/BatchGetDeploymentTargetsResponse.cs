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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// This is the response object from the BatchGetDeploymentTargets operation.
    /// </summary>
    public partial class BatchGetDeploymentTargetsResponse : AmazonWebServiceResponse
    {
        private List<DeploymentTarget> _deploymentTargets = new List<DeploymentTarget>();

        /// <summary>
        /// Gets and sets the property DeploymentTargets. 
        /// <para>
        ///  A list of target objects for a deployment. Each target object contains details about
        /// the target, such as its status and lifecycle events. The type of the target objects
        /// depends on the deployment' compute platform. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>EC2/On-premises</b>: Each target object is an EC2 or on-premises instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AWS Lambda</b>: The target object is a specific version of an AWS Lambda function.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon ECS</b>: The target object is an Amazon ECS service. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CloudFormation</b>: The target object is an AWS CloudFormation blue/green deployment.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<DeploymentTarget> DeploymentTargets
        {
            get { return this._deploymentTargets; }
            set { this._deploymentTargets = value; }
        }

        // Check to see if DeploymentTargets property is set
        internal bool IsSetDeploymentTargets()
        {
            return this._deploymentTargets != null && this._deploymentTargets.Count > 0; 
        }

    }
}