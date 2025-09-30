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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AppTest.Model;
using Amazon.AppTest.Model.Internal.MarshallTransformations;
using Amazon.AppTest.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AppTest
{
    /// <summary>
    /// <para>Implementation for accessing AppTest</para>
    ///
    /// AWS Mainframe Modernization Application Testing provides tools and resources for automated
    /// functional equivalence testing for your migration projects.
    /// </summary>
    public partial class AmazonAppTestClient : AmazonServiceClient, IAmazonAppTest
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppTestMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppTestClient with the credentials loaded from the application's
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
        public AmazonAppTestClient()
            : base(new AmazonAppTestConfig()) { }

        /// <summary>
        /// Constructs AmazonAppTestClient with the credentials loaded from the application's
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
        public AmazonAppTestClient(RegionEndpoint region)
            : base(new AmazonAppTestConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppTestClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppTestClient Configuration Object</param>
        public AmazonAppTestClient(AmazonAppTestConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonAppTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppTestClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppTestClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppTestClient with AWS Credentials and an
        /// AmazonAppTestClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppTestClient Configuration Object</param>
        public AmazonAppTestClient(AWSCredentials credentials, AmazonAppTestConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppTestClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppTestClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppTestConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppTestClient Configuration Object</param>
        public AmazonAppTestClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppTestClient Configuration Object</param>
        public AmazonAppTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAppTestPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAppTestPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AppTestPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppTestEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppTestAuthSchemeHandler());
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


        #region  CreateTestCase

        internal virtual CreateTestCaseResponse CreateTestCase(CreateTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTestCaseResponseUnmarshaller.Instance;

            return Invoke<CreateTestCaseResponse>(request, options);
        }



        /// <summary>
        /// Creates a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTestCase service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestCase">REST API Reference for CreateTestCase Operation</seealso>
        public virtual Task<CreateTestCaseResponse> CreateTestCaseAsync(CreateTestCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTestCaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTestCaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTestConfiguration

        internal virtual CreateTestConfigurationResponse CreateTestConfiguration(CreateTestConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTestConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateTestConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTestConfiguration service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestConfiguration">REST API Reference for CreateTestConfiguration Operation</seealso>
        public virtual Task<CreateTestConfigurationResponse> CreateTestConfigurationAsync(CreateTestConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTestConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTestConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTestSuite

        internal virtual CreateTestSuiteResponse CreateTestSuite(CreateTestSuiteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTestSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTestSuiteResponseUnmarshaller.Instance;

            return Invoke<CreateTestSuiteResponse>(request, options);
        }



        /// <summary>
        /// Creates a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestSuite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTestSuite service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestSuite">REST API Reference for CreateTestSuite Operation</seealso>
        public virtual Task<CreateTestSuiteResponse> CreateTestSuiteAsync(CreateTestSuiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTestSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTestSuiteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTestSuiteResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTestCase

        internal virtual DeleteTestCaseResponse DeleteTestCase(DeleteTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTestCaseResponseUnmarshaller.Instance;

            return Invoke<DeleteTestCaseResponse>(request, options);
        }



        /// <summary>
        /// Deletes a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTestCase service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestCase">REST API Reference for DeleteTestCase Operation</seealso>
        public virtual Task<DeleteTestCaseResponse> DeleteTestCaseAsync(DeleteTestCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTestCaseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTestCaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTestConfiguration

        internal virtual DeleteTestConfigurationResponse DeleteTestConfiguration(DeleteTestConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTestConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteTestConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTestConfiguration service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestConfiguration">REST API Reference for DeleteTestConfiguration Operation</seealso>
        public virtual Task<DeleteTestConfigurationResponse> DeleteTestConfigurationAsync(DeleteTestConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTestConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTestConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTestRun

        internal virtual DeleteTestRunResponse DeleteTestRun(DeleteTestRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTestRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTestRunResponseUnmarshaller.Instance;

            return Invoke<DeleteTestRunResponse>(request, options);
        }



        /// <summary>
        /// Deletes a test run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTestRun service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestRun">REST API Reference for DeleteTestRun Operation</seealso>
        public virtual Task<DeleteTestRunResponse> DeleteTestRunAsync(DeleteTestRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTestRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTestRunResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTestRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTestSuite

        internal virtual DeleteTestSuiteResponse DeleteTestSuite(DeleteTestSuiteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTestSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTestSuiteResponseUnmarshaller.Instance;

            return Invoke<DeleteTestSuiteResponse>(request, options);
        }



        /// <summary>
        /// Deletes a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestSuite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTestSuite service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestSuite">REST API Reference for DeleteTestSuite Operation</seealso>
        public virtual Task<DeleteTestSuiteResponse> DeleteTestSuiteAsync(DeleteTestSuiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTestSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTestSuiteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTestSuiteResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTestCase

        internal virtual GetTestCaseResponse GetTestCase(GetTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestCaseResponseUnmarshaller.Instance;

            return Invoke<GetTestCaseResponse>(request, options);
        }



        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTestCase service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestCase">REST API Reference for GetTestCase Operation</seealso>
        public virtual Task<GetTestCaseResponse> GetTestCaseAsync(GetTestCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestCaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetTestCaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTestConfiguration

        internal virtual GetTestConfigurationResponse GetTestConfiguration(GetTestConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetTestConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTestConfiguration service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestConfiguration">REST API Reference for GetTestConfiguration Operation</seealso>
        public virtual Task<GetTestConfigurationResponse> GetTestConfigurationAsync(GetTestConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetTestConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTestRunStep

        internal virtual GetTestRunStepResponse GetTestRunStep(GetTestRunStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestRunStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestRunStepResponseUnmarshaller.Instance;

            return Invoke<GetTestRunStepResponse>(request, options);
        }



        /// <summary>
        /// Gets a test run step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestRunStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTestRunStep service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestRunStep">REST API Reference for GetTestRunStep Operation</seealso>
        public virtual Task<GetTestRunStepResponse> GetTestRunStepAsync(GetTestRunStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestRunStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestRunStepResponseUnmarshaller.Instance;

            return InvokeAsync<GetTestRunStepResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTestSuite

        internal virtual GetTestSuiteResponse GetTestSuite(GetTestSuiteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestSuiteResponseUnmarshaller.Instance;

            return Invoke<GetTestSuiteResponse>(request, options);
        }



        /// <summary>
        /// Gets a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestSuite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTestSuite service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestSuite">REST API Reference for GetTestSuite Operation</seealso>
        public virtual Task<GetTestSuiteResponse> GetTestSuiteAsync(GetTestSuiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTestSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTestSuiteResponseUnmarshaller.Instance;

            return InvokeAsync<GetTestSuiteResponse>(request, options, cancellationToken);
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
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTestCases

        internal virtual ListTestCasesResponse ListTestCases(ListTestCasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestCasesResponseUnmarshaller.Instance;

            return Invoke<ListTestCasesResponse>(request, options);
        }



        /// <summary>
        /// Lists test cases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTestCases service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestCases">REST API Reference for ListTestCases Operation</seealso>
        public virtual Task<ListTestCasesResponse> ListTestCasesAsync(ListTestCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestCasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTestCasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTestConfigurations

        internal virtual ListTestConfigurationsResponse ListTestConfigurations(ListTestConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListTestConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Lists test configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTestConfigurations service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestConfigurations">REST API Reference for ListTestConfigurations Operation</seealso>
        public virtual Task<ListTestConfigurationsResponse> ListTestConfigurationsAsync(ListTestConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTestConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTestRuns

        internal virtual ListTestRunsResponse ListTestRuns(ListTestRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestRunsResponseUnmarshaller.Instance;

            return Invoke<ListTestRunsResponse>(request, options);
        }



        /// <summary>
        /// Lists test runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTestRuns service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRuns">REST API Reference for ListTestRuns Operation</seealso>
        public virtual Task<ListTestRunsResponse> ListTestRunsAsync(ListTestRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTestRunsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTestRunSteps

        internal virtual ListTestRunStepsResponse ListTestRunSteps(ListTestRunStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestRunStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestRunStepsResponseUnmarshaller.Instance;

            return Invoke<ListTestRunStepsResponse>(request, options);
        }



        /// <summary>
        /// Lists test run steps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRunSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTestRunSteps service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRunSteps">REST API Reference for ListTestRunSteps Operation</seealso>
        public virtual Task<ListTestRunStepsResponse> ListTestRunStepsAsync(ListTestRunStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestRunStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestRunStepsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTestRunStepsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTestRunTestCases

        internal virtual ListTestRunTestCasesResponse ListTestRunTestCases(ListTestRunTestCasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestRunTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestRunTestCasesResponseUnmarshaller.Instance;

            return Invoke<ListTestRunTestCasesResponse>(request, options);
        }



        /// <summary>
        /// Lists test run test cases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRunTestCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTestRunTestCases service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRunTestCases">REST API Reference for ListTestRunTestCases Operation</seealso>
        public virtual Task<ListTestRunTestCasesResponse> ListTestRunTestCasesAsync(ListTestRunTestCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestRunTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestRunTestCasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTestRunTestCasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTestSuites

        internal virtual ListTestSuitesResponse ListTestSuites(ListTestSuitesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestSuitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestSuitesResponseUnmarshaller.Instance;

            return Invoke<ListTestSuitesResponse>(request, options);
        }



        /// <summary>
        /// Lists test suites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestSuites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTestSuites service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestSuites">REST API Reference for ListTestSuites Operation</seealso>
        public virtual Task<ListTestSuitesResponse> ListTestSuitesAsync(ListTestSuitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTestSuitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestSuitesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTestSuitesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartTestRun

        internal virtual StartTestRunResponse StartTestRun(StartTestRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTestRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTestRunResponseUnmarshaller.Instance;

            return Invoke<StartTestRunResponse>(request, options);
        }



        /// <summary>
        /// Starts a test run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTestRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTestRun service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/StartTestRun">REST API Reference for StartTestRun Operation</seealso>
        public virtual Task<StartTestRunResponse> StartTestRunAsync(StartTestRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTestRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTestRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartTestRunResponse>(request, options, cancellationToken);
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
        /// Specifies tags of a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Untags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTestCase

        internal virtual UpdateTestCaseResponse UpdateTestCase(UpdateTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTestCaseResponseUnmarshaller.Instance;

            return Invoke<UpdateTestCaseResponse>(request, options);
        }



        /// <summary>
        /// Updates a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTestCase service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestCase">REST API Reference for UpdateTestCase Operation</seealso>
        public virtual Task<UpdateTestCaseResponse> UpdateTestCaseAsync(UpdateTestCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTestCaseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTestCaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTestConfiguration

        internal virtual UpdateTestConfigurationResponse UpdateTestConfiguration(UpdateTestConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTestConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateTestConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTestConfiguration service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestConfiguration">REST API Reference for UpdateTestConfiguration Operation</seealso>
        public virtual Task<UpdateTestConfigurationResponse> UpdateTestConfigurationAsync(UpdateTestConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTestConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTestConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTestSuite

        internal virtual UpdateTestSuiteResponse UpdateTestSuite(UpdateTestSuiteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTestSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTestSuiteResponseUnmarshaller.Instance;

            return Invoke<UpdateTestSuiteResponse>(request, options);
        }



        /// <summary>
        /// Updates a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestSuite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTestSuite service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestSuite">REST API Reference for UpdateTestSuite Operation</seealso>
        public virtual Task<UpdateTestSuiteResponse> UpdateTestSuiteAsync(UpdateTestSuiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTestSuiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTestSuiteResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTestSuiteResponse>(request, options, cancellationToken);
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