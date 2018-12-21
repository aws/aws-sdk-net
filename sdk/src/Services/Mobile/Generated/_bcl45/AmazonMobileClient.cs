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
 * Do not modify this file. This file is generated from the mobile-2017-07-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Mobile.Model;
using Amazon.Mobile.Model.Internal.MarshallTransformations;
using Amazon.Mobile.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Mobile
{
    /// <summary>
    /// Implementation for accessing Mobile
    ///
    /// AWS Mobile Service provides mobile app and website developers with capabilities required
    /// to configure AWS resources and bootstrap their developer desktop projects with the
    /// necessary SDKs, constants, tools and samples to make use of those resources.
    /// </summary>
    public partial class AmazonMobileClient : AmazonServiceClient, IAmazonMobile
    {
        private static IServiceMetadata serviceMetadata = new AmazonMobileMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonMobileClient with the credentials loaded from the application's
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
        public AmazonMobileClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMobileConfig()) { }

        /// <summary>
        /// Constructs AmazonMobileClient with the credentials loaded from the application's
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
        public AmazonMobileClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMobileConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMobileClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMobileClient Configuration Object</param>
        public AmazonMobileClient(AmazonMobileConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMobileClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMobileClient(AWSCredentials credentials)
            : this(credentials, new AmazonMobileConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMobileClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMobileClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMobileConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMobileClient with AWS Credentials and an
        /// AmazonMobileClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMobileClient Configuration Object</param>
        public AmazonMobileClient(AWSCredentials credentials, AmazonMobileConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMobileClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMobileClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMobileConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMobileClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMobileClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMobileConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMobileClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMobileClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMobileClient Configuration Object</param>
        public AmazonMobileClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMobileConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMobileClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMobileClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMobileConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMobileClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMobileClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMobileConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMobileClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMobileClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMobileClient Configuration Object</param>
        public AmazonMobileClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMobileConfig clientConfig)
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


        #region  CreateProject


        /// <summary>
        /// Creates an AWS Mobile Hub project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.LimitExceededException">
        /// There are too many AWS Mobile Hub projects in the account or the account has exceeded
        /// the maximum number of resources in some AWS service. You should create another sub-account
        /// using AWS Organizations or remove some resources and retry your request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Delets a project in AWS Mobile Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBundle


        /// <summary>
        /// Get the bundle details for the requested bundle id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundle service method.</param>
        /// 
        /// <returns>The response from the DescribeBundle service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DescribeBundle">REST API Reference for DescribeBundle Operation</seealso>
        public virtual DescribeBundleResponse DescribeBundle(DescribeBundleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBundleResponseUnmarshaller.Instance;

            return Invoke<DescribeBundleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundle operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DescribeBundle">REST API Reference for DescribeBundle Operation</seealso>
        public virtual Task<DescribeBundleResponse> DescribeBundleAsync(DescribeBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBundleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBundleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProject


        /// <summary>
        /// Gets details about a project in AWS Mobile Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportBundle


        /// <summary>
        /// Generates customized software development kit (SDK) and or tool packages used to
        /// integrate mobile web or mobile app clients with backend AWS resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportBundle service method.</param>
        /// 
        /// <returns>The response from the ExportBundle service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ExportBundle">REST API Reference for ExportBundle Operation</seealso>
        public virtual ExportBundleResponse ExportBundle(ExportBundleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportBundleResponseUnmarshaller.Instance;

            return Invoke<ExportBundleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportBundle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportBundle operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ExportBundle">REST API Reference for ExportBundle Operation</seealso>
        public virtual Task<ExportBundleResponse> ExportBundleAsync(ExportBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportBundleResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExportBundleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportProject


        /// <summary>
        /// Exports project configuration to a snapshot which can be downloaded and shared. Note
        /// that mobile app push credentials are encrypted in exported projects, so they can only
        /// be shared successfully within the same AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportProject service method.</param>
        /// 
        /// <returns>The response from the ExportProject service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ExportProject">REST API Reference for ExportProject Operation</seealso>
        public virtual ExportProjectResponse ExportProject(ExportProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportProjectResponseUnmarshaller.Instance;

            return Invoke<ExportProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ExportProject">REST API Reference for ExportProject Operation</seealso>
        public virtual Task<ExportProjectResponse> ExportProjectAsync(ExportProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExportProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBundles


        /// <summary>
        /// List all available bundles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBundles service method.</param>
        /// 
        /// <returns>The response from the ListBundles service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ListBundles">REST API Reference for ListBundles Operation</seealso>
        public virtual ListBundlesResponse ListBundles(ListBundlesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBundlesResponseUnmarshaller.Instance;

            return Invoke<ListBundlesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBundles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ListBundles">REST API Reference for ListBundles Operation</seealso>
        public virtual Task<ListBundlesResponse> ListBundlesAsync(ListBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBundlesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBundlesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Lists projects in AWS Mobile Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Update an existing project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by Mobile.</returns>
        /// <exception cref="Amazon.Mobile.Model.AccountActionRequiredException">
        /// Account Action is required in order to continue the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.BadRequestException">
        /// The request cannot be processed because some parameter is not valid or the project
        /// state prevents the operation from being performed.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.InternalFailureException">
        /// The service has encountered an unexpected error condition which prevents it from
        /// servicing the request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.LimitExceededException">
        /// There are too many AWS Mobile Hub projects in the account or the account has exceeded
        /// the maximum number of resources in some AWS service. You should create another sub-account
        /// using AWS Organizations or remove some resources and retry your request.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.NotFoundException">
        /// No entity can be found with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. The request should be retried after some
        /// time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.TooManyRequestsException">
        /// Too many requests have been received for this AWS account in too short a time. The
        /// request should be retried after some time delay.
        /// </exception>
        /// <exception cref="Amazon.Mobile.Model.UnauthorizedException">
        /// Credentials of the caller are insufficient to authorize the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mobile-2017-07-01/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}