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
    /// Container for the parameters to the StopServiceDeployment operation.
    /// Stops an ongoing service deployment.
    /// 
    ///  
    /// <para>
    /// The following stop types are avaiable:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// ROLLBACK - This option rolls back the service deployment to the previous service revision.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can use this option even if you didn't configure the service deployment for the
    /// rollback option. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/stop-service-deployment.html">Stopping
    /// Amazon ECS service deployments</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class StopServiceDeploymentRequest : AmazonECSRequest
    {
        private string _serviceDeploymentArn;
        private StopServiceDeploymentStopType _stopType;

        /// <summary>
        /// Gets and sets the property ServiceDeploymentArn. 
        /// <para>
        /// The ARN of the service deployment that you want to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceDeploymentArn
        {
            get { return this._serviceDeploymentArn; }
            set { this._serviceDeploymentArn = value; }
        }

        // Check to see if ServiceDeploymentArn property is set
        internal bool IsSetServiceDeploymentArn()
        {
            return this._serviceDeploymentArn != null;
        }

        /// <summary>
        /// Gets and sets the property StopType. 
        /// <para>
        /// How you want Amazon ECS to stop the service. 
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>ROLLBACK</c>.
        /// </para>
        /// </summary>
        public StopServiceDeploymentStopType StopType
        {
            get { return this._stopType; }
            set { this._stopType = value; }
        }

        // Check to see if StopType property is set
        internal bool IsSetStopType()
        {
            return this._stopType != null;
        }

    }
}