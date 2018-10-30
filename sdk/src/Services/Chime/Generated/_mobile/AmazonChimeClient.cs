/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Chime.Model;
using Amazon.Chime.Model.Internal.MarshallTransformations;
using Amazon.Chime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Chime
{
    /// <summary>
    /// Implementation for accessing Chime
    ///
    /// Amazon Chime is a communications service that transforms online meetings with a secure,
    /// easy-to-use application that you can trust. Amazon Chime works seamlessly across your
    /// devices so that you can stay connected. You can use Amazon Chime for online meetings,
    /// video conferencing, calls, and chat. You can also share content, both inside and outside
    /// your organization. Amazon Chime frees you to work productively from anywhere. 
    /// 
    ///  
    /// <para>
    /// The Amazon Chime API is designed for administrators to use to perform key tasks, such
    /// as creating and managing Amazon Chime accounts and users. This guide provides detailed
    /// information about the Amazon Chime API.
    /// </para>
    ///  
    /// <para>
    /// Use host name <code>service.chime.aws.amazon.com</code> when working with the Amazon
    /// Chime API.
    /// </para>
    /// </summary>
    public partial class AmazonChimeClient : AmazonServiceClient, IAmazonChime
    {
        private static IServiceMetadata serviceMetadata = new AmazonChimeMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonChimeClient with the credentials loaded from the application's
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
        public AmazonChimeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeConfig()) { }

        /// <summary>
        /// Constructs AmazonChimeClient with the credentials loaded from the application's
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
        public AmazonChimeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonChimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonChimeClient Configuration Object</param>
        public AmazonChimeClient(AmazonChimeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonChimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonChimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonChimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Credentials and an
        /// AmazonChimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonChimeClient Configuration Object</param>
        public AmazonChimeClient(AWSCredentials credentials, AmazonChimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonChimeClient Configuration Object</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonChimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonChimeClient Configuration Object</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonChimeConfig clientConfig)
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

        
        #region  BatchSuspendUser

        internal virtual BatchSuspendUserResponse BatchSuspendUser(BatchSuspendUserRequest request)
        {
            var marshaller = BatchSuspendUserRequestMarshaller.Instance;
            var unmarshaller = BatchSuspendUserResponseUnmarshaller.Instance;

            return Invoke<BatchSuspendUserRequest,BatchSuspendUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchSuspendUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchSuspendUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchSuspendUser">REST API Reference for BatchSuspendUser Operation</seealso>
        public virtual Task<BatchSuspendUserResponse> BatchSuspendUserAsync(BatchSuspendUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchSuspendUserRequestMarshaller.Instance;
            var unmarshaller = BatchSuspendUserResponseUnmarshaller.Instance;

            return InvokeAsync<BatchSuspendUserRequest,BatchSuspendUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchUnsuspendUser

        internal virtual BatchUnsuspendUserResponse BatchUnsuspendUser(BatchUnsuspendUserRequest request)
        {
            var marshaller = BatchUnsuspendUserRequestMarshaller.Instance;
            var unmarshaller = BatchUnsuspendUserResponseUnmarshaller.Instance;

            return Invoke<BatchUnsuspendUserRequest,BatchUnsuspendUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchUnsuspendUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUnsuspendUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUnsuspendUser">REST API Reference for BatchUnsuspendUser Operation</seealso>
        public virtual Task<BatchUnsuspendUserResponse> BatchUnsuspendUserAsync(BatchUnsuspendUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchUnsuspendUserRequestMarshaller.Instance;
            var unmarshaller = BatchUnsuspendUserResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUnsuspendUserRequest,BatchUnsuspendUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchUpdateUser

        internal virtual BatchUpdateUserResponse BatchUpdateUser(BatchUpdateUserRequest request)
        {
            var marshaller = BatchUpdateUserRequestMarshaller.Instance;
            var unmarshaller = BatchUpdateUserResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateUserRequest,BatchUpdateUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdateUser">REST API Reference for BatchUpdateUser Operation</seealso>
        public virtual Task<BatchUpdateUserResponse> BatchUpdateUserAsync(BatchUpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchUpdateUserRequestMarshaller.Instance;
            var unmarshaller = BatchUpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateUserRequest,BatchUpdateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAccount

        internal virtual CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            var marshaller = CreateAccountRequestMarshaller.Instance;
            var unmarshaller = CreateAccountResponseUnmarshaller.Instance;

            return Invoke<CreateAccountRequest,CreateAccountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        public virtual Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAccountRequestMarshaller.Instance;
            var unmarshaller = CreateAccountResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccountRequest,CreateAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccount

        internal virtual DeleteAccountResponse DeleteAccount(DeleteAccountRequest request)
        {
            var marshaller = DeleteAccountRequestMarshaller.Instance;
            var unmarshaller = DeleteAccountResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountRequest,DeleteAccountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAccount">REST API Reference for DeleteAccount Operation</seealso>
        public virtual Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAccountRequestMarshaller.Instance;
            var unmarshaller = DeleteAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountRequest,DeleteAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccount

        internal virtual GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var marshaller = GetAccountRequestMarshaller.Instance;
            var unmarshaller = GetAccountResponseUnmarshaller.Instance;

            return Invoke<GetAccountRequest,GetAccountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccount">REST API Reference for GetAccount Operation</seealso>
        public virtual Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAccountRequestMarshaller.Instance;
            var unmarshaller = GetAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountRequest,GetAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSettings

        internal virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var marshaller = GetAccountSettingsRequestMarshaller.Instance;
            var unmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsRequest,GetAccountSettingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAccountSettingsRequestMarshaller.Instance;
            var unmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSettingsRequest,GetAccountSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUser

        internal virtual GetUserResponse GetUser(GetUserRequest request)
        {
            var marshaller = GetUserRequestMarshaller.Instance;
            var unmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserRequest,GetUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetUserRequestMarshaller.Instance;
            var unmarshaller = GetUserResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserRequest,GetUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InviteUsers

        internal virtual InviteUsersResponse InviteUsers(InviteUsersRequest request)
        {
            var marshaller = InviteUsersRequestMarshaller.Instance;
            var unmarshaller = InviteUsersResponseUnmarshaller.Instance;

            return Invoke<InviteUsersRequest,InviteUsersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InviteUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/InviteUsers">REST API Reference for InviteUsers Operation</seealso>
        public virtual Task<InviteUsersResponse> InviteUsersAsync(InviteUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = InviteUsersRequestMarshaller.Instance;
            var unmarshaller = InviteUsersResponseUnmarshaller.Instance;

            return InvokeAsync<InviteUsersRequest,InviteUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAccounts

        internal virtual ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            var marshaller = ListAccountsRequestMarshaller.Instance;
            var unmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return Invoke<ListAccountsRequest,ListAccountsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public virtual Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAccountsRequestMarshaller.Instance;
            var unmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountsRequest,ListAccountsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListUsers

        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var marshaller = ListUsersRequestMarshaller.Instance;
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersRequest,ListUsersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListUsersRequestMarshaller.Instance;
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersRequest,ListUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  LogoutUser

        internal virtual LogoutUserResponse LogoutUser(LogoutUserRequest request)
        {
            var marshaller = LogoutUserRequestMarshaller.Instance;
            var unmarshaller = LogoutUserResponseUnmarshaller.Instance;

            return Invoke<LogoutUserRequest,LogoutUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the LogoutUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LogoutUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/LogoutUser">REST API Reference for LogoutUser Operation</seealso>
        public virtual Task<LogoutUserResponse> LogoutUserAsync(LogoutUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = LogoutUserRequestMarshaller.Instance;
            var unmarshaller = LogoutUserResponseUnmarshaller.Instance;

            return InvokeAsync<LogoutUserRequest,LogoutUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetPersonalPIN

        internal virtual ResetPersonalPINResponse ResetPersonalPIN(ResetPersonalPINRequest request)
        {
            var marshaller = ResetPersonalPINRequestMarshaller.Instance;
            var unmarshaller = ResetPersonalPINResponseUnmarshaller.Instance;

            return Invoke<ResetPersonalPINRequest,ResetPersonalPINResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetPersonalPIN operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetPersonalPIN operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ResetPersonalPIN">REST API Reference for ResetPersonalPIN Operation</seealso>
        public virtual Task<ResetPersonalPINResponse> ResetPersonalPINAsync(ResetPersonalPINRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetPersonalPINRequestMarshaller.Instance;
            var unmarshaller = ResetPersonalPINResponseUnmarshaller.Instance;

            return InvokeAsync<ResetPersonalPINRequest,ResetPersonalPINResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccount

        internal virtual UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            var marshaller = UpdateAccountRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountRequest,UpdateAccountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        public virtual Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAccountRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountRequest,UpdateAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccountSettings

        internal virtual UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request)
        {
            var marshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSettingsRequest,UpdateAccountSettingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountSettingsRequest,UpdateAccountSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUser

        internal virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var marshaller = UpdateUserRequestMarshaller.Instance;
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserRequest,UpdateUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateUserRequestMarshaller.Instance;
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserRequest,UpdateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}