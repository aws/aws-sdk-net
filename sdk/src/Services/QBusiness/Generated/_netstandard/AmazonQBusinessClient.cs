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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QBusiness.Model;
using Amazon.QBusiness.Model.Internal.MarshallTransformations;
using Amazon.QBusiness.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.QBusiness
{
    /// <summary>
    /// <para>Implementation for accessing QBusiness</para>
    ///
    /// This is the <i>Amazon Q Business</i> API Reference. Amazon Q Business is a fully managed,
    /// generative-AI powered enterprise chat assistant that you can deploy within your organization.
    /// Amazon Q Business enhances employee productivity by supporting key tasks such as question-answering,
    /// knowledge discovery, writing email messages, summarizing text, drafting document outlines,
    /// and brainstorming ideas. Users ask questions of Amazon Q Business and get answers
    /// that are presented in a conversational manner. For an introduction to the service,
    /// see the <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/what-is.html">
    /// <i>Amazon Q Business User Guide</i> </a>.
    /// 
    ///  
    /// <para>
    /// For an overview of the Amazon Q Business APIs, see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/api-ref.html#api-overview">Overview
    /// of Amazon Q Business API operations</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about the IAM access control permissions you need to use this API,
    /// see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/iam-roles.html">IAM
    /// roles for Amazon Q Business</a> in the <i>Amazon Q Business User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can use the following AWS SDKs to access Amazon Q Business APIs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sdk-for-cpp">AWS SDK for C++</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sdk-for-go">AWS SDK for Go</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sdk-for-java">AWS SDK for Java</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sdk-for-javascript">AWS SDK for JavaScript</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sdk-for-net">AWS SDK for .NET</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/pythonsdk">AWS SDK for Python (Boto3)</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sdk-for-ruby">AWS SDK for Ruby</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following resources provide additional information about using the Amazon Q Business
    /// API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i> <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/setting-up.html">Setting
    /// up for Amazon Q Business</a> </i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i> <a href="https://awscli.amazonaws.com/v2/documentation/api/latest/reference/qbusiness/index.html">Amazon
    /// Q Business CLI Reference</a> </i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i> <a href="https://docs.aws.amazon.com/general/latest/gr/amazonq.html">Amazon Web
    /// Services General Reference</a> </i> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonQBusinessClient : AmazonServiceClient, IAmazonQBusiness
    {
        private static IServiceMetadata serviceMetadata = new AmazonQBusinessMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonQBusinessClient with the credentials loaded from the application's
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
        public AmazonQBusinessClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQBusinessConfig()) { }

        /// <summary>
        /// Constructs AmazonQBusinessClient with the credentials loaded from the application's
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
        public AmazonQBusinessClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQBusinessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQBusinessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQBusinessClient Configuration Object</param>
        public AmazonQBusinessClient(AmazonQBusinessConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonQBusinessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQBusinessClient(AWSCredentials credentials)
            : this(credentials, new AmazonQBusinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQBusinessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQBusinessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQBusinessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQBusinessClient with AWS Credentials and an
        /// AmazonQBusinessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQBusinessClient Configuration Object</param>
        public AmazonQBusinessClient(AWSCredentials credentials, AmazonQBusinessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQBusinessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQBusinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQBusinessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQBusinessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQBusinessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQBusinessClient Configuration Object</param>
        public AmazonQBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQBusinessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQBusinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQBusinessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQBusinessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQBusinessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQBusinessClient Configuration Object</param>
        public AmazonQBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQBusinessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IQBusinessPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IQBusinessPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new QBusinessPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQBusinessEndpointResolver());
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


        #region  BatchDeleteDocument

        internal virtual BatchDeleteDocumentResponse BatchDeleteDocument(BatchDeleteDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDocumentResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteDocumentResponse>(request, options);
        }



        /// <summary>
        /// Asynchronously deletes one or more documents added using the <c>BatchPutDocument</c>
        /// API from an Amazon Q Business index.
        /// 
        ///  
        /// <para>
        /// You can see the progress of the deletion, and any error messages related to the process,
        /// by using CloudWatch.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteDocument service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        public virtual Task<BatchDeleteDocumentResponse> BatchDeleteDocumentAsync(BatchDeleteDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchPutDocument

        internal virtual BatchPutDocumentResponse BatchPutDocument(BatchPutDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutDocumentResponseUnmarshaller.Instance;

            return Invoke<BatchPutDocumentResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more documents to an Amazon Q Business index.
        /// 
        ///  
        /// <para>
        /// You use this API to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ingest your structured and unstructured documents and documents stored in an Amazon
        /// S3 bucket into an Amazon Q Business index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// add custom attributes to documents in an Amazon Q Business index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// attach an access control list to the documents added to an Amazon Q Business index.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can see the progress of the deletion, and any error messages related to the process,
        /// by using CloudWatch.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutDocument service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        public virtual Task<BatchPutDocumentResponse> BatchPutDocumentAsync(BatchPutDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<BatchPutDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ChatSync

        internal virtual ChatSyncResponse ChatSync(ChatSyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChatSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChatSyncResponseUnmarshaller.Instance;

            return Invoke<ChatSyncResponse>(request, options);
        }



        /// <summary>
        /// Starts or continues a non-streaming Amazon Q Business conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChatSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChatSync service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ChatSync">REST API Reference for ChatSync Operation</seealso>
        public virtual Task<ChatSyncResponse> ChatSyncAsync(ChatSyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChatSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChatSyncResponseUnmarshaller.Instance;

            return InvokeAsync<ChatSyncResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q Business application.
        /// 
        ///  <note> 
        /// <para>
        /// There are new tiers for Amazon Q Business. Not all features in Amazon Q Business Pro
        /// are also available in Amazon Q Business Lite. For information on what's included in
        /// Amazon Q Business Lite and what's included in Amazon Q Business Pro, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/what-is.html#tiers">Amazon
        /// Q Business tiers</a>. You must use the Amazon Q Business console to assign subscription
        /// tiers to users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataSource

        internal virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Creates a data source connector for an Amazon Q Business application.
        /// 
        ///  
        /// <para>
        ///  <c>CreateDataSource</c> is a synchronous operation. The operation returns 200 if
        /// the data source was successfully created. Otherwise, an exception is raised.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIndex

        internal virtual CreateIndexResponse CreateIndex(CreateIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return Invoke<CreateIndexResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q Business index.
        /// 
        ///  
        /// <para>
        /// To determine if index creation has completed, check the <c>Status</c> field returned
        /// from a call to <c>DescribeIndex</c>. The <c>Status</c> field is set to <c>ACTIVE</c>
        /// when the index is ready to use.
        /// </para>
        ///  
        /// <para>
        /// Once the index is active, you can index your documents using the <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_BatchPutDocument.html">
        /// <c>BatchPutDocument</c> </a> API or the <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_CreateDataSource.html">
        /// <c>CreateDataSource</c> </a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual Task<CreateIndexResponse> CreateIndexAsync(CreateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlugin

        internal virtual CreatePluginResponse CreatePlugin(CreatePluginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePluginResponseUnmarshaller.Instance;

            return Invoke<CreatePluginResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreatePlugin">REST API Reference for CreatePlugin Operation</seealso>
        public virtual Task<CreatePluginResponse> CreatePluginAsync(CreatePluginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePluginResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePluginResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRetriever

        internal virtual CreateRetrieverResponse CreateRetriever(CreateRetrieverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRetrieverResponseUnmarshaller.Instance;

            return Invoke<CreateRetrieverResponse>(request, options);
        }



        /// <summary>
        /// Adds a retriever to your Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRetriever service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateRetriever">REST API Reference for CreateRetriever Operation</seealso>
        public virtual Task<CreateRetrieverResponse> CreateRetrieverAsync(CreateRetrieverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRetrieverResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRetrieverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }



        /// <summary>
        /// Creates a universally unique identifier (UUID) mapped to a list of local user ids
        /// within an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWebExperience

        internal virtual CreateWebExperienceResponse CreateWebExperience(CreateWebExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebExperienceResponseUnmarshaller.Instance;

            return Invoke<CreateWebExperienceResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateWebExperience">REST API Reference for CreateWebExperience Operation</seealso>
        public virtual Task<CreateWebExperienceResponse> CreateWebExperienceAsync(CreateWebExperienceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebExperienceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWebExperienceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChatControlsConfiguration

        internal virtual DeleteChatControlsConfigurationResponse DeleteChatControlsConfiguration(DeleteChatControlsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChatControlsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteChatControlsConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes chat controls configured for an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatControlsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChatControlsConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatControlsConfiguration">REST API Reference for DeleteChatControlsConfiguration Operation</seealso>
        public virtual Task<DeleteChatControlsConfigurationResponse> DeleteChatControlsConfigurationAsync(DeleteChatControlsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChatControlsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChatControlsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConversation

        internal virtual DeleteConversationResponse DeleteConversation(DeleteConversationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConversationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConversationResponseUnmarshaller.Instance;

            return Invoke<DeleteConversationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q Business web experience conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConversation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConversation service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteConversation">REST API Reference for DeleteConversation Operation</seealso>
        public virtual Task<DeleteConversationResponse> DeleteConversationAsync(DeleteConversationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConversationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConversationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConversationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataSource

        internal virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q Business data source connector. While the data source is being
        /// deleted, the <c>Status</c> field returned by a call to the <c>DescribeDataSource</c>
        /// API is set to <c>DELETING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a group so that all users and sub groups that belong to the group can no longer
        /// access documents only available to that group. For example, after deleting the group
        /// "Summer Interns", all interns who belonged to that group no longer see intern-only
        /// documents in their chat results. 
        /// 
        ///  
        /// <para>
        /// If you want to delete, update, or replace users or sub groups of a group, you need
        /// to use the <c>PutGroup</c> operation. For example, if a user in the group "Engineering"
        /// leaves the engineering team and another user takes their place, you provide an updated
        /// list of users or sub groups that belong to the "Engineering" group when calling <c>PutGroup</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIndex

        internal virtual DeleteIndexResponse DeleteIndex(DeleteIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;

            return Invoke<DeleteIndexResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual Task<DeleteIndexResponse> DeleteIndexAsync(DeleteIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePlugin

        internal virtual DeletePluginResponse DeletePlugin(DeletePluginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePluginResponseUnmarshaller.Instance;

            return Invoke<DeletePluginResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeletePlugin">REST API Reference for DeletePlugin Operation</seealso>
        public virtual Task<DeletePluginResponse> DeletePluginAsync(DeletePluginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePluginResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePluginResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRetriever

        internal virtual DeleteRetrieverResponse DeleteRetriever(DeleteRetrieverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetrieverResponseUnmarshaller.Instance;

            return Invoke<DeleteRetrieverResponse>(request, options);
        }



        /// <summary>
        /// Deletes the retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetriever service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteRetriever">REST API Reference for DeleteRetriever Operation</seealso>
        public virtual Task<DeleteRetrieverResponse> DeleteRetrieverAsync(DeleteRetrieverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetrieverResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRetrieverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }



        /// <summary>
        /// Deletes a user by email id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWebExperience

        internal virtual DeleteWebExperienceResponse DeleteWebExperience(DeleteWebExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebExperienceResponseUnmarshaller.Instance;

            return Invoke<DeleteWebExperienceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteWebExperience">REST API Reference for DeleteWebExperience Operation</seealso>
        public virtual Task<DeleteWebExperienceResponse> DeleteWebExperienceAsync(DeleteWebExperienceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebExperienceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWebExperienceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApplication

        internal virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChatControlsConfiguration

        internal virtual GetChatControlsConfigurationResponse GetChatControlsConfiguration(GetChatControlsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChatControlsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetChatControlsConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an chat controls configured for an existing Amazon Q Business
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChatControlsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChatControlsConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatControlsConfiguration">REST API Reference for GetChatControlsConfiguration Operation</seealso>
        public virtual Task<GetChatControlsConfigurationResponse> GetChatControlsConfigurationAsync(GetChatControlsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChatControlsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetChatControlsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataSource

        internal virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an existing Amazon Q Business data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroup

        internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }



        /// <summary>
        /// Describes a group by group name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIndex

        internal virtual GetIndexResponse GetIndex(GetIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexResponseUnmarshaller.Instance;

            return Invoke<GetIndexResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an existing Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetIndex">REST API Reference for GetIndex Operation</seealso>
        public virtual Task<GetIndexResponse> GetIndexAsync(GetIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexResponseUnmarshaller.Instance;

            return InvokeAsync<GetIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlugin

        internal virtual GetPluginResponse GetPlugin(GetPluginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPluginResponseUnmarshaller.Instance;

            return Invoke<GetPluginResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an existing Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPlugin">REST API Reference for GetPlugin Operation</seealso>
        public virtual Task<GetPluginResponse> GetPluginAsync(GetPluginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPluginResponseUnmarshaller.Instance;

            return InvokeAsync<GetPluginResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRetriever

        internal virtual GetRetrieverResponse GetRetriever(GetRetrieverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRetrieverResponseUnmarshaller.Instance;

            return Invoke<GetRetrieverResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an existing retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRetriever service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetRetriever">REST API Reference for GetRetriever Operation</seealso>
        public virtual Task<GetRetrieverResponse> GetRetrieverAsync(GetRetrieverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRetrieverResponseUnmarshaller.Instance;

            return InvokeAsync<GetRetrieverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUser

        internal virtual GetUserResponse GetUser(GetUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserResponse>(request, options);
        }



        /// <summary>
        /// Describes the universally unique identifier (UUID) associated with a local user in
        /// a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWebExperience

        internal virtual GetWebExperienceResponse GetWebExperience(GetWebExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebExperienceResponseUnmarshaller.Instance;

            return Invoke<GetWebExperienceResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an existing Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetWebExperience">REST API Reference for GetWebExperience Operation</seealso>
        public virtual Task<GetWebExperienceResponse> GetWebExperienceAsync(GetWebExperienceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebExperienceResponseUnmarshaller.Instance;

            return InvokeAsync<GetWebExperienceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplications

        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Lists Amazon Q Business applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConversations

        internal virtual ListConversationsResponse ListConversations(ListConversationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConversationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConversationsResponseUnmarshaller.Instance;

            return Invoke<ListConversationsResponse>(request, options);
        }



        /// <summary>
        /// Lists one or more Amazon Q Business conversations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConversations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConversations service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListConversations">REST API Reference for ListConversations Operation</seealso>
        public virtual Task<ListConversationsResponse> ListConversationsAsync(ListConversationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConversationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConversationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConversationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSources

        internal virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the Amazon Q Business data source connectors that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSourceSyncJobs

        internal virtual ListDataSourceSyncJobsResponse ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceSyncJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceSyncJobsResponseUnmarshaller.Instance;

            return Invoke<ListDataSourceSyncJobsResponse>(request, options);
        }



        /// <summary>
        /// Get information about an Amazon Q Business data source connector synchronization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSourceSyncJobs service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        public virtual Task<ListDataSourceSyncJobsResponse> ListDataSourceSyncJobsAsync(ListDataSourceSyncJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceSyncJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceSyncJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourceSyncJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDocuments

        internal virtual ListDocumentsResponse ListDocuments(ListDocumentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentsResponse>(request, options);
        }



        /// <summary>
        /// A list of documents attached to an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public virtual Task<ListDocumentsResponse> ListDocumentsAsync(ListDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroups

        internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of groups that are mapped to users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIndices

        internal virtual ListIndicesResponse ListIndices(ListIndicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;

            return Invoke<ListIndicesResponse>(request, options);
        }



        /// <summary>
        /// Lists the Amazon Q Business indices you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIndices service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListIndices">REST API Reference for ListIndices Operation</seealso>
        public virtual Task<ListIndicesResponse> ListIndicesAsync(ListIndicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIndicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMessages

        internal virtual ListMessagesResponse ListMessages(ListMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessagesResponseUnmarshaller.Instance;

            return Invoke<ListMessagesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of messages associated with an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMessages service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListMessages">REST API Reference for ListMessages Operation</seealso>
        public virtual Task<ListMessagesResponse> ListMessagesAsync(ListMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListMessagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlugins

        internal virtual ListPluginsResponse ListPlugins(ListPluginsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPluginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginsResponseUnmarshaller.Instance;

            return Invoke<ListPluginsResponse>(request, options);
        }



        /// <summary>
        /// Lists configured Amazon Q Business plugins.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlugins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlugins service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        public virtual Task<ListPluginsResponse> ListPluginsAsync(ListPluginsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPluginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPluginsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRetrievers

        internal virtual ListRetrieversResponse ListRetrievers(ListRetrieversRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetrieversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetrieversResponseUnmarshaller.Instance;

            return Invoke<ListRetrieversResponse>(request, options);
        }



        /// <summary>
        /// Lists the retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetrievers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetrievers service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListRetrievers">REST API Reference for ListRetrievers Operation</seealso>
        public virtual Task<ListRetrieversResponse> ListRetrieversAsync(ListRetrieversRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetrieversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetrieversResponseUnmarshaller.Instance;

            return InvokeAsync<ListRetrieversResponse>(request, options, cancellationToken);
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
        /// Gets a list of tags associated with a specified resource. Amazon Q Business applications
        /// and data sources can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWebExperiences

        internal virtual ListWebExperiencesResponse ListWebExperiences(ListWebExperiencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebExperiencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebExperiencesResponseUnmarshaller.Instance;

            return Invoke<ListWebExperiencesResponse>(request, options);
        }



        /// <summary>
        /// Lists one or more Amazon Q Business Web Experiences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebExperiences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebExperiences service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListWebExperiences">REST API Reference for ListWebExperiences Operation</seealso>
        public virtual Task<ListWebExperiencesResponse> ListWebExperiencesAsync(ListWebExperiencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebExperiencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebExperiencesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWebExperiencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutFeedback

        internal virtual PutFeedbackResponse PutFeedback(PutFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Enables your end user to provide feedback on their Amazon Q Business generated chat
        /// responses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFeedback service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual Task<PutFeedbackResponse> PutFeedbackAsync(PutFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<PutFeedbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutGroup

        internal virtual PutGroupResponse PutGroup(PutGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupResponseUnmarshaller.Instance;

            return Invoke<PutGroupResponse>(request, options);
        }



        /// <summary>
        /// Create, or updates, a mapping of users—who have access to a document—to groups.
        /// 
        ///  
        /// <para>
        /// You can also map sub groups to groups. For example, the group "Company Intellectual
        /// Property Teams" includes sub groups "Research" and "Engineering". These sub groups
        /// include their own list of users or people who work in these teams. Only users who
        /// work in research and engineering, and therefore belong in the intellectual property
        /// group, can see top-secret company documents in their Amazon Q Business chat results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutGroup service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutGroup">REST API Reference for PutGroup Operation</seealso>
        public virtual Task<PutGroupResponse> PutGroupAsync(PutGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupResponseUnmarshaller.Instance;

            return InvokeAsync<PutGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDataSourceSyncJob

        internal virtual StartDataSourceSyncJobResponse StartDataSourceSyncJob(StartDataSourceSyncJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceSyncJobResponseUnmarshaller.Instance;

            return Invoke<StartDataSourceSyncJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a data source connector synchronization job. If a synchronization job is already
        /// in progress, Amazon Q Business returns a <c>ConflictException</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDataSourceSyncJob service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        public virtual Task<StartDataSourceSyncJobResponse> StartDataSourceSyncJobAsync(StartDataSourceSyncJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceSyncJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartDataSourceSyncJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDataSourceSyncJob

        internal virtual StopDataSourceSyncJobResponse StopDataSourceSyncJob(StopDataSourceSyncJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataSourceSyncJobResponseUnmarshaller.Instance;

            return Invoke<StopDataSourceSyncJobResponse>(request, options);
        }



        /// <summary>
        /// Stops an Amazon Q Business data source connector synchronization job already in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDataSourceSyncJob service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        public virtual Task<StopDataSourceSyncJobResponse> StopDataSourceSyncJobAsync(StopDataSourceSyncJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataSourceSyncJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopDataSourceSyncJobResponse>(request, options, cancellationToken);
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
        /// Adds the specified tag to the specified Amazon Q Business application or data source
        /// resource. If the tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a tag from an Amazon Q Business application or a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChatControlsConfiguration

        internal virtual UpdateChatControlsConfigurationResponse UpdateChatControlsConfiguration(UpdateChatControlsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChatControlsConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateChatControlsConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates an set of chat controls configured for an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatControlsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChatControlsConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatControlsConfiguration">REST API Reference for UpdateChatControlsConfiguration Operation</seealso>
        public virtual Task<UpdateChatControlsConfigurationResponse> UpdateChatControlsConfigurationAsync(UpdateChatControlsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChatControlsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChatControlsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataSource

        internal virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing Amazon Q Business data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIndex

        internal virtual UpdateIndexResponse UpdateIndex(UpdateIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexResponseUnmarshaller.Instance;

            return Invoke<UpdateIndexResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        public virtual Task<UpdateIndexResponse> UpdateIndexAsync(UpdateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePlugin

        internal virtual UpdatePluginResponse UpdatePlugin(UpdatePluginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePluginResponseUnmarshaller.Instance;

            return Invoke<UpdatePluginResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdatePlugin">REST API Reference for UpdatePlugin Operation</seealso>
        public virtual Task<UpdatePluginResponse> UpdatePluginAsync(UpdatePluginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePluginResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePluginResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRetriever

        internal virtual UpdateRetrieverResponse UpdateRetriever(UpdateRetrieverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRetrieverResponseUnmarshaller.Instance;

            return Invoke<UpdateRetrieverResponse>(request, options);
        }



        /// <summary>
        /// Updates the retriever used for your Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRetriever service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateRetriever">REST API Reference for UpdateRetriever Operation</seealso>
        public virtual Task<UpdateRetrieverResponse> UpdateRetrieverAsync(UpdateRetrieverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRetrieverResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRetrieverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUser

        internal virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }



        /// <summary>
        /// Updates a information associated with a user id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWebExperience

        internal virtual UpdateWebExperienceResponse UpdateWebExperience(UpdateWebExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebExperienceResponseUnmarshaller.Instance;

            return Invoke<UpdateWebExperienceResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistences with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Make sure you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateWebExperience">REST API Reference for UpdateWebExperience Operation</seealso>
        public virtual Task<UpdateWebExperienceResponse> UpdateWebExperienceAsync(UpdateWebExperienceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebExperienceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWebExperienceResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonQBusinessEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}