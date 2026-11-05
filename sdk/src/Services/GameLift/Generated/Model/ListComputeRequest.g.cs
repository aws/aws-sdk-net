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
    /// Container for the parameters to the ListCompute operation. <b>This API works with
    /// the following fleet types:</b> EC2, Anywhere, Container <para> Retrieves information
    /// on the compute resources in an Amazon GameLift Servers fleet. Use the pagination parameters
    /// to retrieve results in a set of sequential pages. </para> <para> <b>Request options</b>
    /// </para> <ul> <li> <para> Retrieve a list of all computes in a fleet. Specify a fleet
    /// ID. </para> </li> <li> <para> Retrieve a list of all computes in a specific fleet
    /// location. Specify a fleet ID and location. </para> </li> </ul> <para> <b>Results</b>
    /// </para> <para> If successful, this operation returns information on a set of computes.
    /// Depending on the type of fleet, the result includes the following information: </para>
    /// <ul> <li> <para> For a managed EC2 fleet (compute type <c>EC2</c>), this operation
    /// returns information about the EC2 instance. Compute names are EC2 instance IDs. </para>
    /// </li> <li> <para> For an Anywhere fleet (compute type <c>ANYWHERE</c>), this operation
    /// returns compute names and details from when the compute was registered with <c>RegisterCompute</c>.
    /// This includes <c>GameLiftServiceSdkEndpoint</c> or <c>GameLiftAgentEndpoint</c>. </para>
    /// </li> </ul>
    /// </summary>
    public partial class ListComputeRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeStatus. 
        /// <para>
        /// The status of computes in a managed container fleet, based on the success of the latest
        /// update deployment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> -- The compute is deployed with the correct container definitions.
        /// It is ready to process game servers and host game sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPAIRED</c> -- An update deployment to the compute failed, and the compute is
        /// deployed with incorrect container definitions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ListComputeInputStatus ComputeStatus { get; set; }

        /// <summary>
        /// Checks to see if the ComputeStatus property is set.
        /// </summary>
        internal bool IsSetComputeStatus() => this.ComputeStatus != null;

        /// <summary>
        /// Gets and sets the property ContainerGroupDefinitionName. 
        /// <para>
        /// For computes in a managed container fleet, the name of the deployed container group
        /// definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ContainerGroupDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerGroupDefinitionName property is set.
        /// </summary>
        internal bool IsSetContainerGroupDefinitionName() => this.ContainerGroupDefinitionName != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to retrieve compute resources for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
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
        /// Gets and sets the property Location. 
        /// <para>
        /// The name of a location to retrieve compute resources for. For an Amazon GameLift Servers
        /// Anywhere fleet, use a custom location. For a managed fleet, provide a Amazon Web Services
        /// Region or Local Zone code (for example: <c>us-west-2</c> or <c>us-west-2-lax-1</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

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
