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
    /// This is the response object from the DescribeServiceDeployments operation.
    /// </summary>
    public partial class DescribeServiceDeploymentsResponse : AmazonWebServiceResponse
    {
        private List<Failure> _failures = AWSConfigs.InitializeCollections ? new List<Failure>() : null;
        private List<ServiceDeployment> _serviceDeployments = AWSConfigs.InitializeCollections ? new List<ServiceDeployment>() : null;

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// Any failures associated with the call.
        /// </para>
        ///  
        /// <para>
        /// If you decsribe a deployment with a service revision created before October 25, 2024,
        /// the call fails. The failure includes the service revision ARN and the reason set to
        /// <c>MISSING</c>.
        /// </para>
        /// </summary>
        public List<Failure> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && (this._failures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceDeployments. 
        /// <para>
        /// The list of service deployments described.
        /// </para>
        /// </summary>
        public List<ServiceDeployment> ServiceDeployments
        {
            get { return this._serviceDeployments; }
            set { this._serviceDeployments = value; }
        }

        // Check to see if ServiceDeployments property is set
        internal bool IsSetServiceDeployments()
        {
            return this._serviceDeployments != null && (this._serviceDeployments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}