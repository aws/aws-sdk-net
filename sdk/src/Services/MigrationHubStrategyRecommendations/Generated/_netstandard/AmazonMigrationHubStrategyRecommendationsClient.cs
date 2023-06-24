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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MigrationHubStrategyRecommendations.Model;
using Amazon.MigrationHubStrategyRecommendations.Model.Internal.MarshallTransformations;
using Amazon.MigrationHubStrategyRecommendations.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MigrationHubStrategyRecommendations
{
    /// <summary>
    /// Implementation for accessing MigrationHubStrategyRecommendations
    ///
    /// Migration Hub Strategy Recommendations 
    /// <para>
    /// This API reference provides descriptions, syntax, and other details about each of
    /// the actions and data types for Migration Hub Strategy Recommendations (Strategy Recommendations).
    /// The topic for each action shows the API request parameters and the response. Alternatively,
    /// you can use one of the AWS SDKs to access an API that is tailored to the programming
    /// language or platform that you're using. For more information, see <a href="http://aws.amazon.com/tools/#SDKs">AWS
    /// SDKs</a>.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonMigrationHubStrategyRecommendationsClient : AmazonServiceClient, IAmazonMigrationHubStrategyRecommendations
    {
        private static IServiceMetadata serviceMetadata = new AmazonMigrationHubStrategyRecommendationsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with the credentials loaded from the application's
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
        public AmazonMigrationHubStrategyRecommendationsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMigrationHubStrategyRecommendationsConfig()) { }

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with the credentials loaded from the application's
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
        public AmazonMigrationHubStrategyRecommendationsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMigrationHubStrategyRecommendationsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMigrationHubStrategyRecommendationsClient Configuration Object</param>
        public AmazonMigrationHubStrategyRecommendationsClient(AmazonMigrationHubStrategyRecommendationsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMigrationHubStrategyRecommendationsClient(AWSCredentials credentials)
            : this(credentials, new AmazonMigrationHubStrategyRecommendationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubStrategyRecommendationsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMigrationHubStrategyRecommendationsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with AWS Credentials and an
        /// AmazonMigrationHubStrategyRecommendationsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMigrationHubStrategyRecommendationsClient Configuration Object</param>
        public AmazonMigrationHubStrategyRecommendationsClient(AWSCredentials credentials, AmazonMigrationHubStrategyRecommendationsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMigrationHubStrategyRecommendationsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMigrationHubStrategyRecommendationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubStrategyRecommendationsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMigrationHubStrategyRecommendationsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMigrationHubStrategyRecommendationsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMigrationHubStrategyRecommendationsClient Configuration Object</param>
        public AmazonMigrationHubStrategyRecommendationsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMigrationHubStrategyRecommendationsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMigrationHubStrategyRecommendationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMigrationHubStrategyRecommendationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubStrategyRecommendationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMigrationHubStrategyRecommendationsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubStrategyRecommendationsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMigrationHubStrategyRecommendationsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMigrationHubStrategyRecommendationsClient Configuration Object</param>
        public AmazonMigrationHubStrategyRecommendationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMigrationHubStrategyRecommendationsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMigrationHubStrategyRecommendationsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMigrationHubStrategyRecommendationsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MigrationHubStrategyRecommendationsPaginatorFactory(this);
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMigrationHubStrategyRecommendationsEndpointResolver());
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


        #region  GetApplicationComponentDetails

        internal virtual GetApplicationComponentDetailsResponse GetApplicationComponentDetails(GetApplicationComponentDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationComponentDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationComponentDetailsResponseUnmarshaller.Instance;

            return Invoke<GetApplicationComponentDetailsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about an application component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationComponentDetails service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentDetails">REST API Reference for GetApplicationComponentDetails Operation</seealso>
        public virtual Task<GetApplicationComponentDetailsResponse> GetApplicationComponentDetailsAsync(GetApplicationComponentDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationComponentDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationComponentDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationComponentDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApplicationComponentStrategies

        internal virtual GetApplicationComponentStrategiesResponse GetApplicationComponentStrategies(GetApplicationComponentStrategiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationComponentStrategiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationComponentStrategiesResponseUnmarshaller.Instance;

            return Invoke<GetApplicationComponentStrategiesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of all the recommended strategies and tools for an application component
        /// running on a server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentStrategies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationComponentStrategies service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentStrategies">REST API Reference for GetApplicationComponentStrategies Operation</seealso>
        public virtual Task<GetApplicationComponentStrategiesResponse> GetApplicationComponentStrategiesAsync(GetApplicationComponentStrategiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationComponentStrategiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationComponentStrategiesResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationComponentStrategiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssessment

        internal virtual GetAssessmentResponse GetAssessment(GetAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the status of an on-going assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssessment service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        public virtual Task<GetAssessmentResponse> GetAssessmentAsync(GetAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetImportFileTask

        internal virtual GetImportFileTaskResponse GetImportFileTask(GetImportFileTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportFileTaskResponseUnmarshaller.Instance;

            return Invoke<GetImportFileTaskResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details about a specific import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportFileTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImportFileTask service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetImportFileTask">REST API Reference for GetImportFileTask Operation</seealso>
        public virtual Task<GetImportFileTaskResponse> GetImportFileTaskAsync(GetImportFileTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportFileTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportFileTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLatestAssessmentId

        internal virtual GetLatestAssessmentIdResponse GetLatestAssessmentId(GetLatestAssessmentIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLatestAssessmentIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLatestAssessmentIdResponseUnmarshaller.Instance;

            return Invoke<GetLatestAssessmentIdResponse>(request, options);
        }



        /// <summary>
        /// Retrieve the latest ID of a specific assessment task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLatestAssessmentId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLatestAssessmentId service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetLatestAssessmentId">REST API Reference for GetLatestAssessmentId Operation</seealso>
        public virtual Task<GetLatestAssessmentIdResponse> GetLatestAssessmentIdAsync(GetLatestAssessmentIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLatestAssessmentIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLatestAssessmentIdResponseUnmarshaller.Instance;

            return InvokeAsync<GetLatestAssessmentIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPortfolioPreferences

        internal virtual GetPortfolioPreferencesResponse GetPortfolioPreferences(GetPortfolioPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortfolioPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortfolioPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetPortfolioPreferencesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves your migration and modernization preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPortfolioPreferences service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioPreferences">REST API Reference for GetPortfolioPreferences Operation</seealso>
        public virtual Task<GetPortfolioPreferencesResponse> GetPortfolioPreferencesAsync(GetPortfolioPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortfolioPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortfolioPreferencesResponseUnmarshaller.Instance;

            return InvokeAsync<GetPortfolioPreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPortfolioSummary

        internal virtual GetPortfolioSummaryResponse GetPortfolioSummary(GetPortfolioSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortfolioSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortfolioSummaryResponseUnmarshaller.Instance;

            return Invoke<GetPortfolioSummaryResponse>(request, options);
        }



        /// <summary>
        /// Retrieves overall summary including the number of servers to rehost and the overall
        /// number of anti-patterns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPortfolioSummary service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioSummary">REST API Reference for GetPortfolioSummary Operation</seealso>
        public virtual Task<GetPortfolioSummaryResponse> GetPortfolioSummaryAsync(GetPortfolioSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortfolioSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortfolioSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetPortfolioSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRecommendationReportDetails

        internal virtual GetRecommendationReportDetailsResponse GetRecommendationReportDetails(GetRecommendationReportDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationReportDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationReportDetailsResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationReportDetailsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about the specified recommendation report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationReportDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendationReportDetails service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetRecommendationReportDetails">REST API Reference for GetRecommendationReportDetails Operation</seealso>
        public virtual Task<GetRecommendationReportDetailsResponse> GetRecommendationReportDetailsAsync(GetRecommendationReportDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationReportDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationReportDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecommendationReportDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServerDetails

        internal virtual GetServerDetailsResponse GetServerDetails(GetServerDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerDetailsResponseUnmarshaller.Instance;

            return Invoke<GetServerDetailsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServerDetails service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerDetails">REST API Reference for GetServerDetails Operation</seealso>
        public virtual Task<GetServerDetailsResponse> GetServerDetailsAsync(GetServerDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetServerDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServerStrategies

        internal virtual GetServerStrategiesResponse GetServerStrategies(GetServerStrategiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerStrategiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerStrategiesResponseUnmarshaller.Instance;

            return Invoke<GetServerStrategiesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves recommended strategies and tools for the specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerStrategies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServerStrategies service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerStrategies">REST API Reference for GetServerStrategies Operation</seealso>
        public virtual Task<GetServerStrategiesResponse> GetServerStrategiesAsync(GetServerStrategiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerStrategiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerStrategiesResponseUnmarshaller.Instance;

            return InvokeAsync<GetServerStrategiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationComponents

        internal virtual ListApplicationComponentsResponse ListApplicationComponents(ListApplicationComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationComponentsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationComponentsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of all the application components (processes).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationComponents service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ServiceLinkedRoleLockClientException">
        /// Exception to indicate that the service-linked role (SLR) is locked.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListApplicationComponents">REST API Reference for ListApplicationComponents Operation</seealso>
        public virtual Task<ListApplicationComponentsResponse> ListApplicationComponentsAsync(ListApplicationComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationComponentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationComponentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCollectors

        internal virtual ListCollectorsResponse ListCollectors(ListCollectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectorsResponseUnmarshaller.Instance;

            return Invoke<ListCollectorsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of all the installed collectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollectors service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListCollectors">REST API Reference for ListCollectors Operation</seealso>
        public virtual Task<ListCollectorsResponse> ListCollectorsAsync(ListCollectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImportFileTask

        internal virtual ListImportFileTaskResponse ListImportFileTask(ListImportFileTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportFileTaskResponseUnmarshaller.Instance;

            return Invoke<ListImportFileTaskResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of all the imports performed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportFileTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportFileTask service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListImportFileTask">REST API Reference for ListImportFileTask Operation</seealso>
        public virtual Task<ListImportFileTaskResponse> ListImportFileTaskAsync(ListImportFileTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportFileTaskResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportFileTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServers

        internal virtual ListServersResponse ListServers(ListServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServersResponseUnmarshaller.Instance;

            return Invoke<ListServersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServers service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListServers">REST API Reference for ListServers Operation</seealso>
        public virtual Task<ListServersResponse> ListServersAsync(ListServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServersResponseUnmarshaller.Instance;

            return InvokeAsync<ListServersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPortfolioPreferences

        internal virtual PutPortfolioPreferencesResponse PutPortfolioPreferences(PutPortfolioPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPortfolioPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPortfolioPreferencesResponseUnmarshaller.Instance;

            return Invoke<PutPortfolioPreferencesResponse>(request, options);
        }



        /// <summary>
        /// Saves the specified migration and modernization preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPortfolioPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPortfolioPreferences service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ConflictException">
        /// Exception to indicate that there is an ongoing task when a new task is created. Return
        /// when once the existing tasks are complete.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/PutPortfolioPreferences">REST API Reference for PutPortfolioPreferences Operation</seealso>
        public virtual Task<PutPortfolioPreferencesResponse> PutPortfolioPreferencesAsync(PutPortfolioPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPortfolioPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPortfolioPreferencesResponseUnmarshaller.Instance;

            return InvokeAsync<PutPortfolioPreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAssessment

        internal virtual StartAssessmentResponse StartAssessment(StartAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Starts the assessment of an on-premises environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAssessment service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ServiceQuotaExceededException">
        /// The AWS account has reached its quota of imports. Contact AWS Support to increase
        /// the quota for this account.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartAssessment">REST API Reference for StartAssessment Operation</seealso>
        public virtual Task<StartAssessmentResponse> StartAssessmentAsync(StartAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<StartAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartImportFileTask

        internal virtual StartImportFileTaskResponse StartImportFileTask(StartImportFileTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportFileTaskResponseUnmarshaller.Instance;

            return Invoke<StartImportFileTaskResponse>(request, options);
        }



        /// <summary>
        /// Starts a file import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportFileTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImportFileTask service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ServiceQuotaExceededException">
        /// The AWS account has reached its quota of imports. Contact AWS Support to increase
        /// the quota for this account.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartImportFileTask">REST API Reference for StartImportFileTask Operation</seealso>
        public virtual Task<StartImportFileTaskResponse> StartImportFileTaskAsync(StartImportFileTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportFileTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartImportFileTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartRecommendationReportGeneration

        internal virtual StartRecommendationReportGenerationResponse StartRecommendationReportGeneration(StartRecommendationReportGenerationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRecommendationReportGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecommendationReportGenerationResponseUnmarshaller.Instance;

            return Invoke<StartRecommendationReportGenerationResponse>(request, options);
        }



        /// <summary>
        /// Starts generating a recommendation report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecommendationReportGeneration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRecommendationReportGeneration service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ConflictException">
        /// Exception to indicate that there is an ongoing task when a new task is created. Return
        /// when once the existing tasks are complete.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartRecommendationReportGeneration">REST API Reference for StartRecommendationReportGeneration Operation</seealso>
        public virtual Task<StartRecommendationReportGenerationResponse> StartRecommendationReportGenerationAsync(StartRecommendationReportGenerationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRecommendationReportGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecommendationReportGenerationResponseUnmarshaller.Instance;

            return InvokeAsync<StartRecommendationReportGenerationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopAssessment

        internal virtual StopAssessmentResponse StopAssessment(StopAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentResponseUnmarshaller.Instance;

            return Invoke<StopAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Stops the assessment of an on-premises environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopAssessment service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StopAssessment">REST API Reference for StopAssessment Operation</seealso>
        public virtual Task<StopAssessmentResponse> StopAssessmentAsync(StopAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<StopAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplicationComponentConfig

        internal virtual UpdateApplicationComponentConfigResponse UpdateApplicationComponentConfig(UpdateApplicationComponentConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationComponentConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationComponentConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationComponentConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an application component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationComponentConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplicationComponentConfig service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateApplicationComponentConfig">REST API Reference for UpdateApplicationComponentConfig Operation</seealso>
        public virtual Task<UpdateApplicationComponentConfigResponse> UpdateApplicationComponentConfigAsync(UpdateApplicationComponentConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationComponentConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationComponentConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationComponentConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServerConfig

        internal virtual UpdateServerConfigResponse UpdateServerConfig(UpdateServerConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateServerConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of the specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServerConfig service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateServerConfig">REST API Reference for UpdateServerConfig Operation</seealso>
        public virtual Task<UpdateServerConfigResponse> UpdateServerConfigAsync(UpdateServerConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServerConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}