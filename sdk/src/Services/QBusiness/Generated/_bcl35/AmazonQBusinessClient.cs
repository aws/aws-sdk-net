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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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


        #region  AssociatePermission

        /// <summary>
        /// Adds or updates a permission policy for a Amazon Q Business application, allowing
        /// cross-account access for an ISV. This operation creates a new policy statement for
        /// the specified Amazon Q Business application. The policy statement defines the IAM
        /// actions that the ISV is allowed to perform on the Amazon Q Business application's
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePermission service method.</param>
        /// 
        /// <returns>The response from the AssociatePermission service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/AssociatePermission">REST API Reference for AssociatePermission Operation</seealso>
        public virtual AssociatePermissionResponse AssociatePermission(AssociatePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePermissionResponseUnmarshaller.Instance;

            return Invoke<AssociatePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePermission operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/AssociatePermission">REST API Reference for AssociatePermission Operation</seealso>
        public virtual IAsyncResult BeginAssociatePermission(AssociatePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePermission.</param>
        /// 
        /// <returns>Returns a  AssociatePermissionResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/AssociatePermission">REST API Reference for AssociatePermission Operation</seealso>
        public virtual AssociatePermissionResponse EndAssociatePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteDocument

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
        /// 
        /// <returns>The response from the BatchDeleteDocument service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        public virtual BatchDeleteDocumentResponse BatchDeleteDocument(BatchDeleteDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDocumentResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteDocumentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDocument operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteDocument(BatchDeleteDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteDocument.</param>
        /// 
        /// <returns>Returns a  BatchDeleteDocumentResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        public virtual BatchDeleteDocumentResponse EndBatchDeleteDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchPutDocument

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
        /// 
        /// <returns>The response from the BatchPutDocument service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual BatchPutDocumentResponse BatchPutDocument(BatchPutDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutDocumentResponseUnmarshaller.Instance;

            return Invoke<BatchPutDocumentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutDocument operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        public virtual IAsyncResult BeginBatchPutDocument(BatchPutDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutDocument.</param>
        /// 
        /// <returns>Returns a  BatchPutDocumentResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        public virtual BatchPutDocumentResponse EndBatchPutDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchPutDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelSubscription

        /// <summary>
        /// Unsubscribes a user or a group from their pricing tier in an Amazon Q Business application.
        /// An unsubscribed user or group loses all Amazon Q Business feature access at the start
        /// of next month.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription service method.</param>
        /// 
        /// <returns>The response from the CancelSubscription service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        public virtual CancelSubscriptionResponse CancelSubscription(CancelSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CancelSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        public virtual IAsyncResult BeginCancelSubscription(CancelSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSubscription.</param>
        /// 
        /// <returns>Returns a  CancelSubscriptionResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        public virtual CancelSubscriptionResponse EndCancelSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  ChatSync

        /// <summary>
        /// Starts or continues a non-streaming Amazon Q Business conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChatSync service method.</param>
        /// 
        /// <returns>The response from the ChatSync service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ExternalResourceException">
        /// An external resource that you configured with your application is returning errors
        /// and preventing this operation from succeeding. Fix those errors and try again.
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ChatSync">REST API Reference for ChatSync Operation</seealso>
        public virtual ChatSyncResponse ChatSync(ChatSyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChatSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChatSyncResponseUnmarshaller.Instance;

            return Invoke<ChatSyncResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChatSync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChatSync operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChatSync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ChatSync">REST API Reference for ChatSync Operation</seealso>
        public virtual IAsyncResult BeginChatSync(ChatSyncRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChatSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChatSyncResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ChatSync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChatSync.</param>
        /// 
        /// <returns>Returns a  ChatSyncResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ChatSync">REST API Reference for ChatSync Operation</seealso>
        public virtual ChatSyncResponse EndChatSync(IAsyncResult asyncResult)
        {
            return EndInvoke<ChatSyncResponse>(asyncResult);
        }

        #endregion
        
        #region  CheckDocumentAccess

        /// <summary>
        /// Verifies if a user has access permissions for a specified document and returns the
        /// actual ACL attached to the document. Resolves user access on the document via user
        /// aliases and groups when verifying user access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDocumentAccess service method.</param>
        /// 
        /// <returns>The response from the CheckDocumentAccess service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CheckDocumentAccess">REST API Reference for CheckDocumentAccess Operation</seealso>
        public virtual CheckDocumentAccessResponse CheckDocumentAccess(CheckDocumentAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDocumentAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDocumentAccessResponseUnmarshaller.Instance;

            return Invoke<CheckDocumentAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDocumentAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDocumentAccess operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckDocumentAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CheckDocumentAccess">REST API Reference for CheckDocumentAccess Operation</seealso>
        public virtual IAsyncResult BeginCheckDocumentAccess(CheckDocumentAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDocumentAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDocumentAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CheckDocumentAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDocumentAccess.</param>
        /// 
        /// <returns>Returns a  CheckDocumentAccessResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CheckDocumentAccess">REST API Reference for CheckDocumentAccess Operation</seealso>
        public virtual CheckDocumentAccessResponse EndCheckDocumentAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<CheckDocumentAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAnonymousWebExperienceUrl

        /// <summary>
        /// Creates a unique URL for anonymous Amazon Q Business web experience. This URL can
        /// only be used once and must be used within 5 minutes after it's generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnonymousWebExperienceUrl service method.</param>
        /// 
        /// <returns>The response from the CreateAnonymousWebExperienceUrl service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateAnonymousWebExperienceUrl">REST API Reference for CreateAnonymousWebExperienceUrl Operation</seealso>
        public virtual CreateAnonymousWebExperienceUrlResponse CreateAnonymousWebExperienceUrl(CreateAnonymousWebExperienceUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnonymousWebExperienceUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnonymousWebExperienceUrlResponseUnmarshaller.Instance;

            return Invoke<CreateAnonymousWebExperienceUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAnonymousWebExperienceUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnonymousWebExperienceUrl operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnonymousWebExperienceUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateAnonymousWebExperienceUrl">REST API Reference for CreateAnonymousWebExperienceUrl Operation</seealso>
        public virtual IAsyncResult BeginCreateAnonymousWebExperienceUrl(CreateAnonymousWebExperienceUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnonymousWebExperienceUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnonymousWebExperienceUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnonymousWebExperienceUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnonymousWebExperienceUrl.</param>
        /// 
        /// <returns>Returns a  CreateAnonymousWebExperienceUrlResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateAnonymousWebExperienceUrl">REST API Reference for CreateAnonymousWebExperienceUrl Operation</seealso>
        public virtual CreateAnonymousWebExperienceUrlResponse EndCreateAnonymousWebExperienceUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAnonymousWebExperienceUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApplication

        /// <summary>
        /// Creates an Amazon Q Business application.
        /// 
        ///  <note> 
        /// <para>
        /// There are new tiers for Amazon Q Business. Not all features in Amazon Q Business Pro
        /// are also available in Amazon Q Business Lite. For information on what's included in
        /// Amazon Q Business Lite and what's included in Amazon Q Business Pro, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/tiers.html#user-sub-tiers">Amazon
        /// Q Business tiers</a>. You must use the Amazon Q Business console to assign subscription
        /// tiers to users. 
        /// </para>
        ///  
        /// <para>
        /// An Amazon Q Apps service linked role will be created if it's absent in the Amazon
        /// Web Services account when <c>QAppsConfiguration</c> is enabled in the request. For
        /// more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/using-service-linked-roles-qapps.html">
        /// Using service-linked roles for Q Apps</a>.
        /// </para>
        ///  
        /// <para>
        /// When you create an application, Amazon Q Business may securely transmit data for processing
        /// from your selected Amazon Web Services region, but within your geography. For more
        /// information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/cross-region-inference.html">Cross
        /// region inference in Amazon Q Business</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChatResponseConfiguration

        /// <summary>
        /// Creates a new chat response configuration for an Amazon Q Business application. This
        /// operation establishes a set of parameters that define how the system generates and
        /// formats responses to user queries in chat interactions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChatResponseConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateChatResponseConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateChatResponseConfiguration">REST API Reference for CreateChatResponseConfiguration Operation</seealso>
        public virtual CreateChatResponseConfigurationResponse CreateChatResponseConfiguration(CreateChatResponseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChatResponseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChatResponseConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateChatResponseConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChatResponseConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChatResponseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateChatResponseConfiguration">REST API Reference for CreateChatResponseConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateChatResponseConfiguration(CreateChatResponseConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChatResponseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChatResponseConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChatResponseConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateChatResponseConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateChatResponseConfiguration">REST API Reference for CreateChatResponseConfiguration Operation</seealso>
        public virtual CreateChatResponseConfigurationResponse EndCreateChatResponseConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChatResponseConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataAccessor

        /// <summary>
        /// Creates a new data accessor for an ISV to access data from a Amazon Q Business application.
        /// The data accessor is an entity that represents the ISV's access to the Amazon Q Business
        /// application's data. It includes the IAM role ARN for the ISV, a friendly name, and
        /// a set of action configurations that define the specific actions the ISV is allowed
        /// to perform and any associated data filters. When the data accessor is created, an
        /// IAM Identity Center application is also created to manage the ISV's identity and authentication
        /// for accessing the Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAccessor service method.</param>
        /// 
        /// <returns>The response from the CreateDataAccessor service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataAccessor">REST API Reference for CreateDataAccessor Operation</seealso>
        public virtual CreateDataAccessorResponse CreateDataAccessor(CreateDataAccessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataAccessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataAccessorResponseUnmarshaller.Instance;

            return Invoke<CreateDataAccessorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAccessor operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataAccessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataAccessor">REST API Reference for CreateDataAccessor Operation</seealso>
        public virtual IAsyncResult BeginCreateDataAccessor(CreateDataAccessorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataAccessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataAccessorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataAccessor.</param>
        /// 
        /// <returns>Returns a  CreateDataAccessorResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataAccessor">REST API Reference for CreateDataAccessor Operation</seealso>
        public virtual CreateDataAccessorResponse EndCreateDataAccessor(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataAccessorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSource

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
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSource(CreateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSource.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse EndCreateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIndex

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
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual CreateIndexResponse CreateIndex(CreateIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return Invoke<CreateIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual IAsyncResult BeginCreateIndex(CreateIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIndex.</param>
        /// 
        /// <returns>Returns a  CreateIndexResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual CreateIndexResponse EndCreateIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePlugin

        /// <summary>
        /// Creates an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlugin service method.</param>
        /// 
        /// <returns>The response from the CreatePlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual CreatePluginResponse CreatePlugin(CreatePluginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePluginResponseUnmarshaller.Instance;

            return Invoke<CreatePluginResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlugin operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreatePlugin">REST API Reference for CreatePlugin Operation</seealso>
        public virtual IAsyncResult BeginCreatePlugin(CreatePluginRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePluginResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlugin.</param>
        /// 
        /// <returns>Returns a  CreatePluginResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreatePlugin">REST API Reference for CreatePlugin Operation</seealso>
        public virtual CreatePluginResponse EndCreatePlugin(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePluginResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRetriever

        /// <summary>
        /// Adds a retriever to your Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRetriever service method.</param>
        /// 
        /// <returns>The response from the CreateRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual CreateRetrieverResponse CreateRetriever(CreateRetrieverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRetrieverResponseUnmarshaller.Instance;

            return Invoke<CreateRetrieverResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRetriever operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRetriever operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRetriever
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateRetriever">REST API Reference for CreateRetriever Operation</seealso>
        public virtual IAsyncResult BeginCreateRetriever(CreateRetrieverRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRetrieverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRetriever operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRetriever.</param>
        /// 
        /// <returns>Returns a  CreateRetrieverResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateRetriever">REST API Reference for CreateRetriever Operation</seealso>
        public virtual CreateRetrieverResponse EndCreateRetriever(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRetrieverResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSubscription

        /// <summary>
        /// Subscribes an IAM Identity Center user or a group to a pricing tier for an Amazon
        /// Q Business application.
        /// 
        ///  
        /// <para>
        /// Amazon Q Business offers two subscription tiers: <c>Q_LITE</c> and <c>Q_BUSINESS</c>.
        /// Subscription tier determines feature access for the user. For more information on
        /// subscriptions and pricing tiers, see <a href="https://aws.amazon.com/q/business/pricing/">Amazon
        /// Q Business pricing</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For an example IAM role policy for assigning subscriptions, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/setting-up.html#permissions">Set
        /// up required permissions</a> in the Amazon Q Business User Guide.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateSubscription(CreateSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscription.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual CreateSubscriptionResponse EndCreateSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUser

        /// <summary>
        /// Creates a universally unique identifier (UUID) mapped to a list of local user ids
        /// within an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
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
        /// <returns>Returns a  CreateUserResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWebExperience

        /// <summary>
        /// Creates an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebExperience service method.</param>
        /// 
        /// <returns>The response from the CreateWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual CreateWebExperienceResponse CreateWebExperience(CreateWebExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebExperienceResponseUnmarshaller.Instance;

            return Invoke<CreateWebExperienceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWebExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWebExperience operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWebExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateWebExperience">REST API Reference for CreateWebExperience Operation</seealso>
        public virtual IAsyncResult BeginCreateWebExperience(CreateWebExperienceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebExperienceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWebExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWebExperience.</param>
        /// 
        /// <returns>Returns a  CreateWebExperienceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateWebExperience">REST API Reference for CreateWebExperience Operation</seealso>
        public virtual CreateWebExperienceResponse EndCreateWebExperience(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWebExperienceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Deletes an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAttachment

        /// <summary>
        /// Deletes an attachment associated with a specific Amazon Q Business conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttachment service method.</param>
        /// 
        /// <returns>The response from the DeleteAttachment service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        public virtual DeleteAttachmentResponse DeleteAttachment(DeleteAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttachmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttachment operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        public virtual IAsyncResult BeginDeleteAttachment(DeleteAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttachment.</param>
        /// 
        /// <returns>Returns a  DeleteAttachmentResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        public virtual DeleteAttachmentResponse EndDeleteAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChatControlsConfiguration

        /// <summary>
        /// Deletes chat controls configured for an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatControlsConfiguration service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatControlsConfiguration">REST API Reference for DeleteChatControlsConfiguration Operation</seealso>
        public virtual DeleteChatControlsConfigurationResponse DeleteChatControlsConfiguration(DeleteChatControlsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChatControlsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteChatControlsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatControlsConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChatControlsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatControlsConfiguration">REST API Reference for DeleteChatControlsConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteChatControlsConfiguration(DeleteChatControlsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChatControlsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChatControlsConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteChatControlsConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatControlsConfiguration">REST API Reference for DeleteChatControlsConfiguration Operation</seealso>
        public virtual DeleteChatControlsConfigurationResponse EndDeleteChatControlsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChatControlsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChatResponseConfiguration

        /// <summary>
        /// Deletes a specified chat response configuration from an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatResponseConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteChatResponseConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatResponseConfiguration">REST API Reference for DeleteChatResponseConfiguration Operation</seealso>
        public virtual DeleteChatResponseConfigurationResponse DeleteChatResponseConfiguration(DeleteChatResponseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChatResponseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChatResponseConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteChatResponseConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatResponseConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChatResponseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatResponseConfiguration">REST API Reference for DeleteChatResponseConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteChatResponseConfiguration(DeleteChatResponseConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChatResponseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChatResponseConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChatResponseConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteChatResponseConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatResponseConfiguration">REST API Reference for DeleteChatResponseConfiguration Operation</seealso>
        public virtual DeleteChatResponseConfigurationResponse EndDeleteChatResponseConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChatResponseConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConversation

        /// <summary>
        /// Deletes an Amazon Q Business web experience conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConversation service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteConversation">REST API Reference for DeleteConversation Operation</seealso>
        public virtual DeleteConversationResponse DeleteConversation(DeleteConversationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConversationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConversationResponseUnmarshaller.Instance;

            return Invoke<DeleteConversationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConversation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConversation operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConversation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteConversation">REST API Reference for DeleteConversation Operation</seealso>
        public virtual IAsyncResult BeginDeleteConversation(DeleteConversationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConversationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConversationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConversation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConversation.</param>
        /// 
        /// <returns>Returns a  DeleteConversationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteConversation">REST API Reference for DeleteConversation Operation</seealso>
        public virtual DeleteConversationResponse EndDeleteConversation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConversationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataAccessor

        /// <summary>
        /// Deletes a specified data accessor. This operation permanently removes the data accessor
        /// and its associated IAM Identity Center application. Any access granted to the ISV
        /// through this data accessor will be revoked.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAccessor service method.</param>
        /// 
        /// <returns>The response from the DeleteDataAccessor service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataAccessor">REST API Reference for DeleteDataAccessor Operation</seealso>
        public virtual DeleteDataAccessorResponse DeleteDataAccessor(DeleteDataAccessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataAccessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataAccessorResponseUnmarshaller.Instance;

            return Invoke<DeleteDataAccessorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAccessor operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataAccessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataAccessor">REST API Reference for DeleteDataAccessor Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataAccessor(DeleteDataAccessorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataAccessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataAccessorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataAccessor.</param>
        /// 
        /// <returns>Returns a  DeleteDataAccessorResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataAccessor">REST API Reference for DeleteDataAccessor Operation</seealso>
        public virtual DeleteDataAccessorResponse EndDeleteDataAccessor(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataAccessorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataSource

        /// <summary>
        /// Deletes an Amazon Q Business data source connector. While the data source is being
        /// deleted, the <c>Status</c> field returned by a call to the <c>DescribeDataSource</c>
        /// API is set to <c>DELETING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroup

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
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIndex

        /// <summary>
        /// Deletes an Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// 
        /// <returns>The response from the DeleteIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual DeleteIndexResponse DeleteIndex(DeleteIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;

            return Invoke<DeleteIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual IAsyncResult BeginDeleteIndex(DeleteIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndex.</param>
        /// 
        /// <returns>Returns a  DeleteIndexResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual DeleteIndexResponse EndDeleteIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePlugin

        /// <summary>
        /// Deletes an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlugin service method.</param>
        /// 
        /// <returns>The response from the DeletePlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeletePlugin">REST API Reference for DeletePlugin Operation</seealso>
        public virtual DeletePluginResponse DeletePlugin(DeletePluginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePluginResponseUnmarshaller.Instance;

            return Invoke<DeletePluginResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlugin operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeletePlugin">REST API Reference for DeletePlugin Operation</seealso>
        public virtual IAsyncResult BeginDeletePlugin(DeletePluginRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePluginResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlugin.</param>
        /// 
        /// <returns>Returns a  DeletePluginResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeletePlugin">REST API Reference for DeletePlugin Operation</seealso>
        public virtual DeletePluginResponse EndDeletePlugin(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePluginResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRetriever

        /// <summary>
        /// Deletes the retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetriever service method.</param>
        /// 
        /// <returns>The response from the DeleteRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteRetriever">REST API Reference for DeleteRetriever Operation</seealso>
        public virtual DeleteRetrieverResponse DeleteRetriever(DeleteRetrieverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetrieverResponseUnmarshaller.Instance;

            return Invoke<DeleteRetrieverResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRetriever operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetriever operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRetriever
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteRetriever">REST API Reference for DeleteRetriever Operation</seealso>
        public virtual IAsyncResult BeginDeleteRetriever(DeleteRetrieverRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetrieverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRetriever operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRetriever.</param>
        /// 
        /// <returns>Returns a  DeleteRetrieverResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteRetriever">REST API Reference for DeleteRetriever Operation</seealso>
        public virtual DeleteRetrieverResponse EndDeleteRetriever(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRetrieverResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Deletes a user by email id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
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
        /// <returns>Returns a  DeleteUserResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWebExperience

        /// <summary>
        /// Deletes an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebExperience service method.</param>
        /// 
        /// <returns>The response from the DeleteWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteWebExperience">REST API Reference for DeleteWebExperience Operation</seealso>
        public virtual DeleteWebExperienceResponse DeleteWebExperience(DeleteWebExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebExperienceResponseUnmarshaller.Instance;

            return Invoke<DeleteWebExperienceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWebExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebExperience operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWebExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteWebExperience">REST API Reference for DeleteWebExperience Operation</seealso>
        public virtual IAsyncResult BeginDeleteWebExperience(DeleteWebExperienceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebExperienceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWebExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWebExperience.</param>
        /// 
        /// <returns>Returns a  DeleteWebExperienceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteWebExperience">REST API Reference for DeleteWebExperience Operation</seealso>
        public virtual DeleteWebExperienceResponse EndDeleteWebExperience(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWebExperienceResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociatePermission

        /// <summary>
        /// Removes a permission policy from a Amazon Q Business application, revoking the cross-account
        /// access that was previously granted to an ISV. This operation deletes the specified
        /// policy statement from the application's permission policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePermission service method.</param>
        /// 
        /// <returns>The response from the DisassociatePermission service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DisassociatePermission">REST API Reference for DisassociatePermission Operation</seealso>
        public virtual DisassociatePermissionResponse DisassociatePermission(DisassociatePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePermissionResponseUnmarshaller.Instance;

            return Invoke<DisassociatePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePermission operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DisassociatePermission">REST API Reference for DisassociatePermission Operation</seealso>
        public virtual IAsyncResult BeginDisassociatePermission(DisassociatePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePermission.</param>
        /// 
        /// <returns>Returns a  DisassociatePermissionResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DisassociatePermission">REST API Reference for DisassociatePermission Operation</seealso>
        public virtual DisassociatePermissionResponse EndDisassociatePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociatePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplication

        /// <summary>
        /// Gets information about an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual IAsyncResult BeginGetApplication(GetApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplication.</param>
        /// 
        /// <returns>Returns a  GetApplicationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse EndGetApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChatControlsConfiguration

        /// <summary>
        /// Gets information about chat controls configured for an existing Amazon Q Business
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChatControlsConfiguration service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatControlsConfiguration">REST API Reference for GetChatControlsConfiguration Operation</seealso>
        public virtual GetChatControlsConfigurationResponse GetChatControlsConfiguration(GetChatControlsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChatControlsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetChatControlsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChatControlsConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChatControlsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatControlsConfiguration">REST API Reference for GetChatControlsConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetChatControlsConfiguration(GetChatControlsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChatControlsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChatControlsConfiguration.</param>
        /// 
        /// <returns>Returns a  GetChatControlsConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatControlsConfiguration">REST API Reference for GetChatControlsConfiguration Operation</seealso>
        public virtual GetChatControlsConfigurationResponse EndGetChatControlsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChatControlsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChatResponseConfiguration

        /// <summary>
        /// Retrieves detailed information about a specific chat response configuration from an
        /// Amazon Q Business application. This operation returns the complete configuration settings
        /// and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChatResponseConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetChatResponseConfiguration service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatResponseConfiguration">REST API Reference for GetChatResponseConfiguration Operation</seealso>
        public virtual GetChatResponseConfigurationResponse GetChatResponseConfiguration(GetChatResponseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChatResponseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChatResponseConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetChatResponseConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChatResponseConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChatResponseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatResponseConfiguration">REST API Reference for GetChatResponseConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetChatResponseConfiguration(GetChatResponseConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChatResponseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChatResponseConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChatResponseConfiguration.</param>
        /// 
        /// <returns>Returns a  GetChatResponseConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatResponseConfiguration">REST API Reference for GetChatResponseConfiguration Operation</seealso>
        public virtual GetChatResponseConfigurationResponse EndGetChatResponseConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChatResponseConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataAccessor

        /// <summary>
        /// Retrieves information about a specified data accessor. This operation returns details
        /// about the data accessor, including its display name, unique identifier, Amazon Resource
        /// Name (ARN), the associated Amazon Q Business application and IAM Identity Center application,
        /// the IAM role for the ISV, the action configurations, and the timestamps for when the
        /// data accessor was created and last updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAccessor service method.</param>
        /// 
        /// <returns>The response from the GetDataAccessor service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataAccessor">REST API Reference for GetDataAccessor Operation</seealso>
        public virtual GetDataAccessorResponse GetDataAccessor(GetDataAccessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataAccessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataAccessorResponseUnmarshaller.Instance;

            return Invoke<GetDataAccessorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataAccessor operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataAccessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataAccessor">REST API Reference for GetDataAccessor Operation</seealso>
        public virtual IAsyncResult BeginGetDataAccessor(GetDataAccessorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataAccessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataAccessorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataAccessor.</param>
        /// 
        /// <returns>Returns a  GetDataAccessorResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataAccessor">REST API Reference for GetDataAccessor Operation</seealso>
        public virtual GetDataAccessorResponse EndGetDataAccessor(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataAccessorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataSource

        /// <summary>
        /// Gets information about an existing Amazon Q Business data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual IAsyncResult BeginGetDataSource(GetDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSource.</param>
        /// 
        /// <returns>Returns a  GetDataSourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse EndGetDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentContent

        /// <summary>
        /// Retrieves the content of a document that was ingested into Amazon Q Business. This
        /// API validates user authorization against document ACLs before returning a pre-signed
        /// URL for secure document access. You can download or view source documents referenced
        /// in chat responses through the URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentContent service method.</param>
        /// 
        /// <returns>The response from the GetDocumentContent service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDocumentContent">REST API Reference for GetDocumentContent Operation</seealso>
        public virtual GetDocumentContentResponse GetDocumentContent(GetDocumentContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentContentResponseUnmarshaller.Instance;

            return Invoke<GetDocumentContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentContent operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDocumentContent">REST API Reference for GetDocumentContent Operation</seealso>
        public virtual IAsyncResult BeginGetDocumentContent(GetDocumentContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentContent.</param>
        /// 
        /// <returns>Returns a  GetDocumentContentResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDocumentContent">REST API Reference for GetDocumentContent Operation</seealso>
        public virtual GetDocumentContentResponse EndGetDocumentContent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentContentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroup

        /// <summary>
        /// Describes a group by group name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse EndGetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIndex

        /// <summary>
        /// Gets information about an existing Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndex service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetIndex">REST API Reference for GetIndex Operation</seealso>
        public virtual GetIndexResponse GetIndex(GetIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexResponseUnmarshaller.Instance;

            return Invoke<GetIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIndex operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetIndex">REST API Reference for GetIndex Operation</seealso>
        public virtual IAsyncResult BeginGetIndex(GetIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIndex.</param>
        /// 
        /// <returns>Returns a  GetIndexResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetIndex">REST API Reference for GetIndex Operation</seealso>
        public virtual GetIndexResponse EndGetIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMedia

        /// <summary>
        /// Returns the image bytes corresponding to a media object. If you have implemented your
        /// own application with the Chat and ChatSync APIs, and have enabled content extraction
        /// from visual data in Amazon Q Business, you use the GetMedia API operation to download
        /// the images so you can show them in your UI with responses.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/extracting-meaning-from-images.html">Extracting
        /// semantic meaning from images and visuals</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedia service method.</param>
        /// 
        /// <returns>The response from the GetMedia service method, as returned by QBusiness.</returns>
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
        /// <exception cref="Amazon.QBusiness.Model.MediaTooLargeException">
        /// The requested media object is too large to be returned.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetMedia">REST API Reference for GetMedia Operation</seealso>
        public virtual GetMediaResponse GetMedia(GetMediaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaResponseUnmarshaller.Instance;

            return Invoke<GetMediaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMedia operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMedia
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetMedia">REST API Reference for GetMedia Operation</seealso>
        public virtual IAsyncResult BeginGetMedia(GetMediaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMedia operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMedia.</param>
        /// 
        /// <returns>Returns a  GetMediaResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetMedia">REST API Reference for GetMedia Operation</seealso>
        public virtual GetMediaResponse EndGetMedia(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMediaResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlugin

        /// <summary>
        /// Gets information about an existing Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlugin service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPlugin">REST API Reference for GetPlugin Operation</seealso>
        public virtual GetPluginResponse GetPlugin(GetPluginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPluginResponseUnmarshaller.Instance;

            return Invoke<GetPluginResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlugin operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPlugin">REST API Reference for GetPlugin Operation</seealso>
        public virtual IAsyncResult BeginGetPlugin(GetPluginRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPluginResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlugin.</param>
        /// 
        /// <returns>Returns a  GetPluginResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPlugin">REST API Reference for GetPlugin Operation</seealso>
        public virtual GetPluginResponse EndGetPlugin(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPluginResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPolicy

        /// <summary>
        /// Retrieves the current permission policy for a Amazon Q Business application. The policy
        /// is returned as a JSON-formatted string and defines the IAM actions that are allowed
        /// or denied for the application's resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRetriever

        /// <summary>
        /// Gets information about an existing retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRetriever service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetRetriever">REST API Reference for GetRetriever Operation</seealso>
        public virtual GetRetrieverResponse GetRetriever(GetRetrieverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRetrieverResponseUnmarshaller.Instance;

            return Invoke<GetRetrieverResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRetriever operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRetriever operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRetriever
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetRetriever">REST API Reference for GetRetriever Operation</seealso>
        public virtual IAsyncResult BeginGetRetriever(GetRetrieverRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRetrieverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRetriever operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRetriever.</param>
        /// 
        /// <returns>Returns a  GetRetrieverResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetRetriever">REST API Reference for GetRetriever Operation</seealso>
        public virtual GetRetrieverResponse EndGetRetriever(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRetrieverResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUser

        /// <summary>
        /// Describes the universally unique identifier (UUID) associated with a local user in
        /// a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual GetUserResponse GetUser(GetUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual GetUserResponse EndGetUser(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWebExperience

        /// <summary>
        /// Gets information about an existing Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebExperience service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetWebExperience">REST API Reference for GetWebExperience Operation</seealso>
        public virtual GetWebExperienceResponse GetWebExperience(GetWebExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebExperienceResponseUnmarshaller.Instance;

            return Invoke<GetWebExperienceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWebExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWebExperience operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWebExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetWebExperience">REST API Reference for GetWebExperience Operation</seealso>
        public virtual IAsyncResult BeginGetWebExperience(GetWebExperienceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebExperienceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWebExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWebExperience.</param>
        /// 
        /// <returns>Returns a  GetWebExperienceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetWebExperience">REST API Reference for GetWebExperience Operation</seealso>
        public virtual GetWebExperienceResponse EndGetWebExperience(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWebExperienceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplications

        /// <summary>
        /// Lists Amazon Q Business applications.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Q Business applications may securely transmit data for processing across Amazon
        /// Web Services Regions within your geography. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/cross-region-inference.html">Cross
        /// region inference in Amazon Q Business</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
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
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse EndListApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttachments

        /// <summary>
        /// Gets a list of attachments associated with an Amazon Q Business web experience or
        /// a list of attachements associated with a specific Amazon Q Business conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachments service method.</param>
        /// 
        /// <returns>The response from the ListAttachments service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        public virtual ListAttachmentsResponse ListAttachments(ListAttachmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachmentsResponseUnmarshaller.Instance;

            return Invoke<ListAttachmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachments operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        public virtual IAsyncResult BeginListAttachments(ListAttachmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachments.</param>
        /// 
        /// <returns>Returns a  ListAttachmentsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        public virtual ListAttachmentsResponse EndListAttachments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttachmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChatResponseConfigurations

        /// <summary>
        /// Retrieves a list of all chat response configurations available in a specified Amazon
        /// Q Business application. This operation returns summary information about each configuration
        /// to help administrators manage and select appropriate response settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChatResponseConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListChatResponseConfigurations service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListChatResponseConfigurations">REST API Reference for ListChatResponseConfigurations Operation</seealso>
        public virtual ListChatResponseConfigurationsResponse ListChatResponseConfigurations(ListChatResponseConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChatResponseConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChatResponseConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListChatResponseConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChatResponseConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChatResponseConfigurations operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChatResponseConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListChatResponseConfigurations">REST API Reference for ListChatResponseConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListChatResponseConfigurations(ListChatResponseConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChatResponseConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChatResponseConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChatResponseConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChatResponseConfigurations.</param>
        /// 
        /// <returns>Returns a  ListChatResponseConfigurationsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListChatResponseConfigurations">REST API Reference for ListChatResponseConfigurations Operation</seealso>
        public virtual ListChatResponseConfigurationsResponse EndListChatResponseConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChatResponseConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConversations

        /// <summary>
        /// Lists one or more Amazon Q Business conversations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConversations service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListConversations">REST API Reference for ListConversations Operation</seealso>
        public virtual ListConversationsResponse ListConversations(ListConversationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConversationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConversationsResponseUnmarshaller.Instance;

            return Invoke<ListConversationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConversations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConversations operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConversations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListConversations">REST API Reference for ListConversations Operation</seealso>
        public virtual IAsyncResult BeginListConversations(ListConversationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConversationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConversationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConversations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConversations.</param>
        /// 
        /// <returns>Returns a  ListConversationsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListConversations">REST API Reference for ListConversations Operation</seealso>
        public virtual ListConversationsResponse EndListConversations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConversationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataAccessors

        /// <summary>
        /// Lists the data accessors for a Amazon Q Business application. This operation returns
        /// a paginated list of data accessor summaries, including the friendly name, unique identifier,
        /// ARN, associated IAM role, and creation/update timestamps for each data accessor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataAccessors service method.</param>
        /// 
        /// <returns>The response from the ListDataAccessors service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataAccessors">REST API Reference for ListDataAccessors Operation</seealso>
        public virtual ListDataAccessorsResponse ListDataAccessors(ListDataAccessorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataAccessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataAccessorsResponseUnmarshaller.Instance;

            return Invoke<ListDataAccessorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataAccessors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataAccessors operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataAccessors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataAccessors">REST API Reference for ListDataAccessors Operation</seealso>
        public virtual IAsyncResult BeginListDataAccessors(ListDataAccessorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataAccessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataAccessorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataAccessors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataAccessors.</param>
        /// 
        /// <returns>Returns a  ListDataAccessorsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataAccessors">REST API Reference for ListDataAccessors Operation</seealso>
        public virtual ListDataAccessorsResponse EndListDataAccessors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataAccessorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSources

        /// <summary>
        /// Lists the Amazon Q Business data source connectors that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual IAsyncResult BeginListDataSources(ListDataSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSources.</param>
        /// 
        /// <returns>Returns a  ListDataSourcesResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse EndListDataSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSourceSyncJobs

        /// <summary>
        /// Get information about an Amazon Q Business data source connector synchronization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs service method.</param>
        /// 
        /// <returns>The response from the ListDataSourceSyncJobs service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        public virtual ListDataSourceSyncJobsResponse ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceSyncJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceSyncJobsResponseUnmarshaller.Instance;

            return Invoke<ListDataSourceSyncJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSourceSyncJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSourceSyncJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        public virtual IAsyncResult BeginListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourceSyncJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceSyncJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSourceSyncJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSourceSyncJobs.</param>
        /// 
        /// <returns>Returns a  ListDataSourceSyncJobsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        public virtual ListDataSourceSyncJobsResponse EndListDataSourceSyncJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSourceSyncJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDocuments

        /// <summary>
        /// A list of documents attached to an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public virtual ListDocumentsResponse ListDocuments(ListDocumentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDocuments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public virtual IAsyncResult BeginListDocuments(ListDocumentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocuments.</param>
        /// 
        /// <returns>Returns a  ListDocumentsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public virtual ListDocumentsResponse EndListDocuments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDocumentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Provides a list of groups that are mapped to users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIndices

        /// <summary>
        /// Lists the Amazon Q Business indices you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListIndices">REST API Reference for ListIndices Operation</seealso>
        public virtual ListIndicesResponse ListIndices(ListIndicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;

            return Invoke<ListIndicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIndices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndices operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIndices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListIndices">REST API Reference for ListIndices Operation</seealso>
        public virtual IAsyncResult BeginListIndices(ListIndicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIndices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIndices.</param>
        /// 
        /// <returns>Returns a  ListIndicesResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListIndices">REST API Reference for ListIndices Operation</seealso>
        public virtual ListIndicesResponse EndListIndices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIndicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMessages

        /// <summary>
        /// Gets a list of messages associated with an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessages service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListMessages">REST API Reference for ListMessages Operation</seealso>
        public virtual ListMessagesResponse ListMessages(ListMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessagesResponseUnmarshaller.Instance;

            return Invoke<ListMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMessages operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListMessages">REST API Reference for ListMessages Operation</seealso>
        public virtual IAsyncResult BeginListMessages(ListMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMessages.</param>
        /// 
        /// <returns>Returns a  ListMessagesResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListMessages">REST API Reference for ListMessages Operation</seealso>
        public virtual ListMessagesResponse EndListMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPluginActions

        /// <summary>
        /// Lists configured Amazon Q Business actions for a specific plugin in an Amazon Q Business
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPluginActions service method.</param>
        /// 
        /// <returns>The response from the ListPluginActions service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginActions">REST API Reference for ListPluginActions Operation</seealso>
        public virtual ListPluginActionsResponse ListPluginActions(ListPluginActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPluginActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginActionsResponseUnmarshaller.Instance;

            return Invoke<ListPluginActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPluginActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPluginActions operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPluginActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginActions">REST API Reference for ListPluginActions Operation</seealso>
        public virtual IAsyncResult BeginListPluginActions(ListPluginActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPluginActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPluginActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPluginActions.</param>
        /// 
        /// <returns>Returns a  ListPluginActionsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginActions">REST API Reference for ListPluginActions Operation</seealso>
        public virtual ListPluginActionsResponse EndListPluginActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPluginActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPlugins

        /// <summary>
        /// Lists configured Amazon Q Business plugins.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlugins service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        public virtual ListPluginsResponse ListPlugins(ListPluginsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPluginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginsResponseUnmarshaller.Instance;

            return Invoke<ListPluginsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlugins operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlugins operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlugins
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        public virtual IAsyncResult BeginListPlugins(ListPluginsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPluginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlugins operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlugins.</param>
        /// 
        /// <returns>Returns a  ListPluginsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        public virtual ListPluginsResponse EndListPlugins(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPluginsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPluginTypeActions

        /// <summary>
        /// Lists configured Amazon Q Business actions for any plugin type—both built-in and custom.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPluginTypeActions service method.</param>
        /// 
        /// <returns>The response from the ListPluginTypeActions service method, as returned by QBusiness.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeActions">REST API Reference for ListPluginTypeActions Operation</seealso>
        public virtual ListPluginTypeActionsResponse ListPluginTypeActions(ListPluginTypeActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPluginTypeActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginTypeActionsResponseUnmarshaller.Instance;

            return Invoke<ListPluginTypeActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPluginTypeActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPluginTypeActions operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPluginTypeActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeActions">REST API Reference for ListPluginTypeActions Operation</seealso>
        public virtual IAsyncResult BeginListPluginTypeActions(ListPluginTypeActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPluginTypeActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginTypeActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPluginTypeActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPluginTypeActions.</param>
        /// 
        /// <returns>Returns a  ListPluginTypeActionsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeActions">REST API Reference for ListPluginTypeActions Operation</seealso>
        public virtual ListPluginTypeActionsResponse EndListPluginTypeActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPluginTypeActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPluginTypeMetadata

        /// <summary>
        /// Lists metadata for all Amazon Q Business plugin types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPluginTypeMetadata service method.</param>
        /// 
        /// <returns>The response from the ListPluginTypeMetadata service method, as returned by QBusiness.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeMetadata">REST API Reference for ListPluginTypeMetadata Operation</seealso>
        public virtual ListPluginTypeMetadataResponse ListPluginTypeMetadata(ListPluginTypeMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPluginTypeMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginTypeMetadataResponseUnmarshaller.Instance;

            return Invoke<ListPluginTypeMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPluginTypeMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPluginTypeMetadata operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPluginTypeMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeMetadata">REST API Reference for ListPluginTypeMetadata Operation</seealso>
        public virtual IAsyncResult BeginListPluginTypeMetadata(ListPluginTypeMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPluginTypeMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPluginTypeMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPluginTypeMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPluginTypeMetadata.</param>
        /// 
        /// <returns>Returns a  ListPluginTypeMetadataResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeMetadata">REST API Reference for ListPluginTypeMetadata Operation</seealso>
        public virtual ListPluginTypeMetadataResponse EndListPluginTypeMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPluginTypeMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRetrievers

        /// <summary>
        /// Lists the retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetrievers service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListRetrievers">REST API Reference for ListRetrievers Operation</seealso>
        public virtual ListRetrieversResponse ListRetrievers(ListRetrieversRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetrieversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetrieversResponseUnmarshaller.Instance;

            return Invoke<ListRetrieversResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRetrievers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRetrievers operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRetrievers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListRetrievers">REST API Reference for ListRetrievers Operation</seealso>
        public virtual IAsyncResult BeginListRetrievers(ListRetrieversRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetrieversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetrieversResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRetrievers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRetrievers.</param>
        /// 
        /// <returns>Returns a  ListRetrieversResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListRetrievers">REST API Reference for ListRetrievers Operation</seealso>
        public virtual ListRetrieversResponse EndListRetrievers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRetrieversResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSubscriptions

        /// <summary>
        /// Lists all subscriptions created in an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginListSubscriptions(ListSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual ListSubscriptionsResponse EndListSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Gets a list of tags associated with a specified resource. Amazon Q Business applications
        /// and data sources can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWebExperiences

        /// <summary>
        /// Lists one or more Amazon Q Business Web Experiences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebExperiences service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListWebExperiences">REST API Reference for ListWebExperiences Operation</seealso>
        public virtual ListWebExperiencesResponse ListWebExperiences(ListWebExperiencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebExperiencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebExperiencesResponseUnmarshaller.Instance;

            return Invoke<ListWebExperiencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWebExperiences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebExperiences operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWebExperiences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListWebExperiences">REST API Reference for ListWebExperiences Operation</seealso>
        public virtual IAsyncResult BeginListWebExperiences(ListWebExperiencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebExperiencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebExperiencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWebExperiences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWebExperiences.</param>
        /// 
        /// <returns>Returns a  ListWebExperiencesResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListWebExperiences">REST API Reference for ListWebExperiences Operation</seealso>
        public virtual ListWebExperiencesResponse EndListWebExperiences(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWebExperiencesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutFeedback

        /// <summary>
        /// Enables your end user to provide feedback on their Amazon Q Business generated chat
        /// responses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual PutFeedbackResponse PutFeedback(PutFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual IAsyncResult BeginPutFeedback(PutFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFeedback.</param>
        /// 
        /// <returns>Returns a  PutFeedbackResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual PutFeedbackResponse EndPutFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<PutFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  PutGroup

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
        ///  
        /// <para>
        /// There are two options for creating groups, either passing group members inline or
        /// using an S3 file via the S3PathForGroupMembers field. For inline groups, there is
        /// a limit of 1000 members per group and for provided S3 files there is a limit of 100
        /// thousand members. When creating a group using an S3 file, you provide both an S3 file
        /// and a <c>RoleArn</c> for Amazon Q Buisness to access the file.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroup service method.</param>
        /// 
        /// <returns>The response from the PutGroup service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual PutGroupResponse PutGroup(PutGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupResponseUnmarshaller.Instance;

            return Invoke<PutGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroup operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutGroup">REST API Reference for PutGroup Operation</seealso>
        public virtual IAsyncResult BeginPutGroup(PutGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGroup.</param>
        /// 
        /// <returns>Returns a  PutGroupResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutGroup">REST API Reference for PutGroup Operation</seealso>
        public virtual PutGroupResponse EndPutGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<PutGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchRelevantContent

        /// <summary>
        /// Searches for relevant content in a Amazon Q Business application based on a query.
        /// This operation takes a search query text, the Amazon Q Business application identifier,
        /// and optional filters (such as content source and maximum results) as input. It returns
        /// a list of relevant content items, where each item includes the content text, the unique
        /// document identifier, the document title, the document URI, any relevant document attributes,
        /// and score attributes indicating the confidence level of the relevance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRelevantContent service method.</param>
        /// 
        /// <returns>The response from the SearchRelevantContent service method, as returned by QBusiness.</returns>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/SearchRelevantContent">REST API Reference for SearchRelevantContent Operation</seealso>
        public virtual SearchRelevantContentResponse SearchRelevantContent(SearchRelevantContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRelevantContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRelevantContentResponseUnmarshaller.Instance;

            return Invoke<SearchRelevantContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchRelevantContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchRelevantContent operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchRelevantContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/SearchRelevantContent">REST API Reference for SearchRelevantContent Operation</seealso>
        public virtual IAsyncResult BeginSearchRelevantContent(SearchRelevantContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRelevantContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRelevantContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchRelevantContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchRelevantContent.</param>
        /// 
        /// <returns>Returns a  SearchRelevantContentResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/SearchRelevantContent">REST API Reference for SearchRelevantContent Operation</seealso>
        public virtual SearchRelevantContentResponse EndSearchRelevantContent(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchRelevantContentResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDataSourceSyncJob

        /// <summary>
        /// Starts a data source connector synchronization job. If a synchronization job is already
        /// in progress, Amazon Q Business returns a <c>ConflictException</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob service method.</param>
        /// 
        /// <returns>The response from the StartDataSourceSyncJob service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual StartDataSourceSyncJobResponse StartDataSourceSyncJob(StartDataSourceSyncJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceSyncJobResponseUnmarshaller.Instance;

            return Invoke<StartDataSourceSyncJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataSourceSyncJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        public virtual IAsyncResult BeginStartDataSourceSyncJob(StartDataSourceSyncJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceSyncJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataSourceSyncJob.</param>
        /// 
        /// <returns>Returns a  StartDataSourceSyncJobResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        public virtual StartDataSourceSyncJobResponse EndStartDataSourceSyncJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDataSourceSyncJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDataSourceSyncJob

        /// <summary>
        /// Stops an Amazon Q Business data source connector synchronization job already in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob service method.</param>
        /// 
        /// <returns>The response from the StopDataSourceSyncJob service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        public virtual StopDataSourceSyncJobResponse StopDataSourceSyncJob(StopDataSourceSyncJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataSourceSyncJobResponseUnmarshaller.Instance;

            return Invoke<StopDataSourceSyncJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDataSourceSyncJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        public virtual IAsyncResult BeginStopDataSourceSyncJob(StopDataSourceSyncJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDataSourceSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataSourceSyncJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDataSourceSyncJob.</param>
        /// 
        /// <returns>Returns a  StopDataSourceSyncJobResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        public virtual StopDataSourceSyncJobResponse EndStopDataSourceSyncJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDataSourceSyncJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds the specified tag to the specified Amazon Q Business application or data source
        /// resource. If the tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from an Amazon Q Business application or a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplication

        /// <summary>
        /// Updates an existing Amazon Q Business application.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Q Business applications may securely transmit data for processing across Amazon
        /// Web Services Regions within your geography. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/cross-region-inference.html">Cross
        /// region inference in Amazon Q Business</a>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// An Amazon Q Apps service-linked role will be created if it's absent in the Amazon
        /// Web Services account when <c>QAppsConfiguration</c> is enabled in the request. For
        /// more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/using-service-linked-roles-qapps.html">Using
        /// service-linked roles for Q Apps</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChatControlsConfiguration

        /// <summary>
        /// Updates a set of chat controls configured for an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatControlsConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateChatControlsConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual UpdateChatControlsConfigurationResponse UpdateChatControlsConfiguration(UpdateChatControlsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChatControlsConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateChatControlsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatControlsConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChatControlsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatControlsConfiguration">REST API Reference for UpdateChatControlsConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateChatControlsConfiguration(UpdateChatControlsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChatControlsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChatControlsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChatControlsConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateChatControlsConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatControlsConfiguration">REST API Reference for UpdateChatControlsConfiguration Operation</seealso>
        public virtual UpdateChatControlsConfigurationResponse EndUpdateChatControlsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChatControlsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChatResponseConfiguration

        /// <summary>
        /// Updates an existing chat response configuration in an Amazon Q Business application.
        /// This operation allows administrators to modify configuration settings, display name,
        /// and response parameters to refine how the system generates responses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatResponseConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateChatResponseConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatResponseConfiguration">REST API Reference for UpdateChatResponseConfiguration Operation</seealso>
        public virtual UpdateChatResponseConfigurationResponse UpdateChatResponseConfiguration(UpdateChatResponseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChatResponseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChatResponseConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateChatResponseConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatResponseConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChatResponseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatResponseConfiguration">REST API Reference for UpdateChatResponseConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateChatResponseConfiguration(UpdateChatResponseConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChatResponseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChatResponseConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChatResponseConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateChatResponseConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatResponseConfiguration">REST API Reference for UpdateChatResponseConfiguration Operation</seealso>
        public virtual UpdateChatResponseConfigurationResponse EndUpdateChatResponseConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChatResponseConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataAccessor

        /// <summary>
        /// Updates an existing data accessor. This operation allows modifying the action configurations
        /// (the allowed actions and associated filters) and the display name of the data accessor.
        /// It does not allow changing the IAM role associated with the data accessor or other
        /// core properties of the data accessor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAccessor service method.</param>
        /// 
        /// <returns>The response from the UpdateDataAccessor service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataAccessor">REST API Reference for UpdateDataAccessor Operation</seealso>
        public virtual UpdateDataAccessorResponse UpdateDataAccessor(UpdateDataAccessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataAccessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataAccessorResponseUnmarshaller.Instance;

            return Invoke<UpdateDataAccessorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAccessor operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataAccessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataAccessor">REST API Reference for UpdateDataAccessor Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataAccessor(UpdateDataAccessorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataAccessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataAccessorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataAccessor.</param>
        /// 
        /// <returns>Returns a  UpdateDataAccessorResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataAccessor">REST API Reference for UpdateDataAccessor Operation</seealso>
        public virtual UpdateDataAccessorResponse EndUpdateDataAccessor(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataAccessorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSource

        /// <summary>
        /// Updates an existing Amazon Q Business data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIndex

        /// <summary>
        /// Updates an Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex service method.</param>
        /// 
        /// <returns>The response from the UpdateIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual UpdateIndexResponse UpdateIndex(UpdateIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexResponseUnmarshaller.Instance;

            return Invoke<UpdateIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        public virtual IAsyncResult BeginUpdateIndex(UpdateIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIndex.</param>
        /// 
        /// <returns>Returns a  UpdateIndexResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        public virtual UpdateIndexResponse EndUpdateIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePlugin

        /// <summary>
        /// Updates an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlugin service method.</param>
        /// 
        /// <returns>The response from the UpdatePlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual UpdatePluginResponse UpdatePlugin(UpdatePluginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePluginResponseUnmarshaller.Instance;

            return Invoke<UpdatePluginResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlugin operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdatePlugin">REST API Reference for UpdatePlugin Operation</seealso>
        public virtual IAsyncResult BeginUpdatePlugin(UpdatePluginRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePluginResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePlugin.</param>
        /// 
        /// <returns>Returns a  UpdatePluginResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdatePlugin">REST API Reference for UpdatePlugin Operation</seealso>
        public virtual UpdatePluginResponse EndUpdatePlugin(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePluginResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRetriever

        /// <summary>
        /// Updates the retriever used for your Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRetriever service method.</param>
        /// 
        /// <returns>The response from the UpdateRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual UpdateRetrieverResponse UpdateRetriever(UpdateRetrieverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRetrieverResponseUnmarshaller.Instance;

            return Invoke<UpdateRetrieverResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRetriever operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRetriever operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRetriever
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateRetriever">REST API Reference for UpdateRetriever Operation</seealso>
        public virtual IAsyncResult BeginUpdateRetriever(UpdateRetrieverRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRetrieverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRetrieverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRetriever operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRetriever.</param>
        /// 
        /// <returns>Returns a  UpdateRetrieverResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateRetriever">REST API Reference for UpdateRetriever Operation</seealso>
        public virtual UpdateRetrieverResponse EndUpdateRetriever(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRetrieverResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSubscription

        /// <summary>
        /// Updates the pricing tier for an Amazon Q Business subscription. Upgrades are instant.
        /// Downgrades apply at the start of the next month. Subscription tier determines feature
        /// access for the user. For more information on subscriptions and pricing tiers, see
        /// <a href="https://aws.amazon.com/q/business/pricing/">Amazon Q Business pricing</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscription service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        public virtual UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubscription(UpdateSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscription.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriptionResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        public virtual UpdateSubscriptionResponse EndUpdateSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUser

        /// <summary>
        /// Updates a information associated with a user id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
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
        public virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWebExperience

        /// <summary>
        /// Updates an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebExperience service method.</param>
        /// 
        /// <returns>The response from the UpdateWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateWebExperience">REST API Reference for UpdateWebExperience Operation</seealso>
        public virtual UpdateWebExperienceResponse UpdateWebExperience(UpdateWebExperienceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebExperienceResponseUnmarshaller.Instance;

            return Invoke<UpdateWebExperienceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWebExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebExperience operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWebExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateWebExperience">REST API Reference for UpdateWebExperience Operation</seealso>
        public virtual IAsyncResult BeginUpdateWebExperience(UpdateWebExperienceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebExperienceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebExperienceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWebExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWebExperience.</param>
        /// 
        /// <returns>Returns a  UpdateWebExperienceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateWebExperience">REST API Reference for UpdateWebExperience Operation</seealso>
        public virtual UpdateWebExperienceResponse EndUpdateWebExperience(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWebExperienceResponse>(asyncResult);
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
            var resolver = new AmazonQBusinessEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}