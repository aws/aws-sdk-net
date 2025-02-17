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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The deployment controller to use for the service.
    /// </summary>
    public partial class DeploymentController
    {
        private DeploymentControllerType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The deployment controller type to use.
        /// </para>
        ///  
        /// <para>
        /// There are three deployment controller types available:
        /// </para>
        ///  <dl> <dt>ECS</dt> <dd> 
        /// <para>
        /// The rolling update (<c>ECS</c>) deployment type involves replacing the current running
        /// version of the container with the latest version. The number of containers Amazon
        /// ECS adds or removes from the service during a rolling update is controlled by adjusting
        /// the minimum and maximum number of healthy tasks allowed during a service deployment,
        /// as specified in the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DeploymentConfiguration.html">DeploymentConfiguration</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about rolling deployments, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html">Deploy
        /// Amazon ECS services by replacing tasks</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        ///  </dd> <dt>CODE_DEPLOY</dt> <dd> 
        /// <para>
        /// The blue/green (<c>CODE_DEPLOY</c>) deployment type uses the blue/green deployment
        /// model powered by CodeDeploy, which allows you to verify a new deployment of a service
        /// before sending production traffic to it.
        /// </para>
        ///  
        /// <para>
        /// For more information about blue/green deployments, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-bluegreen.html">Validate
        /// the state of an Amazon ECS service before deployment </a> in the <i>Amazon Elastic
        /// Container Service Developer Guide</i>.
        /// </para>
        ///  </dd> <dt>EXTERNAL</dt> <dd> 
        /// <para>
        /// The external (<c>EXTERNAL</c>) deployment type enables you to use any third-party
        /// deployment controller for full control over the deployment process for an Amazon ECS
        /// service.
        /// </para>
        ///  
        /// <para>
        /// For more information about external deployments, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-external.html">Deploy
        /// Amazon ECS services using a third-party controller </a> in the <i>Amazon Elastic Container
        /// Service Developer Guide</i>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentControllerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}