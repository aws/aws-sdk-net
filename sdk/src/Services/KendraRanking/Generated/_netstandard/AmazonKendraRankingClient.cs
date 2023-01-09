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
 * Do not modify this file. This file is generated from the kendra-ranking-2022-10-19.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KendraRanking.Model;
using Amazon.KendraRanking.Model.Internal.MarshallTransformations;
using Amazon.KendraRanking.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KendraRanking
{
    /// <summary>
    /// Implementation for accessing KendraRanking
    ///
    /// Amazon Kendra Intelligent Ranking uses Amazon Kendra semantic search capabilities
    /// to intelligently re-rank a search service's results.
    /// </summary>
    public partial class AmazonKendraRankingClient : AmazonServiceClient, IAmazonKendraRanking
    {
        private static IServiceMetadata serviceMetadata = new AmazonKendraRankingMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonKendraRankingClient with the credentials loaded from the application's
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
        public AmazonKendraRankingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKendraRankingConfig()) { }

        /// <summary>
        /// Constructs AmazonKendraRankingClient with the credentials loaded from the application's
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
        public AmazonKendraRankingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKendraRankingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKendraRankingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKendraRankingClient Configuration Object</param>
        public AmazonKendraRankingClient(AmazonKendraRankingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonKendraRankingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKendraRankingClient(AWSCredentials credentials)
            : this(credentials, new AmazonKendraRankingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKendraRankingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKendraRankingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKendraRankingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKendraRankingClient with AWS Credentials and an
        /// AmazonKendraRankingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKendraRankingClient Configuration Object</param>
        public AmazonKendraRankingClient(AWSCredentials credentials, AmazonKendraRankingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKendraRankingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKendraRankingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKendraRankingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKendraRankingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKendraRankingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKendraRankingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKendraRankingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKendraRankingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKendraRankingClient Configuration Object</param>
        public AmazonKendraRankingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKendraRankingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKendraRankingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKendraRankingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKendraRankingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKendraRankingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKendraRankingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKendraRankingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKendraRankingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKendraRankingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKendraRankingClient Configuration Object</param>
        public AmazonKendraRankingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKendraRankingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IKendraRankingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IKendraRankingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new KendraRankingPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKendraRankingEndpointResolver());
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


        #region  CreateRescoreExecutionPlan

        internal virtual CreateRescoreExecutionPlanResponse CreateRescoreExecutionPlan(CreateRescoreExecutionPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRescoreExecutionPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRescoreExecutionPlanResponseUnmarshaller.Instance;

            return Invoke<CreateRescoreExecutionPlanResponse>(request, options);
        }



        /// <summary>
        /// Creates a rescore execution plan. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <code>Rescore</code> API. You set the number
        /// of capacity units that you require for Amazon Kendra Intelligent Ranking to rescore
        /// or re-rank a search service's results.
        /// 
        ///  
        /// <para>
        /// For an example of using the <code>CreateRescoreExecutionPlan</code> API, including
        /// using the Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/search-service-rerank.html">Semantically
        /// ranking a search service's results</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRescoreExecutionPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra Intelligent Ranking service.
        /// Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/CreateRescoreExecutionPlan">REST API Reference for CreateRescoreExecutionPlan Operation</seealso>
        public virtual Task<CreateRescoreExecutionPlanResponse> CreateRescoreExecutionPlanAsync(CreateRescoreExecutionPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRescoreExecutionPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRescoreExecutionPlanResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRescoreExecutionPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRescoreExecutionPlan

        internal virtual DeleteRescoreExecutionPlanResponse DeleteRescoreExecutionPlan(DeleteRescoreExecutionPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRescoreExecutionPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRescoreExecutionPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteRescoreExecutionPlanResponse>(request, options);
        }



        /// <summary>
        /// Deletes a rescore execution plan. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <code>Rescore</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRescoreExecutionPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/DeleteRescoreExecutionPlan">REST API Reference for DeleteRescoreExecutionPlan Operation</seealso>
        public virtual Task<DeleteRescoreExecutionPlanResponse> DeleteRescoreExecutionPlanAsync(DeleteRescoreExecutionPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRescoreExecutionPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRescoreExecutionPlanResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRescoreExecutionPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRescoreExecutionPlan

        internal virtual DescribeRescoreExecutionPlanResponse DescribeRescoreExecutionPlan(DescribeRescoreExecutionPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRescoreExecutionPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRescoreExecutionPlanResponseUnmarshaller.Instance;

            return Invoke<DescribeRescoreExecutionPlanResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a rescore execution plan. A rescore execution plan is an Amazon
        /// Kendra Intelligent Ranking resource used for provisioning the <code>Rescore</code>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRescoreExecutionPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/DescribeRescoreExecutionPlan">REST API Reference for DescribeRescoreExecutionPlan Operation</seealso>
        public virtual Task<DescribeRescoreExecutionPlanResponse> DescribeRescoreExecutionPlanAsync(DescribeRescoreExecutionPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRescoreExecutionPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRescoreExecutionPlanResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRescoreExecutionPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRescoreExecutionPlans

        internal virtual ListRescoreExecutionPlansResponse ListRescoreExecutionPlans(ListRescoreExecutionPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRescoreExecutionPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRescoreExecutionPlansResponseUnmarshaller.Instance;

            return Invoke<ListRescoreExecutionPlansResponse>(request, options);
        }



        /// <summary>
        /// Lists your rescore execution plans. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <code>Rescore</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRescoreExecutionPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRescoreExecutionPlans service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/ListRescoreExecutionPlans">REST API Reference for ListRescoreExecutionPlans Operation</seealso>
        public virtual Task<ListRescoreExecutionPlansResponse> ListRescoreExecutionPlansAsync(ListRescoreExecutionPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRescoreExecutionPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRescoreExecutionPlansResponseUnmarshaller.Instance;

            return InvokeAsync<ListRescoreExecutionPlansResponse>(request, options, cancellationToken);
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
        /// Gets a list of tags associated with a specified resource. A rescore execution plan
        /// is an example of a resource that can have tags associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceUnavailableException">
        /// The resource you want to use is unavailable. Please check you have provided the correct
        /// resource information and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Rescore

        internal virtual RescoreResponse Rescore(RescoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RescoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RescoreResponseUnmarshaller.Instance;

            return Invoke<RescoreResponse>(request, options);
        }



        /// <summary>
        /// Rescores or re-ranks search results from a search service such as OpenSearch (self
        /// managed). You use the semantic search capabilities of Amazon Kendra Intelligent Ranking
        /// to improve the search service's results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Rescore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Rescore service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/Rescore">REST API Reference for Rescore Operation</seealso>
        public virtual Task<RescoreResponse> RescoreAsync(RescoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RescoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RescoreResponseUnmarshaller.Instance;

            return InvokeAsync<RescoreResponse>(request, options, cancellationToken);
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
        /// Adds a specified tag to a specified rescore execution plan. A rescore execution plan
        /// is an Amazon Kendra Intelligent Ranking resource used for provisioning the <code>Rescore</code>
        /// API. If the tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceUnavailableException">
        /// The resource you want to use is unavailable. Please check you have provided the correct
        /// resource information and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a tag from a rescore execution plan. A rescore execution plan is an Amazon
        /// Kendra Intelligent Ranking resource used for provisioning the <code>Rescore</code>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceUnavailableException">
        /// The resource you want to use is unavailable. Please check you have provided the correct
        /// resource information and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRescoreExecutionPlan

        internal virtual UpdateRescoreExecutionPlanResponse UpdateRescoreExecutionPlan(UpdateRescoreExecutionPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRescoreExecutionPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRescoreExecutionPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateRescoreExecutionPlanResponse>(request, options);
        }



        /// <summary>
        /// Updates a rescore execution plan. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <code>Rescore</code> API. You can update
        /// the number of capacity units you require for Amazon Kendra Intelligent Ranking to
        /// rescore or re-rank a search service's results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRescoreExecutionPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra Intelligent Ranking service.
        /// Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/UpdateRescoreExecutionPlan">REST API Reference for UpdateRescoreExecutionPlan Operation</seealso>
        public virtual Task<UpdateRescoreExecutionPlanResponse> UpdateRescoreExecutionPlanAsync(UpdateRescoreExecutionPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRescoreExecutionPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRescoreExecutionPlanResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRescoreExecutionPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}