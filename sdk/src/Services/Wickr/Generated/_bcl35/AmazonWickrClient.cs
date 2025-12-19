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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Wickr.Model;
using Amazon.Wickr.Model.Internal.MarshallTransformations;
using Amazon.Wickr.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Wickr
{
    /// <summary>
    /// <para>Implementation for accessing Wickr</para>
    ///
    /// Welcome to the <i>Amazon Web Services Wickr API Reference</i>.
    /// 
    ///  
    /// <para>
    /// The Amazon Web Services Wickr application programming interface (API) is designed
    /// for administrators to perform key tasks, such as creating and managing Amazon Web
    /// Services Wickr, networks, users, security groups, bots and more. This guide provides
    /// detailed information about the Amazon Web Services Wickr API, including operations,
    /// types, inputs and outputs, and error codes. You can use an Amazon Web Services SDK,
    /// the Amazon Web Services Command Line Interface (Amazon Web Services CLI, or the REST
    /// API to make API calls for Amazon Web Services Wickr. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Using Amazon Web Services SDK</i> 
    /// </para>
    ///  
    /// <para>
    /// The SDK clients authenticate your requests by using access keys that you provide.
    /// For more information, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/access.html">Authentication
    /// and access using Amazon Web Services SDKs and tools</a> in the <i>Amazon Web Services
    /// SDKs and Tools Reference Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Using Amazon Web Services CLI</i> 
    /// </para>
    ///  
    /// <para>
    /// Use your access keys with the Amazon Web Services CLI to make API calls. For more
    /// information about setting up the Amazon Web Services CLI, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-getting-started.html">Getting
    /// started with the Amazon Web Services CLI</a> in the <i>Amazon Web Services Command
    /// Line Interface User Guide for Version 2</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Using REST APIs</i> 
    /// </para>
    ///  
    /// <para>
    /// If you use REST to make API calls, you must authenticate your request by providing
    /// a signature. Amazon Web Services Wickr supports Signature Version 4. For more information,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_sigv.html">Amazon
    /// Web Services Signature Version 4 for API requests</a> in the <i>Amazon Web Services
    /// Identity and Access Management User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// Access and permissions to the APIs can be controlled by Amazon Web Services Identity
    /// and Access Management. The managed policy <a href="https://docs.aws.amazon.com/wickr/latest/adminguide/security-iam-awsmanpol.html#security-iam-awsmanpol-AWSWickrFullAccess">Amazon
    /// Web ServicesWickrFullAccess</a> grants full administrative permission to the Amazon
    /// Web Services Wickr service APIs. For more information on restricting access to specific
    /// operations, see <a href="https://docs.aws.amazon.com/wickr/latest/adminguide/security-iam.html">Identity
    /// and access management for Amazon Web Services Wickr </a> in the <i>Amazon Web Services
    /// Wickr Administration Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Types of Errors</i>:
    /// </para>
    ///  
    /// <para>
    /// The Amazon Web Services Wickr APIs provide an HTTP interface. HTTP defines ranges
    /// of HTTP Status Codes for different types of error responses.
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Client errors are indicated by HTTP Status Code class of 4xx
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Service errors are indicated by HTTP Status Code class of 5xx
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// In this reference guide, the documentation for each API has an Errors section that
    /// includes a brief discussion about HTTP status codes. We recommend looking there as
    /// part of your investigation when you get an error.
    /// </para>
    /// </summary>
    public partial class AmazonWickrClient : AmazonServiceClient, IAmazonWickr
    {
        private static IServiceMetadata serviceMetadata = new AmazonWickrMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IWickrPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IWickrPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new WickrPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonWickrClient with the credentials loaded from the application's
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
        public AmazonWickrClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWickrConfig()) { }

        /// <summary>
        /// Constructs AmazonWickrClient with the credentials loaded from the application's
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
        public AmazonWickrClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWickrConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWickrClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWickrClient Configuration Object</param>
        public AmazonWickrClient(AmazonWickrConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonWickrClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWickrClient(AWSCredentials credentials)
            : this(credentials, new AmazonWickrConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWickrClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWickrClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWickrConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWickrClient with AWS Credentials and an
        /// AmazonWickrClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWickrClient Configuration Object</param>
        public AmazonWickrClient(AWSCredentials credentials, AmazonWickrConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWickrClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWickrClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWickrConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWickrClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWickrClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWickrConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWickrClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWickrClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWickrClient Configuration Object</param>
        public AmazonWickrClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWickrConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWickrClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWickrClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWickrConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWickrClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWickrClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWickrConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWickrClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWickrClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWickrClient Configuration Object</param>
        public AmazonWickrClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWickrConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWickrEndpointResolver());
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


        #region  BatchCreateUser

        /// <summary>
        /// Creates multiple users in a specified Wickr network. This operation allows you to
        /// provision multiple user accounts simultaneously, optionally specifying security groups,
        /// and validation requirements for each user.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>codeValidation</c>, <c>inviteCode</c>, and <c>inviteCodeTtl</c> are restricted
        /// to networks under preview only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateUser service method.</param>
        /// 
        /// <returns>The response from the BatchCreateUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchCreateUser">REST API Reference for BatchCreateUser Operation</seealso>
        public virtual BatchCreateUserResponse BatchCreateUser(BatchCreateUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateUserResponseUnmarshaller.Instance;

            return Invoke<BatchCreateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateUser operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchCreateUser">REST API Reference for BatchCreateUser Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateUser(BatchCreateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateUser.</param>
        /// 
        /// <returns>Returns a  BatchCreateUserResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchCreateUser">REST API Reference for BatchCreateUser Operation</seealso>
        public virtual BatchCreateUserResponse EndBatchCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteUser

        /// <summary>
        /// Deletes multiple users from a specified Wickr network. This operation permanently
        /// removes user accounts and their associated data from the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUser service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchDeleteUser">REST API Reference for BatchDeleteUser Operation</seealso>
        public virtual BatchDeleteUserResponse BatchDeleteUser(BatchDeleteUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteUserResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUser operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchDeleteUser">REST API Reference for BatchDeleteUser Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteUser(BatchDeleteUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteUser.</param>
        /// 
        /// <returns>Returns a  BatchDeleteUserResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchDeleteUser">REST API Reference for BatchDeleteUser Operation</seealso>
        public virtual BatchDeleteUserResponse EndBatchDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchLookupUserUname

        /// <summary>
        /// Looks up multiple user usernames from their unique username hashes (unames). This
        /// operation allows you to retrieve the email addresses associated with a list of username
        /// hashes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchLookupUserUname service method.</param>
        /// 
        /// <returns>The response from the BatchLookupUserUname service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchLookupUserUname">REST API Reference for BatchLookupUserUname Operation</seealso>
        public virtual BatchLookupUserUnameResponse BatchLookupUserUname(BatchLookupUserUnameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchLookupUserUnameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchLookupUserUnameResponseUnmarshaller.Instance;

            return Invoke<BatchLookupUserUnameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchLookupUserUname operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchLookupUserUname operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchLookupUserUname
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchLookupUserUname">REST API Reference for BatchLookupUserUname Operation</seealso>
        public virtual IAsyncResult BeginBatchLookupUserUname(BatchLookupUserUnameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchLookupUserUnameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchLookupUserUnameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchLookupUserUname operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchLookupUserUname.</param>
        /// 
        /// <returns>Returns a  BatchLookupUserUnameResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchLookupUserUname">REST API Reference for BatchLookupUserUname Operation</seealso>
        public virtual BatchLookupUserUnameResponse EndBatchLookupUserUname(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchLookupUserUnameResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchReinviteUser

        /// <summary>
        /// Resends invitation codes to multiple users who have pending invitations in a Wickr
        /// network. This operation is useful when users haven't accepted their initial invitations
        /// or when invitations have expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchReinviteUser service method.</param>
        /// 
        /// <returns>The response from the BatchReinviteUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchReinviteUser">REST API Reference for BatchReinviteUser Operation</seealso>
        public virtual BatchReinviteUserResponse BatchReinviteUser(BatchReinviteUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchReinviteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchReinviteUserResponseUnmarshaller.Instance;

            return Invoke<BatchReinviteUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchReinviteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchReinviteUser operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchReinviteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchReinviteUser">REST API Reference for BatchReinviteUser Operation</seealso>
        public virtual IAsyncResult BeginBatchReinviteUser(BatchReinviteUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchReinviteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchReinviteUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchReinviteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchReinviteUser.</param>
        /// 
        /// <returns>Returns a  BatchReinviteUserResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchReinviteUser">REST API Reference for BatchReinviteUser Operation</seealso>
        public virtual BatchReinviteUserResponse EndBatchReinviteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchReinviteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchResetDevicesForUser

        /// <summary>
        /// Resets multiple devices for a specific user in a Wickr network. This operation forces
        /// the selected devices to log out and requires users to re-authenticate, which is useful
        /// for security purposes or when devices need to be revoked.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchResetDevicesForUser service method.</param>
        /// 
        /// <returns>The response from the BatchResetDevicesForUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchResetDevicesForUser">REST API Reference for BatchResetDevicesForUser Operation</seealso>
        public virtual BatchResetDevicesForUserResponse BatchResetDevicesForUser(BatchResetDevicesForUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchResetDevicesForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchResetDevicesForUserResponseUnmarshaller.Instance;

            return Invoke<BatchResetDevicesForUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchResetDevicesForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchResetDevicesForUser operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchResetDevicesForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchResetDevicesForUser">REST API Reference for BatchResetDevicesForUser Operation</seealso>
        public virtual IAsyncResult BeginBatchResetDevicesForUser(BatchResetDevicesForUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchResetDevicesForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchResetDevicesForUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchResetDevicesForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchResetDevicesForUser.</param>
        /// 
        /// <returns>Returns a  BatchResetDevicesForUserResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchResetDevicesForUser">REST API Reference for BatchResetDevicesForUser Operation</seealso>
        public virtual BatchResetDevicesForUserResponse EndBatchResetDevicesForUser(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchResetDevicesForUserResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchToggleUserSuspendStatus

        /// <summary>
        /// Suspends or unsuspends multiple users in a Wickr network. Suspended users cannot access
        /// the network until they are unsuspended. This operation is useful for temporarily restricting
        /// access without deleting user accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchToggleUserSuspendStatus service method.</param>
        /// 
        /// <returns>The response from the BatchToggleUserSuspendStatus service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchToggleUserSuspendStatus">REST API Reference for BatchToggleUserSuspendStatus Operation</seealso>
        public virtual BatchToggleUserSuspendStatusResponse BatchToggleUserSuspendStatus(BatchToggleUserSuspendStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchToggleUserSuspendStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchToggleUserSuspendStatusResponseUnmarshaller.Instance;

            return Invoke<BatchToggleUserSuspendStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchToggleUserSuspendStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchToggleUserSuspendStatus operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchToggleUserSuspendStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchToggleUserSuspendStatus">REST API Reference for BatchToggleUserSuspendStatus Operation</seealso>
        public virtual IAsyncResult BeginBatchToggleUserSuspendStatus(BatchToggleUserSuspendStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchToggleUserSuspendStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchToggleUserSuspendStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchToggleUserSuspendStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchToggleUserSuspendStatus.</param>
        /// 
        /// <returns>Returns a  BatchToggleUserSuspendStatusResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchToggleUserSuspendStatus">REST API Reference for BatchToggleUserSuspendStatus Operation</seealso>
        public virtual BatchToggleUserSuspendStatusResponse EndBatchToggleUserSuspendStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchToggleUserSuspendStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBot

        /// <summary>
        /// Creates a new bot in a specified Wickr network. Bots are automated accounts that can
        /// send and receive messages, enabling integration with external systems and automation
        /// of tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBot service method.</param>
        /// 
        /// <returns>The response from the CreateBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        public virtual CreateBotResponse CreateBot(CreateBotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBotResponseUnmarshaller.Instance;

            return Invoke<CreateBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBot operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        public virtual IAsyncResult BeginCreateBot(CreateBotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBot.</param>
        /// 
        /// <returns>Returns a  CreateBotResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        public virtual CreateBotResponse EndCreateBot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataRetentionBot

        /// <summary>
        /// Creates a data retention bot in a Wickr network. Data retention bots are specialized
        /// bots that handle message archiving and compliance by capturing and storing messages
        /// for regulatory or organizational requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRetentionBot service method.</param>
        /// 
        /// <returns>The response from the CreateDataRetentionBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateDataRetentionBot">REST API Reference for CreateDataRetentionBot Operation</seealso>
        public virtual CreateDataRetentionBotResponse CreateDataRetentionBot(CreateDataRetentionBotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataRetentionBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataRetentionBotResponseUnmarshaller.Instance;

            return Invoke<CreateDataRetentionBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataRetentionBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRetentionBot operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataRetentionBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateDataRetentionBot">REST API Reference for CreateDataRetentionBot Operation</seealso>
        public virtual IAsyncResult BeginCreateDataRetentionBot(CreateDataRetentionBotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataRetentionBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataRetentionBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataRetentionBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataRetentionBot.</param>
        /// 
        /// <returns>Returns a  CreateDataRetentionBotResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateDataRetentionBot">REST API Reference for CreateDataRetentionBot Operation</seealso>
        public virtual CreateDataRetentionBotResponse EndCreateDataRetentionBot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataRetentionBotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataRetentionBotChallenge

        /// <summary>
        /// Creates a new challenge password for the data retention bot. This password is used
        /// for authentication when the bot connects to the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRetentionBotChallenge service method.</param>
        /// 
        /// <returns>The response from the CreateDataRetentionBotChallenge service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateDataRetentionBotChallenge">REST API Reference for CreateDataRetentionBotChallenge Operation</seealso>
        public virtual CreateDataRetentionBotChallengeResponse CreateDataRetentionBotChallenge(CreateDataRetentionBotChallengeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataRetentionBotChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataRetentionBotChallengeResponseUnmarshaller.Instance;

            return Invoke<CreateDataRetentionBotChallengeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataRetentionBotChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRetentionBotChallenge operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataRetentionBotChallenge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateDataRetentionBotChallenge">REST API Reference for CreateDataRetentionBotChallenge Operation</seealso>
        public virtual IAsyncResult BeginCreateDataRetentionBotChallenge(CreateDataRetentionBotChallengeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataRetentionBotChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataRetentionBotChallengeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataRetentionBotChallenge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataRetentionBotChallenge.</param>
        /// 
        /// <returns>Returns a  CreateDataRetentionBotChallengeResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateDataRetentionBotChallenge">REST API Reference for CreateDataRetentionBotChallenge Operation</seealso>
        public virtual CreateDataRetentionBotChallengeResponse EndCreateDataRetentionBotChallenge(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataRetentionBotChallengeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNetwork

        /// <summary>
        /// Creates a new Wickr network with specified access level and configuration. This operation
        /// provisions a new communication network for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        public virtual CreateNetworkResponse CreateNetwork(CreateNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        public virtual IAsyncResult BeginCreateNetwork(CreateNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetwork.</param>
        /// 
        /// <returns>Returns a  CreateNetworkResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        public virtual CreateNetworkResponse EndCreateNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSecurityGroup

        /// <summary>
        /// Creates a new security group in a Wickr network. Security groups allow you to organize
        /// users and control their permissions, features, and security settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        public virtual CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateSecurityGroup(CreateSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateSecurityGroupResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        public virtual CreateSecurityGroupResponse EndCreateSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBot

        /// <summary>
        /// Deletes a bot from a specified Wickr network. This operation permanently removes the
        /// bot account and its associated data from the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot service method.</param>
        /// 
        /// <returns>The response from the DeleteBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        public virtual DeleteBotResponse DeleteBot(DeleteBotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return Invoke<DeleteBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        public virtual IAsyncResult BeginDeleteBot(DeleteBotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBot.</param>
        /// 
        /// <returns>Returns a  DeleteBotResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        public virtual DeleteBotResponse EndDeleteBot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataRetentionBot

        /// <summary>
        /// Deletes the data retention bot from a Wickr network. This operation permanently removes
        /// the bot and all its associated data from the database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataRetentionBot service method.</param>
        /// 
        /// <returns>The response from the DeleteDataRetentionBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteDataRetentionBot">REST API Reference for DeleteDataRetentionBot Operation</seealso>
        public virtual DeleteDataRetentionBotResponse DeleteDataRetentionBot(DeleteDataRetentionBotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataRetentionBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataRetentionBotResponseUnmarshaller.Instance;

            return Invoke<DeleteDataRetentionBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataRetentionBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataRetentionBot operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataRetentionBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteDataRetentionBot">REST API Reference for DeleteDataRetentionBot Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataRetentionBot(DeleteDataRetentionBotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataRetentionBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataRetentionBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataRetentionBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataRetentionBot.</param>
        /// 
        /// <returns>Returns a  DeleteDataRetentionBotResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteDataRetentionBot">REST API Reference for DeleteDataRetentionBot Operation</seealso>
        public virtual DeleteDataRetentionBotResponse EndDeleteDataRetentionBot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataRetentionBotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNetwork

        /// <summary>
        /// Deletes a Wickr network and all its associated resources, including users, bots, security
        /// groups, and settings. This operation is permanent and cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        public virtual DeleteNetworkResponse DeleteNetwork(DeleteNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        public virtual IAsyncResult BeginDeleteNetwork(DeleteNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetwork.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        public virtual DeleteNetworkResponse EndDeleteNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSecurityGroup

        /// <summary>
        /// Deletes a security group from a Wickr network. This operation cannot be performed
        /// on the default security group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        public virtual DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteSecurityGroup(DeleteSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteSecurityGroupResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        public virtual DeleteSecurityGroupResponse EndDeleteSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBot

        /// <summary>
        /// Retrieves detailed information about a specific bot in a Wickr network, including
        /// its status, group membership, and authentication details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBot service method.</param>
        /// 
        /// <returns>The response from the GetBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetBot">REST API Reference for GetBot Operation</seealso>
        public virtual GetBotResponse GetBot(GetBotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotResponseUnmarshaller.Instance;

            return Invoke<GetBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBot operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetBot">REST API Reference for GetBot Operation</seealso>
        public virtual IAsyncResult BeginGetBot(GetBotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBot.</param>
        /// 
        /// <returns>Returns a  GetBotResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetBot">REST API Reference for GetBot Operation</seealso>
        public virtual GetBotResponse EndGetBot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBotsCount

        /// <summary>
        /// Retrieves the count of bots in a Wickr network, categorized by their status (pending,
        /// active, and total).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotsCount service method.</param>
        /// 
        /// <returns>The response from the GetBotsCount service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetBotsCount">REST API Reference for GetBotsCount Operation</seealso>
        public virtual GetBotsCountResponse GetBotsCount(GetBotsCountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotsCountResponseUnmarshaller.Instance;

            return Invoke<GetBotsCountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBotsCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBotsCount operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBotsCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetBotsCount">REST API Reference for GetBotsCount Operation</seealso>
        public virtual IAsyncResult BeginGetBotsCount(GetBotsCountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotsCountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBotsCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBotsCount.</param>
        /// 
        /// <returns>Returns a  GetBotsCountResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetBotsCount">REST API Reference for GetBotsCount Operation</seealso>
        public virtual GetBotsCountResponse EndGetBotsCount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBotsCountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataRetentionBot

        /// <summary>
        /// Retrieves information about the data retention bot in a Wickr network, including its
        /// status and whether the data retention service is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetentionBot service method.</param>
        /// 
        /// <returns>The response from the GetDataRetentionBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetDataRetentionBot">REST API Reference for GetDataRetentionBot Operation</seealso>
        public virtual GetDataRetentionBotResponse GetDataRetentionBot(GetDataRetentionBotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataRetentionBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataRetentionBotResponseUnmarshaller.Instance;

            return Invoke<GetDataRetentionBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataRetentionBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetentionBot operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataRetentionBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetDataRetentionBot">REST API Reference for GetDataRetentionBot Operation</seealso>
        public virtual IAsyncResult BeginGetDataRetentionBot(GetDataRetentionBotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataRetentionBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataRetentionBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataRetentionBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataRetentionBot.</param>
        /// 
        /// <returns>Returns a  GetDataRetentionBotResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetDataRetentionBot">REST API Reference for GetDataRetentionBot Operation</seealso>
        public virtual GetDataRetentionBotResponse EndGetDataRetentionBot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataRetentionBotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGuestUserHistoryCount

        /// <summary>
        /// Retrieves historical guest user count data for a Wickr network, showing the number
        /// of guest users per billing period over the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGuestUserHistoryCount service method.</param>
        /// 
        /// <returns>The response from the GetGuestUserHistoryCount service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetGuestUserHistoryCount">REST API Reference for GetGuestUserHistoryCount Operation</seealso>
        public virtual GetGuestUserHistoryCountResponse GetGuestUserHistoryCount(GetGuestUserHistoryCountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGuestUserHistoryCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGuestUserHistoryCountResponseUnmarshaller.Instance;

            return Invoke<GetGuestUserHistoryCountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGuestUserHistoryCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGuestUserHistoryCount operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGuestUserHistoryCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetGuestUserHistoryCount">REST API Reference for GetGuestUserHistoryCount Operation</seealso>
        public virtual IAsyncResult BeginGetGuestUserHistoryCount(GetGuestUserHistoryCountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGuestUserHistoryCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGuestUserHistoryCountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGuestUserHistoryCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGuestUserHistoryCount.</param>
        /// 
        /// <returns>Returns a  GetGuestUserHistoryCountResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetGuestUserHistoryCount">REST API Reference for GetGuestUserHistoryCount Operation</seealso>
        public virtual GetGuestUserHistoryCountResponse EndGetGuestUserHistoryCount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGuestUserHistoryCountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetwork

        /// <summary>
        /// Retrieves detailed information about a specific Wickr network, including its configuration,
        /// access level, and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        public virtual GetNetworkResponse GetNetwork(GetNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResponseUnmarshaller.Instance;

            return Invoke<GetNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        public virtual IAsyncResult BeginGetNetwork(GetNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetwork.</param>
        /// 
        /// <returns>Returns a  GetNetworkResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        public virtual GetNetworkResponse EndGetNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetworkSettings

        /// <summary>
        /// Retrieves all network-level settings for a Wickr network, including client metrics,
        /// data retention, and other configuration options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the GetNetworkSettings service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        public virtual GetNetworkSettingsResponse GetNetworkSettings(GetNetworkSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<GetNetworkSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        public virtual IAsyncResult BeginGetNetworkSettings(GetNetworkSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkSettings.</param>
        /// 
        /// <returns>Returns a  GetNetworkSettingsResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        public virtual GetNetworkSettingsResponse EndGetNetworkSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOidcInfo

        /// <summary>
        /// Retrieves the OpenID Connect (OIDC) configuration for a Wickr network, including SSO
        /// settings and optional token information if access token parameters are provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOidcInfo service method.</param>
        /// 
        /// <returns>The response from the GetOidcInfo service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetOidcInfo">REST API Reference for GetOidcInfo Operation</seealso>
        public virtual GetOidcInfoResponse GetOidcInfo(GetOidcInfoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOidcInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOidcInfoResponseUnmarshaller.Instance;

            return Invoke<GetOidcInfoResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOidcInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOidcInfo operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOidcInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetOidcInfo">REST API Reference for GetOidcInfo Operation</seealso>
        public virtual IAsyncResult BeginGetOidcInfo(GetOidcInfoRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOidcInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOidcInfoResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOidcInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOidcInfo.</param>
        /// 
        /// <returns>Returns a  GetOidcInfoResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetOidcInfo">REST API Reference for GetOidcInfo Operation</seealso>
        public virtual GetOidcInfoResponse EndGetOidcInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOidcInfoResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSecurityGroup

        /// <summary>
        /// Retrieves detailed information about a specific security group in a Wickr network,
        /// including its settings, member counts, and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the GetSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetSecurityGroup">REST API Reference for GetSecurityGroup Operation</seealso>
        public virtual GetSecurityGroupResponse GetSecurityGroup(GetSecurityGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<GetSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityGroup operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetSecurityGroup">REST API Reference for GetSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginGetSecurityGroup(GetSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSecurityGroup.</param>
        /// 
        /// <returns>Returns a  GetSecurityGroupResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetSecurityGroup">REST API Reference for GetSecurityGroup Operation</seealso>
        public virtual GetSecurityGroupResponse EndGetSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUser

        /// <summary>
        /// Retrieves detailed information about a specific user in a Wickr network, including
        /// their profile, status, and activity history.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual GetUserResponse GetUser(GetUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  GetUserResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual GetUserResponse EndGetUser(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUsersCount

        /// <summary>
        /// Retrieves the count of users in a Wickr network, categorized by their status (pending,
        /// active, rejected) and showing how many users can still be added.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsersCount service method.</param>
        /// 
        /// <returns>The response from the GetUsersCount service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetUsersCount">REST API Reference for GetUsersCount Operation</seealso>
        public virtual GetUsersCountResponse GetUsersCount(GetUsersCountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsersCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsersCountResponseUnmarshaller.Instance;

            return Invoke<GetUsersCountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsersCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsersCount operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsersCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetUsersCount">REST API Reference for GetUsersCount Operation</seealso>
        public virtual IAsyncResult BeginGetUsersCount(GetUsersCountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsersCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsersCountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsersCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsersCount.</param>
        /// 
        /// <returns>Returns a  GetUsersCountResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetUsersCount">REST API Reference for GetUsersCount Operation</seealso>
        public virtual GetUsersCountResponse EndGetUsersCount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUsersCountResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBlockedGuestUsers

        /// <summary>
        /// Retrieves a paginated list of guest users who have been blocked from a Wickr network.
        /// You can filter and sort the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlockedGuestUsers service method.</param>
        /// 
        /// <returns>The response from the ListBlockedGuestUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListBlockedGuestUsers">REST API Reference for ListBlockedGuestUsers Operation</seealso>
        public virtual ListBlockedGuestUsersResponse ListBlockedGuestUsers(ListBlockedGuestUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBlockedGuestUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlockedGuestUsersResponseUnmarshaller.Instance;

            return Invoke<ListBlockedGuestUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBlockedGuestUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBlockedGuestUsers operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBlockedGuestUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListBlockedGuestUsers">REST API Reference for ListBlockedGuestUsers Operation</seealso>
        public virtual IAsyncResult BeginListBlockedGuestUsers(ListBlockedGuestUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBlockedGuestUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlockedGuestUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBlockedGuestUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBlockedGuestUsers.</param>
        /// 
        /// <returns>Returns a  ListBlockedGuestUsersResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListBlockedGuestUsers">REST API Reference for ListBlockedGuestUsers Operation</seealso>
        public virtual ListBlockedGuestUsersResponse EndListBlockedGuestUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBlockedGuestUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBots

        /// <summary>
        /// Retrieves a paginated list of bots in a specified Wickr network. You can filter and
        /// sort the results based on various criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// 
        /// <returns>The response from the ListBots service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListBots">REST API Reference for ListBots Operation</seealso>
        public virtual ListBotsResponse ListBots(ListBotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBotsResponseUnmarshaller.Instance;

            return Invoke<ListBotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBots operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListBots">REST API Reference for ListBots Operation</seealso>
        public virtual IAsyncResult BeginListBots(ListBotsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListBotsResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListBots">REST API Reference for ListBots Operation</seealso>
        public virtual ListBotsResponse EndListBots(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBotsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevicesForUser

        /// <summary>
        /// Retrieves a paginated list of devices associated with a specific user in a Wickr network.
        /// This operation returns information about all devices where the user has logged into
        /// Wickr.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesForUser service method.</param>
        /// 
        /// <returns>The response from the ListDevicesForUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListDevicesForUser">REST API Reference for ListDevicesForUser Operation</seealso>
        public virtual ListDevicesForUserResponse ListDevicesForUser(ListDevicesForUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevicesForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesForUserResponseUnmarshaller.Instance;

            return Invoke<ListDevicesForUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicesForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesForUser operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevicesForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListDevicesForUser">REST API Reference for ListDevicesForUser Operation</seealso>
        public virtual IAsyncResult BeginListDevicesForUser(ListDevicesForUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevicesForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesForUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevicesForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevicesForUser.</param>
        /// 
        /// <returns>Returns a  ListDevicesForUserResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListDevicesForUser">REST API Reference for ListDevicesForUser Operation</seealso>
        public virtual ListDevicesForUserResponse EndListDevicesForUser(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicesForUserResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGuestUsers

        /// <summary>
        /// Retrieves a paginated list of guest users who have communicated with your Wickr network.
        /// Guest users are external users from federated networks who can communicate with network
        /// members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGuestUsers service method.</param>
        /// 
        /// <returns>The response from the ListGuestUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListGuestUsers">REST API Reference for ListGuestUsers Operation</seealso>
        public virtual ListGuestUsersResponse ListGuestUsers(ListGuestUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGuestUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGuestUsersResponseUnmarshaller.Instance;

            return Invoke<ListGuestUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGuestUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGuestUsers operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGuestUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListGuestUsers">REST API Reference for ListGuestUsers Operation</seealso>
        public virtual IAsyncResult BeginListGuestUsers(ListGuestUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGuestUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGuestUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGuestUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGuestUsers.</param>
        /// 
        /// <returns>Returns a  ListGuestUsersResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListGuestUsers">REST API Reference for ListGuestUsers Operation</seealso>
        public virtual ListGuestUsersResponse EndListGuestUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGuestUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNetworks

        /// <summary>
        /// Retrieves a paginated list of all Wickr networks associated with your Amazon Web Services
        /// account. You can sort the results by network ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        public virtual ListNetworksResponse ListNetworks(ListNetworksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworksResponseUnmarshaller.Instance;

            return Invoke<ListNetworksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        public virtual IAsyncResult BeginListNetworks(ListNetworksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworks.</param>
        /// 
        /// <returns>Returns a  ListNetworksResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        public virtual ListNetworksResponse EndListNetworks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNetworksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSecurityGroups

        /// <summary>
        /// Retrieves a paginated list of security groups in a specified Wickr network. You can
        /// sort the results by various criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the ListSecurityGroups service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListSecurityGroups">REST API Reference for ListSecurityGroups Operation</seealso>
        public virtual ListSecurityGroupsResponse ListSecurityGroups(ListSecurityGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityGroups operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListSecurityGroups">REST API Reference for ListSecurityGroups Operation</seealso>
        public virtual IAsyncResult BeginListSecurityGroups(ListSecurityGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityGroups.</param>
        /// 
        /// <returns>Returns a  ListSecurityGroupsResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListSecurityGroups">REST API Reference for ListSecurityGroups Operation</seealso>
        public virtual ListSecurityGroupsResponse EndListSecurityGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSecurityGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSecurityGroupUsers

        /// <summary>
        /// Retrieves a paginated list of users who belong to a specific security group in a Wickr
        /// network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityGroupUsers service method.</param>
        /// 
        /// <returns>The response from the ListSecurityGroupUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListSecurityGroupUsers">REST API Reference for ListSecurityGroupUsers Operation</seealso>
        public virtual ListSecurityGroupUsersResponse ListSecurityGroupUsers(ListSecurityGroupUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityGroupUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityGroupUsersResponseUnmarshaller.Instance;

            return Invoke<ListSecurityGroupUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityGroupUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityGroupUsers operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityGroupUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListSecurityGroupUsers">REST API Reference for ListSecurityGroupUsers Operation</seealso>
        public virtual IAsyncResult BeginListSecurityGroupUsers(ListSecurityGroupUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityGroupUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityGroupUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityGroupUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityGroupUsers.</param>
        /// 
        /// <returns>Returns a  ListSecurityGroupUsersResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListSecurityGroupUsers">REST API Reference for ListSecurityGroupUsers Operation</seealso>
        public virtual ListSecurityGroupUsersResponse EndListSecurityGroupUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSecurityGroupUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Retrieves a paginated list of users in a specified Wickr network. You can filter and
        /// sort the results based on various criteria such as name, status, or security group
        /// membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListUsersResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterOidcConfig

        /// <summary>
        /// Registers and saves an OpenID Connect (OIDC) configuration for a Wickr network, enabling
        /// Single Sign-On (SSO) authentication through an identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOidcConfig service method.</param>
        /// 
        /// <returns>The response from the RegisterOidcConfig service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/RegisterOidcConfig">REST API Reference for RegisterOidcConfig Operation</seealso>
        public virtual RegisterOidcConfigResponse RegisterOidcConfig(RegisterOidcConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterOidcConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOidcConfigResponseUnmarshaller.Instance;

            return Invoke<RegisterOidcConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterOidcConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterOidcConfig operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterOidcConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/RegisterOidcConfig">REST API Reference for RegisterOidcConfig Operation</seealso>
        public virtual IAsyncResult BeginRegisterOidcConfig(RegisterOidcConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterOidcConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOidcConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterOidcConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterOidcConfig.</param>
        /// 
        /// <returns>Returns a  RegisterOidcConfigResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/RegisterOidcConfig">REST API Reference for RegisterOidcConfig Operation</seealso>
        public virtual RegisterOidcConfigResponse EndRegisterOidcConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterOidcConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterOidcConfigTest

        /// <summary>
        /// Tests an OpenID Connect (OIDC) configuration for a Wickr network by validating the
        /// connection to the identity provider and retrieving its supported capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOidcConfigTest service method.</param>
        /// 
        /// <returns>The response from the RegisterOidcConfigTest service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/RegisterOidcConfigTest">REST API Reference for RegisterOidcConfigTest Operation</seealso>
        public virtual RegisterOidcConfigTestResponse RegisterOidcConfigTest(RegisterOidcConfigTestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterOidcConfigTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOidcConfigTestResponseUnmarshaller.Instance;

            return Invoke<RegisterOidcConfigTestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterOidcConfigTest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterOidcConfigTest operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterOidcConfigTest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/RegisterOidcConfigTest">REST API Reference for RegisterOidcConfigTest Operation</seealso>
        public virtual IAsyncResult BeginRegisterOidcConfigTest(RegisterOidcConfigTestRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterOidcConfigTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOidcConfigTestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterOidcConfigTest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterOidcConfigTest.</param>
        /// 
        /// <returns>Returns a  RegisterOidcConfigTestResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/RegisterOidcConfigTest">REST API Reference for RegisterOidcConfigTest Operation</seealso>
        public virtual RegisterOidcConfigTestResponse EndRegisterOidcConfigTest(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterOidcConfigTestResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBot

        /// <summary>
        /// Updates the properties of an existing bot in a Wickr network. This operation allows
        /// you to modify the bot's display name, security group, password, or suspension status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot service method.</param>
        /// 
        /// <returns>The response from the UpdateBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        public virtual UpdateBotResponse UpdateBot(UpdateBotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBotResponseUnmarshaller.Instance;

            return Invoke<UpdateBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        public virtual IAsyncResult BeginUpdateBot(UpdateBotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBot.</param>
        /// 
        /// <returns>Returns a  UpdateBotResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        public virtual UpdateBotResponse EndUpdateBot(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBotResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataRetention

        /// <summary>
        /// Updates the data retention bot settings, allowing you to enable or disable the data
        /// retention service, or acknowledge the public key message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRetention service method.</param>
        /// 
        /// <returns>The response from the UpdateDataRetention service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateDataRetention">REST API Reference for UpdateDataRetention Operation</seealso>
        public virtual UpdateDataRetentionResponse UpdateDataRetention(UpdateDataRetentionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataRetentionResponseUnmarshaller.Instance;

            return Invoke<UpdateDataRetentionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataRetention operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRetention operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataRetention
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateDataRetention">REST API Reference for UpdateDataRetention Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataRetention(UpdateDataRetentionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataRetentionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataRetention operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataRetention.</param>
        /// 
        /// <returns>Returns a  UpdateDataRetentionResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateDataRetention">REST API Reference for UpdateDataRetention Operation</seealso>
        public virtual UpdateDataRetentionResponse EndUpdateDataRetention(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataRetentionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGuestUser

        /// <summary>
        /// Updates the block status of a guest user in a Wickr network. This operation allows
        /// you to block or unblock a guest user from accessing the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGuestUser service method.</param>
        /// 
        /// <returns>The response from the UpdateGuestUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateGuestUser">REST API Reference for UpdateGuestUser Operation</seealso>
        public virtual UpdateGuestUserResponse UpdateGuestUser(UpdateGuestUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGuestUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGuestUserResponseUnmarshaller.Instance;

            return Invoke<UpdateGuestUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGuestUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGuestUser operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGuestUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateGuestUser">REST API Reference for UpdateGuestUser Operation</seealso>
        public virtual IAsyncResult BeginUpdateGuestUser(UpdateGuestUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGuestUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGuestUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGuestUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGuestUser.</param>
        /// 
        /// <returns>Returns a  UpdateGuestUserResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateGuestUser">REST API Reference for UpdateGuestUser Operation</seealso>
        public virtual UpdateGuestUserResponse EndUpdateGuestUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGuestUserResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNetwork

        /// <summary>
        /// Updates the properties of an existing Wickr network, such as its name or encryption
        /// key configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetwork service method.</param>
        /// 
        /// <returns>The response from the UpdateNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateNetwork">REST API Reference for UpdateNetwork Operation</seealso>
        public virtual UpdateNetworkResponse UpdateNetwork(UpdateNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetwork operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateNetwork">REST API Reference for UpdateNetwork Operation</seealso>
        public virtual IAsyncResult BeginUpdateNetwork(UpdateNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateNetwork">REST API Reference for UpdateNetwork Operation</seealso>
        public virtual UpdateNetworkResponse EndUpdateNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNetworkSettings

        /// <summary>
        /// Updates network-level settings for a Wickr network. You can modify settings such as
        /// client metrics, data retention, and other network-wide options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSettings service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        public virtual UpdateNetworkSettingsResponse UpdateNetworkSettings(UpdateNetworkSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateNetworkSettings(UpdateNetworkSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkSettings.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkSettingsResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        public virtual UpdateNetworkSettingsResponse EndUpdateNetworkSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNetworkSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSecurityGroup

        /// <summary>
        /// Updates the properties of an existing security group in a Wickr network, such as its
        /// name or settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateSecurityGroup">REST API Reference for UpdateSecurityGroup Operation</seealso>
        public virtual UpdateSecurityGroupResponse UpdateSecurityGroup(UpdateSecurityGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroup operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateSecurityGroup">REST API Reference for UpdateSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateSecurityGroup(UpdateSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurityGroup.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityGroupResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateSecurityGroup">REST API Reference for UpdateSecurityGroup Operation</seealso>
        public virtual UpdateSecurityGroupResponse EndUpdateSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUser

        /// <summary>
        /// Updates the properties of an existing user in a Wickr network. This operation allows
        /// you to modify the user's name, password, security group membership, and invite code
        /// settings.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>codeValidation</c>, <c>inviteCode</c>, and <c>inviteCodeTtl</c> are restricted
        /// to networks under preview only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonWickrClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UpdateUserResult from Wickr.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserResponse>(asyncResult);
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
            var resolver = new AmazonWickrEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}