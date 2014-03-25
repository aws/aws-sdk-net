/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.CloudSearch.Model;
using Amazon.CloudSearch.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch
{
    /// <summary>
    /// Implementation for accessing AmazonCloudSearch.
    /// 
    /// Amazon CloudSearch Configuration Service <para>You use the Amazon CloudSearch configuration service to create, configure, and manage search
    /// domains. Configuration service requests are submitted using the AWS Query protocol. AWS Query requests are HTTP or HTTPS requests submitted
    /// via HTTP GET or POST with a query parameter named Action.</para> <para>The endpoint for configuration service requests is region-specific:
    /// cloudsearch. <i>region</i> .amazonaws.com. For example, cloudsearch.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#cloudsearch_region">Regions and Endpoints</a> .</para>
    /// </summary>
	public partial class AmazonCloudSearchClient : AmazonWebServiceClient, Amazon.CloudSearch.IAmazonCloudSearch
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

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
            : this(credentials, new AmazonCloudSearchConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Credentials and an
        /// AmazonCloudSearchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(AWSCredentials credentials, AmazonCloudSearchConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
        /// AmazonCloudSearchClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudSearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudSearchConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudSearchClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudSearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal BuildSuggestersResponse BuildSuggesters(BuildSuggestersRequest request)
        {
            var task = BuildSuggestersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Indexes the search suggestions. </para>
        /// </summary>
        /// 
        /// <param name="buildSuggestersRequest">Container for the necessary parameters to execute the BuildSuggesters service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the BuildSuggesters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<BuildSuggestersResponse> BuildSuggestersAsync(BuildSuggestersRequest buildSuggestersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BuildSuggestersRequestMarshaller();
            var unmarshaller = BuildSuggestersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, BuildSuggestersRequest, BuildSuggestersResponse>(buildSuggestersRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var task = CreateDomainAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Creates a new search domain. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/creating-domains.html">Creating a Search Domain</a> in the <i>Amazon
        /// CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createDomainRequest">Container for the necessary parameters to execute the CreateDomain service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateDomainRequest, CreateDomainResponse>(createDomainRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DefineAnalysisSchemeResponse DefineAnalysisScheme(DefineAnalysisSchemeRequest request)
        {
            var task = DefineAnalysisSchemeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Configures an analysis scheme for a domain. An analysis scheme defines language-specific text processing options for a <c>text</c>
        /// field. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineAnalysisSchemeRequest">Container for the necessary parameters to execute the DefineAnalysisScheme service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineAnalysisScheme service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DefineAnalysisSchemeResponse> DefineAnalysisSchemeAsync(DefineAnalysisSchemeRequest defineAnalysisSchemeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var unmarshaller = DefineAnalysisSchemeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DefineAnalysisSchemeRequest, DefineAnalysisSchemeResponse>(defineAnalysisSchemeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DefineExpressionResponse DefineExpression(DefineExpressionRequest request)
        {
            var task = DefineExpressionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Configures an <c> Expression </c> for the search domain. Used to create new expressions and modify existing ones. If the expression
        /// exists, the new configuration replaces the old one. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html">Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineExpressionRequest">Container for the necessary parameters to execute the DefineExpression service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DefineExpressionResponse> DefineExpressionAsync(DefineExpressionRequest defineExpressionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DefineExpressionRequestMarshaller();
            var unmarshaller = DefineExpressionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DefineExpressionRequest, DefineExpressionResponse>(defineExpressionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest request)
        {
            var task = DefineIndexFieldAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Configures an <c> IndexField </c> for the search domain. Used to create new fields and modify existing ones. You must specify the name
        /// of the domain you are configuring and an index field configuration. The index field configuration specifies a unique name, the index field
        /// type, and the options you want to configure for the field. The options you can specify depend on the <c> IndexFieldType </c> . If the field
        /// exists, the new configuration replaces the old one. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html">Configuring Index Fields</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="defineIndexFieldRequest">Container for the necessary parameters to execute the DefineIndexField service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DefineIndexFieldResponse> DefineIndexFieldAsync(DefineIndexFieldRequest defineIndexFieldRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var unmarshaller = DefineIndexFieldResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DefineIndexFieldRequest, DefineIndexFieldResponse>(defineIndexFieldRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DefineSuggesterResponse DefineSuggester(DefineSuggesterRequest request)
        {
            var task = DefineSuggesterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Configures a suggester for a domain. A suggester enables you to display possible matches before users finish typing their queries.
        /// When you configure a suggester, you must specify the name of the text field you want to search for possible matches and a unique name for
        /// the suggester. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html">Getting Search Suggestions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineSuggesterRequest">Container for the necessary parameters to execute the DefineSuggester service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineSuggester service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DefineSuggesterResponse> DefineSuggesterAsync(DefineSuggesterRequest defineSuggesterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DefineSuggesterRequestMarshaller();
            var unmarshaller = DefineSuggesterResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DefineSuggesterRequest, DefineSuggesterResponse>(defineSuggesterRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteAnalysisSchemeResponse DeleteAnalysisScheme(DeleteAnalysisSchemeRequest request)
        {
            var task = DeleteAnalysisSchemeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Deletes an analysis scheme. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html.html">Configuring Analysis Schemes</a>
        /// in the <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="deleteAnalysisSchemeRequest">Container for the necessary parameters to execute the DeleteAnalysisScheme service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteAnalysisScheme service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteAnalysisSchemeResponse> DeleteAnalysisSchemeAsync(DeleteAnalysisSchemeRequest deleteAnalysisSchemeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var unmarshaller = DeleteAnalysisSchemeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteAnalysisSchemeRequest, DeleteAnalysisSchemeResponse>(deleteAnalysisSchemeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var task = DeleteDomainAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Permanently deletes a search domain and all of its data. Once a domain has been deleted, it cannot be recovered. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/deleting-domains.html">Deleting a Search Domain</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="deleteDomainRequest">Container for the necessary parameters to execute the DeleteDomain service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteDomainRequest, DeleteDomainResponse>(deleteDomainRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteExpressionResponse DeleteExpression(DeleteExpressionRequest request)
        {
            var task = DeleteExpressionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Removes an <c> Expression </c> from the search domain. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html">Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteExpressionRequest">Container for the necessary parameters to execute the DeleteExpression service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteExpressionResponse> DeleteExpressionAsync(DeleteExpressionRequest deleteExpressionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteExpressionRequestMarshaller();
            var unmarshaller = DeleteExpressionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteExpressionRequest, DeleteExpressionResponse>(deleteExpressionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest request)
        {
            var task = DeleteIndexFieldAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Removes an <c> IndexField </c> from the search domain. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html">Configuring Index Fields</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteIndexFieldRequest">Container for the necessary parameters to execute the DeleteIndexField service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteIndexFieldResponse> DeleteIndexFieldAsync(DeleteIndexFieldRequest deleteIndexFieldRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var unmarshaller = DeleteIndexFieldResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteIndexFieldRequest, DeleteIndexFieldResponse>(deleteIndexFieldRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteSuggesterResponse DeleteSuggester(DeleteSuggesterRequest request)
        {
            var task = DeleteSuggesterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Deletes a suggester. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html">Getting Search Suggestions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteSuggesterRequest">Container for the necessary parameters to execute the DeleteSuggester service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteSuggester service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteSuggesterResponse> DeleteSuggesterAsync(DeleteSuggesterRequest deleteSuggesterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var unmarshaller = DeleteSuggesterResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteSuggesterRequest, DeleteSuggesterResponse>(deleteSuggesterRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeAnalysisSchemesResponse DescribeAnalysisSchemes(DescribeAnalysisSchemesRequest request)
        {
            var task = DescribeAnalysisSchemesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Gets the analysis schemes configured for a domain. An analysis scheme defines language-specific text processing options for a
        /// <c>text</c> field. Can be limited to specific analysis schemes by name. By default, shows all analysis schemes and includes any pending
        /// changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes.
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAnalysisSchemesRequest">Container for the necessary parameters to execute the DescribeAnalysisSchemes service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeAnalysisSchemes service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeAnalysisSchemesResponse> DescribeAnalysisSchemesAsync(DescribeAnalysisSchemesRequest describeAnalysisSchemesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAnalysisSchemesRequestMarshaller();
            var unmarshaller = DescribeAnalysisSchemesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAnalysisSchemesRequest, DescribeAnalysisSchemesResponse>(describeAnalysisSchemesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeAvailabilityOptionsResponse DescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request)
        {
            var task = DescribeAvailabilityOptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Gets the availability options configured for a domain. By default, shows the configuration with any pending changes. Set the
        /// <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html">Configuring Availability
        /// Options</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityOptionsRequest">Container for the necessary parameters to execute the DescribeAvailabilityOptions service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.DisabledOperationException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeAvailabilityOptionsResponse> DescribeAvailabilityOptionsAsync(DescribeAvailabilityOptionsRequest describeAvailabilityOptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var unmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAvailabilityOptionsRequest, DescribeAvailabilityOptionsResponse>(describeAvailabilityOptionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            var task = DescribeDomainsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by default. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html">Getting Information about
        /// a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeDomainsRequest">Container for the necessary parameters to execute the DescribeDomains service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest describeDomainsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDomainsRequestMarshaller();
            var unmarshaller = DescribeDomainsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDomainsRequest, DescribeDomainsResponse>(describeDomainsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeExpressionsResponse DescribeExpressions(DescribeExpressionsRequest request)
        {
            var task = DescribeExpressionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Gets the expressions configured for the search domain. Can be limited to specific expressions by name. By default, shows all
        /// expressions and includes any pending changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html">Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeExpressionsRequest">Container for the necessary parameters to execute the DescribeExpressions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeExpressions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeExpressionsResponse> DescribeExpressionsAsync(DescribeExpressionsRequest describeExpressionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeExpressionsRequestMarshaller();
            var unmarshaller = DescribeExpressionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeExpressionsRequest, DescribeExpressionsResponse>(describeExpressionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest request)
        {
            var task = DescribeIndexFieldsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Gets information about the index fields configured for the search domain. Can be limited to specific fields by name. By default,
        /// shows all fields and includes any pending changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html">Getting Domain Information</a> in the <i>Amazon
        /// CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeIndexFieldsRequest">Container for the necessary parameters to execute the DescribeIndexFields service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeIndexFieldsResponse> DescribeIndexFieldsAsync(DescribeIndexFieldsRequest describeIndexFieldsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var unmarshaller = DescribeIndexFieldsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeIndexFieldsRequest, DescribeIndexFieldsResponse>(describeIndexFieldsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeScalingParametersResponse DescribeScalingParameters(DescribeScalingParametersRequest request)
        {
            var task = DescribeScalingParametersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Gets the scaling parameters configured for a domain. A domain's scaling parameters specify the desired search instance type and
        /// replication count. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html">Configuring Scaling Options</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeScalingParametersRequest">Container for the necessary parameters to execute the DescribeScalingParameters service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeScalingParameters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeScalingParametersResponse> DescribeScalingParametersAsync(DescribeScalingParametersRequest describeScalingParametersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingParametersRequestMarshaller();
            var unmarshaller = DescribeScalingParametersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeScalingParametersRequest, DescribeScalingParametersResponse>(describeScalingParametersRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request)
        {
            var task = DescribeServiceAccessPoliciesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Gets information about the access policies that control access to the domain's document and search endpoints. By default, shows the
        /// configuration with any pending changes. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending
        /// changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html">Configuring Access for a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeServiceAccessPoliciesRequest">Container for the necessary parameters to execute the DescribeServiceAccessPolicies
        /// service method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeServiceAccessPoliciesResponse> DescribeServiceAccessPoliciesAsync(DescribeServiceAccessPoliciesRequest describeServiceAccessPoliciesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeServiceAccessPoliciesRequest, DescribeServiceAccessPoliciesResponse>(describeServiceAccessPoliciesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeSuggestersResponse DescribeSuggesters(DescribeSuggestersRequest request)
        {
            var task = DescribeSuggestersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Gets the suggesters configured for a domain. A suggester enables you to display possible matches before users finish typing their
        /// queries. Can be limited to specific suggesters by name. By default, shows all suggesters and includes any pending changes to the
        /// configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes. For more
        /// information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html">Getting Search
        /// Suggestions</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSuggestersRequest">Container for the necessary parameters to execute the DescribeSuggesters service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeSuggesters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeSuggestersResponse> DescribeSuggestersAsync(DescribeSuggestersRequest describeSuggestersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSuggestersRequestMarshaller();
            var unmarshaller = DescribeSuggestersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSuggestersRequest, DescribeSuggestersResponse>(describeSuggestersRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest request)
        {
            var task = IndexDocumentsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Tells the search domain to start indexing its documents using the latest indexing options. This operation must be invoked to activate
        /// options whose OptionStatus is <c>RequiresIndexDocuments</c> .</para>
        /// </summary>
        /// 
        /// <param name="indexDocumentsRequest">Container for the necessary parameters to execute the IndexDocuments service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<IndexDocumentsResponse> IndexDocumentsAsync(IndexDocumentsRequest indexDocumentsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new IndexDocumentsRequestMarshaller();
            var unmarshaller = IndexDocumentsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, IndexDocumentsRequest, IndexDocumentsResponse>(indexDocumentsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var task = ListDomainNamesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Lists all search domains owned by an account.</para>
        /// </summary>
        /// 
        /// <param name="listDomainNamesRequest">Container for the necessary parameters to execute the ListDomainNames service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest listDomainNamesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDomainNamesRequestMarshaller();
            var unmarshaller = ListDomainNamesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListDomainNamesRequest, ListDomainNamesResponse>(listDomainNamesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateAvailabilityOptionsResponse UpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request)
        {
            var task = UpdateAvailabilityOptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Configures the availability options for a domain. Enabling the Multi-AZ option expands an Amazon CloudSearch domain to an additional
        /// Availability Zone in the same Region to increase fault tolerance in the event of a service disruption. Changes to the Multi-AZ option can
        /// take about half an hour to become active. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html">Configuring Availability
        /// Options</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="updateAvailabilityOptionsRequest">Container for the necessary parameters to execute the UpdateAvailabilityOptions service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateAvailabilityOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.DisabledOperationException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateAvailabilityOptionsResponse> UpdateAvailabilityOptionsAsync(UpdateAvailabilityOptionsRequest updateAvailabilityOptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var unmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateAvailabilityOptionsRequest, UpdateAvailabilityOptionsResponse>(updateAvailabilityOptionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateScalingParametersResponse UpdateScalingParameters(UpdateScalingParametersRequest request)
        {
            var task = UpdateScalingParametersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Configures scaling parameters for a domain. A domain's scaling parameters specify the desired search instance type and replication
        /// count. Amazon CloudSearch will still automatically scale your domain based on the volume of data and traffic, but not below the desired
        /// instance type and replication count. If the Multi-AZ option is enabled, these values control the resources used per Availability Zone. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html">Configuring
        /// Scaling Options</a> in the <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="updateScalingParametersRequest">Container for the necessary parameters to execute the UpdateScalingParameters service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateScalingParameters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateScalingParametersResponse> UpdateScalingParametersAsync(UpdateScalingParametersRequest updateScalingParametersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var unmarshaller = UpdateScalingParametersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateScalingParametersRequest, UpdateScalingParametersResponse>(updateScalingParametersRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request)
        {
            var task = UpdateServiceAccessPoliciesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>Configures the access rules that control access to the domain's document and search endpoints. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"> Configuring Access for an Amazon CloudSearch
        /// Domain</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateServiceAccessPoliciesRequest">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateServiceAccessPoliciesResponse> UpdateServiceAccessPoliciesAsync(UpdateServiceAccessPoliciesRequest updateServiceAccessPoliciesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateServiceAccessPoliciesRequest, UpdateServiceAccessPoliciesResponse>(updateServiceAccessPoliciesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
