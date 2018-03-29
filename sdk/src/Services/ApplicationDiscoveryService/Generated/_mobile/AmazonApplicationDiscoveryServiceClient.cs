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
    /// AWS Application Discovery Service 
    /// <para>
    /// AWS Application Discovery Service helps you plan application migration projects by
    /// automatically identifying servers, virtual machines (VMs), software, and software
    /// dependencies running in your on-premises data centers. Application Discovery Service
    /// also collects application performance data, which can help you assess the outcome
    /// of your migration. The data collected by Application Discovery Service is securely
    /// retained in an AWS-hosted and managed database in the cloud. You can export the data
    /// as a CSV or XML file into your preferred visualization tool or cloud-migration solution
    /// to plan your migration. For more information, see <a href="http://aws.amazon.com/application-discovery/faqs/">AWS
    /// Application Discovery Service FAQ</a>.
    /// </para>
    ///  
    /// <para>
    /// Application Discovery Service offers two modes of operation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Agentless discovery</b> mode is recommended for environments that use VMware vCenter
    /// Server. This mode doesn't require you to install an agent on each host. Agentless
    /// discovery gathers server information regardless of the operating systems, which minimizes
    /// the time required for initial on-premises infrastructure assessment. Agentless discovery
    /// doesn't collect information about software and software dependencies. It also doesn't
    /// work in non-VMware environments. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Agent-based discovery</b> mode collects a richer set of data than agentless discovery
    /// by using the AWS Application Discovery Agent, which you install on one or more hosts
    /// in your data center. The agent captures infrastructure and application information,
    /// including an inventory of installed software applications, system and process performance,
    /// resource utilization, and network dependencies between workloads. The information
    /// collected by agents is secured at rest and in transit to the Application Discovery
    /// Service database in the cloud. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// We recommend that you use agent-based discovery for non-VMware environments and to
    /// collect information about software and software dependencies. You can also run agent-based
    /// and agentless discovery simultaneously. Use agentless discovery to quickly complete
    /// the initial infrastructure assessment and then install agents on select hosts.
    /// </para>
    ///  
    /// <para>
    /// Application Discovery Service integrates with application discovery solutions from
    /// AWS Partner Network (APN) partners. Third-party application discovery tools can query
    /// Application Discovery Service and write to the Application Discovery Service database
    /// using a public API. You can then import the data into either a visualization tool
    /// or cloud-migration solution.
    /// </para>
    ///  <important> 
    /// <para>
    /// Application Discovery Service doesn't gather sensitive information. All data is handled
    /// according to the <a href="http://aws.amazon.com/privacy/">AWS Privacy Policy</a>.
    /// You can operate Application Discovery Service offline to inspect collected data before
    /// it is shared with the service.
    /// </para>
    ///  </important> 
    /// <para>
    /// Your AWS account must be granted access to Application Discovery Service, a process
    /// called <i>whitelisting</i>. This is true for AWS partners and customers alike. To
    /// request access, <a href="http://aws.amazon.com/application-discovery/">sign up for
    /// Application Discovery Service</a>. 
    /// </para>
    ///  
    /// <para>
    /// This API reference provides descriptions, syntax, and usage examples for each of the
    /// actions and data types for Application Discovery Service. The topic for each action
    /// shows the API request parameters and the response. Alternatively, you can use one
    /// of the AWS SDKs to access an API that is tailored to the programming language or platform
    /// that you're using. For more information, see <a href="http://aws.amazon.com/tools/#SDKs">AWS
    /// SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// This guide is intended for use with the <a href="http://docs.aws.amazon.com/application-discovery/latest/userguide/">
    /// <i>AWS Application Discovery Service User Guide</i> </a>.
    /// </para>
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

        
        #region  AssociateConfigurationItemsToApplication

        internal virtual AssociateConfigurationItemsToApplicationResponse AssociateConfigurationItemsToApplication(AssociateConfigurationItemsToApplicationRequest request)
        {
            var marshaller = AssociateConfigurationItemsToApplicationRequestMarshaller.Instance;
            var unmarshaller = AssociateConfigurationItemsToApplicationResponseUnmarshaller.Instance;

            return Invoke<AssociateConfigurationItemsToApplicationRequest,AssociateConfigurationItemsToApplicationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateConfigurationItemsToApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateConfigurationItemsToApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/AssociateConfigurationItemsToApplication">REST API Reference for AssociateConfigurationItemsToApplication Operation</seealso>
        public virtual Task<AssociateConfigurationItemsToApplicationResponse> AssociateConfigurationItemsToApplicationAsync(AssociateConfigurationItemsToApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateConfigurationItemsToApplicationRequestMarshaller.Instance;
            var unmarshaller = AssociateConfigurationItemsToApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateConfigurationItemsToApplicationRequest,AssociateConfigurationItemsToApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var marshaller = CreateApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTags

        internal virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = CreateTagsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateTagsRequestMarshaller.Instance;
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsRequest,CreateTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplications

        internal virtual DeleteApplicationsResponse DeleteApplications(DeleteApplicationsRequest request)
        {
            var marshaller = DeleteApplicationsRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationsResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationsRequest,DeleteApplicationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DeleteApplications">REST API Reference for DeleteApplications Operation</seealso>
        public virtual Task<DeleteApplicationsResponse> DeleteApplicationsAsync(DeleteApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteApplicationsRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationsRequest,DeleteApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = DeleteTagsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteTagsRequestMarshaller.Instance;
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAgents

        internal virtual DescribeAgentsResponse DescribeAgents(DescribeAgentsRequest request)
        {
            var marshaller = DescribeAgentsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeAgents">REST API Reference for DescribeAgents Operation</seealso>
        public virtual Task<DescribeAgentsResponse> DescribeAgentsAsync(DescribeAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAgentsRequestMarshaller.Instance;
            var unmarshaller = DescribeAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgentsRequest,DescribeAgentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurations

        internal virtual DescribeConfigurationsResponse DescribeConfigurations(DescribeConfigurationsRequest request)
        {
            var marshaller = DescribeConfigurationsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeConfigurations">REST API Reference for DescribeConfigurations Operation</seealso>
        public virtual Task<DescribeConfigurationsResponse> DescribeConfigurationsAsync(DescribeConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeConfigurationsRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationsRequest,DescribeConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportConfigurations

        [Obsolete("Deprecated in favor of DescribeExportTasks.")]
        internal virtual DescribeExportConfigurationsResponse DescribeExportConfigurations(DescribeExportConfigurationsRequest request)
        {
            var marshaller = DescribeExportConfigurationsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeExportConfigurations">REST API Reference for DescribeExportConfigurations Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeExportTasks.")]
        public virtual Task<DescribeExportConfigurationsResponse> DescribeExportConfigurationsAsync(DescribeExportConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeExportConfigurationsRequestMarshaller.Instance;
            var unmarshaller = DescribeExportConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportConfigurationsRequest,DescribeExportConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportTasks

        internal virtual DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var marshaller = DescribeExportTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeExportTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = DescribeTagsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTagsRequestMarshaller.Instance;
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateConfigurationItemsFromApplication

        internal virtual DisassociateConfigurationItemsFromApplicationResponse DisassociateConfigurationItemsFromApplication(DisassociateConfigurationItemsFromApplicationRequest request)
        {
            var marshaller = DisassociateConfigurationItemsFromApplicationRequestMarshaller.Instance;
            var unmarshaller = DisassociateConfigurationItemsFromApplicationResponseUnmarshaller.Instance;

            return Invoke<DisassociateConfigurationItemsFromApplicationRequest,DisassociateConfigurationItemsFromApplicationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConfigurationItemsFromApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConfigurationItemsFromApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DisassociateConfigurationItemsFromApplication">REST API Reference for DisassociateConfigurationItemsFromApplication Operation</seealso>
        public virtual Task<DisassociateConfigurationItemsFromApplicationResponse> DisassociateConfigurationItemsFromApplicationAsync(DisassociateConfigurationItemsFromApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateConfigurationItemsFromApplicationRequestMarshaller.Instance;
            var unmarshaller = DisassociateConfigurationItemsFromApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateConfigurationItemsFromApplicationRequest,DisassociateConfigurationItemsFromApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ExportConfigurations

        [Obsolete("Deprecated in favor of StartExportTask.")]
        internal virtual ExportConfigurationsResponse ExportConfigurations(ExportConfigurationsRequest request)
        {
            var marshaller = ExportConfigurationsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ExportConfigurations">REST API Reference for ExportConfigurations Operation</seealso>
        [Obsolete("Deprecated in favor of StartExportTask.")]
        public virtual Task<ExportConfigurationsResponse> ExportConfigurationsAsync(ExportConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ExportConfigurationsRequestMarshaller.Instance;
            var unmarshaller = ExportConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportConfigurationsRequest,ExportConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDiscoverySummary

        internal virtual GetDiscoverySummaryResponse GetDiscoverySummary(GetDiscoverySummaryRequest request)
        {
            var marshaller = GetDiscoverySummaryRequestMarshaller.Instance;
            var unmarshaller = GetDiscoverySummaryResponseUnmarshaller.Instance;

            return Invoke<GetDiscoverySummaryRequest,GetDiscoverySummaryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDiscoverySummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoverySummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/GetDiscoverySummary">REST API Reference for GetDiscoverySummary Operation</seealso>
        public virtual Task<GetDiscoverySummaryResponse> GetDiscoverySummaryAsync(GetDiscoverySummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDiscoverySummaryRequestMarshaller.Instance;
            var unmarshaller = GetDiscoverySummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetDiscoverySummaryRequest,GetDiscoverySummaryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurations

        internal virtual ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request)
        {
            var marshaller = ListConfigurationsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListConfigurationsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationsRequest,ListConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListServerNeighbors

        internal virtual ListServerNeighborsResponse ListServerNeighbors(ListServerNeighborsRequest request)
        {
            var marshaller = ListServerNeighborsRequestMarshaller.Instance;
            var unmarshaller = ListServerNeighborsResponseUnmarshaller.Instance;

            return Invoke<ListServerNeighborsRequest,ListServerNeighborsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListServerNeighbors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerNeighbors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ListServerNeighbors">REST API Reference for ListServerNeighbors Operation</seealso>
        public virtual Task<ListServerNeighborsResponse> ListServerNeighborsAsync(ListServerNeighborsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListServerNeighborsRequestMarshaller.Instance;
            var unmarshaller = ListServerNeighborsResponseUnmarshaller.Instance;

            return InvokeAsync<ListServerNeighborsRequest,ListServerNeighborsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartDataCollectionByAgentIds

        internal virtual StartDataCollectionByAgentIdsResponse StartDataCollectionByAgentIds(StartDataCollectionByAgentIdsRequest request)
        {
            var marshaller = StartDataCollectionByAgentIdsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartDataCollectionByAgentIds">REST API Reference for StartDataCollectionByAgentIds Operation</seealso>
        public virtual Task<StartDataCollectionByAgentIdsResponse> StartDataCollectionByAgentIdsAsync(StartDataCollectionByAgentIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartDataCollectionByAgentIdsRequestMarshaller.Instance;
            var unmarshaller = StartDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return InvokeAsync<StartDataCollectionByAgentIdsRequest,StartDataCollectionByAgentIdsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartExportTask

        internal virtual StartExportTaskResponse StartExportTask(StartExportTaskRequest request)
        {
            var marshaller = StartExportTaskRequestMarshaller.Instance;
            var unmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return Invoke<StartExportTaskRequest,StartExportTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        public virtual Task<StartExportTaskResponse> StartExportTaskAsync(StartExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartExportTaskRequestMarshaller.Instance;
            var unmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartExportTaskRequest,StartExportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopDataCollectionByAgentIds

        internal virtual StopDataCollectionByAgentIdsResponse StopDataCollectionByAgentIds(StopDataCollectionByAgentIdsRequest request)
        {
            var marshaller = StopDataCollectionByAgentIdsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StopDataCollectionByAgentIds">REST API Reference for StopDataCollectionByAgentIds Operation</seealso>
        public virtual Task<StopDataCollectionByAgentIdsResponse> StopDataCollectionByAgentIdsAsync(StopDataCollectionByAgentIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopDataCollectionByAgentIdsRequestMarshaller.Instance;
            var unmarshaller = StopDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return InvokeAsync<StopDataCollectionByAgentIdsRequest,StopDataCollectionByAgentIdsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var marshaller = UpdateApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}