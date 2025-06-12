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
    /// This is the response object from the ListServiceDeployments operation.
    /// </summary>
    public partial class ListServiceDeploymentsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ServiceDeploymentBrief> _serviceDeployments = AWSConfigs.InitializeCollections ? new List<ServiceDeploymentBrief>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>ListServiceDeployments</c> request.
        /// When the results of a <c>ListServiceDeployments</c> request exceed <c>maxResults</c>,
        /// this value can be used to retrieve the next page of results. This value is null when
        /// there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceDeployments. 
        /// <para>
        /// An overview of the service deployment, including the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The ARN of the service deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of the service being deployed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of the cluster that hosts the service in the service deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The time that the service deployment started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The time that the service deployment completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The service deployment status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Information about why the service deployment is in the current state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of the service revision that is being deployed.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceDeploymentBrief> ServiceDeployments
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