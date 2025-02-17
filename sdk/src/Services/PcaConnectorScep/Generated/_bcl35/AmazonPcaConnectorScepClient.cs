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
 * Do not modify this file. This file is generated from the pca-connector-scep-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.PcaConnectorScep.Model;
using Amazon.PcaConnectorScep.Model.Internal.MarshallTransformations;
using Amazon.PcaConnectorScep.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.PcaConnectorScep
{
    /// <summary>
    /// <para>Implementation for accessing PcaConnectorScep</para>
    ///
    /// Connector for SCEP creates a connector between Amazon Web Services Private CA and
    /// your SCEP-enabled clients and devices. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep.html">Connector
    /// for SCEP</a> in the <i>Amazon Web Services Private CA User Guide</i>.
    /// </summary>
    public partial class AmazonPcaConnectorScepClient : AmazonServiceClient, IAmazonPcaConnectorScep
    {
        private static IServiceMetadata serviceMetadata = new AmazonPcaConnectorScepMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IPcaConnectorScepPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPcaConnectorScepPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PcaConnectorScepPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with the credentials loaded from the application's
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
        public AmazonPcaConnectorScepClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPcaConnectorScepConfig()) { }

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with the credentials loaded from the application's
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
        public AmazonPcaConnectorScepClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPcaConnectorScepConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPcaConnectorScepClient Configuration Object</param>
        public AmazonPcaConnectorScepClient(AmazonPcaConnectorScepConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPcaConnectorScepClient(AWSCredentials credentials)
            : this(credentials, new AmazonPcaConnectorScepConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPcaConnectorScepClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPcaConnectorScepConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with AWS Credentials and an
        /// AmazonPcaConnectorScepClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPcaConnectorScepClient Configuration Object</param>
        public AmazonPcaConnectorScepClient(AWSCredentials credentials, AmazonPcaConnectorScepConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPcaConnectorScepClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPcaConnectorScepConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPcaConnectorScepClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPcaConnectorScepConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPcaConnectorScepClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPcaConnectorScepClient Configuration Object</param>
        public AmazonPcaConnectorScepClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPcaConnectorScepConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPcaConnectorScepClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPcaConnectorScepConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPcaConnectorScepClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPcaConnectorScepConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorScepClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPcaConnectorScepClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPcaConnectorScepClient Configuration Object</param>
        public AmazonPcaConnectorScepClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPcaConnectorScepConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPcaConnectorScepEndpointResolver());
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


        #region  CreateChallenge

        /// <summary>
        /// For general-purpose connectors. Creates a <i>challenge password</i> for the specified
        /// connector. The SCEP protocol uses a challenge password to authenticate a request before
        /// issuing a certificate from a certificate authority (CA). Your SCEP clients include
        /// the challenge password as part of their certificate request to Connector for SCEP.
        /// To retrieve the connector Amazon Resource Names (ARNs) for the connectors in your
        /// account, call <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_ListConnectors.html">ListConnectors</a>.
        /// 
        ///  
        /// <para>
        /// To create additional challenge passwords for the connector, call <c>CreateChallenge</c>
        /// again. We recommend frequently rotating your challenge passwords.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChallenge service method.</param>
        /// 
        /// <returns>The response from the CreateChallenge service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ConflictException">
        /// This request can't be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateChallenge">REST API Reference for CreateChallenge Operation</seealso>
        public virtual CreateChallengeResponse CreateChallenge(CreateChallengeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChallengeResponseUnmarshaller.Instance;

            return Invoke<CreateChallengeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChallenge operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChallenge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateChallenge">REST API Reference for CreateChallenge Operation</seealso>
        public virtual IAsyncResult BeginCreateChallenge(CreateChallengeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChallengeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChallenge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChallenge.</param>
        /// 
        /// <returns>Returns a  CreateChallengeResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateChallenge">REST API Reference for CreateChallenge Operation</seealso>
        public virtual CreateChallengeResponse EndCreateChallenge(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChallengeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnector

        /// <summary>
        /// Creates a SCEP connector. A SCEP connector links Amazon Web Services Private Certificate
        /// Authority to your SCEP-compatible devices and mobile device management (MDM) systems.
        /// Before you create a connector, you must complete a set of prerequisites, including
        /// creation of a private certificate authority (CA) to use with this connector. For more
        /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep-prerequisites.html">Connector
        /// for SCEP prerequisites</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ConflictException">
        /// This request can't be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
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
        /// <returns>Returns a  CreateConnectorResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual CreateConnectorResponse EndCreateConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChallenge

        /// <summary>
        /// Deletes the specified <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_Challenge.html">Challenge</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChallenge service method.</param>
        /// 
        /// <returns>The response from the DeleteChallenge service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ConflictException">
        /// This request can't be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteChallenge">REST API Reference for DeleteChallenge Operation</seealso>
        public virtual DeleteChallengeResponse DeleteChallenge(DeleteChallengeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChallengeResponseUnmarshaller.Instance;

            return Invoke<DeleteChallengeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChallenge operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChallenge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteChallenge">REST API Reference for DeleteChallenge Operation</seealso>
        public virtual IAsyncResult BeginDeleteChallenge(DeleteChallengeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChallengeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChallenge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChallenge.</param>
        /// 
        /// <returns>Returns a  DeleteChallengeResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteChallenge">REST API Reference for DeleteChallenge Operation</seealso>
        public virtual DeleteChallengeResponse EndDeleteChallenge(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChallengeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnector

        /// <summary>
        /// Deletes the specified <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_Connector.html">Connector</a>.
        /// This operation also deletes any challenges associated with the connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ConflictException">
        /// This request can't be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
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
        /// <returns>Returns a  DeleteConnectorResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual DeleteConnectorResponse EndDeleteConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChallengeMetadata

        /// <summary>
        /// Retrieves the metadata for the specified <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_Challenge.html">Challenge</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChallengeMetadata service method.</param>
        /// 
        /// <returns>The response from the GetChallengeMetadata service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengeMetadata">REST API Reference for GetChallengeMetadata Operation</seealso>
        public virtual GetChallengeMetadataResponse GetChallengeMetadata(GetChallengeMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChallengeMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChallengeMetadataResponseUnmarshaller.Instance;

            return Invoke<GetChallengeMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChallengeMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChallengeMetadata operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChallengeMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengeMetadata">REST API Reference for GetChallengeMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetChallengeMetadata(GetChallengeMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChallengeMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChallengeMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChallengeMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChallengeMetadata.</param>
        /// 
        /// <returns>Returns a  GetChallengeMetadataResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengeMetadata">REST API Reference for GetChallengeMetadata Operation</seealso>
        public virtual GetChallengeMetadataResponse EndGetChallengeMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChallengeMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChallengePassword

        /// <summary>
        /// Retrieves the challenge password for the specified <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_Challenge.html">Challenge</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChallengePassword service method.</param>
        /// 
        /// <returns>The response from the GetChallengePassword service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengePassword">REST API Reference for GetChallengePassword Operation</seealso>
        public virtual GetChallengePasswordResponse GetChallengePassword(GetChallengePasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChallengePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChallengePasswordResponseUnmarshaller.Instance;

            return Invoke<GetChallengePasswordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChallengePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChallengePassword operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChallengePassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengePassword">REST API Reference for GetChallengePassword Operation</seealso>
        public virtual IAsyncResult BeginGetChallengePassword(GetChallengePasswordRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChallengePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChallengePasswordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChallengePassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChallengePassword.</param>
        /// 
        /// <returns>Returns a  GetChallengePasswordResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengePassword">REST API Reference for GetChallengePassword Operation</seealso>
        public virtual GetChallengePasswordResponse EndGetChallengePassword(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChallengePasswordResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnector

        /// <summary>
        /// Retrieves details about the specified <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_Connector.html">Connector</a>.
        /// Calling this action returns important details about the connector, such as the public
        /// SCEP URL where your clients can request certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnector service method.</param>
        /// 
        /// <returns>The response from the GetConnector service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        public virtual GetConnectorResponse GetConnector(GetConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorResponseUnmarshaller.Instance;

            return Invoke<GetConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnector operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        public virtual IAsyncResult BeginGetConnector(GetConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnector.</param>
        /// 
        /// <returns>Returns a  GetConnectorResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        public virtual GetConnectorResponse EndGetConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChallengeMetadata

        /// <summary>
        /// Retrieves the challenge metadata for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChallengeMetadata service method.</param>
        /// 
        /// <returns>The response from the ListChallengeMetadata service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListChallengeMetadata">REST API Reference for ListChallengeMetadata Operation</seealso>
        public virtual ListChallengeMetadataResponse ListChallengeMetadata(ListChallengeMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChallengeMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChallengeMetadataResponseUnmarshaller.Instance;

            return Invoke<ListChallengeMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChallengeMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChallengeMetadata operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChallengeMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListChallengeMetadata">REST API Reference for ListChallengeMetadata Operation</seealso>
        public virtual IAsyncResult BeginListChallengeMetadata(ListChallengeMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChallengeMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChallengeMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChallengeMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChallengeMetadata.</param>
        /// 
        /// <returns>Returns a  ListChallengeMetadataResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListChallengeMetadata">REST API Reference for ListChallengeMetadata Operation</seealso>
        public virtual ListChallengeMetadataResponse EndListChallengeMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChallengeMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConnectors

        /// <summary>
        /// Lists the connectors belonging to your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
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
        /// <returns>Returns a  ListConnectorsResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual ListConnectorsResponse EndListConnectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConnectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves the tags associated with the specified resource. Tags are key-value pairs
        /// that you can use to categorize and manage your resources, for purposes like billing.
        /// For example, you might set the tag key to "customer" and the value to the customer
        /// name or ID. You can specify one or more tags to add to each Amazon Web Services resource,
        /// up to 50 tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags to your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
            var resolver = new AmazonPcaConnectorScepEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}