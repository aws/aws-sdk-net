/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.CognitoIdentity.Model;
using Amazon.CognitoIdentity.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentity
{
    /// <summary>
    /// Implementation for accessing CognitoIdentity
    /// 
    /// Amazon Cognito
    /// <para>
    /// Amazon Cognito is a web service that facilitates the delivery of scoped, temporary
    /// credentials to mobile devices or other untrusted environments. Amazon Cognito uniquely
    /// identifies a device or user and supplies the user with a consistent identity throughout
    /// the lifetime of an application.
    /// </para>
    /// 
    /// <para>
    /// Amazon Cognito lets users authenticate with third-party identity providers (Facebook,
    /// Google, or Login with Amazon). As a developer, you decide which identity providers
    /// to trust. You can also choose to support unauthenticated access from your application.
    /// Your users are provided with Cognito tokens that uniquely identify their device and
    /// any information provided about third-party logins.
    /// </para>
    /// </summary>
	public partial class AmazonCognitoIdentityClient : AmazonWebServiceClient, Amazon.CognitoIdentity.IAmazonCognitoIdentity
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCognitoIdentityClient(AWSCredentials credentials)
            : this(credentials, new AmazonCognitoIdentityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCognitoIdentityConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Credentials and an
        /// AmazonCognitoIdentityClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityClient Configuration Object</param>
        public AmazonCognitoIdentityClient(AWSCredentials credentials, AmazonCognitoIdentityConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoIdentityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoIdentityConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoIdentityClient Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityClient Configuration Object</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoIdentityConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoIdentityClient Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityClient Configuration Object</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoIdentityConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal CreateIdentityPoolResponse CreateIdentityPool(CreateIdentityPoolRequest request)
        {
            var task = CreateIdentityPoolAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Creates a new identity pool. The identity pool is a store of user identity information
        /// that is specific to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityPool service method.</param>
        /// 
        /// <returns>The response from the CreateIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.LimitExceededException">
        /// Thrown when the total number of user pools has exceeded a preset limit.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateIdentityPoolResponse> CreateIdentityPoolAsync(CreateIdentityPoolRequest createIdentityPoolRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateIdentityPoolRequestMarshaller();
            var unmarshaller = CreateIdentityPoolResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateIdentityPoolRequest, CreateIdentityPoolResponse>(createIdentityPoolRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteIdentityPoolResponse DeleteIdentityPool(DeleteIdentityPoolRequest request)
        {
            var task = DeleteIdentityPoolAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Deletes a user pool. Once a pool is deleted, users will not be able to authenticate
        /// with the pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPool service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(DeleteIdentityPoolRequest deleteIdentityPoolRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteIdentityPoolRequestMarshaller();
            var unmarshaller = DeleteIdentityPoolResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteIdentityPoolRequest, DeleteIdentityPoolResponse>(deleteIdentityPoolRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeIdentityPoolResponse DescribeIdentityPool(DescribeIdentityPoolRequest request)
        {
            var task = DescribeIdentityPoolAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Gets details about a particular identity pool, including the pool name, ID description,
        /// creation date, and current number of users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPool service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(DescribeIdentityPoolRequest describeIdentityPoolRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeIdentityPoolRequestMarshaller();
            var unmarshaller = DescribeIdentityPoolResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeIdentityPoolRequest, DescribeIdentityPoolResponse>(describeIdentityPoolRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetIdResponse GetId(GetIdRequest request)
        {
            var task = GetIdAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Generates (or retrieves) a Cognito ID. Supplying multiple logins will create an implicit
        /// linked account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetId service method.</param>
        /// 
        /// <returns>The response from the GetId service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.LimitExceededException">
        /// Thrown when the total number of user pools has exceeded a preset limit.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetIdResponse> GetIdAsync(GetIdRequest getIdRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIdRequestMarshaller();
            var unmarshaller = GetIdResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetIdRequest, GetIdResponse>(getIdRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetOpenIdTokenResponse GetOpenIdToken(GetOpenIdTokenRequest request)
        {
            var task = GetOpenIdTokenAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Gets an OpenID token, using a known Cognito ID. This known Cognito ID is returned
        /// from GetId. You can optionally add additional logins for the identity. Supplying multiple
        /// logins creates an implicit link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdToken service method.</param>
        /// 
        /// <returns>The response from the GetOpenIdToken service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(GetOpenIdTokenRequest getOpenIdTokenRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetOpenIdTokenRequestMarshaller();
            var unmarshaller = GetOpenIdTokenResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetOpenIdTokenRequest, GetOpenIdTokenResponse>(getOpenIdTokenRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
        {
            var task = ListIdentitiesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Lists the identities in a pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities service method.</param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest listIdentitiesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListIdentitiesRequestMarshaller();
            var unmarshaller = ListIdentitiesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListIdentitiesRequest, ListIdentitiesResponse>(listIdentitiesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListIdentityPoolsResponse ListIdentityPools(ListIdentityPoolsRequest request)
        {
            var task = ListIdentityPoolsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Lists all of the Cognito identity pools registered for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPools service method.</param>
        /// 
        /// <returns>The response from the ListIdentityPools service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListIdentityPoolsResponse> ListIdentityPoolsAsync(ListIdentityPoolsRequest listIdentityPoolsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListIdentityPoolsRequestMarshaller();
            var unmarshaller = ListIdentityPoolsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListIdentityPoolsRequest, ListIdentityPoolsResponse>(listIdentityPoolsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UnlinkIdentityResponse UnlinkIdentity(UnlinkIdentityRequest request)
        {
            var task = UnlinkIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Unlinks a federated identity from an existing account. Unlinked logins will be considered
        /// new identities next time they are seen. Removing the last linked login will make this
        /// identity inaccessible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnlinkIdentity service method.</param>
        /// 
        /// <returns>The response from the UnlinkIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UnlinkIdentityResponse> UnlinkIdentityAsync(UnlinkIdentityRequest unlinkIdentityRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnlinkIdentityRequestMarshaller();
            var unmarshaller = UnlinkIdentityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UnlinkIdentityRequest, UnlinkIdentityResponse>(unlinkIdentityRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateIdentityPoolResponse UpdateIdentityPool(UpdateIdentityPoolRequest request)
        {
            var task = UpdateIdentityPoolAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Updates a user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPool service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(UpdateIdentityPoolRequest updateIdentityPoolRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateIdentityPoolRequestMarshaller();
            var unmarshaller = UpdateIdentityPoolResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateIdentityPoolRequest, UpdateIdentityPoolResponse>(updateIdentityPoolRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
