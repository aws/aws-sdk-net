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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.TrustedAdvisor.Model;
using Amazon.TrustedAdvisor.Model.Internal.MarshallTransformations;
using Amazon.TrustedAdvisor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.TrustedAdvisor
{
    /// <summary>
    /// <para>Implementation for accessing TrustedAdvisor</para>
    ///
    /// TrustedAdvisor Public API
    /// </summary>
    public partial class AmazonTrustedAdvisorClient : AmazonServiceClient, IAmazonTrustedAdvisor
    {
        private static IServiceMetadata serviceMetadata = new AmazonTrustedAdvisorMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ITrustedAdvisorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITrustedAdvisorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TrustedAdvisorPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with the credentials loaded from the application's
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
        public AmazonTrustedAdvisorClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTrustedAdvisorConfig()) { }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with the credentials loaded from the application's
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
        public AmazonTrustedAdvisorClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTrustedAdvisorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTrustedAdvisorClient Configuration Object</param>
        public AmazonTrustedAdvisorClient(AmazonTrustedAdvisorConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTrustedAdvisorClient(AWSCredentials credentials)
            : this(credentials, new AmazonTrustedAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTrustedAdvisorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTrustedAdvisorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Credentials and an
        /// AmazonTrustedAdvisorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTrustedAdvisorClient Configuration Object</param>
        public AmazonTrustedAdvisorClient(AWSCredentials credentials, AmazonTrustedAdvisorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTrustedAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTrustedAdvisorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTrustedAdvisorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTrustedAdvisorClient Configuration Object</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTrustedAdvisorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTrustedAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTrustedAdvisorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTrustedAdvisorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTrustedAdvisorClient Configuration Object</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTrustedAdvisorConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTrustedAdvisorEndpointResolver());
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


        #region  BatchUpdateRecommendationResourceExclusion

        /// <summary>
        /// Update one or more exclusion status for a list of recommendation resources
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRecommendationResourceExclusion service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateRecommendationResourceExclusion service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/BatchUpdateRecommendationResourceExclusion">REST API Reference for BatchUpdateRecommendationResourceExclusion Operation</seealso>
        public virtual BatchUpdateRecommendationResourceExclusionResponse BatchUpdateRecommendationResourceExclusion(BatchUpdateRecommendationResourceExclusionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateRecommendationResourceExclusionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateRecommendationResourceExclusionResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateRecommendationResourceExclusionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateRecommendationResourceExclusion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRecommendationResourceExclusion operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateRecommendationResourceExclusion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/BatchUpdateRecommendationResourceExclusion">REST API Reference for BatchUpdateRecommendationResourceExclusion Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateRecommendationResourceExclusion(BatchUpdateRecommendationResourceExclusionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateRecommendationResourceExclusionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateRecommendationResourceExclusionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateRecommendationResourceExclusion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateRecommendationResourceExclusion.</param>
        /// 
        /// <returns>Returns a  BatchUpdateRecommendationResourceExclusionResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/BatchUpdateRecommendationResourceExclusion">REST API Reference for BatchUpdateRecommendationResourceExclusion Operation</seealso>
        public virtual BatchUpdateRecommendationResourceExclusionResponse EndBatchUpdateRecommendationResourceExclusion(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateRecommendationResourceExclusionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOrganizationRecommendation

        /// <summary>
        /// Get a specific recommendation within an AWS Organizations organization. This API supports
        /// only prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationRecommendation service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetOrganizationRecommendation">REST API Reference for GetOrganizationRecommendation Operation</seealso>
        public virtual GetOrganizationRecommendationResponse GetOrganizationRecommendation(GetOrganizationRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOrganizationRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetOrganizationRecommendationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOrganizationRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationRecommendation operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOrganizationRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetOrganizationRecommendation">REST API Reference for GetOrganizationRecommendation Operation</seealso>
        public virtual IAsyncResult BeginGetOrganizationRecommendation(GetOrganizationRecommendationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOrganizationRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationRecommendationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOrganizationRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOrganizationRecommendation.</param>
        /// 
        /// <returns>Returns a  GetOrganizationRecommendationResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetOrganizationRecommendation">REST API Reference for GetOrganizationRecommendation Operation</seealso>
        public virtual GetOrganizationRecommendationResponse EndGetOrganizationRecommendation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOrganizationRecommendationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecommendation

        /// <summary>
        /// Get a specific Recommendation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        public virtual GetRecommendationResponse GetRecommendation(GetRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        public virtual IAsyncResult BeginGetRecommendation(GetRecommendationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendation.</param>
        /// 
        /// <returns>Returns a  GetRecommendationResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        public virtual GetRecommendationResponse EndGetRecommendation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecommendationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChecks

        /// <summary>
        /// List a filterable set of Checks
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChecks service method.</param>
        /// 
        /// <returns>The response from the ListChecks service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListChecks">REST API Reference for ListChecks Operation</seealso>
        public virtual ListChecksResponse ListChecks(ListChecksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChecksResponseUnmarshaller.Instance;

            return Invoke<ListChecksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChecks operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChecks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListChecks">REST API Reference for ListChecks Operation</seealso>
        public virtual IAsyncResult BeginListChecks(ListChecksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChecksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChecks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChecks.</param>
        /// 
        /// <returns>Returns a  ListChecksResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListChecks">REST API Reference for ListChecks Operation</seealso>
        public virtual ListChecksResponse EndListChecks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChecksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOrganizationRecommendationAccounts

        /// <summary>
        /// Lists the accounts that own the resources for an organization aggregate recommendation.
        /// This API only supports prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationAccounts service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendationAccounts service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationAccounts">REST API Reference for ListOrganizationRecommendationAccounts Operation</seealso>
        public virtual ListOrganizationRecommendationAccountsResponse ListOrganizationRecommendationAccounts(ListOrganizationRecommendationAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationAccountsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationRecommendationAccountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationRecommendationAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationAccounts operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationRecommendationAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationAccounts">REST API Reference for ListOrganizationRecommendationAccounts Operation</seealso>
        public virtual IAsyncResult BeginListOrganizationRecommendationAccounts(ListOrganizationRecommendationAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationRecommendationAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationRecommendationAccounts.</param>
        /// 
        /// <returns>Returns a  ListOrganizationRecommendationAccountsResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationAccounts">REST API Reference for ListOrganizationRecommendationAccounts Operation</seealso>
        public virtual ListOrganizationRecommendationAccountsResponse EndListOrganizationRecommendationAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOrganizationRecommendationAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOrganizationRecommendationResources

        /// <summary>
        /// List Resources of a Recommendation within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationResources service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendationResources service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationResources">REST API Reference for ListOrganizationRecommendationResources Operation</seealso>
        public virtual ListOrganizationRecommendationResourcesResponse ListOrganizationRecommendationResources(ListOrganizationRecommendationResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationResourcesResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationRecommendationResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationRecommendationResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationResources operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationRecommendationResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationResources">REST API Reference for ListOrganizationRecommendationResources Operation</seealso>
        public virtual IAsyncResult BeginListOrganizationRecommendationResources(ListOrganizationRecommendationResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationRecommendationResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationRecommendationResources.</param>
        /// 
        /// <returns>Returns a  ListOrganizationRecommendationResourcesResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationResources">REST API Reference for ListOrganizationRecommendationResources Operation</seealso>
        public virtual ListOrganizationRecommendationResourcesResponse EndListOrganizationRecommendationResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOrganizationRecommendationResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOrganizationRecommendations

        /// <summary>
        /// List a filterable set of Recommendations within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendations service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendations">REST API Reference for ListOrganizationRecommendations Operation</seealso>
        public virtual ListOrganizationRecommendationsResponse ListOrganizationRecommendations(ListOrganizationRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendations operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendations">REST API Reference for ListOrganizationRecommendations Operation</seealso>
        public virtual IAsyncResult BeginListOrganizationRecommendations(ListOrganizationRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationRecommendations.</param>
        /// 
        /// <returns>Returns a  ListOrganizationRecommendationsResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendations">REST API Reference for ListOrganizationRecommendations Operation</seealso>
        public virtual ListOrganizationRecommendationsResponse EndListOrganizationRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOrganizationRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecommendationResources

        /// <summary>
        /// List Resources of a Recommendation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationResources service method.</param>
        /// 
        /// <returns>The response from the ListRecommendationResources service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendationResources">REST API Reference for ListRecommendationResources Operation</seealso>
        public virtual ListRecommendationResourcesResponse ListRecommendationResources(ListRecommendationResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationResourcesResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendationResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationResources operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendationResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendationResources">REST API Reference for ListRecommendationResources Operation</seealso>
        public virtual IAsyncResult BeginListRecommendationResources(ListRecommendationResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendationResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendationResources.</param>
        /// 
        /// <returns>Returns a  ListRecommendationResourcesResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendationResources">REST API Reference for ListRecommendationResources Operation</seealso>
        public virtual ListRecommendationResourcesResponse EndListRecommendationResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecommendationResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecommendations

        /// <summary>
        /// List a filterable set of Recommendations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual IAsyncResult BeginListRecommendations(ListRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendations.</param>
        /// 
        /// <returns>Returns a  ListRecommendationsResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual ListRecommendationsResponse EndListRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateOrganizationRecommendationLifecycle

        /// <summary>
        /// Update the lifecycle of a Recommendation within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationRecommendationLifecycle service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationRecommendationLifecycle service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateOrganizationRecommendationLifecycle">REST API Reference for UpdateOrganizationRecommendationLifecycle Operation</seealso>
        public virtual UpdateOrganizationRecommendationLifecycleResponse UpdateOrganizationRecommendationLifecycle(UpdateOrganizationRecommendationLifecycleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationRecommendationLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationRecommendationLifecycleResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationRecommendationLifecycleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOrganizationRecommendationLifecycle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationRecommendationLifecycle operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOrganizationRecommendationLifecycle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateOrganizationRecommendationLifecycle">REST API Reference for UpdateOrganizationRecommendationLifecycle Operation</seealso>
        public virtual IAsyncResult BeginUpdateOrganizationRecommendationLifecycle(UpdateOrganizationRecommendationLifecycleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationRecommendationLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationRecommendationLifecycleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOrganizationRecommendationLifecycle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOrganizationRecommendationLifecycle.</param>
        /// 
        /// <returns>Returns a  UpdateOrganizationRecommendationLifecycleResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateOrganizationRecommendationLifecycle">REST API Reference for UpdateOrganizationRecommendationLifecycle Operation</seealso>
        public virtual UpdateOrganizationRecommendationLifecycleResponse EndUpdateOrganizationRecommendationLifecycle(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOrganizationRecommendationLifecycleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRecommendationLifecycle

        /// <summary>
        /// Update the lifecyle of a Recommendation. This API only supports prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommendationLifecycle service method.</param>
        /// 
        /// <returns>The response from the UpdateRecommendationLifecycle service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateRecommendationLifecycle">REST API Reference for UpdateRecommendationLifecycle Operation</seealso>
        public virtual UpdateRecommendationLifecycleResponse UpdateRecommendationLifecycle(UpdateRecommendationLifecycleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecommendationLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecommendationLifecycleResponseUnmarshaller.Instance;

            return Invoke<UpdateRecommendationLifecycleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecommendationLifecycle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommendationLifecycle operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecommendationLifecycle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateRecommendationLifecycle">REST API Reference for UpdateRecommendationLifecycle Operation</seealso>
        public virtual IAsyncResult BeginUpdateRecommendationLifecycle(UpdateRecommendationLifecycleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecommendationLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecommendationLifecycleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecommendationLifecycle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecommendationLifecycle.</param>
        /// 
        /// <returns>Returns a  UpdateRecommendationLifecycleResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateRecommendationLifecycle">REST API Reference for UpdateRecommendationLifecycle Operation</seealso>
        public virtual UpdateRecommendationLifecycleResponse EndUpdateRecommendationLifecycle(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRecommendationLifecycleResponse>(asyncResult);
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
            var resolver = new AmazonTrustedAdvisorEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}