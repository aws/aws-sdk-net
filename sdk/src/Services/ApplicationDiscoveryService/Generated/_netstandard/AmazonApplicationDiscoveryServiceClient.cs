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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ApplicationDiscoveryService.Model;
using Amazon.ApplicationDiscoveryService.Model.Internal.MarshallTransformations;
using Amazon.ApplicationDiscoveryService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ApplicationDiscoveryService
{
    /// <summary>
    /// <para>Implementation for accessing ApplicationDiscoveryService</para>
    ///
    /// Amazon Web Services Application Discovery Service 
    /// <para>
    /// Amazon Web Services Application Discovery Service (Application Discovery Service)
    /// helps you plan application migration projects. It automatically identifies servers,
    /// virtual machines (VMs), and network dependencies in your on-premises data centers.
    /// For more information, see the <a href="http://aws.amazon.com/application-discovery/faqs/">Amazon
    /// Web Services Application Discovery Service FAQ</a>. 
    /// </para>
    ///  
    /// <para>
    /// Application Discovery Service offers three ways of performing discovery and collecting
    /// data about your on-premises servers:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Agentless discovery</b> using Amazon Web Services Application Discovery Service
    /// Agentless Collector (Agentless Collector), which doesn't require you to install an
    /// agent on each host.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Agentless Collector gathers server information regardless of the operating systems,
    /// which minimizes the time required for initial on-premises infrastructure assessment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Agentless Collector doesn't collect information about network dependencies, only agent-based
    /// discovery collects that information. 
    /// </para>
    ///  </li> </ul> </li> </ul> <ul> <li> 
    /// <para>
    ///  <b>Agent-based discovery</b> using the Amazon Web Services Application Discovery
    /// Agent (Application Discovery Agent) collects a richer set of data than agentless discovery,
    /// which you install on one or more hosts in your data center.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  The agent captures infrastructure and application information, including an inventory
    /// of running processes, system performance information, resource utilization, and network
    /// dependencies.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The information collected by agents is secured at rest and in transit to the Application
    /// Discovery Service database in the Amazon Web Services cloud. For more information,
    /// see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/discovery-agent.html">Amazon
    /// Web Services Application Discovery Agent</a>.
    /// </para>
    ///  </li> </ul> </li> </ul> <ul> <li> 
    /// <para>
    ///  <b>Amazon Web Services Partner Network (APN) solutions</b> integrate with Application
    /// Discovery Service, enabling you to import details of your on-premises environment
    /// directly into Amazon Web Services Migration Hub (Migration Hub) without using Agentless
    /// Collector or Application Discovery Agent.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Third-party application discovery tools can query Amazon Web Services Application
    /// Discovery Service, and they can write to the Application Discovery Service database
    /// using the public API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In this way, you can import data into Migration Hub and view it, so that you can associate
    /// applications with servers and track migrations.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    ///  <b>Working With This Guide</b> 
    /// </para>
    ///  
    /// <para>
    /// This API reference provides descriptions, syntax, and usage examples for each of the
    /// actions and data types for Application Discovery Service. The topic for each action
    /// shows the API request parameters and the response. Alternatively, you can use one
    /// of the Amazon Web Services SDKs to access an API that is tailored to the programming
    /// language or platform that you're using. For more information, see <a href="http://aws.amazon.com/tools/#SDKs">Amazon
    /// Web Services SDKs</a>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// Remember that you must set your Migration Hub home Region before you call any of these
    /// APIs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must make API calls for write actions (create, notify, associate, disassociate,
    /// import, or put) while in your home Region, or a <c>HomeRegionNotSetException</c> error
    /// is returned.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// API calls for read actions (list, describe, stop, and delete) are permitted outside
    /// of your home Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Although it is unlikely, the Migration Hub home Region could change. If you call APIs
    /// outside the home Region, an <c>InvalidInputException</c> is returned.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must call <c>GetHomeRegion</c> to obtain the latest Migration Hub home Region.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// This guide is intended for use with the <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/">Amazon
    /// Web Services Application Discovery Service User Guide</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// All data is handled according to the <a href="https://aws.amazon.com/privacy/">Amazon
    /// Web Services Privacy Policy</a>. You can operate Application Discovery Service offline
    /// to inspect collected data before it is shared with the service.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AmazonApplicationDiscoveryServiceClient : AmazonServiceClient, IAmazonApplicationDiscoveryService
    {
        private static IServiceMetadata serviceMetadata = new AmazonApplicationDiscoveryServiceMetadata();
        
        #region Constructors

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
            : base(new AmazonApplicationDiscoveryServiceConfig()) { }

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
            : base(new AmazonApplicationDiscoveryServiceConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
        private IApplicationDiscoveryServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IApplicationDiscoveryServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ApplicationDiscoveryServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApplicationDiscoveryServiceEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApplicationDiscoveryServiceAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateConfigurationItemsToApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConfigurationItemsToApplicationResponseUnmarshaller.Instance;

            return Invoke<AssociateConfigurationItemsToApplicationResponse>(request, options);
        }



        /// <summary>
        /// Associates one or more configuration items with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateConfigurationItemsToApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateConfigurationItemsToApplication service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/AssociateConfigurationItemsToApplication">REST API Reference for AssociateConfigurationItemsToApplication Operation</seealso>
        public virtual Task<AssociateConfigurationItemsToApplicationResponse> AssociateConfigurationItemsToApplicationAsync(AssociateConfigurationItemsToApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateConfigurationItemsToApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConfigurationItemsToApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateConfigurationItemsToApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteAgents

        internal virtual BatchDeleteAgentsResponse BatchDeleteAgents(BatchDeleteAgentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteAgentsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteAgentsResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more agents or collectors as specified by ID. Deleting an agent or
        /// collector does not delete the previously discovered data. To delete the data collected,
        /// use <c>StartBatchDeleteConfigurationTask</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteAgents service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/BatchDeleteAgents">REST API Reference for BatchDeleteAgents Operation</seealso>
        public virtual Task<BatchDeleteAgentsResponse> BatchDeleteAgentsAsync(BatchDeleteAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteAgentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteImportData

        internal virtual BatchDeleteImportDataResponse BatchDeleteImportData(BatchDeleteImportDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteImportDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteImportDataResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteImportDataResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more import tasks, each identified by their import ID. Each import
        /// task has a number of records that can identify servers or applications. 
        /// 
        ///  
        /// <para>
        /// Amazon Web Services Application Discovery Service has built-in matching logic that
        /// will identify when discovered servers match existing entries that you've previously
        /// discovered, the information for the already-existing discovered server is updated.
        /// When you delete an import task that contains records that were used to match, the
        /// information in those matched records that comes from the deleted records will also
        /// be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteImportData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteImportData service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/BatchDeleteImportData">REST API Reference for BatchDeleteImportData Operation</seealso>
        public virtual Task<BatchDeleteImportDataResponse> BatchDeleteImportDataAsync(BatchDeleteImportDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteImportDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteImportDataResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteImportDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates an application with the given name and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTags

        internal virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }



        /// <summary>
        /// Creates one or more tags for configuration items. Tags are metadata that help you
        /// categorize IT assets. This API accepts a list of multiple configuration items.
        /// 
        ///  <important> 
        /// <para>
        /// Do not store sensitive information (like personal data) in tags.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
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
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApplications

        internal virtual DeleteApplicationsResponse DeleteApplications(DeleteApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationsResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Deletes a list of applications and their associations with configuration items.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplications service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DeleteApplications">REST API Reference for DeleteApplications Operation</seealso>
        public virtual Task<DeleteApplicationsResponse> DeleteApplicationsAsync(DeleteApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }



        /// <summary>
        /// Deletes the association between configuration items and one or more tags. This API
        /// accepts a list of multiple configuration items.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
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
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAgents

        internal virtual DescribeAgentsResponse DescribeAgents(DescribeAgentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentsResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentsResponse>(request, options);
        }



        /// <summary>
        /// Lists agents or collectors as specified by ID or other filters. All agents/collectors
        /// associated with your user can be listed if you call <c>DescribeAgents</c> as is without
        /// passing any parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAgents service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeAgents">REST API Reference for DescribeAgents Operation</seealso>
        public virtual Task<DescribeAgentsResponse> DescribeAgentsAsync(DescribeAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBatchDeleteConfigurationTask

        internal virtual DescribeBatchDeleteConfigurationTaskResponse DescribeBatchDeleteConfigurationTask(DescribeBatchDeleteConfigurationTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBatchDeleteConfigurationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchDeleteConfigurationTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeBatchDeleteConfigurationTaskResponse>(request, options);
        }



        /// <summary>
        /// Takes a unique deletion task identifier as input and returns metadata about a configuration
        /// deletion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchDeleteConfigurationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBatchDeleteConfigurationTask service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeBatchDeleteConfigurationTask">REST API Reference for DescribeBatchDeleteConfigurationTask Operation</seealso>
        public virtual Task<DescribeBatchDeleteConfigurationTaskResponse> DescribeBatchDeleteConfigurationTaskAsync(DescribeBatchDeleteConfigurationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBatchDeleteConfigurationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchDeleteConfigurationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBatchDeleteConfigurationTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeConfigurations

        internal virtual DescribeConfigurationsResponse DescribeConfigurations(DescribeConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves attributes for a list of configuration item IDs.
        /// 
        ///  <note> 
        /// <para>
        /// All of the supplied IDs must be for the same asset type from one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// server
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// process
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// connection
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Output fields are specific to the asset type specified. For example, the output for
        /// a <i>server</i> configuration item includes a list of attributes about the server,
        /// such as host name, operating system, number of network cards, etc.
        /// </para>
        ///  
        /// <para>
        /// For a complete list of outputs for each asset type, see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/discovery-api-queries.html#DescribeConfigurations">Using
        /// the DescribeConfigurations Action</a> in the <i>Amazon Web Services Application Discovery
        /// Service User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeConfigurations">REST API Reference for DescribeConfigurations Operation</seealso>
        public virtual Task<DescribeConfigurationsResponse> DescribeConfigurationsAsync(DescribeConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeContinuousExports

        internal virtual DescribeContinuousExportsResponse DescribeContinuousExports(DescribeContinuousExportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContinuousExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContinuousExportsResponseUnmarshaller.Instance;

            return Invoke<DescribeContinuousExportsResponse>(request, options);
        }



        /// <summary>
        /// Lists exports as specified by ID. All continuous exports associated with your user
        /// can be listed if you call <c>DescribeContinuousExports</c> as is without passing any
        /// parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContinuousExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContinuousExports service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
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
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeContinuousExports">REST API Reference for DescribeContinuousExports Operation</seealso>
        public virtual Task<DescribeContinuousExportsResponse> DescribeContinuousExportsAsync(DescribeContinuousExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContinuousExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContinuousExportsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeContinuousExportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeExportConfigurations

        [Obsolete("Deprecated in favor of DescribeExportTasks.")]
        internal virtual DescribeExportConfigurationsResponse DescribeExportConfigurations(DescribeExportConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExportConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeExportConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// <c>DescribeExportConfigurations</c> is deprecated. Use <a href="https://docs.aws.amazon.com/application-discovery/latest/APIReference/API_DescribeExportTasks.html">DescribeExportTasks</a>,
        /// instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
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
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeExportConfigurations">REST API Reference for DescribeExportConfigurations Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeExportTasks.")]
        public virtual Task<DescribeExportConfigurationsResponse> DescribeExportConfigurationsAsync(DescribeExportConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExportConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeExportTasks

        internal virtual DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksResponse>(request, options);
        }



        /// <summary>
        /// Retrieve status of one or more export tasks. You can retrieve the status of up to
        /// 100 export tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeImportTasks

        internal virtual DescribeImportTasksResponse DescribeImportTasks(DescribeImportTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportTasksResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of import tasks for your account, including status information, times,
        /// IDs, the Amazon S3 Object URL for the import file, and more.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImportTasks service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeImportTasks">REST API Reference for DescribeImportTasks Operation</seealso>
        public virtual Task<DescribeImportTasksResponse> DescribeImportTasksAsync(DescribeImportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImportTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of configuration items that have tags as specified by the key-value
        /// pairs, name and value, passed to the optional parameter <c>filters</c>.
        /// 
        ///  
        /// <para>
        /// There are three valid tag filter names:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// tagKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// tagValue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// configurationId
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Also, all configuration items associated with your user that have tags can be listed
        /// if you call <c>DescribeTags</c> as is without passing any parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
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
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateConfigurationItemsFromApplication

        internal virtual DisassociateConfigurationItemsFromApplicationResponse DisassociateConfigurationItemsFromApplication(DisassociateConfigurationItemsFromApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateConfigurationItemsFromApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConfigurationItemsFromApplicationResponseUnmarshaller.Instance;

            return Invoke<DisassociateConfigurationItemsFromApplicationResponse>(request, options);
        }



        /// <summary>
        /// Disassociates one or more configuration items from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConfigurationItemsFromApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateConfigurationItemsFromApplication service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DisassociateConfigurationItemsFromApplication">REST API Reference for DisassociateConfigurationItemsFromApplication Operation</seealso>
        public virtual Task<DisassociateConfigurationItemsFromApplicationResponse> DisassociateConfigurationItemsFromApplicationAsync(DisassociateConfigurationItemsFromApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateConfigurationItemsFromApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConfigurationItemsFromApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateConfigurationItemsFromApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportConfigurations

        [Obsolete("Deprecated in favor of StartExportTask.")]
        internal virtual ExportConfigurationsResponse ExportConfigurations(ExportConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ExportConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Deprecated. Use <c>StartExportTask</c> instead.
        /// 
        ///  
        /// <para>
        /// Exports all discovered configuration data to an Amazon S3 bucket or an application
        /// that enables you to view and evaluate the data. Data includes tags and tag associations,
        /// processes, connections, servers, and system performance. This API returns an export
        /// ID that you can query using the <i>DescribeExportConfigurations</i> API. The system
        /// imposes a limit of two configuration exports in six hours.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
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
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ExportConfigurations">REST API Reference for ExportConfigurations Operation</seealso>
        [Obsolete("Deprecated in favor of StartExportTask.")]
        public virtual Task<ExportConfigurationsResponse> ExportConfigurationsAsync(ExportConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDiscoverySummary

        internal virtual GetDiscoverySummaryResponse GetDiscoverySummary(GetDiscoverySummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDiscoverySummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoverySummaryResponseUnmarshaller.Instance;

            return Invoke<GetDiscoverySummaryResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a short summary of discovered assets.
        /// 
        ///  
        /// <para>
        /// This API operation takes no request parameters and is called as is at the command
        /// prompt as shown in the example.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoverySummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDiscoverySummary service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/GetDiscoverySummary">REST API Reference for GetDiscoverySummary Operation</seealso>
        public virtual Task<GetDiscoverySummaryResponse> GetDiscoverySummaryAsync(GetDiscoverySummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDiscoverySummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoverySummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetDiscoverySummaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfigurations

        internal virtual ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of configuration items as specified by the value passed to the required
        /// parameter <c>configurationType</c>. Optional filtering may be applied to refine search
        /// results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
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
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListServerNeighbors

        internal virtual ListServerNeighborsResponse ListServerNeighbors(ListServerNeighborsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServerNeighborsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServerNeighborsResponseUnmarshaller.Instance;

            return Invoke<ListServerNeighborsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of servers that are one network hop away from a specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerNeighbors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServerNeighbors service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ListServerNeighbors">REST API Reference for ListServerNeighbors Operation</seealso>
        public virtual Task<ListServerNeighborsResponse> ListServerNeighborsAsync(ListServerNeighborsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServerNeighborsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServerNeighborsResponseUnmarshaller.Instance;

            return InvokeAsync<ListServerNeighborsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartBatchDeleteConfigurationTask

        internal virtual StartBatchDeleteConfigurationTaskResponse StartBatchDeleteConfigurationTask(StartBatchDeleteConfigurationTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartBatchDeleteConfigurationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBatchDeleteConfigurationTaskResponseUnmarshaller.Instance;

            return Invoke<StartBatchDeleteConfigurationTaskResponse>(request, options);
        }



        /// <summary>
        /// Takes a list of configurationId as input and starts an asynchronous deletion task
        /// to remove the configurationItems. Returns a unique deletion task identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBatchDeleteConfigurationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBatchDeleteConfigurationTask service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.LimitExceededException">
        /// The limit of 200 configuration IDs per request has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.OperationNotPermittedException">
        /// This operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartBatchDeleteConfigurationTask">REST API Reference for StartBatchDeleteConfigurationTask Operation</seealso>
        public virtual Task<StartBatchDeleteConfigurationTaskResponse> StartBatchDeleteConfigurationTaskAsync(StartBatchDeleteConfigurationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartBatchDeleteConfigurationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBatchDeleteConfigurationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartBatchDeleteConfigurationTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartContinuousExport

        internal virtual StartContinuousExportResponse StartContinuousExport(StartContinuousExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartContinuousExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContinuousExportResponseUnmarshaller.Instance;

            return Invoke<StartContinuousExportResponse>(request, options);
        }



        /// <summary>
        /// Start the continuous flow of agent's discovered data into Amazon Athena.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContinuousExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartContinuousExport service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ConflictErrorException">
        /// Conflict error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
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
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceInUseException">
        /// This issue occurs when the same <c>clientRequestToken</c> is used with the <c>StartImportTask</c>
        /// action, but with different parameters. For example, you use the same request token
        /// but have two different import URLs, you can encounter this issue. If the import tasks
        /// are meant to be different, use a different <c>clientRequestToken</c>, and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartContinuousExport">REST API Reference for StartContinuousExport Operation</seealso>
        public virtual Task<StartContinuousExportResponse> StartContinuousExportAsync(StartContinuousExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartContinuousExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContinuousExportResponseUnmarshaller.Instance;

            return InvokeAsync<StartContinuousExportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDataCollectionByAgentIds

        internal virtual StartDataCollectionByAgentIdsResponse StartDataCollectionByAgentIds(StartDataCollectionByAgentIdsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataCollectionByAgentIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return Invoke<StartDataCollectionByAgentIdsResponse>(request, options);
        }



        /// <summary>
        /// Instructs the specified agents to start collecting data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollectionByAgentIds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDataCollectionByAgentIds service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartDataCollectionByAgentIds">REST API Reference for StartDataCollectionByAgentIds Operation</seealso>
        public virtual Task<StartDataCollectionByAgentIdsResponse> StartDataCollectionByAgentIdsAsync(StartDataCollectionByAgentIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataCollectionByAgentIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return InvokeAsync<StartDataCollectionByAgentIdsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartExportTask

        internal virtual StartExportTaskResponse StartExportTask(StartExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return Invoke<StartExportTaskResponse>(request, options);
        }



        /// <summary>
        /// Begins the export of a discovered data report to an Amazon S3 bucket managed by Amazon
        /// Web Services.
        /// 
        ///  <note> 
        /// <para>
        /// Exports might provide an estimate of fees and savings based on certain information
        /// that you provide. Fee estimates do not include any taxes that might apply. Your actual
        /// fees and savings depend on a variety of factors, including your actual usage of Amazon
        /// Web Services services, which might vary from the estimates provided in this report.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you do not specify <c>preferences</c> or <c>agentIds</c> in the filter, a summary
        /// of all servers, applications, tags, and performance is generated. This data is an
        /// aggregation of all server data collected through on-premises tooling, file import,
        /// application grouping and applying tags.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>agentIds</c> in a filter, the task exports up to 72 hours of detailed
        /// data collected by the identified Application Discovery Agent, including network, process,
        /// and performance details. A time range for exported agent data may be set by using
        /// <c>startTime</c> and <c>endTime</c>. Export of detailed agent data is limited to five
        /// concurrently running exports. Export of detailed agent data is limited to two exports
        /// per day.
        /// </para>
        ///  
        /// <para>
        /// If you enable <c>ec2RecommendationsPreferences</c> in <c>preferences</c> , an Amazon
        /// EC2 instance matching the characteristics of each server in Application Discovery
        /// Service is generated. Changing the attributes of the <c>ec2RecommendationsPreferences</c>
        /// changes the criteria of the recommendation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExportTask service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
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
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        public virtual Task<StartExportTaskResponse> StartExportTaskAsync(StartExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartExportTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartImportTask

        internal virtual StartImportTaskResponse StartImportTask(StartImportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportTaskResponseUnmarshaller.Instance;

            return Invoke<StartImportTaskResponse>(request, options);
        }



        /// <summary>
        /// Starts an import task, which allows you to import details of your on-premises environment
        /// directly into Amazon Web Services Migration Hub without having to use the Amazon Web
        /// Services Application Discovery Service (Application Discovery Service) tools such
        /// as the Amazon Web Services Application Discovery Service Agentless Collector or Application
        /// Discovery Agent. This gives you the option to perform migration assessment and planning
        /// directly from your imported data, including the ability to group your devices as applications
        /// and track their migration status.
        /// 
        ///  
        /// <para>
        /// To start an import request, do this:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Download the specially formatted comma separated value (CSV) import template, which
        /// you can find here: <a href="https://s3.us-west-2.amazonaws.com/templates-7cffcf56-bd96-4b1c-b45b-a5b42f282e46/import_template.csv">https://s3.us-west-2.amazonaws.com/templates-7cffcf56-bd96-4b1c-b45b-a5b42f282e46/import_template.csv</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fill out the template with your server and application data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Upload your import file to an Amazon S3 bucket, and make a note of it's Object URL.
        /// Your import file must be in the CSV format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the console or the <c>StartImportTask</c> command with the Amazon Web Services
        /// CLI or one of the Amazon Web Services SDKs to import the records from your file.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/discovery-import.html">Migration
        /// Hub Import</a> in the <i>Amazon Web Services Application Discovery Service User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// There are limits to the number of import tasks you can create (and delete) in an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/ads_service_limits.html">Amazon
        /// Web Services Application Discovery Service Limits</a> in the <i>Amazon Web Services
        /// Application Discovery Service User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImportTask service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceInUseException">
        /// This issue occurs when the same <c>clientRequestToken</c> is used with the <c>StartImportTask</c>
        /// action, but with different parameters. For example, you use the same request token
        /// but have two different import URLs, you can encounter this issue. If the import tasks
        /// are meant to be different, use a different <c>clientRequestToken</c>, and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartImportTask">REST API Reference for StartImportTask Operation</seealso>
        public virtual Task<StartImportTaskResponse> StartImportTaskAsync(StartImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartImportTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopContinuousExport

        internal virtual StopContinuousExportResponse StopContinuousExport(StopContinuousExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopContinuousExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopContinuousExportResponseUnmarshaller.Instance;

            return Invoke<StopContinuousExportResponse>(request, options);
        }



        /// <summary>
        /// Stop the continuous flow of agent's discovered data into Amazon Athena.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContinuousExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopContinuousExport service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
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
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceInUseException">
        /// This issue occurs when the same <c>clientRequestToken</c> is used with the <c>StartImportTask</c>
        /// action, but with different parameters. For example, you use the same request token
        /// but have two different import URLs, you can encounter this issue. If the import tasks
        /// are meant to be different, use a different <c>clientRequestToken</c>, and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StopContinuousExport">REST API Reference for StopContinuousExport Operation</seealso>
        public virtual Task<StopContinuousExportResponse> StopContinuousExportAsync(StopContinuousExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopContinuousExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopContinuousExportResponseUnmarshaller.Instance;

            return InvokeAsync<StopContinuousExportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopDataCollectionByAgentIds

        internal virtual StopDataCollectionByAgentIdsResponse StopDataCollectionByAgentIds(StopDataCollectionByAgentIdsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDataCollectionByAgentIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return Invoke<StopDataCollectionByAgentIdsResponse>(request, options);
        }



        /// <summary>
        /// Instructs the specified agents to stop collecting data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollectionByAgentIds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDataCollectionByAgentIds service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StopDataCollectionByAgentIds">REST API Reference for StopDataCollectionByAgentIds Operation</seealso>
        public virtual Task<StopDataCollectionByAgentIdsResponse> StopDataCollectionByAgentIdsAsync(StopDataCollectionByAgentIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDataCollectionByAgentIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return InvokeAsync<StopDataCollectionByAgentIdsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Updates metadata about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The user does not have permission to perform the action. Check the IAM policy associated
        /// with this user.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.HomeRegionNotSetException">
        /// The home Region is not set. Set the home Region to continue.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}