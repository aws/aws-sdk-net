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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ApplicationDiscoveryService.Model;
using Amazon.ApplicationDiscoveryService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ApplicationDiscoveryService
{
    /// <summary>
    /// Implementation for accessing ApplicationDiscoveryService
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
    public partial class AmazonApplicationDiscoveryServiceClient : AmazonServiceClient, IAmazonApplicationDiscoveryService
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApplicationDiscoveryServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonApplicationDiscoveryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationDiscoveryServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApplicationDiscoveryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Credentials and an
        /// AmazonApplicationDiscoveryServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApplicationDiscoveryServiceClient Configuration Object</param>
        public AmazonApplicationDiscoveryServiceClient(AWSCredentials credentials, AmazonApplicationDiscoveryServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationDiscoveryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationDiscoveryServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationDiscoveryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApplicationDiscoveryServiceClient Configuration Object</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApplicationDiscoveryServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationDiscoveryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationDiscoveryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationDiscoveryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApplicationDiscoveryServiceClient Configuration Object</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApplicationDiscoveryServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreateTags

        internal CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsRequest,CreateTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsRequest,CreateTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAgents

        internal DescribeAgentsResponse DescribeAgents(DescribeAgentsRequest request)
        {
            var marshaller = new DescribeAgentsRequestMarshaller();
            var unmarshaller = DescribeAgentsResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentsRequest,DescribeAgentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAgentsResponse> DescribeAgentsAsync(DescribeAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAgentsRequestMarshaller();
            var unmarshaller = DescribeAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgentsRequest,DescribeAgentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ExportConfigurations

        internal ExportConfigurationsResponse ExportConfigurations(ExportConfigurationsRequest request)
        {
            var marshaller = new ExportConfigurationsRequestMarshaller();
            var unmarshaller = ExportConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ExportConfigurationsRequest,ExportConfigurationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ExportConfigurationsResponse> ExportConfigurationsAsync(ExportConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ExportConfigurationsRequestMarshaller();
            var unmarshaller = ExportConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportConfigurationsRequest,ExportConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConfigurationAttributes

        internal GetConfigurationAttributesResponse GetConfigurationAttributes(GetConfigurationAttributesRequest request)
        {
            var marshaller = new GetConfigurationAttributesRequestMarshaller();
            var unmarshaller = GetConfigurationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationAttributesRequest,GetConfigurationAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetConfigurationAttributesResponse> GetConfigurationAttributesAsync(GetConfigurationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetConfigurationAttributesRequestMarshaller();
            var unmarshaller = GetConfigurationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationAttributesRequest,GetConfigurationAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetExportStatus

        internal GetExportStatusResponse GetExportStatus(GetExportStatusRequest request)
        {
            var marshaller = new GetExportStatusRequestMarshaller();
            var unmarshaller = GetExportStatusResponseUnmarshaller.Instance;

            return Invoke<GetExportStatusRequest,GetExportStatusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetExportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetExportStatusResponse> GetExportStatusAsync(GetExportStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetExportStatusRequestMarshaller();
            var unmarshaller = GetExportStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportStatusRequest,GetExportStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurations

        internal ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request)
        {
            var marshaller = new ListConfigurationsRequestMarshaller();
            var unmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationsRequest,ListConfigurationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListConfigurationsRequestMarshaller();
            var unmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationsRequest,ListConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveConfiguration

        internal RemoveConfigurationResponse RemoveConfiguration(RemoveConfigurationRequest request)
        {
            var marshaller = new RemoveConfigurationRequestMarshaller();
            var unmarshaller = RemoveConfigurationResponseUnmarshaller.Instance;

            return Invoke<RemoveConfigurationRequest,RemoveConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveConfigurationResponse> RemoveConfigurationAsync(RemoveConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveConfigurationRequestMarshaller();
            var unmarshaller = RemoveConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveConfigurationRequest,RemoveConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartDataCollectionByAgentIds

        internal StartDataCollectionByAgentIdsResponse StartDataCollectionByAgentIds(StartDataCollectionByAgentIdsRequest request)
        {
            var marshaller = new StartDataCollectionByAgentIdsRequestMarshaller();
            var unmarshaller = StartDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return Invoke<StartDataCollectionByAgentIdsRequest,StartDataCollectionByAgentIdsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollectionByAgentIds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartDataCollectionByAgentIdsResponse> StartDataCollectionByAgentIdsAsync(StartDataCollectionByAgentIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartDataCollectionByAgentIdsRequestMarshaller();
            var unmarshaller = StartDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return InvokeAsync<StartDataCollectionByAgentIdsRequest,StartDataCollectionByAgentIdsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopDataCollectionByAgentIds

        internal StopDataCollectionByAgentIdsResponse StopDataCollectionByAgentIds(StopDataCollectionByAgentIdsRequest request)
        {
            var marshaller = new StopDataCollectionByAgentIdsRequestMarshaller();
            var unmarshaller = StopDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return Invoke<StopDataCollectionByAgentIdsRequest,StopDataCollectionByAgentIdsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollectionByAgentIds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StopDataCollectionByAgentIdsResponse> StopDataCollectionByAgentIdsAsync(StopDataCollectionByAgentIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopDataCollectionByAgentIdsRequestMarshaller();
            var unmarshaller = StopDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return InvokeAsync<StopDataCollectionByAgentIdsRequest,StopDataCollectionByAgentIdsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}