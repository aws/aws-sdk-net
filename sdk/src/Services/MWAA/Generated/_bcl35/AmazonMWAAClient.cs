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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.MWAA.Model;
using Amazon.MWAA.Model.Internal.MarshallTransformations;
using Amazon.MWAA.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MWAA
{
    /// <summary>
    /// Implementation for accessing MWAA
    ///
    /// Amazon Managed Workflows for Apache Airflow 
    /// <para>
    /// This section contains the Amazon Managed Workflows for Apache Airflow (MWAA) API reference
    /// documentation. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/what-is-mwaa.html">What
    /// Is Amazon MWAA?</a>.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonMWAAClient : AmazonServiceClient, IAmazonMWAA
    {
        private static IServiceMetadata serviceMetadata = new AmazonMWAAMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonMWAAClient with the credentials loaded from the application's
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
        public AmazonMWAAClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMWAAConfig()) { }

        /// <summary>
        /// Constructs AmazonMWAAClient with the credentials loaded from the application's
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
        public AmazonMWAAClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMWAAConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMWAAClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMWAAClient Configuration Object</param>
        public AmazonMWAAClient(AmazonMWAAConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMWAAClient(AWSCredentials credentials)
            : this(credentials, new AmazonMWAAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMWAAClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMWAAConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Credentials and an
        /// AmazonMWAAClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMWAAClient Configuration Object</param>
        public AmazonMWAAClient(AWSCredentials credentials, AmazonMWAAConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMWAAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMWAAConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMWAAClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMWAAClient Configuration Object</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMWAAConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMWAAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMWAAConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMWAAClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMWAAClient Configuration Object</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMWAAConfig clientConfig)
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


        #region  CreateCliToken

        /// <summary>
        /// Create a CLI token to use Airflow CLI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCliToken service method.</param>
        /// 
        /// <returns>The response from the CreateCliToken service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateCliToken">REST API Reference for CreateCliToken Operation</seealso>
        public virtual CreateCliTokenResponse CreateCliToken(CreateCliTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCliTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCliTokenResponseUnmarshaller.Instance;

            return Invoke<CreateCliTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCliToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCliToken operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCliToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateCliToken">REST API Reference for CreateCliToken Operation</seealso>
        public virtual IAsyncResult BeginCreateCliToken(CreateCliTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCliTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCliTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCliToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCliToken.</param>
        /// 
        /// <returns>Returns a  CreateCliTokenResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateCliToken">REST API Reference for CreateCliToken Operation</seealso>
        public virtual CreateCliTokenResponse EndCreateCliToken(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCliTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEnvironment

        /// <summary>
        /// JSON blob that describes the environment to create.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWebLoginToken

        /// <summary>
        /// Create a JWT token to be used to login to Airflow Web UI with claims based Authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebLoginToken service method.</param>
        /// 
        /// <returns>The response from the CreateWebLoginToken service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.AccessDeniedException">
        /// Access to the Airflow Web UI or CLI has been Denied. Please follow the MWAA user guide
        /// to setup permissions to access the Web UI and CLI functionality.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateWebLoginToken">REST API Reference for CreateWebLoginToken Operation</seealso>
        public virtual CreateWebLoginTokenResponse CreateWebLoginToken(CreateWebLoginTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebLoginTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebLoginTokenResponseUnmarshaller.Instance;

            return Invoke<CreateWebLoginTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWebLoginToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWebLoginToken operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWebLoginToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateWebLoginToken">REST API Reference for CreateWebLoginToken Operation</seealso>
        public virtual IAsyncResult BeginCreateWebLoginToken(CreateWebLoginTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebLoginTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebLoginTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWebLoginToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWebLoginToken.</param>
        /// 
        /// <returns>Returns a  CreateWebLoginTokenResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateWebLoginToken">REST API Reference for CreateWebLoginToken Operation</seealso>
        public virtual CreateWebLoginTokenResponse EndCreateWebLoginToken(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWebLoginTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironment

        /// <summary>
        /// Delete an existing environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironment(DeleteEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse EndDeleteEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironment

        /// <summary>
        /// Get details of an existing environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironment(GetEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironment.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual GetEnvironmentResponse EndGetEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironments

        /// <summary>
        /// List Amazon MWAA Environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual IAsyncResult BeginListEnvironments(ListEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironments.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentsResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse EndListEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List the tags for MWAA environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PublishMetrics

        /// <summary>
        /// An operation for publishing metrics from the customers to the Ops plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishMetrics service method.</param>
        /// 
        /// <returns>The response from the PublishMetrics service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/PublishMetrics">REST API Reference for PublishMetrics Operation</seealso>
        public virtual PublishMetricsResponse PublishMetrics(PublishMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishMetricsResponseUnmarshaller.Instance;

            return Invoke<PublishMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PublishMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishMetrics operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/PublishMetrics">REST API Reference for PublishMetrics Operation</seealso>
        public virtual IAsyncResult BeginPublishMetrics(PublishMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PublishMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishMetrics.</param>
        /// 
        /// <returns>Returns a  PublishMetricsResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/PublishMetrics">REST API Reference for PublishMetrics Operation</seealso>
        public virtual PublishMetricsResponse EndPublishMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<PublishMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Add tag to the MWAA environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Remove a tag from the MWAA environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnvironment

        /// <summary>
        /// Update an MWAA environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation on AmazonMWAAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentResult from MWAA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
    }
}