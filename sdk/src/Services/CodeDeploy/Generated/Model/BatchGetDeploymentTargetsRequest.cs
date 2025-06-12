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
    /// Container for the parameters to the BatchGetDeploymentTargets operation.
    /// Returns an array of one or more targets associated with a deployment. This method
    /// works with all compute types and should be used instead of the deprecated <c>BatchGetDeploymentInstances</c>.
    /// The maximum number of targets that can be returned is 25.
    /// 
    ///  
    /// <para>
    ///  The type of targets returned depends on the deployment's compute platform or deployment
    /// method: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>EC2/On-premises</b>: Information about Amazon EC2 instance targets. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Lambda</b>: Information about Lambda functions targets. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Amazon ECS</b>: Information about Amazon ECS service targets. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>CloudFormation</b>: Information about targets of blue/green deployments initiated
    /// by a CloudFormation stack update.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class BatchGetDeploymentTargetsRequest : AmazonCodeDeployRequest
    {
        private string _deploymentId;
        private List<string> _targetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// determines the type of the targets and their formats. The maximum number of deployment
        /// target IDs you can specify is 25.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For deployments that use the EC2/On-premises compute platform, the target IDs are
        /// Amazon EC2 or on-premises instances IDs, and their target type is <c>instanceTarget</c>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For deployments that use the Lambda compute platform, the target IDs are the names
        /// of Lambda functions, and their target type is <c>instanceTarget</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For deployments that use the Amazon ECS compute platform, the target IDs are pairs
        /// of Amazon ECS clusters and services specified using the format <c>&lt;clustername&gt;:&lt;servicename&gt;</c>.
        /// Their target type is <c>ecsTarget</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For deployments that are deployed with CloudFormation, the target IDs are CloudFormation
        /// stack IDs. Their target type is <c>cloudFormationTarget</c>. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TargetIds
        {
            get { return this._targetIds; }
            set { this._targetIds = value; }
        }

        // Check to see if TargetIds property is set
        internal bool IsSetTargetIds()
        {
            return this._targetIds != null && (this._targetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}