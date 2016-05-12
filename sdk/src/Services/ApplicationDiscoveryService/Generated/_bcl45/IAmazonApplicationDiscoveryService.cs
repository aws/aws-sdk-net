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

using Amazon.ApplicationDiscoveryService.Model;

namespace Amazon.ApplicationDiscoveryService
{
    /// <summary>
    /// Interface for accessing ApplicationDiscoveryService
    ///
    /// This is the AWS Discovery Service API Reference. The AWS Discovery Service streamlines
    /// the process of migrating to Amazon Web Services by helping you identify assets in
    /// your data center, including servers, virtual machines, applications, application dependencies,
    /// and network infrastructure. You can use this information to find the workloads that
    /// make up an application, analyze dependencies, and build migration strategies. The
    /// service also collects performance data about your workloads which you can use to assess
    /// migration outcomes.
    /// 
    ///  
    /// <para>
    /// This API reference provides descriptions, syntax, and usage examples for each of the
    /// actions and data types for the Discovery Service. The topic for each action shows
    /// the API request parameters and the response. Alternatively, you can use one of the
    /// AWS SDKs to access an API that's tailored to the programming language or platform
    /// that you're using. For more information, see <a href="http://aws.amazon.com/tools/#SDKs">AWS
    /// SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// This guide is intended for use with the <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/remote-commands-prereq.html">AWS
    /// Discovery Service user guide</a>.
    /// </para>
    ///  
    /// <para>
    /// The following are short descriptions of each API action, organized by function.
    /// </para>
    ///  
    /// <para>
    ///  <b>Managing AWS Agents</b> 
    /// </para>
    ///  
    /// <para>
    /// The AWS agent is an Amazon application that you install on servers and virtual machines
    /// in your data center or on Amazon EC2 instances. The agent captures server configuration
    /// and activity information (including hardware profile, network, file system, and process
    /// activity) and sends this data to the AWS Application Discovery Service. The Discovery
    /// Service processes this data and maps the application dependencies for your workloads.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>StartDataCollectionByAgentIds</i>: Instructs the specified agents to start collecting
    /// data. Agents can reside on host servers or virtual machines in your data center or
    /// on AWS EC2 instances.
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
    /// IP addresses, MAC addresses, agent health, host name where the agent resides, and
    /// the version number of each agent.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Querying Configuration Items</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>configuration item</i> is an IT asset that was discovered in your data center
    /// by an AWS agent. With the Discovery Service, you can specify filters and query specific
    /// configuration items. For example, using this API, you could create a filter to query
    /// for a process configuration item named apache and an operating system configuration
    /// item named Ubuntu.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>GetConfigurationAttributes</i>: Retrieves a list of attributes for a specific
    /// configuration ID. For example, the output for a <i>server</i> configuration item includes
    /// a list of attributes about the server, including host name, operating system, number
    /// of network cards, etc.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>ListConfigurations</i>: Retrieves a list of configurations items according to
    /// the criteria you specify in a filter. The filter criteria identify relationship requirements.
    /// For example, the following filter specifies criteria of process.name and values of
    /// <i>nginx</i> and <i>apache</i>.
    /// </para>
    ///  
    /// <para>
    ///  <code>ConfigurationType = Process Filters = [WebServerCriteria] WebServerCriteria
    /// = { ‘key’ : process.name, ‘values’ : [ ‘nginx’, ‘apache’ ], ‘condition’ : ‘contains’
    /// } </code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging Discovered Configuration Items</b> 
    /// </para>
    ///  
    /// <para>
    /// You can tag discovered configuration items. Tags are metadata that help you categorize
    /// IT assets in your data center. Tags use a <i>key</i>,<i>value</i> format. For example,
    /// <code>{"key": "serverType", "value": "webServer"}</code>. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>CreateTags</i>: Creates one or more tags for a configuration item. Tags are metadata
    /// that help you categorize IT assets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>DescribeTags</i>: Retrieve a list of configuration items that are tagged with
    /// a specific tag. Or retrieve a list all tags assigned to a specific configuration item.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>DeleteTags</i>: Deletes one or more tags associated with a configuration item.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Exporting Data</b> 
    /// </para>
    ///  
    /// <para>
    /// You can export discovered data to an Amazon S3 bucket in the form of CSV files.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>ExportConfigurations</i>: Exports all discovered configuration data to an Amazon
    /// S3 bucket. Data includes processes, connections, servers, and system performance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>GetExportStatus</i>: Gets the status of the data export. When the export is complete,
    /// the service returns an Amazon S3 URL where you can download CSV files that include
    /// the data.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonApplicationDiscoveryService : IDisposable
    {

        
        #region  CreateTags


        /// <summary>
        /// Creates one or more tags for a configuration item. Tags are metadata that help you
        /// categorize IT assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        CreateTagsResponse CreateTags(CreateTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes one or more tags associated with a configuration item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAgents


        /// <summary>
        /// Lists AWS agents by ID or lists all agents associated with your user account if you
        /// did not specify an agent ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgents service method.</param>
        /// 
        /// <returns>The response from the DescribeAgents service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        DescribeAgentsResponse DescribeAgents(DescribeAgentsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAgentsResponse> DescribeAgentsAsync(DescribeAgentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Retrieve a list of configuration items that are tagged with a specific tag. Or retrieve
        /// a list all tags assigned to a specific configuration item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportConfigurations


        /// <summary>
        /// Exports the selected configurations to an Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportConfigurations service method.</param>
        /// 
        /// <returns>The response from the ExportConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.OperationNotPermittedException">
        /// This operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        ExportConfigurationsResponse ExportConfigurations(ExportConfigurationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ExportConfigurationsResponse> ExportConfigurationsAsync(ExportConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConfigurationAttributes


        /// <summary>
        /// Retrieve a list of attributes for a specific configuration ID. For example, the output
        /// for a <i>server</i> configuration item includes a list of attributes about the server,
        /// including host name, operating system, number of network cards, etc.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationAttributes service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        GetConfigurationAttributesResponse GetConfigurationAttributes(GetConfigurationAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetConfigurationAttributesResponse> GetConfigurationAttributesAsync(GetConfigurationAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetExportStatus


        /// <summary>
        /// Retrieves the status of a given export process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportStatus service method.</param>
        /// 
        /// <returns>The response from the GetExportStatus service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        GetExportStatusResponse GetExportStatus(GetExportStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetExportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetExportStatusResponse> GetExportStatusAsync(GetExportStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConfigurations


        /// <summary>
        /// Retrieve a list of configurations items according to the criteria you specify in a
        /// filter. The filter criteria identify relationship requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveConfiguration


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveConfiguration service method.</param>
        /// 
        /// <returns>The response from the RemoveConfiguration service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        RemoveConfigurationResponse RemoveConfiguration(RemoveConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveConfigurationResponse> RemoveConfigurationAsync(RemoveConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartDataCollectionByAgentIds


        /// <summary>
        /// Instructs the specified agents to start collecting data. Agents can reside on host
        /// servers or virtual machines in your data center or on AWS EC2 instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollectionByAgentIds service method.</param>
        /// 
        /// <returns>The response from the StartDataCollectionByAgentIds service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        StartDataCollectionByAgentIdsResponse StartDataCollectionByAgentIds(StartDataCollectionByAgentIdsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollectionByAgentIds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartDataCollectionByAgentIdsResponse> StartDataCollectionByAgentIdsAsync(StartDataCollectionByAgentIdsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopDataCollectionByAgentIds


        /// <summary>
        /// Instructs the specified agents to stop collecting data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollectionByAgentIds service method.</param>
        /// 
        /// <returns>The response from the StopDataCollectionByAgentIds service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        StopDataCollectionByAgentIdsResponse StopDataCollectionByAgentIds(StopDataCollectionByAgentIdsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollectionByAgentIds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopDataCollectionByAgentIdsResponse> StopDataCollectionByAgentIdsAsync(StopDataCollectionByAgentIdsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}