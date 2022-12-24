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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Transfer.Model;
using Amazon.Transfer.Model.Internal.MarshallTransformations;
using Amazon.Transfer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Transfer
{
    /// <summary>
    /// Implementation for accessing Transfer
    ///
    /// Transfer Family is a fully managed service that enables the transfer of files over
    /// the File Transfer Protocol (FTP), File Transfer Protocol over SSL (FTPS), or Secure
    /// Shell (SSH) File Transfer Protocol (SFTP) directly into and out of Amazon Simple Storage
    /// Service (Amazon S3) or Amazon EFS. Additionally, you can use Applicability Statement
    /// 2 (AS2) to transfer files into and out of Amazon S3. Amazon Web Services helps you
    /// seamlessly migrate your file transfer workflows to Transfer Family by integrating
    /// with existing authentication systems, and providing DNS routing with Amazon Route
    /// 53 so nothing changes for your customers and partners, or their applications. With
    /// your data in Amazon S3, you can use it with Amazon Web Services for processing, analytics,
    /// machine learning, and archiving. Getting started with Transfer Family is easy since
    /// there is no infrastructure to buy and set up.
    /// </summary>
    public partial class AmazonTransferClient : AmazonServiceClient, IAmazonTransfer
    {
        private static IServiceMetadata serviceMetadata = new AmazonTransferMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ITransferPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITransferPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TransferPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonTransferClient with the credentials loaded from the application's
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
        public AmazonTransferClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTransferConfig()) { }

        /// <summary>
        /// Constructs AmazonTransferClient with the credentials loaded from the application's
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
        public AmazonTransferClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTransferConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTransferClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTransferClient Configuration Object</param>
        public AmazonTransferClient(AmazonTransferConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonTransferClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTransferClient(AWSCredentials credentials)
            : this(credentials, new AmazonTransferConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTransferClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTransferClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTransferConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTransferClient with AWS Credentials and an
        /// AmazonTransferClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTransferClient Configuration Object</param>
        public AmazonTransferClient(AWSCredentials credentials, AmazonTransferConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTransferClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTransferClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTransferConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTransferClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTransferClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTransferConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTransferClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTransferClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTransferClient Configuration Object</param>
        public AmazonTransferClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTransferConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTransferClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTransferClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTransferConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTransferClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTransferClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTransferConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTransferClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTransferClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTransferClient Configuration Object</param>
        public AmazonTransferClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTransferConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTransferEndpointResolver());
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


        #region  CreateAccess

        /// <summary>
        /// Used by administrators to choose which groups in the directory should have access
        /// to upload and download files over the enabled protocols using Transfer Family. For
        /// example, a Microsoft Active Directory might contain 50,000 users, but only a small
        /// fraction might need the ability to transfer files to the server. An administrator
        /// can use <code>CreateAccess</code> to limit the access to the correct set of users
        /// who need this ability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccess service method.</param>
        /// 
        /// <returns>The response from the CreateAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateAccess">REST API Reference for CreateAccess Operation</seealso>
        public virtual CreateAccessResponse CreateAccess(CreateAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessResponseUnmarshaller.Instance;

            return Invoke<CreateAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccess operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateAccess">REST API Reference for CreateAccess Operation</seealso>
        public virtual IAsyncResult BeginCreateAccess(CreateAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccess.</param>
        /// 
        /// <returns>Returns a  CreateAccessResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateAccess">REST API Reference for CreateAccess Operation</seealso>
        public virtual CreateAccessResponse EndCreateAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAgreement

        /// <summary>
        /// Creates an agreement. An agreement is a bilateral trading partner agreement, or partnership,
        /// between an Transfer Family server and an AS2 process. The agreement defines the file
        /// and message transfer relationship between the server and the AS2 process. To define
        /// an agreement, Transfer Family combines a server, local profile, partner profile, certificate,
        /// and other attributes.
        /// 
        ///  
        /// <para>
        /// The partner is identified with the <code>PartnerProfileId</code>, and the AS2 process
        /// is identified with the <code>LocalProfileId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgreement service method.</param>
        /// 
        /// <returns>The response from the CreateAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateAgreement">REST API Reference for CreateAgreement Operation</seealso>
        public virtual CreateAgreementResponse CreateAgreement(CreateAgreementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgreementResponseUnmarshaller.Instance;

            return Invoke<CreateAgreementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAgreement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgreement operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgreement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateAgreement">REST API Reference for CreateAgreement Operation</seealso>
        public virtual IAsyncResult BeginCreateAgreement(CreateAgreementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgreementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgreement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgreement.</param>
        /// 
        /// <returns>Returns a  CreateAgreementResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateAgreement">REST API Reference for CreateAgreement Operation</seealso>
        public virtual CreateAgreementResponse EndCreateAgreement(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAgreementResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnector

        /// <summary>
        /// Creates the connector, which captures the parameters for an outbound connection for
        /// the AS2 protocol. The connector is required for sending files to an externally hosted
        /// AS2 server. For more details about connectors, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/create-b2b-server.html#configure-as2-connector">Create
        /// AS2 connectors</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual CreateConnectorResponse CreateConnector(CreateConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual IAsyncResult BeginCreateConnector(CreateConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnector.</param>
        /// 
        /// <returns>Returns a  CreateConnectorResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual CreateConnectorResponse EndCreateConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProfile

        /// <summary>
        /// Creates the local or partner profile to use for AS2 transfers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateProfile(CreateProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProfile.</param>
        /// 
        /// <returns>Returns a  CreateProfileResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual CreateProfileResponse EndCreateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateServer

        /// <summary>
        /// Instantiates an auto-scaling virtual server based on the selected file transfer protocol
        /// in Amazon Web Services. When you make updates to your file transfer protocol-enabled
        /// server or when you work with users, use the service-generated <code>ServerId</code>
        /// property that is assigned to the newly created server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServer service method.</param>
        /// 
        /// <returns>The response from the CreateServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateServer">REST API Reference for CreateServer Operation</seealso>
        public virtual CreateServerResponse CreateServer(CreateServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServerResponseUnmarshaller.Instance;

            return Invoke<CreateServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServer operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateServer">REST API Reference for CreateServer Operation</seealso>
        public virtual IAsyncResult BeginCreateServer(CreateServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServer.</param>
        /// 
        /// <returns>Returns a  CreateServerResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateServer">REST API Reference for CreateServer Operation</seealso>
        public virtual CreateServerResponse EndCreateServer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUser

        /// <summary>
        /// Creates a user and associates them with an existing file transfer protocol-enabled
        /// server. You can only create and associate users with servers that have the <code>IdentityProviderType</code>
        /// set to <code>SERVICE_MANAGED</code>. Using parameters for <code>CreateUser</code>,
        /// you can specify the user name, set the home directory, store the user's public key,
        /// and assign the user's Identity and Access Management (IAM) role. You can also optionally
        /// add a session policy, and assign metadata with tags that can be used to group and
        /// search for users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateUser">REST API Reference for CreateUser Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateUser">REST API Reference for CreateUser Operation</seealso>
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
        /// <returns>Returns a  CreateUserResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkflow

        /// <summary>
        /// Allows you to create a workflow with specified steps and step details the workflow
        /// invokes after file transfer completes. After creating a workflow, you can associate
        /// the workflow created with any transfer servers by specifying the <code>workflow-details</code>
        /// field in <code>CreateServer</code> and <code>UpdateServer</code> operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkflow(CreateWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual CreateWorkflowResponse EndCreateWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccess

        /// <summary>
        /// Allows you to delete the access specified in the <code>ServerID</code> and <code>ExternalID</code>
        /// parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccess service method.</param>
        /// 
        /// <returns>The response from the DeleteAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteAccess">REST API Reference for DeleteAccess Operation</seealso>
        public virtual DeleteAccessResponse DeleteAccess(DeleteAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccess operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteAccess">REST API Reference for DeleteAccess Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccess(DeleteAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccess.</param>
        /// 
        /// <returns>Returns a  DeleteAccessResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteAccess">REST API Reference for DeleteAccess Operation</seealso>
        public virtual DeleteAccessResponse EndDeleteAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAgreement

        /// <summary>
        /// Delete the agreement that's specified in the provided <code>AgreementId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgreement service method.</param>
        /// 
        /// <returns>The response from the DeleteAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteAgreement">REST API Reference for DeleteAgreement Operation</seealso>
        public virtual DeleteAgreementResponse DeleteAgreement(DeleteAgreementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgreementResponseUnmarshaller.Instance;

            return Invoke<DeleteAgreementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgreement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgreement operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgreement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteAgreement">REST API Reference for DeleteAgreement Operation</seealso>
        public virtual IAsyncResult BeginDeleteAgreement(DeleteAgreementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgreementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgreement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgreement.</param>
        /// 
        /// <returns>Returns a  DeleteAgreementResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteAgreement">REST API Reference for DeleteAgreement Operation</seealso>
        public virtual DeleteAgreementResponse EndDeleteAgreement(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAgreementResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCertificate

        /// <summary>
        /// Deletes the certificate that's specified in the <code>CertificateId</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual IAsyncResult BeginDeleteCertificate(DeleteCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteCertificateResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual DeleteCertificateResponse EndDeleteCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnector

        /// <summary>
        /// Deletes the agreement that's specified in the provided <code>ConnectorId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual DeleteConnectorResponse DeleteConnector(DeleteConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnector(DeleteConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnector.</param>
        /// 
        /// <returns>Returns a  DeleteConnectorResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual DeleteConnectorResponse EndDeleteConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteHostKey

        /// <summary>
        /// Deletes the host key that's specified in the <code>HoskKeyId</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostKey service method.</param>
        /// 
        /// <returns>The response from the DeleteHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteHostKey">REST API Reference for DeleteHostKey Operation</seealso>
        public virtual DeleteHostKeyResponse DeleteHostKey(DeleteHostKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHostKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHostKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteHostKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostKey operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHostKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteHostKey">REST API Reference for DeleteHostKey Operation</seealso>
        public virtual IAsyncResult BeginDeleteHostKey(DeleteHostKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHostKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHostKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHostKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHostKey.</param>
        /// 
        /// <returns>Returns a  DeleteHostKeyResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteHostKey">REST API Reference for DeleteHostKey Operation</seealso>
        public virtual DeleteHostKeyResponse EndDeleteHostKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteHostKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProfile

        /// <summary>
        /// Deletes the profile that's specified in the <code>ProfileId</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteProfile(DeleteProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfile.</param>
        /// 
        /// <returns>Returns a  DeleteProfileResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual DeleteProfileResponse EndDeleteProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServer

        /// <summary>
        /// Deletes the file transfer protocol-enabled server that you specify.
        /// 
        ///  
        /// <para>
        /// No response returns from this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer service method.</param>
        /// 
        /// <returns>The response from the DeleteServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteServer">REST API Reference for DeleteServer Operation</seealso>
        public virtual DeleteServerResponse DeleteServer(DeleteServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerResponseUnmarshaller.Instance;

            return Invoke<DeleteServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteServer">REST API Reference for DeleteServer Operation</seealso>
        public virtual IAsyncResult BeginDeleteServer(DeleteServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServer.</param>
        /// 
        /// <returns>Returns a  DeleteServerResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteServer">REST API Reference for DeleteServer Operation</seealso>
        public virtual DeleteServerResponse EndDeleteServer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSshPublicKey

        /// <summary>
        /// Deletes a user's Secure Shell (SSH) public key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSshPublicKey service method.</param>
        /// 
        /// <returns>The response from the DeleteSshPublicKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteSshPublicKey">REST API Reference for DeleteSshPublicKey Operation</seealso>
        public virtual DeleteSshPublicKeyResponse DeleteSshPublicKey(DeleteSshPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSshPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSshPublicKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteSshPublicKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSshPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSshPublicKey operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSshPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteSshPublicKey">REST API Reference for DeleteSshPublicKey Operation</seealso>
        public virtual IAsyncResult BeginDeleteSshPublicKey(DeleteSshPublicKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSshPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSshPublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSshPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSshPublicKey.</param>
        /// 
        /// <returns>Returns a  DeleteSshPublicKeyResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteSshPublicKey">REST API Reference for DeleteSshPublicKey Operation</seealso>
        public virtual DeleteSshPublicKeyResponse EndDeleteSshPublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSshPublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Deletes the user belonging to a file transfer protocol-enabled server you specify.
        /// 
        ///  
        /// <para>
        /// No response returns from this operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you delete a user from a server, the user's information is lost.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
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
        /// <returns>Returns a  DeleteUserResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkflow

        /// <summary>
        /// Deletes the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkflow(DeleteWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual DeleteWorkflowResponse EndDeleteWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccess

        /// <summary>
        /// Describes the access that is assigned to the specific file transfer protocol-enabled
        /// server, as identified by its <code>ServerId</code> property and its <code>ExternalId</code>.
        /// 
        ///  
        /// <para>
        /// The response from this call returns the properties of the access that is associated
        /// with the <code>ServerId</code> value that was specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccess service method.</param>
        /// 
        /// <returns>The response from the DescribeAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeAccess">REST API Reference for DescribeAccess Operation</seealso>
        public virtual DescribeAccessResponse DescribeAccess(DescribeAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessResponseUnmarshaller.Instance;

            return Invoke<DescribeAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccess operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeAccess">REST API Reference for DescribeAccess Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccess(DescribeAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccess.</param>
        /// 
        /// <returns>Returns a  DescribeAccessResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeAccess">REST API Reference for DescribeAccess Operation</seealso>
        public virtual DescribeAccessResponse EndDescribeAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAgreement

        /// <summary>
        /// Describes the agreement that's identified by the <code>AgreementId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgreement service method.</param>
        /// 
        /// <returns>The response from the DescribeAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeAgreement">REST API Reference for DescribeAgreement Operation</seealso>
        public virtual DescribeAgreementResponse DescribeAgreement(DescribeAgreementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgreementResponseUnmarshaller.Instance;

            return Invoke<DescribeAgreementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgreement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgreement operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAgreement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeAgreement">REST API Reference for DescribeAgreement Operation</seealso>
        public virtual IAsyncResult BeginDescribeAgreement(DescribeAgreementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgreementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAgreement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAgreement.</param>
        /// 
        /// <returns>Returns a  DescribeAgreementResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeAgreement">REST API Reference for DescribeAgreement Operation</seealso>
        public virtual DescribeAgreementResponse EndDescribeAgreement(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAgreementResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCertificate

        /// <summary>
        /// Describes the certificate that's identified by the <code>CertificateId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual IAsyncResult BeginDescribeCertificate(DescribeCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificate.</param>
        /// 
        /// <returns>Returns a  DescribeCertificateResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual DescribeCertificateResponse EndDescribeCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConnector

        /// <summary>
        /// Describes the connector that's identified by the <code>ConnectorId.</code>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector service method.</param>
        /// 
        /// <returns>The response from the DescribeConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        public virtual DescribeConnectorResponse DescribeConnector(DescribeConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        public virtual IAsyncResult BeginDescribeConnector(DescribeConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnector.</param>
        /// 
        /// <returns>Returns a  DescribeConnectorResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        public virtual DescribeConnectorResponse EndDescribeConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExecution

        /// <summary>
        /// You can use <code>DescribeExecution</code> to check the details of the execution of
        /// the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual IAsyncResult BeginDescribeExecution(DescribeExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExecution.</param>
        /// 
        /// <returns>Returns a  DescribeExecutionResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual DescribeExecutionResponse EndDescribeExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHostKey

        /// <summary>
        /// Returns the details of the host key that's specified by the <code>HostKeyId</code>
        /// and <code>ServerId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostKey service method.</param>
        /// 
        /// <returns>The response from the DescribeHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeHostKey">REST API Reference for DescribeHostKey Operation</seealso>
        public virtual DescribeHostKeyResponse DescribeHostKey(DescribeHostKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostKeyResponseUnmarshaller.Instance;

            return Invoke<DescribeHostKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostKey operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHostKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeHostKey">REST API Reference for DescribeHostKey Operation</seealso>
        public virtual IAsyncResult BeginDescribeHostKey(DescribeHostKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHostKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHostKey.</param>
        /// 
        /// <returns>Returns a  DescribeHostKeyResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeHostKey">REST API Reference for DescribeHostKey Operation</seealso>
        public virtual DescribeHostKeyResponse EndDescribeHostKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHostKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProfile

        /// <summary>
        /// Returns the details of the profile that's specified by the <code>ProfileId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeProfile">REST API Reference for DescribeProfile Operation</seealso>
        public virtual DescribeProfileResponse DescribeProfile(DescribeProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfile operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeProfile">REST API Reference for DescribeProfile Operation</seealso>
        public virtual IAsyncResult BeginDescribeProfile(DescribeProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProfile.</param>
        /// 
        /// <returns>Returns a  DescribeProfileResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeProfile">REST API Reference for DescribeProfile Operation</seealso>
        public virtual DescribeProfileResponse EndDescribeProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSecurityPolicy

        /// <summary>
        /// Describes the security policy that is attached to your file transfer protocol-enabled
        /// server. The response contains a description of the security policy's properties. For
        /// more information about security policies, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies.html">Working
        /// with security policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityPolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityPolicy service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeSecurityPolicy">REST API Reference for DescribeSecurityPolicy Operation</seealso>
        public virtual DescribeSecurityPolicyResponse DescribeSecurityPolicy(DescribeSecurityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityPolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityPolicy operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSecurityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeSecurityPolicy">REST API Reference for DescribeSecurityPolicy Operation</seealso>
        public virtual IAsyncResult BeginDescribeSecurityPolicy(DescribeSecurityPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSecurityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityPolicy.</param>
        /// 
        /// <returns>Returns a  DescribeSecurityPolicyResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeSecurityPolicy">REST API Reference for DescribeSecurityPolicy Operation</seealso>
        public virtual DescribeSecurityPolicyResponse EndDescribeSecurityPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSecurityPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeServer

        /// <summary>
        /// Describes a file transfer protocol-enabled server that you specify by passing the
        /// <code>ServerId</code> parameter.
        /// 
        ///  
        /// <para>
        /// The response contains a description of a server's properties. When you set <code>EndpointType</code>
        /// to VPC, the response will contain the <code>EndpointDetails</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServer service method.</param>
        /// 
        /// <returns>The response from the DescribeServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeServer">REST API Reference for DescribeServer Operation</seealso>
        public virtual DescribeServerResponse DescribeServer(DescribeServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServerResponseUnmarshaller.Instance;

            return Invoke<DescribeServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServer operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeServer">REST API Reference for DescribeServer Operation</seealso>
        public virtual IAsyncResult BeginDescribeServer(DescribeServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServer.</param>
        /// 
        /// <returns>Returns a  DescribeServerResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeServer">REST API Reference for DescribeServer Operation</seealso>
        public virtual DescribeServerResponse EndDescribeServer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeServerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUser

        /// <summary>
        /// Describes the user assigned to the specific file transfer protocol-enabled server,
        /// as identified by its <code>ServerId</code> property.
        /// 
        ///  
        /// <para>
        /// The response from this call returns the properties of the user associated with the
        /// <code>ServerId</code> value that was specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
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
        /// <returns>Returns a  DescribeUserResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkflow

        /// <summary>
        /// Describes the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflow service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkflow service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeWorkflow">REST API Reference for DescribeWorkflow Operation</seealso>
        public virtual DescribeWorkflowResponse DescribeWorkflow(DescribeWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkflowResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflow operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeWorkflow">REST API Reference for DescribeWorkflow Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkflow(DescribeWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkflow.</param>
        /// 
        /// <returns>Returns a  DescribeWorkflowResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeWorkflow">REST API Reference for DescribeWorkflow Operation</seealso>
        public virtual DescribeWorkflowResponse EndDescribeWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportCertificate

        /// <summary>
        /// Imports the signing and encryption certificates that you need to create local (AS2)
        /// profiles and partner profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual ImportCertificateResponse ImportCertificate(ImportCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual IAsyncResult BeginImportCertificate(ImportCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCertificate.</param>
        /// 
        /// <returns>Returns a  ImportCertificateResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual ImportCertificateResponse EndImportCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportHostKey

        /// <summary>
        /// Adds a host key to the server that's specified by the <code>ServerId</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportHostKey service method.</param>
        /// 
        /// <returns>The response from the ImportHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportHostKey">REST API Reference for ImportHostKey Operation</seealso>
        public virtual ImportHostKeyResponse ImportHostKey(ImportHostKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportHostKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportHostKeyResponseUnmarshaller.Instance;

            return Invoke<ImportHostKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportHostKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportHostKey operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportHostKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportHostKey">REST API Reference for ImportHostKey Operation</seealso>
        public virtual IAsyncResult BeginImportHostKey(ImportHostKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportHostKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportHostKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportHostKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportHostKey.</param>
        /// 
        /// <returns>Returns a  ImportHostKeyResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportHostKey">REST API Reference for ImportHostKey Operation</seealso>
        public virtual ImportHostKeyResponse EndImportHostKey(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportHostKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportSshPublicKey

        /// <summary>
        /// Adds a Secure Shell (SSH) public key to a user account identified by a <code>UserName</code>
        /// value assigned to the specific file transfer protocol-enabled server, identified by
        /// <code>ServerId</code>.
        /// 
        ///  
        /// <para>
        /// The response returns the <code>UserName</code> value, the <code>ServerId</code> value,
        /// and the name of the <code>SshPublicKeyId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSshPublicKey service method.</param>
        /// 
        /// <returns>The response from the ImportSshPublicKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportSshPublicKey">REST API Reference for ImportSshPublicKey Operation</seealso>
        public virtual ImportSshPublicKeyResponse ImportSshPublicKey(ImportSshPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSshPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSshPublicKeyResponseUnmarshaller.Instance;

            return Invoke<ImportSshPublicKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportSshPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportSshPublicKey operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportSshPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportSshPublicKey">REST API Reference for ImportSshPublicKey Operation</seealso>
        public virtual IAsyncResult BeginImportSshPublicKey(ImportSshPublicKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSshPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSshPublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportSshPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportSshPublicKey.</param>
        /// 
        /// <returns>Returns a  ImportSshPublicKeyResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportSshPublicKey">REST API Reference for ImportSshPublicKey Operation</seealso>
        public virtual ImportSshPublicKeyResponse EndImportSshPublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportSshPublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccesses

        /// <summary>
        /// Lists the details for all the accesses you have on your server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccesses service method.</param>
        /// 
        /// <returns>The response from the ListAccesses service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListAccesses">REST API Reference for ListAccesses Operation</seealso>
        public virtual ListAccessesResponse ListAccesses(ListAccessesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessesResponseUnmarshaller.Instance;

            return Invoke<ListAccessesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccesses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccesses operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccesses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListAccesses">REST API Reference for ListAccesses Operation</seealso>
        public virtual IAsyncResult BeginListAccesses(ListAccessesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccesses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccesses.</param>
        /// 
        /// <returns>Returns a  ListAccessesResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListAccesses">REST API Reference for ListAccesses Operation</seealso>
        public virtual ListAccessesResponse EndListAccesses(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccessesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgreements

        /// <summary>
        /// Returns a list of the agreements for the server that's identified by the <code>ServerId</code>
        /// that you supply. If you want to limit the results to a certain number, supply a value
        /// for the <code>MaxResults</code> parameter. If you ran the command previously and received
        /// a value for <code>NextToken</code>, you can supply that value to continue listing
        /// agreements from where you left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgreements service method.</param>
        /// 
        /// <returns>The response from the ListAgreements service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListAgreements">REST API Reference for ListAgreements Operation</seealso>
        public virtual ListAgreementsResponse ListAgreements(ListAgreementsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgreementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgreementsResponseUnmarshaller.Instance;

            return Invoke<ListAgreementsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgreements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgreements operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgreements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListAgreements">REST API Reference for ListAgreements Operation</seealso>
        public virtual IAsyncResult BeginListAgreements(ListAgreementsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgreementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgreementsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgreements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgreements.</param>
        /// 
        /// <returns>Returns a  ListAgreementsResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListAgreements">REST API Reference for ListAgreements Operation</seealso>
        public virtual ListAgreementsResponse EndListAgreements(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgreementsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCertificates

        /// <summary>
        /// Returns a list of the current certificates that have been imported into Transfer Family.
        /// If you want to limit the results to a certain number, supply a value for the <code>MaxResults</code>
        /// parameter. If you ran the command previously and received a value for the <code>NextToken</code>
        /// parameter, you can supply that value to continue listing certificates from where you
        /// left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual IAsyncResult BeginListCertificates(ListCertificatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCertificates.</param>
        /// 
        /// <returns>Returns a  ListCertificatesResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual ListCertificatesResponse EndListCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConnectors

        /// <summary>
        /// Lists the connectors for the specified Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual ListConnectorsResponse ListConnectors(ListConnectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListConnectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual IAsyncResult BeginListConnectors(ListConnectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectors.</param>
        /// 
        /// <returns>Returns a  ListConnectorsResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual ListConnectorsResponse EndListConnectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConnectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExecutions

        /// <summary>
        /// Lists all executions for the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual IAsyncResult BeginListExecutions(ListExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExecutions.</param>
        /// 
        /// <returns>Returns a  ListExecutionsResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual ListExecutionsResponse EndListExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHostKeys

        /// <summary>
        /// Returns a list of host keys for the server that's specified by the <code>ServerId</code>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostKeys service method.</param>
        /// 
        /// <returns>The response from the ListHostKeys service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListHostKeys">REST API Reference for ListHostKeys Operation</seealso>
        public virtual ListHostKeysResponse ListHostKeys(ListHostKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHostKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostKeysResponseUnmarshaller.Instance;

            return Invoke<ListHostKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostKeys operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHostKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListHostKeys">REST API Reference for ListHostKeys Operation</seealso>
        public virtual IAsyncResult BeginListHostKeys(ListHostKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHostKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHostKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHostKeys.</param>
        /// 
        /// <returns>Returns a  ListHostKeysResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListHostKeys">REST API Reference for ListHostKeys Operation</seealso>
        public virtual ListHostKeysResponse EndListHostKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHostKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProfiles

        /// <summary>
        /// Returns a list of the profiles for your system. If you want to limit the results to
        /// a certain number, supply a value for the <code>MaxResults</code> parameter. If you
        /// ran the command previously and received a value for <code>NextToken</code>, you can
        /// supply that value to continue listing profiles from where you left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual ListProfilesResponse ListProfiles(ListProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return Invoke<ListProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual IAsyncResult BeginListProfiles(ListProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfiles.</param>
        /// 
        /// <returns>Returns a  ListProfilesResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual ListProfilesResponse EndListProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSecurityPolicies

        /// <summary>
        /// Lists the security policies that are attached to your file transfer protocol-enabled
        /// servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityPolicies service method.</param>
        /// 
        /// <returns>The response from the ListSecurityPolicies service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        public virtual ListSecurityPoliciesResponse ListSecurityPolicies(ListSecurityPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListSecurityPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityPolicies operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        public virtual IAsyncResult BeginListSecurityPolicies(ListSecurityPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityPolicies.</param>
        /// 
        /// <returns>Returns a  ListSecurityPoliciesResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        public virtual ListSecurityPoliciesResponse EndListSecurityPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSecurityPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServers

        /// <summary>
        /// Lists the file transfer protocol-enabled servers that are associated with your Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServers service method.</param>
        /// 
        /// <returns>The response from the ListServers service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListServers">REST API Reference for ListServers Operation</seealso>
        public virtual ListServersResponse ListServers(ListServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServersResponseUnmarshaller.Instance;

            return Invoke<ListServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServers operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListServers">REST API Reference for ListServers Operation</seealso>
        public virtual IAsyncResult BeginListServers(ListServersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServers.</param>
        /// 
        /// <returns>Returns a  ListServersResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListServers">REST API Reference for ListServers Operation</seealso>
        public virtual ListServersResponse EndListServers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a user, server, or role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Lists the users for a file transfer protocol-enabled server that you specify by passing
        /// the <code>ServerId</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListUsers">REST API Reference for ListUsers Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListUsers">REST API Reference for ListUsers Operation</seealso>
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
        /// <returns>Returns a  ListUsersResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkflows

        /// <summary>
        /// Lists all of your workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual IAsyncResult BeginListWorkflows(ListWorkflowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflows.</param>
        /// 
        /// <returns>Returns a  ListWorkflowsResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual ListWorkflowsResponse EndListWorkflows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkflowsResponse>(asyncResult);
        }

        #endregion
        
        #region  SendWorkflowStepState

        /// <summary>
        /// Sends a callback for asynchronous custom steps.
        /// 
        ///  
        /// <para>
        ///  The <code>ExecutionId</code>, <code>WorkflowId</code>, and <code>Token</code> are
        /// passed to the target resource during execution of a custom step of a workflow. You
        /// must include those with their callback as well as providing a status. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendWorkflowStepState service method.</param>
        /// 
        /// <returns>The response from the SendWorkflowStepState service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/SendWorkflowStepState">REST API Reference for SendWorkflowStepState Operation</seealso>
        public virtual SendWorkflowStepStateResponse SendWorkflowStepState(SendWorkflowStepStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendWorkflowStepStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendWorkflowStepStateResponseUnmarshaller.Instance;

            return Invoke<SendWorkflowStepStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendWorkflowStepState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendWorkflowStepState operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendWorkflowStepState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/SendWorkflowStepState">REST API Reference for SendWorkflowStepState Operation</seealso>
        public virtual IAsyncResult BeginSendWorkflowStepState(SendWorkflowStepStateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendWorkflowStepStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendWorkflowStepStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendWorkflowStepState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendWorkflowStepState.</param>
        /// 
        /// <returns>Returns a  SendWorkflowStepStateResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/SendWorkflowStepState">REST API Reference for SendWorkflowStepState Operation</seealso>
        public virtual SendWorkflowStepStateResponse EndSendWorkflowStepState(IAsyncResult asyncResult)
        {
            return EndInvoke<SendWorkflowStepStateResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFileTransfer

        /// <summary>
        /// Begins an outbound file transfer to a remote AS2 server. You specify the <code>ConnectorId</code>
        /// and the file paths for where to send the files.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFileTransfer service method.</param>
        /// 
        /// <returns>The response from the StartFileTransfer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartFileTransfer">REST API Reference for StartFileTransfer Operation</seealso>
        public virtual StartFileTransferResponse StartFileTransfer(StartFileTransferRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFileTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFileTransferResponseUnmarshaller.Instance;

            return Invoke<StartFileTransferResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFileTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFileTransfer operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFileTransfer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartFileTransfer">REST API Reference for StartFileTransfer Operation</seealso>
        public virtual IAsyncResult BeginStartFileTransfer(StartFileTransferRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFileTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFileTransferResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFileTransfer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFileTransfer.</param>
        /// 
        /// <returns>Returns a  StartFileTransferResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartFileTransfer">REST API Reference for StartFileTransfer Operation</seealso>
        public virtual StartFileTransferResponse EndStartFileTransfer(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFileTransferResponse>(asyncResult);
        }

        #endregion
        
        #region  StartServer

        /// <summary>
        /// Changes the state of a file transfer protocol-enabled server from <code>OFFLINE</code>
        /// to <code>ONLINE</code>. It has no impact on a server that is already <code>ONLINE</code>.
        /// An <code>ONLINE</code> server can accept and process file transfer jobs.
        /// 
        ///  
        /// <para>
        /// The state of <code>STARTING</code> indicates that the server is in an intermediate
        /// state, either not fully able to respond, or not fully online. The values of <code>START_FAILED</code>
        /// can indicate an error condition.
        /// </para>
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartServer service method.</param>
        /// 
        /// <returns>The response from the StartServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartServer">REST API Reference for StartServer Operation</seealso>
        public virtual StartServerResponse StartServer(StartServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartServerResponseUnmarshaller.Instance;

            return Invoke<StartServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartServer operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartServer">REST API Reference for StartServer Operation</seealso>
        public virtual IAsyncResult BeginStartServer(StartServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartServer.</param>
        /// 
        /// <returns>Returns a  StartServerResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartServer">REST API Reference for StartServer Operation</seealso>
        public virtual StartServerResponse EndStartServer(IAsyncResult asyncResult)
        {
            return EndInvoke<StartServerResponse>(asyncResult);
        }

        #endregion
        
        #region  StopServer

        /// <summary>
        /// Changes the state of a file transfer protocol-enabled server from <code>ONLINE</code>
        /// to <code>OFFLINE</code>. An <code>OFFLINE</code> server cannot accept and process
        /// file transfer jobs. Information tied to your server, such as server and user properties,
        /// are not affected by stopping your server.
        /// 
        ///  <note> 
        /// <para>
        /// Stopping the server does not reduce or impact your file transfer protocol endpoint
        /// billing; you must delete the server to stop being billed.
        /// </para>
        ///  </note> 
        /// <para>
        /// The state of <code>STOPPING</code> indicates that the server is in an intermediate
        /// state, either not fully able to respond, or not fully offline. The values of <code>STOP_FAILED</code>
        /// can indicate an error condition.
        /// </para>
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopServer service method.</param>
        /// 
        /// <returns>The response from the StopServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StopServer">REST API Reference for StopServer Operation</seealso>
        public virtual StopServerResponse StopServer(StopServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopServerResponseUnmarshaller.Instance;

            return Invoke<StopServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopServer operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StopServer">REST API Reference for StopServer Operation</seealso>
        public virtual IAsyncResult BeginStopServer(StopServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopServer.</param>
        /// 
        /// <returns>Returns a  StopServerResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StopServer">REST API Reference for StopServer Operation</seealso>
        public virtual StopServerResponse EndStopServer(IAsyncResult asyncResult)
        {
            return EndInvoke<StopServerResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// 
        ///  
        /// <para>
        /// There is no response returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TestIdentityProvider

        /// <summary>
        /// If the <code>IdentityProviderType</code> of a file transfer protocol-enabled server
        /// is <code>AWS_DIRECTORY_SERVICE</code> or <code>API_Gateway</code>, tests whether your
        /// identity provider is set up successfully. We highly recommend that you call this operation
        /// to test your authentication method as soon as you create your server. By doing so,
        /// you can troubleshoot issues with the identity provider integration to ensure that
        /// your users can successfully use the service.
        /// 
        ///  
        /// <para>
        ///  The <code>ServerId</code> and <code>UserName</code> parameters are required. The
        /// <code>ServerProtocol</code>, <code>SourceIp</code>, and <code>UserPassword</code>
        /// are all optional. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  You cannot use <code>TestIdentityProvider</code> if the <code>IdentityProviderType</code>
        /// of your server is <code>SERVICE_MANAGED</code>. 
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  If you provide any incorrect values for any parameters, the <code>Response</code>
        /// field is empty. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you provide a server ID for a server that uses service-managed users, you get
        /// an error: 
        /// </para>
        ///  
        /// <para>
        ///  <code> An error occurred (InvalidRequestException) when calling the TestIdentityProvider
        /// operation: s-<i>server-ID</i> not configured for external auth </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you enter a Server ID for the <code>--server-id</code> parameter that does not
        /// identify an actual Transfer server, you receive the following error: 
        /// </para>
        ///  
        /// <para>
        ///  <code>An error occurred (ResourceNotFoundException) when calling the TestIdentityProvider
        /// operation: Unknown server</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the TestIdentityProvider service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TestIdentityProvider">REST API Reference for TestIdentityProvider Operation</seealso>
        public virtual TestIdentityProviderResponse TestIdentityProvider(TestIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<TestIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestIdentityProvider operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TestIdentityProvider">REST API Reference for TestIdentityProvider Operation</seealso>
        public virtual IAsyncResult BeginTestIdentityProvider(TestIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestIdentityProvider.</param>
        /// 
        /// <returns>Returns a  TestIdentityProviderResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TestIdentityProvider">REST API Reference for TestIdentityProvider Operation</seealso>
        public virtual TestIdentityProviderResponse EndTestIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<TestIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Detaches a key-value pair from a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// 
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccess

        /// <summary>
        /// Allows you to update parameters for the access specified in the <code>ServerID</code>
        /// and <code>ExternalID</code> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccess service method.</param>
        /// 
        /// <returns>The response from the UpdateAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateAccess">REST API Reference for UpdateAccess Operation</seealso>
        public virtual UpdateAccessResponse UpdateAccess(UpdateAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccess operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateAccess">REST API Reference for UpdateAccess Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccess(UpdateAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccess.</param>
        /// 
        /// <returns>Returns a  UpdateAccessResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateAccess">REST API Reference for UpdateAccess Operation</seealso>
        public virtual UpdateAccessResponse EndUpdateAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAgreement

        /// <summary>
        /// Updates some of the parameters for an existing agreement. Provide the <code>AgreementId</code>
        /// and the <code>ServerId</code> for the agreement that you want to update, along with
        /// the new values for the parameters to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgreement service method.</param>
        /// 
        /// <returns>The response from the UpdateAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateAgreement">REST API Reference for UpdateAgreement Operation</seealso>
        public virtual UpdateAgreementResponse UpdateAgreement(UpdateAgreementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgreementResponseUnmarshaller.Instance;

            return Invoke<UpdateAgreementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgreement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgreement operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgreement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateAgreement">REST API Reference for UpdateAgreement Operation</seealso>
        public virtual IAsyncResult BeginUpdateAgreement(UpdateAgreementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgreementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgreement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgreement.</param>
        /// 
        /// <returns>Returns a  UpdateAgreementResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateAgreement">REST API Reference for UpdateAgreement Operation</seealso>
        public virtual UpdateAgreementResponse EndUpdateAgreement(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAgreementResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCertificate

        /// <summary>
        /// Updates the active and inactive dates for a certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        public virtual UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificate operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        public virtual IAsyncResult BeginUpdateCertificate(UpdateCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateCertificateResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        public virtual UpdateCertificateResponse EndUpdateCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnector

        /// <summary>
        /// Updates some of the parameters for an existing connector. Provide the <code>ConnectorId</code>
        /// for the connector that you want to update, along with the new values for the parameters
        /// to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector service method.</param>
        /// 
        /// <returns>The response from the UpdateConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        public virtual UpdateConnectorResponse UpdateConnector(UpdateConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnector(UpdateConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnector.</param>
        /// 
        /// <returns>Returns a  UpdateConnectorResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        public virtual UpdateConnectorResponse EndUpdateConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateHostKey

        /// <summary>
        /// Updates the description for the host key that's specified by the <code>ServerId</code>
        /// and <code>HostKeyId</code> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostKey service method.</param>
        /// 
        /// <returns>The response from the UpdateHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateHostKey">REST API Reference for UpdateHostKey Operation</seealso>
        public virtual UpdateHostKeyResponse UpdateHostKey(UpdateHostKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHostKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHostKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateHostKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHostKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostKey operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHostKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateHostKey">REST API Reference for UpdateHostKey Operation</seealso>
        public virtual IAsyncResult BeginUpdateHostKey(UpdateHostKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHostKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHostKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHostKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHostKey.</param>
        /// 
        /// <returns>Returns a  UpdateHostKeyResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateHostKey">REST API Reference for UpdateHostKey Operation</seealso>
        public virtual UpdateHostKeyResponse EndUpdateHostKey(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateHostKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProfile

        /// <summary>
        /// Updates some of the parameters for an existing profile. Provide the <code>ProfileId</code>
        /// for the profile that you want to update, along with the new values for the parameters
        /// to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateProfile(UpdateProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProfile.</param>
        /// 
        /// <returns>Returns a  UpdateProfileResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual UpdateProfileResponse EndUpdateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServer

        /// <summary>
        /// Updates the file transfer protocol-enabled server's properties after that server has
        /// been created.
        /// 
        ///  
        /// <para>
        /// The <code>UpdateServer</code> call returns the <code>ServerId</code> of the server
        /// you updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer service method.</param>
        /// 
        /// <returns>The response from the UpdateServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ConflictException">
        /// This exception is thrown when the <code>UpdateServer</code> is called for a file transfer
        /// protocol-enabled server that has VPC as the endpoint type and the server's <code>VpcEndpointID</code>
        /// is not in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateServer">REST API Reference for UpdateServer Operation</seealso>
        public virtual UpdateServerResponse UpdateServer(UpdateServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerResponseUnmarshaller.Instance;

            return Invoke<UpdateServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateServer">REST API Reference for UpdateServer Operation</seealso>
        public virtual IAsyncResult BeginUpdateServer(UpdateServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServer.</param>
        /// 
        /// <returns>Returns a  UpdateServerResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateServer">REST API Reference for UpdateServer Operation</seealso>
        public virtual UpdateServerResponse EndUpdateServer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUser

        /// <summary>
        /// Assigns new properties to a user. Parameters you pass modify any or all of the following:
        /// the home directory, role, and policy for the <code>UserName</code> and <code>ServerId</code>
        /// you specify.
        /// 
        ///  
        /// <para>
        /// The response returns the <code>ServerId</code> and the <code>UserName</code> for the
        /// updated user.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonTransferClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
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
        /// <returns>Returns a  UpdateUserResult from Transfer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserResponse>(asyncResult);
        }

        #endregion
        
    }
}