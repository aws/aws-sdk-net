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

namespace Amazon.CloudSearch
{
    /// <summary>
    /// Implementation for accessing CloudSearch
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

#if CORECLR
    
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudSearchConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudSearchConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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


        #region  BuildSuggesters

        internal virtual BuildSuggestersResponse BuildSuggesters(BuildSuggestersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BuildSuggestersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BuildSuggestersResponseUnmarshaller.Instance;

            return Invoke<BuildSuggestersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BuildSuggesters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BuildSuggesters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<BuildSuggestersResponse> BuildSuggestersAsync(BuildSuggestersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BuildSuggestersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BuildSuggestersResponseUnmarshaller.Instance;

            return InvokeAsync<BuildSuggestersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain

        internal virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DefineAnalysisScheme

        internal virtual DefineAnalysisSchemeResponse DefineAnalysisScheme(DefineAnalysisSchemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DefineAnalysisSchemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineAnalysisSchemeResponseUnmarshaller.Instance;

            return Invoke<DefineAnalysisSchemeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DefineAnalysisScheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineAnalysisScheme operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DefineAnalysisSchemeResponse> DefineAnalysisSchemeAsync(DefineAnalysisSchemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DefineAnalysisSchemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineAnalysisSchemeResponseUnmarshaller.Instance;

            return InvokeAsync<DefineAnalysisSchemeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DefineExpression

        internal virtual DefineExpressionResponse DefineExpression(DefineExpressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DefineExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineExpressionResponseUnmarshaller.Instance;

            return Invoke<DefineExpressionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DefineExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DefineExpressionResponse> DefineExpressionAsync(DefineExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DefineExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<DefineExpressionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DefineIndexField

        internal virtual DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DefineIndexFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return Invoke<DefineIndexFieldResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DefineIndexField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DefineIndexFieldResponse> DefineIndexFieldAsync(DefineIndexFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DefineIndexFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return InvokeAsync<DefineIndexFieldResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DefineSuggester

        internal virtual DefineSuggesterResponse DefineSuggester(DefineSuggesterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DefineSuggesterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineSuggesterResponseUnmarshaller.Instance;

            return Invoke<DefineSuggesterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DefineSuggester operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineSuggester operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DefineSuggesterResponse> DefineSuggesterAsync(DefineSuggesterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DefineSuggesterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DefineSuggesterResponseUnmarshaller.Instance;

            return InvokeAsync<DefineSuggesterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAnalysisScheme

        internal virtual DeleteAnalysisSchemeResponse DeleteAnalysisScheme(DeleteAnalysisSchemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnalysisSchemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalysisSchemeResponseUnmarshaller.Instance;

            return Invoke<DeleteAnalysisSchemeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnalysisScheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisScheme operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteAnalysisSchemeResponse> DeleteAnalysisSchemeAsync(DeleteAnalysisSchemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnalysisSchemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalysisSchemeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnalysisSchemeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteExpression

        internal virtual DeleteExpressionResponse DeleteExpression(DeleteExpressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExpressionResponseUnmarshaller.Instance;

            return Invoke<DeleteExpressionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteExpressionResponse> DeleteExpressionAsync(DeleteExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteExpressionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIndexField

        internal virtual DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return Invoke<DeleteIndexFieldResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndexField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteIndexFieldResponse> DeleteIndexFieldAsync(DeleteIndexFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIndexFieldResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSuggester

        internal virtual DeleteSuggesterResponse DeleteSuggester(DeleteSuggesterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSuggesterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuggesterResponseUnmarshaller.Instance;

            return Invoke<DeleteSuggesterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSuggester operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuggester operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteSuggesterResponse> DeleteSuggesterAsync(DeleteSuggesterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSuggesterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuggesterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSuggesterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAnalysisSchemes

        internal virtual DescribeAnalysisSchemesResponse DescribeAnalysisSchemes(DescribeAnalysisSchemesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnalysisSchemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnalysisSchemesResponseUnmarshaller.Instance;

            return Invoke<DescribeAnalysisSchemesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnalysisSchemes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisSchemes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeAnalysisSchemesResponse> DescribeAnalysisSchemesAsync(DescribeAnalysisSchemesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnalysisSchemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnalysisSchemesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAnalysisSchemesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAvailabilityOptions

        internal virtual DescribeAvailabilityOptionsResponse DescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAvailabilityOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeAvailabilityOptionsResponse> DescribeAvailabilityOptionsAsync(DescribeAvailabilityOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAvailabilityOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailabilityOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomains

        internal virtual DescribeDomainsResponse DescribeDomains()
        {
            return DescribeDomains(new DescribeDomainsRequest());
        }
        internal virtual DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default. To get the number of searchable documents
        /// in a domain, use the console or submit a <code>matchall</code> request to your domain's
        /// search endpoint: <code>q=matchall&amp;amp;q.parser=structured&amp;amp;size=0</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-domain-info.html"
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
        public virtual Task<DescribeDomainsResponse> DescribeDomainsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDomainsAsync(new DescribeDomainsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeExpressions

        internal virtual DescribeExpressionsResponse DescribeExpressions(DescribeExpressionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExpressionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExpressionsResponseUnmarshaller.Instance;

            return Invoke<DescribeExpressionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExpressions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExpressions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeExpressionsResponse> DescribeExpressionsAsync(DescribeExpressionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExpressionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExpressionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExpressionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIndexFields

        internal virtual DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIndexFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return Invoke<DescribeIndexFieldsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndexFields operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeIndexFieldsResponse> DescribeIndexFieldsAsync(DescribeIndexFieldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIndexFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIndexFieldsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingParameters

        internal virtual DescribeScalingParametersResponse DescribeScalingParameters(DescribeScalingParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingParametersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeScalingParametersResponse> DescribeScalingParametersAsync(DescribeScalingParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceAccessPolicies

        internal virtual DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceAccessPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeServiceAccessPoliciesResponse> DescribeServiceAccessPoliciesAsync(DescribeServiceAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServiceAccessPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSuggesters

        internal virtual DescribeSuggestersResponse DescribeSuggesters(DescribeSuggestersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSuggestersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSuggestersResponseUnmarshaller.Instance;

            return Invoke<DescribeSuggestersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSuggesters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSuggesters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeSuggestersResponse> DescribeSuggestersAsync(DescribeSuggestersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSuggestersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSuggestersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSuggestersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IndexDocuments

        internal virtual IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IndexDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IndexDocumentsResponseUnmarshaller.Instance;

            return Invoke<IndexDocumentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the IndexDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<IndexDocumentsResponse> IndexDocumentsAsync(IndexDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        public virtual Task<ListDomainNamesResponse> ListDomainNamesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDomainNamesAsync(new ListDomainNamesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAvailabilityOptions

        internal virtual UpdateAvailabilityOptionsResponse UpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAvailabilityOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateAvailabilityOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAvailabilityOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateAvailabilityOptionsResponse> UpdateAvailabilityOptionsAsync(UpdateAvailabilityOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAvailabilityOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAvailabilityOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateScalingParameters

        internal virtual UpdateScalingParametersResponse UpdateScalingParameters(UpdateScalingParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScalingParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScalingParametersResponseUnmarshaller.Instance;

            return Invoke<UpdateScalingParametersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScalingParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScalingParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateScalingParametersResponse> UpdateScalingParametersAsync(UpdateScalingParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScalingParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScalingParametersResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScalingParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceAccessPolicies

        internal virtual UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceAccessPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateServiceAccessPoliciesResponse> UpdateServiceAccessPoliciesAsync(UpdateServiceAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceAccessPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}