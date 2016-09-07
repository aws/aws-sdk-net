/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ApplicationDiscoveryService.Model;

namespace Amazon.ApplicationDiscoveryService
{
    /// <summary>
    /// Interface for accessing ApplicationDiscoveryService
    ///
    /// The AWS Application Discovery Service helps Systems Integrators quickly and reliably
    /// plan application migration projects by automatically identifying applications running
    /// in on-premises data centers, their associated dependencies, and their performance
    /// profile.
    /// 
    ///  
    /// <para>
    ///  Planning data center migrations can involve thousands of workloads that are often
    /// deeply interdependent. Application discovery and dependency mapping are important
    /// early first steps in the migration process, but difficult to perform at scale due
    /// to the lack of automated tools.
    /// </para>
    ///  
    /// <para>
    /// The AWS Application Discovery Service automatically collects configuration and usage
    /// data from servers to develop a list of applications, how they perform, and how they
    /// are interdependent. This information is securely retained in an AWS Application Discovery
    /// Service database which you can export as a CSV file into your preferred visualization
    /// tool or cloud migration solution to help reduce the complexity and time in planning
    /// your cloud migration.
    /// </para>
    ///  
    /// <para>
    /// The Application Discovery Service is currently available for preview. Only customers
    /// who are engaged with <a href="https://aws.amazon.com/professional-services/">AWS Professional
    /// Services</a> or a certified AWS partner can use the service. To see the list of certified
    /// partners and request access to the Application Discovery Service, complete the following
    /// <a href="http://aws.amazon.com/application-discovery/preview/">preview form</a>.
    /// </para>
    ///  
    /// <para>
    /// This API reference provides descriptions, syntax, and usage examples for each of the
    /// actions and data types for the Discovery Service. The topic for each action shows
    /// the API request parameters and the response. Alternatively, you can use one of the
    /// AWS SDKs to access an API that is tailored to the programming language or platform
    /// that you're using. For more information, see <a href="http://aws.amazon.com/tools/#SDKs">AWS
    /// SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// This guide is intended for use with the <a href="http://docs.aws.amazon.com/application-discovery/latest/userguide/what-is-appdiscovery.html">
    /// <i>AWS Discovery Service User Guide</i> </a>.
    /// </para>
    ///  
    /// <para>
    /// The following are short descriptions of each API action, organized by function.
    /// </para>
    ///  
    /// <para>
    ///  <b>Managing AWS Agents Using the Application Discovery Service</b> 
    /// </para>
    ///  
    /// <para>
    /// An AWS agent is software that you install on on-premises servers and virtual machines
    /// that are targeted for discovery and migration. Agents run on Linux and Windows Server
    /// and collect server configuration and activity information about your applications
    /// and infrastructure. Specifically, agents collect the following information and send
    /// it to the Application Discovery Service using Secure Sockets Layer (SSL) encryption:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// User information (user name, home directory)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Group information (name)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List of installed packages
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List of kernel modules
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All create and stop process events
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DNS queries
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// NIC information
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// TCP/UDP process listening ports
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// TCPV4/V6 connections
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Operating system information
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// System performance
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Process performance
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The Application Discovery Service API includes the following actions to manage AWS
    /// agents:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>StartDataCollectionByAgentIds</i>: Instructs the specified agents to start collecting
    /// data. The Application Discovery Service takes several minutes to receive and process
    /// data after you initiate data collection.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>StopDataCollectionByAgentIds</i>: Instructs the specified agents to stop collecting
    /// data.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>DescribeAgents</i>: Lists AWS agents by ID or lists all agents associated with
    /// your user account if you did not specify an agent ID. The output includes agent IDs,
    /// IP addresses, media access control (MAC) addresses, agent health, host name where
    /// the agent resides, and the version number of each agent.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Querying Configuration Items</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>configuration item</i> is an IT asset that was discovered in your data center
    /// by an AWS agent. When you use the Application Discovery Service, you can specify filters
    /// and query specific configuration items. The service supports Server, Process, and
    /// Connection configuration items. This means you can specify a value for the following
    /// keys and query your IT assets:
    /// </para>
    ///  <p class="title"> <b>Server</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// server.HostName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// server.osName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// server.osVersion
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// server.configurationId
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// server.agentId
    /// </para>
    ///  </li> </ul> <p class="title"> <b>Process</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// process.name
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// process.CommandLine
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// process.configurationId
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// server.hostName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// server.osName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// server.osVersion
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// server.configurationId
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// server.agentId
    /// </para>
    ///  </li> </ul> <p class="title"> <b>Connection</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// connection.sourceIp
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// connection.sourcePort
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// connection.destinationIp
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// connection.destinationPort
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// sourceProcess.configurationId
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// sourceProcess.commandLine
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// sourceProcess.name
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// destinationProcessId.configurationId
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// destinationProcess.commandLine
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// destinationProcess.name
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// sourceServer.configurationId
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// sourceServer.hostName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// sourceServer.osName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// sourceServer.osVersion
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// destinationServer.configurationId
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// destinationServer.hostName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// destinationServer.osName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// destinationServer.osVersion
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The Application Discovery Service includes the following actions for querying configuration
    /// items. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>DescribeConfigurations</i>: Retrieves a list of attributes for a specific configuration
    /// ID. For example, the output for a <i>server</i> configuration item includes a list
    /// of attributes about the server, including host name, operating system, number of network
    /// cards, etc.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>ListConfigurations</i>: Retrieves a list of configuration items according to the
    /// criteria you specify in a filter. The filter criteria identify relationship requirements.
    /// For example, you can specify filter criteria of process.name with values of <i>nginx</i>
    /// and <i>apache</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging Discovered Configuration Items</b> 
    /// </para>
    ///  
    /// <para>
    /// You can tag discovered configuration items. Tags are metadata that help you categorize
    /// IT assets in your data center. Tags use a <i>key</i>-<i>value</i> format. For example,
    /// <code>{"key": "serverType", "value": "webServer"}</code>. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>CreateTags</i>: Creates one or more tags for a configuration items.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>DescribeTags</i>: Retrieves a list of configuration items that are tagged with
    /// a specific tag. <i>Or</i>, retrieves a list of all tags assigned to a specific configuration
    /// item.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>DeleteTags</i>: Deletes the association between a configuration item and one or
    /// more tags.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Exporting Data</b> 
    /// </para>
    ///  
    /// <para>
    /// You can export data as a CSV file to an Amazon S3 bucket or into your preferred visualization
    /// tool or cloud migration solution to help reduce the complexity and time in planning
    /// your cloud migration.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>ExportConfigurations</i>: Exports all discovered configuration data to an Amazon
    /// S3 bucket. Data includes tags and tag associations, processes, connections, servers,
    /// and system performance. This API returns an export ID which you can query using the
    /// GetExportStatus API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>DescribeExportConfigurations</i>: Gets the status of the data export. When the
    /// export is complete, the service returns an Amazon S3 URL where you can download CSV
    /// files that include the data.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonApplicationDiscoveryService : IAmazonService, IDisposable
    {
                
        #region  CreateTags


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTags


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAgents


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAgentsResponse> DescribeAgentsAsync(DescribeAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConfigurationsResponse> DescribeConfigurationsAsync(DescribeConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExportConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeExportConfigurationsResponse> DescribeExportConfigurationsAsync(DescribeExportConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTags


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the ExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ExportConfigurationsResponse> ExportConfigurationsAsync(ExportConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDataCollectionByAgentIds


        /// <summary>
        /// Initiates the asynchronous execution of the StartDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollectionByAgentIds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartDataCollectionByAgentIdsResponse> StartDataCollectionByAgentIdsAsync(StartDataCollectionByAgentIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopDataCollectionByAgentIds


        /// <summary>
        /// Initiates the asynchronous execution of the StopDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollectionByAgentIds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopDataCollectionByAgentIdsResponse> StopDataCollectionByAgentIdsAsync(StopDataCollectionByAgentIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}