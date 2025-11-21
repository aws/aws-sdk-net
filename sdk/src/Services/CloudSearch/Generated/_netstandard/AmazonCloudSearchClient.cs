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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudSearch.Model;
using Amazon.CloudSearch.Model.Internal.MarshallTransformations;
using Amazon.CloudSearch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CloudSearch
{
    /// <summary>
    /// <para>Implementation for accessing CloudSearch</para>
    ///
    /// Amazon CloudSearch Configuration Service 
    /// <para>
    /// You use the Amazon CloudSearch configuration service to create, configure, and manage
    /// search domains. Configuration service requests are submitted using the AWS Query protocol.
    /// AWS Query requests are HTTP or HTTPS requests submitted via HTTP GET or POST with
    /// a query parameter named Action.
    /// </para>
    ///  
    /// <para>
    /// The endpoint for configuration service requests is region-specific: cloudsearch.<i>region</i>.amazonaws.com.
    /// For example, cloudsearch.us-east-1.amazonaws.com. For a current list of supported
    /// regions and endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#cloudsearch_region"
    /// target="_blank">Regions and Endpoints</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudSearchClient : AmazonServiceClient, IAmazonCloudSearch
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudSearchMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudSearchClient with the credentials loaded from the application's
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
        public AmazonCloudSearchClient()
            : base(new AmazonCloudSearchConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with the credentials loaded from the application's
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
        public AmazonCloudSearchClient(RegionEndpoint region)
            : base(new AmazonCloudSearchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(AmazonCloudSearchConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudSearchClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudSearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudSearchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudSearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Credentials and an
        /// AmazonCloudSearchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(AWSCredentials credentials, AmazonCloudSearchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudSearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudSearchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudSearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudSearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudSearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudSearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudSearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudSearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudSearchEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudSearchAuthSchemeHandler());
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


        #region  BuildSuggesters

        internal virtual BuildSuggestersResponse BuildSuggesters(BuildSuggestersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BuildSuggestersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BuildSuggestersResponseUnmarshaller.Instance;

            return Invoke<BuildSuggestersResponse>(request, options);
        }



        /// <summary>
        /// Indexes the search suggestions. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html#configuring-suggesters">Configuring
        /// Suggesters</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BuildSuggesters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BuildSuggesters service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/BuildSuggesters">REST API Reference for BuildSuggesters Operation</seealso>
        public virtual Task<BuildSuggestersResponse> BuildSuggestersAsync(BuildSuggestersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BuildSuggestersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BuildSuggestersResponseUnmarshaller.Instance;

            return InvokeAsync<BuildSuggestersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDomain

        internal virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }



        /// <summary>
        /// Creates a new search domain. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/creating-domains.html"
        /// target="_blank">Creating a Search Domain</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DefineAnalysisScheme

        internal virtual DefineAnalysisSchemeResponse DefineAnalysisScheme(DefineAnalysisSchemeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DefineAnalysisSchemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineAnalysisSchemeResponseUnmarshaller.Instance;

            return Invoke<DefineAnalysisSchemeResponse>(request, options);
        }



        /// <summary>
        /// Configures an analysis scheme that can be applied to a <c>text</c> or <c>text-array</c>
        /// field to define language-specific text processing options. For more information, see
        /// <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// target="_blank">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineAnalysisScheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DefineAnalysisScheme service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineAnalysisScheme">REST API Reference for DefineAnalysisScheme Operation</seealso>
        public virtual Task<DefineAnalysisSchemeResponse> DefineAnalysisSchemeAsync(DefineAnalysisSchemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DefineAnalysisSchemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineAnalysisSchemeResponseUnmarshaller.Instance;

            return InvokeAsync<DefineAnalysisSchemeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DefineExpression

        internal virtual DefineExpressionResponse DefineExpression(DefineExpressionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DefineExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineExpressionResponseUnmarshaller.Instance;

            return Invoke<DefineExpressionResponse>(request, options);
        }



        /// <summary>
        /// Configures an <c><a>Expression</a></c> for the search domain. Used to create new expressions
        /// and modify existing ones. If the expression exists, the new configuration replaces
        /// the old one. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
        /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineExpression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DefineExpression service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineExpression">REST API Reference for DefineExpression Operation</seealso>
        public virtual Task<DefineExpressionResponse> DefineExpressionAsync(DefineExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DefineExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<DefineExpressionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DefineIndexField

        internal virtual DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DefineIndexFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return Invoke<DefineIndexFieldResponse>(request, options);
        }



        /// <summary>
        /// Configures an <c><a>IndexField</a></c> for the search domain. Used to create new fields
        /// and modify existing ones. You must specify the name of the domain you are configuring
        /// and an index field configuration. The index field configuration specifies a unique
        /// name, the index field type, and the options you want to configure for the field. The
        /// options you can specify depend on the <c><a>IndexFieldType</a></c>. If the field exists,
        /// the new configuration replaces the old one. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html"
        /// target="_blank">Configuring Index Fields</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineIndexField">REST API Reference for DefineIndexField Operation</seealso>
        public virtual Task<DefineIndexFieldResponse> DefineIndexFieldAsync(DefineIndexFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DefineIndexFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return InvokeAsync<DefineIndexFieldResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DefineSuggester

        internal virtual DefineSuggesterResponse DefineSuggester(DefineSuggesterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DefineSuggesterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineSuggesterResponseUnmarshaller.Instance;

            return Invoke<DefineSuggesterResponse>(request, options);
        }



        /// <summary>
        /// Configures a suggester for a domain. A suggester enables you to display possible matches
        /// before users finish typing their queries. When you configure a suggester, you must
        /// specify the name of the text field you want to search for possible matches and a unique
        /// name for the suggester. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html"
        /// target="_blank">Getting Search Suggestions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineSuggester service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DefineSuggester service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineSuggester">REST API Reference for DefineSuggester Operation</seealso>
        public virtual Task<DefineSuggesterResponse> DefineSuggesterAsync(DefineSuggesterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DefineSuggesterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineSuggesterResponseUnmarshaller.Instance;

            return InvokeAsync<DefineSuggesterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAnalysisScheme

        internal virtual DeleteAnalysisSchemeResponse DeleteAnalysisScheme(DeleteAnalysisSchemeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnalysisSchemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalysisSchemeResponseUnmarshaller.Instance;

            return Invoke<DeleteAnalysisSchemeResponse>(request, options);
        }



        /// <summary>
        /// Deletes an analysis scheme. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// target="_blank">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisScheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnalysisScheme service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteAnalysisScheme">REST API Reference for DeleteAnalysisScheme Operation</seealso>
        public virtual Task<DeleteAnalysisSchemeResponse> DeleteAnalysisSchemeAsync(DeleteAnalysisSchemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnalysisSchemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalysisSchemeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnalysisSchemeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDomain

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }



        /// <summary>
        /// Permanently deletes a search domain and all of its data. Once a domain has been deleted,
        /// it cannot be recovered. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/deleting-domains.html"
        /// target="_blank">Deleting a Search Domain</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteExpression

        internal virtual DeleteExpressionResponse DeleteExpression(DeleteExpressionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExpressionResponseUnmarshaller.Instance;

            return Invoke<DeleteExpressionResponse>(request, options);
        }



        /// <summary>
        /// Removes an <c><a>Expression</a></c> from the search domain. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
        /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExpression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExpression service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteExpression">REST API Reference for DeleteExpression Operation</seealso>
        public virtual Task<DeleteExpressionResponse> DeleteExpressionAsync(DeleteExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteExpressionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIndexField

        internal virtual DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIndexFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return Invoke<DeleteIndexFieldResponse>(request, options);
        }



        /// <summary>
        /// Removes an <c><a>IndexField</a></c> from the search domain. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html"
        /// target="_blank">Configuring Index Fields</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteIndexField">REST API Reference for DeleteIndexField Operation</seealso>
        public virtual Task<DeleteIndexFieldResponse> DeleteIndexFieldAsync(DeleteIndexFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIndexFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIndexFieldResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSuggester

        internal virtual DeleteSuggesterResponse DeleteSuggester(DeleteSuggesterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSuggesterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuggesterResponseUnmarshaller.Instance;

            return Invoke<DeleteSuggesterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a suggester. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html"
        /// target="_blank">Getting Search Suggestions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuggester service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSuggester service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteSuggester">REST API Reference for DeleteSuggester Operation</seealso>
        public virtual Task<DeleteSuggesterResponse> DeleteSuggesterAsync(DeleteSuggesterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSuggesterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuggesterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSuggesterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAnalysisSchemes

        internal virtual DescribeAnalysisSchemesResponse DescribeAnalysisSchemes(DescribeAnalysisSchemesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnalysisSchemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnalysisSchemesResponseUnmarshaller.Instance;

            return Invoke<DescribeAnalysisSchemesResponse>(request, options);
        }



        /// <summary>
        /// Gets the analysis schemes configured for a domain. An analysis scheme defines language-specific
        /// text processing options for a <c>text</c> field. Can be limited to specific analysis
        /// schemes by name. By default, shows all analysis schemes and includes any pending changes
        /// to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// target="_blank">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisSchemes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnalysisSchemes service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeAnalysisSchemes">REST API Reference for DescribeAnalysisSchemes Operation</seealso>
        public virtual Task<DescribeAnalysisSchemesResponse> DescribeAnalysisSchemesAsync(DescribeAnalysisSchemesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnalysisSchemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnalysisSchemesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAnalysisSchemesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAvailabilityOptions

        internal virtual DescribeAvailabilityOptionsResponse DescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAvailabilityOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityOptionsResponse>(request, options);
        }



        /// <summary>
        /// Gets the availability options configured for a domain. By default, shows the configuration
        /// with any pending changes. Set the <c>Deployed</c> option to <c>true</c> to show the
        /// active configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html"
        /// target="_blank">Configuring Availability Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailabilityOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeAvailabilityOptions">REST API Reference for DescribeAvailabilityOptions Operation</seealso>
        public virtual Task<DescribeAvailabilityOptionsResponse> DescribeAvailabilityOptionsAsync(DescribeAvailabilityOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAvailabilityOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailabilityOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDomainEndpointOptions

        internal virtual DescribeDomainEndpointOptionsResponse DescribeDomainEndpointOptions(DescribeDomainEndpointOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDomainEndpointOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainEndpointOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainEndpointOptionsResponse>(request, options);
        }



        /// <summary>
        /// Returns the domain's endpoint options, specifically whether all requests to the domain
        /// must arrive over HTTPS. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-domain-endpoint-options.html"
        /// target="_blank">Configuring Domain Endpoint Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainEndpointOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainEndpointOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeDomainEndpointOptions">REST API Reference for DescribeDomainEndpointOptions Operation</seealso>
        public virtual Task<DescribeDomainEndpointOptionsResponse> DescribeDomainEndpointOptionsAsync(DescribeDomainEndpointOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDomainEndpointOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainEndpointOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainEndpointOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDomains

        internal virtual DescribeDomainsResponse DescribeDomains()
        {
            return DescribeDomains(new DescribeDomainsRequest());
        }
        internal virtual DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default. To get the number of searchable documents
        /// in a domain, use the console or submit a <c>matchall</c> request to your domain's
        /// search endpoint: <c>q=matchall&amp;amp;q.parser=structured&amp;amp;size=0</c>. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-domain-info.html"
        /// target="_blank">Getting Information about a Search Domain</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        public virtual Task<DescribeDomainsResponse> DescribeDomainsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDomainsAsync(new DescribeDomainsRequest(), cancellationToken);
        }



        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default. To get the number of searchable documents
        /// in a domain, use the console or submit a <c>matchall</c> request to your domain's
        /// search endpoint: <c>q=matchall&amp;amp;q.parser=structured&amp;amp;size=0</c>. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-domain-info.html"
        /// target="_blank">Getting Information about a Search Domain</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        public virtual Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeExpressions

        internal virtual DescribeExpressionsResponse DescribeExpressions(DescribeExpressionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExpressionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExpressionsResponseUnmarshaller.Instance;

            return Invoke<DescribeExpressionsResponse>(request, options);
        }



        /// <summary>
        /// Gets the expressions configured for the search domain. Can be limited to specific
        /// expressions by name. By default, shows all expressions and includes any pending changes
        /// to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
        /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExpressions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExpressions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeExpressions">REST API Reference for DescribeExpressions Operation</seealso>
        public virtual Task<DescribeExpressionsResponse> DescribeExpressionsAsync(DescribeExpressionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExpressionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExpressionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExpressionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeIndexFields

        internal virtual DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIndexFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return Invoke<DescribeIndexFieldsResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the index fields configured for the search domain. Can be limited
        /// to specific fields by name. By default, shows all fields and includes any pending
        /// changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show
        /// the active configuration and exclude pending changes. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-domain-info.html"
        /// target="_blank">Getting Domain Information</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeIndexFields">REST API Reference for DescribeIndexFields Operation</seealso>
        public virtual Task<DescribeIndexFieldsResponse> DescribeIndexFieldsAsync(DescribeIndexFieldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIndexFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIndexFieldsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeScalingParameters

        internal virtual DescribeScalingParametersResponse DescribeScalingParameters(DescribeScalingParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeScalingParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingParametersResponse>(request, options);
        }



        /// <summary>
        /// Gets the scaling parameters configured for a domain. A domain's scaling parameters
        /// specify the desired search instance type and replication count. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html"
        /// target="_blank">Configuring Scaling Options</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingParameters service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeScalingParameters">REST API Reference for DescribeScalingParameters Operation</seealso>
        public virtual Task<DescribeScalingParametersResponse> DescribeScalingParametersAsync(DescribeScalingParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeScalingParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeServiceAccessPolicies

        internal virtual DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServiceAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceAccessPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the access policies that control access to the domain's document
        /// and search endpoints. By default, shows the configuration with any pending changes.
        /// Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and
        /// exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"
        /// target="_blank">Configuring Access for a Search Domain</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeServiceAccessPolicies">REST API Reference for DescribeServiceAccessPolicies Operation</seealso>
        public virtual Task<DescribeServiceAccessPoliciesResponse> DescribeServiceAccessPoliciesAsync(DescribeServiceAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServiceAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServiceAccessPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSuggesters

        internal virtual DescribeSuggestersResponse DescribeSuggesters(DescribeSuggestersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSuggestersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSuggestersResponseUnmarshaller.Instance;

            return Invoke<DescribeSuggestersResponse>(request, options);
        }



        /// <summary>
        /// Gets the suggesters configured for a domain. A suggester enables you to display possible
        /// matches before users finish typing their queries. Can be limited to specific suggesters
        /// by name. By default, shows all suggesters and includes any pending changes to the
        /// configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration
        /// and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html"
        /// target="_blank">Getting Search Suggestions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSuggesters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSuggesters service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeSuggesters">REST API Reference for DescribeSuggesters Operation</seealso>
        public virtual Task<DescribeSuggestersResponse> DescribeSuggestersAsync(DescribeSuggestersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSuggestersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSuggestersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSuggestersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  IndexDocuments

        internal virtual IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IndexDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IndexDocumentsResponseUnmarshaller.Instance;

            return Invoke<IndexDocumentsResponse>(request, options);
        }



        /// <summary>
        /// Tells the search domain to start indexing its documents using the latest indexing
        /// options. This operation must be invoked to activate options whose <a>OptionStatus</a>
        /// is <c>RequiresIndexDocuments</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/IndexDocuments">REST API Reference for IndexDocuments Operation</seealso>
        public virtual Task<IndexDocumentsResponse> IndexDocumentsAsync(IndexDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IndexDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IndexDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<IndexDocumentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDomainNames

        internal virtual ListDomainNamesResponse ListDomainNames()
        {
            return ListDomainNames(new ListDomainNamesRequest());
        }
        internal virtual ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesResponse>(request, options);
        }


        /// <summary>
        /// Lists all search domains owned by an account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        public virtual Task<ListDomainNamesResponse> ListDomainNamesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDomainNamesAsync(new ListDomainNamesRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists all search domains owned by an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        public virtual Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainNamesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAvailabilityOptions

        internal virtual UpdateAvailabilityOptionsResponse UpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAvailabilityOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateAvailabilityOptionsResponse>(request, options);
        }



        /// <summary>
        /// Configures the availability options for a domain. Enabling the Multi-AZ option expands
        /// an Amazon CloudSearch domain to an additional Availability Zone in the same Region
        /// to increase fault tolerance in the event of a service disruption. Changes to the Multi-AZ
        /// option can take about half an hour to become active. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html"
        /// target="_blank">Configuring Availability Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAvailabilityOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateAvailabilityOptions">REST API Reference for UpdateAvailabilityOptions Operation</seealso>
        public virtual Task<UpdateAvailabilityOptionsResponse> UpdateAvailabilityOptionsAsync(UpdateAvailabilityOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAvailabilityOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAvailabilityOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDomainEndpointOptions

        internal virtual UpdateDomainEndpointOptionsResponse UpdateDomainEndpointOptions(UpdateDomainEndpointOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainEndpointOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainEndpointOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainEndpointOptionsResponse>(request, options);
        }



        /// <summary>
        /// Updates the domain's endpoint options, specifically whether all requests to the domain
        /// must arrive over HTTPS. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-domain-endpoint-options.html"
        /// target="_blank">Configuring Domain Endpoint Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEndpointOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainEndpointOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateDomainEndpointOptions">REST API Reference for UpdateDomainEndpointOptions Operation</seealso>
        public virtual Task<UpdateDomainEndpointOptionsResponse> UpdateDomainEndpointOptionsAsync(UpdateDomainEndpointOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainEndpointOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainEndpointOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainEndpointOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateScalingParameters

        internal virtual UpdateScalingParametersResponse UpdateScalingParameters(UpdateScalingParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScalingParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScalingParametersResponseUnmarshaller.Instance;

            return Invoke<UpdateScalingParametersResponse>(request, options);
        }



        /// <summary>
        /// Configures scaling parameters for a domain. A domain's scaling parameters specify
        /// the desired search instance type and replication count. Amazon CloudSearch will still
        /// automatically scale your domain based on the volume of data and traffic, but not below
        /// the desired instance type and replication count. If the Multi-AZ option is enabled,
        /// these values control the resources used per Availability Zone. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html"
        /// target="_blank">Configuring Scaling Options</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScalingParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScalingParameters service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateScalingParameters">REST API Reference for UpdateScalingParameters Operation</seealso>
        public virtual Task<UpdateScalingParametersResponse> UpdateScalingParametersAsync(UpdateScalingParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScalingParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScalingParametersResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScalingParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateServiceAccessPolicies

        internal virtual UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceAccessPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Configures the access rules that control access to the domain's document and search
        /// endpoints. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"
        /// target="_blank"> Configuring Access for an Amazon CloudSearch Domain</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateServiceAccessPolicies">REST API Reference for UpdateServiceAccessPolicies Operation</seealso>
        public virtual Task<UpdateServiceAccessPoliciesResponse> UpdateServiceAccessPoliciesAsync(UpdateServiceAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceAccessPoliciesResponse>(request, options, cancellationToken);
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