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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchCreateUserResponse> BatchCreateUserAsync(BatchCreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchCreateUserResponse>(request, options, cancellationToken);
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
        /// Deletes multiple users from a specified Wickr network. This operation permanently
        /// removes user accounts and their associated data from the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchDeleteUserResponse> BatchDeleteUserAsync(BatchDeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDeleteUserResponse>(request, options, cancellationToken);
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
        /// Looks up multiple user usernames from their unique username hashes (unames). This
        /// operation allows you to retrieve the email addresses associated with a list of username
        /// hashes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchLookupUserUname service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchLookupUserUnameResponse> BatchLookupUserUnameAsync(BatchLookupUserUnameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchLookupUserUnameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchLookupUserUnameResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchLookupUserUnameResponse>(request, options, cancellationToken);
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
        /// Resends invitation codes to multiple users who have pending invitations in a Wickr
        /// network. This operation is useful when users haven't accepted their initial invitations
        /// or when invitations have expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchReinviteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchReinviteUserResponse> BatchReinviteUserAsync(BatchReinviteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchReinviteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchReinviteUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchReinviteUserResponse>(request, options, cancellationToken);
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
        /// Resets multiple devices for a specific user in a Wickr network. This operation forces
        /// the selected devices to log out and requires users to re-authenticate, which is useful
        /// for security purposes or when devices need to be revoked.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchResetDevicesForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchResetDevicesForUserResponse> BatchResetDevicesForUserAsync(BatchResetDevicesForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchResetDevicesForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchResetDevicesForUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchResetDevicesForUserResponse>(request, options, cancellationToken);
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
        /// Suspends or unsuspends multiple users in a Wickr network. Suspended users cannot access
        /// the network until they are unsuspended. This operation is useful for temporarily restricting
        /// access without deleting user accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchToggleUserSuspendStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchToggleUserSuspendStatusResponse> BatchToggleUserSuspendStatusAsync(BatchToggleUserSuspendStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchToggleUserSuspendStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchToggleUserSuspendStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchToggleUserSuspendStatusResponse>(request, options, cancellationToken);
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
        /// Creates a new bot in a specified Wickr network. Bots are automated accounts that can
        /// send and receive messages, enabling integration with external systems and automation
        /// of tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateBotResponse> CreateBotAsync(CreateBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBotResponse>(request, options, cancellationToken);
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
        /// Creates a data retention bot in a Wickr network. Data retention bots are specialized
        /// bots that handle message archiving and compliance by capturing and storing messages
        /// for regulatory or organizational requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRetentionBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateDataRetentionBotResponse> CreateDataRetentionBotAsync(CreateDataRetentionBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataRetentionBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataRetentionBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDataRetentionBotResponse>(request, options, cancellationToken);
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
        /// Creates a new challenge password for the data retention bot. This password is used
        /// for authentication when the bot connects to the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRetentionBotChallenge service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateDataRetentionBotChallengeResponse> CreateDataRetentionBotChallengeAsync(CreateDataRetentionBotChallengeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataRetentionBotChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataRetentionBotChallengeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDataRetentionBotChallengeResponse>(request, options, cancellationToken);
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
        /// Creates a new Wickr network with specified access level and configuration. This operation
        /// provisions a new communication network for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateNetworkResponse> CreateNetworkAsync(CreateNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateNetworkResponse>(request, options, cancellationToken);
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
        /// Creates a new security group in a Wickr network. Security groups allow you to organize
        /// users and control their permissions, features, and security settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSecurityGroupResponse>(request, options, cancellationToken);
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
        /// Deletes a bot from a specified Wickr network. This operation permanently removes the
        /// bot account and its associated data from the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteBotResponse> DeleteBotAsync(DeleteBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBotResponse>(request, options, cancellationToken);
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
        /// Deletes the data retention bot from a Wickr network. This operation permanently removes
        /// the bot and all its associated data from the database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataRetentionBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteDataRetentionBotResponse> DeleteDataRetentionBotAsync(DeleteDataRetentionBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataRetentionBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataRetentionBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDataRetentionBotResponse>(request, options, cancellationToken);
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
        /// Deletes a Wickr network and all its associated resources, including users, bots, security
        /// groups, and settings. This operation is permanent and cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteNetworkResponse> DeleteNetworkAsync(DeleteNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteNetworkResponse>(request, options, cancellationToken);
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
        /// Deletes a security group from a Wickr network. This operation cannot be performed
        /// on the default security group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSecurityGroupResponse>(request, options, cancellationToken);
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
        /// Retrieves detailed information about a specific bot in a Wickr network, including
        /// its status, group membership, and authentication details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetBotResponse> GetBotAsync(GetBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBotResponse>(request, options, cancellationToken);
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
        /// Retrieves the count of bots in a Wickr network, categorized by their status (pending,
        /// active, and total).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotsCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetBotsCountResponse> GetBotsCountAsync(GetBotsCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBotsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotsCountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBotsCountResponse>(request, options, cancellationToken);
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
        /// Retrieves information about the data retention bot in a Wickr network, including its
        /// status and whether the data retention service is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetentionBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetDataRetentionBotResponse> GetDataRetentionBotAsync(GetDataRetentionBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataRetentionBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataRetentionBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDataRetentionBotResponse>(request, options, cancellationToken);
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
        /// Retrieves historical guest user count data for a Wickr network, showing the number
        /// of guest users per billing period over the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGuestUserHistoryCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetGuestUserHistoryCountResponse> GetGuestUserHistoryCountAsync(GetGuestUserHistoryCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGuestUserHistoryCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGuestUserHistoryCountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGuestUserHistoryCountResponse>(request, options, cancellationToken);
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
        /// Retrieves detailed information about a specific Wickr network, including its configuration,
        /// access level, and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetNetworkResponse> GetNetworkAsync(GetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNetworkResponse>(request, options, cancellationToken);
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
        /// Retrieves all network-level settings for a Wickr network, including client metrics,
        /// data retention, and other configuration options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetNetworkSettingsResponse> GetNetworkSettingsAsync(GetNetworkSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNetworkSettingsResponse>(request, options, cancellationToken);
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
        /// Retrieves the OpenID Connect (OIDC) configuration for a Wickr network, including SSO
        /// settings and optional token information if access token parameters are provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOidcInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetOidcInfoResponse> GetOidcInfoAsync(GetOidcInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOidcInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOidcInfoResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOidcInfoResponse>(request, options, cancellationToken);
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
        /// Retrieves detailed information about a specific security group in a Wickr network,
        /// including its settings, member counts, and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetSecurityGroupResponse> GetSecurityGroupAsync(GetSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSecurityGroupResponse>(request, options, cancellationToken);
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
        /// Retrieves detailed information about a specific user in a Wickr network, including
        /// their profile, status, and activity history.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUserResponse>(request, options, cancellationToken);
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
        /// Retrieves the count of users in a Wickr network, categorized by their status (pending,
        /// active, rejected) and showing how many users can still be added.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsersCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetUsersCountResponse> GetUsersCountAsync(GetUsersCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsersCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsersCountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUsersCountResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of guest users who have been blocked from a Wickr network.
        /// You can filter and sort the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlockedGuestUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListBlockedGuestUsersResponse> ListBlockedGuestUsersAsync(ListBlockedGuestUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBlockedGuestUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlockedGuestUsersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBlockedGuestUsersResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of bots in a specified Wickr network. You can filter and
        /// sort the results based on various criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListBotsResponse> ListBotsAsync(ListBotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBotsResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of devices associated with a specific user in a Wickr network.
        /// This operation returns information about all devices where the user has logged into
        /// Wickr.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListDevicesForUserResponse> ListDevicesForUserAsync(ListDevicesForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevicesForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesForUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDevicesForUserResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of guest users who have communicated with your Wickr network.
        /// Guest users are external users from federated networks who can communicate with network
        /// members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGuestUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListGuestUsersResponse> ListGuestUsersAsync(ListGuestUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGuestUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGuestUsersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGuestUsersResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of all Wickr networks associated with your Amazon Web Services
        /// account. You can sort the results by network ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListNetworksResponse> ListNetworksAsync(ListNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNetworksResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of security groups in a specified Wickr network. You can
        /// sort the results by various criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListSecurityGroupsResponse> ListSecurityGroupsAsync(ListSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSecurityGroupsResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of users who belong to a specific security group in a Wickr
        /// network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityGroupUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListSecurityGroupUsersResponse> ListSecurityGroupUsersAsync(ListSecurityGroupUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityGroupUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityGroupUsersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSecurityGroupUsersResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of users in a specified Wickr network. You can filter and
        /// sort the results based on various criteria such as name, status, or security group
        /// membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListUsersResponse>(request, options, cancellationToken);
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
        /// Registers and saves an OpenID Connect (OIDC) configuration for a Wickr network, enabling
        /// Single Sign-On (SSO) authentication through an identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOidcConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RegisterOidcConfigResponse> RegisterOidcConfigAsync(RegisterOidcConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterOidcConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOidcConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterOidcConfigResponse>(request, options, cancellationToken);
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
        /// Tests an OpenID Connect (OIDC) configuration for a Wickr network by validating the
        /// connection to the identity provider and retrieving its supported capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOidcConfigTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RegisterOidcConfigTestResponse> RegisterOidcConfigTestAsync(RegisterOidcConfigTestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterOidcConfigTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOidcConfigTestResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterOidcConfigTestResponse>(request, options, cancellationToken);
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
        /// Updates the properties of an existing bot in a Wickr network. This operation allows
        /// you to modify the bot's display name, security group, password, or suspension status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateBotResponse> UpdateBotAsync(UpdateBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBotResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBotResponse>(request, options, cancellationToken);
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
        /// Updates the data retention bot settings, allowing you to enable or disable the data
        /// retention service, or acknowledge the public key message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRetention service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateDataRetentionResponse> UpdateDataRetentionAsync(UpdateDataRetentionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataRetentionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDataRetentionResponse>(request, options, cancellationToken);
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
        /// Updates the block status of a guest user in a Wickr network. This operation allows
        /// you to block or unblock a guest user from accessing the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGuestUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateGuestUserResponse> UpdateGuestUserAsync(UpdateGuestUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGuestUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGuestUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGuestUserResponse>(request, options, cancellationToken);
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
        /// Updates the properties of an existing Wickr network, such as its name or encryption
        /// key configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateNetworkResponse> UpdateNetworkAsync(UpdateNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNetworkResponse>(request, options, cancellationToken);
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
        /// Updates network-level settings for a Wickr network. You can modify settings such as
        /// client metrics, data retention, and other network-wide options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateNetworkSettingsResponse> UpdateNetworkSettingsAsync(UpdateNetworkSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNetworkSettingsResponse>(request, options, cancellationToken);
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
        /// Updates the properties of an existing security group in a Wickr network, such as its
        /// name or settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateSecurityGroupResponse> UpdateSecurityGroupAsync(UpdateSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSecurityGroupResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateUserResponse>(request, options, cancellationToken);
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