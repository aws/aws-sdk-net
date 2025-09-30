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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SecurityIR.Model;
using Amazon.SecurityIR.Model.Internal.MarshallTransformations;
using Amazon.SecurityIR.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.SecurityIR
{
    /// <summary>
    /// <para>Implementation for accessing SecurityIR</para>
    ///
    /// This guide documents the action and response elements for use of the service.
    /// </summary>
    public partial class AmazonSecurityIRClient : AmazonServiceClient, IAmazonSecurityIR
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecurityIRMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ISecurityIRPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISecurityIRPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SecurityIRPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonSecurityIRClient with the credentials loaded from the application's
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
        public AmazonSecurityIRClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityIRConfig()) { }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with the credentials loaded from the application's
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
        public AmazonSecurityIRClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityIRConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSecurityIRClient Configuration Object</param>
        public AmazonSecurityIRClient(AmazonSecurityIRConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecurityIRClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecurityIRConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityIRClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecurityIRConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Credentials and an
        /// AmazonSecurityIRClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityIRClient Configuration Object</param>
        public AmazonSecurityIRClient(AWSCredentials credentials, AmazonSecurityIRConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityIRConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityIRConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityIRClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecurityIRClient Configuration Object</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityIRConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityIRConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityIRConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityIRClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecurityIRClient Configuration Object</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityIRConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityIREndpointResolver());
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


        #region  BatchGetMemberAccountDetails

        /// <summary>
        /// Provides information on whether the supplied account IDs are associated with a membership.
        /// 
        ///  <note> 
        /// <para>
        ///  AWS account ID's may appear less than 12 characters and need to be zero-prepended.
        /// An example would be <c>123123123</c> which is nine digits, and with zero-prepend would
        /// be <c>000123123123</c>. Not zero-prepending to 12 digits could result in errors. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberAccountDetails service method.</param>
        /// 
        /// <returns>The response from the BatchGetMemberAccountDetails service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/BatchGetMemberAccountDetails">REST API Reference for BatchGetMemberAccountDetails Operation</seealso>
        public virtual BatchGetMemberAccountDetailsResponse BatchGetMemberAccountDetails(BatchGetMemberAccountDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetMemberAccountDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMemberAccountDetailsResponseUnmarshaller.Instance;

            return Invoke<BatchGetMemberAccountDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetMemberAccountDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberAccountDetails operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetMemberAccountDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/BatchGetMemberAccountDetails">REST API Reference for BatchGetMemberAccountDetails Operation</seealso>
        public virtual IAsyncResult BeginBatchGetMemberAccountDetails(BatchGetMemberAccountDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetMemberAccountDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMemberAccountDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetMemberAccountDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetMemberAccountDetails.</param>
        /// 
        /// <returns>Returns a  BatchGetMemberAccountDetailsResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/BatchGetMemberAccountDetails">REST API Reference for BatchGetMemberAccountDetails Operation</seealso>
        public virtual BatchGetMemberAccountDetailsResponse EndBatchGetMemberAccountDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetMemberAccountDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelMembership

        /// <summary>
        /// Cancels an existing membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMembership service method.</param>
        /// 
        /// <returns>The response from the CancelMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CancelMembership">REST API Reference for CancelMembership Operation</seealso>
        public virtual CancelMembershipResponse CancelMembership(CancelMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMembershipResponseUnmarshaller.Instance;

            return Invoke<CancelMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMembership operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CancelMembership">REST API Reference for CancelMembership Operation</seealso>
        public virtual IAsyncResult BeginCancelMembership(CancelMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMembership.</param>
        /// 
        /// <returns>Returns a  CancelMembershipResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CancelMembership">REST API Reference for CancelMembership Operation</seealso>
        public virtual CancelMembershipResponse EndCancelMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  CloseCase

        /// <summary>
        /// Closes an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseCase service method.</param>
        /// 
        /// <returns>The response from the CloseCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CloseCase">REST API Reference for CloseCase Operation</seealso>
        public virtual CloseCaseResponse CloseCase(CloseCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CloseCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseCaseResponseUnmarshaller.Instance;

            return Invoke<CloseCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CloseCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloseCase operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloseCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CloseCase">REST API Reference for CloseCase Operation</seealso>
        public virtual IAsyncResult BeginCloseCase(CloseCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CloseCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CloseCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloseCase.</param>
        /// 
        /// <returns>Returns a  CloseCaseResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CloseCase">REST API Reference for CloseCase Operation</seealso>
        public virtual CloseCaseResponse EndCloseCase(IAsyncResult asyncResult)
        {
            return EndInvoke<CloseCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCase

        /// <summary>
        /// Creates a new case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCase">REST API Reference for CreateCase Operation</seealso>
        public virtual CreateCaseResponse CreateCase(CreateCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCaseResponseUnmarshaller.Instance;

            return Invoke<CreateCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCase operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCase">REST API Reference for CreateCase Operation</seealso>
        public virtual IAsyncResult BeginCreateCase(CreateCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCase.</param>
        /// 
        /// <returns>Returns a  CreateCaseResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCase">REST API Reference for CreateCase Operation</seealso>
        public virtual CreateCaseResponse EndCreateCase(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCaseComment

        /// <summary>
        /// Adds a comment to an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCaseComment service method.</param>
        /// 
        /// <returns>The response from the CreateCaseComment service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCaseComment">REST API Reference for CreateCaseComment Operation</seealso>
        public virtual CreateCaseCommentResponse CreateCaseComment(CreateCaseCommentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCaseCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCaseCommentResponseUnmarshaller.Instance;

            return Invoke<CreateCaseCommentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCaseComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCaseComment operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCaseComment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCaseComment">REST API Reference for CreateCaseComment Operation</seealso>
        public virtual IAsyncResult BeginCreateCaseComment(CreateCaseCommentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCaseCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCaseCommentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCaseComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCaseComment.</param>
        /// 
        /// <returns>Returns a  CreateCaseCommentResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCaseComment">REST API Reference for CreateCaseComment Operation</seealso>
        public virtual CreateCaseCommentResponse EndCreateCaseComment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCaseCommentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMembership

        /// <summary>
        /// Creates a new membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        public virtual CreateMembershipResponse CreateMembership(CreateMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        public virtual IAsyncResult BeginCreateMembership(CreateMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMembership.</param>
        /// 
        /// <returns>Returns a  CreateMembershipResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        public virtual CreateMembershipResponse EndCreateMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCase

        /// <summary>
        /// Returns the attributes of a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCase service method.</param>
        /// 
        /// <returns>The response from the GetCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCase">REST API Reference for GetCase Operation</seealso>
        public virtual GetCaseResponse GetCase(GetCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseResponseUnmarshaller.Instance;

            return Invoke<GetCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCase operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCase">REST API Reference for GetCase Operation</seealso>
        public virtual IAsyncResult BeginGetCase(GetCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCase.</param>
        /// 
        /// <returns>Returns a  GetCaseResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCase">REST API Reference for GetCase Operation</seealso>
        public virtual GetCaseResponse EndGetCase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCaseAttachmentDownloadUrl

        /// <summary>
        /// Returns a Pre-Signed URL for uploading attachments into a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentDownloadUrl service method.</param>
        /// 
        /// <returns>The response from the GetCaseAttachmentDownloadUrl service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentDownloadUrl">REST API Reference for GetCaseAttachmentDownloadUrl Operation</seealso>
        public virtual GetCaseAttachmentDownloadUrlResponse GetCaseAttachmentDownloadUrl(GetCaseAttachmentDownloadUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseAttachmentDownloadUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseAttachmentDownloadUrlResponseUnmarshaller.Instance;

            return Invoke<GetCaseAttachmentDownloadUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCaseAttachmentDownloadUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentDownloadUrl operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCaseAttachmentDownloadUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentDownloadUrl">REST API Reference for GetCaseAttachmentDownloadUrl Operation</seealso>
        public virtual IAsyncResult BeginGetCaseAttachmentDownloadUrl(GetCaseAttachmentDownloadUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseAttachmentDownloadUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseAttachmentDownloadUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCaseAttachmentDownloadUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCaseAttachmentDownloadUrl.</param>
        /// 
        /// <returns>Returns a  GetCaseAttachmentDownloadUrlResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentDownloadUrl">REST API Reference for GetCaseAttachmentDownloadUrl Operation</seealso>
        public virtual GetCaseAttachmentDownloadUrlResponse EndGetCaseAttachmentDownloadUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCaseAttachmentDownloadUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCaseAttachmentUploadUrl

        /// <summary>
        /// Uploads an attachment to a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentUploadUrl service method.</param>
        /// 
        /// <returns>The response from the GetCaseAttachmentUploadUrl service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentUploadUrl">REST API Reference for GetCaseAttachmentUploadUrl Operation</seealso>
        public virtual GetCaseAttachmentUploadUrlResponse GetCaseAttachmentUploadUrl(GetCaseAttachmentUploadUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseAttachmentUploadUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseAttachmentUploadUrlResponseUnmarshaller.Instance;

            return Invoke<GetCaseAttachmentUploadUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCaseAttachmentUploadUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentUploadUrl operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCaseAttachmentUploadUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentUploadUrl">REST API Reference for GetCaseAttachmentUploadUrl Operation</seealso>
        public virtual IAsyncResult BeginGetCaseAttachmentUploadUrl(GetCaseAttachmentUploadUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseAttachmentUploadUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseAttachmentUploadUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCaseAttachmentUploadUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCaseAttachmentUploadUrl.</param>
        /// 
        /// <returns>Returns a  GetCaseAttachmentUploadUrlResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentUploadUrl">REST API Reference for GetCaseAttachmentUploadUrl Operation</seealso>
        public virtual GetCaseAttachmentUploadUrlResponse EndGetCaseAttachmentUploadUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCaseAttachmentUploadUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMembership

        /// <summary>
        /// Returns the attributes of a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembership service method.</param>
        /// 
        /// <returns>The response from the GetMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetMembership">REST API Reference for GetMembership Operation</seealso>
        public virtual GetMembershipResponse GetMembership(GetMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembershipResponseUnmarshaller.Instance;

            return Invoke<GetMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembership operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetMembership">REST API Reference for GetMembership Operation</seealso>
        public virtual IAsyncResult BeginGetMembership(GetMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMembership.</param>
        /// 
        /// <returns>Returns a  GetMembershipResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetMembership">REST API Reference for GetMembership Operation</seealso>
        public virtual GetMembershipResponse EndGetMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCaseEdits

        /// <summary>
        /// Views the case history for edits made to a designated case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCaseEdits service method.</param>
        /// 
        /// <returns>The response from the ListCaseEdits service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCaseEdits">REST API Reference for ListCaseEdits Operation</seealso>
        public virtual ListCaseEditsResponse ListCaseEdits(ListCaseEditsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCaseEditsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCaseEditsResponseUnmarshaller.Instance;

            return Invoke<ListCaseEditsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCaseEdits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCaseEdits operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCaseEdits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCaseEdits">REST API Reference for ListCaseEdits Operation</seealso>
        public virtual IAsyncResult BeginListCaseEdits(ListCaseEditsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCaseEditsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCaseEditsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCaseEdits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCaseEdits.</param>
        /// 
        /// <returns>Returns a  ListCaseEditsResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCaseEdits">REST API Reference for ListCaseEdits Operation</seealso>
        public virtual ListCaseEditsResponse EndListCaseEdits(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCaseEditsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCases

        /// <summary>
        /// Lists all cases the requester has access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCases service method.</param>
        /// 
        /// <returns>The response from the ListCases service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCases">REST API Reference for ListCases Operation</seealso>
        public virtual ListCasesResponse ListCases(ListCasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCasesResponseUnmarshaller.Instance;

            return Invoke<ListCasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCases operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCases">REST API Reference for ListCases Operation</seealso>
        public virtual IAsyncResult BeginListCases(ListCasesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCases.</param>
        /// 
        /// <returns>Returns a  ListCasesResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCases">REST API Reference for ListCases Operation</seealso>
        public virtual ListCasesResponse EndListCases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComments

        /// <summary>
        /// Returns comments for a designated case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComments service method.</param>
        /// 
        /// <returns>The response from the ListComments service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListComments">REST API Reference for ListComments Operation</seealso>
        public virtual ListCommentsResponse ListComments(ListCommentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCommentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommentsResponseUnmarshaller.Instance;

            return Invoke<ListCommentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComments operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListComments">REST API Reference for ListComments Operation</seealso>
        public virtual IAsyncResult BeginListComments(ListCommentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCommentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComments.</param>
        /// 
        /// <returns>Returns a  ListCommentsResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListComments">REST API Reference for ListComments Operation</seealso>
        public virtual ListCommentsResponse EndListComments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCommentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMemberships

        /// <summary>
        /// Returns the memberships that the calling principal can access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        public virtual ListMembershipsResponse ListMemberships(ListMembershipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListMembershipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        public virtual IAsyncResult BeginListMemberships(ListMembershipsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembershipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemberships.</param>
        /// 
        /// <returns>Returns a  ListMembershipsResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        public virtual ListMembershipsResponse EndListMemberships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMembershipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns currently configured tags on a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds a tag(s) to a designated resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag(s) from a designate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCase

        /// <summary>
        /// Updates an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase service method.</param>
        /// 
        /// <returns>The response from the UpdateCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        public virtual UpdateCaseResponse UpdateCase(UpdateCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseResponseUnmarshaller.Instance;

            return Invoke<UpdateCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        public virtual IAsyncResult BeginUpdateCase(UpdateCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCase.</param>
        /// 
        /// <returns>Returns a  UpdateCaseResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        public virtual UpdateCaseResponse EndUpdateCase(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCaseComment

        /// <summary>
        /// Updates an existing case comment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseComment service method.</param>
        /// 
        /// <returns>The response from the UpdateCaseComment service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseComment">REST API Reference for UpdateCaseComment Operation</seealso>
        public virtual UpdateCaseCommentResponse UpdateCaseComment(UpdateCaseCommentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateCaseCommentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCaseComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseComment operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCaseComment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseComment">REST API Reference for UpdateCaseComment Operation</seealso>
        public virtual IAsyncResult BeginUpdateCaseComment(UpdateCaseCommentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseCommentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCaseComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCaseComment.</param>
        /// 
        /// <returns>Returns a  UpdateCaseCommentResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseComment">REST API Reference for UpdateCaseComment Operation</seealso>
        public virtual UpdateCaseCommentResponse EndUpdateCaseComment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCaseCommentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCaseStatus

        /// <summary>
        /// Updates the state transitions for a designated cases.
        /// 
        ///  
        /// <para>
        ///  <b>Self-managed</b>: the following states are available for self-managed cases. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Submitted → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detection and Analysis → Containment, Eradication, and Recovery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detection and Analysis → Post-incident Activities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Containment, Eradication, and Recovery → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Containment, Eradication, and Recovery → Post-incident Activities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Post-incident Activities → Containment, Eradication, and Recovery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Post-incident Activities → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any → Closed
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>AWS supported</b>: You must use the <c>CloseCase</c> API to close. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateCaseStatus service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseStatus">REST API Reference for UpdateCaseStatus Operation</seealso>
        public virtual UpdateCaseStatusResponse UpdateCaseStatus(UpdateCaseStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateCaseStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCaseStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseStatus operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCaseStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseStatus">REST API Reference for UpdateCaseStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateCaseStatus(UpdateCaseStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCaseStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCaseStatus.</param>
        /// 
        /// <returns>Returns a  UpdateCaseStatusResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseStatus">REST API Reference for UpdateCaseStatus Operation</seealso>
        public virtual UpdateCaseStatusResponse EndUpdateCaseStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCaseStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMembership

        /// <summary>
        /// Updates membership configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership service method.</param>
        /// 
        /// <returns>The response from the UpdateMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        public virtual UpdateMembershipResponse UpdateMembership(UpdateMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMembershipResponseUnmarshaller.Instance;

            return Invoke<UpdateMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        public virtual IAsyncResult BeginUpdateMembership(UpdateMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMembership.</param>
        /// 
        /// <returns>Returns a  UpdateMembershipResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        public virtual UpdateMembershipResponse EndUpdateMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResolverType

        /// <summary>
        /// Updates the resolver type for a case.
        /// 
        ///  <important> 
        /// <para>
        /// This is a one-way action and cannot be reversed.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverType service method.</param>
        /// 
        /// <returns>The response from the UpdateResolverType service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateResolverType">REST API Reference for UpdateResolverType Operation</seealso>
        public virtual UpdateResolverTypeResponse UpdateResolverType(UpdateResolverTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResolverTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResolverType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverType operation on AmazonSecurityIRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResolverType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateResolverType">REST API Reference for UpdateResolverType Operation</seealso>
        public virtual IAsyncResult BeginUpdateResolverType(UpdateResolverTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResolverTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResolverType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResolverType.</param>
        /// 
        /// <returns>Returns a  UpdateResolverTypeResult from SecurityIR.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateResolverType">REST API Reference for UpdateResolverType Operation</seealso>
        public virtual UpdateResolverTypeResponse EndUpdateResolverType(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResolverTypeResponse>(asyncResult);
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
            var resolver = new AmazonSecurityIREndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}