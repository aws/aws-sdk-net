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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFleetDeployment operation.
    /// Retrieves information about a managed container fleet deployment. 
    /// 
    ///  
    /// <para>
    ///  <b>Request options</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Get information about the latest deployment for a specific fleet. Provide the fleet
    /// ID or ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Get information about a specific deployment. Provide the fleet ID or ARN and the
    /// deployment ID.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Results</b> 
    /// </para>
    ///  
    /// <para>
    /// If successful, a <c>FleetDeployment</c> object is returned.
    /// </para>
    /// </summary>
    public partial class DescribeFleetDeploymentRequest : AmazonGameLiftRequest
    {
        private string _deploymentId;
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// A unique identifier for the deployment to return information for. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the container fleet. You can use either the fleet ID or ARN
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

    }
}