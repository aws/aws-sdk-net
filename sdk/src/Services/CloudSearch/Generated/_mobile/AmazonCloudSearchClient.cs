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

using Amazon.CloudSearch.Model;
using Amazon.CloudSearch.Model.Internal.MarshallTransformations;
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

        internal BuildSuggestersResponse BuildSuggesters(BuildSuggestersRequest request)
        {
            var marshaller = new BuildSuggestersRequestMarshaller();
            var unmarshaller = BuildSuggestersResponseUnmarshaller.Instance;

            return Invoke<BuildSuggestersRequest,BuildSuggestersResponse>(request, marshaller, unmarshaller);
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
        public Task<BuildSuggestersResponse> BuildSuggestersAsync(BuildSuggestersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BuildSuggestersRequestMarshaller();
            var unmarshaller = BuildSuggestersResponseUnmarshaller.Instance;

            return InvokeAsync<BuildSuggestersRequest,BuildSuggestersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain

        internal CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainRequest,CreateDomainResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainRequest,CreateDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DefineAnalysisScheme

        internal DefineAnalysisSchemeResponse DefineAnalysisScheme(DefineAnalysisSchemeRequest request)
        {
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var unmarshaller = DefineAnalysisSchemeResponseUnmarshaller.Instance;

            return Invoke<DefineAnalysisSchemeRequest,DefineAnalysisSchemeResponse>(request, marshaller, unmarshaller);
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
        public Task<DefineAnalysisSchemeResponse> DefineAnalysisSchemeAsync(DefineAnalysisSchemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var unmarshaller = DefineAnalysisSchemeResponseUnmarshaller.Instance;

            return InvokeAsync<DefineAnalysisSchemeRequest,DefineAnalysisSchemeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DefineExpression

        internal DefineExpressionResponse DefineExpression(DefineExpressionRequest request)
        {
            var marshaller = new DefineExpressionRequestMarshaller();
            var unmarshaller = DefineExpressionResponseUnmarshaller.Instance;

            return Invoke<DefineExpressionRequest,DefineExpressionResponse>(request, marshaller, unmarshaller);
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
        public Task<DefineExpressionResponse> DefineExpressionAsync(DefineExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DefineExpressionRequestMarshaller();
            var unmarshaller = DefineExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<DefineExpressionRequest,DefineExpressionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DefineIndexField

        internal DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest request)
        {
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var unmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return Invoke<DefineIndexFieldRequest,DefineIndexFieldResponse>(request, marshaller, unmarshaller);
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
        public Task<DefineIndexFieldResponse> DefineIndexFieldAsync(DefineIndexFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var unmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return InvokeAsync<DefineIndexFieldRequest,DefineIndexFieldResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DefineSuggester

        internal DefineSuggesterResponse DefineSuggester(DefineSuggesterRequest request)
        {
            var marshaller = new DefineSuggesterRequestMarshaller();
            var unmarshaller = DefineSuggesterResponseUnmarshaller.Instance;

            return Invoke<DefineSuggesterRequest,DefineSuggesterResponse>(request, marshaller, unmarshaller);
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
        public Task<DefineSuggesterResponse> DefineSuggesterAsync(DefineSuggesterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DefineSuggesterRequestMarshaller();
            var unmarshaller = DefineSuggesterResponseUnmarshaller.Instance;

            return InvokeAsync<DefineSuggesterRequest,DefineSuggesterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAnalysisScheme

        internal DeleteAnalysisSchemeResponse DeleteAnalysisScheme(DeleteAnalysisSchemeRequest request)
        {
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var unmarshaller = DeleteAnalysisSchemeResponseUnmarshaller.Instance;

            return Invoke<DeleteAnalysisSchemeRequest,DeleteAnalysisSchemeResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteAnalysisSchemeResponse> DeleteAnalysisSchemeAsync(DeleteAnalysisSchemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var unmarshaller = DeleteAnalysisSchemeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnalysisSchemeRequest,DeleteAnalysisSchemeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain

        internal DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainRequest,DeleteDomainResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainRequest,DeleteDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteExpression

        internal DeleteExpressionResponse DeleteExpression(DeleteExpressionRequest request)
        {
            var marshaller = new DeleteExpressionRequestMarshaller();
            var unmarshaller = DeleteExpressionResponseUnmarshaller.Instance;

            return Invoke<DeleteExpressionRequest,DeleteExpressionResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteExpressionResponse> DeleteExpressionAsync(DeleteExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteExpressionRequestMarshaller();
            var unmarshaller = DeleteExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteExpressionRequest,DeleteExpressionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIndexField

        internal DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest request)
        {
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var unmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return Invoke<DeleteIndexFieldRequest,DeleteIndexFieldResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteIndexFieldResponse> DeleteIndexFieldAsync(DeleteIndexFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var unmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIndexFieldRequest,DeleteIndexFieldResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSuggester

        internal DeleteSuggesterResponse DeleteSuggester(DeleteSuggesterRequest request)
        {
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var unmarshaller = DeleteSuggesterResponseUnmarshaller.Instance;

            return Invoke<DeleteSuggesterRequest,DeleteSuggesterResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteSuggesterResponse> DeleteSuggesterAsync(DeleteSuggesterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var unmarshaller = DeleteSuggesterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSuggesterRequest,DeleteSuggesterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAnalysisSchemes

        internal DescribeAnalysisSchemesResponse DescribeAnalysisSchemes(DescribeAnalysisSchemesRequest request)
        {
            var marshaller = new DescribeAnalysisSchemesRequestMarshaller();
            var unmarshaller = DescribeAnalysisSchemesResponseUnmarshaller.Instance;

            return Invoke<DescribeAnalysisSchemesRequest,DescribeAnalysisSchemesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeAnalysisSchemesResponse> DescribeAnalysisSchemesAsync(DescribeAnalysisSchemesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAnalysisSchemesRequestMarshaller();
            var unmarshaller = DescribeAnalysisSchemesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAnalysisSchemesRequest,DescribeAnalysisSchemesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAvailabilityOptions

        internal DescribeAvailabilityOptionsResponse DescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request)
        {
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var unmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityOptionsRequest,DescribeAvailabilityOptionsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeAvailabilityOptionsResponse> DescribeAvailabilityOptionsAsync(DescribeAvailabilityOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var unmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailabilityOptionsRequest,DescribeAvailabilityOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomains

        internal DescribeDomainsResponse DescribeDomains()
        {
            return DescribeDomains(new DescribeDomainsRequest());
        }
        internal DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            var marshaller = new DescribeDomainsRequestMarshaller();
            var unmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainsRequest,DescribeDomainsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeDomainsResponse> DescribeDomainsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDomainsRequestMarshaller();
            var unmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainsRequest,DescribeDomainsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeExpressions

        internal DescribeExpressionsResponse DescribeExpressions(DescribeExpressionsRequest request)
        {
            var marshaller = new DescribeExpressionsRequestMarshaller();
            var unmarshaller = DescribeExpressionsResponseUnmarshaller.Instance;

            return Invoke<DescribeExpressionsRequest,DescribeExpressionsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeExpressionsResponse> DescribeExpressionsAsync(DescribeExpressionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeExpressionsRequestMarshaller();
            var unmarshaller = DescribeExpressionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExpressionsRequest,DescribeExpressionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeIndexFields

        internal DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest request)
        {
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var unmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return Invoke<DescribeIndexFieldsRequest,DescribeIndexFieldsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeIndexFieldsResponse> DescribeIndexFieldsAsync(DescribeIndexFieldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var unmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIndexFieldsRequest,DescribeIndexFieldsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingParameters

        internal DescribeScalingParametersResponse DescribeScalingParameters(DescribeScalingParametersRequest request)
        {
            var marshaller = new DescribeScalingParametersRequestMarshaller();
            var unmarshaller = DescribeScalingParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingParametersRequest,DescribeScalingParametersResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeScalingParametersResponse> DescribeScalingParametersAsync(DescribeScalingParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingParametersRequestMarshaller();
            var unmarshaller = DescribeScalingParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingParametersRequest,DescribeScalingParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceAccessPolicies

        internal DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request)
        {
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceAccessPoliciesRequest,DescribeServiceAccessPoliciesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeServiceAccessPoliciesResponse> DescribeServiceAccessPoliciesAsync(DescribeServiceAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServiceAccessPoliciesRequest,DescribeServiceAccessPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSuggesters

        internal DescribeSuggestersResponse DescribeSuggesters(DescribeSuggestersRequest request)
        {
            var marshaller = new DescribeSuggestersRequestMarshaller();
            var unmarshaller = DescribeSuggestersResponseUnmarshaller.Instance;

            return Invoke<DescribeSuggestersRequest,DescribeSuggestersResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeSuggestersResponse> DescribeSuggestersAsync(DescribeSuggestersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSuggestersRequestMarshaller();
            var unmarshaller = DescribeSuggestersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSuggestersRequest,DescribeSuggestersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  IndexDocuments

        internal IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest request)
        {
            var marshaller = new IndexDocumentsRequestMarshaller();
            var unmarshaller = IndexDocumentsResponseUnmarshaller.Instance;

            return Invoke<IndexDocumentsRequest,IndexDocumentsResponse>(request, marshaller, unmarshaller);
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
        public Task<IndexDocumentsResponse> IndexDocumentsAsync(IndexDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new IndexDocumentsRequestMarshaller();
            var unmarshaller = IndexDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<IndexDocumentsRequest,IndexDocumentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDomainNames

        internal ListDomainNamesResponse ListDomainNames()
        {
            return ListDomainNames(new ListDomainNamesRequest());
        }
        internal ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var marshaller = new ListDomainNamesRequestMarshaller();
            var unmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesRequest,ListDomainNamesResponse>(request, marshaller, unmarshaller);
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
        public Task<ListDomainNamesResponse> ListDomainNamesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDomainNamesRequestMarshaller();
            var unmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainNamesRequest,ListDomainNamesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAvailabilityOptions

        internal UpdateAvailabilityOptionsResponse UpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request)
        {
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var unmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateAvailabilityOptionsRequest,UpdateAvailabilityOptionsResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateAvailabilityOptionsResponse> UpdateAvailabilityOptionsAsync(UpdateAvailabilityOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var unmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAvailabilityOptionsRequest,UpdateAvailabilityOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateScalingParameters

        internal UpdateScalingParametersResponse UpdateScalingParameters(UpdateScalingParametersRequest request)
        {
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var unmarshaller = UpdateScalingParametersResponseUnmarshaller.Instance;

            return Invoke<UpdateScalingParametersRequest,UpdateScalingParametersResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateScalingParametersResponse> UpdateScalingParametersAsync(UpdateScalingParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var unmarshaller = UpdateScalingParametersResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScalingParametersRequest,UpdateScalingParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceAccessPolicies

        internal UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request)
        {
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceAccessPoliciesRequest,UpdateServiceAccessPoliciesResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateServiceAccessPoliciesResponse> UpdateServiceAccessPoliciesAsync(UpdateServiceAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceAccessPoliciesRequest,UpdateServiceAccessPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}