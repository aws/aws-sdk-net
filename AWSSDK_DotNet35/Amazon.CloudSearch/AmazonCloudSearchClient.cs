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
    /// Amazon CloudSearch Configuration Service <para>You use the configuration service to create, configure, and manage search domains.
    /// Configuration service requests are submitted using the AWS Query protocol. AWS Query requests are HTTP or HTTPS requests submitted via HTTP
    /// GET or POST with a query parameter named Action.</para> <para>The endpoint for configuration service requests is region-specific:
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
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


        #region CreateDomain

        /// <summary>
        /// <para>Creates a new search domain.</para>
        /// </summary>
        /// 
        /// <param name="createDomainRequest">Container for the necessary parameters to execute the CreateDomain service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
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
    
        #region DefineIndexField

        /// <summary>
        /// <para>Configures an <c>IndexField</c> for the search domain. Used to create new fields and modify existing ones. If the field exists, the
        /// new configuration replaces the old one. You can configure a maximum of 200 index fields.</para>
        /// </summary>
        /// 
        /// <param name="defineIndexFieldRequest">Container for the necessary parameters to execute the DefineIndexField service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
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
    
        #region DefineRankExpression

        /// <summary>
        /// <para>Configures a <c>RankExpression</c> for the search domain. Used to create new rank expressions and modify existing ones. If the
        /// expression exists, the new configuration replaces the old one. You can configure a maximum of 50 rank expressions.</para>
        /// </summary>
        /// 
        /// <param name="defineRankExpressionRequest">Container for the necessary parameters to execute the DefineRankExpression service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineRankExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        public DefineRankExpressionResponse DefineRankExpression(DefineRankExpressionRequest defineRankExpressionRequest)
        {
            IAsyncResult asyncResult = invokeDefineRankExpression(defineRankExpressionRequest, null, null, true);
            return EndDefineRankExpression(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DefineRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineRankExpression"/>
        /// </summary>
        /// 
        /// <param name="defineRankExpressionRequest">Container for the necessary parameters to execute the DefineRankExpression operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDefineRankExpression operation.</returns>
        public IAsyncResult BeginDefineRankExpression(DefineRankExpressionRequest defineRankExpressionRequest, AsyncCallback callback, object state)
        {
            return invokeDefineRankExpression(defineRankExpressionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DefineRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineRankExpression"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineRankExpression.</param>
        /// 
        /// <returns>Returns a DefineRankExpressionResult from AmazonCloudSearch.</returns>
        public DefineRankExpressionResponse EndDefineRankExpression(IAsyncResult asyncResult)
        {
            return endOperation<DefineRankExpressionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDefineRankExpression(DefineRankExpressionRequest defineRankExpressionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DefineRankExpressionRequestMarshaller().Marshall(defineRankExpressionRequest);
            var unmarshaller = DefineRankExpressionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDomain

        /// <summary>
        /// <para>Permanently deletes a search domain and all of its data.</para>
        /// </summary>
        /// 
        /// <param name="deleteDomainRequest">Container for the necessary parameters to execute the DeleteDomain service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="InternalException"/>
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
    
        #region DeleteIndexField

        /// <summary>
        /// <para>Removes an <c>IndexField</c> from the search domain.</para>
        /// </summary>
        /// 
        /// <param name="deleteIndexFieldRequest">Container for the necessary parameters to execute the DeleteIndexField service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
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
    
        #region DeleteRankExpression

        /// <summary>
        /// <para>Removes a <c>RankExpression</c> from the search domain.</para>
        /// </summary>
        /// 
        /// <param name="deleteRankExpressionRequest">Container for the necessary parameters to execute the DeleteRankExpression service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteRankExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        public DeleteRankExpressionResponse DeleteRankExpression(DeleteRankExpressionRequest deleteRankExpressionRequest)
        {
            IAsyncResult asyncResult = invokeDeleteRankExpression(deleteRankExpressionRequest, null, null, true);
            return EndDeleteRankExpression(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteRankExpression"/>
        /// </summary>
        /// 
        /// <param name="deleteRankExpressionRequest">Container for the necessary parameters to execute the DeleteRankExpression operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteRankExpression operation.</returns>
        public IAsyncResult BeginDeleteRankExpression(DeleteRankExpressionRequest deleteRankExpressionRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteRankExpression(deleteRankExpressionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteRankExpression"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRankExpression.</param>
        /// 
        /// <returns>Returns a DeleteRankExpressionResult from AmazonCloudSearch.</returns>
        public DeleteRankExpressionResponse EndDeleteRankExpression(IAsyncResult asyncResult)
        {
            return endOperation<DeleteRankExpressionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteRankExpression(DeleteRankExpressionRequest deleteRankExpressionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteRankExpressionRequestMarshaller().Marshall(deleteRankExpressionRequest);
            var unmarshaller = DeleteRankExpressionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDefaultSearchField

        /// <summary>
        /// <para>Gets the default search field configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeDefaultSearchFieldRequest">Container for the necessary parameters to execute the DescribeDefaultSearchField service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDefaultSearchField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        public DescribeDefaultSearchFieldResponse DescribeDefaultSearchField(DescribeDefaultSearchFieldRequest describeDefaultSearchFieldRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDefaultSearchField(describeDefaultSearchFieldRequest, null, null, true);
            return EndDescribeDefaultSearchField(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeDefaultSearchField"/>
        /// </summary>
        /// 
        /// <param name="describeDefaultSearchFieldRequest">Container for the necessary parameters to execute the DescribeDefaultSearchField operation
        ///          on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDefaultSearchField operation.</returns>
        public IAsyncResult BeginDescribeDefaultSearchField(DescribeDefaultSearchFieldRequest describeDefaultSearchFieldRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDefaultSearchField(describeDefaultSearchFieldRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeDefaultSearchField"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultSearchField.</param>
        /// 
        /// <returns>Returns a DescribeDefaultSearchFieldResult from AmazonCloudSearch.</returns>
        public DescribeDefaultSearchFieldResponse EndDescribeDefaultSearchField(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDefaultSearchFieldResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDefaultSearchField(DescribeDefaultSearchFieldRequest describeDefaultSearchFieldRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDefaultSearchFieldRequestMarshaller().Marshall(describeDefaultSearchFieldRequest);
            var unmarshaller = DescribeDefaultSearchFieldResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDomains

        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by
        /// default.</para>
        /// </summary>
        /// 
        /// <param name="describeDomainsRequest">Container for the necessary parameters to execute the DescribeDomains service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="InternalException"/>
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
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by
        /// default.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="InternalException"/>
        public DescribeDomainsResponse DescribeDomains()
        {
            return DescribeDomains(new DescribeDomainsRequest());
        }
        

        #endregion
    
        #region DescribeIndexFields

        /// <summary>
        /// <para>Gets information about the index fields configured for the search domain. Can be limited to specific fields by name. Shows all fields
        /// by default.</para>
        /// </summary>
        /// 
        /// <param name="describeIndexFieldsRequest">Container for the necessary parameters to execute the DescribeIndexFields service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
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
    
        #region DescribeRankExpressions

        /// <summary>
        /// <para>Gets the rank expressions configured for the search domain. Can be limited to specific rank expressions by name. Shows all rank
        /// expressions by default. </para>
        /// </summary>
        /// 
        /// <param name="describeRankExpressionsRequest">Container for the necessary parameters to execute the DescribeRankExpressions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeRankExpressions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        public DescribeRankExpressionsResponse DescribeRankExpressions(DescribeRankExpressionsRequest describeRankExpressionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeRankExpressions(describeRankExpressionsRequest, null, null, true);
            return EndDescribeRankExpressions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRankExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeRankExpressions"/>
        /// </summary>
        /// 
        /// <param name="describeRankExpressionsRequest">Container for the necessary parameters to execute the DescribeRankExpressions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeRankExpressions operation.</returns>
        public IAsyncResult BeginDescribeRankExpressions(DescribeRankExpressionsRequest describeRankExpressionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeRankExpressions(describeRankExpressionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeRankExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeRankExpressions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRankExpressions.</param>
        /// 
        /// <returns>Returns a DescribeRankExpressionsResult from AmazonCloudSearch.</returns>
        public DescribeRankExpressionsResponse EndDescribeRankExpressions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeRankExpressionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeRankExpressions(DescribeRankExpressionsRequest describeRankExpressionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeRankExpressionsRequestMarshaller().Marshall(describeRankExpressionsRequest);
            var unmarshaller = DescribeRankExpressionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeServiceAccessPolicies

        /// <summary>
        /// <para>Gets information about the resource-based policies that control access to the domain's document and search services.</para>
        /// </summary>
        /// 
        /// <param name="describeServiceAccessPoliciesRequest">Container for the necessary parameters to execute the DescribeServiceAccessPolicies
        ///          service method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
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
    
        #region DescribeStemmingOptions

        /// <summary>
        /// <para>Gets the stemming dictionary configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeStemmingOptionsRequest">Container for the necessary parameters to execute the DescribeStemmingOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeStemmingOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        public DescribeStemmingOptionsResponse DescribeStemmingOptions(DescribeStemmingOptionsRequest describeStemmingOptionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeStemmingOptions(describeStemmingOptionsRequest, null, null, true);
            return EndDescribeStemmingOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeStemmingOptions"/>
        /// </summary>
        /// 
        /// <param name="describeStemmingOptionsRequest">Container for the necessary parameters to execute the DescribeStemmingOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStemmingOptions operation.</returns>
        public IAsyncResult BeginDescribeStemmingOptions(DescribeStemmingOptionsRequest describeStemmingOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeStemmingOptions(describeStemmingOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeStemmingOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStemmingOptions.</param>
        /// 
        /// <returns>Returns a DescribeStemmingOptionsResult from AmazonCloudSearch.</returns>
        public DescribeStemmingOptionsResponse EndDescribeStemmingOptions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeStemmingOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeStemmingOptions(DescribeStemmingOptionsRequest describeStemmingOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStemmingOptionsRequestMarshaller().Marshall(describeStemmingOptionsRequest);
            var unmarshaller = DescribeStemmingOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeStopwordOptions

        /// <summary>
        /// <para>Gets the stopwords configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeStopwordOptionsRequest">Container for the necessary parameters to execute the DescribeStopwordOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeStopwordOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        public DescribeStopwordOptionsResponse DescribeStopwordOptions(DescribeStopwordOptionsRequest describeStopwordOptionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeStopwordOptions(describeStopwordOptionsRequest, null, null, true);
            return EndDescribeStopwordOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeStopwordOptions"/>
        /// </summary>
        /// 
        /// <param name="describeStopwordOptionsRequest">Container for the necessary parameters to execute the DescribeStopwordOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStopwordOptions operation.</returns>
        public IAsyncResult BeginDescribeStopwordOptions(DescribeStopwordOptionsRequest describeStopwordOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeStopwordOptions(describeStopwordOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeStopwordOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStopwordOptions.</param>
        /// 
        /// <returns>Returns a DescribeStopwordOptionsResult from AmazonCloudSearch.</returns>
        public DescribeStopwordOptionsResponse EndDescribeStopwordOptions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeStopwordOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeStopwordOptions(DescribeStopwordOptionsRequest describeStopwordOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStopwordOptionsRequestMarshaller().Marshall(describeStopwordOptionsRequest);
            var unmarshaller = DescribeStopwordOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeSynonymOptions

        /// <summary>
        /// <para>Gets the synonym dictionary configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeSynonymOptionsRequest">Container for the necessary parameters to execute the DescribeSynonymOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeSynonymOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        public DescribeSynonymOptionsResponse DescribeSynonymOptions(DescribeSynonymOptionsRequest describeSynonymOptionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSynonymOptions(describeSynonymOptionsRequest, null, null, true);
            return EndDescribeSynonymOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeSynonymOptions"/>
        /// </summary>
        /// 
        /// <param name="describeSynonymOptionsRequest">Container for the necessary parameters to execute the DescribeSynonymOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSynonymOptions operation.</returns>
        public IAsyncResult BeginDescribeSynonymOptions(DescribeSynonymOptionsRequest describeSynonymOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSynonymOptions(describeSynonymOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeSynonymOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSynonymOptions.</param>
        /// 
        /// <returns>Returns a DescribeSynonymOptionsResult from AmazonCloudSearch.</returns>
        public DescribeSynonymOptionsResponse EndDescribeSynonymOptions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSynonymOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSynonymOptions(DescribeSynonymOptionsRequest describeSynonymOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSynonymOptionsRequestMarshaller().Marshall(describeSynonymOptionsRequest);
            var unmarshaller = DescribeSynonymOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region IndexDocuments

        /// <summary>
        /// <para>Tells the search domain to start indexing its documents using the latest text processing options and <c>IndexFields</c> . This
        /// operation must be invoked to make options whose OptionStatus has <c>OptionState</c> of <c>RequiresIndexDocuments</c> visible in search
        /// results.</para>
        /// </summary>
        /// 
        /// <param name="indexDocumentsRequest">Container for the necessary parameters to execute the IndexDocuments service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
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
    
        #region UpdateDefaultSearchField

        /// <summary>
        /// <para>Configures the default search field for the search domain. The default search field is the text field that is searched when a search
        /// request does not specify which fields to search. By default, it is configured to include the contents of all of the domain's text fields.
        /// </para>
        /// </summary>
        /// 
        /// <param name="updateDefaultSearchFieldRequest">Container for the necessary parameters to execute the UpdateDefaultSearchField service method
        ///          on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateDefaultSearchField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        public UpdateDefaultSearchFieldResponse UpdateDefaultSearchField(UpdateDefaultSearchFieldRequest updateDefaultSearchFieldRequest)
        {
            IAsyncResult asyncResult = invokeUpdateDefaultSearchField(updateDefaultSearchFieldRequest, null, null, true);
            return EndUpdateDefaultSearchField(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateDefaultSearchField"/>
        /// </summary>
        /// 
        /// <param name="updateDefaultSearchFieldRequest">Container for the necessary parameters to execute the UpdateDefaultSearchField operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateDefaultSearchField operation.</returns>
        public IAsyncResult BeginUpdateDefaultSearchField(UpdateDefaultSearchFieldRequest updateDefaultSearchFieldRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateDefaultSearchField(updateDefaultSearchFieldRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateDefaultSearchField"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDefaultSearchField.</param>
        /// 
        /// <returns>Returns a UpdateDefaultSearchFieldResult from AmazonCloudSearch.</returns>
        public UpdateDefaultSearchFieldResponse EndUpdateDefaultSearchField(IAsyncResult asyncResult)
        {
            return endOperation<UpdateDefaultSearchFieldResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateDefaultSearchField(UpdateDefaultSearchFieldRequest updateDefaultSearchFieldRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateDefaultSearchFieldRequestMarshaller().Marshall(updateDefaultSearchFieldRequest);
            var unmarshaller = UpdateDefaultSearchFieldResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateServiceAccessPolicies

        /// <summary>
        /// <para>Configures the policies that control access to the domain's document and search services. The maximum size of an access policy
        /// document is 100 KB.</para>
        /// </summary>
        /// 
        /// <param name="updateServiceAccessPoliciesRequest">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
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
    
        #region UpdateStemmingOptions

        /// <summary>
        /// <para>Configures a stemming dictionary for the search domain. The stemming dictionary is used during indexing and when processing search
        /// requests. The maximum size of the stemming dictionary is 500 KB.</para>
        /// </summary>
        /// 
        /// <param name="updateStemmingOptionsRequest">Container for the necessary parameters to execute the UpdateStemmingOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateStemmingOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        public UpdateStemmingOptionsResponse UpdateStemmingOptions(UpdateStemmingOptionsRequest updateStemmingOptionsRequest)
        {
            IAsyncResult asyncResult = invokeUpdateStemmingOptions(updateStemmingOptionsRequest, null, null, true);
            return EndUpdateStemmingOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateStemmingOptions"/>
        /// </summary>
        /// 
        /// <param name="updateStemmingOptionsRequest">Container for the necessary parameters to execute the UpdateStemmingOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateStemmingOptions operation.</returns>
        public IAsyncResult BeginUpdateStemmingOptions(UpdateStemmingOptionsRequest updateStemmingOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateStemmingOptions(updateStemmingOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateStemmingOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStemmingOptions.</param>
        /// 
        /// <returns>Returns a UpdateStemmingOptionsResult from AmazonCloudSearch.</returns>
        public UpdateStemmingOptionsResponse EndUpdateStemmingOptions(IAsyncResult asyncResult)
        {
            return endOperation<UpdateStemmingOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateStemmingOptions(UpdateStemmingOptionsRequest updateStemmingOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateStemmingOptionsRequestMarshaller().Marshall(updateStemmingOptionsRequest);
            var unmarshaller = UpdateStemmingOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateStopwordOptions

        /// <summary>
        /// <para>Configures stopwords for the search domain. Stopwords are used during indexing and when processing search requests. The maximum size
        /// of the stopwords dictionary is 10 KB.</para>
        /// </summary>
        /// 
        /// <param name="updateStopwordOptionsRequest">Container for the necessary parameters to execute the UpdateStopwordOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateStopwordOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        public UpdateStopwordOptionsResponse UpdateStopwordOptions(UpdateStopwordOptionsRequest updateStopwordOptionsRequest)
        {
            IAsyncResult asyncResult = invokeUpdateStopwordOptions(updateStopwordOptionsRequest, null, null, true);
            return EndUpdateStopwordOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateStopwordOptions"/>
        /// </summary>
        /// 
        /// <param name="updateStopwordOptionsRequest">Container for the necessary parameters to execute the UpdateStopwordOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateStopwordOptions operation.</returns>
        public IAsyncResult BeginUpdateStopwordOptions(UpdateStopwordOptionsRequest updateStopwordOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateStopwordOptions(updateStopwordOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateStopwordOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStopwordOptions.</param>
        /// 
        /// <returns>Returns a UpdateStopwordOptionsResult from AmazonCloudSearch.</returns>
        public UpdateStopwordOptionsResponse EndUpdateStopwordOptions(IAsyncResult asyncResult)
        {
            return endOperation<UpdateStopwordOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateStopwordOptions(UpdateStopwordOptionsRequest updateStopwordOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateStopwordOptionsRequestMarshaller().Marshall(updateStopwordOptionsRequest);
            var unmarshaller = UpdateStopwordOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateSynonymOptions

        /// <summary>
        /// <para>Configures a synonym dictionary for the search domain. The synonym dictionary is used during indexing to configure mappings for terms
        /// that occur in text fields. The maximum size of the synonym dictionary is 100 KB. </para>
        /// </summary>
        /// 
        /// <param name="updateSynonymOptionsRequest">Container for the necessary parameters to execute the UpdateSynonymOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateSynonymOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        public UpdateSynonymOptionsResponse UpdateSynonymOptions(UpdateSynonymOptionsRequest updateSynonymOptionsRequest)
        {
            IAsyncResult asyncResult = invokeUpdateSynonymOptions(updateSynonymOptionsRequest, null, null, true);
            return EndUpdateSynonymOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateSynonymOptions"/>
        /// </summary>
        /// 
        /// <param name="updateSynonymOptionsRequest">Container for the necessary parameters to execute the UpdateSynonymOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateSynonymOptions operation.</returns>
        public IAsyncResult BeginUpdateSynonymOptions(UpdateSynonymOptionsRequest updateSynonymOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateSynonymOptions(updateSynonymOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateSynonymOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSynonymOptions.</param>
        /// 
        /// <returns>Returns a UpdateSynonymOptionsResult from AmazonCloudSearch.</returns>
        public UpdateSynonymOptionsResponse EndUpdateSynonymOptions(IAsyncResult asyncResult)
        {
            return endOperation<UpdateSynonymOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateSynonymOptions(UpdateSynonymOptionsRequest updateSynonymOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateSynonymOptionsRequestMarshaller().Marshall(updateSynonymOptionsRequest);
            var unmarshaller = UpdateSynonymOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
