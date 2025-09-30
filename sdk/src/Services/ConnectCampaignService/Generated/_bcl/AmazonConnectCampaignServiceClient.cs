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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ConnectCampaignService.Model;
using Amazon.ConnectCampaignService.Model.Internal.MarshallTransformations;
using Amazon.ConnectCampaignService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ConnectCampaignService
{
    /// <summary>
    /// <para>Implementation for accessing ConnectCampaignService</para>
    ///
    /// Provide APIs to create and manage Amazon Connect Campaigns.
    /// </summary>
    public partial class AmazonConnectCampaignServiceClient : AmazonServiceClient, IAmazonConnectCampaignService
    {
        private static IServiceMetadata serviceMetadata = new AmazonConnectCampaignServiceMetadata();
        private IConnectCampaignServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IConnectCampaignServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ConnectCampaignServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with the credentials loaded from the application's
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
        public AmazonConnectCampaignServiceClient()
            : base(new AmazonConnectCampaignServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with the credentials loaded from the application's
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
        public AmazonConnectCampaignServiceClient(RegionEndpoint region)
            : base(new AmazonConnectCampaignServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConnectCampaignServiceClient Configuration Object</param>
        public AmazonConnectCampaignServiceClient(AmazonConnectCampaignServiceConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConnectCampaignServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonConnectCampaignServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectCampaignServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConnectCampaignServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with AWS Credentials and an
        /// AmazonConnectCampaignServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConnectCampaignServiceClient Configuration Object</param>
        public AmazonConnectCampaignServiceClient(AWSCredentials credentials, AmazonConnectCampaignServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConnectCampaignServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectCampaignServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectCampaignServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectCampaignServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectCampaignServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConnectCampaignServiceClient Configuration Object</param>
        public AmazonConnectCampaignServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConnectCampaignServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConnectCampaignServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectCampaignServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectCampaignServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectCampaignServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectCampaignServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConnectCampaignServiceClient Configuration Object</param>
        public AmazonConnectCampaignServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConnectCampaignServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectCampaignServiceEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectCampaignServiceAuthSchemeHandler());
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


        #region  CreateCampaign


        /// <summary>
        /// Creates a campaign for the specified Amazon Connect account. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignResponse>(request, options);
        }


        /// <summary>
        /// Creates a campaign for the specified Amazon Connect account. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCampaign


        /// <summary>
        /// Deletes a campaign from the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignResponse>(request, options);
        }


        /// <summary>
        /// Deletes a campaign from the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual Task<DeleteCampaignResponse> DeleteCampaignAsync(DeleteCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnectInstanceConfig


        /// <summary>
        /// Deletes a connect instance config from the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectInstanceConfig service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        public virtual DeleteConnectInstanceConfigResponse DeleteConnectInstanceConfig(DeleteConnectInstanceConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectInstanceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectInstanceConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectInstanceConfigResponse>(request, options);
        }


        /// <summary>
        /// Deletes a connect instance config from the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnectInstanceConfig service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        public virtual Task<DeleteConnectInstanceConfigResponse> DeleteConnectInstanceConfigAsync(DeleteConnectInstanceConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectInstanceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectInstanceConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConnectInstanceConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstanceOnboardingJob


        /// <summary>
        /// Delete the Connect Campaigns onboarding job for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceOnboardingJob service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceOnboardingJob service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        public virtual DeleteInstanceOnboardingJobResponse DeleteInstanceOnboardingJob(DeleteInstanceOnboardingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceOnboardingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceOnboardingJobResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceOnboardingJobResponse>(request, options);
        }


        /// <summary>
        /// Delete the Connect Campaigns onboarding job for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceOnboardingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInstanceOnboardingJob service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        public virtual Task<DeleteInstanceOnboardingJobResponse> DeleteInstanceOnboardingJobAsync(DeleteInstanceOnboardingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceOnboardingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceOnboardingJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInstanceOnboardingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCampaign


        /// <summary>
        /// Describes the specific campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign service method.</param>
        /// 
        /// <returns>The response from the DescribeCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual DescribeCampaignResponse DescribeCampaign(DescribeCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCampaignResponseUnmarshaller.Instance;

            return Invoke<DescribeCampaignResponse>(request, options);
        }


        /// <summary>
        /// Describes the specific campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual Task<DescribeCampaignResponse> DescribeCampaignAsync(DescribeCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCampaignState


        /// <summary>
        /// Get state of a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignState service method.</param>
        /// 
        /// <returns>The response from the GetCampaignState service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        public virtual GetCampaignStateResponse GetCampaignState(GetCampaignStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignStateResponseUnmarshaller.Instance;

            return Invoke<GetCampaignStateResponse>(request, options);
        }


        /// <summary>
        /// Get state of a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCampaignState service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        public virtual Task<GetCampaignStateResponse> GetCampaignStateAsync(GetCampaignStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCampaignStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCampaignStateBatch


        /// <summary>
        /// Get state of campaigns for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignStateBatch service method.</param>
        /// 
        /// <returns>The response from the GetCampaignStateBatch service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        public virtual GetCampaignStateBatchResponse GetCampaignStateBatch(GetCampaignStateBatchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignStateBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignStateBatchResponseUnmarshaller.Instance;

            return Invoke<GetCampaignStateBatchResponse>(request, options);
        }


        /// <summary>
        /// Get state of campaigns for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignStateBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCampaignStateBatch service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        public virtual Task<GetCampaignStateBatchResponse> GetCampaignStateBatchAsync(GetCampaignStateBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignStateBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignStateBatchResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCampaignStateBatchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnectInstanceConfig


        /// <summary>
        /// Get the specific Connect instance config.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectInstanceConfig service method.</param>
        /// 
        /// <returns>The response from the GetConnectInstanceConfig service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        public virtual GetConnectInstanceConfigResponse GetConnectInstanceConfig(GetConnectInstanceConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectInstanceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectInstanceConfigResponseUnmarshaller.Instance;

            return Invoke<GetConnectInstanceConfigResponse>(request, options);
        }


        /// <summary>
        /// Get the specific Connect instance config.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectInstanceConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectInstanceConfig service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        public virtual Task<GetConnectInstanceConfigResponse> GetConnectInstanceConfigAsync(GetConnectInstanceConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectInstanceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectInstanceConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConnectInstanceConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceOnboardingJobStatus


        /// <summary>
        /// Get the specific instance onboarding job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceOnboardingJobStatus service method.</param>
        /// 
        /// <returns>The response from the GetInstanceOnboardingJobStatus service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        public virtual GetInstanceOnboardingJobStatusResponse GetInstanceOnboardingJobStatus(GetInstanceOnboardingJobStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceOnboardingJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceOnboardingJobStatusResponseUnmarshaller.Instance;

            return Invoke<GetInstanceOnboardingJobStatusResponse>(request, options);
        }


        /// <summary>
        /// Get the specific instance onboarding job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceOnboardingJobStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstanceOnboardingJobStatus service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        public virtual Task<GetInstanceOnboardingJobStatusResponse> GetInstanceOnboardingJobStatusAsync(GetInstanceOnboardingJobStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceOnboardingJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceOnboardingJobStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstanceOnboardingJobStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCampaigns


        /// <summary>
        /// Provides summary information about the campaigns under the specified Amazon Connect
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// 
        /// <returns>The response from the ListCampaigns service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual ListCampaignsResponse ListCampaigns(ListCampaignsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return Invoke<ListCampaignsResponse>(request, options);
        }


        /// <summary>
        /// Provides summary information about the campaigns under the specified Amazon Connect
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCampaigns service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual Task<ListCampaignsResponse> ListCampaignsAsync(ListCampaignsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCampaignsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PauseCampaign


        /// <summary>
        /// Pauses a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseCampaign service method.</param>
        /// 
        /// <returns>The response from the PauseCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        public virtual PauseCampaignResponse PauseCampaign(PauseCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PauseCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseCampaignResponseUnmarshaller.Instance;

            return Invoke<PauseCampaignResponse>(request, options);
        }


        /// <summary>
        /// Pauses a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PauseCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        public virtual Task<PauseCampaignResponse> PauseCampaignAsync(PauseCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PauseCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<PauseCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDialRequestBatch


        /// <summary>
        /// Creates dials requests for the specified campaign Amazon Connect account. This API
        /// is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDialRequestBatch service method.</param>
        /// 
        /// <returns>The response from the PutDialRequestBatch service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/PutDialRequestBatch">REST API Reference for PutDialRequestBatch Operation</seealso>
        public virtual PutDialRequestBatchResponse PutDialRequestBatch(PutDialRequestBatchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDialRequestBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDialRequestBatchResponseUnmarshaller.Instance;

            return Invoke<PutDialRequestBatchResponse>(request, options);
        }


        /// <summary>
        /// Creates dials requests for the specified campaign Amazon Connect account. This API
        /// is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDialRequestBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDialRequestBatch service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/PutDialRequestBatch">REST API Reference for PutDialRequestBatch Operation</seealso>
        public virtual Task<PutDialRequestBatchResponse> PutDialRequestBatchAsync(PutDialRequestBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDialRequestBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDialRequestBatchResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutDialRequestBatchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResumeCampaign


        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeCampaign service method.</param>
        /// 
        /// <returns>The response from the ResumeCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        public virtual ResumeCampaignResponse ResumeCampaign(ResumeCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeCampaignResponseUnmarshaller.Instance;

            return Invoke<ResumeCampaignResponse>(request, options);
        }


        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        public virtual Task<ResumeCampaignResponse> ResumeCampaignAsync(ResumeCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResumeCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCampaign


        /// <summary>
        /// Starts a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCampaign service method.</param>
        /// 
        /// <returns>The response from the StartCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        public virtual StartCampaignResponse StartCampaign(StartCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignResponseUnmarshaller.Instance;

            return Invoke<StartCampaignResponse>(request, options);
        }


        /// <summary>
        /// Starts a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        public virtual Task<StartCampaignResponse> StartCampaignAsync(StartCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartInstanceOnboardingJob


        /// <summary>
        /// Onboard the specific Amazon Connect instance to Connect Campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceOnboardingJob service method.</param>
        /// 
        /// <returns>The response from the StartInstanceOnboardingJob service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        public virtual StartInstanceOnboardingJobResponse StartInstanceOnboardingJob(StartInstanceOnboardingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartInstanceOnboardingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceOnboardingJobResponseUnmarshaller.Instance;

            return Invoke<StartInstanceOnboardingJobResponse>(request, options);
        }


        /// <summary>
        /// Onboard the specific Amazon Connect instance to Connect Campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceOnboardingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartInstanceOnboardingJob service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        public virtual Task<StartInstanceOnboardingJobResponse> StartInstanceOnboardingJobAsync(StartInstanceOnboardingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartInstanceOnboardingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceOnboardingJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartInstanceOnboardingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopCampaign


        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCampaign service method.</param>
        /// 
        /// <returns>The response from the StopCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        public virtual StopCampaignResponse StopCampaign(StopCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCampaignResponseUnmarshaller.Instance;

            return Invoke<StopCampaignResponse>(request, options);
        }


        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCampaign service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        public virtual Task<StopCampaignResponse> StopCampaignAsync(StopCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCampaignResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopCampaignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Tag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Untag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCampaignDialerConfig


        /// <summary>
        /// Updates the dialer config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignDialerConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignDialerConfig service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignDialerConfig">REST API Reference for UpdateCampaignDialerConfig Operation</seealso>
        public virtual UpdateCampaignDialerConfigResponse UpdateCampaignDialerConfig(UpdateCampaignDialerConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignDialerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignDialerConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignDialerConfigResponse>(request, options);
        }


        /// <summary>
        /// Updates the dialer config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignDialerConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCampaignDialerConfig service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignDialerConfig">REST API Reference for UpdateCampaignDialerConfig Operation</seealso>
        public virtual Task<UpdateCampaignDialerConfigResponse> UpdateCampaignDialerConfigAsync(UpdateCampaignDialerConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignDialerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignDialerConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCampaignDialerConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCampaignName


        /// <summary>
        /// Updates the name of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignName service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignName service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        public virtual UpdateCampaignNameResponse UpdateCampaignName(UpdateCampaignNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignNameResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignNameResponse>(request, options);
        }


        /// <summary>
        /// Updates the name of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCampaignName service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        public virtual Task<UpdateCampaignNameResponse> UpdateCampaignNameAsync(UpdateCampaignNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCampaignNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCampaignOutboundCallConfig


        /// <summary>
        /// Updates the outbound call config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignOutboundCallConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignOutboundCallConfig service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignOutboundCallConfig">REST API Reference for UpdateCampaignOutboundCallConfig Operation</seealso>
        public virtual UpdateCampaignOutboundCallConfigResponse UpdateCampaignOutboundCallConfig(UpdateCampaignOutboundCallConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignOutboundCallConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignOutboundCallConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignOutboundCallConfigResponse>(request, options);
        }


        /// <summary>
        /// Updates the outbound call config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignOutboundCallConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCampaignOutboundCallConfig service method, as returned by ConnectCampaignService.</returns>
        /// <exception cref="Amazon.ConnectCampaignService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignOutboundCallConfig">REST API Reference for UpdateCampaignOutboundCallConfig Operation</seealso>
        public virtual Task<UpdateCampaignOutboundCallConfigResponse> UpdateCampaignOutboundCallConfigAsync(UpdateCampaignOutboundCallConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignOutboundCallConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignOutboundCallConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCampaignOutboundCallConfigResponse>(request, options, cancellationToken);
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