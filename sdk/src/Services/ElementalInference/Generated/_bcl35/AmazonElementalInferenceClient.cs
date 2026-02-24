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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ElementalInference.Model;
using Amazon.ElementalInference.Model.Internal.MarshallTransformations;
using Amazon.ElementalInference.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ElementalInference
{
    /// <summary>
    /// <para>Implementation for accessing ElementalInference</para>
    ///
    /// This is the AWS Elemental Inference REST API Reference. It provides information on
    /// the URL, request contents, and response contents of each AWS Elemental Inference REST
    /// operation. 
    /// 
    ///  
    /// <para>
    /// We assume that you have the IAM permissions that you need to use AWS Elemental Inference
    /// via the REST API. We also assume that you are familiar with the features and operations
    /// of AWS Elemental Inference as described in <i>AWS Elemental Inference User Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonElementalInferenceClient : AmazonServiceClient, IAmazonElementalInference
    {
        private static IServiceMetadata serviceMetadata = new AmazonElementalInferenceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IElementalInferencePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IElementalInferencePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ElementalInferencePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with the credentials loaded from the application's
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
        public AmazonElementalInferenceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElementalInferenceConfig()) { }

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with the credentials loaded from the application's
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
        public AmazonElementalInferenceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElementalInferenceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElementalInferenceClient Configuration Object</param>
        public AmazonElementalInferenceClient(AmazonElementalInferenceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonElementalInferenceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElementalInferenceClient(AWSCredentials credentials)
            : this(credentials, new AmazonElementalInferenceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElementalInferenceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElementalInferenceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with AWS Credentials and an
        /// AmazonElementalInferenceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElementalInferenceClient Configuration Object</param>
        public AmazonElementalInferenceClient(AWSCredentials credentials, AmazonElementalInferenceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElementalInferenceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElementalInferenceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElementalInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElementalInferenceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElementalInferenceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElementalInferenceClient Configuration Object</param>
        public AmazonElementalInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElementalInferenceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElementalInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElementalInferenceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElementalInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElementalInferenceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElementalInferenceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElementalInferenceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElementalInferenceClient Configuration Object</param>
        public AmazonElementalInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElementalInferenceConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElementalInferenceEndpointResolver());
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


        #region  AssociateFeed

        /// <summary>
        /// Associates a resource with the feed. The resource provides the input that Elemental
        /// Inference needs needs in order to perform an Elemental Inference feature, such as
        /// cropping video. You always provide the resource by associating it with a feed. You
        /// can associate only one resource with each feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFeed service method.</param>
        /// 
        /// <returns>The response from the AssociateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/AssociateFeed">REST API Reference for AssociateFeed Operation</seealso>
        public virtual AssociateFeedResponse AssociateFeed(AssociateFeedRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFeedResponseUnmarshaller.Instance;

            return Invoke<AssociateFeedResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateFeed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateFeed operation on AmazonElementalInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateFeed
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/AssociateFeed">REST API Reference for AssociateFeed Operation</seealso>
        public virtual IAsyncResult BeginAssociateFeed(AssociateFeedRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFeedResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateFeed operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateFeed.</param>
        /// 
        /// <returns>Returns a  AssociateFeedResult from ElementalInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/AssociateFeed">REST API Reference for AssociateFeed Operation</seealso>
        public virtual AssociateFeedResponse EndAssociateFeed(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateFeedResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFeed

        /// <summary>
        /// Creates a feed. The feed is the target for live streams being sent by the calling
        /// application. An example of a calling application is AWS Elemental MediaLive. After
        /// you create the feed, you can associate a resource with the feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeed service method.</param>
        /// 
        /// <returns>The response from the CreateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateFeed">REST API Reference for CreateFeed Operation</seealso>
        public virtual CreateFeedResponse CreateFeed(CreateFeedRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFeedResponseUnmarshaller.Instance;

            return Invoke<CreateFeedResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFeed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFeed operation on AmazonElementalInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFeed
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateFeed">REST API Reference for CreateFeed Operation</seealso>
        public virtual IAsyncResult BeginCreateFeed(CreateFeedRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFeedResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFeed operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFeed.</param>
        /// 
        /// <returns>Returns a  CreateFeedResult from ElementalInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateFeed">REST API Reference for CreateFeed Operation</seealso>
        public virtual CreateFeedResponse EndCreateFeed(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFeedResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFeed

        /// <summary>
        /// Deletes the specified feed. The feed can be deleted at any time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeed service method.</param>
        /// 
        /// <returns>The response from the DeleteFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFeed">REST API Reference for DeleteFeed Operation</seealso>
        public virtual DeleteFeedResponse DeleteFeed(DeleteFeedRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFeedResponseUnmarshaller.Instance;

            return Invoke<DeleteFeedResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFeed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeed operation on AmazonElementalInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFeed
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFeed">REST API Reference for DeleteFeed Operation</seealso>
        public virtual IAsyncResult BeginDeleteFeed(DeleteFeedRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFeedResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFeed operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFeed.</param>
        /// 
        /// <returns>Returns a  DeleteFeedResult from ElementalInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFeed">REST API Reference for DeleteFeed Operation</seealso>
        public virtual DeleteFeedResponse EndDeleteFeed(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFeedResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateFeed

        /// <summary>
        /// Releases the resource (for example, an MediaLive channel) that is associated with
        /// this feed. The outputs in the feed become disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFeed service method.</param>
        /// 
        /// <returns>The response from the DisassociateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DisassociateFeed">REST API Reference for DisassociateFeed Operation</seealso>
        public virtual DisassociateFeedResponse DisassociateFeed(DisassociateFeedRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFeedResponseUnmarshaller.Instance;

            return Invoke<DisassociateFeedResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFeed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFeed operation on AmazonElementalInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFeed
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DisassociateFeed">REST API Reference for DisassociateFeed Operation</seealso>
        public virtual IAsyncResult BeginDisassociateFeed(DisassociateFeedRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFeedResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFeed operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFeed.</param>
        /// 
        /// <returns>Returns a  DisassociateFeedResult from ElementalInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DisassociateFeed">REST API Reference for DisassociateFeed Operation</seealso>
        public virtual DisassociateFeedResponse EndDisassociateFeed(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateFeedResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFeed

        /// <summary>
        /// Retrieves information about the specified feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeed service method.</param>
        /// 
        /// <returns>The response from the GetFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFeed">REST API Reference for GetFeed Operation</seealso>
        public virtual GetFeedResponse GetFeed(GetFeedRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFeedResponseUnmarshaller.Instance;

            return Invoke<GetFeedResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFeed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFeed operation on AmazonElementalInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFeed
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFeed">REST API Reference for GetFeed Operation</seealso>
        public virtual IAsyncResult BeginGetFeed(GetFeedRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFeedResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFeed operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFeed.</param>
        /// 
        /// <returns>Returns a  GetFeedResult from ElementalInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFeed">REST API Reference for GetFeed Operation</seealso>
        public virtual GetFeedResponse EndGetFeed(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFeedResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFeeds

        /// <summary>
        /// Displays a list of feeds that belong to this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeeds service method.</param>
        /// 
        /// <returns>The response from the ListFeeds service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListFeeds">REST API Reference for ListFeeds Operation</seealso>
        public virtual ListFeedsResponse ListFeeds(ListFeedsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFeedsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFeedsResponseUnmarshaller.Instance;

            return Invoke<ListFeedsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFeeds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFeeds operation on AmazonElementalInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFeeds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListFeeds">REST API Reference for ListFeeds Operation</seealso>
        public virtual IAsyncResult BeginListFeeds(ListFeedsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFeedsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFeedsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFeeds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFeeds.</param>
        /// 
        /// <returns>Returns a  ListFeedsResult from ElementalInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListFeeds">REST API Reference for ListFeeds Operation</seealso>
        public virtual ListFeedsResponse EndListFeeds(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFeedsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List all tags that are on an Elemental Inference resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonElementalInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from ElementalInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to the resource identified by the specified resourceArn
        /// in the current region. If existing tags on a resource are not specified in the request
        /// parameters, they are not changed. When a resource is deleted, the tags associated
        /// with that resource are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonElementalInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from ElementalInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes specified tags from the specified resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonElementalInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from ElementalInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFeed

        /// <summary>
        /// Updates the name and/or outputs in a feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeed service method.</param>
        /// 
        /// <returns>The response from the UpdateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateFeed">REST API Reference for UpdateFeed Operation</seealso>
        public virtual UpdateFeedResponse UpdateFeed(UpdateFeedRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFeedResponseUnmarshaller.Instance;

            return Invoke<UpdateFeedResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFeed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeed operation on AmazonElementalInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFeed
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateFeed">REST API Reference for UpdateFeed Operation</seealso>
        public virtual IAsyncResult BeginUpdateFeed(UpdateFeedRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFeedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFeedResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFeed operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFeed.</param>
        /// 
        /// <returns>Returns a  UpdateFeedResult from ElementalInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateFeed">REST API Reference for UpdateFeed Operation</seealso>
        public virtual UpdateFeedResponse EndUpdateFeed(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFeedResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonElementalInferenceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}