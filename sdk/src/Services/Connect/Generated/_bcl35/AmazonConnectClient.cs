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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Connect.Model;
using Amazon.Connect.Model.Internal.MarshallTransformations;
using Amazon.Connect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Connect
{
    /// <summary>
    /// Implementation for accessing Connect
    ///
    /// Amazon Connect is a cloud-based contact center solution that you use to set up and
    /// manage a customer contact center and provide reliable customer engagement at any scale.
    /// 
    ///  
    /// <para>
    /// Amazon Connect provides metrics and real-time reporting that enable you to optimize
    /// contact routing. You can also resolve customer issues more efficiently by getting
    /// customers in touch with the appropriate agents.
    /// </para>
    ///  
    /// <para>
    /// There are limits to the number of Amazon Connect resources that you can create. There
    /// are also limits to the number of requests that you can make per second. For more information,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
    /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can connect programmatically to an Amazon Web Services service by using an endpoint.
    /// For a list of Amazon Connect endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Amazon
    /// Connect Endpoints</a>.
    /// </para>
    /// </summary>
    public partial class AmazonConnectClient : AmazonServiceClient, IAmazonConnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonConnectMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IConnectPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IConnectPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ConnectPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonConnectClient with the credentials loaded from the application's
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
        public AmazonConnectClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectConfig()) { }

        /// <summary>
        /// Constructs AmazonConnectClient with the credentials loaded from the application's
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
        public AmazonConnectClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConnectClient Configuration Object</param>
        public AmazonConnectClient(AmazonConnectConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectClient with AWS Credentials and an
        /// AmazonConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConnectClient Configuration Object</param>
        public AmazonConnectClient(AWSCredentials credentials, AmazonConnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConnectClient Configuration Object</param>
        public AmazonConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConnectClient Configuration Object</param>
        public AmazonConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConnectConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectEndpointResolver());
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


        #region  AssociateApprovedOrigin

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Associates an approved origin to an Amazon Connect instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApprovedOrigin service method.</param>
        /// 
        /// <returns>The response from the AssociateApprovedOrigin service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateApprovedOrigin">REST API Reference for AssociateApprovedOrigin Operation</seealso>
        public virtual AssociateApprovedOriginResponse AssociateApprovedOrigin(AssociateApprovedOriginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateApprovedOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApprovedOriginResponseUnmarshaller.Instance;

            return Invoke<AssociateApprovedOriginResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateApprovedOrigin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateApprovedOrigin operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateApprovedOrigin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateApprovedOrigin">REST API Reference for AssociateApprovedOrigin Operation</seealso>
        public virtual IAsyncResult BeginAssociateApprovedOrigin(AssociateApprovedOriginRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateApprovedOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApprovedOriginResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateApprovedOrigin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateApprovedOrigin.</param>
        /// 
        /// <returns>Returns a  AssociateApprovedOriginResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateApprovedOrigin">REST API Reference for AssociateApprovedOrigin Operation</seealso>
        public virtual AssociateApprovedOriginResponse EndAssociateApprovedOrigin(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateApprovedOriginResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateBot

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Allows the specified Amazon Connect instance to access the specified Amazon Lex or
        /// Amazon Lex V2 bot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBot service method.</param>
        /// 
        /// <returns>The response from the AssociateBot service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateBot">REST API Reference for AssociateBot Operation</seealso>
        public virtual AssociateBotResponse AssociateBot(AssociateBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBotResponseUnmarshaller.Instance;

            return Invoke<AssociateBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateBot operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateBot">REST API Reference for AssociateBot Operation</seealso>
        public virtual IAsyncResult BeginAssociateBot(AssociateBotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateBot.</param>
        /// 
        /// <returns>Returns a  AssociateBotResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateBot">REST API Reference for AssociateBot Operation</seealso>
        public virtual AssociateBotResponse EndAssociateBot(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateBotResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateDefaultVocabulary

        /// <summary>
        /// Associates an existing vocabulary as the default. Contact Lens for Amazon Connect
        /// uses the vocabulary in post-call and real-time analysis sessions for the given language.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDefaultVocabulary service method.</param>
        /// 
        /// <returns>The response from the AssociateDefaultVocabulary service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateDefaultVocabulary">REST API Reference for AssociateDefaultVocabulary Operation</seealso>
        public virtual AssociateDefaultVocabularyResponse AssociateDefaultVocabulary(AssociateDefaultVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDefaultVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDefaultVocabularyResponseUnmarshaller.Instance;

            return Invoke<AssociateDefaultVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDefaultVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDefaultVocabulary operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDefaultVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateDefaultVocabulary">REST API Reference for AssociateDefaultVocabulary Operation</seealso>
        public virtual IAsyncResult BeginAssociateDefaultVocabulary(AssociateDefaultVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDefaultVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDefaultVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDefaultVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDefaultVocabulary.</param>
        /// 
        /// <returns>Returns a  AssociateDefaultVocabularyResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateDefaultVocabulary">REST API Reference for AssociateDefaultVocabulary Operation</seealso>
        public virtual AssociateDefaultVocabularyResponse EndAssociateDefaultVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDefaultVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateInstanceStorageConfig

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Associates a storage resource type for the first time. You can only associate one
        /// type of storage configuration in a single call. This means, for example, that you
        /// can't define an instance with multiple S3 buckets for storing chat transcripts.
        /// </para>
        ///  
        /// <para>
        /// This API does not create a resource that doesn't exist. It only associates it to the
        /// instance. Ensure that the resource being specified in the storage configuration, like
        /// an S3 bucket, exists when being used for association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateInstanceStorageConfig service method.</param>
        /// 
        /// <returns>The response from the AssociateInstanceStorageConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateInstanceStorageConfig">REST API Reference for AssociateInstanceStorageConfig Operation</seealso>
        public virtual AssociateInstanceStorageConfigResponse AssociateInstanceStorageConfig(AssociateInstanceStorageConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateInstanceStorageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateInstanceStorageConfigResponseUnmarshaller.Instance;

            return Invoke<AssociateInstanceStorageConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateInstanceStorageConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateInstanceStorageConfig operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateInstanceStorageConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateInstanceStorageConfig">REST API Reference for AssociateInstanceStorageConfig Operation</seealso>
        public virtual IAsyncResult BeginAssociateInstanceStorageConfig(AssociateInstanceStorageConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateInstanceStorageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateInstanceStorageConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateInstanceStorageConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateInstanceStorageConfig.</param>
        /// 
        /// <returns>Returns a  AssociateInstanceStorageConfigResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateInstanceStorageConfig">REST API Reference for AssociateInstanceStorageConfig Operation</seealso>
        public virtual AssociateInstanceStorageConfigResponse EndAssociateInstanceStorageConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateInstanceStorageConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateLambdaFunction

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Allows the specified Amazon Connect instance to access the specified Lambda function.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLambdaFunction service method.</param>
        /// 
        /// <returns>The response from the AssociateLambdaFunction service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateLambdaFunction">REST API Reference for AssociateLambdaFunction Operation</seealso>
        public virtual AssociateLambdaFunctionResponse AssociateLambdaFunction(AssociateLambdaFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLambdaFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLambdaFunctionResponseUnmarshaller.Instance;

            return Invoke<AssociateLambdaFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateLambdaFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateLambdaFunction operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateLambdaFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateLambdaFunction">REST API Reference for AssociateLambdaFunction Operation</seealso>
        public virtual IAsyncResult BeginAssociateLambdaFunction(AssociateLambdaFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLambdaFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLambdaFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateLambdaFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateLambdaFunction.</param>
        /// 
        /// <returns>Returns a  AssociateLambdaFunctionResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateLambdaFunction">REST API Reference for AssociateLambdaFunction Operation</seealso>
        public virtual AssociateLambdaFunctionResponse EndAssociateLambdaFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateLambdaFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateLexBot

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Allows the specified Amazon Connect instance to access the specified Amazon Lex V1
        /// bot. This API only supports the association of Amazon Lex V1 bots.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLexBot service method.</param>
        /// 
        /// <returns>The response from the AssociateLexBot service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateLexBot">REST API Reference for AssociateLexBot Operation</seealso>
        public virtual AssociateLexBotResponse AssociateLexBot(AssociateLexBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLexBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLexBotResponseUnmarshaller.Instance;

            return Invoke<AssociateLexBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateLexBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateLexBot operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateLexBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateLexBot">REST API Reference for AssociateLexBot Operation</seealso>
        public virtual IAsyncResult BeginAssociateLexBot(AssociateLexBotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLexBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLexBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateLexBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateLexBot.</param>
        /// 
        /// <returns>Returns a  AssociateLexBotResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateLexBot">REST API Reference for AssociateLexBot Operation</seealso>
        public virtual AssociateLexBotResponse EndAssociateLexBot(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateLexBotResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociatePhoneNumberContactFlow

        /// <summary>
        /// Associates a flow with a phone number claimed to your Amazon Connect instance.
        /// 
        ///  <important> 
        /// <para>
        /// If the number is claimed to a traffic distribution group, and you are calling this
        /// API using an instance in the Amazon Web Services Region where the traffic distribution
        /// group was created, you can use either a full phone number ARN or UUID value for the
        /// <code>PhoneNumberId</code> URI request parameter. However, if the number is claimed
        /// to a traffic distribution group and you are calling this API using an instance in
        /// the alternate Amazon Web Services Region associated with the traffic distribution
        /// group, you must provide a full phone number ARN. If a UUID is provided in this scenario,
        /// you will receive a <code>ResourceNotFoundException</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumberContactFlow service method.</param>
        /// 
        /// <returns>The response from the AssociatePhoneNumberContactFlow service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociatePhoneNumberContactFlow">REST API Reference for AssociatePhoneNumberContactFlow Operation</seealso>
        public virtual AssociatePhoneNumberContactFlowResponse AssociatePhoneNumberContactFlow(AssociatePhoneNumberContactFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumberContactFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumberContactFlowResponseUnmarshaller.Instance;

            return Invoke<AssociatePhoneNumberContactFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumberContactFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumberContactFlow operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumberContactFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociatePhoneNumberContactFlow">REST API Reference for AssociatePhoneNumberContactFlow Operation</seealso>
        public virtual IAsyncResult BeginAssociatePhoneNumberContactFlow(AssociatePhoneNumberContactFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumberContactFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumberContactFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumberContactFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumberContactFlow.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumberContactFlowResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociatePhoneNumberContactFlow">REST API Reference for AssociatePhoneNumberContactFlow Operation</seealso>
        public virtual AssociatePhoneNumberContactFlowResponse EndAssociatePhoneNumberContactFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePhoneNumberContactFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateQueueQuickConnects

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Associates a set of quick connects with a queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateQueueQuickConnects service method.</param>
        /// 
        /// <returns>The response from the AssociateQueueQuickConnects service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateQueueQuickConnects">REST API Reference for AssociateQueueQuickConnects Operation</seealso>
        public virtual AssociateQueueQuickConnectsResponse AssociateQueueQuickConnects(AssociateQueueQuickConnectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateQueueQuickConnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateQueueQuickConnectsResponseUnmarshaller.Instance;

            return Invoke<AssociateQueueQuickConnectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateQueueQuickConnects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateQueueQuickConnects operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateQueueQuickConnects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateQueueQuickConnects">REST API Reference for AssociateQueueQuickConnects Operation</seealso>
        public virtual IAsyncResult BeginAssociateQueueQuickConnects(AssociateQueueQuickConnectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateQueueQuickConnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateQueueQuickConnectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateQueueQuickConnects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateQueueQuickConnects.</param>
        /// 
        /// <returns>Returns a  AssociateQueueQuickConnectsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateQueueQuickConnects">REST API Reference for AssociateQueueQuickConnects Operation</seealso>
        public virtual AssociateQueueQuickConnectsResponse EndAssociateQueueQuickConnects(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateQueueQuickConnectsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateRoutingProfileQueues

        /// <summary>
        /// Associates a set of queues with a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRoutingProfileQueues service method.</param>
        /// 
        /// <returns>The response from the AssociateRoutingProfileQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateRoutingProfileQueues">REST API Reference for AssociateRoutingProfileQueues Operation</seealso>
        public virtual AssociateRoutingProfileQueuesResponse AssociateRoutingProfileQueues(AssociateRoutingProfileQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateRoutingProfileQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRoutingProfileQueuesResponseUnmarshaller.Instance;

            return Invoke<AssociateRoutingProfileQueuesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRoutingProfileQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRoutingProfileQueues operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateRoutingProfileQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateRoutingProfileQueues">REST API Reference for AssociateRoutingProfileQueues Operation</seealso>
        public virtual IAsyncResult BeginAssociateRoutingProfileQueues(AssociateRoutingProfileQueuesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateRoutingProfileQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRoutingProfileQueuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateRoutingProfileQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateRoutingProfileQueues.</param>
        /// 
        /// <returns>Returns a  AssociateRoutingProfileQueuesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateRoutingProfileQueues">REST API Reference for AssociateRoutingProfileQueues Operation</seealso>
        public virtual AssociateRoutingProfileQueuesResponse EndAssociateRoutingProfileQueues(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateRoutingProfileQueuesResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateSecurityKey

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Associates a security key to the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSecurityKey service method.</param>
        /// 
        /// <returns>The response from the AssociateSecurityKey service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateSecurityKey">REST API Reference for AssociateSecurityKey Operation</seealso>
        public virtual AssociateSecurityKeyResponse AssociateSecurityKey(AssociateSecurityKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSecurityKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSecurityKeyResponseUnmarshaller.Instance;

            return Invoke<AssociateSecurityKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSecurityKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSecurityKey operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSecurityKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateSecurityKey">REST API Reference for AssociateSecurityKey Operation</seealso>
        public virtual IAsyncResult BeginAssociateSecurityKey(AssociateSecurityKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSecurityKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSecurityKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSecurityKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSecurityKey.</param>
        /// 
        /// <returns>Returns a  AssociateSecurityKeyResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/AssociateSecurityKey">REST API Reference for AssociateSecurityKey Operation</seealso>
        public virtual AssociateSecurityKeyResponse EndAssociateSecurityKey(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateSecurityKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  ClaimPhoneNumber

        /// <summary>
        /// Claims an available phone number to your Amazon Connect instance or traffic distribution
        /// group. You can call this API only in the same Amazon Web Services Region where the
        /// Amazon Connect instance or traffic distribution group was created.
        /// 
        ///  
        /// <para>
        /// For more information about how to use this operation, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/claim-phone-number.html">Claim
        /// a phone number in your country</a> and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/claim-phone-numbers-traffic-distribution-groups.html">Claim
        /// phone numbers to traffic distribution groups</a> in the <i>Amazon Connect Administrator
        /// Guide</i>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_SearchAvailablePhoneNumbers.html">SearchAvailablePhoneNumbers</a>
        /// API for available phone numbers that you can claim. Call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribePhoneNumber.html">DescribePhoneNumber</a>
        /// API to verify the status of a previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ClaimPhoneNumber.html">ClaimPhoneNumber</a>
        /// operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClaimPhoneNumber service method.</param>
        /// 
        /// <returns>The response from the ClaimPhoneNumber service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ClaimPhoneNumber">REST API Reference for ClaimPhoneNumber Operation</seealso>
        public virtual ClaimPhoneNumberResponse ClaimPhoneNumber(ClaimPhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClaimPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClaimPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<ClaimPhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ClaimPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ClaimPhoneNumber operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndClaimPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ClaimPhoneNumber">REST API Reference for ClaimPhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginClaimPhoneNumber(ClaimPhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClaimPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClaimPhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ClaimPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginClaimPhoneNumber.</param>
        /// 
        /// <returns>Returns a  ClaimPhoneNumberResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ClaimPhoneNumber">REST API Reference for ClaimPhoneNumber Operation</seealso>
        public virtual ClaimPhoneNumberResponse EndClaimPhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<ClaimPhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAgentStatus

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Creates an agent status for the specified Amazon Connect instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentStatus service method.</param>
        /// 
        /// <returns>The response from the CreateAgentStatus service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateAgentStatus">REST API Reference for CreateAgentStatus Operation</seealso>
        public virtual CreateAgentStatusResponse CreateAgentStatus(CreateAgentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentStatusResponseUnmarshaller.Instance;

            return Invoke<CreateAgentStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAgentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentStatus operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateAgentStatus">REST API Reference for CreateAgentStatus Operation</seealso>
        public virtual IAsyncResult BeginCreateAgentStatus(CreateAgentStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgentStatus.</param>
        /// 
        /// <returns>Returns a  CreateAgentStatusResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateAgentStatus">REST API Reference for CreateAgentStatus Operation</seealso>
        public virtual CreateAgentStatusResponse EndCreateAgentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAgentStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateContactFlow

        /// <summary>
        /// Creates a flow for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
        /// Connect Flow language</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactFlow service method.</param>
        /// 
        /// <returns>The response from the CreateContactFlow service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidContactFlowException">
        /// The flow is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateContactFlow">REST API Reference for CreateContactFlow Operation</seealso>
        public virtual CreateContactFlowResponse CreateContactFlow(CreateContactFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactFlowResponseUnmarshaller.Instance;

            return Invoke<CreateContactFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContactFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContactFlow operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContactFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateContactFlow">REST API Reference for CreateContactFlow Operation</seealso>
        public virtual IAsyncResult BeginCreateContactFlow(CreateContactFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContactFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContactFlow.</param>
        /// 
        /// <returns>Returns a  CreateContactFlowResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateContactFlow">REST API Reference for CreateContactFlow Operation</seealso>
        public virtual CreateContactFlowResponse EndCreateContactFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateContactFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateContactFlowModule

        /// <summary>
        /// Creates a flow module for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactFlowModule service method.</param>
        /// 
        /// <returns>The response from the CreateContactFlowModule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidContactFlowModuleException">
        /// The problems with the module. Please fix before trying again.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateContactFlowModule">REST API Reference for CreateContactFlowModule Operation</seealso>
        public virtual CreateContactFlowModuleResponse CreateContactFlowModule(CreateContactFlowModuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactFlowModuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactFlowModuleResponseUnmarshaller.Instance;

            return Invoke<CreateContactFlowModuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContactFlowModule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContactFlowModule operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContactFlowModule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateContactFlowModule">REST API Reference for CreateContactFlowModule Operation</seealso>
        public virtual IAsyncResult BeginCreateContactFlowModule(CreateContactFlowModuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactFlowModuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactFlowModuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContactFlowModule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContactFlowModule.</param>
        /// 
        /// <returns>Returns a  CreateContactFlowModuleResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateContactFlowModule">REST API Reference for CreateContactFlowModule Operation</seealso>
        public virtual CreateContactFlowModuleResponse EndCreateContactFlowModule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateContactFlowModuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHoursOfOperation

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Creates hours of operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHoursOfOperation service method.</param>
        /// 
        /// <returns>The response from the CreateHoursOfOperation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateHoursOfOperation">REST API Reference for CreateHoursOfOperation Operation</seealso>
        public virtual CreateHoursOfOperationResponse CreateHoursOfOperation(CreateHoursOfOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHoursOfOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHoursOfOperationResponseUnmarshaller.Instance;

            return Invoke<CreateHoursOfOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHoursOfOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHoursOfOperation operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHoursOfOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateHoursOfOperation">REST API Reference for CreateHoursOfOperation Operation</seealso>
        public virtual IAsyncResult BeginCreateHoursOfOperation(CreateHoursOfOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHoursOfOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHoursOfOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHoursOfOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHoursOfOperation.</param>
        /// 
        /// <returns>Returns a  CreateHoursOfOperationResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateHoursOfOperation">REST API Reference for CreateHoursOfOperation Operation</seealso>
        public virtual CreateHoursOfOperationResponse EndCreateHoursOfOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHoursOfOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInstance

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Initiates an Amazon Connect instance with all the supported channels enabled. It does
        /// not attach any storage, such as Amazon Simple Storage Service (Amazon S3) or Amazon
        /// Kinesis. It also does not allow for any configurations on features, such as Contact
        /// Lens for Amazon Connect. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Connect enforces a limit on the total number of instances that you can create
        /// or delete in 30 days. If you exceed this limit, you will get an error message indicating
        /// there has been an excessive number of attempts at creating or deleting instances.
        /// You must wait 30 days before you can restart creating and deleting instances in your
        /// account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance service method.</param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateInstance(CreateInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstance.</param>
        /// 
        /// <returns>Returns a  CreateInstanceResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual CreateInstanceResponse EndCreateInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIntegrationAssociation

        /// <summary>
        /// Creates an Amazon Web Services resource association with an Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateIntegrationAssociation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateIntegrationAssociation">REST API Reference for CreateIntegrationAssociation Operation</seealso>
        public virtual CreateIntegrationAssociationResponse CreateIntegrationAssociation(CreateIntegrationAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntegrationAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationAssociation operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIntegrationAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateIntegrationAssociation">REST API Reference for CreateIntegrationAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateIntegrationAssociation(CreateIntegrationAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIntegrationAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIntegrationAssociation.</param>
        /// 
        /// <returns>Returns a  CreateIntegrationAssociationResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateIntegrationAssociation">REST API Reference for CreateIntegrationAssociation Operation</seealso>
        public virtual CreateIntegrationAssociationResponse EndCreateIntegrationAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIntegrationAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateQueue

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Creates a new queue for the specified Amazon Connect instance.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the number being used in the input is claimed to a traffic distribution group,
        /// and you are calling this API using an instance in the Amazon Web Services Region where
        /// the traffic distribution group was created, you can use either a full phone number
        /// ARN or UUID value for the <code>OutboundCallerIdNumberId</code> value of the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_OutboundCallerConfig">OutboundCallerConfig</a>
        /// request body parameter. However, if the number is claimed to a traffic distribution
        /// group and you are calling this API using an instance in the alternate Amazon Web Services
        /// Region associated with the traffic distribution group, you must provide a full phone
        /// number ARN. If a UUID is provided in this scenario, you will receive a <code>ResourceNotFoundException</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return Invoke<CreateQueueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual IAsyncResult BeginCreateQueue(CreateQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueue.</param>
        /// 
        /// <returns>Returns a  CreateQueueResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual CreateQueueResponse EndCreateQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQueueResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateQuickConnect

        /// <summary>
        /// Creates a quick connect for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuickConnect service method.</param>
        /// 
        /// <returns>The response from the CreateQuickConnect service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateQuickConnect">REST API Reference for CreateQuickConnect Operation</seealso>
        public virtual CreateQuickConnectResponse CreateQuickConnect(CreateQuickConnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQuickConnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuickConnectResponseUnmarshaller.Instance;

            return Invoke<CreateQuickConnectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQuickConnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQuickConnect operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQuickConnect
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateQuickConnect">REST API Reference for CreateQuickConnect Operation</seealso>
        public virtual IAsyncResult BeginCreateQuickConnect(CreateQuickConnectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQuickConnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuickConnectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQuickConnect operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQuickConnect.</param>
        /// 
        /// <returns>Returns a  CreateQuickConnectResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateQuickConnect">REST API Reference for CreateQuickConnect Operation</seealso>
        public virtual CreateQuickConnectResponse EndCreateQuickConnect(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQuickConnectResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRoutingProfile

        /// <summary>
        /// Creates a new routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingProfile service method.</param>
        /// 
        /// <returns>The response from the CreateRoutingProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateRoutingProfile">REST API Reference for CreateRoutingProfile Operation</seealso>
        public virtual CreateRoutingProfileResponse CreateRoutingProfile(CreateRoutingProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoutingProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingProfileResponseUnmarshaller.Instance;

            return Invoke<CreateRoutingProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoutingProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingProfile operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoutingProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateRoutingProfile">REST API Reference for CreateRoutingProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateRoutingProfile(CreateRoutingProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoutingProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoutingProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoutingProfile.</param>
        /// 
        /// <returns>Returns a  CreateRoutingProfileResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateRoutingProfile">REST API Reference for CreateRoutingProfile Operation</seealso>
        public virtual CreateRoutingProfileResponse EndCreateRoutingProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRoutingProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRule

        /// <summary>
        /// Creates a rule for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/connect-rules-language.html">Rules
        /// Function language</a> to code conditions for the rule. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual IAsyncResult BeginCreateRule(CreateRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRule.</param>
        /// 
        /// <returns>Returns a  CreateRuleResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse EndCreateRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSecurityProfile

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Creates a security profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateSecurityProfile">REST API Reference for CreateSecurityProfile Operation</seealso>
        public virtual CreateSecurityProfileResponse CreateSecurityProfile(CreateSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityProfile operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateSecurityProfile">REST API Reference for CreateSecurityProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateSecurityProfile(CreateSecurityProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityProfile.</param>
        /// 
        /// <returns>Returns a  CreateSecurityProfileResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateSecurityProfile">REST API Reference for CreateSecurityProfile Operation</seealso>
        public virtual CreateSecurityProfileResponse EndCreateSecurityProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSecurityProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTaskTemplate

        /// <summary>
        /// Creates a new task template in the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTaskTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTaskTemplate service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.PropertyValidationException">
        /// The property is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateTaskTemplate">REST API Reference for CreateTaskTemplate Operation</seealso>
        public virtual CreateTaskTemplateResponse CreateTaskTemplate(CreateTaskTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTaskTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTaskTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTaskTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTaskTemplate operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTaskTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateTaskTemplate">REST API Reference for CreateTaskTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateTaskTemplate(CreateTaskTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTaskTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTaskTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTaskTemplate.</param>
        /// 
        /// <returns>Returns a  CreateTaskTemplateResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateTaskTemplate">REST API Reference for CreateTaskTemplate Operation</seealso>
        public virtual CreateTaskTemplateResponse EndCreateTaskTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTaskTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrafficDistributionGroup

        /// <summary>
        /// Creates a traffic distribution group given an Amazon Connect instance that has been
        /// replicated. 
        /// 
        ///  
        /// <para>
        /// For more information about creating traffic distribution groups, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-traffic-distribution-groups.html">Set
        /// up traffic distribution groups</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficDistributionGroup service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficDistributionGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotReadyException">
        /// The resource is not ready.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateTrafficDistributionGroup">REST API Reference for CreateTrafficDistributionGroup Operation</seealso>
        public virtual CreateTrafficDistributionGroupResponse CreateTrafficDistributionGroup(CreateTrafficDistributionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrafficDistributionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficDistributionGroupResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficDistributionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficDistributionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficDistributionGroup operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrafficDistributionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateTrafficDistributionGroup">REST API Reference for CreateTrafficDistributionGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateTrafficDistributionGroup(CreateTrafficDistributionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrafficDistributionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficDistributionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrafficDistributionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrafficDistributionGroup.</param>
        /// 
        /// <returns>Returns a  CreateTrafficDistributionGroupResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateTrafficDistributionGroup">REST API Reference for CreateTrafficDistributionGroup Operation</seealso>
        public virtual CreateTrafficDistributionGroupResponse EndCreateTrafficDistributionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrafficDistributionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUseCase

        /// <summary>
        /// Creates a use case for an integration association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUseCase service method.</param>
        /// 
        /// <returns>The response from the CreateUseCase service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUseCase">REST API Reference for CreateUseCase Operation</seealso>
        public virtual CreateUseCaseResponse CreateUseCase(CreateUseCaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUseCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUseCaseResponseUnmarshaller.Instance;

            return Invoke<CreateUseCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUseCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUseCase operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUseCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUseCase">REST API Reference for CreateUseCase Operation</seealso>
        public virtual IAsyncResult BeginCreateUseCase(CreateUseCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUseCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUseCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUseCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUseCase.</param>
        /// 
        /// <returns>Returns a  CreateUseCaseResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUseCase">REST API Reference for CreateUseCase Operation</seealso>
        public virtual CreateUseCaseResponse EndCreateUseCase(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUseCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUser

        /// <summary>
        /// Creates a user account for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For information about how to create user accounts using the Amazon Connect console,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/user-management.html">Add
        /// Users</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserHierarchyGroup

        /// <summary>
        /// Creates a new user hierarchy group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserHierarchyGroup service method.</param>
        /// 
        /// <returns>The response from the CreateUserHierarchyGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUserHierarchyGroup">REST API Reference for CreateUserHierarchyGroup Operation</seealso>
        public virtual CreateUserHierarchyGroupResponse CreateUserHierarchyGroup(CreateUserHierarchyGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserHierarchyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserHierarchyGroupResponseUnmarshaller.Instance;

            return Invoke<CreateUserHierarchyGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserHierarchyGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserHierarchyGroup operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserHierarchyGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUserHierarchyGroup">REST API Reference for CreateUserHierarchyGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateUserHierarchyGroup(CreateUserHierarchyGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserHierarchyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserHierarchyGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserHierarchyGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserHierarchyGroup.</param>
        /// 
        /// <returns>Returns a  CreateUserHierarchyGroupResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUserHierarchyGroup">REST API Reference for CreateUserHierarchyGroup Operation</seealso>
        public virtual CreateUserHierarchyGroupResponse EndCreateUserHierarchyGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserHierarchyGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVocabulary

        /// <summary>
        /// Creates a custom vocabulary associated with your Amazon Connect instance. You can
        /// set a custom vocabulary to be your default vocabulary for a given language. Contact
        /// Lens for Amazon Connect uses the default vocabulary in post-call and real-time contact
        /// analysis sessions for that language.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary service method.</param>
        /// 
        /// <returns>The response from the CreateVocabulary service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        public virtual CreateVocabularyResponse CreateVocabulary(CreateVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyResponseUnmarshaller.Instance;

            return Invoke<CreateVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        public virtual IAsyncResult BeginCreateVocabulary(CreateVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVocabulary.</param>
        /// 
        /// <returns>Returns a  CreateVocabularyResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        public virtual CreateVocabularyResponse EndCreateVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteContactFlow

        /// <summary>
        /// Deletes a flow for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactFlow service method.</param>
        /// 
        /// <returns>The response from the DeleteContactFlow service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteContactFlow">REST API Reference for DeleteContactFlow Operation</seealso>
        public virtual DeleteContactFlowResponse DeleteContactFlow(DeleteContactFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteContactFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContactFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactFlow operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContactFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteContactFlow">REST API Reference for DeleteContactFlow Operation</seealso>
        public virtual IAsyncResult BeginDeleteContactFlow(DeleteContactFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContactFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContactFlow.</param>
        /// 
        /// <returns>Returns a  DeleteContactFlowResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteContactFlow">REST API Reference for DeleteContactFlow Operation</seealso>
        public virtual DeleteContactFlowResponse EndDeleteContactFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteContactFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteContactFlowModule

        /// <summary>
        /// Deletes the specified flow module.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactFlowModule service method.</param>
        /// 
        /// <returns>The response from the DeleteContactFlowModule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteContactFlowModule">REST API Reference for DeleteContactFlowModule Operation</seealso>
        public virtual DeleteContactFlowModuleResponse DeleteContactFlowModule(DeleteContactFlowModuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactFlowModuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactFlowModuleResponseUnmarshaller.Instance;

            return Invoke<DeleteContactFlowModuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContactFlowModule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactFlowModule operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContactFlowModule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteContactFlowModule">REST API Reference for DeleteContactFlowModule Operation</seealso>
        public virtual IAsyncResult BeginDeleteContactFlowModule(DeleteContactFlowModuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactFlowModuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactFlowModuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContactFlowModule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContactFlowModule.</param>
        /// 
        /// <returns>Returns a  DeleteContactFlowModuleResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteContactFlowModule">REST API Reference for DeleteContactFlowModule Operation</seealso>
        public virtual DeleteContactFlowModuleResponse EndDeleteContactFlowModule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteContactFlowModuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteHoursOfOperation

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Deletes an hours of operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHoursOfOperation service method.</param>
        /// 
        /// <returns>The response from the DeleteHoursOfOperation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteHoursOfOperation">REST API Reference for DeleteHoursOfOperation Operation</seealso>
        public virtual DeleteHoursOfOperationResponse DeleteHoursOfOperation(DeleteHoursOfOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHoursOfOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHoursOfOperationResponseUnmarshaller.Instance;

            return Invoke<DeleteHoursOfOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHoursOfOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHoursOfOperation operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHoursOfOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteHoursOfOperation">REST API Reference for DeleteHoursOfOperation Operation</seealso>
        public virtual IAsyncResult BeginDeleteHoursOfOperation(DeleteHoursOfOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHoursOfOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHoursOfOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHoursOfOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHoursOfOperation.</param>
        /// 
        /// <returns>Returns a  DeleteHoursOfOperationResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteHoursOfOperation">REST API Reference for DeleteHoursOfOperation Operation</seealso>
        public virtual DeleteHoursOfOperationResponse EndDeleteHoursOfOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteHoursOfOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInstance

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Deletes the Amazon Connect instance.
        /// </para>
        ///  
        /// <para>
        /// Amazon Connect enforces a limit on the total number of instances that you can create
        /// or delete in 30 days. If you exceed this limit, you will get an error message indicating
        /// there has been an excessive number of attempts at creating or deleting instances.
        /// You must wait 30 days before you can restart creating and deleting instances in your
        /// account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIntegrationAssociation

        /// <summary>
        /// Deletes an Amazon Web Services resource association from an Amazon Connect instance.
        /// The association must not have any use cases associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegrationAssociation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteIntegrationAssociation">REST API Reference for DeleteIntegrationAssociation Operation</seealso>
        public virtual DeleteIntegrationAssociationResponse DeleteIntegrationAssociation(DeleteIntegrationAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegrationAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationAssociation operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntegrationAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteIntegrationAssociation">REST API Reference for DeleteIntegrationAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteIntegrationAssociation(DeleteIntegrationAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegrationAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegrationAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationAssociationResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteIntegrationAssociation">REST API Reference for DeleteIntegrationAssociation Operation</seealso>
        public virtual DeleteIntegrationAssociationResponse EndDeleteIntegrationAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIntegrationAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteQuickConnect

        /// <summary>
        /// Deletes a quick connect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuickConnect service method.</param>
        /// 
        /// <returns>The response from the DeleteQuickConnect service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteQuickConnect">REST API Reference for DeleteQuickConnect Operation</seealso>
        public virtual DeleteQuickConnectResponse DeleteQuickConnect(DeleteQuickConnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQuickConnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQuickConnectResponseUnmarshaller.Instance;

            return Invoke<DeleteQuickConnectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQuickConnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuickConnect operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQuickConnect
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteQuickConnect">REST API Reference for DeleteQuickConnect Operation</seealso>
        public virtual IAsyncResult BeginDeleteQuickConnect(DeleteQuickConnectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQuickConnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQuickConnectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQuickConnect operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQuickConnect.</param>
        /// 
        /// <returns>Returns a  DeleteQuickConnectResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteQuickConnect">REST API Reference for DeleteQuickConnect Operation</seealso>
        public virtual DeleteQuickConnectResponse EndDeleteQuickConnect(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQuickConnectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRule

        /// <summary>
        /// Deletes a rule for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSecurityProfile

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Deletes a security profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteSecurityProfile">REST API Reference for DeleteSecurityProfile Operation</seealso>
        public virtual DeleteSecurityProfileResponse DeleteSecurityProfile(DeleteSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityProfile operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteSecurityProfile">REST API Reference for DeleteSecurityProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteSecurityProfile(DeleteSecurityProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityProfile.</param>
        /// 
        /// <returns>Returns a  DeleteSecurityProfileResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteSecurityProfile">REST API Reference for DeleteSecurityProfile Operation</seealso>
        public virtual DeleteSecurityProfileResponse EndDeleteSecurityProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSecurityProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTaskTemplate

        /// <summary>
        /// Deletes the task template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTaskTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteTaskTemplate service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteTaskTemplate">REST API Reference for DeleteTaskTemplate Operation</seealso>
        public virtual DeleteTaskTemplateResponse DeleteTaskTemplate(DeleteTaskTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTaskTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteTaskTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTaskTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTaskTemplate operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTaskTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteTaskTemplate">REST API Reference for DeleteTaskTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteTaskTemplate(DeleteTaskTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTaskTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTaskTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTaskTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteTaskTemplateResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteTaskTemplate">REST API Reference for DeleteTaskTemplate Operation</seealso>
        public virtual DeleteTaskTemplateResponse EndDeleteTaskTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTaskTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTrafficDistributionGroup

        /// <summary>
        /// Deletes a traffic distribution group. This API can be called only in the Region where
        /// the traffic distribution group is created.
        /// 
        ///  
        /// <para>
        /// For more information about deleting traffic distribution groups, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/delete-traffic-distribution-groups.html">Delete
        /// traffic distribution groups</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficDistributionGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteTrafficDistributionGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteTrafficDistributionGroup">REST API Reference for DeleteTrafficDistributionGroup Operation</seealso>
        public virtual DeleteTrafficDistributionGroupResponse DeleteTrafficDistributionGroup(DeleteTrafficDistributionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrafficDistributionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrafficDistributionGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficDistributionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficDistributionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficDistributionGroup operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrafficDistributionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteTrafficDistributionGroup">REST API Reference for DeleteTrafficDistributionGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrafficDistributionGroup(DeleteTrafficDistributionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrafficDistributionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrafficDistributionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrafficDistributionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrafficDistributionGroup.</param>
        /// 
        /// <returns>Returns a  DeleteTrafficDistributionGroupResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteTrafficDistributionGroup">REST API Reference for DeleteTrafficDistributionGroup Operation</seealso>
        public virtual DeleteTrafficDistributionGroupResponse EndDeleteTrafficDistributionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTrafficDistributionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUseCase

        /// <summary>
        /// Deletes a use case from an integration association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUseCase service method.</param>
        /// 
        /// <returns>The response from the DeleteUseCase service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUseCase">REST API Reference for DeleteUseCase Operation</seealso>
        public virtual DeleteUseCaseResponse DeleteUseCase(DeleteUseCaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUseCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUseCaseResponseUnmarshaller.Instance;

            return Invoke<DeleteUseCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUseCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUseCase operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUseCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUseCase">REST API Reference for DeleteUseCase Operation</seealso>
        public virtual IAsyncResult BeginDeleteUseCase(DeleteUseCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUseCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUseCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUseCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUseCase.</param>
        /// 
        /// <returns>Returns a  DeleteUseCaseResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUseCase">REST API Reference for DeleteUseCase Operation</seealso>
        public virtual DeleteUseCaseResponse EndDeleteUseCase(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUseCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Deletes a user account from the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For information about what happens to a user's data when their account is deleted,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/delete-users.html">Delete
        /// Users from Your Amazon Connect Instance</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserHierarchyGroup

        /// <summary>
        /// Deletes an existing user hierarchy group. It must not be associated with any agents
        /// or have any active child groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserHierarchyGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteUserHierarchyGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUserHierarchyGroup">REST API Reference for DeleteUserHierarchyGroup Operation</seealso>
        public virtual DeleteUserHierarchyGroupResponse DeleteUserHierarchyGroup(DeleteUserHierarchyGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserHierarchyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserHierarchyGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteUserHierarchyGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserHierarchyGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserHierarchyGroup operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserHierarchyGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUserHierarchyGroup">REST API Reference for DeleteUserHierarchyGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserHierarchyGroup(DeleteUserHierarchyGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserHierarchyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserHierarchyGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserHierarchyGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserHierarchyGroup.</param>
        /// 
        /// <returns>Returns a  DeleteUserHierarchyGroupResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUserHierarchyGroup">REST API Reference for DeleteUserHierarchyGroup Operation</seealso>
        public virtual DeleteUserHierarchyGroupResponse EndDeleteUserHierarchyGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserHierarchyGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVocabulary

        /// <summary>
        /// Deletes the vocabulary that has the given identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabulary service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        public virtual DeleteVocabularyResponse DeleteVocabulary(DeleteVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyResponseUnmarshaller.Instance;

            return Invoke<DeleteVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        public virtual IAsyncResult BeginDeleteVocabulary(DeleteVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVocabulary.</param>
        /// 
        /// <returns>Returns a  DeleteVocabularyResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        public virtual DeleteVocabularyResponse EndDeleteVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAgentStatus

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Describes an agent status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgentStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeAgentStatus service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeAgentStatus">REST API Reference for DescribeAgentStatus Operation</seealso>
        public virtual DescribeAgentStatusResponse DescribeAgentStatus(DescribeAgentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgentStatus operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAgentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeAgentStatus">REST API Reference for DescribeAgentStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeAgentStatus(DescribeAgentStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAgentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAgentStatus.</param>
        /// 
        /// <returns>Returns a  DescribeAgentStatusResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeAgentStatus">REST API Reference for DescribeAgentStatus Operation</seealso>
        public virtual DescribeAgentStatusResponse EndDescribeAgentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAgentStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeContact

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Describes the specified contact. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Contact information remains available in Amazon Connect for 24 months, and then it
        /// is deleted.
        /// </para>
        ///  
        /// <para>
        /// Only data from November 12, 2021, and later is returned by this API.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContact service method.</param>
        /// 
        /// <returns>The response from the DescribeContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        public virtual DescribeContactResponse DescribeContact(DescribeContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContactResponseUnmarshaller.Instance;

            return Invoke<DescribeContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContact operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        public virtual IAsyncResult BeginDescribeContact(DescribeContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeContact.</param>
        /// 
        /// <returns>Returns a  DescribeContactResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        public virtual DescribeContactResponse EndDescribeContact(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeContactResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeContactFlow

        /// <summary>
        /// Describes the specified flow.
        /// 
        ///  
        /// <para>
        /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
        /// Connect Flow language</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContactFlow service method.</param>
        /// 
        /// <returns>The response from the DescribeContactFlow service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.ContactFlowNotPublishedException">
        /// The flow has not been published.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContactFlow">REST API Reference for DescribeContactFlow Operation</seealso>
        public virtual DescribeContactFlowResponse DescribeContactFlow(DescribeContactFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContactFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContactFlowResponseUnmarshaller.Instance;

            return Invoke<DescribeContactFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContactFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContactFlow operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeContactFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContactFlow">REST API Reference for DescribeContactFlow Operation</seealso>
        public virtual IAsyncResult BeginDescribeContactFlow(DescribeContactFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContactFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContactFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeContactFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeContactFlow.</param>
        /// 
        /// <returns>Returns a  DescribeContactFlowResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContactFlow">REST API Reference for DescribeContactFlow Operation</seealso>
        public virtual DescribeContactFlowResponse EndDescribeContactFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeContactFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeContactFlowModule

        /// <summary>
        /// Describes the specified flow module.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContactFlowModule service method.</param>
        /// 
        /// <returns>The response from the DescribeContactFlowModule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContactFlowModule">REST API Reference for DescribeContactFlowModule Operation</seealso>
        public virtual DescribeContactFlowModuleResponse DescribeContactFlowModule(DescribeContactFlowModuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContactFlowModuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContactFlowModuleResponseUnmarshaller.Instance;

            return Invoke<DescribeContactFlowModuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContactFlowModule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContactFlowModule operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeContactFlowModule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContactFlowModule">REST API Reference for DescribeContactFlowModule Operation</seealso>
        public virtual IAsyncResult BeginDescribeContactFlowModule(DescribeContactFlowModuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContactFlowModuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContactFlowModuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeContactFlowModule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeContactFlowModule.</param>
        /// 
        /// <returns>Returns a  DescribeContactFlowModuleResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeContactFlowModule">REST API Reference for DescribeContactFlowModule Operation</seealso>
        public virtual DescribeContactFlowModuleResponse EndDescribeContactFlowModule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeContactFlowModuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHoursOfOperation

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Describes the hours of operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHoursOfOperation service method.</param>
        /// 
        /// <returns>The response from the DescribeHoursOfOperation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeHoursOfOperation">REST API Reference for DescribeHoursOfOperation Operation</seealso>
        public virtual DescribeHoursOfOperationResponse DescribeHoursOfOperation(DescribeHoursOfOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHoursOfOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHoursOfOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeHoursOfOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHoursOfOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHoursOfOperation operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHoursOfOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeHoursOfOperation">REST API Reference for DescribeHoursOfOperation Operation</seealso>
        public virtual IAsyncResult BeginDescribeHoursOfOperation(DescribeHoursOfOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHoursOfOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHoursOfOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHoursOfOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHoursOfOperation.</param>
        /// 
        /// <returns>Returns a  DescribeHoursOfOperationResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeHoursOfOperation">REST API Reference for DescribeHoursOfOperation Operation</seealso>
        public virtual DescribeHoursOfOperationResponse EndDescribeHoursOfOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHoursOfOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstance

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns the current state of the specified instance identifier. It tracks the instance
        /// while it is being created and returns an error status, if applicable. 
        /// </para>
        ///  
        /// <para>
        /// If an instance is not created successfully, the instance status reason field returns
        /// details relevant to the reason. The instance in a failed state is returned only for
        /// 24 hours after the CreateInstance API was invoked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeInstance service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstance">REST API Reference for DescribeInstance Operation</seealso>
        public virtual DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstance operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstance">REST API Reference for DescribeInstance Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstance(DescribeInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstance.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstance">REST API Reference for DescribeInstance Operation</seealso>
        public virtual DescribeInstanceResponse EndDescribeInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstanceAttribute

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Describes the specified instance attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        public virtual DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAttributeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstanceAttribute(DescribeInstanceAttributeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceAttributeResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        public virtual DescribeInstanceAttributeResponse EndDescribeInstanceAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstanceStorageConfig

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Retrieves the current storage configurations for the specified resource type, association
        /// ID, and instance ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStorageConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceStorageConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstanceStorageConfig">REST API Reference for DescribeInstanceStorageConfig Operation</seealso>
        public virtual DescribeInstanceStorageConfigResponse DescribeInstanceStorageConfig(DescribeInstanceStorageConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceStorageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceStorageConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceStorageConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceStorageConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStorageConfig operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceStorageConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstanceStorageConfig">REST API Reference for DescribeInstanceStorageConfig Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstanceStorageConfig(DescribeInstanceStorageConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceStorageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceStorageConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceStorageConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceStorageConfig.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceStorageConfigResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeInstanceStorageConfig">REST API Reference for DescribeInstanceStorageConfig Operation</seealso>
        public virtual DescribeInstanceStorageConfigResponse EndDescribeInstanceStorageConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceStorageConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePhoneNumber

        /// <summary>
        /// Gets details and status of a phone number that’s claimed to your Amazon Connect instance
        /// or traffic distribution group.
        /// 
        ///  <important> 
        /// <para>
        /// If the number is claimed to a traffic distribution group, and you are calling in the
        /// Amazon Web Services Region where the traffic distribution group was created, you can
        /// use either a phone number ARN or UUID value for the <code>PhoneNumberId</code> URI
        /// request parameter. However, if the number is claimed to a traffic distribution group
        /// and you are calling this API in the alternate Amazon Web Services Region associated
        /// with the traffic distribution group, you must provide a full phone number ARN. If
        /// a UUID is provided in this scenario, you will receive a <code>ResourceNotFoundException</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the DescribePhoneNumber service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribePhoneNumber">REST API Reference for DescribePhoneNumber Operation</seealso>
        public virtual DescribePhoneNumberResponse DescribePhoneNumber(DescribePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<DescribePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePhoneNumber operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribePhoneNumber">REST API Reference for DescribePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginDescribePhoneNumber(DescribePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePhoneNumber.</param>
        /// 
        /// <returns>Returns a  DescribePhoneNumberResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribePhoneNumber">REST API Reference for DescribePhoneNumber Operation</seealso>
        public virtual DescribePhoneNumberResponse EndDescribePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeQueue

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Describes the specified queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueue service method.</param>
        /// 
        /// <returns>The response from the DescribeQueue service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeQueue">REST API Reference for DescribeQueue Operation</seealso>
        public virtual DescribeQueueResponse DescribeQueue(DescribeQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueueResponseUnmarshaller.Instance;

            return Invoke<DescribeQueueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueue operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeQueue">REST API Reference for DescribeQueue Operation</seealso>
        public virtual IAsyncResult BeginDescribeQueue(DescribeQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQueue.</param>
        /// 
        /// <returns>Returns a  DescribeQueueResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeQueue">REST API Reference for DescribeQueue Operation</seealso>
        public virtual DescribeQueueResponse EndDescribeQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeQueueResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeQuickConnect

        /// <summary>
        /// Describes the quick connect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuickConnect service method.</param>
        /// 
        /// <returns>The response from the DescribeQuickConnect service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeQuickConnect">REST API Reference for DescribeQuickConnect Operation</seealso>
        public virtual DescribeQuickConnectResponse DescribeQuickConnect(DescribeQuickConnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQuickConnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQuickConnectResponseUnmarshaller.Instance;

            return Invoke<DescribeQuickConnectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQuickConnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuickConnect operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQuickConnect
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeQuickConnect">REST API Reference for DescribeQuickConnect Operation</seealso>
        public virtual IAsyncResult BeginDescribeQuickConnect(DescribeQuickConnectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQuickConnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQuickConnectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQuickConnect operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQuickConnect.</param>
        /// 
        /// <returns>Returns a  DescribeQuickConnectResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeQuickConnect">REST API Reference for DescribeQuickConnect Operation</seealso>
        public virtual DescribeQuickConnectResponse EndDescribeQuickConnect(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeQuickConnectResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRoutingProfile

        /// <summary>
        /// Describes the specified routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoutingProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeRoutingProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeRoutingProfile">REST API Reference for DescribeRoutingProfile Operation</seealso>
        public virtual DescribeRoutingProfileResponse DescribeRoutingProfile(DescribeRoutingProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoutingProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoutingProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeRoutingProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRoutingProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoutingProfile operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRoutingProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeRoutingProfile">REST API Reference for DescribeRoutingProfile Operation</seealso>
        public virtual IAsyncResult BeginDescribeRoutingProfile(DescribeRoutingProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoutingProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoutingProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRoutingProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRoutingProfile.</param>
        /// 
        /// <returns>Returns a  DescribeRoutingProfileResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeRoutingProfile">REST API Reference for DescribeRoutingProfile Operation</seealso>
        public virtual DescribeRoutingProfileResponse EndDescribeRoutingProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRoutingProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRule

        /// <summary>
        /// Describes a rule for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule service method.</param>
        /// 
        /// <returns>The response from the DescribeRule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        public virtual DescribeRuleResponse DescribeRule(DescribeRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        public virtual IAsyncResult BeginDescribeRule(DescribeRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRule.</param>
        /// 
        /// <returns>Returns a  DescribeRuleResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        public virtual DescribeRuleResponse EndDescribeRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSecurityProfile

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Gets basic information about the security profle.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeSecurityProfile">REST API Reference for DescribeSecurityProfile Operation</seealso>
        public virtual DescribeSecurityProfileResponse DescribeSecurityProfile(DescribeSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityProfile operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeSecurityProfile">REST API Reference for DescribeSecurityProfile Operation</seealso>
        public virtual IAsyncResult BeginDescribeSecurityProfile(DescribeSecurityProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityProfile.</param>
        /// 
        /// <returns>Returns a  DescribeSecurityProfileResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeSecurityProfile">REST API Reference for DescribeSecurityProfile Operation</seealso>
        public virtual DescribeSecurityProfileResponse EndDescribeSecurityProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSecurityProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTrafficDistributionGroup

        /// <summary>
        /// Gets details and status of a traffic distribution group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrafficDistributionGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeTrafficDistributionGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeTrafficDistributionGroup">REST API Reference for DescribeTrafficDistributionGroup Operation</seealso>
        public virtual DescribeTrafficDistributionGroupResponse DescribeTrafficDistributionGroup(DescribeTrafficDistributionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrafficDistributionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrafficDistributionGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeTrafficDistributionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrafficDistributionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrafficDistributionGroup operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrafficDistributionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeTrafficDistributionGroup">REST API Reference for DescribeTrafficDistributionGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeTrafficDistributionGroup(DescribeTrafficDistributionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrafficDistributionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrafficDistributionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrafficDistributionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrafficDistributionGroup.</param>
        /// 
        /// <returns>Returns a  DescribeTrafficDistributionGroupResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeTrafficDistributionGroup">REST API Reference for DescribeTrafficDistributionGroup Operation</seealso>
        public virtual DescribeTrafficDistributionGroupResponse EndDescribeTrafficDistributionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTrafficDistributionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUser

        /// <summary>
        /// Describes the specified user account. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID in the Amazon Connect console</a> (it’s the final part of the ARN).
        /// The console does not display the user IDs. Instead, list the users and note the IDs
        /// provided in the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual IAsyncResult BeginDescribeUser(DescribeUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUser.</param>
        /// 
        /// <returns>Returns a  DescribeUserResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUserHierarchyGroup

        /// <summary>
        /// Describes the specified hierarchy group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserHierarchyGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeUserHierarchyGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyGroup">REST API Reference for DescribeUserHierarchyGroup Operation</seealso>
        public virtual DescribeUserHierarchyGroupResponse DescribeUserHierarchyGroup(DescribeUserHierarchyGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserHierarchyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserHierarchyGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeUserHierarchyGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserHierarchyGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserHierarchyGroup operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserHierarchyGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyGroup">REST API Reference for DescribeUserHierarchyGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeUserHierarchyGroup(DescribeUserHierarchyGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserHierarchyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserHierarchyGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserHierarchyGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserHierarchyGroup.</param>
        /// 
        /// <returns>Returns a  DescribeUserHierarchyGroupResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyGroup">REST API Reference for DescribeUserHierarchyGroup Operation</seealso>
        public virtual DescribeUserHierarchyGroupResponse EndDescribeUserHierarchyGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserHierarchyGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUserHierarchyStructure

        /// <summary>
        /// Describes the hierarchy structure of the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserHierarchyStructure service method.</param>
        /// 
        /// <returns>The response from the DescribeUserHierarchyStructure service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyStructure">REST API Reference for DescribeUserHierarchyStructure Operation</seealso>
        public virtual DescribeUserHierarchyStructureResponse DescribeUserHierarchyStructure(DescribeUserHierarchyStructureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserHierarchyStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserHierarchyStructureResponseUnmarshaller.Instance;

            return Invoke<DescribeUserHierarchyStructureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserHierarchyStructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserHierarchyStructure operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserHierarchyStructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyStructure">REST API Reference for DescribeUserHierarchyStructure Operation</seealso>
        public virtual IAsyncResult BeginDescribeUserHierarchyStructure(DescribeUserHierarchyStructureRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserHierarchyStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserHierarchyStructureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserHierarchyStructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserHierarchyStructure.</param>
        /// 
        /// <returns>Returns a  DescribeUserHierarchyStructureResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyStructure">REST API Reference for DescribeUserHierarchyStructure Operation</seealso>
        public virtual DescribeUserHierarchyStructureResponse EndDescribeUserHierarchyStructure(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserHierarchyStructureResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVocabulary

        /// <summary>
        /// Describes the specified vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVocabulary service method.</param>
        /// 
        /// <returns>The response from the DescribeVocabulary service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeVocabulary">REST API Reference for DescribeVocabulary Operation</seealso>
        public virtual DescribeVocabularyResponse DescribeVocabulary(DescribeVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVocabularyResponseUnmarshaller.Instance;

            return Invoke<DescribeVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVocabulary operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeVocabulary">REST API Reference for DescribeVocabulary Operation</seealso>
        public virtual IAsyncResult BeginDescribeVocabulary(DescribeVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVocabulary.</param>
        /// 
        /// <returns>Returns a  DescribeVocabularyResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeVocabulary">REST API Reference for DescribeVocabulary Operation</seealso>
        public virtual DescribeVocabularyResponse EndDescribeVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateApprovedOrigin

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Revokes access to integrated applications from Amazon Connect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApprovedOrigin service method.</param>
        /// 
        /// <returns>The response from the DisassociateApprovedOrigin service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateApprovedOrigin">REST API Reference for DisassociateApprovedOrigin Operation</seealso>
        public virtual DisassociateApprovedOriginResponse DisassociateApprovedOrigin(DisassociateApprovedOriginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateApprovedOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApprovedOriginResponseUnmarshaller.Instance;

            return Invoke<DisassociateApprovedOriginResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateApprovedOrigin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApprovedOrigin operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateApprovedOrigin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateApprovedOrigin">REST API Reference for DisassociateApprovedOrigin Operation</seealso>
        public virtual IAsyncResult BeginDisassociateApprovedOrigin(DisassociateApprovedOriginRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateApprovedOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApprovedOriginResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateApprovedOrigin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateApprovedOrigin.</param>
        /// 
        /// <returns>Returns a  DisassociateApprovedOriginResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateApprovedOrigin">REST API Reference for DisassociateApprovedOrigin Operation</seealso>
        public virtual DisassociateApprovedOriginResponse EndDisassociateApprovedOrigin(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateApprovedOriginResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateBot

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Revokes authorization from the specified instance to access the specified Amazon Lex
        /// or Amazon Lex V2 bot. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBot service method.</param>
        /// 
        /// <returns>The response from the DisassociateBot service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateBot">REST API Reference for DisassociateBot Operation</seealso>
        public virtual DisassociateBotResponse DisassociateBot(DisassociateBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBotResponseUnmarshaller.Instance;

            return Invoke<DisassociateBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBot operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateBot">REST API Reference for DisassociateBot Operation</seealso>
        public virtual IAsyncResult BeginDisassociateBot(DisassociateBotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateBot.</param>
        /// 
        /// <returns>Returns a  DisassociateBotResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateBot">REST API Reference for DisassociateBot Operation</seealso>
        public virtual DisassociateBotResponse EndDisassociateBot(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateBotResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateInstanceStorageConfig

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Removes the storage type configurations for the specified resource type and association
        /// ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateInstanceStorageConfig service method.</param>
        /// 
        /// <returns>The response from the DisassociateInstanceStorageConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateInstanceStorageConfig">REST API Reference for DisassociateInstanceStorageConfig Operation</seealso>
        public virtual DisassociateInstanceStorageConfigResponse DisassociateInstanceStorageConfig(DisassociateInstanceStorageConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateInstanceStorageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateInstanceStorageConfigResponseUnmarshaller.Instance;

            return Invoke<DisassociateInstanceStorageConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateInstanceStorageConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateInstanceStorageConfig operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateInstanceStorageConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateInstanceStorageConfig">REST API Reference for DisassociateInstanceStorageConfig Operation</seealso>
        public virtual IAsyncResult BeginDisassociateInstanceStorageConfig(DisassociateInstanceStorageConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateInstanceStorageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateInstanceStorageConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateInstanceStorageConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateInstanceStorageConfig.</param>
        /// 
        /// <returns>Returns a  DisassociateInstanceStorageConfigResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateInstanceStorageConfig">REST API Reference for DisassociateInstanceStorageConfig Operation</seealso>
        public virtual DisassociateInstanceStorageConfigResponse EndDisassociateInstanceStorageConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateInstanceStorageConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateLambdaFunction

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Remove the Lambda function from the dropdown options available in the relevant flow
        /// blocks.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLambdaFunction service method.</param>
        /// 
        /// <returns>The response from the DisassociateLambdaFunction service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateLambdaFunction">REST API Reference for DisassociateLambdaFunction Operation</seealso>
        public virtual DisassociateLambdaFunctionResponse DisassociateLambdaFunction(DisassociateLambdaFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLambdaFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLambdaFunctionResponseUnmarshaller.Instance;

            return Invoke<DisassociateLambdaFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateLambdaFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLambdaFunction operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateLambdaFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateLambdaFunction">REST API Reference for DisassociateLambdaFunction Operation</seealso>
        public virtual IAsyncResult BeginDisassociateLambdaFunction(DisassociateLambdaFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLambdaFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLambdaFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateLambdaFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateLambdaFunction.</param>
        /// 
        /// <returns>Returns a  DisassociateLambdaFunctionResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateLambdaFunction">REST API Reference for DisassociateLambdaFunction Operation</seealso>
        public virtual DisassociateLambdaFunctionResponse EndDisassociateLambdaFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateLambdaFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateLexBot

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Revokes authorization from the specified instance to access the specified Amazon Lex
        /// bot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLexBot service method.</param>
        /// 
        /// <returns>The response from the DisassociateLexBot service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateLexBot">REST API Reference for DisassociateLexBot Operation</seealso>
        public virtual DisassociateLexBotResponse DisassociateLexBot(DisassociateLexBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLexBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLexBotResponseUnmarshaller.Instance;

            return Invoke<DisassociateLexBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateLexBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLexBot operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateLexBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateLexBot">REST API Reference for DisassociateLexBot Operation</seealso>
        public virtual IAsyncResult BeginDisassociateLexBot(DisassociateLexBotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLexBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLexBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateLexBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateLexBot.</param>
        /// 
        /// <returns>Returns a  DisassociateLexBotResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateLexBot">REST API Reference for DisassociateLexBot Operation</seealso>
        public virtual DisassociateLexBotResponse EndDisassociateLexBot(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateLexBotResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociatePhoneNumberContactFlow

        /// <summary>
        /// Removes the flow association from a phone number claimed to your Amazon Connect instance.
        /// 
        ///  <important> 
        /// <para>
        /// If the number is claimed to a traffic distribution group, and you are calling this
        /// API using an instance in the Amazon Web Services Region where the traffic distribution
        /// group was created, you can use either a full phone number ARN or UUID value for the
        /// <code>PhoneNumberId</code> URI request parameter. However, if the number is claimed
        /// to a traffic distribution group and you are calling this API using an instance in
        /// the alternate Amazon Web Services Region associated with the traffic distribution
        /// group, you must provide a full phone number ARN. If a UUID is provided in this scenario,
        /// you will receive a <code>ResourceNotFoundException</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumberContactFlow service method.</param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumberContactFlow service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociatePhoneNumberContactFlow">REST API Reference for DisassociatePhoneNumberContactFlow Operation</seealso>
        public virtual DisassociatePhoneNumberContactFlowResponse DisassociatePhoneNumberContactFlow(DisassociatePhoneNumberContactFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumberContactFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumberContactFlowResponseUnmarshaller.Instance;

            return Invoke<DisassociatePhoneNumberContactFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumberContactFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumberContactFlow operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumberContactFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociatePhoneNumberContactFlow">REST API Reference for DisassociatePhoneNumberContactFlow Operation</seealso>
        public virtual IAsyncResult BeginDisassociatePhoneNumberContactFlow(DisassociatePhoneNumberContactFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumberContactFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumberContactFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumberContactFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumberContactFlow.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumberContactFlowResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociatePhoneNumberContactFlow">REST API Reference for DisassociatePhoneNumberContactFlow Operation</seealso>
        public virtual DisassociatePhoneNumberContactFlowResponse EndDisassociatePhoneNumberContactFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociatePhoneNumberContactFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateQueueQuickConnects

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Disassociates a set of quick connects from a queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQueueQuickConnects service method.</param>
        /// 
        /// <returns>The response from the DisassociateQueueQuickConnects service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateQueueQuickConnects">REST API Reference for DisassociateQueueQuickConnects Operation</seealso>
        public virtual DisassociateQueueQuickConnectsResponse DisassociateQueueQuickConnects(DisassociateQueueQuickConnectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateQueueQuickConnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateQueueQuickConnectsResponseUnmarshaller.Instance;

            return Invoke<DisassociateQueueQuickConnectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateQueueQuickConnects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQueueQuickConnects operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateQueueQuickConnects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateQueueQuickConnects">REST API Reference for DisassociateQueueQuickConnects Operation</seealso>
        public virtual IAsyncResult BeginDisassociateQueueQuickConnects(DisassociateQueueQuickConnectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateQueueQuickConnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateQueueQuickConnectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateQueueQuickConnects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateQueueQuickConnects.</param>
        /// 
        /// <returns>Returns a  DisassociateQueueQuickConnectsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateQueueQuickConnects">REST API Reference for DisassociateQueueQuickConnects Operation</seealso>
        public virtual DisassociateQueueQuickConnectsResponse EndDisassociateQueueQuickConnects(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateQueueQuickConnectsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateRoutingProfileQueues

        /// <summary>
        /// Disassociates a set of queues from a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRoutingProfileQueues service method.</param>
        /// 
        /// <returns>The response from the DisassociateRoutingProfileQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateRoutingProfileQueues">REST API Reference for DisassociateRoutingProfileQueues Operation</seealso>
        public virtual DisassociateRoutingProfileQueuesResponse DisassociateRoutingProfileQueues(DisassociateRoutingProfileQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRoutingProfileQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRoutingProfileQueuesResponseUnmarshaller.Instance;

            return Invoke<DisassociateRoutingProfileQueuesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRoutingProfileQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRoutingProfileQueues operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateRoutingProfileQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateRoutingProfileQueues">REST API Reference for DisassociateRoutingProfileQueues Operation</seealso>
        public virtual IAsyncResult BeginDisassociateRoutingProfileQueues(DisassociateRoutingProfileQueuesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRoutingProfileQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRoutingProfileQueuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateRoutingProfileQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRoutingProfileQueues.</param>
        /// 
        /// <returns>Returns a  DisassociateRoutingProfileQueuesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateRoutingProfileQueues">REST API Reference for DisassociateRoutingProfileQueues Operation</seealso>
        public virtual DisassociateRoutingProfileQueuesResponse EndDisassociateRoutingProfileQueues(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateRoutingProfileQueuesResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateSecurityKey

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Deletes the specified security key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSecurityKey service method.</param>
        /// 
        /// <returns>The response from the DisassociateSecurityKey service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateSecurityKey">REST API Reference for DisassociateSecurityKey Operation</seealso>
        public virtual DisassociateSecurityKeyResponse DisassociateSecurityKey(DisassociateSecurityKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSecurityKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSecurityKeyResponseUnmarshaller.Instance;

            return Invoke<DisassociateSecurityKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSecurityKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSecurityKey operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSecurityKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateSecurityKey">REST API Reference for DisassociateSecurityKey Operation</seealso>
        public virtual IAsyncResult BeginDisassociateSecurityKey(DisassociateSecurityKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSecurityKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSecurityKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSecurityKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSecurityKey.</param>
        /// 
        /// <returns>Returns a  DisassociateSecurityKeyResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DisassociateSecurityKey">REST API Reference for DisassociateSecurityKey Operation</seealso>
        public virtual DisassociateSecurityKeyResponse EndDisassociateSecurityKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateSecurityKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DismissUserContact

        /// <summary>
        /// Dismisses contacts from an agent’s CCP and returns the agent to an available state,
        /// which allows the agent to receive a new routed contact. Contacts can only be dismissed
        /// if they are in a <code>MISSED</code>, <code>ERROR</code>, <code>ENDED</code>, or <code>REJECTED</code>
        /// state in the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/about-contact-states.html">Agent
        /// Event Stream</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DismissUserContact service method.</param>
        /// 
        /// <returns>The response from the DismissUserContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DismissUserContact">REST API Reference for DismissUserContact Operation</seealso>
        public virtual DismissUserContactResponse DismissUserContact(DismissUserContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DismissUserContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DismissUserContactResponseUnmarshaller.Instance;

            return Invoke<DismissUserContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DismissUserContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DismissUserContact operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDismissUserContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DismissUserContact">REST API Reference for DismissUserContact Operation</seealso>
        public virtual IAsyncResult BeginDismissUserContact(DismissUserContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DismissUserContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DismissUserContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DismissUserContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDismissUserContact.</param>
        /// 
        /// <returns>Returns a  DismissUserContactResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DismissUserContact">REST API Reference for DismissUserContact Operation</seealso>
        public virtual DismissUserContactResponse EndDismissUserContact(IAsyncResult asyncResult)
        {
            return EndInvoke<DismissUserContactResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContactAttributes

        /// <summary>
        /// Retrieves the contact attributes for the specified contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactAttributes service method.</param>
        /// 
        /// <returns>The response from the GetContactAttributes service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetContactAttributes">REST API Reference for GetContactAttributes Operation</seealso>
        public virtual GetContactAttributesResponse GetContactAttributes(GetContactAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactAttributesResponseUnmarshaller.Instance;

            return Invoke<GetContactAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContactAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactAttributes operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetContactAttributes">REST API Reference for GetContactAttributes Operation</seealso>
        public virtual IAsyncResult BeginGetContactAttributes(GetContactAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactAttributes.</param>
        /// 
        /// <returns>Returns a  GetContactAttributesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetContactAttributes">REST API Reference for GetContactAttributes Operation</seealso>
        public virtual GetContactAttributesResponse EndGetContactAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContactAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCurrentMetricData

        /// <summary>
        /// Gets the real-time metric data from the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For a description of each metric, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html">Real-time
        /// Metrics Definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentMetricData service method.</param>
        /// 
        /// <returns>The response from the GetCurrentMetricData service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetCurrentMetricData">REST API Reference for GetCurrentMetricData Operation</seealso>
        public virtual GetCurrentMetricDataResponse GetCurrentMetricData(GetCurrentMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCurrentMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCurrentMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetCurrentMetricDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCurrentMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentMetricData operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCurrentMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetCurrentMetricData">REST API Reference for GetCurrentMetricData Operation</seealso>
        public virtual IAsyncResult BeginGetCurrentMetricData(GetCurrentMetricDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCurrentMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCurrentMetricDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCurrentMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCurrentMetricData.</param>
        /// 
        /// <returns>Returns a  GetCurrentMetricDataResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetCurrentMetricData">REST API Reference for GetCurrentMetricData Operation</seealso>
        public virtual GetCurrentMetricDataResponse EndGetCurrentMetricData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCurrentMetricDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCurrentUserData

        /// <summary>
        /// Gets the real-time active user data from the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentUserData service method.</param>
        /// 
        /// <returns>The response from the GetCurrentUserData service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetCurrentUserData">REST API Reference for GetCurrentUserData Operation</seealso>
        public virtual GetCurrentUserDataResponse GetCurrentUserData(GetCurrentUserDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCurrentUserDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCurrentUserDataResponseUnmarshaller.Instance;

            return Invoke<GetCurrentUserDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCurrentUserData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentUserData operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCurrentUserData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetCurrentUserData">REST API Reference for GetCurrentUserData Operation</seealso>
        public virtual IAsyncResult BeginGetCurrentUserData(GetCurrentUserDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCurrentUserDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCurrentUserDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCurrentUserData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCurrentUserData.</param>
        /// 
        /// <returns>Returns a  GetCurrentUserDataResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetCurrentUserData">REST API Reference for GetCurrentUserData Operation</seealso>
        public virtual GetCurrentUserDataResponse EndGetCurrentUserData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCurrentUserDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFederationToken

        /// <summary>
        /// Retrieves a token for federation.
        /// 
        ///  <note> 
        /// <para>
        /// This API doesn't support root users. If you try to invoke GetFederationToken with
        /// root credentials, an error message similar to the following one appears: 
        /// </para>
        ///  
        /// <para>
        ///  <code>Provided identity: Principal: .... User: .... cannot be used for federation
        /// with Amazon Connect</code> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken service method.</param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.UserNotFoundException">
        /// No user with the specified credentials was found in the Amazon Connect instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        public virtual GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFederationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFederationTokenResponseUnmarshaller.Instance;

            return Invoke<GetFederationTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFederationToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFederationToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        public virtual IAsyncResult BeginGetFederationToken(GetFederationTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFederationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFederationTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFederationToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFederationToken.</param>
        /// 
        /// <returns>Returns a  GetFederationTokenResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        public virtual GetFederationTokenResponse EndGetFederationToken(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFederationTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMetricData

        /// <summary>
        /// Gets historical metric data from the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For a description of each historical metric, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html">Historical
        /// Metrics Definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        public virtual GetMetricDataResponse GetMetricData(GetMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetMetricDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        public virtual IAsyncResult BeginGetMetricData(GetMetricDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricData.</param>
        /// 
        /// <returns>Returns a  GetMetricDataResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        public virtual GetMetricDataResponse EndGetMetricData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMetricDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMetricDataV2

        /// <summary>
        /// Gets metric data from the specified Amazon Connect instance. 
        /// 
        ///  
        /// <para>
        ///  <code>GetMetricDataV2</code> offers more features than <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_GetMetricData.html">GetMetricData</a>,
        /// the previous version of this API. It has new metrics, offers filtering at a metric
        /// level, and offers the ability to filter and group data by channels, queues, routing
        /// profiles, agents, and agent hierarchy levels. It can retrieve historical data for
        /// the last 14 days, in 24-hour intervals.
        /// </para>
        ///  
        /// <para>
        /// For a description of the historical metrics that are supported by <code>GetMetricDataV2</code>
        /// and <code>GetMetricData</code>, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html">Historical
        /// metrics definitions</a> in the <i>Amazon Connect Administrator's Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This API is not available in the Amazon Web Services GovCloud (US) Regions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricDataV2 service method.</param>
        /// 
        /// <returns>The response from the GetMetricDataV2 service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetMetricDataV2">REST API Reference for GetMetricDataV2 Operation</seealso>
        public virtual GetMetricDataV2Response GetMetricDataV2(GetMetricDataV2Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricDataV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataV2ResponseUnmarshaller.Instance;

            return Invoke<GetMetricDataV2Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricDataV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricDataV2 operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetricDataV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetMetricDataV2">REST API Reference for GetMetricDataV2 Operation</seealso>
        public virtual IAsyncResult BeginGetMetricDataV2(GetMetricDataV2Request request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricDataV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataV2ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetricDataV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricDataV2.</param>
        /// 
        /// <returns>Returns a  GetMetricDataV2Result from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetMetricDataV2">REST API Reference for GetMetricDataV2 Operation</seealso>
        public virtual GetMetricDataV2Response EndGetMetricDataV2(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMetricDataV2Response>(asyncResult);
        }

        #endregion
        
        #region  GetTaskTemplate

        /// <summary>
        /// Gets details about a specific task template in the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaskTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTaskTemplate service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetTaskTemplate">REST API Reference for GetTaskTemplate Operation</seealso>
        public virtual GetTaskTemplateResponse GetTaskTemplate(GetTaskTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTaskTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaskTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTaskTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTaskTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTaskTemplate operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTaskTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetTaskTemplate">REST API Reference for GetTaskTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetTaskTemplate(GetTaskTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTaskTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaskTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTaskTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTaskTemplate.</param>
        /// 
        /// <returns>Returns a  GetTaskTemplateResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetTaskTemplate">REST API Reference for GetTaskTemplate Operation</seealso>
        public virtual GetTaskTemplateResponse EndGetTaskTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTaskTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTrafficDistribution

        /// <summary>
        /// Retrieves the current traffic distribution for a given traffic distribution group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficDistribution service method.</param>
        /// 
        /// <returns>The response from the GetTrafficDistribution service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetTrafficDistribution">REST API Reference for GetTrafficDistribution Operation</seealso>
        public virtual GetTrafficDistributionResponse GetTrafficDistribution(GetTrafficDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrafficDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficDistributionResponseUnmarshaller.Instance;

            return Invoke<GetTrafficDistributionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficDistribution operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrafficDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetTrafficDistribution">REST API Reference for GetTrafficDistribution Operation</seealso>
        public virtual IAsyncResult BeginGetTrafficDistribution(GetTrafficDistributionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrafficDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficDistributionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrafficDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrafficDistribution.</param>
        /// 
        /// <returns>Returns a  GetTrafficDistributionResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetTrafficDistribution">REST API Reference for GetTrafficDistribution Operation</seealso>
        public virtual GetTrafficDistributionResponse EndGetTrafficDistribution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTrafficDistributionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgentStatuses

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Lists agent statuses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentStatuses service method.</param>
        /// 
        /// <returns>The response from the ListAgentStatuses service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListAgentStatuses">REST API Reference for ListAgentStatuses Operation</seealso>
        public virtual ListAgentStatusesResponse ListAgentStatuses(ListAgentStatusesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentStatusesResponseUnmarshaller.Instance;

            return Invoke<ListAgentStatusesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgentStatuses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentStatuses operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentStatuses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListAgentStatuses">REST API Reference for ListAgentStatuses Operation</seealso>
        public virtual IAsyncResult BeginListAgentStatuses(ListAgentStatusesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentStatusesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentStatuses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentStatuses.</param>
        /// 
        /// <returns>Returns a  ListAgentStatusesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListAgentStatuses">REST API Reference for ListAgentStatuses Operation</seealso>
        public virtual ListAgentStatusesResponse EndListAgentStatuses(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgentStatusesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApprovedOrigins

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of all approved origins associated with the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApprovedOrigins service method.</param>
        /// 
        /// <returns>The response from the ListApprovedOrigins service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListApprovedOrigins">REST API Reference for ListApprovedOrigins Operation</seealso>
        public virtual ListApprovedOriginsResponse ListApprovedOrigins(ListApprovedOriginsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApprovedOriginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApprovedOriginsResponseUnmarshaller.Instance;

            return Invoke<ListApprovedOriginsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApprovedOrigins operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApprovedOrigins operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApprovedOrigins
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListApprovedOrigins">REST API Reference for ListApprovedOrigins Operation</seealso>
        public virtual IAsyncResult BeginListApprovedOrigins(ListApprovedOriginsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApprovedOriginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApprovedOriginsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApprovedOrigins operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApprovedOrigins.</param>
        /// 
        /// <returns>Returns a  ListApprovedOriginsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListApprovedOrigins">REST API Reference for ListApprovedOrigins Operation</seealso>
        public virtual ListApprovedOriginsResponse EndListApprovedOrigins(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApprovedOriginsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBots

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// For the specified version of Amazon Lex, returns a paginated list of all the Amazon
        /// Lex bots currently associated with the instance. Use this API to returns both Amazon
        /// Lex V1 and V2 bots.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// 
        /// <returns>The response from the ListBots service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListBots">REST API Reference for ListBots Operation</seealso>
        public virtual ListBotsResponse ListBots(ListBotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBotsResponseUnmarshaller.Instance;

            return Invoke<ListBotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBots operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListBots">REST API Reference for ListBots Operation</seealso>
        public virtual IAsyncResult BeginListBots(ListBotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBots.</param>
        /// 
        /// <returns>Returns a  ListBotsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListBots">REST API Reference for ListBots Operation</seealso>
        public virtual ListBotsResponse EndListBots(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBotsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContactFlowModules

        /// <summary>
        /// Provides information about the flow modules for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactFlowModules service method.</param>
        /// 
        /// <returns>The response from the ListContactFlowModules service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactFlowModules">REST API Reference for ListContactFlowModules Operation</seealso>
        public virtual ListContactFlowModulesResponse ListContactFlowModules(ListContactFlowModulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactFlowModulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactFlowModulesResponseUnmarshaller.Instance;

            return Invoke<ListContactFlowModulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContactFlowModules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContactFlowModules operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContactFlowModules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactFlowModules">REST API Reference for ListContactFlowModules Operation</seealso>
        public virtual IAsyncResult BeginListContactFlowModules(ListContactFlowModulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactFlowModulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactFlowModulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContactFlowModules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContactFlowModules.</param>
        /// 
        /// <returns>Returns a  ListContactFlowModulesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactFlowModules">REST API Reference for ListContactFlowModules Operation</seealso>
        public virtual ListContactFlowModulesResponse EndListContactFlowModules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContactFlowModulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContactFlows

        /// <summary>
        /// Provides information about the flows for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
        /// Connect Flow language</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about flows, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-contact-flows.html">Flows</a>
        /// in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactFlows service method.</param>
        /// 
        /// <returns>The response from the ListContactFlows service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactFlows">REST API Reference for ListContactFlows Operation</seealso>
        public virtual ListContactFlowsResponse ListContactFlows(ListContactFlowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactFlowsResponseUnmarshaller.Instance;

            return Invoke<ListContactFlowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContactFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContactFlows operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContactFlows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactFlows">REST API Reference for ListContactFlows Operation</seealso>
        public virtual IAsyncResult BeginListContactFlows(ListContactFlowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactFlowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContactFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContactFlows.</param>
        /// 
        /// <returns>Returns a  ListContactFlowsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactFlows">REST API Reference for ListContactFlows Operation</seealso>
        public virtual ListContactFlowsResponse EndListContactFlows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContactFlowsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContactReferences

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// For the specified <code>referenceTypes</code>, returns a list of references associated
        /// with the contact. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactReferences service method.</param>
        /// 
        /// <returns>The response from the ListContactReferences service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactReferences">REST API Reference for ListContactReferences Operation</seealso>
        public virtual ListContactReferencesResponse ListContactReferences(ListContactReferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactReferencesResponseUnmarshaller.Instance;

            return Invoke<ListContactReferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContactReferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContactReferences operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContactReferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactReferences">REST API Reference for ListContactReferences Operation</seealso>
        public virtual IAsyncResult BeginListContactReferences(ListContactReferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactReferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContactReferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContactReferences.</param>
        /// 
        /// <returns>Returns a  ListContactReferencesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactReferences">REST API Reference for ListContactReferences Operation</seealso>
        public virtual ListContactReferencesResponse EndListContactReferences(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContactReferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDefaultVocabularies

        /// <summary>
        /// Lists the default vocabularies for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDefaultVocabularies service method.</param>
        /// 
        /// <returns>The response from the ListDefaultVocabularies service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListDefaultVocabularies">REST API Reference for ListDefaultVocabularies Operation</seealso>
        public virtual ListDefaultVocabulariesResponse ListDefaultVocabularies(ListDefaultVocabulariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDefaultVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDefaultVocabulariesResponseUnmarshaller.Instance;

            return Invoke<ListDefaultVocabulariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDefaultVocabularies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDefaultVocabularies operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDefaultVocabularies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListDefaultVocabularies">REST API Reference for ListDefaultVocabularies Operation</seealso>
        public virtual IAsyncResult BeginListDefaultVocabularies(ListDefaultVocabulariesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDefaultVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDefaultVocabulariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDefaultVocabularies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDefaultVocabularies.</param>
        /// 
        /// <returns>Returns a  ListDefaultVocabulariesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListDefaultVocabularies">REST API Reference for ListDefaultVocabularies Operation</seealso>
        public virtual ListDefaultVocabulariesResponse EndListDefaultVocabularies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDefaultVocabulariesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHoursOfOperations

        /// <summary>
        /// Provides information about the hours of operation for the specified Amazon Connect
        /// instance.
        /// 
        ///  
        /// <para>
        /// For more information about hours of operation, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-hours-operation.html">Set
        /// the Hours of Operation for a Queue</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHoursOfOperations service method.</param>
        /// 
        /// <returns>The response from the ListHoursOfOperations service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListHoursOfOperations">REST API Reference for ListHoursOfOperations Operation</seealso>
        public virtual ListHoursOfOperationsResponse ListHoursOfOperations(ListHoursOfOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHoursOfOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHoursOfOperationsResponseUnmarshaller.Instance;

            return Invoke<ListHoursOfOperationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHoursOfOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHoursOfOperations operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHoursOfOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListHoursOfOperations">REST API Reference for ListHoursOfOperations Operation</seealso>
        public virtual IAsyncResult BeginListHoursOfOperations(ListHoursOfOperationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHoursOfOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHoursOfOperationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHoursOfOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHoursOfOperations.</param>
        /// 
        /// <returns>Returns a  ListHoursOfOperationsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListHoursOfOperations">REST API Reference for ListHoursOfOperations Operation</seealso>
        public virtual ListHoursOfOperationsResponse EndListHoursOfOperations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHoursOfOperationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstanceAttributes

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of all attribute types for the given instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceAttributes service method.</param>
        /// 
        /// <returns>The response from the ListInstanceAttributes service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstanceAttributes">REST API Reference for ListInstanceAttributes Operation</seealso>
        public virtual ListInstanceAttributesResponse ListInstanceAttributes(ListInstanceAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceAttributesResponseUnmarshaller.Instance;

            return Invoke<ListInstanceAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceAttributes operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstanceAttributes">REST API Reference for ListInstanceAttributes Operation</seealso>
        public virtual IAsyncResult BeginListInstanceAttributes(ListInstanceAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceAttributes.</param>
        /// 
        /// <returns>Returns a  ListInstanceAttributesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstanceAttributes">REST API Reference for ListInstanceAttributes Operation</seealso>
        public virtual ListInstanceAttributesResponse EndListInstanceAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstanceAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstances

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Return a list of instances which are in active state, creation-in-progress state,
        /// and failed state. Instances that aren't successfully created (they are in a failed
        /// state) are returned only for 24 hours after the CreateInstance API was invoked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual IAsyncResult BeginListInstances(ListInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a  ListInstancesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse EndListInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstanceStorageConfigs

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of storage configs for the identified instance and resource
        /// type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceStorageConfigs service method.</param>
        /// 
        /// <returns>The response from the ListInstanceStorageConfigs service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstanceStorageConfigs">REST API Reference for ListInstanceStorageConfigs Operation</seealso>
        public virtual ListInstanceStorageConfigsResponse ListInstanceStorageConfigs(ListInstanceStorageConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceStorageConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceStorageConfigsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceStorageConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceStorageConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceStorageConfigs operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceStorageConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstanceStorageConfigs">REST API Reference for ListInstanceStorageConfigs Operation</seealso>
        public virtual IAsyncResult BeginListInstanceStorageConfigs(ListInstanceStorageConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceStorageConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceStorageConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceStorageConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceStorageConfigs.</param>
        /// 
        /// <returns>Returns a  ListInstanceStorageConfigsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListInstanceStorageConfigs">REST API Reference for ListInstanceStorageConfigs Operation</seealso>
        public virtual ListInstanceStorageConfigsResponse EndListInstanceStorageConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstanceStorageConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIntegrationAssociations

        /// <summary>
        /// Provides summary information about the Amazon Web Services resource associations for
        /// the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListIntegrationAssociations service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListIntegrationAssociations">REST API Reference for ListIntegrationAssociations Operation</seealso>
        public virtual ListIntegrationAssociationsResponse ListIntegrationAssociations(ListIntegrationAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIntegrationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListIntegrationAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIntegrationAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrationAssociations operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIntegrationAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListIntegrationAssociations">REST API Reference for ListIntegrationAssociations Operation</seealso>
        public virtual IAsyncResult BeginListIntegrationAssociations(ListIntegrationAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIntegrationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIntegrationAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIntegrationAssociations.</param>
        /// 
        /// <returns>Returns a  ListIntegrationAssociationsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListIntegrationAssociations">REST API Reference for ListIntegrationAssociations Operation</seealso>
        public virtual ListIntegrationAssociationsResponse EndListIntegrationAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIntegrationAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLambdaFunctions

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of all Lambda functions that display in the dropdown options
        /// in the relevant flow blocks.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLambdaFunctions service method.</param>
        /// 
        /// <returns>The response from the ListLambdaFunctions service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListLambdaFunctions">REST API Reference for ListLambdaFunctions Operation</seealso>
        public virtual ListLambdaFunctionsResponse ListLambdaFunctions(ListLambdaFunctionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLambdaFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLambdaFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListLambdaFunctionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLambdaFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLambdaFunctions operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLambdaFunctions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListLambdaFunctions">REST API Reference for ListLambdaFunctions Operation</seealso>
        public virtual IAsyncResult BeginListLambdaFunctions(ListLambdaFunctionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLambdaFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLambdaFunctionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLambdaFunctions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLambdaFunctions.</param>
        /// 
        /// <returns>Returns a  ListLambdaFunctionsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListLambdaFunctions">REST API Reference for ListLambdaFunctions Operation</seealso>
        public virtual ListLambdaFunctionsResponse EndListLambdaFunctions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLambdaFunctionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLexBots

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of all the Amazon Lex V1 bots currently associated with the
        /// instance. To return both Amazon Lex V1 and V2 bots, use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListBots.html">ListBots</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLexBots service method.</param>
        /// 
        /// <returns>The response from the ListLexBots service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListLexBots">REST API Reference for ListLexBots Operation</seealso>
        public virtual ListLexBotsResponse ListLexBots(ListLexBotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLexBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLexBotsResponseUnmarshaller.Instance;

            return Invoke<ListLexBotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLexBots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLexBots operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLexBots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListLexBots">REST API Reference for ListLexBots Operation</seealso>
        public virtual IAsyncResult BeginListLexBots(ListLexBotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLexBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLexBotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLexBots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLexBots.</param>
        /// 
        /// <returns>Returns a  ListLexBotsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListLexBots">REST API Reference for ListLexBots Operation</seealso>
        public virtual ListLexBotsResponse EndListLexBots(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLexBotsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPhoneNumbers

        /// <summary>
        /// Provides information about the phone numbers for the specified Amazon Connect instance.
        /// 
        /// 
        ///  
        /// <para>
        /// For more information about phone numbers, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-center-phone-number.html">Set
        /// Up Phone Numbers for Your Contact Center</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The phone number <code>Arn</code> value that is returned from each of the items in
        /// the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbers.html#connect-ListPhoneNumbers-response-PhoneNumberSummaryList">PhoneNumberSummaryList</a>
        /// cannot be used to tag phone number resources. It will fail with a <code>ResourceNotFoundException</code>.
        /// Instead, use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
        /// API. It returns the new phone number ARN that can be used to tag phone number resources.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
        /// 
        /// <returns>The response from the ListPhoneNumbers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        public virtual ListPhoneNumbersResponse ListPhoneNumbers(ListPhoneNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<ListPhoneNumbersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        public virtual IAsyncResult BeginListPhoneNumbers(ListPhoneNumbersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumbers.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumbersResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        public virtual ListPhoneNumbersResponse EndListPhoneNumbers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPhoneNumbersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPhoneNumbersV2

        /// <summary>
        /// Lists phone numbers claimed to your Amazon Connect instance or traffic distribution
        /// group. If the provided <code>TargetArn</code> is a traffic distribution group, you
        /// can call this API in both Amazon Web Services Regions associated with traffic distribution
        /// group.
        /// 
        ///  
        /// <para>
        /// For more information about phone numbers, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-center-phone-number.html">Set
        /// Up Phone Numbers for Your Contact Center</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbersV2 service method.</param>
        /// 
        /// <returns>The response from the ListPhoneNumbersV2 service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPhoneNumbersV2">REST API Reference for ListPhoneNumbersV2 Operation</seealso>
        public virtual ListPhoneNumbersV2Response ListPhoneNumbersV2(ListPhoneNumbersV2Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersV2ResponseUnmarshaller.Instance;

            return Invoke<ListPhoneNumbersV2Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumbersV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbersV2 operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumbersV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPhoneNumbersV2">REST API Reference for ListPhoneNumbersV2 Operation</seealso>
        public virtual IAsyncResult BeginListPhoneNumbersV2(ListPhoneNumbersV2Request request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersV2ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumbersV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumbersV2.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumbersV2Result from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPhoneNumbersV2">REST API Reference for ListPhoneNumbersV2 Operation</seealso>
        public virtual ListPhoneNumbersV2Response EndListPhoneNumbersV2(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPhoneNumbersV2Response>(asyncResult);
        }

        #endregion
        
        #region  ListPrompts

        /// <summary>
        /// Provides information about the prompts for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrompts service method.</param>
        /// 
        /// <returns>The response from the ListPrompts service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPrompts">REST API Reference for ListPrompts Operation</seealso>
        public virtual ListPromptsResponse ListPrompts(ListPromptsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPromptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPromptsResponseUnmarshaller.Instance;

            return Invoke<ListPromptsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrompts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrompts operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrompts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPrompts">REST API Reference for ListPrompts Operation</seealso>
        public virtual IAsyncResult BeginListPrompts(ListPromptsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPromptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPromptsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrompts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrompts.</param>
        /// 
        /// <returns>Returns a  ListPromptsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPrompts">REST API Reference for ListPrompts Operation</seealso>
        public virtual ListPromptsResponse EndListPrompts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPromptsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListQueueQuickConnects

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Lists the quick connects associated with a queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueQuickConnects service method.</param>
        /// 
        /// <returns>The response from the ListQueueQuickConnects service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQueueQuickConnects">REST API Reference for ListQueueQuickConnects Operation</seealso>
        public virtual ListQueueQuickConnectsResponse ListQueueQuickConnects(ListQueueQuickConnectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueueQuickConnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueQuickConnectsResponseUnmarshaller.Instance;

            return Invoke<ListQueueQuickConnectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueueQuickConnects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueueQuickConnects operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueueQuickConnects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQueueQuickConnects">REST API Reference for ListQueueQuickConnects Operation</seealso>
        public virtual IAsyncResult BeginListQueueQuickConnects(ListQueueQuickConnectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueueQuickConnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueQuickConnectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueueQuickConnects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueueQuickConnects.</param>
        /// 
        /// <returns>Returns a  ListQueueQuickConnectsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQueueQuickConnects">REST API Reference for ListQueueQuickConnects Operation</seealso>
        public virtual ListQueueQuickConnectsResponse EndListQueueQuickConnects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueueQuickConnectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListQueues

        /// <summary>
        /// Provides information about the queues for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// If you do not specify a <code>QueueTypes</code> parameter, both standard and agent
        /// queues are returned. This might cause an unexpected truncation of results if you have
        /// more than 1000 agents and you limit the number of results of the API call in code.
        /// </para>
        ///  
        /// <para>
        /// For more information about queues, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-queues-standard-and-agent.html">Queues:
        /// Standard and Agent</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return Invoke<ListQueuesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueues operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual IAsyncResult BeginListQueues(ListQueuesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueues.</param>
        /// 
        /// <returns>Returns a  ListQueuesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual ListQueuesResponse EndListQueues(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueuesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListQuickConnects

        /// <summary>
        /// Provides information about the quick connects for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickConnects service method.</param>
        /// 
        /// <returns>The response from the ListQuickConnects service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQuickConnects">REST API Reference for ListQuickConnects Operation</seealso>
        public virtual ListQuickConnectsResponse ListQuickConnects(ListQuickConnectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQuickConnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickConnectsResponseUnmarshaller.Instance;

            return Invoke<ListQuickConnectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQuickConnects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQuickConnects operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQuickConnects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQuickConnects">REST API Reference for ListQuickConnects Operation</seealso>
        public virtual IAsyncResult BeginListQuickConnects(ListQuickConnectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQuickConnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickConnectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQuickConnects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQuickConnects.</param>
        /// 
        /// <returns>Returns a  ListQuickConnectsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQuickConnects">REST API Reference for ListQuickConnects Operation</seealso>
        public virtual ListQuickConnectsResponse EndListQuickConnects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQuickConnectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRoutingProfileQueues

        /// <summary>
        /// Lists the queues associated with a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingProfileQueues service method.</param>
        /// 
        /// <returns>The response from the ListRoutingProfileQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRoutingProfileQueues">REST API Reference for ListRoutingProfileQueues Operation</seealso>
        public virtual ListRoutingProfileQueuesResponse ListRoutingProfileQueues(ListRoutingProfileQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoutingProfileQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingProfileQueuesResponseUnmarshaller.Instance;

            return Invoke<ListRoutingProfileQueuesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoutingProfileQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingProfileQueues operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoutingProfileQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRoutingProfileQueues">REST API Reference for ListRoutingProfileQueues Operation</seealso>
        public virtual IAsyncResult BeginListRoutingProfileQueues(ListRoutingProfileQueuesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoutingProfileQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingProfileQueuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoutingProfileQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoutingProfileQueues.</param>
        /// 
        /// <returns>Returns a  ListRoutingProfileQueuesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRoutingProfileQueues">REST API Reference for ListRoutingProfileQueues Operation</seealso>
        public virtual ListRoutingProfileQueuesResponse EndListRoutingProfileQueues(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRoutingProfileQueuesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRoutingProfiles

        /// <summary>
        /// Provides summary information about the routing profiles for the specified Amazon Connect
        /// instance.
        /// 
        ///  
        /// <para>
        /// For more information about routing profiles, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-routing.html">Routing
        /// Profiles</a> and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/routing-profiles.html">Create
        /// a Routing Profile</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingProfiles service method.</param>
        /// 
        /// <returns>The response from the ListRoutingProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRoutingProfiles">REST API Reference for ListRoutingProfiles Operation</seealso>
        public virtual ListRoutingProfilesResponse ListRoutingProfiles(ListRoutingProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoutingProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingProfilesResponseUnmarshaller.Instance;

            return Invoke<ListRoutingProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoutingProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingProfiles operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoutingProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRoutingProfiles">REST API Reference for ListRoutingProfiles Operation</seealso>
        public virtual IAsyncResult BeginListRoutingProfiles(ListRoutingProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoutingProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoutingProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoutingProfiles.</param>
        /// 
        /// <returns>Returns a  ListRoutingProfilesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRoutingProfiles">REST API Reference for ListRoutingProfiles Operation</seealso>
        public virtual ListRoutingProfilesResponse EndListRoutingProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRoutingProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRules

        /// <summary>
        /// List all rules for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse EndListRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSecurityKeys

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of all security keys associated with the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityKeys service method.</param>
        /// 
        /// <returns>The response from the ListSecurityKeys service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityKeys">REST API Reference for ListSecurityKeys Operation</seealso>
        public virtual ListSecurityKeysResponse ListSecurityKeys(ListSecurityKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityKeysResponseUnmarshaller.Instance;

            return Invoke<ListSecurityKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityKeys operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityKeys">REST API Reference for ListSecurityKeys Operation</seealso>
        public virtual IAsyncResult BeginListSecurityKeys(ListSecurityKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityKeys.</param>
        /// 
        /// <returns>Returns a  ListSecurityKeysResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityKeys">REST API Reference for ListSecurityKeys Operation</seealso>
        public virtual ListSecurityKeysResponse EndListSecurityKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSecurityKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSecurityProfilePermissions

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Lists the permissions granted to a security profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfilePermissions service method.</param>
        /// 
        /// <returns>The response from the ListSecurityProfilePermissions service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityProfilePermissions">REST API Reference for ListSecurityProfilePermissions Operation</seealso>
        public virtual ListSecurityProfilePermissionsResponse ListSecurityProfilePermissions(ListSecurityProfilePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilePermissionsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityProfilePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityProfilePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfilePermissions operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityProfilePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityProfilePermissions">REST API Reference for ListSecurityProfilePermissions Operation</seealso>
        public virtual IAsyncResult BeginListSecurityProfilePermissions(ListSecurityProfilePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityProfilePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityProfilePermissions.</param>
        /// 
        /// <returns>Returns a  ListSecurityProfilePermissionsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityProfilePermissions">REST API Reference for ListSecurityProfilePermissions Operation</seealso>
        public virtual ListSecurityProfilePermissionsResponse EndListSecurityProfilePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSecurityProfilePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSecurityProfiles

        /// <summary>
        /// Provides summary information about the security profiles for the specified Amazon
        /// Connect instance.
        /// 
        ///  
        /// <para>
        /// For more information about security profiles, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/connect-security-profiles.html">Security
        /// Profiles</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfiles service method.</param>
        /// 
        /// <returns>The response from the ListSecurityProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        public virtual ListSecurityProfilesResponse ListSecurityProfiles(ListSecurityProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilesResponseUnmarshaller.Instance;

            return Invoke<ListSecurityProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfiles operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        public virtual IAsyncResult BeginListSecurityProfiles(ListSecurityProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityProfiles.</param>
        /// 
        /// <returns>Returns a  ListSecurityProfilesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        public virtual ListSecurityProfilesResponse EndListSecurityProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSecurityProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for the specified resource.
        /// 
        ///  
        /// <para>
        /// For sample policies that use tags, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security_iam_id-based-policy-examples.html">Amazon
        /// Connect Identity-Based Policy Examples</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTaskTemplates

        /// <summary>
        /// Lists task templates for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTaskTemplates service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTaskTemplates">REST API Reference for ListTaskTemplates Operation</seealso>
        public virtual ListTaskTemplatesResponse ListTaskTemplates(ListTaskTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTaskTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTaskTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskTemplates operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTaskTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTaskTemplates">REST API Reference for ListTaskTemplates Operation</seealso>
        public virtual IAsyncResult BeginListTaskTemplates(ListTaskTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTaskTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTaskTemplates.</param>
        /// 
        /// <returns>Returns a  ListTaskTemplatesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTaskTemplates">REST API Reference for ListTaskTemplates Operation</seealso>
        public virtual ListTaskTemplatesResponse EndListTaskTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTaskTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrafficDistributionGroups

        /// <summary>
        /// Lists traffic distribution groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficDistributionGroups service method.</param>
        /// 
        /// <returns>The response from the ListTrafficDistributionGroups service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTrafficDistributionGroups">REST API Reference for ListTrafficDistributionGroups Operation</seealso>
        public virtual ListTrafficDistributionGroupsResponse ListTrafficDistributionGroups(ListTrafficDistributionGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficDistributionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficDistributionGroupsResponseUnmarshaller.Instance;

            return Invoke<ListTrafficDistributionGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficDistributionGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficDistributionGroups operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrafficDistributionGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTrafficDistributionGroups">REST API Reference for ListTrafficDistributionGroups Operation</seealso>
        public virtual IAsyncResult BeginListTrafficDistributionGroups(ListTrafficDistributionGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficDistributionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficDistributionGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrafficDistributionGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrafficDistributionGroups.</param>
        /// 
        /// <returns>Returns a  ListTrafficDistributionGroupsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTrafficDistributionGroups">REST API Reference for ListTrafficDistributionGroups Operation</seealso>
        public virtual ListTrafficDistributionGroupsResponse EndListTrafficDistributionGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrafficDistributionGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUseCases

        /// <summary>
        /// Lists the use cases for the integration association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUseCases service method.</param>
        /// 
        /// <returns>The response from the ListUseCases service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUseCases">REST API Reference for ListUseCases Operation</seealso>
        public virtual ListUseCasesResponse ListUseCases(ListUseCasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUseCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUseCasesResponseUnmarshaller.Instance;

            return Invoke<ListUseCasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUseCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUseCases operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUseCases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUseCases">REST API Reference for ListUseCases Operation</seealso>
        public virtual IAsyncResult BeginListUseCases(ListUseCasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUseCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUseCasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUseCases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUseCases.</param>
        /// 
        /// <returns>Returns a  ListUseCasesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUseCases">REST API Reference for ListUseCases Operation</seealso>
        public virtual ListUseCasesResponse EndListUseCases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUseCasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserHierarchyGroups

        /// <summary>
        /// Provides summary information about the hierarchy groups for the specified Amazon Connect
        /// instance.
        /// 
        ///  
        /// <para>
        /// For more information about agent hierarchies, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/agent-hierarchy.html">Set
        /// Up Agent Hierarchies</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserHierarchyGroups service method.</param>
        /// 
        /// <returns>The response from the ListUserHierarchyGroups service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUserHierarchyGroups">REST API Reference for ListUserHierarchyGroups Operation</seealso>
        public virtual ListUserHierarchyGroupsResponse ListUserHierarchyGroups(ListUserHierarchyGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserHierarchyGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserHierarchyGroupsResponseUnmarshaller.Instance;

            return Invoke<ListUserHierarchyGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserHierarchyGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserHierarchyGroups operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserHierarchyGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUserHierarchyGroups">REST API Reference for ListUserHierarchyGroups Operation</seealso>
        public virtual IAsyncResult BeginListUserHierarchyGroups(ListUserHierarchyGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserHierarchyGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserHierarchyGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserHierarchyGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserHierarchyGroups.</param>
        /// 
        /// <returns>Returns a  ListUserHierarchyGroupsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUserHierarchyGroups">REST API Reference for ListUserHierarchyGroups Operation</seealso>
        public virtual ListUserHierarchyGroupsResponse EndListUserHierarchyGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserHierarchyGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Provides summary information about the users for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  MonitorContact

        /// <summary>
        /// Initiates silent monitoring of a contact. The Contact Control Panel (CCP) of the user
        /// specified by <i>userId</i> will be set to silent monitoring mode on the contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MonitorContact service method.</param>
        /// 
        /// <returns>The response from the MonitorContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/MonitorContact">REST API Reference for MonitorContact Operation</seealso>
        public virtual MonitorContactResponse MonitorContact(MonitorContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MonitorContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MonitorContactResponseUnmarshaller.Instance;

            return Invoke<MonitorContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MonitorContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorContact operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMonitorContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/MonitorContact">REST API Reference for MonitorContact Operation</seealso>
        public virtual IAsyncResult BeginMonitorContact(MonitorContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MonitorContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MonitorContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MonitorContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMonitorContact.</param>
        /// 
        /// <returns>Returns a  MonitorContactResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/MonitorContact">REST API Reference for MonitorContact Operation</seealso>
        public virtual MonitorContactResponse EndMonitorContact(IAsyncResult asyncResult)
        {
            return EndInvoke<MonitorContactResponse>(asyncResult);
        }

        #endregion
        
        #region  PutUserStatus

        /// <summary>
        /// Changes the current status of a user or agent in Amazon Connect. If the agent is currently
        /// handling a contact, this sets the agent's next status.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-agent-status.html">Agent
        /// status</a> and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-next-status.html">Set
        /// your next status</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserStatus service method.</param>
        /// 
        /// <returns>The response from the PutUserStatus service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/PutUserStatus">REST API Reference for PutUserStatus Operation</seealso>
        public virtual PutUserStatusResponse PutUserStatus(PutUserStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutUserStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUserStatusResponseUnmarshaller.Instance;

            return Invoke<PutUserStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutUserStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserStatus operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutUserStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/PutUserStatus">REST API Reference for PutUserStatus Operation</seealso>
        public virtual IAsyncResult BeginPutUserStatus(PutUserStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutUserStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUserStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutUserStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutUserStatus.</param>
        /// 
        /// <returns>Returns a  PutUserStatusResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/PutUserStatus">REST API Reference for PutUserStatus Operation</seealso>
        public virtual PutUserStatusResponse EndPutUserStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<PutUserStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ReleasePhoneNumber

        /// <summary>
        /// Releases a phone number previously claimed to an Amazon Connect instance or traffic
        /// distribution group. You can call this API only in the Amazon Web Services Region where
        /// the number was claimed.
        /// 
        ///  <important> 
        /// <para>
        /// To release phone numbers from a traffic distribution group, use the <code>ReleasePhoneNumber</code>
        /// API, not the Amazon Connect console.
        /// </para>
        ///  
        /// <para>
        /// After releasing a phone number, the phone number enters into a cooldown period of
        /// 30 days. It cannot be searched for or claimed again until the period has ended. If
        /// you accidentally release a phone number, contact Amazon Web Services Support.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleasePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the ReleasePhoneNumber service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ReleasePhoneNumber">REST API Reference for ReleasePhoneNumber Operation</seealso>
        public virtual ReleasePhoneNumberResponse ReleasePhoneNumber(ReleasePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleasePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleasePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<ReleasePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReleasePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleasePhoneNumber operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReleasePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ReleasePhoneNumber">REST API Reference for ReleasePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginReleasePhoneNumber(ReleasePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleasePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleasePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReleasePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleasePhoneNumber.</param>
        /// 
        /// <returns>Returns a  ReleasePhoneNumberResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ReleasePhoneNumber">REST API Reference for ReleasePhoneNumber Operation</seealso>
        public virtual ReleasePhoneNumberResponse EndReleasePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<ReleasePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  ReplicateInstance

        /// <summary>
        /// Replicates an Amazon Connect instance in the specified Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// For more information about replicating an Amazon Connect instance, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/create-replica-connect-instance.html">Create
        /// a replica of your existing Amazon Connect instance</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplicateInstance service method.</param>
        /// 
        /// <returns>The response from the ReplicateInstance service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotReadyException">
        /// The resource is not ready.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ReplicateInstance">REST API Reference for ReplicateInstance Operation</seealso>
        public virtual ReplicateInstanceResponse ReplicateInstance(ReplicateInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplicateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplicateInstanceResponseUnmarshaller.Instance;

            return Invoke<ReplicateInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplicateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplicateInstance operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplicateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ReplicateInstance">REST API Reference for ReplicateInstance Operation</seealso>
        public virtual IAsyncResult BeginReplicateInstance(ReplicateInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplicateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplicateInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReplicateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplicateInstance.</param>
        /// 
        /// <returns>Returns a  ReplicateInstanceResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ReplicateInstance">REST API Reference for ReplicateInstance Operation</seealso>
        public virtual ReplicateInstanceResponse EndReplicateInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<ReplicateInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  ResumeContactRecording

        /// <summary>
        /// When a contact is being recorded, and the recording has been suspended using SuspendContactRecording,
        /// this API resumes recording the call.
        /// 
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeContactRecording service method.</param>
        /// 
        /// <returns>The response from the ResumeContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ResumeContactRecording">REST API Reference for ResumeContactRecording Operation</seealso>
        public virtual ResumeContactRecordingResponse ResumeContactRecording(ResumeContactRecordingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeContactRecordingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeContactRecordingResponseUnmarshaller.Instance;

            return Invoke<ResumeContactRecordingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeContactRecording operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeContactRecording operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeContactRecording
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ResumeContactRecording">REST API Reference for ResumeContactRecording Operation</seealso>
        public virtual IAsyncResult BeginResumeContactRecording(ResumeContactRecordingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeContactRecordingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeContactRecordingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeContactRecording operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeContactRecording.</param>
        /// 
        /// <returns>Returns a  ResumeContactRecordingResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ResumeContactRecording">REST API Reference for ResumeContactRecording Operation</seealso>
        public virtual ResumeContactRecordingResponse EndResumeContactRecording(IAsyncResult asyncResult)
        {
            return EndInvoke<ResumeContactRecordingResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchAvailablePhoneNumbers

        /// <summary>
        /// Searches for available phone numbers that you can claim to your Amazon Connect instance
        /// or traffic distribution group. If the provided <code>TargetArn</code> is a traffic
        /// distribution group, you can call this API in both Amazon Web Services Regions associated
        /// with the traffic distribution group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers service method.</param>
        /// 
        /// <returns>The response from the SearchAvailablePhoneNumbers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        public virtual SearchAvailablePhoneNumbersResponse SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAvailablePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAvailablePhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<SearchAvailablePhoneNumbersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchAvailablePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchAvailablePhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        public virtual IAsyncResult BeginSearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAvailablePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAvailablePhoneNumbersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchAvailablePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchAvailablePhoneNumbers.</param>
        /// 
        /// <returns>Returns a  SearchAvailablePhoneNumbersResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        public virtual SearchAvailablePhoneNumbersResponse EndSearchAvailablePhoneNumbers(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchAvailablePhoneNumbersResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchQueues

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Searches queues in an Amazon Connect instance, with optional filtering.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchQueues service method.</param>
        /// 
        /// <returns>The response from the SearchQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchQueues">REST API Reference for SearchQueues Operation</seealso>
        public virtual SearchQueuesResponse SearchQueues(SearchQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchQueuesResponseUnmarshaller.Instance;

            return Invoke<SearchQueuesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchQueues operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchQueues">REST API Reference for SearchQueues Operation</seealso>
        public virtual IAsyncResult BeginSearchQueues(SearchQueuesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchQueuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchQueues.</param>
        /// 
        /// <returns>Returns a  SearchQueuesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchQueues">REST API Reference for SearchQueues Operation</seealso>
        public virtual SearchQueuesResponse EndSearchQueues(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchQueuesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchRoutingProfiles

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Searches routing profiles in an Amazon Connect instance, with optional filtering.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRoutingProfiles service method.</param>
        /// 
        /// <returns>The response from the SearchRoutingProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchRoutingProfiles">REST API Reference for SearchRoutingProfiles Operation</seealso>
        public virtual SearchRoutingProfilesResponse SearchRoutingProfiles(SearchRoutingProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRoutingProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRoutingProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchRoutingProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchRoutingProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchRoutingProfiles operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchRoutingProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchRoutingProfiles">REST API Reference for SearchRoutingProfiles Operation</seealso>
        public virtual IAsyncResult BeginSearchRoutingProfiles(SearchRoutingProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRoutingProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRoutingProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchRoutingProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchRoutingProfiles.</param>
        /// 
        /// <returns>Returns a  SearchRoutingProfilesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchRoutingProfiles">REST API Reference for SearchRoutingProfiles Operation</seealso>
        public virtual SearchRoutingProfilesResponse EndSearchRoutingProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchRoutingProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchSecurityProfiles

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Searches security profiles in an Amazon Connect instance, with optional filtering.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSecurityProfiles service method.</param>
        /// 
        /// <returns>The response from the SearchSecurityProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchSecurityProfiles">REST API Reference for SearchSecurityProfiles Operation</seealso>
        public virtual SearchSecurityProfilesResponse SearchSecurityProfiles(SearchSecurityProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchSecurityProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSecurityProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchSecurityProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSecurityProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSecurityProfiles operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSecurityProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchSecurityProfiles">REST API Reference for SearchSecurityProfiles Operation</seealso>
        public virtual IAsyncResult BeginSearchSecurityProfiles(SearchSecurityProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchSecurityProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSecurityProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSecurityProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSecurityProfiles.</param>
        /// 
        /// <returns>Returns a  SearchSecurityProfilesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchSecurityProfiles">REST API Reference for SearchSecurityProfiles Operation</seealso>
        public virtual SearchSecurityProfilesResponse EndSearchSecurityProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchSecurityProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchUsers

        /// <summary>
        /// Searches users in an Amazon Connect instance, with optional filtering.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>AfterContactWorkTimeLimit</code> is returned in milliseconds. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers service method.</param>
        /// 
        /// <returns>The response from the SearchUsers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual SearchUsersResponse SearchUsers(SearchUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return Invoke<SearchUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual IAsyncResult BeginSearchUsers(SearchUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchUsers.</param>
        /// 
        /// <returns>Returns a  SearchUsersResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual SearchUsersResponse EndSearchUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchVocabularies

        /// <summary>
        /// Searches for vocabularies within a specific Amazon Connect instance using <code>State</code>,
        /// <code>NameStartsWith</code>, and <code>LanguageCode</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchVocabularies service method.</param>
        /// 
        /// <returns>The response from the SearchVocabularies service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchVocabularies">REST API Reference for SearchVocabularies Operation</seealso>
        public virtual SearchVocabulariesResponse SearchVocabularies(SearchVocabulariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchVocabulariesResponseUnmarshaller.Instance;

            return Invoke<SearchVocabulariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchVocabularies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchVocabularies operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchVocabularies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchVocabularies">REST API Reference for SearchVocabularies Operation</seealso>
        public virtual IAsyncResult BeginSearchVocabularies(SearchVocabulariesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchVocabulariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchVocabularies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchVocabularies.</param>
        /// 
        /// <returns>Returns a  SearchVocabulariesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SearchVocabularies">REST API Reference for SearchVocabularies Operation</seealso>
        public virtual SearchVocabulariesResponse EndSearchVocabularies(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchVocabulariesResponse>(asyncResult);
        }

        #endregion
        
        #region  StartChatContact

        /// <summary>
        /// Initiates a flow to start a new chat for the customer. Response of this API provides
        /// a token required to obtain credentials from the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// API in the Amazon Connect Participant Service.
        /// 
        ///  
        /// <para>
        /// When a new chat contact is successfully created, clients must subscribe to the participant’s
        /// connection for the created chat within 5 minutes. This is achieved by invoking <a
        /// href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// with WEBSOCKET and CONNECTION_CREDENTIALS. 
        /// </para>
        ///  
        /// <para>
        /// A 429 error occurs in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// API rate limit is exceeded. API TPS throttling returns a <code>TooManyRequests</code>
        /// exception.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">quota
        /// for concurrent active chats</a> is exceeded. Active chat throttling returns a <code>LimitExceededException</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you use the <code>ChatDurationInMinutes</code> parameter and receive a 400 error,
        /// your account may not support the ability to configure custom chat durations. For more
        /// information, contact Amazon Web Services Support. 
        /// </para>
        ///  
        /// <para>
        /// For more information about chat, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat.html">Chat</a>
        /// in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChatContact service method.</param>
        /// 
        /// <returns>The response from the StartChatContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartChatContact">REST API Reference for StartChatContact Operation</seealso>
        public virtual StartChatContactResponse StartChatContact(StartChatContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChatContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChatContactResponseUnmarshaller.Instance;

            return Invoke<StartChatContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartChatContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartChatContact operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartChatContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartChatContact">REST API Reference for StartChatContact Operation</seealso>
        public virtual IAsyncResult BeginStartChatContact(StartChatContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChatContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChatContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartChatContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartChatContact.</param>
        /// 
        /// <returns>Returns a  StartChatContactResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartChatContact">REST API Reference for StartChatContact Operation</seealso>
        public virtual StartChatContactResponse EndStartChatContact(IAsyncResult asyncResult)
        {
            return EndInvoke<StartChatContactResponse>(asyncResult);
        }

        #endregion
        
        #region  StartContactRecording

        /// <summary>
        /// Starts recording the contact: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If the API is called <i>before</i> the agent joins the call, recording starts when
        /// the agent joins the call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the API is called <i>after</i> the agent joins the call, recording starts at the
        /// time of the API call.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// StartContactRecording is a one-time action. For example, if you use StopContactRecording
        /// to stop recording an ongoing call, you can't use StartContactRecording to restart
        /// it. For scenarios where the recording has started and you want to suspend and resume
        /// it, such as when collecting sensitive information (for example, a credit card number),
        /// use SuspendContactRecording and ResumeContactRecording.
        /// </para>
        ///  
        /// <para>
        /// You can use this API to override the recording behavior configured in the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-recording-behavior.html">Set
        /// recording behavior</a> block.
        /// </para>
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContactRecording service method.</param>
        /// 
        /// <returns>The response from the StartContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactRecording">REST API Reference for StartContactRecording Operation</seealso>
        public virtual StartContactRecordingResponse StartContactRecording(StartContactRecordingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartContactRecordingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContactRecordingResponseUnmarshaller.Instance;

            return Invoke<StartContactRecordingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartContactRecording operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartContactRecording operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartContactRecording
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactRecording">REST API Reference for StartContactRecording Operation</seealso>
        public virtual IAsyncResult BeginStartContactRecording(StartContactRecordingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartContactRecordingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContactRecordingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartContactRecording operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartContactRecording.</param>
        /// 
        /// <returns>Returns a  StartContactRecordingResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactRecording">REST API Reference for StartContactRecording Operation</seealso>
        public virtual StartContactRecordingResponse EndStartContactRecording(IAsyncResult asyncResult)
        {
            return EndInvoke<StartContactRecordingResponse>(asyncResult);
        }

        #endregion
        
        #region  StartContactStreaming

        /// <summary>
        /// Initiates real-time message streaming for a new chat contact.
        /// 
        ///  
        /// <para>
        ///  For more information about message streaming, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-message-streaming.html">Enable
        /// real-time chat message streaming</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContactStreaming service method.</param>
        /// 
        /// <returns>The response from the StartContactStreaming service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactStreaming">REST API Reference for StartContactStreaming Operation</seealso>
        public virtual StartContactStreamingResponse StartContactStreaming(StartContactStreamingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartContactStreamingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContactStreamingResponseUnmarshaller.Instance;

            return Invoke<StartContactStreamingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartContactStreaming operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartContactStreaming operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartContactStreaming
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactStreaming">REST API Reference for StartContactStreaming Operation</seealso>
        public virtual IAsyncResult BeginStartContactStreaming(StartContactStreamingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartContactStreamingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContactStreamingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartContactStreaming operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartContactStreaming.</param>
        /// 
        /// <returns>Returns a  StartContactStreamingResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactStreaming">REST API Reference for StartContactStreaming Operation</seealso>
        public virtual StartContactStreamingResponse EndStartContactStreaming(IAsyncResult asyncResult)
        {
            return EndInvoke<StartContactStreamingResponse>(asyncResult);
        }

        #endregion
        
        #region  StartOutboundVoiceContact

        /// <summary>
        /// Places an outbound call to a contact, and then initiates the flow. It performs the
        /// actions in the flow that's specified (in <code>ContactFlowId</code>).
        /// 
        ///  
        /// <para>
        /// Agents do not initiate the outbound API, which means that they do not dial the contact.
        /// If the flow places an outbound call to a contact, and then puts the contact in queue,
        /// the call is then routed to the agent, like any other inbound case.
        /// </para>
        ///  
        /// <para>
        /// There is a 60-second dialing timeout for this operation. If the call is not connected
        /// after 60 seconds, it fails.
        /// </para>
        ///  <note> 
        /// <para>
        /// UK numbers with a 447 prefix are not allowed by default. Before you can dial these
        /// UK mobile numbers, you must submit a service quota increase request. For more information,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>. 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Campaign calls are not allowed by default. Before you can make a call with <code>TrafficType</code>
        /// = <code>CAMPAIGN</code>, you must submit a service quota increase request to the quota
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#outbound-communications-quotas">Amazon
        /// Connect campaigns</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOutboundVoiceContact service method.</param>
        /// 
        /// <returns>The response from the StartOutboundVoiceContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DestinationNotAllowedException">
        /// Outbound calls to the destination number are not allowed.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.OutboundContactNotPermittedException">
        /// The contact is not permitted.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartOutboundVoiceContact">REST API Reference for StartOutboundVoiceContact Operation</seealso>
        public virtual StartOutboundVoiceContactResponse StartOutboundVoiceContact(StartOutboundVoiceContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOutboundVoiceContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOutboundVoiceContactResponseUnmarshaller.Instance;

            return Invoke<StartOutboundVoiceContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartOutboundVoiceContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartOutboundVoiceContact operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartOutboundVoiceContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartOutboundVoiceContact">REST API Reference for StartOutboundVoiceContact Operation</seealso>
        public virtual IAsyncResult BeginStartOutboundVoiceContact(StartOutboundVoiceContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOutboundVoiceContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOutboundVoiceContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartOutboundVoiceContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartOutboundVoiceContact.</param>
        /// 
        /// <returns>Returns a  StartOutboundVoiceContactResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartOutboundVoiceContact">REST API Reference for StartOutboundVoiceContact Operation</seealso>
        public virtual StartOutboundVoiceContactResponse EndStartOutboundVoiceContact(IAsyncResult asyncResult)
        {
            return EndInvoke<StartOutboundVoiceContactResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTaskContact

        /// <summary>
        /// Initiates a flow to start a new task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTaskContact service method.</param>
        /// 
        /// <returns>The response from the StartTaskContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartTaskContact">REST API Reference for StartTaskContact Operation</seealso>
        public virtual StartTaskContactResponse StartTaskContact(StartTaskContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTaskContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskContactResponseUnmarshaller.Instance;

            return Invoke<StartTaskContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTaskContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTaskContact operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTaskContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartTaskContact">REST API Reference for StartTaskContact Operation</seealso>
        public virtual IAsyncResult BeginStartTaskContact(StartTaskContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTaskContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTaskContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTaskContact.</param>
        /// 
        /// <returns>Returns a  StartTaskContactResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartTaskContact">REST API Reference for StartTaskContact Operation</seealso>
        public virtual StartTaskContactResponse EndStartTaskContact(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTaskContactResponse>(asyncResult);
        }

        #endregion
        
        #region  StopContact

        /// <summary>
        /// Ends the specified contact. This call does not work for the following initiation methods:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DISCONNECT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TRANSFER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// QUEUE_TRANSFER
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContact service method.</param>
        /// 
        /// <returns>The response from the StopContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.ContactNotFoundException">
        /// The contact with the specified ID is not active or does not exist. Applies to Voice
        /// calls only, not to Chat, Task, or Voice Callback.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContact">REST API Reference for StopContact Operation</seealso>
        public virtual StopContactResponse StopContact(StopContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopContactResponseUnmarshaller.Instance;

            return Invoke<StopContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopContact operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContact">REST API Reference for StopContact Operation</seealso>
        public virtual IAsyncResult BeginStopContact(StopContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopContact.</param>
        /// 
        /// <returns>Returns a  StopContactResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContact">REST API Reference for StopContact Operation</seealso>
        public virtual StopContactResponse EndStopContact(IAsyncResult asyncResult)
        {
            return EndInvoke<StopContactResponse>(asyncResult);
        }

        #endregion
        
        #region  StopContactRecording

        /// <summary>
        /// Stops recording a call when a contact is being recorded. StopContactRecording is a
        /// one-time action. If you use StopContactRecording to stop recording an ongoing call,
        /// you can't use StartContactRecording to restart it. For scenarios where the recording
        /// has started and you want to suspend it for sensitive information (for example, to
        /// collect a credit card number), and then restart it, use SuspendContactRecording and
        /// ResumeContactRecording.
        /// 
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContactRecording service method.</param>
        /// 
        /// <returns>The response from the StopContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContactRecording">REST API Reference for StopContactRecording Operation</seealso>
        public virtual StopContactRecordingResponse StopContactRecording(StopContactRecordingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopContactRecordingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopContactRecordingResponseUnmarshaller.Instance;

            return Invoke<StopContactRecordingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopContactRecording operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopContactRecording operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopContactRecording
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContactRecording">REST API Reference for StopContactRecording Operation</seealso>
        public virtual IAsyncResult BeginStopContactRecording(StopContactRecordingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopContactRecordingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopContactRecordingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopContactRecording operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopContactRecording.</param>
        /// 
        /// <returns>Returns a  StopContactRecordingResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContactRecording">REST API Reference for StopContactRecording Operation</seealso>
        public virtual StopContactRecordingResponse EndStopContactRecording(IAsyncResult asyncResult)
        {
            return EndInvoke<StopContactRecordingResponse>(asyncResult);
        }

        #endregion
        
        #region  StopContactStreaming

        /// <summary>
        /// Ends message streaming on a specified contact. To restart message streaming on that
        /// contact, call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartContactStreaming.html">StartContactStreaming</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContactStreaming service method.</param>
        /// 
        /// <returns>The response from the StopContactStreaming service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContactStreaming">REST API Reference for StopContactStreaming Operation</seealso>
        public virtual StopContactStreamingResponse StopContactStreaming(StopContactStreamingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopContactStreamingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopContactStreamingResponseUnmarshaller.Instance;

            return Invoke<StopContactStreamingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopContactStreaming operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopContactStreaming operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopContactStreaming
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContactStreaming">REST API Reference for StopContactStreaming Operation</seealso>
        public virtual IAsyncResult BeginStopContactStreaming(StopContactStreamingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopContactStreamingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopContactStreamingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopContactStreaming operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopContactStreaming.</param>
        /// 
        /// <returns>Returns a  StopContactStreamingResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContactStreaming">REST API Reference for StopContactStreaming Operation</seealso>
        public virtual StopContactStreamingResponse EndStopContactStreaming(IAsyncResult asyncResult)
        {
            return EndInvoke<StopContactStreamingResponse>(asyncResult);
        }

        #endregion
        
        #region  SuspendContactRecording

        /// <summary>
        /// When a contact is being recorded, this API suspends recording the call. For example,
        /// you might suspend the call recording while collecting sensitive information, such
        /// as a credit card number. Then use ResumeContactRecording to restart recording. 
        /// 
        ///  
        /// <para>
        /// The period of time that the recording is suspended is filled with silence in the final
        /// recording. 
        /// </para>
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendContactRecording service method.</param>
        /// 
        /// <returns>The response from the SuspendContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SuspendContactRecording">REST API Reference for SuspendContactRecording Operation</seealso>
        public virtual SuspendContactRecordingResponse SuspendContactRecording(SuspendContactRecordingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendContactRecordingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendContactRecordingResponseUnmarshaller.Instance;

            return Invoke<SuspendContactRecordingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SuspendContactRecording operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SuspendContactRecording operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSuspendContactRecording
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SuspendContactRecording">REST API Reference for SuspendContactRecording Operation</seealso>
        public virtual IAsyncResult BeginSuspendContactRecording(SuspendContactRecordingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendContactRecordingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendContactRecordingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SuspendContactRecording operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuspendContactRecording.</param>
        /// 
        /// <returns>Returns a  SuspendContactRecordingResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SuspendContactRecording">REST API Reference for SuspendContactRecording Operation</seealso>
        public virtual SuspendContactRecordingResponse EndSuspendContactRecording(IAsyncResult asyncResult)
        {
            return EndInvoke<SuspendContactRecordingResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// 
        ///  
        /// <para>
        /// Some of the supported resource types are agents, routing profiles, queues, quick connects,
        /// contact flows, agent statuses, hours of operation, phone numbers, security profiles,
        /// and task templates. For a complete list, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/tagging.html">Tagging
        /// resources in Amazon Connect</a>.
        /// </para>
        ///  
        /// <para>
        /// For sample policies that use tags, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security_iam_id-based-policy-examples.html">Amazon
        /// Connect Identity-Based Policy Examples</a> in the <i>Amazon Connect Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TransferContact

        /// <summary>
        /// Transfers contacts from one agent or queue to another agent or queue at any point
        /// after a contact is created. You can transfer a contact to another queue by providing
        /// the flow which orchestrates the contact to the destination queue. This gives you more
        /// control over contact handling and helps you adhere to the service level agreement
        /// (SLA) guaranteed to your customers.
        /// 
        ///  
        /// <para>
        /// Note the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Transfer is supported for only <code>TASK</code> contacts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use both <code>QueueId</code> and <code>UserId</code> in the same call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The following flow types are supported: Inbound flow, Transfer to agent flow, and
        /// Transfer to queue flow.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>TransferContact</code> API can be called only on active contacts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A contact cannot be transferred more than 11 times.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferContact service method.</param>
        /// 
        /// <returns>The response from the TransferContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/TransferContact">REST API Reference for TransferContact Operation</seealso>
        public virtual TransferContactResponse TransferContact(TransferContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferContactResponseUnmarshaller.Instance;

            return Invoke<TransferContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TransferContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferContact operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTransferContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/TransferContact">REST API Reference for TransferContact Operation</seealso>
        public virtual IAsyncResult BeginTransferContact(TransferContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TransferContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTransferContact.</param>
        /// 
        /// <returns>Returns a  TransferContactResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/TransferContact">REST API Reference for TransferContact Operation</seealso>
        public virtual TransferContactResponse EndTransferContact(IAsyncResult asyncResult)
        {
            return EndInvoke<TransferContactResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAgentStatus

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates agent status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentStatus service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        public virtual UpdateAgentStatusResponse UpdateAgentStatus(UpdateAgentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentStatus operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateAgentStatus(UpdateAgentStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAgentStatusResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        public virtual UpdateAgentStatusResponse EndUpdateAgentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAgentStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContact

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Adds or updates user-defined contact information associated with the specified contact.
        /// At least one field to be updated must be present in the request.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can add or update user-defined contact information for both ongoing and completed
        /// contacts.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// 
        /// <returns>The response from the UpdateContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        public virtual UpdateContactResponse UpdateContact(UpdateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactResponseUnmarshaller.Instance;

            return Invoke<UpdateContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        public virtual IAsyncResult BeginUpdateContact(UpdateContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContact.</param>
        /// 
        /// <returns>Returns a  UpdateContactResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        public virtual UpdateContactResponse EndUpdateContact(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContactResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContactAttributes

        /// <summary>
        /// Creates or updates user-defined contact attributes associated with the specified contact.
        /// 
        ///  
        /// <para>
        /// You can create or update user-defined attributes for both ongoing and completed contacts.
        /// For example, while the call is active, you can update the customer's name or the reason
        /// the customer called. You can add notes about steps that the agent took during the
        /// call that display to the next agent that takes the call. You can also update attributes
        /// for a contact using data from your CRM application and save the data with the contact
        /// in Amazon Connect. You could also flag calls for additional analysis, such as legal
        /// review or to identify abusive callers.
        /// </para>
        ///  
        /// <para>
        /// Contact attributes are available in Amazon Connect for 24 months, and are then deleted.
        /// For information about contact record retention and the maximum size of the contact
        /// record attributes section, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#feature-limits">Feature
        /// specifications</a> in the <i>Amazon Connect Administrator Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateContactAttributes service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactAttributes">REST API Reference for UpdateContactAttributes Operation</seealso>
        public virtual UpdateContactAttributesResponse UpdateContactAttributes(UpdateContactAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateContactAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContactAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactAttributes operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContactAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactAttributes">REST API Reference for UpdateContactAttributes Operation</seealso>
        public virtual IAsyncResult BeginUpdateContactAttributes(UpdateContactAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContactAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContactAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateContactAttributesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactAttributes">REST API Reference for UpdateContactAttributes Operation</seealso>
        public virtual UpdateContactAttributesResponse EndUpdateContactAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContactAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContactFlowContent

        /// <summary>
        /// Updates the specified flow.
        /// 
        ///  
        /// <para>
        /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
        /// Connect Flow language</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowContent service method.</param>
        /// 
        /// <returns>The response from the UpdateContactFlowContent service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidContactFlowException">
        /// The flow is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowContent">REST API Reference for UpdateContactFlowContent Operation</seealso>
        public virtual UpdateContactFlowContentResponse UpdateContactFlowContent(UpdateContactFlowContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactFlowContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactFlowContentResponseUnmarshaller.Instance;

            return Invoke<UpdateContactFlowContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContactFlowContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowContent operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContactFlowContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowContent">REST API Reference for UpdateContactFlowContent Operation</seealso>
        public virtual IAsyncResult BeginUpdateContactFlowContent(UpdateContactFlowContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactFlowContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactFlowContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContactFlowContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContactFlowContent.</param>
        /// 
        /// <returns>Returns a  UpdateContactFlowContentResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowContent">REST API Reference for UpdateContactFlowContent Operation</seealso>
        public virtual UpdateContactFlowContentResponse EndUpdateContactFlowContent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContactFlowContentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContactFlowMetadata

        /// <summary>
        /// Updates metadata about specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateContactFlowMetadata service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowMetadata">REST API Reference for UpdateContactFlowMetadata Operation</seealso>
        public virtual UpdateContactFlowMetadataResponse UpdateContactFlowMetadata(UpdateContactFlowMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactFlowMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactFlowMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateContactFlowMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContactFlowMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowMetadata operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContactFlowMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowMetadata">REST API Reference for UpdateContactFlowMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateContactFlowMetadata(UpdateContactFlowMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactFlowMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactFlowMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContactFlowMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContactFlowMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateContactFlowMetadataResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowMetadata">REST API Reference for UpdateContactFlowMetadata Operation</seealso>
        public virtual UpdateContactFlowMetadataResponse EndUpdateContactFlowMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContactFlowMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContactFlowModuleContent

        /// <summary>
        /// Updates specified flow module for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowModuleContent service method.</param>
        /// 
        /// <returns>The response from the UpdateContactFlowModuleContent service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidContactFlowModuleException">
        /// The problems with the module. Please fix before trying again.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowModuleContent">REST API Reference for UpdateContactFlowModuleContent Operation</seealso>
        public virtual UpdateContactFlowModuleContentResponse UpdateContactFlowModuleContent(UpdateContactFlowModuleContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactFlowModuleContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactFlowModuleContentResponseUnmarshaller.Instance;

            return Invoke<UpdateContactFlowModuleContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContactFlowModuleContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowModuleContent operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContactFlowModuleContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowModuleContent">REST API Reference for UpdateContactFlowModuleContent Operation</seealso>
        public virtual IAsyncResult BeginUpdateContactFlowModuleContent(UpdateContactFlowModuleContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactFlowModuleContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactFlowModuleContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContactFlowModuleContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContactFlowModuleContent.</param>
        /// 
        /// <returns>Returns a  UpdateContactFlowModuleContentResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowModuleContent">REST API Reference for UpdateContactFlowModuleContent Operation</seealso>
        public virtual UpdateContactFlowModuleContentResponse EndUpdateContactFlowModuleContent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContactFlowModuleContentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContactFlowModuleMetadata

        /// <summary>
        /// Updates metadata about specified flow module.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowModuleMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateContactFlowModuleMetadata service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowModuleMetadata">REST API Reference for UpdateContactFlowModuleMetadata Operation</seealso>
        public virtual UpdateContactFlowModuleMetadataResponse UpdateContactFlowModuleMetadata(UpdateContactFlowModuleMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactFlowModuleMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactFlowModuleMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateContactFlowModuleMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContactFlowModuleMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowModuleMetadata operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContactFlowModuleMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowModuleMetadata">REST API Reference for UpdateContactFlowModuleMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateContactFlowModuleMetadata(UpdateContactFlowModuleMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactFlowModuleMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactFlowModuleMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContactFlowModuleMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContactFlowModuleMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateContactFlowModuleMetadataResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowModuleMetadata">REST API Reference for UpdateContactFlowModuleMetadata Operation</seealso>
        public virtual UpdateContactFlowModuleMetadataResponse EndUpdateContactFlowModuleMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContactFlowModuleMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContactFlowName

        /// <summary>
        /// The name of the flow.
        /// 
        ///  
        /// <para>
        /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
        /// Connect Flow language</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowName service method.</param>
        /// 
        /// <returns>The response from the UpdateContactFlowName service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowName">REST API Reference for UpdateContactFlowName Operation</seealso>
        public virtual UpdateContactFlowNameResponse UpdateContactFlowName(UpdateContactFlowNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactFlowNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactFlowNameResponseUnmarshaller.Instance;

            return Invoke<UpdateContactFlowNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContactFlowName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactFlowName operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContactFlowName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowName">REST API Reference for UpdateContactFlowName Operation</seealso>
        public virtual IAsyncResult BeginUpdateContactFlowName(UpdateContactFlowNameRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactFlowNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactFlowNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContactFlowName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContactFlowName.</param>
        /// 
        /// <returns>Returns a  UpdateContactFlowNameResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactFlowName">REST API Reference for UpdateContactFlowName Operation</seealso>
        public virtual UpdateContactFlowNameResponse EndUpdateContactFlowName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContactFlowNameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContactSchedule

        /// <summary>
        /// Updates the scheduled time of a task contact that is already scheduled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateContactSchedule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactSchedule">REST API Reference for UpdateContactSchedule Operation</seealso>
        public virtual UpdateContactScheduleResponse UpdateContactSchedule(UpdateContactScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateContactScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContactSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactSchedule operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContactSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactSchedule">REST API Reference for UpdateContactSchedule Operation</seealso>
        public virtual IAsyncResult BeginUpdateContactSchedule(UpdateContactScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContactSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContactSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateContactScheduleResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactSchedule">REST API Reference for UpdateContactSchedule Operation</seealso>
        public virtual UpdateContactScheduleResponse EndUpdateContactSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContactScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateHoursOfOperation

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the hours of operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHoursOfOperation service method.</param>
        /// 
        /// <returns>The response from the UpdateHoursOfOperation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateHoursOfOperation">REST API Reference for UpdateHoursOfOperation Operation</seealso>
        public virtual UpdateHoursOfOperationResponse UpdateHoursOfOperation(UpdateHoursOfOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHoursOfOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHoursOfOperationResponseUnmarshaller.Instance;

            return Invoke<UpdateHoursOfOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHoursOfOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHoursOfOperation operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHoursOfOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateHoursOfOperation">REST API Reference for UpdateHoursOfOperation Operation</seealso>
        public virtual IAsyncResult BeginUpdateHoursOfOperation(UpdateHoursOfOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHoursOfOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHoursOfOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHoursOfOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHoursOfOperation.</param>
        /// 
        /// <returns>Returns a  UpdateHoursOfOperationResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateHoursOfOperation">REST API Reference for UpdateHoursOfOperation Operation</seealso>
        public virtual UpdateHoursOfOperationResponse EndUpdateHoursOfOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateHoursOfOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInstanceAttribute

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the value for the specified attribute type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceAttribute service method.</param>
        /// 
        /// <returns>The response from the UpdateInstanceAttribute service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateInstanceAttribute">REST API Reference for UpdateInstanceAttribute Operation</seealso>
        public virtual UpdateInstanceAttributeResponse UpdateInstanceAttribute(UpdateInstanceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceAttributeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceAttribute operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstanceAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateInstanceAttribute">REST API Reference for UpdateInstanceAttribute Operation</seealso>
        public virtual IAsyncResult BeginUpdateInstanceAttribute(UpdateInstanceAttributeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceAttributeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceAttributeResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateInstanceAttribute">REST API Reference for UpdateInstanceAttribute Operation</seealso>
        public virtual UpdateInstanceAttributeResponse EndUpdateInstanceAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInstanceAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInstanceStorageConfig

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates an existing configuration for a resource type. This API is idempotent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceStorageConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateInstanceStorageConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateInstanceStorageConfig">REST API Reference for UpdateInstanceStorageConfig Operation</seealso>
        public virtual UpdateInstanceStorageConfigResponse UpdateInstanceStorageConfig(UpdateInstanceStorageConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceStorageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceStorageConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceStorageConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstanceStorageConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceStorageConfig operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstanceStorageConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateInstanceStorageConfig">REST API Reference for UpdateInstanceStorageConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateInstanceStorageConfig(UpdateInstanceStorageConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceStorageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceStorageConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstanceStorageConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstanceStorageConfig.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceStorageConfigResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateInstanceStorageConfig">REST API Reference for UpdateInstanceStorageConfig Operation</seealso>
        public virtual UpdateInstanceStorageConfigResponse EndUpdateInstanceStorageConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInstanceStorageConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateParticipantRoleConfig

        /// <summary>
        /// Updates timeouts for when human chat participants are to be considered idle, and when
        /// agents are automatically disconnected from a chat due to idleness. You can set four
        /// timers:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Customer idle timeout
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customer auto-disconnect timeout
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Agent idle timeout
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Agent auto-disconnect timeout
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how chat timeouts work, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-chat-timeouts.html">Set
        /// up chat timeouts for human participants</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateParticipantRoleConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateParticipantRoleConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateParticipantRoleConfig">REST API Reference for UpdateParticipantRoleConfig Operation</seealso>
        public virtual UpdateParticipantRoleConfigResponse UpdateParticipantRoleConfig(UpdateParticipantRoleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateParticipantRoleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParticipantRoleConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateParticipantRoleConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateParticipantRoleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateParticipantRoleConfig operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateParticipantRoleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateParticipantRoleConfig">REST API Reference for UpdateParticipantRoleConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateParticipantRoleConfig(UpdateParticipantRoleConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateParticipantRoleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParticipantRoleConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateParticipantRoleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateParticipantRoleConfig.</param>
        /// 
        /// <returns>Returns a  UpdateParticipantRoleConfigResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateParticipantRoleConfig">REST API Reference for UpdateParticipantRoleConfig Operation</seealso>
        public virtual UpdateParticipantRoleConfigResponse EndUpdateParticipantRoleConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateParticipantRoleConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePhoneNumber

        /// <summary>
        /// Updates your claimed phone number from its current Amazon Connect instance or traffic
        /// distribution group to another Amazon Connect instance or traffic distribution group
        /// in the same Amazon Web Services Region.
        /// 
        ///  <important> 
        /// <para>
        /// You can call <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribePhoneNumber.html">DescribePhoneNumber</a>
        /// API to verify the status of a previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdatePhoneNumber.html">UpdatePhoneNumber</a>
        /// operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual UpdatePhoneNumberResponse UpdatePhoneNumber(UpdatePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<UpdatePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginUpdatePhoneNumber(UpdatePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePhoneNumber.</param>
        /// 
        /// <returns>Returns a  UpdatePhoneNumberResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual UpdatePhoneNumberResponse EndUpdatePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQueueHoursOfOperation

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the hours of operation for the specified queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueHoursOfOperation service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueHoursOfOperation service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueHoursOfOperation">REST API Reference for UpdateQueueHoursOfOperation Operation</seealso>
        public virtual UpdateQueueHoursOfOperationResponse UpdateQueueHoursOfOperation(UpdateQueueHoursOfOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueHoursOfOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueHoursOfOperationResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueHoursOfOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQueueHoursOfOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueHoursOfOperation operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueueHoursOfOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueHoursOfOperation">REST API Reference for UpdateQueueHoursOfOperation Operation</seealso>
        public virtual IAsyncResult BeginUpdateQueueHoursOfOperation(UpdateQueueHoursOfOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueHoursOfOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueHoursOfOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueueHoursOfOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueueHoursOfOperation.</param>
        /// 
        /// <returns>Returns a  UpdateQueueHoursOfOperationResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueHoursOfOperation">REST API Reference for UpdateQueueHoursOfOperation Operation</seealso>
        public virtual UpdateQueueHoursOfOperationResponse EndUpdateQueueHoursOfOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueueHoursOfOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQueueMaxContacts

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the maximum number of contacts allowed in a queue before it is considered
        /// full.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueMaxContacts service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueMaxContacts service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueMaxContacts">REST API Reference for UpdateQueueMaxContacts Operation</seealso>
        public virtual UpdateQueueMaxContactsResponse UpdateQueueMaxContacts(UpdateQueueMaxContactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueMaxContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueMaxContactsResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueMaxContactsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQueueMaxContacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueMaxContacts operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueueMaxContacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueMaxContacts">REST API Reference for UpdateQueueMaxContacts Operation</seealso>
        public virtual IAsyncResult BeginUpdateQueueMaxContacts(UpdateQueueMaxContactsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueMaxContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueMaxContactsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueueMaxContacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueueMaxContacts.</param>
        /// 
        /// <returns>Returns a  UpdateQueueMaxContactsResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueMaxContacts">REST API Reference for UpdateQueueMaxContacts Operation</seealso>
        public virtual UpdateQueueMaxContactsResponse EndUpdateQueueMaxContacts(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueueMaxContactsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQueueName

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the name and description of a queue. At least <code>Name</code> or <code>Description</code>
        /// must be provided.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueName service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueName service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueName">REST API Reference for UpdateQueueName Operation</seealso>
        public virtual UpdateQueueNameResponse UpdateQueueName(UpdateQueueNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueNameResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQueueName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueName operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueueName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueName">REST API Reference for UpdateQueueName Operation</seealso>
        public virtual IAsyncResult BeginUpdateQueueName(UpdateQueueNameRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueueName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueueName.</param>
        /// 
        /// <returns>Returns a  UpdateQueueNameResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueName">REST API Reference for UpdateQueueName Operation</seealso>
        public virtual UpdateQueueNameResponse EndUpdateQueueName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueueNameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQueueOutboundCallerConfig

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the outbound caller ID name, number, and outbound whisper flow for a specified
        /// queue.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the number being used in the input is claimed to a traffic distribution group,
        /// and you are calling this API using an instance in the Amazon Web Services Region where
        /// the traffic distribution group was created, you can use either a full phone number
        /// ARN or UUID value for the <code>OutboundCallerIdNumberId</code> value of the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_OutboundCallerConfig">OutboundCallerConfig</a>
        /// request body parameter. However, if the number is claimed to a traffic distribution
        /// group and you are calling this API using an instance in the alternate Amazon Web Services
        /// Region associated with the traffic distribution group, you must provide a full phone
        /// number ARN. If a UUID is provided in this scenario, you will receive a <code>ResourceNotFoundException</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueOutboundCallerConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueOutboundCallerConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueOutboundCallerConfig">REST API Reference for UpdateQueueOutboundCallerConfig Operation</seealso>
        public virtual UpdateQueueOutboundCallerConfigResponse UpdateQueueOutboundCallerConfig(UpdateQueueOutboundCallerConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueOutboundCallerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueOutboundCallerConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueOutboundCallerConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQueueOutboundCallerConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueOutboundCallerConfig operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueueOutboundCallerConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueOutboundCallerConfig">REST API Reference for UpdateQueueOutboundCallerConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateQueueOutboundCallerConfig(UpdateQueueOutboundCallerConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueOutboundCallerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueOutboundCallerConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueueOutboundCallerConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueueOutboundCallerConfig.</param>
        /// 
        /// <returns>Returns a  UpdateQueueOutboundCallerConfigResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueOutboundCallerConfig">REST API Reference for UpdateQueueOutboundCallerConfig Operation</seealso>
        public virtual UpdateQueueOutboundCallerConfigResponse EndUpdateQueueOutboundCallerConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueueOutboundCallerConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQueueStatus

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the status of the queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueStatus service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueStatus">REST API Reference for UpdateQueueStatus Operation</seealso>
        public virtual UpdateQueueStatusResponse UpdateQueueStatus(UpdateQueueStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQueueStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueStatus operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueueStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueStatus">REST API Reference for UpdateQueueStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateQueueStatus(UpdateQueueStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueueStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueueStatus.</param>
        /// 
        /// <returns>Returns a  UpdateQueueStatusResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQueueStatus">REST API Reference for UpdateQueueStatus Operation</seealso>
        public virtual UpdateQueueStatusResponse EndUpdateQueueStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueueStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQuickConnectConfig

        /// <summary>
        /// Updates the configuration settings for the specified quick connect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickConnectConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateQuickConnectConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQuickConnectConfig">REST API Reference for UpdateQuickConnectConfig Operation</seealso>
        public virtual UpdateQuickConnectConfigResponse UpdateQuickConnectConfig(UpdateQuickConnectConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuickConnectConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickConnectConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateQuickConnectConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQuickConnectConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickConnectConfig operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQuickConnectConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQuickConnectConfig">REST API Reference for UpdateQuickConnectConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateQuickConnectConfig(UpdateQuickConnectConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuickConnectConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickConnectConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQuickConnectConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQuickConnectConfig.</param>
        /// 
        /// <returns>Returns a  UpdateQuickConnectConfigResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQuickConnectConfig">REST API Reference for UpdateQuickConnectConfig Operation</seealso>
        public virtual UpdateQuickConnectConfigResponse EndUpdateQuickConnectConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQuickConnectConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQuickConnectName

        /// <summary>
        /// Updates the name and description of a quick connect. The request accepts the following
        /// data in JSON format. At least <code>Name</code> or <code>Description</code> must be
        /// provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickConnectName service method.</param>
        /// 
        /// <returns>The response from the UpdateQuickConnectName service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQuickConnectName">REST API Reference for UpdateQuickConnectName Operation</seealso>
        public virtual UpdateQuickConnectNameResponse UpdateQuickConnectName(UpdateQuickConnectNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuickConnectNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickConnectNameResponseUnmarshaller.Instance;

            return Invoke<UpdateQuickConnectNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQuickConnectName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickConnectName operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQuickConnectName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQuickConnectName">REST API Reference for UpdateQuickConnectName Operation</seealso>
        public virtual IAsyncResult BeginUpdateQuickConnectName(UpdateQuickConnectNameRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuickConnectNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickConnectNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQuickConnectName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQuickConnectName.</param>
        /// 
        /// <returns>Returns a  UpdateQuickConnectNameResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateQuickConnectName">REST API Reference for UpdateQuickConnectName Operation</seealso>
        public virtual UpdateQuickConnectNameResponse EndUpdateQuickConnectName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQuickConnectNameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoutingProfileConcurrency

        /// <summary>
        /// Updates the channels that agents can handle in the Contact Control Panel (CCP) for
        /// a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileConcurrency service method.</param>
        /// 
        /// <returns>The response from the UpdateRoutingProfileConcurrency service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileConcurrency">REST API Reference for UpdateRoutingProfileConcurrency Operation</seealso>
        public virtual UpdateRoutingProfileConcurrencyResponse UpdateRoutingProfileConcurrency(UpdateRoutingProfileConcurrencyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingProfileConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingProfileConcurrencyResponseUnmarshaller.Instance;

            return Invoke<UpdateRoutingProfileConcurrencyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoutingProfileConcurrency operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileConcurrency operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoutingProfileConcurrency
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileConcurrency">REST API Reference for UpdateRoutingProfileConcurrency Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoutingProfileConcurrency(UpdateRoutingProfileConcurrencyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingProfileConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingProfileConcurrencyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoutingProfileConcurrency operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoutingProfileConcurrency.</param>
        /// 
        /// <returns>Returns a  UpdateRoutingProfileConcurrencyResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileConcurrency">REST API Reference for UpdateRoutingProfileConcurrency Operation</seealso>
        public virtual UpdateRoutingProfileConcurrencyResponse EndUpdateRoutingProfileConcurrency(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRoutingProfileConcurrencyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoutingProfileDefaultOutboundQueue

        /// <summary>
        /// Updates the default outbound queue of a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileDefaultOutboundQueue service method.</param>
        /// 
        /// <returns>The response from the UpdateRoutingProfileDefaultOutboundQueue service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileDefaultOutboundQueue">REST API Reference for UpdateRoutingProfileDefaultOutboundQueue Operation</seealso>
        public virtual UpdateRoutingProfileDefaultOutboundQueueResponse UpdateRoutingProfileDefaultOutboundQueue(UpdateRoutingProfileDefaultOutboundQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingProfileDefaultOutboundQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingProfileDefaultOutboundQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateRoutingProfileDefaultOutboundQueueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoutingProfileDefaultOutboundQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileDefaultOutboundQueue operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoutingProfileDefaultOutboundQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileDefaultOutboundQueue">REST API Reference for UpdateRoutingProfileDefaultOutboundQueue Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoutingProfileDefaultOutboundQueue(UpdateRoutingProfileDefaultOutboundQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingProfileDefaultOutboundQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingProfileDefaultOutboundQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoutingProfileDefaultOutboundQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoutingProfileDefaultOutboundQueue.</param>
        /// 
        /// <returns>Returns a  UpdateRoutingProfileDefaultOutboundQueueResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileDefaultOutboundQueue">REST API Reference for UpdateRoutingProfileDefaultOutboundQueue Operation</seealso>
        public virtual UpdateRoutingProfileDefaultOutboundQueueResponse EndUpdateRoutingProfileDefaultOutboundQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRoutingProfileDefaultOutboundQueueResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoutingProfileName

        /// <summary>
        /// Updates the name and description of a routing profile. The request accepts the following
        /// data in JSON format. At least <code>Name</code> or <code>Description</code> must be
        /// provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileName service method.</param>
        /// 
        /// <returns>The response from the UpdateRoutingProfileName service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileName">REST API Reference for UpdateRoutingProfileName Operation</seealso>
        public virtual UpdateRoutingProfileNameResponse UpdateRoutingProfileName(UpdateRoutingProfileNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingProfileNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingProfileNameResponseUnmarshaller.Instance;

            return Invoke<UpdateRoutingProfileNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoutingProfileName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileName operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoutingProfileName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileName">REST API Reference for UpdateRoutingProfileName Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoutingProfileName(UpdateRoutingProfileNameRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingProfileNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingProfileNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoutingProfileName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoutingProfileName.</param>
        /// 
        /// <returns>Returns a  UpdateRoutingProfileNameResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileName">REST API Reference for UpdateRoutingProfileName Operation</seealso>
        public virtual UpdateRoutingProfileNameResponse EndUpdateRoutingProfileName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRoutingProfileNameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoutingProfileQueues

        /// <summary>
        /// Updates the properties associated with a set of queues for a routing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileQueues service method.</param>
        /// 
        /// <returns>The response from the UpdateRoutingProfileQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileQueues">REST API Reference for UpdateRoutingProfileQueues Operation</seealso>
        public virtual UpdateRoutingProfileQueuesResponse UpdateRoutingProfileQueues(UpdateRoutingProfileQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingProfileQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingProfileQueuesResponseUnmarshaller.Instance;

            return Invoke<UpdateRoutingProfileQueuesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoutingProfileQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingProfileQueues operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoutingProfileQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileQueues">REST API Reference for UpdateRoutingProfileQueues Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoutingProfileQueues(UpdateRoutingProfileQueuesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingProfileQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingProfileQueuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoutingProfileQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoutingProfileQueues.</param>
        /// 
        /// <returns>Returns a  UpdateRoutingProfileQueuesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRoutingProfileQueues">REST API Reference for UpdateRoutingProfileQueues Operation</seealso>
        public virtual UpdateRoutingProfileQueuesResponse EndUpdateRoutingProfileQueues(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRoutingProfileQueuesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRule

        /// <summary>
        /// Updates a rule for the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/connect-rules-language.html">Rules
        /// Function language</a> to code conditions for the rule. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateRule(UpdateRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRule.</param>
        /// 
        /// <returns>Returns a  UpdateRuleResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual UpdateRuleResponse EndUpdateRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSecurityProfile

        /// <summary>
        /// This API is in preview release for Amazon Connect and is subject to change.
        /// 
        ///  
        /// <para>
        /// Updates a security profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurityProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateSecurityProfile">REST API Reference for UpdateSecurityProfile Operation</seealso>
        public virtual UpdateSecurityProfileResponse UpdateSecurityProfile(UpdateSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityProfile operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateSecurityProfile">REST API Reference for UpdateSecurityProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateSecurityProfile(UpdateSecurityProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurityProfile.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityProfileResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateSecurityProfile">REST API Reference for UpdateSecurityProfile Operation</seealso>
        public virtual UpdateSecurityProfileResponse EndUpdateSecurityProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSecurityProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTaskTemplate

        /// <summary>
        /// Updates details about a specific task template in the specified Amazon Connect instance.
        /// This operation does not support partial updates. Instead it does a full update of
        /// template content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTaskTemplate service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.PropertyValidationException">
        /// The property is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateTaskTemplate">REST API Reference for UpdateTaskTemplate Operation</seealso>
        public virtual UpdateTaskTemplateResponse UpdateTaskTemplate(UpdateTaskTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTaskTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskTemplate operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTaskTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateTaskTemplate">REST API Reference for UpdateTaskTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateTaskTemplate(UpdateTaskTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTaskTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTaskTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateTaskTemplateResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateTaskTemplate">REST API Reference for UpdateTaskTemplate Operation</seealso>
        public virtual UpdateTaskTemplateResponse EndUpdateTaskTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTaskTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTrafficDistribution

        /// <summary>
        /// Updates the traffic distribution for a given traffic distribution group. 
        /// 
        ///  
        /// <para>
        /// For more information about updating a traffic distribution group, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/update-telephony-traffic-distribution.html">Update
        /// telephony traffic distribution across Amazon Web Services Regions </a> in the <i>Amazon
        /// Connect Administrator Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateTrafficDistribution service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceConflictException">
        /// A resource already has that name.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateTrafficDistribution">REST API Reference for UpdateTrafficDistribution Operation</seealso>
        public virtual UpdateTrafficDistributionResponse UpdateTrafficDistribution(UpdateTrafficDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrafficDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrafficDistributionResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficDistributionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficDistribution operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrafficDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateTrafficDistribution">REST API Reference for UpdateTrafficDistribution Operation</seealso>
        public virtual IAsyncResult BeginUpdateTrafficDistribution(UpdateTrafficDistributionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrafficDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrafficDistributionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrafficDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrafficDistribution.</param>
        /// 
        /// <returns>Returns a  UpdateTrafficDistributionResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateTrafficDistribution">REST API Reference for UpdateTrafficDistribution Operation</seealso>
        public virtual UpdateTrafficDistributionResponse EndUpdateTrafficDistribution(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTrafficDistributionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserHierarchy

        /// <summary>
        /// Assigns the specified hierarchy group to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchy service method.</param>
        /// 
        /// <returns>The response from the UpdateUserHierarchy service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchy">REST API Reference for UpdateUserHierarchy Operation</seealso>
        public virtual UpdateUserHierarchyResponse UpdateUserHierarchy(UpdateUserHierarchyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserHierarchyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserHierarchyResponseUnmarshaller.Instance;

            return Invoke<UpdateUserHierarchyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserHierarchy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchy operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserHierarchy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchy">REST API Reference for UpdateUserHierarchy Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserHierarchy(UpdateUserHierarchyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserHierarchyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserHierarchyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserHierarchy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserHierarchy.</param>
        /// 
        /// <returns>Returns a  UpdateUserHierarchyResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchy">REST API Reference for UpdateUserHierarchy Operation</seealso>
        public virtual UpdateUserHierarchyResponse EndUpdateUserHierarchy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserHierarchyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserHierarchyGroupName

        /// <summary>
        /// Updates the name of the user hierarchy group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchyGroupName service method.</param>
        /// 
        /// <returns>The response from the UpdateUserHierarchyGroupName service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchyGroupName">REST API Reference for UpdateUserHierarchyGroupName Operation</seealso>
        public virtual UpdateUserHierarchyGroupNameResponse UpdateUserHierarchyGroupName(UpdateUserHierarchyGroupNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserHierarchyGroupNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserHierarchyGroupNameResponseUnmarshaller.Instance;

            return Invoke<UpdateUserHierarchyGroupNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserHierarchyGroupName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchyGroupName operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserHierarchyGroupName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchyGroupName">REST API Reference for UpdateUserHierarchyGroupName Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserHierarchyGroupName(UpdateUserHierarchyGroupNameRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserHierarchyGroupNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserHierarchyGroupNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserHierarchyGroupName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserHierarchyGroupName.</param>
        /// 
        /// <returns>Returns a  UpdateUserHierarchyGroupNameResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchyGroupName">REST API Reference for UpdateUserHierarchyGroupName Operation</seealso>
        public virtual UpdateUserHierarchyGroupNameResponse EndUpdateUserHierarchyGroupName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserHierarchyGroupNameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserHierarchyStructure

        /// <summary>
        /// Updates the user hierarchy structure: add, remove, and rename user hierarchy levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchyStructure service method.</param>
        /// 
        /// <returns>The response from the UpdateUserHierarchyStructure service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceInUseException">
        /// That resource is already in use. Please try another.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchyStructure">REST API Reference for UpdateUserHierarchyStructure Operation</seealso>
        public virtual UpdateUserHierarchyStructureResponse UpdateUserHierarchyStructure(UpdateUserHierarchyStructureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserHierarchyStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserHierarchyStructureResponseUnmarshaller.Instance;

            return Invoke<UpdateUserHierarchyStructureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserHierarchyStructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchyStructure operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserHierarchyStructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchyStructure">REST API Reference for UpdateUserHierarchyStructure Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserHierarchyStructure(UpdateUserHierarchyStructureRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserHierarchyStructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserHierarchyStructureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserHierarchyStructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserHierarchyStructure.</param>
        /// 
        /// <returns>Returns a  UpdateUserHierarchyStructureResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchyStructure">REST API Reference for UpdateUserHierarchyStructure Operation</seealso>
        public virtual UpdateUserHierarchyStructureResponse EndUpdateUserHierarchyStructure(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserHierarchyStructureResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserIdentityInfo

        /// <summary>
        /// Updates the identity information for the specified user.
        /// 
        ///  <important> 
        /// <para>
        /// We strongly recommend limiting who has the ability to invoke <code>UpdateUserIdentityInfo</code>.
        /// Someone with that ability can change the login credentials of other users by changing
        /// their email address. This poses a security risk to your organization. They can change
        /// the email address of a user to the attacker's email address, and then reset the password
        /// through email. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-profile-best-practices.html">Best
        /// Practices for Security Profiles</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserIdentityInfo service method.</param>
        /// 
        /// <returns>The response from the UpdateUserIdentityInfo service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserIdentityInfo">REST API Reference for UpdateUserIdentityInfo Operation</seealso>
        public virtual UpdateUserIdentityInfoResponse UpdateUserIdentityInfo(UpdateUserIdentityInfoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserIdentityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserIdentityInfoResponseUnmarshaller.Instance;

            return Invoke<UpdateUserIdentityInfoResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserIdentityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserIdentityInfo operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserIdentityInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserIdentityInfo">REST API Reference for UpdateUserIdentityInfo Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserIdentityInfo(UpdateUserIdentityInfoRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserIdentityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserIdentityInfoResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserIdentityInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserIdentityInfo.</param>
        /// 
        /// <returns>Returns a  UpdateUserIdentityInfoResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserIdentityInfo">REST API Reference for UpdateUserIdentityInfo Operation</seealso>
        public virtual UpdateUserIdentityInfoResponse EndUpdateUserIdentityInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserIdentityInfoResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserPhoneConfig

        /// <summary>
        /// Updates the phone configuration settings for the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPhoneConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateUserPhoneConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserPhoneConfig">REST API Reference for UpdateUserPhoneConfig Operation</seealso>
        public virtual UpdateUserPhoneConfigResponse UpdateUserPhoneConfig(UpdateUserPhoneConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPhoneConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPhoneConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPhoneConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPhoneConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPhoneConfig operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserPhoneConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserPhoneConfig">REST API Reference for UpdateUserPhoneConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserPhoneConfig(UpdateUserPhoneConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPhoneConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPhoneConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserPhoneConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserPhoneConfig.</param>
        /// 
        /// <returns>Returns a  UpdateUserPhoneConfigResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserPhoneConfig">REST API Reference for UpdateUserPhoneConfig Operation</seealso>
        public virtual UpdateUserPhoneConfigResponse EndUpdateUserPhoneConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserPhoneConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserRoutingProfile

        /// <summary>
        /// Assigns the specified routing profile to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserRoutingProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateUserRoutingProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserRoutingProfile">REST API Reference for UpdateUserRoutingProfile Operation</seealso>
        public virtual UpdateUserRoutingProfileResponse UpdateUserRoutingProfile(UpdateUserRoutingProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRoutingProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserRoutingProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateUserRoutingProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserRoutingProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserRoutingProfile operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserRoutingProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserRoutingProfile">REST API Reference for UpdateUserRoutingProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserRoutingProfile(UpdateUserRoutingProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRoutingProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserRoutingProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserRoutingProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserRoutingProfile.</param>
        /// 
        /// <returns>Returns a  UpdateUserRoutingProfileResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserRoutingProfile">REST API Reference for UpdateUserRoutingProfile Operation</seealso>
        public virtual UpdateUserRoutingProfileResponse EndUpdateUserRoutingProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserRoutingProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserSecurityProfiles

        /// <summary>
        /// Assigns the specified security profiles to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSecurityProfiles service method.</param>
        /// 
        /// <returns>The response from the UpdateUserSecurityProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserSecurityProfiles">REST API Reference for UpdateUserSecurityProfiles Operation</seealso>
        public virtual UpdateUserSecurityProfilesResponse UpdateUserSecurityProfiles(UpdateUserSecurityProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserSecurityProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserSecurityProfilesResponseUnmarshaller.Instance;

            return Invoke<UpdateUserSecurityProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserSecurityProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSecurityProfiles operation on AmazonConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserSecurityProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserSecurityProfiles">REST API Reference for UpdateUserSecurityProfiles Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserSecurityProfiles(UpdateUserSecurityProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserSecurityProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserSecurityProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserSecurityProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserSecurityProfiles.</param>
        /// 
        /// <returns>Returns a  UpdateUserSecurityProfilesResult from Connect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserSecurityProfiles">REST API Reference for UpdateUserSecurityProfiles Operation</seealso>
        public virtual UpdateUserSecurityProfilesResponse EndUpdateUserSecurityProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserSecurityProfilesResponse>(asyncResult);
        }

        #endregion
        
    }
}