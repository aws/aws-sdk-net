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
    public partial class AmazonApplicationDiscoveryServiceClient : AmazonServiceClient, IAmazonApplicationDiscoveryService
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonApplicationDiscoveryServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationDiscoveryServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationDiscoveryServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationDiscoveryServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonApplicationDiscoveryServiceClient Configuration Object</param>
        public AmazonApplicationDiscoveryServiceClient(AmazonApplicationDiscoveryServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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
        
        #region  DescribeConfigurations

        internal DescribeConfigurationsResponse DescribeConfigurations(DescribeConfigurationsRequest request)
        {
            var marshaller = new DescribeConfigurationsRequestMarshaller();
            var unmarshaller = DescribeConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationsRequest,DescribeConfigurationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeConfigurationsResponse> DescribeConfigurationsAsync(DescribeConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConfigurationsRequestMarshaller();
            var unmarshaller = DescribeConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationsRequest,DescribeConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportConfigurations

        internal DescribeExportConfigurationsResponse DescribeExportConfigurations(DescribeExportConfigurationsRequest request)
        {
            var marshaller = new DescribeExportConfigurationsRequestMarshaller();
            var unmarshaller = DescribeExportConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeExportConfigurationsRequest,DescribeExportConfigurationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeExportConfigurationsResponse> DescribeExportConfigurationsAsync(DescribeExportConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeExportConfigurationsRequestMarshaller();
            var unmarshaller = DescribeExportConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportConfigurationsRequest,DescribeExportConfigurationsResponse>(request, marshaller, 
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