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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTDeviceAdvisor.Model;
using Amazon.IoTDeviceAdvisor.Model.Internal.MarshallTransformations;
using Amazon.IoTDeviceAdvisor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTDeviceAdvisor
{
    /// <summary>
    /// Implementation for accessing IoTDeviceAdvisor
    ///
    /// AWS IoT Core Device Advisor is a cloud-based, fully managed test capability for validating
    /// IoT devices during device software development. Device Advisor provides pre-built
    /// tests that you can use to validate IoT devices for reliable and secure connectivity
    /// with AWS IoT Core before deploying devices to production. By using Device Advisor,
    /// you can confirm that your devices can connect to AWS IoT Core, follow security best
    /// practices and, if applicable, receive software updates from IoT Device Management.
    /// You can also download signed qualification reports to submit to the AWS Partner Network
    /// to get your device qualified for the AWS Partner Device Catalog without the need to
    /// send your device in and wait for it to be tested.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonIoTDeviceAdvisorClient : AmazonServiceClient, IAmazonIoTDeviceAdvisor
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTDeviceAdvisorMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with the credentials loaded from the application's
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
        public AmazonIoTDeviceAdvisorClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTDeviceAdvisorConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with the credentials loaded from the application's
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
        public AmazonIoTDeviceAdvisorClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTDeviceAdvisorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTDeviceAdvisorClient Configuration Object</param>
        public AmazonIoTDeviceAdvisorClient(AmazonIoTDeviceAdvisorConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTDeviceAdvisorClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTDeviceAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTDeviceAdvisorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTDeviceAdvisorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Credentials and an
        /// AmazonIoTDeviceAdvisorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTDeviceAdvisorClient Configuration Object</param>
        public AmazonIoTDeviceAdvisorClient(AWSCredentials credentials, AmazonIoTDeviceAdvisorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTDeviceAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTDeviceAdvisorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTDeviceAdvisorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTDeviceAdvisorClient Configuration Object</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTDeviceAdvisorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTDeviceAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTDeviceAdvisorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTDeviceAdvisorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTDeviceAdvisorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTDeviceAdvisorClient Configuration Object</param>
        public AmazonIoTDeviceAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTDeviceAdvisorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IIoTDeviceAdvisorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTDeviceAdvisorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTDeviceAdvisorPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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


        #region  CreateSuiteDefinition

        internal virtual CreateSuiteDefinitionResponse CreateSuiteDefinition(CreateSuiteDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSuiteDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateSuiteDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a Device Advisor test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSuiteDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/CreateSuiteDefinition">REST API Reference for CreateSuiteDefinition Operation</seealso>
        public virtual Task<CreateSuiteDefinitionResponse> CreateSuiteDefinitionAsync(CreateSuiteDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSuiteDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSuiteDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSuiteDefinition

        internal virtual DeleteSuiteDefinitionResponse DeleteSuiteDefinition(DeleteSuiteDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuiteDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteSuiteDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Device Advisor test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuiteDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/DeleteSuiteDefinition">REST API Reference for DeleteSuiteDefinition Operation</seealso>
        public virtual Task<DeleteSuiteDefinitionResponse> DeleteSuiteDefinitionAsync(DeleteSuiteDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuiteDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSuiteDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSuiteDefinition

        internal virtual GetSuiteDefinitionResponse GetSuiteDefinition(GetSuiteDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetSuiteDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a Device Advisor test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteDefinition">REST API Reference for GetSuiteDefinition Operation</seealso>
        public virtual Task<GetSuiteDefinitionResponse> GetSuiteDefinitionAsync(GetSuiteDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSuiteDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSuiteRun

        internal virtual GetSuiteRunResponse GetSuiteRun(GetSuiteRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSuiteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteRunResponseUnmarshaller.Instance;

            return Invoke<GetSuiteRunResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a Device Advisor test suite run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSuiteRun service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRun">REST API Reference for GetSuiteRun Operation</seealso>
        public virtual Task<GetSuiteRunResponse> GetSuiteRunAsync(GetSuiteRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSuiteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetSuiteRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSuiteRunReport

        internal virtual GetSuiteRunReportResponse GetSuiteRunReport(GetSuiteRunReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSuiteRunReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteRunReportResponseUnmarshaller.Instance;

            return Invoke<GetSuiteRunReportResponse>(request, options);
        }



        /// <summary>
        /// Gets a report download link for a successful Device Advisor qualifying test suite
        /// run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRunReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSuiteRunReport service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRunReport">REST API Reference for GetSuiteRunReport Operation</seealso>
        public virtual Task<GetSuiteRunReportResponse> GetSuiteRunReportAsync(GetSuiteRunReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSuiteRunReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuiteRunReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetSuiteRunReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSuiteDefinitions

        internal virtual ListSuiteDefinitionsResponse ListSuiteDefinitions(ListSuiteDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuiteDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuiteDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListSuiteDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the Device Advisor test suites you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSuiteDefinitions service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteDefinitions">REST API Reference for ListSuiteDefinitions Operation</seealso>
        public virtual Task<ListSuiteDefinitionsResponse> ListSuiteDefinitionsAsync(ListSuiteDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuiteDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuiteDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSuiteDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSuiteRuns

        internal virtual ListSuiteRunsResponse ListSuiteRuns(ListSuiteRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuiteRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuiteRunsResponseUnmarshaller.Instance;

            return Invoke<ListSuiteRunsResponse>(request, options);
        }



        /// <summary>
        /// Lists the runs of the specified Device Advisor test suite. You can list all runs of
        /// the test suite, or the runs of a specific version of the test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSuiteRuns service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteRuns">REST API Reference for ListSuiteRuns Operation</seealso>
        public virtual Task<ListSuiteRunsResponse> ListSuiteRunsAsync(ListSuiteRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuiteRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuiteRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSuiteRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags attached to an IoT Device Advisor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTestCases

        internal virtual ListTestCasesResponse ListTestCases(ListTestCasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestCasesResponseUnmarshaller.Instance;

            return Invoke<ListTestCasesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the test cases in the test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTestCases service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTestCases">REST API Reference for ListTestCases Operation</seealso>
        public virtual Task<ListTestCasesResponse> ListTestCasesAsync(ListTestCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestCasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTestCasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSuiteRun

        internal virtual StartSuiteRunResponse StartSuiteRun(StartSuiteRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSuiteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSuiteRunResponseUnmarshaller.Instance;

            return Invoke<StartSuiteRunResponse>(request, options);
        }



        /// <summary>
        /// Starts a Device Advisor test suite run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSuiteRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSuiteRun service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ConflictException">
        /// Sends Conflict Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StartSuiteRun">REST API Reference for StartSuiteRun Operation</seealso>
        public virtual Task<StartSuiteRunResponse> StartSuiteRunAsync(StartSuiteRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSuiteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSuiteRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartSuiteRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds to and modifies existing tags of an IoT Device Advisor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from an IoT Device Advisor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSuiteDefinition

        internal virtual UpdateSuiteDefinitionResponse UpdateSuiteDefinition(UpdateSuiteDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSuiteDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateSuiteDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates a Device Advisor test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSuiteDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UpdateSuiteDefinition">REST API Reference for UpdateSuiteDefinition Operation</seealso>
        public virtual Task<UpdateSuiteDefinitionResponse> UpdateSuiteDefinitionAsync(UpdateSuiteDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSuiteDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSuiteDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSuiteDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}