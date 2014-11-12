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

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  BuildSuggesters

        /// <summary>
        /// Indexes the search suggestions. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html#configuring-suggesters">Configuring
        /// Suggesters</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BuildSuggesters service method.</param>
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
        public BuildSuggestersResponse BuildSuggesters(BuildSuggestersRequest request)
        {
            var marshaller = new BuildSuggestersRequestMarshaller();
            var unmarshaller = BuildSuggestersResponseUnmarshaller.Instance;

            return Invoke<BuildSuggestersRequest,BuildSuggestersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BuildSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BuildSuggesters operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBuildSuggesters
        ///         operation.</returns>
        public IAsyncResult BeginBuildSuggesters(BuildSuggestersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new BuildSuggestersRequestMarshaller();
            var unmarshaller = BuildSuggestersResponseUnmarshaller.Instance;

            return BeginInvoke<BuildSuggestersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BuildSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBuildSuggesters.</param>
        /// 
        /// <returns>Returns a  BuildSuggestersResult from CloudSearch.</returns>
        public  BuildSuggestersResponse EndBuildSuggesters(IAsyncResult asyncResult)
        {
            return EndInvoke<BuildSuggestersResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomain

        /// <summary>
        /// Creates a new search domain. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/creating-domains.html"
        /// target="_blank">Creating a Search Domain</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
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
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainRequest,CreateDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        public IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from CloudSearch.</returns>
        public  CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DefineAnalysisScheme

        /// <summary>
        /// Configures an analysis scheme that can be applied to a <code>text</code> or <code>text-array</code>
        /// field to define language-specific text processing options. For more information, see
        /// <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// target="_blank">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineAnalysisScheme service method.</param>
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
        public DefineAnalysisSchemeResponse DefineAnalysisScheme(DefineAnalysisSchemeRequest request)
        {
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var unmarshaller = DefineAnalysisSchemeResponseUnmarshaller.Instance;

            return Invoke<DefineAnalysisSchemeRequest,DefineAnalysisSchemeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DefineAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineAnalysisScheme operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineAnalysisScheme
        ///         operation.</returns>
        public IAsyncResult BeginDefineAnalysisScheme(DefineAnalysisSchemeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DefineAnalysisSchemeRequestMarshaller();
            var unmarshaller = DefineAnalysisSchemeResponseUnmarshaller.Instance;

            return BeginInvoke<DefineAnalysisSchemeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DefineAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineAnalysisScheme.</param>
        /// 
        /// <returns>Returns a  DefineAnalysisSchemeResult from CloudSearch.</returns>
        public  DefineAnalysisSchemeResponse EndDefineAnalysisScheme(IAsyncResult asyncResult)
        {
            return EndInvoke<DefineAnalysisSchemeResponse>(asyncResult);
        }

        #endregion
        
        #region  DefineExpression

        /// <summary>
        /// Configures an <code><a>Expression</a></code> for the search domain. Used to create
        /// new expressions and modify existing ones. If the expression exists, the new configuration
        /// replaces the old one. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
        /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineExpression service method.</param>
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
        public DefineExpressionResponse DefineExpression(DefineExpressionRequest request)
        {
            var marshaller = new DefineExpressionRequestMarshaller();
            var unmarshaller = DefineExpressionResponseUnmarshaller.Instance;

            return Invoke<DefineExpressionRequest,DefineExpressionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DefineExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineExpression operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineExpression
        ///         operation.</returns>
        public IAsyncResult BeginDefineExpression(DefineExpressionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DefineExpressionRequestMarshaller();
            var unmarshaller = DefineExpressionResponseUnmarshaller.Instance;

            return BeginInvoke<DefineExpressionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DefineExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineExpression.</param>
        /// 
        /// <returns>Returns a  DefineExpressionResult from CloudSearch.</returns>
        public  DefineExpressionResponse EndDefineExpression(IAsyncResult asyncResult)
        {
            return EndInvoke<DefineExpressionResponse>(asyncResult);
        }

        #endregion
        
        #region  DefineIndexField

        /// <summary>
        /// Configures an <code><a>IndexField</a></code> for the search domain. Used to create
        /// new fields and modify existing ones. You must specify the name of the domain you are
        /// configuring and an index field configuration. The index field configuration specifies
        /// a unique name, the index field type, and the options you want to configure for the
        /// field. The options you can specify depend on the <code><a>IndexFieldType</a></code>.
        /// If the field exists, the new configuration replaces the old one. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html"
        /// target="_blank">Configuring Index Fields</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField service method.</param>
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
        public DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest request)
        {
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var unmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return Invoke<DefineIndexFieldRequest,DefineIndexFieldResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DefineIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineIndexField
        ///         operation.</returns>
        public IAsyncResult BeginDefineIndexField(DefineIndexFieldRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var unmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return BeginInvoke<DefineIndexFieldRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DefineIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineIndexField.</param>
        /// 
        /// <returns>Returns a  DefineIndexFieldResult from CloudSearch.</returns>
        public  DefineIndexFieldResponse EndDefineIndexField(IAsyncResult asyncResult)
        {
            return EndInvoke<DefineIndexFieldResponse>(asyncResult);
        }

        #endregion
        
        #region  DefineSuggester

        /// <summary>
        /// Configures a suggester for a domain. A suggester enables you to display possible matches
        /// before users finish typing their queries. When you configure a suggester, you must
        /// specify the name of the text field you want to search for possible matches and a unique
        /// name for the suggester. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html"
        /// target="_blank">Getting Search Suggestions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineSuggester service method.</param>
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
        public DefineSuggesterResponse DefineSuggester(DefineSuggesterRequest request)
        {
            var marshaller = new DefineSuggesterRequestMarshaller();
            var unmarshaller = DefineSuggesterResponseUnmarshaller.Instance;

            return Invoke<DefineSuggesterRequest,DefineSuggesterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DefineSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineSuggester operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineSuggester
        ///         operation.</returns>
        public IAsyncResult BeginDefineSuggester(DefineSuggesterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DefineSuggesterRequestMarshaller();
            var unmarshaller = DefineSuggesterResponseUnmarshaller.Instance;

            return BeginInvoke<DefineSuggesterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DefineSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineSuggester.</param>
        /// 
        /// <returns>Returns a  DefineSuggesterResult from CloudSearch.</returns>
        public  DefineSuggesterResponse EndDefineSuggester(IAsyncResult asyncResult)
        {
            return EndInvoke<DefineSuggesterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAnalysisScheme

        /// <summary>
        /// Deletes an analysis scheme. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// target="_blank">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisScheme service method.</param>
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
        public DeleteAnalysisSchemeResponse DeleteAnalysisScheme(DeleteAnalysisSchemeRequest request)
        {
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var unmarshaller = DeleteAnalysisSchemeResponseUnmarshaller.Instance;

            return Invoke<DeleteAnalysisSchemeRequest,DeleteAnalysisSchemeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisScheme operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnalysisScheme
        ///         operation.</returns>
        public IAsyncResult BeginDeleteAnalysisScheme(DeleteAnalysisSchemeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteAnalysisSchemeRequestMarshaller();
            var unmarshaller = DeleteAnalysisSchemeResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAnalysisSchemeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnalysisScheme.</param>
        /// 
        /// <returns>Returns a  DeleteAnalysisSchemeResult from CloudSearch.</returns>
        public  DeleteAnalysisSchemeResponse EndDeleteAnalysisScheme(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAnalysisSchemeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomain

        /// <summary>
        /// Permanently deletes a search domain and all of its data. Once a domain has been deleted,
        /// it cannot be recovered. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/deleting-domains.html"
        /// target="_blank">Deleting a Search Domain</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
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
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainRequest,DeleteDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from CloudSearch.</returns>
        public  DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteExpression

        /// <summary>
        /// Removes an <code><a>Expression</a></code> from the search domain. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
        /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExpression service method.</param>
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
        public DeleteExpressionResponse DeleteExpression(DeleteExpressionRequest request)
        {
            var marshaller = new DeleteExpressionRequestMarshaller();
            var unmarshaller = DeleteExpressionResponseUnmarshaller.Instance;

            return Invoke<DeleteExpressionRequest,DeleteExpressionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExpression operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExpression
        ///         operation.</returns>
        public IAsyncResult BeginDeleteExpression(DeleteExpressionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteExpressionRequestMarshaller();
            var unmarshaller = DeleteExpressionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteExpressionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExpression.</param>
        /// 
        /// <returns>Returns a  DeleteExpressionResult from CloudSearch.</returns>
        public  DeleteExpressionResponse EndDeleteExpression(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteExpressionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIndexField

        /// <summary>
        /// Removes an <code><a>IndexField</a></code> from the search domain. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html"
        /// target="_blank">Configuring Index Fields</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField service method.</param>
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
        public DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest request)
        {
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var unmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return Invoke<DeleteIndexFieldRequest,DeleteIndexFieldResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndexField
        ///         operation.</returns>
        public IAsyncResult BeginDeleteIndexField(DeleteIndexFieldRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var unmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIndexFieldRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndexField.</param>
        /// 
        /// <returns>Returns a  DeleteIndexFieldResult from CloudSearch.</returns>
        public  DeleteIndexFieldResponse EndDeleteIndexField(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIndexFieldResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSuggester

        /// <summary>
        /// Deletes a suggester. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html"
        /// target="_blank">Getting Search Suggestions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuggester service method.</param>
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
        public DeleteSuggesterResponse DeleteSuggester(DeleteSuggesterRequest request)
        {
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var unmarshaller = DeleteSuggesterResponseUnmarshaller.Instance;

            return Invoke<DeleteSuggesterRequest,DeleteSuggesterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuggester operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSuggester
        ///         operation.</returns>
        public IAsyncResult BeginDeleteSuggester(DeleteSuggesterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteSuggesterRequestMarshaller();
            var unmarshaller = DeleteSuggesterResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSuggesterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSuggester.</param>
        /// 
        /// <returns>Returns a  DeleteSuggesterResult from CloudSearch.</returns>
        public  DeleteSuggesterResponse EndDeleteSuggester(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSuggesterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAnalysisSchemes

        /// <summary>
        /// Gets the analysis schemes configured for a domain. An analysis scheme defines language-specific
        /// text processing options for a <code>text</code> field. Can be limited to specific
        /// analysis schemes by name. By default, shows all analysis schemes and includes any
        /// pending changes to the configuration. Set the <code>Deployed</code> option to <code>true</code>
        /// to show the active configuration and exclude pending changes. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// target="_blank">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisSchemes service method.</param>
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
        public DescribeAnalysisSchemesResponse DescribeAnalysisSchemes(DescribeAnalysisSchemesRequest request)
        {
            var marshaller = new DescribeAnalysisSchemesRequestMarshaller();
            var unmarshaller = DescribeAnalysisSchemesResponseUnmarshaller.Instance;

            return Invoke<DescribeAnalysisSchemesRequest,DescribeAnalysisSchemesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnalysisSchemes operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisSchemes operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnalysisSchemes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAnalysisSchemes(DescribeAnalysisSchemesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAnalysisSchemesRequestMarshaller();
            var unmarshaller = DescribeAnalysisSchemesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAnalysisSchemesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnalysisSchemes operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnalysisSchemes.</param>
        /// 
        /// <returns>Returns a  DescribeAnalysisSchemesResult from CloudSearch.</returns>
        public  DescribeAnalysisSchemesResponse EndDescribeAnalysisSchemes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAnalysisSchemesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAvailabilityOptions

        /// <summary>
        /// Gets the availability options configured for a domain. By default, shows the configuration
        /// with any pending changes. Set the <code>Deployed</code> option to <code>true</code>
        /// to show the active configuration and exclude pending changes. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html"
        /// target="_blank">Configuring Availability Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions service method.</param>
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
        public DescribeAvailabilityOptionsResponse DescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request)
        {
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var unmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityOptionsRequest,DescribeAvailabilityOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAvailabilityOptions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var unmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAvailabilityOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a  DescribeAvailabilityOptionsResult from CloudSearch.</returns>
        public  DescribeAvailabilityOptionsResponse EndDescribeAvailabilityOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAvailabilityOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDomains

        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default. To get the number of searchable documents
        /// in a domain, use the console or submit a <code>matchall</code> request to your domain's
        /// search endpoint: <code>q=matchall&amp;amp;q.parser=structured&amp;amp;size=0</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-domain-info.html"
        /// target="_blank">Getting Information about a Search Domain</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
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
        public DescribeDomainsResponse DescribeDomains()
        {
            return DescribeDomains(new DescribeDomainsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains service method.</param>
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
        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            var marshaller = new DescribeDomainsRequestMarshaller();
            var unmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainsRequest,DescribeDomainsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomains operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomains
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDomains(DescribeDomainsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDomainsRequestMarshaller();
            var unmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDomainsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomains operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomains.</param>
        /// 
        /// <returns>Returns a  DescribeDomainsResult from CloudSearch.</returns>
        public  DescribeDomainsResponse EndDescribeDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExpressions

        /// <summary>
        /// Gets the expressions configured for the search domain. Can be limited to specific
        /// expressions by name. By default, shows all expressions and includes any pending changes
        /// to the configuration. Set the <code>Deployed</code> option to <code>true</code> to
        /// show the active configuration and exclude pending changes. For more information, see
        /// <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
        /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExpressions service method.</param>
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
        public DescribeExpressionsResponse DescribeExpressions(DescribeExpressionsRequest request)
        {
            var marshaller = new DescribeExpressionsRequestMarshaller();
            var unmarshaller = DescribeExpressionsResponseUnmarshaller.Instance;

            return Invoke<DescribeExpressionsRequest,DescribeExpressionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExpressions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExpressions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeExpressions(DescribeExpressionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeExpressionsRequestMarshaller();
            var unmarshaller = DescribeExpressionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeExpressionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExpressions.</param>
        /// 
        /// <returns>Returns a  DescribeExpressionsResult from CloudSearch.</returns>
        public  DescribeExpressionsResponse EndDescribeExpressions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExpressionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIndexFields

        /// <summary>
        /// Gets information about the index fields configured for the search domain. Can be limited
        /// to specific fields by name. By default, shows all fields and includes any pending
        /// changes to the configuration. Set the <code>Deployed</code> option to <code>true</code>
        /// to show the active configuration and exclude pending changes. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-domain-info.html"
        /// target="_blank">Getting Domain Information</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields service method.</param>
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
        public DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest request)
        {
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var unmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return Invoke<DescribeIndexFieldsRequest,DescribeIndexFieldsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndexFields operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIndexFields
        ///         operation.</returns>
        public IAsyncResult BeginDescribeIndexFields(DescribeIndexFieldsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var unmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeIndexFieldsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIndexFields operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIndexFields.</param>
        /// 
        /// <returns>Returns a  DescribeIndexFieldsResult from CloudSearch.</returns>
        public  DescribeIndexFieldsResponse EndDescribeIndexFields(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIndexFieldsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScalingParameters

        /// <summary>
        /// Gets the scaling parameters configured for a domain. A domain's scaling parameters
        /// specify the desired search instance type and replication count. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html"
        /// target="_blank">Configuring Scaling Options</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingParameters service method.</param>
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
        public DescribeScalingParametersResponse DescribeScalingParameters(DescribeScalingParametersRequest request)
        {
            var marshaller = new DescribeScalingParametersRequestMarshaller();
            var unmarshaller = DescribeScalingParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingParametersRequest,DescribeScalingParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingParameters operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingParameters
        ///         operation.</returns>
        public IAsyncResult BeginDescribeScalingParameters(DescribeScalingParametersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeScalingParametersRequestMarshaller();
            var unmarshaller = DescribeScalingParametersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeScalingParametersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingParameters.</param>
        /// 
        /// <returns>Returns a  DescribeScalingParametersResult from CloudSearch.</returns>
        public  DescribeScalingParametersResponse EndDescribeScalingParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalingParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeServiceAccessPolicies

        /// <summary>
        /// Gets information about the access policies that control access to the domain's document
        /// and search endpoints. By default, shows the configuration with any pending changes.
        /// Set the <code>Deployed</code> option to <code>true</code> to show the active configuration
        /// and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"
        /// target="_blank">Configuring Access for a Search Domain</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies service method.</param>
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
        public DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request)
        {
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceAccessPoliciesRequest,DescribeServiceAccessPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceAccessPolicies
        ///         operation.</returns>
        public IAsyncResult BeginDescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeServiceAccessPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeServiceAccessPoliciesResult from CloudSearch.</returns>
        public  DescribeServiceAccessPoliciesResponse EndDescribeServiceAccessPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeServiceAccessPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSuggesters

        /// <summary>
        /// Gets the suggesters configured for a domain. A suggester enables you to display possible
        /// matches before users finish typing their queries. Can be limited to specific suggesters
        /// by name. By default, shows all suggesters and includes any pending changes to the
        /// configuration. Set the <code>Deployed</code> option to <code>true</code> to show the
        /// active configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html"
        /// target="_blank">Getting Search Suggestions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSuggesters service method.</param>
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
        public DescribeSuggestersResponse DescribeSuggesters(DescribeSuggestersRequest request)
        {
            var marshaller = new DescribeSuggestersRequestMarshaller();
            var unmarshaller = DescribeSuggestersResponseUnmarshaller.Instance;

            return Invoke<DescribeSuggestersRequest,DescribeSuggestersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSuggesters operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSuggesters
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSuggesters(DescribeSuggestersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSuggestersRequestMarshaller();
            var unmarshaller = DescribeSuggestersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSuggestersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSuggesters.</param>
        /// 
        /// <returns>Returns a  DescribeSuggestersResult from CloudSearch.</returns>
        public  DescribeSuggestersResponse EndDescribeSuggesters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSuggestersResponse>(asyncResult);
        }

        #endregion
        
        #region  IndexDocuments

        /// <summary>
        /// Tells the search domain to start indexing its documents using the latest indexing
        /// options. This operation must be invoked to activate options whose <a>OptionStatus</a>
        /// is <code>RequiresIndexDocuments</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments service method.</param>
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
        public IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest request)
        {
            var marshaller = new IndexDocumentsRequestMarshaller();
            var unmarshaller = IndexDocumentsResponseUnmarshaller.Instance;

            return Invoke<IndexDocumentsRequest,IndexDocumentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the IndexDocuments operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIndexDocuments
        ///         operation.</returns>
        public IAsyncResult BeginIndexDocuments(IndexDocumentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new IndexDocumentsRequestMarshaller();
            var unmarshaller = IndexDocumentsResponseUnmarshaller.Instance;

            return BeginInvoke<IndexDocumentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  IndexDocuments operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIndexDocuments.</param>
        /// 
        /// <returns>Returns a  IndexDocumentsResult from CloudSearch.</returns>
        public  IndexDocumentsResponse EndIndexDocuments(IAsyncResult asyncResult)
        {
            return EndInvoke<IndexDocumentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomainNames

        /// <summary>
        /// Lists all search domains owned by an account.
        /// </summary>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        public ListDomainNamesResponse ListDomainNames()
        {
            return ListDomainNames(new ListDomainNamesRequest());
        }

        /// <summary>
        /// Lists all search domains owned by an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        public ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var marshaller = new ListDomainNamesRequestMarshaller();
            var unmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesRequest,ListDomainNamesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainNames
        ///         operation.</returns>
        public IAsyncResult BeginListDomainNames(ListDomainNamesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDomainNamesRequestMarshaller();
            var unmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return BeginInvoke<ListDomainNamesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainNames operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainNames.</param>
        /// 
        /// <returns>Returns a  ListDomainNamesResult from CloudSearch.</returns>
        public  ListDomainNamesResponse EndListDomainNames(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAvailabilityOptions

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
        public UpdateAvailabilityOptionsResponse UpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request)
        {
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var unmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateAvailabilityOptionsRequest,UpdateAvailabilityOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAvailabilityOptions
        ///         operation.</returns>
        public IAsyncResult BeginUpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var unmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAvailabilityOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a  UpdateAvailabilityOptionsResult from CloudSearch.</returns>
        public  UpdateAvailabilityOptionsResponse EndUpdateAvailabilityOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAvailabilityOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateScalingParameters

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
        public UpdateScalingParametersResponse UpdateScalingParameters(UpdateScalingParametersRequest request)
        {
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var unmarshaller = UpdateScalingParametersResponseUnmarshaller.Instance;

            return Invoke<UpdateScalingParametersRequest,UpdateScalingParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScalingParameters operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScalingParameters
        ///         operation.</returns>
        public IAsyncResult BeginUpdateScalingParameters(UpdateScalingParametersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateScalingParametersRequestMarshaller();
            var unmarshaller = UpdateScalingParametersResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateScalingParametersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScalingParameters.</param>
        /// 
        /// <returns>Returns a  UpdateScalingParametersResult from CloudSearch.</returns>
        public  UpdateScalingParametersResponse EndUpdateScalingParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateScalingParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServiceAccessPolicies

        /// <summary>
        /// Configures the access rules that control access to the domain's document and search
        /// endpoints. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"
        /// target="_blank"> Configuring Access for an Amazon CloudSearch Domain</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service method.</param>
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
        public UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request)
        {
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceAccessPoliciesRequest,UpdateServiceAccessPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceAccessPolicies
        ///         operation.</returns>
        public IAsyncResult BeginUpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateServiceAccessPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a  UpdateServiceAccessPoliciesResult from CloudSearch.</returns>
        public  UpdateServiceAccessPoliciesResponse EndUpdateServiceAccessPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceAccessPoliciesResponse>(asyncResult);
        }

        #endregion
        
    }
}