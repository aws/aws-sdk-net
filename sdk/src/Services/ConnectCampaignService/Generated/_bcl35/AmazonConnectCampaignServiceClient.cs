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
using System.Collections.Generic;
using System.Net;

using Amazon.ConnectCampaignService.Model;
using Amazon.ConnectCampaignService.Model.Internal.MarshallTransformations;
using Amazon.ConnectCampaignService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectCampaignServiceConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectCampaignServiceConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectCampaignServiceEndpointResolver());
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
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCampaignResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCampaignResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceConfig operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectInstanceConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnectInstanceConfig(DeleteConnectInstanceConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectInstanceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectInstanceConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectInstanceConfig.</param>
        /// 
        /// <returns>Returns a  DeleteConnectInstanceConfigResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        public virtual DeleteConnectInstanceConfigResponse EndDeleteConnectInstanceConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectInstanceConfigResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceOnboardingJob operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceOnboardingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteInstanceOnboardingJob(DeleteInstanceOnboardingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceOnboardingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceOnboardingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceOnboardingJob.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceOnboardingJobResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        public virtual DeleteInstanceOnboardingJobResponse EndDeleteInstanceOnboardingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceOnboardingJobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual IAsyncResult BeginDescribeCampaign(DescribeCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCampaign.</param>
        /// 
        /// <returns>Returns a  DescribeCampaignResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual DescribeCampaignResponse EndDescribeCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCampaignResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetCampaignState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignState operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        public virtual IAsyncResult BeginGetCampaignState(GetCampaignStateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignState.</param>
        /// 
        /// <returns>Returns a  GetCampaignStateResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        public virtual GetCampaignStateResponse EndGetCampaignState(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignStateResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetCampaignStateBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignStateBatch operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignStateBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        public virtual IAsyncResult BeginGetCampaignStateBatch(GetCampaignStateBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignStateBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignStateBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignStateBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignStateBatch.</param>
        /// 
        /// <returns>Returns a  GetCampaignStateBatchResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        public virtual GetCampaignStateBatchResponse EndGetCampaignStateBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignStateBatchResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectInstanceConfig operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectInstanceConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        public virtual IAsyncResult BeginGetConnectInstanceConfig(GetConnectInstanceConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectInstanceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectInstanceConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectInstanceConfig.</param>
        /// 
        /// <returns>Returns a  GetConnectInstanceConfigResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        public virtual GetConnectInstanceConfigResponse EndGetConnectInstanceConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectInstanceConfigResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetInstanceOnboardingJobStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceOnboardingJobStatus operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceOnboardingJobStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        public virtual IAsyncResult BeginGetInstanceOnboardingJobStatus(GetInstanceOnboardingJobStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceOnboardingJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceOnboardingJobStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceOnboardingJobStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceOnboardingJobStatus.</param>
        /// 
        /// <returns>Returns a  GetInstanceOnboardingJobStatusResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        public virtual GetInstanceOnboardingJobStatusResponse EndGetInstanceOnboardingJobStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceOnboardingJobStatusResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCampaigns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual IAsyncResult BeginListCampaigns(ListCampaignsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCampaigns.</param>
        /// 
        /// <returns>Returns a  ListCampaignsResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual ListCampaignsResponse EndListCampaigns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCampaignsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PauseCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PauseCampaign operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPauseCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        public virtual IAsyncResult BeginPauseCampaign(PauseCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PauseCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PauseCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPauseCampaign.</param>
        /// 
        /// <returns>Returns a  PauseCampaignResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        public virtual PauseCampaignResponse EndPauseCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<PauseCampaignResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutDialRequestBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDialRequestBatch operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDialRequestBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/PutDialRequestBatch">REST API Reference for PutDialRequestBatch Operation</seealso>
        public virtual IAsyncResult BeginPutDialRequestBatch(PutDialRequestBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDialRequestBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDialRequestBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDialRequestBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDialRequestBatch.</param>
        /// 
        /// <returns>Returns a  PutDialRequestBatchResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/PutDialRequestBatch">REST API Reference for PutDialRequestBatch Operation</seealso>
        public virtual PutDialRequestBatchResponse EndPutDialRequestBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDialRequestBatchResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ResumeCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeCampaign operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        public virtual IAsyncResult BeginResumeCampaign(ResumeCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeCampaign.</param>
        /// 
        /// <returns>Returns a  ResumeCampaignResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        public virtual ResumeCampaignResponse EndResumeCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<ResumeCampaignResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StartCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCampaign operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        public virtual IAsyncResult BeginStartCampaign(StartCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCampaign.</param>
        /// 
        /// <returns>Returns a  StartCampaignResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        public virtual StartCampaignResponse EndStartCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCampaignResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StartInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceOnboardingJob operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstanceOnboardingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        public virtual IAsyncResult BeginStartInstanceOnboardingJob(StartInstanceOnboardingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartInstanceOnboardingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceOnboardingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstanceOnboardingJob.</param>
        /// 
        /// <returns>Returns a  StartInstanceOnboardingJobResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        public virtual StartInstanceOnboardingJobResponse EndStartInstanceOnboardingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartInstanceOnboardingJobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StopCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCampaign operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        public virtual IAsyncResult BeginStopCampaign(StopCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCampaign.</param>
        /// 
        /// <returns>Returns a  StopCampaignResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        public virtual StopCampaignResponse EndStopCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<StopCampaignResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateCampaignDialerConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignDialerConfig operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignDialerConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignDialerConfig">REST API Reference for UpdateCampaignDialerConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaignDialerConfig(UpdateCampaignDialerConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignDialerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignDialerConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignDialerConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignDialerConfig.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignDialerConfigResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignDialerConfig">REST API Reference for UpdateCampaignDialerConfig Operation</seealso>
        public virtual UpdateCampaignDialerConfigResponse EndUpdateCampaignDialerConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignDialerConfigResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateCampaignName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignName operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaignName(UpdateCampaignNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignName.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignNameResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        public virtual UpdateCampaignNameResponse EndUpdateCampaignName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignNameResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateCampaignOutboundCallConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignOutboundCallConfig operation on AmazonConnectCampaignServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignOutboundCallConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignOutboundCallConfig">REST API Reference for UpdateCampaignOutboundCallConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaignOutboundCallConfig(UpdateCampaignOutboundCallConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignOutboundCallConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignOutboundCallConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignOutboundCallConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignOutboundCallConfig.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignOutboundCallConfigResult from ConnectCampaignService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaigns-2021-01-30/UpdateCampaignOutboundCallConfig">REST API Reference for UpdateCampaignOutboundCallConfig Operation</seealso>
        public virtual UpdateCampaignOutboundCallConfigResponse EndUpdateCampaignOutboundCallConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignOutboundCallConfigResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonConnectCampaignServiceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}