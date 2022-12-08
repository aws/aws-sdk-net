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
    /// 
    ///  <pre><code> &lt;p&gt;This API reference provides descriptions, syntax, and other
    /// details about each of the actions and data types for Migration Hub Strategy Recommendations
    /// (Strategy Recommendations). The topic for each action shows the API request parameters
    /// and the response. Alternatively, you can use one of the AWS SDKs to access an API
    /// that is tailored to the programming language or platform that you're using. For more
    /// information, see &lt;a href=&quot;http://aws.amazon.com/tools/#SDKs&quot;&gt;AWS SDKs&lt;/a&gt;.&lt;/p&gt;
    /// </code></pre>
    /// </summary>
    public partial class AmazonMigrationHubStrategyRecommendationsClient : AmazonServiceClient, IAmazonMigrationHubStrategyRecommendations
    {
        private static IServiceMetadata serviceMetadata = new AmazonMigrationHubStrategyRecommendationsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        /// <summary>
        /// Retrieves details about an application component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentDetails service method.</param>
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
        public virtual GetApplicationComponentDetailsResponse GetApplicationComponentDetails(GetApplicationComponentDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationComponentDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationComponentDetailsResponseUnmarshaller.Instance;

            return Invoke<GetApplicationComponentDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationComponentDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentDetails operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationComponentDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentDetails">REST API Reference for GetApplicationComponentDetails Operation</seealso>
        public virtual IAsyncResult BeginGetApplicationComponentDetails(GetApplicationComponentDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationComponentDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationComponentDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationComponentDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationComponentDetails.</param>
        /// 
        /// <returns>Returns a  GetApplicationComponentDetailsResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentDetails">REST API Reference for GetApplicationComponentDetails Operation</seealso>
        public virtual GetApplicationComponentDetailsResponse EndGetApplicationComponentDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationComponentDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationComponentStrategies

        /// <summary>
        /// Retrieves a list of all the recommended strategies and tools for an application component
        /// running on a server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentStrategies service method.</param>
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
        public virtual GetApplicationComponentStrategiesResponse GetApplicationComponentStrategies(GetApplicationComponentStrategiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationComponentStrategiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationComponentStrategiesResponseUnmarshaller.Instance;

            return Invoke<GetApplicationComponentStrategiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationComponentStrategies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentStrategies operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationComponentStrategies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentStrategies">REST API Reference for GetApplicationComponentStrategies Operation</seealso>
        public virtual IAsyncResult BeginGetApplicationComponentStrategies(GetApplicationComponentStrategiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationComponentStrategiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationComponentStrategiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationComponentStrategies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationComponentStrategies.</param>
        /// 
        /// <returns>Returns a  GetApplicationComponentStrategiesResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentStrategies">REST API Reference for GetApplicationComponentStrategies Operation</seealso>
        public virtual GetApplicationComponentStrategiesResponse EndGetApplicationComponentStrategies(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationComponentStrategiesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssessment

        /// <summary>
        /// Retrieves the status of an on-going assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment service method.</param>
        /// 
        /// <returns>The response from the GetAssessment service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual GetAssessmentResponse GetAssessment(GetAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        public virtual IAsyncResult BeginGetAssessment(GetAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessment.</param>
        /// 
        /// <returns>Returns a  GetAssessmentResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        public virtual GetAssessmentResponse EndGetAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImportFileTask

        /// <summary>
        /// Retrieves the details about a specific import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportFileTask service method.</param>
        /// 
        /// <returns>The response from the GetImportFileTask service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual GetImportFileTaskResponse GetImportFileTask(GetImportFileTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportFileTaskResponseUnmarshaller.Instance;

            return Invoke<GetImportFileTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportFileTask operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportFileTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetImportFileTask">REST API Reference for GetImportFileTask Operation</seealso>
        public virtual IAsyncResult BeginGetImportFileTask(GetImportFileTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportFileTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportFileTask.</param>
        /// 
        /// <returns>Returns a  GetImportFileTaskResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetImportFileTask">REST API Reference for GetImportFileTask Operation</seealso>
        public virtual GetImportFileTaskResponse EndGetImportFileTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImportFileTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLatestAssessmentId

        /// <summary>
        /// Retrieve the latest ID of a specific assessment task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLatestAssessmentId service method.</param>
        /// 
        /// <returns>The response from the GetLatestAssessmentId service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual GetLatestAssessmentIdResponse GetLatestAssessmentId(GetLatestAssessmentIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLatestAssessmentIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLatestAssessmentIdResponseUnmarshaller.Instance;

            return Invoke<GetLatestAssessmentIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLatestAssessmentId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLatestAssessmentId operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLatestAssessmentId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetLatestAssessmentId">REST API Reference for GetLatestAssessmentId Operation</seealso>
        public virtual IAsyncResult BeginGetLatestAssessmentId(GetLatestAssessmentIdRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLatestAssessmentIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLatestAssessmentIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLatestAssessmentId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLatestAssessmentId.</param>
        /// 
        /// <returns>Returns a  GetLatestAssessmentIdResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetLatestAssessmentId">REST API Reference for GetLatestAssessmentId Operation</seealso>
        public virtual GetLatestAssessmentIdResponse EndGetLatestAssessmentId(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLatestAssessmentIdResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPortfolioPreferences

        /// <summary>
        /// Retrieves your migration and modernization preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioPreferences service method.</param>
        /// 
        /// <returns>The response from the GetPortfolioPreferences service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual GetPortfolioPreferencesResponse GetPortfolioPreferences(GetPortfolioPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortfolioPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortfolioPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetPortfolioPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortfolioPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioPreferences operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortfolioPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioPreferences">REST API Reference for GetPortfolioPreferences Operation</seealso>
        public virtual IAsyncResult BeginGetPortfolioPreferences(GetPortfolioPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortfolioPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortfolioPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortfolioPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortfolioPreferences.</param>
        /// 
        /// <returns>Returns a  GetPortfolioPreferencesResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioPreferences">REST API Reference for GetPortfolioPreferences Operation</seealso>
        public virtual GetPortfolioPreferencesResponse EndGetPortfolioPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPortfolioPreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPortfolioSummary

        /// <summary>
        /// Retrieves overall summary including the number of servers to rehost and the overall
        /// number of anti-patterns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioSummary service method.</param>
        /// 
        /// <returns>The response from the GetPortfolioSummary service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioSummary">REST API Reference for GetPortfolioSummary Operation</seealso>
        public virtual GetPortfolioSummaryResponse GetPortfolioSummary(GetPortfolioSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortfolioSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortfolioSummaryResponseUnmarshaller.Instance;

            return Invoke<GetPortfolioSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortfolioSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioSummary operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortfolioSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioSummary">REST API Reference for GetPortfolioSummary Operation</seealso>
        public virtual IAsyncResult BeginGetPortfolioSummary(GetPortfolioSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortfolioSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortfolioSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortfolioSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortfolioSummary.</param>
        /// 
        /// <returns>Returns a  GetPortfolioSummaryResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioSummary">REST API Reference for GetPortfolioSummary Operation</seealso>
        public virtual GetPortfolioSummaryResponse EndGetPortfolioSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPortfolioSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecommendationReportDetails

        /// <summary>
        /// Retrieves detailed information about the specified recommendation report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationReportDetails service method.</param>
        /// 
        /// <returns>The response from the GetRecommendationReportDetails service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual GetRecommendationReportDetailsResponse GetRecommendationReportDetails(GetRecommendationReportDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationReportDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationReportDetailsResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationReportDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendationReportDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationReportDetails operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendationReportDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetRecommendationReportDetails">REST API Reference for GetRecommendationReportDetails Operation</seealso>
        public virtual IAsyncResult BeginGetRecommendationReportDetails(GetRecommendationReportDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationReportDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationReportDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendationReportDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendationReportDetails.</param>
        /// 
        /// <returns>Returns a  GetRecommendationReportDetailsResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetRecommendationReportDetails">REST API Reference for GetRecommendationReportDetails Operation</seealso>
        public virtual GetRecommendationReportDetailsResponse EndGetRecommendationReportDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecommendationReportDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServerDetails

        /// <summary>
        /// Retrieves detailed information about a specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerDetails service method.</param>
        /// 
        /// <returns>The response from the GetServerDetails service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual GetServerDetailsResponse GetServerDetails(GetServerDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerDetailsResponseUnmarshaller.Instance;

            return Invoke<GetServerDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerDetails operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServerDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerDetails">REST API Reference for GetServerDetails Operation</seealso>
        public virtual IAsyncResult BeginGetServerDetails(GetServerDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServerDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServerDetails.</param>
        /// 
        /// <returns>Returns a  GetServerDetailsResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerDetails">REST API Reference for GetServerDetails Operation</seealso>
        public virtual GetServerDetailsResponse EndGetServerDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServerDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServerStrategies

        /// <summary>
        /// Retrieves recommended strategies and tools for the specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerStrategies service method.</param>
        /// 
        /// <returns>The response from the GetServerStrategies service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual GetServerStrategiesResponse GetServerStrategies(GetServerStrategiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerStrategiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerStrategiesResponseUnmarshaller.Instance;

            return Invoke<GetServerStrategiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerStrategies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerStrategies operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServerStrategies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerStrategies">REST API Reference for GetServerStrategies Operation</seealso>
        public virtual IAsyncResult BeginGetServerStrategies(GetServerStrategiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerStrategiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerStrategiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServerStrategies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServerStrategies.</param>
        /// 
        /// <returns>Returns a  GetServerStrategiesResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerStrategies">REST API Reference for GetServerStrategies Operation</seealso>
        public virtual GetServerStrategiesResponse EndGetServerStrategies(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServerStrategiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationComponents

        /// <summary>
        /// Retrieves a list of all the application components (processes).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationComponents service method.</param>
        /// 
        /// <returns>The response from the ListApplicationComponents service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual ListApplicationComponentsResponse ListApplicationComponents(ListApplicationComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationComponentsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationComponents operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListApplicationComponents">REST API Reference for ListApplicationComponents Operation</seealso>
        public virtual IAsyncResult BeginListApplicationComponents(ListApplicationComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationComponents.</param>
        /// 
        /// <returns>Returns a  ListApplicationComponentsResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListApplicationComponents">REST API Reference for ListApplicationComponents Operation</seealso>
        public virtual ListApplicationComponentsResponse EndListApplicationComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollectors

        /// <summary>
        /// Retrieves a list of all the installed collectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollectors service method.</param>
        /// 
        /// <returns>The response from the ListCollectors service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual ListCollectorsResponse ListCollectors(ListCollectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectorsResponseUnmarshaller.Instance;

            return Invoke<ListCollectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollectors operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListCollectors">REST API Reference for ListCollectors Operation</seealso>
        public virtual IAsyncResult BeginListCollectors(ListCollectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollectors.</param>
        /// 
        /// <returns>Returns a  ListCollectorsResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListCollectors">REST API Reference for ListCollectors Operation</seealso>
        public virtual ListCollectorsResponse EndListCollectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImportFileTask

        /// <summary>
        /// Retrieves a list of all the imports performed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportFileTask service method.</param>
        /// 
        /// <returns>The response from the ListImportFileTask service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual ListImportFileTaskResponse ListImportFileTask(ListImportFileTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportFileTaskResponseUnmarshaller.Instance;

            return Invoke<ListImportFileTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImportFileTask operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImportFileTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListImportFileTask">REST API Reference for ListImportFileTask Operation</seealso>
        public virtual IAsyncResult BeginListImportFileTask(ListImportFileTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportFileTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImportFileTask.</param>
        /// 
        /// <returns>Returns a  ListImportFileTaskResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListImportFileTask">REST API Reference for ListImportFileTask Operation</seealso>
        public virtual ListImportFileTaskResponse EndListImportFileTask(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImportFileTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServers

        /// <summary>
        /// Returns a list of all the servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServers service method.</param>
        /// 
        /// <returns>The response from the ListServers service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual ListServersResponse ListServers(ListServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServersResponseUnmarshaller.Instance;

            return Invoke<ListServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServers operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListServers">REST API Reference for ListServers Operation</seealso>
        public virtual IAsyncResult BeginListServers(ListServersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServers.</param>
        /// 
        /// <returns>Returns a  ListServersResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListServers">REST API Reference for ListServers Operation</seealso>
        public virtual ListServersResponse EndListServers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServersResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPortfolioPreferences

        /// <summary>
        /// Saves the specified migration and modernization preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPortfolioPreferences service method.</param>
        /// 
        /// <returns>The response from the PutPortfolioPreferences service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual PutPortfolioPreferencesResponse PutPortfolioPreferences(PutPortfolioPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPortfolioPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPortfolioPreferencesResponseUnmarshaller.Instance;

            return Invoke<PutPortfolioPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPortfolioPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPortfolioPreferences operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPortfolioPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/PutPortfolioPreferences">REST API Reference for PutPortfolioPreferences Operation</seealso>
        public virtual IAsyncResult BeginPutPortfolioPreferences(PutPortfolioPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPortfolioPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPortfolioPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPortfolioPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPortfolioPreferences.</param>
        /// 
        /// <returns>Returns a  PutPortfolioPreferencesResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/PutPortfolioPreferences">REST API Reference for PutPortfolioPreferences Operation</seealso>
        public virtual PutPortfolioPreferencesResponse EndPutPortfolioPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPortfolioPreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAssessment

        /// <summary>
        /// Starts the assessment of an on-premises environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessment service method.</param>
        /// 
        /// <returns>The response from the StartAssessment service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual StartAssessmentResponse StartAssessment(StartAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAssessment operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartAssessment">REST API Reference for StartAssessment Operation</seealso>
        public virtual IAsyncResult BeginStartAssessment(StartAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAssessment.</param>
        /// 
        /// <returns>Returns a  StartAssessmentResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartAssessment">REST API Reference for StartAssessment Operation</seealso>
        public virtual StartAssessmentResponse EndStartAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  StartImportFileTask

        /// <summary>
        /// Starts a file import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportFileTask service method.</param>
        /// 
        /// <returns>The response from the StartImportFileTask service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual StartImportFileTaskResponse StartImportFileTask(StartImportFileTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportFileTaskResponseUnmarshaller.Instance;

            return Invoke<StartImportFileTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImportFileTask operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImportFileTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartImportFileTask">REST API Reference for StartImportFileTask Operation</seealso>
        public virtual IAsyncResult BeginStartImportFileTask(StartImportFileTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportFileTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportFileTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImportFileTask.</param>
        /// 
        /// <returns>Returns a  StartImportFileTaskResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartImportFileTask">REST API Reference for StartImportFileTask Operation</seealso>
        public virtual StartImportFileTaskResponse EndStartImportFileTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartImportFileTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StartRecommendationReportGeneration

        /// <summary>
        /// Starts generating a recommendation report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecommendationReportGeneration service method.</param>
        /// 
        /// <returns>The response from the StartRecommendationReportGeneration service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual StartRecommendationReportGenerationResponse StartRecommendationReportGeneration(StartRecommendationReportGenerationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRecommendationReportGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecommendationReportGenerationResponseUnmarshaller.Instance;

            return Invoke<StartRecommendationReportGenerationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRecommendationReportGeneration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRecommendationReportGeneration operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRecommendationReportGeneration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartRecommendationReportGeneration">REST API Reference for StartRecommendationReportGeneration Operation</seealso>
        public virtual IAsyncResult BeginStartRecommendationReportGeneration(StartRecommendationReportGenerationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRecommendationReportGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecommendationReportGenerationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartRecommendationReportGeneration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRecommendationReportGeneration.</param>
        /// 
        /// <returns>Returns a  StartRecommendationReportGenerationResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartRecommendationReportGeneration">REST API Reference for StartRecommendationReportGeneration Operation</seealso>
        public virtual StartRecommendationReportGenerationResponse EndStartRecommendationReportGeneration(IAsyncResult asyncResult)
        {
            return EndInvoke<StartRecommendationReportGenerationResponse>(asyncResult);
        }

        #endregion
        
        #region  StopAssessment

        /// <summary>
        /// Stops the assessment of an on-premises environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAssessment service method.</param>
        /// 
        /// <returns>The response from the StopAssessment service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The AWS user account does not have permission to perform the action. Check the AWS
        /// Identity and Access Management (IAM) policy associated with this account.
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
        public virtual StopAssessmentResponse StopAssessment(StopAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentResponseUnmarshaller.Instance;

            return Invoke<StopAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAssessment operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StopAssessment">REST API Reference for StopAssessment Operation</seealso>
        public virtual IAsyncResult BeginStopAssessment(StopAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopAssessment.</param>
        /// 
        /// <returns>Returns a  StopAssessmentResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StopAssessment">REST API Reference for StopAssessment Operation</seealso>
        public virtual StopAssessmentResponse EndStopAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<StopAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplicationComponentConfig

        /// <summary>
        /// Updates the configuration of an application component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationComponentConfig service method.</param>
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
        public virtual UpdateApplicationComponentConfigResponse UpdateApplicationComponentConfig(UpdateApplicationComponentConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationComponentConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationComponentConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationComponentConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationComponentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationComponentConfig operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationComponentConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateApplicationComponentConfig">REST API Reference for UpdateApplicationComponentConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplicationComponentConfig(UpdateApplicationComponentConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationComponentConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationComponentConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationComponentConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationComponentConfig.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationComponentConfigResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateApplicationComponentConfig">REST API Reference for UpdateApplicationComponentConfig Operation</seealso>
        public virtual UpdateApplicationComponentConfigResponse EndUpdateApplicationComponentConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationComponentConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServerConfig

        /// <summary>
        /// Updates the configuration of the specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerConfig service method.</param>
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
        public virtual UpdateServerConfigResponse UpdateServerConfig(UpdateServerConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateServerConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerConfig operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServerConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateServerConfig">REST API Reference for UpdateServerConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateServerConfig(UpdateServerConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServerConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServerConfig.</param>
        /// 
        /// <returns>Returns a  UpdateServerConfigResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateServerConfig">REST API Reference for UpdateServerConfig Operation</seealso>
        public virtual UpdateServerConfigResponse EndUpdateServerConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServerConfigResponse>(asyncResult);
        }

        #endregion
        
    }
}