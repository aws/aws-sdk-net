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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LaunchWizard.Model;
using Amazon.LaunchWizard.Model.Internal.MarshallTransformations;
using Amazon.LaunchWizard.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.LaunchWizard
{
    /// <summary>
    /// <para>Implementation for accessing LaunchWizard</para>
    ///
    /// Launch Wizard offers a guided way of sizing, configuring, and deploying Amazon Web
    /// Services resources for third party applications, such as Microsoft SQL Server Always
    /// On and HANA based SAP systems, without the need to manually identify and provision
    /// individual Amazon Web Services resources.
    /// </summary>
    public partial class AmazonLaunchWizardClient : AmazonServiceClient, IAmazonLaunchWizard
    {
        private static IServiceMetadata serviceMetadata = new AmazonLaunchWizardMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with the credentials loaded from the application's
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
        public AmazonLaunchWizardClient()
            : base(new AmazonLaunchWizardConfig()) { }

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with the credentials loaded from the application's
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
        public AmazonLaunchWizardClient(RegionEndpoint region)
            : base(new AmazonLaunchWizardConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLaunchWizardClient Configuration Object</param>
        public AmazonLaunchWizardClient(AmazonLaunchWizardConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonLaunchWizardClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLaunchWizardClient(AWSCredentials credentials)
            : this(credentials, new AmazonLaunchWizardConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLaunchWizardClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLaunchWizardConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with AWS Credentials and an
        /// AmazonLaunchWizardClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLaunchWizardClient Configuration Object</param>
        public AmazonLaunchWizardClient(AWSCredentials credentials, AmazonLaunchWizardConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLaunchWizardClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLaunchWizardConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLaunchWizardClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLaunchWizardConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLaunchWizardClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLaunchWizardClient Configuration Object</param>
        public AmazonLaunchWizardClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLaunchWizardConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLaunchWizardClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLaunchWizardConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLaunchWizardClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLaunchWizardConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLaunchWizardClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLaunchWizardClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLaunchWizardClient Configuration Object</param>
        public AmazonLaunchWizardClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLaunchWizardConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ILaunchWizardPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILaunchWizardPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LaunchWizardPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLaunchWizardEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLaunchWizardAuthSchemeHandler());
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


        #region  CreateDeployment

        internal virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Creates a deployment for the given workload. Deployments created by this operation
        /// are not available in the Launch Wizard console to use the <c>Clone deployment</c>
        /// action on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceLimitException">
        /// You have exceeded an Launch Wizard resource limit. For example, you might have too
        /// many deployments in progress.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDeployment

        internal virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Deletes a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceLimitException">
        /// You have exceeded an Launch Wizard resource limit. For example, you might have too
        /// many deployments in progress.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual Task<DeleteDeploymentResponse> DeleteDeploymentAsync(DeleteDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDeployment

        internal virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkload

        internal virtual GetWorkloadResponse GetWorkload(GetWorkloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadResponseUnmarshaller.Instance;

            return Invoke<GetWorkloadResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkload service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        public virtual Task<GetWorkloadResponse> GetWorkloadAsync(GetWorkloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkloadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkloadDeploymentPattern

        internal virtual GetWorkloadDeploymentPatternResponse GetWorkloadDeploymentPattern(GetWorkloadDeploymentPatternRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadDeploymentPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadDeploymentPatternResponseUnmarshaller.Instance;

            return Invoke<GetWorkloadDeploymentPatternResponse>(request, options);
        }



        /// <summary>
        /// Returns details for a given workload and deployment pattern, including the available
        /// specifications. You can use the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloads.html">ListWorkloads</a>
        /// operation to discover the available workload names and the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloadDeploymentPatterns.html">ListWorkloadDeploymentPatterns</a>
        /// operation to discover the available deployment pattern names of a given workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadDeploymentPattern service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkloadDeploymentPattern service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetWorkloadDeploymentPattern">REST API Reference for GetWorkloadDeploymentPattern Operation</seealso>
        public virtual Task<GetWorkloadDeploymentPatternResponse> GetWorkloadDeploymentPatternAsync(GetWorkloadDeploymentPatternRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadDeploymentPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadDeploymentPatternResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkloadDeploymentPatternResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeploymentEvents

        internal virtual ListDeploymentEventsResponse ListDeploymentEvents(ListDeploymentEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentEventsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentEventsResponse>(request, options);
        }



        /// <summary>
        /// Lists the events of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentEvents service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeploymentEvents">REST API Reference for ListDeploymentEvents Operation</seealso>
        public virtual Task<ListDeploymentEventsResponse> ListDeploymentEventsAsync(ListDeploymentEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeployments

        internal virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the deployments that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkloadDeploymentPatterns

        internal virtual ListWorkloadDeploymentPatternsResponse ListWorkloadDeploymentPatterns(ListWorkloadDeploymentPatternsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadDeploymentPatternsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadDeploymentPatternsResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadDeploymentPatternsResponse>(request, options);
        }



        /// <summary>
        /// Lists the workload deployment patterns for a given workload name. You can use the
        /// <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloads.html">ListWorkloads</a>
        /// operation to discover the available workload names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadDeploymentPatterns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkloadDeploymentPatterns service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloadDeploymentPatterns">REST API Reference for ListWorkloadDeploymentPatterns Operation</seealso>
        public virtual Task<ListWorkloadDeploymentPatternsResponse> ListWorkloadDeploymentPatternsAsync(ListWorkloadDeploymentPatternsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadDeploymentPatternsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadDeploymentPatternsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkloadDeploymentPatternsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkloads

        internal virtual ListWorkloadsResponse ListWorkloads(ListWorkloadsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadsResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadsResponse>(request, options);
        }



        /// <summary>
        /// Lists the available workload names. You can use the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloadDeploymentPatterns.html">ListWorkloadDeploymentPatterns</a>
        /// operation to discover the available deployment patterns for a given workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkloads service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        public virtual Task<ListWorkloadsResponse> ListWorkloadsAsync(ListWorkloadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkloadsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds the specified tags to the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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