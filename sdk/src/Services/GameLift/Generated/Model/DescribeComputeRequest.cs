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
    /// Container for the parameters to the DescribeCompute operation.
    /// Retrieves properties for a compute resource in an Amazon GameLift fleet. To get a
    /// list of all computes in a fleet, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListCompute.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListCompute.html</a>.
    /// 
    /// 
    ///  
    /// <para>
    /// To request information on a specific compute, provide the fleet ID and compute name.
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns details for the requested compute resource.
    /// Depending on the fleet's compute type, the result includes the following information:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For managed EC2 fleets, this operation returns information about the EC2 instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For Anywhere fleets, this operation returns information about the registered compute.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeComputeRequest : AmazonGameLiftRequest
    {
        private string _computeName;
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// The unique identifier of the compute resource to retrieve properties for. For an Anywhere
        /// fleet compute, use the registered compute name. For an EC2 fleet instance, use the
        /// instance ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string ComputeName
        {
            get { return this._computeName; }
            set { this._computeName = value; }
        }

        // Check to see if ComputeName property is set
        internal bool IsSetComputeName()
        {
            return this._computeName != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that the compute belongs to. You can use either
        /// the fleet ID or ARN value.
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