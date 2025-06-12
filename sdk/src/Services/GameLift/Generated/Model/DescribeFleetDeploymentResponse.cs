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
    /// This is the response object from the DescribeFleetDeployment operation.
    /// </summary>
    public partial class DescribeFleetDeploymentResponse : AmazonWebServiceResponse
    {
        private FleetDeployment _fleetDeployment;
        private Dictionary<string, LocationalDeployment> _locationalDeployments = AWSConfigs.InitializeCollections ? new Dictionary<string, LocationalDeployment>() : null;

        /// <summary>
        /// Gets and sets the property FleetDeployment. 
        /// <para>
        /// The requested deployment information.
        /// </para>
        /// </summary>
        public FleetDeployment FleetDeployment
        {
            get { return this._fleetDeployment; }
            set { this._fleetDeployment = value; }
        }

        // Check to see if FleetDeployment property is set
        internal bool IsSetFleetDeployment()
        {
            return this._fleetDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property LocationalDeployments. 
        /// <para>
        /// If the deployment is for a multi-location fleet, the requests returns the deployment
        /// status in each fleet location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, LocationalDeployment> LocationalDeployments
        {
            get { return this._locationalDeployments; }
            set { this._locationalDeployments = value; }
        }

        // Check to see if LocationalDeployments property is set
        internal bool IsSetLocationalDeployments()
        {
            return this._locationalDeployments != null && (this._locationalDeployments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}