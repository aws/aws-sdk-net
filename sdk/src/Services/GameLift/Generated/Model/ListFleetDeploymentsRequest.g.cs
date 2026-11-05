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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListFleetDeployments operation. <b>This API works
    /// with the following fleet types:</b> Container <para> Retrieves a collection of container
    /// fleet deployments in an Amazon Web Services Region. Use the pagination parameters
    /// to retrieve results as a set of sequential pages. </para> <para> <b>Request options</b>
    /// </para> <ul> <li> <para> Get a list of all deployments. Call this operation without
    /// specifying a fleet ID. </para> </li> <li> <para> Get a list of all deployments for
    /// a fleet. Specify the container fleet ID or ARN value. </para> </li> </ul> <para> <b>Results</b>
    /// </para> <para> If successful, this operation returns a list of deployments that match
    /// the request parameters. A NextToken value is also returned if there are more result
    /// pages to retrieve. </para> <note> <para> Deployments are returned starting with the
    /// latest. </para> </note>
    /// </summary>
    public partial class ListFleetDeploymentsRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the container fleet. You can use either the fleet ID or ARN
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
