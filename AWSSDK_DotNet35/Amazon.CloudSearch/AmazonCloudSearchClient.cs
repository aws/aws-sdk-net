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
using System;
using System.Threading;

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
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#cloudsearch_region" >Regions and Endpoints</a> .</para>
    /// </summary>
    public partial class AmazonCloudSearchClient : AmazonWebServiceClient, IAmazonCloudSearch
    {
    AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudSearchConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudSearchConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
        /// <param name="config">The AmazonCloudSearch Configuration Object</param>
        public AmazonCloudSearchClient(AmazonCloudSearchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
        /// AmazonCloudSearchClient Configuration object. 
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region BuildSuggesters

        /// <summary>
        /// <para>Indexes the search suggestions. </para>
        /// </summary>
        /// 
        /// <param name="buildSuggestersRequest">Container for the necessary parameters to execute the BuildSuggesters service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the BuildSuggesters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public BuildSuggestersResponse BuildSuggesters(BuildSuggestersRequest buildSuggestersRequest)
        {
            IAsyncResult asyncResult = invokeBuildSuggesters(buildSuggestersRequest, null, null, true);
            return EndBuildSuggesters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the BuildSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.BuildSuggesters"/>
        /// </summary>
        /// 
        /// <param name="buildSuggestersRequest">Container for the necessary parameters to execute the BuildSuggesters operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBuildSuggesters
        ///         operation.</returns>
        public IAsyncResult BeginBuildSuggesters(BuildSuggestersRequest buildSuggestersRequest, AsyncCallback callback, object state)
        {
            return invokeBuildSuggesters(buildSuggestersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the BuildSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.BuildSuggesters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBuildSuggesters.</param>
        /// 
        /// <returns>Returns a BuildSuggestersResult from AmazonCloudSearch.</returns>
        public BuildSuggestersResponse EndBuildSuggesters(IAsyncResult asyncResult)
        {
            return endOperation<BuildSuggestersResponse>(asyncResult);
        }
        
        IAsyncResult invokeBuildSuggesters(BuildSuggestersRequest buildSuggestersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new BuildSuggestersRequestMarshaller().Marshall(buildSuggestersRequest);
            var unmarshaller = BuildSuggestersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDomain

        /// <summary>
        /// <para>Creates a new search domain. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/creating-domains.html" >Creating a Search Domain</a> in the <i>Amazon
        /// CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createDomainRequest">Container for the necessary parameters to execute the CreateDomain service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        public CreateDomainResponse CreateDomain(CreateDomainRequest createDomainRequest)
        {
            IAsyncResult asyncResult = invokeCreateDomain(createDomainRequest, null, null, true);
            return EndCreateDomain(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.CreateDomain"/>
        /// </summary>
        /// 
        /// <param name="createDomainRequest">Container for the necessary parameters to execute the CreateDomain operation on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        public IAsyncResult BeginCreateDomain(CreateDomainRequest createDomainRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDomain(createDomainRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.CreateDomain"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a CreateDomainResult from AmazonCloudSearch.</returns>
        public CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult)
        {
            return endOperation<CreateDomainResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDomain(CreateDomainRequest createDomainRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDomainRequestMarshaller().Marshall(createDomainRequest);
            var unmarshaller = CreateDomainResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DefineAnalysisScheme

        /// <summary>
        /// <para>Configures an analysis scheme for a domain. An analysis scheme defines language-specific text processing options for a <c>text</c>
        /// field. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// >Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineAnalysisSchemeRequest">Container for the necessary parameters to execute the DefineAnalysisScheme service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineAnalysisScheme service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        public DefineAnalysisSchemeResponse DefineAnalysisScheme(DefineAnalysisSchemeRequest defineAnalysisSchemeRequest)
        {
            IAsyncResult asyncResult = invokeDefineAnalysisScheme(defineAnalysisSchemeRequest, null, null, true);
            return EndDefineAnalysisScheme(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DefineAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineAnalysisScheme"/>
        /// </summary>
        /// 
        /// <param name="defineAnalysisSchemeRequest">Container for the necessary parameters to execute the DefineAnalysisScheme operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDefineAnalysisScheme operation.</returns>
        public IAsyncResult BeginDefineAnalysisScheme(DefineAnalysisSchemeRequest defineAnalysisSchemeRequest, AsyncCallback callback, object state)
        {
            return invokeDefineAnalysisScheme(defineAnalysisSchemeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DefineAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineAnalysisScheme"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineAnalysisScheme.</param>
        /// 
        /// <returns>Returns a DefineAnalysisSchemeResult from AmazonCloudSearch.</returns>
        public DefineAnalysisSchemeResponse EndDefineAnalysisScheme(IAsyncResult asyncResult)
        {
            return endOperation<DefineAnalysisSchemeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDefineAnalysisScheme(DefineAnalysisSchemeRequest defineAnalysisSchemeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DefineAnalysisSchemeRequestMarshaller().Marshall(defineAnalysisSchemeRequest);
            var unmarshaller = DefineAnalysisSchemeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DefineExpression

        /// <summary>
        /// <para>Configures an <c> Expression </c> for the search domain. Used to create new expressions and modify existing ones. If the expression
        /// exists, the new configuration replaces the old one. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html" >Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineExpressionRequest">Container for the necessary parameters to execute the DefineExpression service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        public DefineExpressionResponse DefineExpression(DefineExpressionRequest defineExpressionRequest)
        {
            IAsyncResult asyncResult = invokeDefineExpression(defineExpressionRequest, null, null, true);
            return EndDefineExpression(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DefineExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineExpression"/>
        /// </summary>
        /// 
        /// <param name="defineExpressionRequest">Container for the necessary parameters to execute the DefineExpression operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineExpression
        ///         operation.</returns>
        public IAsyncResult BeginDefineExpression(DefineExpressionRequest defineExpressionRequest, AsyncCallback callback, object state)
        {
            return invokeDefineExpression(defineExpressionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DefineExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineExpression"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineExpression.</param>
        /// 
        /// <returns>Returns a DefineExpressionResult from AmazonCloudSearch.</returns>
        public DefineExpressionResponse EndDefineExpression(IAsyncResult asyncResult)
        {
            return endOperation<DefineExpressionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDefineExpression(DefineExpressionRequest defineExpressionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DefineExpressionRequestMarshaller().Marshall(defineExpressionRequest);
            var unmarshaller = DefineExpressionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DefineIndexField

        /// <summary>
        /// <para>Configures an <c> IndexField </c> for the search domain. Used to create new fields and modify existing ones. You must specify the name
        /// of the domain you are configuring and an index field configuration. The index field configuration specifies a unique name, the index field
        /// type, and the options you want to configure for the field. The options you can specify depend on the <c> IndexFieldType </c> . If the field
        /// exists, the new configuration replaces the old one. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html" >Configuring Index Fields</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="defineIndexFieldRequest">Container for the necessary parameters to execute the DefineIndexField service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        public DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest defineIndexFieldRequest)
        {
            IAsyncResult asyncResult = invokeDefineIndexField(defineIndexFieldRequest, null, null, true);
            return EndDefineIndexField(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DefineIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineIndexField"/>
        /// </summary>
        /// 
        /// <param name="defineIndexFieldRequest">Container for the necessary parameters to execute the DefineIndexField operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineIndexField
        ///         operation.</returns>
        public IAsyncResult BeginDefineIndexField(DefineIndexFieldRequest defineIndexFieldRequest, AsyncCallback callback, object state)
        {
            return invokeDefineIndexField(defineIndexFieldRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DefineIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineIndexField"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineIndexField.</param>
        /// 
        /// <returns>Returns a DefineIndexFieldResult from AmazonCloudSearch.</returns>
        public DefineIndexFieldResponse EndDefineIndexField(IAsyncResult asyncResult)
        {
            return endOperation<DefineIndexFieldResponse>(asyncResult);
        }
        
        IAsyncResult invokeDefineIndexField(DefineIndexFieldRequest defineIndexFieldRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DefineIndexFieldRequestMarshaller().Marshall(defineIndexFieldRequest);
            var unmarshaller = DefineIndexFieldResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DefineSuggester

        /// <summary>
        /// <para>Configures a suggester for a domain. A suggester enables you to display possible matches before users finish typing their queries.
        /// When you configure a suggester, you must specify the name of the text field you want to search for possible matches and a unique name for
        /// the suggester. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html" >Getting Search Suggestions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineSuggesterRequest">Container for the necessary parameters to execute the DefineSuggester service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineSuggester service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        public DefineSuggesterResponse DefineSuggester(DefineSuggesterRequest defineSuggesterRequest)
        {
            IAsyncResult asyncResult = invokeDefineSuggester(defineSuggesterRequest, null, null, true);
            return EndDefineSuggester(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DefineSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineSuggester"/>
        /// </summary>
        /// 
        /// <param name="defineSuggesterRequest">Container for the necessary parameters to execute the DefineSuggester operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineSuggester
        ///         operation.</returns>
        public IAsyncResult BeginDefineSuggester(DefineSuggesterRequest defineSuggesterRequest, AsyncCallback callback, object state)
        {
            return invokeDefineSuggester(defineSuggesterRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DefineSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineSuggester"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineSuggester.</param>
        /// 
        /// <returns>Returns a DefineSuggesterResult from AmazonCloudSearch.</returns>
        public DefineSuggesterResponse EndDefineSuggester(IAsyncResult asyncResult)
        {
            return endOperation<DefineSuggesterResponse>(asyncResult);
        }
        
        IAsyncResult invokeDefineSuggester(DefineSuggesterRequest defineSuggesterRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DefineSuggesterRequestMarshaller().Marshall(defineSuggesterRequest);
            var unmarshaller = DefineSuggesterResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteAnalysisScheme

        /// <summary>
        /// <para>Deletes an analysis scheme. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html.html" >Configuring Analysis Schemes</a>
        /// in the <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="deleteAnalysisSchemeRequest">Container for the necessary parameters to execute the DeleteAnalysisScheme service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteAnalysisScheme service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public DeleteAnalysisSchemeResponse DeleteAnalysisScheme(DeleteAnalysisSchemeRequest deleteAnalysisSchemeRequest)
        {
            IAsyncResult asyncResult = invokeDeleteAnalysisScheme(deleteAnalysisSchemeRequest, null, null, true);
            return EndDeleteAnalysisScheme(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteAnalysisScheme"/>
        /// </summary>
        /// 
        /// <param name="deleteAnalysisSchemeRequest">Container for the necessary parameters to execute the DeleteAnalysisScheme operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteAnalysisScheme operation.</returns>
        public IAsyncResult BeginDeleteAnalysisScheme(DeleteAnalysisSchemeRequest deleteAnalysisSchemeRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteAnalysisScheme(deleteAnalysisSchemeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteAnalysisScheme"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnalysisScheme.</param>
        /// 
        /// <returns>Returns a DeleteAnalysisSchemeResult from AmazonCloudSearch.</returns>
        public DeleteAnalysisSchemeResponse EndDeleteAnalysisScheme(IAsyncResult asyncResult)
        {
            return endOperation<DeleteAnalysisSchemeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteAnalysisScheme(DeleteAnalysisSchemeRequest deleteAnalysisSchemeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteAnalysisSchemeRequestMarshaller().Marshall(deleteAnalysisSchemeRequest);
            var unmarshaller = DeleteAnalysisSchemeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDomain

        /// <summary>
        /// <para>Permanently deletes a search domain and all of its data. Once a domain has been deleted, it cannot be recovered. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/deleting-domains.html" >Deleting a Search Domain</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="deleteDomainRequest">Container for the necessary parameters to execute the DeleteDomain service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="BaseException"/>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest deleteDomainRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDomain(deleteDomainRequest, null, null, true);
            return EndDeleteDomain(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteDomain"/>
        /// </summary>
        /// 
        /// <param name="deleteDomainRequest">Container for the necessary parameters to execute the DeleteDomain operation on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDomain(DeleteDomainRequest deleteDomainRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDomain(deleteDomainRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteDomain"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a DeleteDomainResult from AmazonCloudSearch.</returns>
        public DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDomainResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDomain(DeleteDomainRequest deleteDomainRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDomainRequestMarshaller().Marshall(deleteDomainRequest);
            var unmarshaller = DeleteDomainResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteExpression

        /// <summary>
        /// <para>Removes an <c> Expression </c> from the search domain. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html" >Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteExpressionRequest">Container for the necessary parameters to execute the DeleteExpression service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public DeleteExpressionResponse DeleteExpression(DeleteExpressionRequest deleteExpressionRequest)
        {
            IAsyncResult asyncResult = invokeDeleteExpression(deleteExpressionRequest, null, null, true);
            return EndDeleteExpression(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteExpression"/>
        /// </summary>
        /// 
        /// <param name="deleteExpressionRequest">Container for the necessary parameters to execute the DeleteExpression operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExpression
        ///         operation.</returns>
        public IAsyncResult BeginDeleteExpression(DeleteExpressionRequest deleteExpressionRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteExpression(deleteExpressionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteExpression"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExpression.</param>
        /// 
        /// <returns>Returns a DeleteExpressionResult from AmazonCloudSearch.</returns>
        public DeleteExpressionResponse EndDeleteExpression(IAsyncResult asyncResult)
        {
            return endOperation<DeleteExpressionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteExpression(DeleteExpressionRequest deleteExpressionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteExpressionRequestMarshaller().Marshall(deleteExpressionRequest);
            var unmarshaller = DeleteExpressionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteIndexField

        /// <summary>
        /// <para>Removes an <c> IndexField </c> from the search domain. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html" >Configuring Index Fields</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteIndexFieldRequest">Container for the necessary parameters to execute the DeleteIndexField service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest deleteIndexFieldRequest)
        {
            IAsyncResult asyncResult = invokeDeleteIndexField(deleteIndexFieldRequest, null, null, true);
            return EndDeleteIndexField(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteIndexField"/>
        /// </summary>
        /// 
        /// <param name="deleteIndexFieldRequest">Container for the necessary parameters to execute the DeleteIndexField operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndexField
        ///         operation.</returns>
        public IAsyncResult BeginDeleteIndexField(DeleteIndexFieldRequest deleteIndexFieldRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteIndexField(deleteIndexFieldRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteIndexField"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndexField.</param>
        /// 
        /// <returns>Returns a DeleteIndexFieldResult from AmazonCloudSearch.</returns>
        public DeleteIndexFieldResponse EndDeleteIndexField(IAsyncResult asyncResult)
        {
            return endOperation<DeleteIndexFieldResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteIndexField(DeleteIndexFieldRequest deleteIndexFieldRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteIndexFieldRequestMarshaller().Marshall(deleteIndexFieldRequest);
            var unmarshaller = DeleteIndexFieldResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteSuggester

        /// <summary>
        /// <para>Deletes a suggester. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html" >Getting Search Suggestions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteSuggesterRequest">Container for the necessary parameters to execute the DeleteSuggester service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteSuggester service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public DeleteSuggesterResponse DeleteSuggester(DeleteSuggesterRequest deleteSuggesterRequest)
        {
            IAsyncResult asyncResult = invokeDeleteSuggester(deleteSuggesterRequest, null, null, true);
            return EndDeleteSuggester(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteSuggester"/>
        /// </summary>
        /// 
        /// <param name="deleteSuggesterRequest">Container for the necessary parameters to execute the DeleteSuggester operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSuggester
        ///         operation.</returns>
        public IAsyncResult BeginDeleteSuggester(DeleteSuggesterRequest deleteSuggesterRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteSuggester(deleteSuggesterRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteSuggester"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSuggester.</param>
        /// 
        /// <returns>Returns a DeleteSuggesterResult from AmazonCloudSearch.</returns>
        public DeleteSuggesterResponse EndDeleteSuggester(IAsyncResult asyncResult)
        {
            return endOperation<DeleteSuggesterResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteSuggester(DeleteSuggesterRequest deleteSuggesterRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteSuggesterRequestMarshaller().Marshall(deleteSuggesterRequest);
            var unmarshaller = DeleteSuggesterResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeAnalysisSchemes

        /// <summary>
        /// <para>Gets the analysis schemes configured for a domain. An analysis scheme defines language-specific text processing options for a
        /// <c>text</c> field. Can be limited to specific analysis schemes by name. By default, shows all analysis schemes and includes any pending
        /// changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes.
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// >Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAnalysisSchemesRequest">Container for the necessary parameters to execute the DescribeAnalysisSchemes service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeAnalysisSchemes service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public DescribeAnalysisSchemesResponse DescribeAnalysisSchemes(DescribeAnalysisSchemesRequest describeAnalysisSchemesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAnalysisSchemes(describeAnalysisSchemesRequest, null, null, true);
            return EndDescribeAnalysisSchemes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnalysisSchemes operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeAnalysisSchemes"/>
        /// </summary>
        /// 
        /// <param name="describeAnalysisSchemesRequest">Container for the necessary parameters to execute the DescribeAnalysisSchemes operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAnalysisSchemes operation.</returns>
        public IAsyncResult BeginDescribeAnalysisSchemes(DescribeAnalysisSchemesRequest describeAnalysisSchemesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAnalysisSchemes(describeAnalysisSchemesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAnalysisSchemes operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeAnalysisSchemes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnalysisSchemes.</param>
        /// 
        /// <returns>Returns a DescribeAnalysisSchemesResult from AmazonCloudSearch.</returns>
        public DescribeAnalysisSchemesResponse EndDescribeAnalysisSchemes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAnalysisSchemesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAnalysisSchemes(DescribeAnalysisSchemesRequest describeAnalysisSchemesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAnalysisSchemesRequestMarshaller().Marshall(describeAnalysisSchemesRequest);
            var unmarshaller = DescribeAnalysisSchemesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeAvailabilityOptions

        /// <summary>
        /// <para>Gets the availability options configured for a domain. By default, shows the configuration with any pending changes. Set the
        /// <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html" >Configuring Availability
        /// Options</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityOptionsRequest">Container for the necessary parameters to execute the DescribeAvailabilityOptions service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="DisabledOperationException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        public DescribeAvailabilityOptionsResponse DescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest describeAvailabilityOptionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAvailabilityOptions(describeAvailabilityOptionsRequest, null, null, true);
            return EndDescribeAvailabilityOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeAvailabilityOptions"/>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityOptionsRequest">Container for the necessary parameters to execute the DescribeAvailabilityOptions operation
        ///          on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAvailabilityOptions operation.</returns>
        public IAsyncResult BeginDescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest describeAvailabilityOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAvailabilityOptions(describeAvailabilityOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeAvailabilityOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a DescribeAvailabilityOptionsResult from AmazonCloudSearch.</returns>
        public DescribeAvailabilityOptionsResponse EndDescribeAvailabilityOptions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAvailabilityOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest describeAvailabilityOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAvailabilityOptionsRequestMarshaller().Marshall(describeAvailabilityOptionsRequest);
            var unmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDomains

        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by default. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html" >Getting Information about
        /// a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeDomainsRequest">Container for the necessary parameters to execute the DescribeDomains service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="BaseException"/>
        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest describeDomainsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDomains(describeDomainsRequest, null, null, true);
            return EndDescribeDomains(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomains operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeDomains"/>
        /// </summary>
        /// 
        /// <param name="describeDomainsRequest">Container for the necessary parameters to execute the DescribeDomains operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomains
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDomains(DescribeDomainsRequest describeDomainsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDomains(describeDomainsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDomains operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeDomains"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomains.</param>
        /// 
        /// <returns>Returns a DescribeDomainsResult from AmazonCloudSearch.</returns>
        public DescribeDomainsResponse EndDescribeDomains(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDomainsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDomains(DescribeDomainsRequest describeDomainsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDomainsRequestMarshaller().Marshall(describeDomainsRequest);
            var unmarshaller = DescribeDomainsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by default. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html" >Getting Information about
        /// a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="BaseException"/>
        public DescribeDomainsResponse DescribeDomains()
        {
            return DescribeDomains(new DescribeDomainsRequest());
        }
        

        #endregion
    
        #region DescribeExpressions

        /// <summary>
        /// <para>Gets the expressions configured for the search domain. Can be limited to specific expressions by name. By default, shows all
        /// expressions and includes any pending changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html" >Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeExpressionsRequest">Container for the necessary parameters to execute the DescribeExpressions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeExpressions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public DescribeExpressionsResponse DescribeExpressions(DescribeExpressionsRequest describeExpressionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeExpressions(describeExpressionsRequest, null, null, true);
            return EndDescribeExpressions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeExpressions"/>
        /// </summary>
        /// 
        /// <param name="describeExpressionsRequest">Container for the necessary parameters to execute the DescribeExpressions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeExpressions operation.</returns>
        public IAsyncResult BeginDescribeExpressions(DescribeExpressionsRequest describeExpressionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeExpressions(describeExpressionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeExpressions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExpressions.</param>
        /// 
        /// <returns>Returns a DescribeExpressionsResult from AmazonCloudSearch.</returns>
        public DescribeExpressionsResponse EndDescribeExpressions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeExpressionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeExpressions(DescribeExpressionsRequest describeExpressionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeExpressionsRequestMarshaller().Marshall(describeExpressionsRequest);
            var unmarshaller = DescribeExpressionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeIndexFields

        /// <summary>
        /// <para>Gets information about the index fields configured for the search domain. Can be limited to specific fields by name. By default,
        /// shows all fields and includes any pending changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html" >Getting Domain Information</a> in the <i>Amazon
        /// CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeIndexFieldsRequest">Container for the necessary parameters to execute the DescribeIndexFields service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest describeIndexFieldsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeIndexFields(describeIndexFieldsRequest, null, null, true);
            return EndDescribeIndexFields(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndexFields operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeIndexFields"/>
        /// </summary>
        /// 
        /// <param name="describeIndexFieldsRequest">Container for the necessary parameters to execute the DescribeIndexFields operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeIndexFields operation.</returns>
        public IAsyncResult BeginDescribeIndexFields(DescribeIndexFieldsRequest describeIndexFieldsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeIndexFields(describeIndexFieldsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeIndexFields operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeIndexFields"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIndexFields.</param>
        /// 
        /// <returns>Returns a DescribeIndexFieldsResult from AmazonCloudSearch.</returns>
        public DescribeIndexFieldsResponse EndDescribeIndexFields(IAsyncResult asyncResult)
        {
            return endOperation<DescribeIndexFieldsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeIndexFields(DescribeIndexFieldsRequest describeIndexFieldsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeIndexFieldsRequestMarshaller().Marshall(describeIndexFieldsRequest);
            var unmarshaller = DescribeIndexFieldsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeScalingParameters

        /// <summary>
        /// <para>Gets the scaling parameters configured for a domain. A domain's scaling parameters specify the desired search instance type and
        /// replication count. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html" >Configuring Scaling Options</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeScalingParametersRequest">Container for the necessary parameters to execute the DescribeScalingParameters service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeScalingParameters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public DescribeScalingParametersResponse DescribeScalingParameters(DescribeScalingParametersRequest describeScalingParametersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeScalingParameters(describeScalingParametersRequest, null, null, true);
            return EndDescribeScalingParameters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeScalingParameters"/>
        /// </summary>
        /// 
        /// <param name="describeScalingParametersRequest">Container for the necessary parameters to execute the DescribeScalingParameters operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeScalingParameters operation.</returns>
        public IAsyncResult BeginDescribeScalingParameters(DescribeScalingParametersRequest describeScalingParametersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeScalingParameters(describeScalingParametersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeScalingParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingParameters.</param>
        /// 
        /// <returns>Returns a DescribeScalingParametersResult from AmazonCloudSearch.</returns>
        public DescribeScalingParametersResponse EndDescribeScalingParameters(IAsyncResult asyncResult)
        {
            return endOperation<DescribeScalingParametersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeScalingParameters(DescribeScalingParametersRequest describeScalingParametersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeScalingParametersRequestMarshaller().Marshall(describeScalingParametersRequest);
            var unmarshaller = DescribeScalingParametersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeServiceAccessPolicies

        /// <summary>
        /// <para>Gets information about the access policies that control access to the domain's document and search endpoints. By default, shows the
        /// configuration with any pending changes. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending
        /// changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"
        /// >Configuring Access for a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeServiceAccessPoliciesRequest">Container for the necessary parameters to execute the DescribeServiceAccessPolicies
        ///          service method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest describeServiceAccessPoliciesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeServiceAccessPolicies(describeServiceAccessPoliciesRequest, null, null, true);
            return EndDescribeServiceAccessPolicies(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="describeServiceAccessPoliciesRequest">Container for the necessary parameters to execute the DescribeServiceAccessPolicies
        ///          operation on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeServiceAccessPolicies operation.</returns>
        public IAsyncResult BeginDescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest describeServiceAccessPoliciesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeServiceAccessPolicies(describeServiceAccessPoliciesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a DescribeServiceAccessPoliciesResult from AmazonCloudSearch.</returns>
        public DescribeServiceAccessPoliciesResponse EndDescribeServiceAccessPolicies(IAsyncResult asyncResult)
        {
            return endOperation<DescribeServiceAccessPoliciesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest describeServiceAccessPoliciesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeServiceAccessPoliciesRequestMarshaller().Marshall(describeServiceAccessPoliciesRequest);
            var unmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeSuggesters

        /// <summary>
        /// <para>Gets the suggesters configured for a domain. A suggester enables you to display possible matches before users finish typing their
        /// queries. Can be limited to specific suggesters by name. By default, shows all suggesters and includes any pending changes to the
        /// configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes. For more
        /// information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html" >Getting Search
        /// Suggestions</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSuggestersRequest">Container for the necessary parameters to execute the DescribeSuggesters service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeSuggesters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public DescribeSuggestersResponse DescribeSuggesters(DescribeSuggestersRequest describeSuggestersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSuggesters(describeSuggestersRequest, null, null, true);
            return EndDescribeSuggesters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeSuggesters"/>
        /// </summary>
        /// 
        /// <param name="describeSuggestersRequest">Container for the necessary parameters to execute the DescribeSuggesters operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSuggesters operation.</returns>
        public IAsyncResult BeginDescribeSuggesters(DescribeSuggestersRequest describeSuggestersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSuggesters(describeSuggestersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeSuggesters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSuggesters.</param>
        /// 
        /// <returns>Returns a DescribeSuggestersResult from AmazonCloudSearch.</returns>
        public DescribeSuggestersResponse EndDescribeSuggesters(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSuggestersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSuggesters(DescribeSuggestersRequest describeSuggestersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSuggestersRequestMarshaller().Marshall(describeSuggestersRequest);
            var unmarshaller = DescribeSuggestersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region IndexDocuments

        /// <summary>
        /// <para>Tells the search domain to start indexing its documents using the latest indexing options. This operation must be invoked to activate
        /// options whose OptionStatus is <c>RequiresIndexDocuments</c> .</para>
        /// </summary>
        /// 
        /// <param name="indexDocumentsRequest">Container for the necessary parameters to execute the IndexDocuments service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        public IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest indexDocumentsRequest)
        {
            IAsyncResult asyncResult = invokeIndexDocuments(indexDocumentsRequest, null, null, true);
            return EndIndexDocuments(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the IndexDocuments operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.IndexDocuments"/>
        /// </summary>
        /// 
        /// <param name="indexDocumentsRequest">Container for the necessary parameters to execute the IndexDocuments operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIndexDocuments
        ///         operation.</returns>
        public IAsyncResult BeginIndexDocuments(IndexDocumentsRequest indexDocumentsRequest, AsyncCallback callback, object state)
        {
            return invokeIndexDocuments(indexDocumentsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the IndexDocuments operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.IndexDocuments"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIndexDocuments.</param>
        /// 
        /// <returns>Returns a IndexDocumentsResult from AmazonCloudSearch.</returns>
        public IndexDocumentsResponse EndIndexDocuments(IAsyncResult asyncResult)
        {
            return endOperation<IndexDocumentsResponse>(asyncResult);
        }
        
        IAsyncResult invokeIndexDocuments(IndexDocumentsRequest indexDocumentsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new IndexDocumentsRequestMarshaller().Marshall(indexDocumentsRequest);
            var unmarshaller = IndexDocumentsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListDomainNames

        /// <summary>
        /// <para>Lists all search domains owned by an account.</para>
        /// </summary>
        /// 
        /// <param name="listDomainNamesRequest">Container for the necessary parameters to execute the ListDomainNames service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        public ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest listDomainNamesRequest)
        {
            IAsyncResult asyncResult = invokeListDomainNames(listDomainNamesRequest, null, null, true);
            return EndListDomainNames(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.ListDomainNames"/>
        /// </summary>
        /// 
        /// <param name="listDomainNamesRequest">Container for the necessary parameters to execute the ListDomainNames operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainNames
        ///         operation.</returns>
        public IAsyncResult BeginListDomainNames(ListDomainNamesRequest listDomainNamesRequest, AsyncCallback callback, object state)
        {
            return invokeListDomainNames(listDomainNamesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListDomainNames operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.ListDomainNames"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainNames.</param>
        /// 
        /// <returns>Returns a ListDomainNamesResult from AmazonCloudSearch.</returns>
        public ListDomainNamesResponse EndListDomainNames(IAsyncResult asyncResult)
        {
            return endOperation<ListDomainNamesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListDomainNames(ListDomainNamesRequest listDomainNamesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListDomainNamesRequestMarshaller().Marshall(listDomainNamesRequest);
            var unmarshaller = ListDomainNamesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Lists all search domains owned by an account.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        public ListDomainNamesResponse ListDomainNames()
        {
            return ListDomainNames(new ListDomainNamesRequest());
        }
        

        #endregion
    
        #region UpdateAvailabilityOptions

        /// <summary>
        /// <para>Configures the availability options for a domain. Enabling the Multi-AZ option expands an Amazon CloudSearch domain to an additional
        /// Availability Zone in the same Region to increase fault tolerance in the event of a service disruption. Changes to the Multi-AZ option can
        /// take about half an hour to become active. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html" >Configuring Availability
        /// Options</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="updateAvailabilityOptionsRequest">Container for the necessary parameters to execute the UpdateAvailabilityOptions service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateAvailabilityOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="DisabledOperationException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        public UpdateAvailabilityOptionsResponse UpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest updateAvailabilityOptionsRequest)
        {
            IAsyncResult asyncResult = invokeUpdateAvailabilityOptions(updateAvailabilityOptionsRequest, null, null, true);
            return EndUpdateAvailabilityOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateAvailabilityOptions"/>
        /// </summary>
        /// 
        /// <param name="updateAvailabilityOptionsRequest">Container for the necessary parameters to execute the UpdateAvailabilityOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateAvailabilityOptions operation.</returns>
        public IAsyncResult BeginUpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest updateAvailabilityOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateAvailabilityOptions(updateAvailabilityOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateAvailabilityOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a UpdateAvailabilityOptionsResult from AmazonCloudSearch.</returns>
        public UpdateAvailabilityOptionsResponse EndUpdateAvailabilityOptions(IAsyncResult asyncResult)
        {
            return endOperation<UpdateAvailabilityOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest updateAvailabilityOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateAvailabilityOptionsRequestMarshaller().Marshall(updateAvailabilityOptionsRequest);
            var unmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateScalingParameters

        /// <summary>
        /// <para>Configures scaling parameters for a domain. A domain's scaling parameters specify the desired search instance type and replication
        /// count. Amazon CloudSearch will still automatically scale your domain based on the volume of data and traffic, but not below the desired
        /// instance type and replication count. If the Multi-AZ option is enabled, these values control the resources used per Availability Zone. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html" >Configuring
        /// Scaling Options</a> in the <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="updateScalingParametersRequest">Container for the necessary parameters to execute the UpdateScalingParameters service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateScalingParameters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        public UpdateScalingParametersResponse UpdateScalingParameters(UpdateScalingParametersRequest updateScalingParametersRequest)
        {
            IAsyncResult asyncResult = invokeUpdateScalingParameters(updateScalingParametersRequest, null, null, true);
            return EndUpdateScalingParameters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateScalingParameters"/>
        /// </summary>
        /// 
        /// <param name="updateScalingParametersRequest">Container for the necessary parameters to execute the UpdateScalingParameters operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateScalingParameters operation.</returns>
        public IAsyncResult BeginUpdateScalingParameters(UpdateScalingParametersRequest updateScalingParametersRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateScalingParameters(updateScalingParametersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateScalingParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScalingParameters.</param>
        /// 
        /// <returns>Returns a UpdateScalingParametersResult from AmazonCloudSearch.</returns>
        public UpdateScalingParametersResponse EndUpdateScalingParameters(IAsyncResult asyncResult)
        {
            return endOperation<UpdateScalingParametersResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateScalingParameters(UpdateScalingParametersRequest updateScalingParametersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateScalingParametersRequestMarshaller().Marshall(updateScalingParametersRequest);
            var unmarshaller = UpdateScalingParametersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateServiceAccessPolicies

        /// <summary>
        /// <para>Configures the access rules that control access to the domain's document and search endpoints. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html" > Configuring Access for an Amazon CloudSearch
        /// Domain</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateServiceAccessPoliciesRequest">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        public UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest updateServiceAccessPoliciesRequest)
        {
            IAsyncResult asyncResult = invokeUpdateServiceAccessPolicies(updateServiceAccessPoliciesRequest, null, null, true);
            return EndUpdateServiceAccessPolicies(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="updateServiceAccessPoliciesRequest">Container for the necessary parameters to execute the UpdateServiceAccessPolicies operation
        ///          on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateServiceAccessPolicies operation.</returns>
        public IAsyncResult BeginUpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest updateServiceAccessPoliciesRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateServiceAccessPolicies(updateServiceAccessPoliciesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a UpdateServiceAccessPoliciesResult from AmazonCloudSearch.</returns>
        public UpdateServiceAccessPoliciesResponse EndUpdateServiceAccessPolicies(IAsyncResult asyncResult)
        {
            return endOperation<UpdateServiceAccessPoliciesResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest updateServiceAccessPoliciesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateServiceAccessPoliciesRequestMarshaller().Marshall(updateServiceAccessPoliciesRequest);
            var unmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
