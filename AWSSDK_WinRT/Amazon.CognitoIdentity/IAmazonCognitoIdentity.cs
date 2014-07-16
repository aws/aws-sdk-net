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
using System.Threading;
using System.Threading.Tasks;

using Amazon.CognitoIdentity.Model;

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
	public partial interface IAmazonCognitoIdentity : IDisposable
    {
 
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
		Task<CreateIdentityPoolResponse> CreateIdentityPoolAsync(CreateIdentityPoolRequest createIdentityPoolRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(DeleteIdentityPoolRequest deleteIdentityPoolRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(DescribeIdentityPoolRequest describeIdentityPoolRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetIdResponse> GetIdAsync(GetIdRequest getIdRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(GetOpenIdTokenRequest getOpenIdTokenRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest listIdentitiesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<ListIdentityPoolsResponse> ListIdentityPoolsAsync(ListIdentityPoolsRequest listIdentityPoolsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<UnlinkIdentityResponse> UnlinkIdentityAsync(UnlinkIdentityRequest unlinkIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(UpdateIdentityPoolRequest updateIdentityPoolRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
