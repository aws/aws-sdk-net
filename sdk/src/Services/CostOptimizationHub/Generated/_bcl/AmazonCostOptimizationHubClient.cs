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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CostOptimizationHub.Model;
using Amazon.CostOptimizationHub.Model.Internal.MarshallTransformations;
using Amazon.CostOptimizationHub.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CostOptimizationHub
{
    /// <summary>
    /// <para>Implementation for accessing CostOptimizationHub</para>
    ///
    /// You can use the Cost Optimization Hub API to programmatically identify, filter, aggregate,
    /// and quantify savings for your cost optimization recommendations across multiple Amazon
    /// Web Services Regions and Amazon Web Services accounts in your organization.
    /// 
    ///  
    /// <para>
    /// The Cost Optimization Hub API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  https://cost-optimization-hub.us-east-1.amazonaws.com 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCostOptimizationHubClient : AmazonServiceClient, IAmazonCostOptimizationHub
    {
        private static IServiceMetadata serviceMetadata = new AmazonCostOptimizationHubMetadata();
        private ICostOptimizationHubPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICostOptimizationHubPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CostOptimizationHubPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with the credentials loaded from the application's
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
        public AmazonCostOptimizationHubClient()
            : base(new AmazonCostOptimizationHubConfig()) { }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with the credentials loaded from the application's
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
        public AmazonCostOptimizationHubClient(RegionEndpoint region)
            : base(new AmazonCostOptimizationHubConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCostOptimizationHubClient Configuration Object</param>
        public AmazonCostOptimizationHubClient(AmazonCostOptimizationHubConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCostOptimizationHubClient(AWSCredentials credentials)
            : this(credentials, new AmazonCostOptimizationHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostOptimizationHubClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCostOptimizationHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with AWS Credentials and an
        /// AmazonCostOptimizationHubClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCostOptimizationHubClient Configuration Object</param>
        public AmazonCostOptimizationHubClient(AWSCredentials credentials, AmazonCostOptimizationHubConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCostOptimizationHubClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCostOptimizationHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostOptimizationHubClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCostOptimizationHubConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCostOptimizationHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCostOptimizationHubClient Configuration Object</param>
        public AmazonCostOptimizationHubClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCostOptimizationHubConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCostOptimizationHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCostOptimizationHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostOptimizationHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCostOptimizationHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostOptimizationHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCostOptimizationHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCostOptimizationHubClient Configuration Object</param>
        public AmazonCostOptimizationHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCostOptimizationHubConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCostOptimizationHubEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCostOptimizationHubAuthSchemeHandler());
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


        #region  GetPreferences


        /// <summary>
        /// Returns a set of preferences for an account in order to add account-specific preferences
        /// into the service. These preferences impact how the savings associated with recommendations
        /// are presented—estimated savings after discounts or estimated savings before discounts,
        /// for example.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreferences service method.</param>
        /// 
        /// <returns>The response from the GetPreferences service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/GetPreferences">REST API Reference for GetPreferences Operation</seealso>
        public virtual GetPreferencesResponse GetPreferences(GetPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetPreferencesResponse>(request, options);
        }


        /// <summary>
        /// Returns a set of preferences for an account in order to add account-specific preferences
        /// into the service. These preferences impact how the savings associated with recommendations
        /// are presented—estimated savings after discounts or estimated savings before discounts,
        /// for example.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPreferences service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/GetPreferences">REST API Reference for GetPreferences Operation</seealso>
        public virtual Task<GetPreferencesResponse> GetPreferencesAsync(GetPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPreferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRecommendation


        /// <summary>
        /// Returns both the current and recommended resource configuration and the estimated
        /// cost impact for a recommendation.
        /// 
        ///  
        /// <para>
        /// The <c>recommendationId</c> is only valid for up to a maximum of 24 hours as recommendations
        /// are refreshed daily. To retrieve the <c>recommendationId</c>, use the <c>ListRecommendations</c>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        public virtual GetRecommendationResponse GetRecommendation(GetRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationResponse>(request, options);
        }


        /// <summary>
        /// Returns both the current and recommended resource configuration and the estimated
        /// cost impact for a recommendation.
        /// 
        ///  
        /// <para>
        /// The <c>recommendationId</c> is only valid for up to a maximum of 24 hours as recommendations
        /// are refreshed daily. To retrieve the <c>recommendationId</c>, use the <c>ListRecommendations</c>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ResourceNotFoundException">
        /// The specified Amazon Resource Name (ARN) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        public virtual Task<GetRecommendationResponse> GetRecommendationAsync(GetRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRecommendationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnrollmentStatuses


        /// <summary>
        /// Retrieves the enrollment status for an account. It can also return the list of accounts
        /// that are enrolled under the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnrollmentStatuses service method.</param>
        /// 
        /// <returns>The response from the ListEnrollmentStatuses service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListEnrollmentStatuses">REST API Reference for ListEnrollmentStatuses Operation</seealso>
        public virtual ListEnrollmentStatusesResponse ListEnrollmentStatuses(ListEnrollmentStatusesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnrollmentStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnrollmentStatusesResponseUnmarshaller.Instance;

            return Invoke<ListEnrollmentStatusesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the enrollment status for an account. It can also return the list of accounts
        /// that are enrolled under the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnrollmentStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnrollmentStatuses service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListEnrollmentStatuses">REST API Reference for ListEnrollmentStatuses Operation</seealso>
        public virtual Task<ListEnrollmentStatusesResponse> ListEnrollmentStatusesAsync(ListEnrollmentStatusesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnrollmentStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnrollmentStatusesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEnrollmentStatusesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecommendations


        /// <summary>
        /// Returns a list of recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecommendationSummaries


        /// <summary>
        /// Returns a concise representation of savings estimates for resources. Also returns
        /// de-duped savings across different types of recommendations.
        /// 
        ///  <note> 
        /// <para>
        /// The following filters are not supported for this API: <c>recommendationIds</c>, <c>resourceArns</c>,
        /// and <c>resourceIds</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationSummaries service method.</param>
        /// 
        /// <returns>The response from the ListRecommendationSummaries service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListRecommendationSummaries">REST API Reference for ListRecommendationSummaries Operation</seealso>
        public virtual ListRecommendationSummariesResponse ListRecommendationSummaries(ListRecommendationSummariesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationSummariesResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationSummariesResponse>(request, options);
        }


        /// <summary>
        /// Returns a concise representation of savings estimates for resources. Also returns
        /// de-duped savings across different types of recommendations.
        /// 
        ///  <note> 
        /// <para>
        /// The following filters are not supported for this API: <c>recommendationIds</c>, <c>resourceArns</c>,
        /// and <c>resourceIds</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendationSummaries service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/ListRecommendationSummaries">REST API Reference for ListRecommendationSummaries Operation</seealso>
        public virtual Task<ListRecommendationSummariesResponse> ListRecommendationSummariesAsync(ListRecommendationSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecommendationSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnrollmentStatus


        /// <summary>
        /// Updates the enrollment (opt in and opt out) status of an account to the Cost Optimization
        /// Hub service.
        /// 
        ///  
        /// <para>
        /// If the account is a management account or delegated administrator of an organization,
        /// this action can also be used to enroll member accounts of the organization.
        /// </para>
        ///  
        /// <para>
        /// You must have the appropriate permissions to opt in to Cost Optimization Hub and to
        /// view its recommendations. When you opt in, Cost Optimization Hub automatically creates
        /// a service-linked role in your account to access its data.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateEnrollmentStatus service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        public virtual UpdateEnrollmentStatusResponse UpdateEnrollmentStatus(UpdateEnrollmentStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnrollmentStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateEnrollmentStatusResponse>(request, options);
        }


        /// <summary>
        /// Updates the enrollment (opt in and opt out) status of an account to the Cost Optimization
        /// Hub service.
        /// 
        ///  
        /// <para>
        /// If the account is a management account or delegated administrator of an organization,
        /// this action can also be used to enroll member accounts of the organization.
        /// </para>
        ///  
        /// <para>
        /// You must have the appropriate permissions to opt in to Cost Optimization Hub and to
        /// view its recommendations. When you opt in, Cost Optimization Hub automatically creates
        /// a service-linked role in your account to access its data.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnrollmentStatus service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        public virtual Task<UpdateEnrollmentStatusResponse> UpdateEnrollmentStatusAsync(UpdateEnrollmentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnrollmentStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEnrollmentStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePreferences


        /// <summary>
        /// Updates a set of preferences for an account in order to add account-specific preferences
        /// into the service. These preferences impact how the savings associated with recommendations
        /// are presented.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreferences service method.</param>
        /// 
        /// <returns>The response from the UpdatePreferences service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/UpdatePreferences">REST API Reference for UpdatePreferences Operation</seealso>
        public virtual UpdatePreferencesResponse UpdatePreferences(UpdatePreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePreferencesResponseUnmarshaller.Instance;

            return Invoke<UpdatePreferencesResponse>(request, options);
        }


        /// <summary>
        /// Updates a set of preferences for an account in order to add account-specific preferences
        /// into the service. These preferences impact how the savings associated with recommendations
        /// are presented.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePreferences service method, as returned by CostOptimizationHub.</returns>
        /// <exception cref="Amazon.CostOptimizationHub.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.InternalServerException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CostOptimizationHub.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cost-optimization-hub-2022-07-26/UpdatePreferences">REST API Reference for UpdatePreferences Operation</seealso>
        public virtual Task<UpdatePreferencesResponse> UpdatePreferencesAsync(UpdatePreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePreferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePreferencesResponse>(request, options, cancellationToken);
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