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
    /// Container for the parameters to the BatchGetDeploymentTargets operation.
    /// Returns an array of targets associated with a deployment. This method works with
    /// all compute types and should be used instead of the deprecated <code>BatchGetDeploymentInstances</code>.
    /// 
    /// 
    ///  
    /// <para>
    ///  The type of targets returned depends on the deployment's compute platform: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>EC2/On-premises</b> - Information about EC2 instance targets. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS Lambda</b> - Information about Lambda functions targets. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Amazon ECS</b> - Information about ECS service targets. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class BatchGetDeploymentTargetsRequest : AmazonCodeDeployRequest
    {
        private string _deploymentId;
        private List<string> _targetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment. 
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
        /// Gets and sets the property TargetIds. 
        /// <para>
        ///  The unique IDs of the deployment targets. The compute platform of the deployment
        /// determines the type of the targets and their formats. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For deployments that use the EC2/On-premises compute platform, the target IDs are
        /// EC2 or on-premises instances IDs and their target type is <code>instanceTarget</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For deployments that use the AWS Lambda compute platform, the target IDs are the
        /// names of Lambda functions and their target type is <code>instanceTarget</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For deployments that use the Amazon ECS compute platform, the target IDs are pairs
        /// of Amazon ECS clusters and services specified using the format <code>&lt;clustername&gt;:&lt;servicename&gt;</code>.
        /// Their target type is <code>ecsTarget</code>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> TargetIds
        {
            get { return this._targetIds; }
            set { this._targetIds = value; }
        }

        // Check to see if TargetIds property is set
        internal bool IsSetTargetIds()
        {
            return this._targetIds != null && this._targetIds.Count > 0; 
        }

    }
}