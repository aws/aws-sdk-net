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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CognitoIdentity.Model;

namespace Amazon.CognitoIdentity
{
    /// <summary>
    /// Interface for accessing CognitoIdentity
    ///
    /// Amazon Cognito Federated Identities 
    /// <para>
    /// Amazon Cognito Federated Identities is a web service that delivers scoped temporary
    /// credentials to mobile devices and other untrusted environments. It uniquely identifies
    /// a device and supplies the user with a consistent identity over the lifetime of an
    /// application.
    /// </para>
    ///  
    /// <para>
    /// Using Amazon Cognito Federated Identities, you can enable authentication with one
    /// or more third-party identity providers (Facebook, Google, or Login with Amazon) or
    /// an Amazon Cognito user pool, and you can also choose to support unauthenticated access
    /// from your app. Cognito delivers a unique identifier for each user and acts as an OpenID
    /// token provider trusted by AWS Security Token Service (STS) to access temporary, limited-privilege
    /// AWS credentials.
    /// </para>
    ///  
    /// <para>
    /// For a description of the authentication flow from the Amazon Cognito Developer Guide
    /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/authentication-flow.html">Authentication
    /// Flow</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-identity.html">Amazon
    /// Cognito Federated Identities</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCognitoIdentity : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICognitoIdentityPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateIdentityPool


        /// <summary>
        /// Creates a new identity pool. The identity pool is a store of user identity information
        /// that is specific to your AWS account. The keys for <code>SupportedLoginProviders</code>
        /// are as follows:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Facebook: <code>graph.facebook.com</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Google: <code>accounts.google.com</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon: <code>www.amazon.com</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Twitter: <code>api.twitter.com</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Digits: <code>www.digits.com</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityPool service method.</param>
        /// 
        /// <returns>The response from the CreateIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.LimitExceededException">
        /// Thrown when the total number of user pools has exceeded a preset limit.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/CreateIdentityPool">REST API Reference for CreateIdentityPool Operation</seealso>
        CreateIdentityPoolResponse CreateIdentityPool(CreateIdentityPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityPool operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdentityPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/CreateIdentityPool">REST API Reference for CreateIdentityPool Operation</seealso>
        IAsyncResult BeginCreateIdentityPool(CreateIdentityPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdentityPool.</param>
        /// 
        /// <returns>Returns a  CreateIdentityPoolResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/CreateIdentityPool">REST API Reference for CreateIdentityPool Operation</seealso>
        CreateIdentityPoolResponse EndCreateIdentityPool(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIdentities


        /// <summary>
        /// Deletes identities from an identity pool. You can specify a list of 1-60 identities
        /// that you want to delete.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentities service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentities service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentities">REST API Reference for DeleteIdentities Operation</seealso>
        DeleteIdentitiesResponse DeleteIdentities(DeleteIdentitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentities operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentities">REST API Reference for DeleteIdentities Operation</seealso>
        IAsyncResult BeginDeleteIdentities(DeleteIdentitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentities.</param>
        /// 
        /// <returns>Returns a  DeleteIdentitiesResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentities">REST API Reference for DeleteIdentities Operation</seealso>
        DeleteIdentitiesResponse EndDeleteIdentities(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIdentityPool


        /// <summary>
        /// Deletes an identity pool. Once a pool is deleted, users will not be able to authenticate
        /// with the pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">An identity pool ID in the format REGION:GUID.</param>
        /// 
        /// <returns>The response from the DeleteIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentityPool">REST API Reference for DeleteIdentityPool Operation</seealso>
        DeleteIdentityPoolResponse DeleteIdentityPool(string identityPoolId);

        /// <summary>
        /// Deletes an identity pool. Once a pool is deleted, users will not be able to authenticate
        /// with the pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPool service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentityPool">REST API Reference for DeleteIdentityPool Operation</seealso>
        DeleteIdentityPoolResponse DeleteIdentityPool(DeleteIdentityPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPool operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentityPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentityPool">REST API Reference for DeleteIdentityPool Operation</seealso>
        IAsyncResult BeginDeleteIdentityPool(DeleteIdentityPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentityPool.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityPoolResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentityPool">REST API Reference for DeleteIdentityPool Operation</seealso>
        DeleteIdentityPoolResponse EndDeleteIdentityPool(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIdentity


        /// <summary>
        /// Returns metadata related to the given identity, including when the identity was created
        /// and any associated linked logins.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityId">A unique identifier in the format REGION:GUID.</param>
        /// 
        /// <returns>The response from the DescribeIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentity">REST API Reference for DescribeIdentity Operation</seealso>
        DescribeIdentityResponse DescribeIdentity(string identityId);

        /// <summary>
        /// Returns metadata related to the given identity, including when the identity was created
        /// and any associated linked logins.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentity service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentity">REST API Reference for DescribeIdentity Operation</seealso>
        DescribeIdentityResponse DescribeIdentity(DescribeIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentity operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentity">REST API Reference for DescribeIdentity Operation</seealso>
        IAsyncResult BeginDescribeIdentity(DescribeIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentity.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentity">REST API Reference for DescribeIdentity Operation</seealso>
        DescribeIdentityResponse EndDescribeIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIdentityPool


        /// <summary>
        /// Gets details about a particular identity pool, including the pool name, ID description,
        /// creation date, and current number of users.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">An identity pool ID in the format REGION:GUID.</param>
        /// 
        /// <returns>The response from the DescribeIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentityPool">REST API Reference for DescribeIdentityPool Operation</seealso>
        DescribeIdentityPoolResponse DescribeIdentityPool(string identityPoolId);

        /// <summary>
        /// Gets details about a particular identity pool, including the pool name, ID description,
        /// creation date, and current number of users.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPool service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentityPool">REST API Reference for DescribeIdentityPool Operation</seealso>
        DescribeIdentityPoolResponse DescribeIdentityPool(DescribeIdentityPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPool operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentityPool">REST API Reference for DescribeIdentityPool Operation</seealso>
        IAsyncResult BeginDescribeIdentityPool(DescribeIdentityPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityPool.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityPoolResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentityPool">REST API Reference for DescribeIdentityPool Operation</seealso>
        DescribeIdentityPoolResponse EndDescribeIdentityPool(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCredentialsForIdentity


        /// <summary>
        /// Returns credentials for the provided identity ID. Any provided logins will be validated
        /// against supported login providers. If the token is for cognito-identity.amazonaws.com,
        /// it will be passed through to AWS Security Token Service with the appropriate role
        /// for the token.
        /// 
        ///  
        /// <para>
        /// This is a public API. You do not need any credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityId">A unique identifier in the format REGION:GUID.</param>
        /// 
        /// <returns>The response from the GetCredentialsForIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ExternalServiceException">
        /// An exception thrown when a dependent service such as Facebook or Twitter is not responding
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidIdentityPoolConfigurationException">
        /// Thrown if the identity pool has no role associated for the given auth type (auth/unauth)
        /// or if the AssumeRole fails.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetCredentialsForIdentity">REST API Reference for GetCredentialsForIdentity Operation</seealso>
        GetCredentialsForIdentityResponse GetCredentialsForIdentity(string identityId);

        /// <summary>
        /// Returns credentials for the provided identity ID. Any provided logins will be validated
        /// against supported login providers. If the token is for cognito-identity.amazonaws.com,
        /// it will be passed through to AWS Security Token Service with the appropriate role
        /// for the token.
        /// 
        ///  
        /// <para>
        /// This is a public API. You do not need any credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityId">A unique identifier in the format REGION:GUID.</param>
        /// <param name="logins">A set of optional name-value pairs that map provider names to provider tokens. The name-value pair will follow the syntax "provider_name": "provider_user_identifier". Logins should not be specified when trying to get credentials for an unauthenticated identity. The Logins parameter is required when using identities associated with external identity providers such as FaceBook. For examples of <code>Logins</code> maps, see the code examples in the <a href="http://docs.aws.amazon.com/cognito/latest/developerguide/external-identity-providers.html">External Identity Providers</a> section of the Amazon Cognito Developer Guide.</param>
        /// 
        /// <returns>The response from the GetCredentialsForIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ExternalServiceException">
        /// An exception thrown when a dependent service such as Facebook or Twitter is not responding
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidIdentityPoolConfigurationException">
        /// Thrown if the identity pool has no role associated for the given auth type (auth/unauth)
        /// or if the AssumeRole fails.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetCredentialsForIdentity">REST API Reference for GetCredentialsForIdentity Operation</seealso>
        GetCredentialsForIdentityResponse GetCredentialsForIdentity(string identityId, Dictionary<string, string> logins);

        /// <summary>
        /// Returns credentials for the provided identity ID. Any provided logins will be validated
        /// against supported login providers. If the token is for cognito-identity.amazonaws.com,
        /// it will be passed through to AWS Security Token Service with the appropriate role
        /// for the token.
        /// 
        ///  
        /// <para>
        /// This is a public API. You do not need any credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialsForIdentity service method.</param>
        /// 
        /// <returns>The response from the GetCredentialsForIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ExternalServiceException">
        /// An exception thrown when a dependent service such as Facebook or Twitter is not responding
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidIdentityPoolConfigurationException">
        /// Thrown if the identity pool has no role associated for the given auth type (auth/unauth)
        /// or if the AssumeRole fails.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetCredentialsForIdentity">REST API Reference for GetCredentialsForIdentity Operation</seealso>
        GetCredentialsForIdentityResponse GetCredentialsForIdentity(GetCredentialsForIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialsForIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialsForIdentity operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCredentialsForIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetCredentialsForIdentity">REST API Reference for GetCredentialsForIdentity Operation</seealso>
        IAsyncResult BeginGetCredentialsForIdentity(GetCredentialsForIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCredentialsForIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCredentialsForIdentity.</param>
        /// 
        /// <returns>Returns a  GetCredentialsForIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetCredentialsForIdentity">REST API Reference for GetCredentialsForIdentity Operation</seealso>
        GetCredentialsForIdentityResponse EndGetCredentialsForIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  GetId


        /// <summary>
        /// Generates (or retrieves) a Cognito ID. Supplying multiple logins will create an implicit
        /// linked account.
        /// 
        ///  
        /// <para>
        /// This is a public API. You do not need any credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetId service method.</param>
        /// 
        /// <returns>The response from the GetId service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ExternalServiceException">
        /// An exception thrown when a dependent service such as Facebook or Twitter is not responding
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.LimitExceededException">
        /// Thrown when the total number of user pools has exceeded a preset limit.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetId">REST API Reference for GetId Operation</seealso>
        GetIdResponse GetId(GetIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetId operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetId">REST API Reference for GetId Operation</seealso>
        IAsyncResult BeginGetId(GetIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetId.</param>
        /// 
        /// <returns>Returns a  GetIdResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetId">REST API Reference for GetId Operation</seealso>
        GetIdResponse EndGetId(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIdentityPoolRoles


        /// <summary>
        /// Gets the roles for an identity pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">An identity pool ID in the format REGION:GUID.</param>
        /// 
        /// <returns>The response from the GetIdentityPoolRoles service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetIdentityPoolRoles">REST API Reference for GetIdentityPoolRoles Operation</seealso>
        GetIdentityPoolRolesResponse GetIdentityPoolRoles(string identityPoolId);

        /// <summary>
        /// Gets the roles for an identity pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolRoles service method.</param>
        /// 
        /// <returns>The response from the GetIdentityPoolRoles service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetIdentityPoolRoles">REST API Reference for GetIdentityPoolRoles Operation</seealso>
        GetIdentityPoolRolesResponse GetIdentityPoolRoles(GetIdentityPoolRolesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityPoolRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolRoles operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityPoolRoles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetIdentityPoolRoles">REST API Reference for GetIdentityPoolRoles Operation</seealso>
        IAsyncResult BeginGetIdentityPoolRoles(GetIdentityPoolRolesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityPoolRoles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityPoolRoles.</param>
        /// 
        /// <returns>Returns a  GetIdentityPoolRolesResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetIdentityPoolRoles">REST API Reference for GetIdentityPoolRoles Operation</seealso>
        GetIdentityPoolRolesResponse EndGetIdentityPoolRoles(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOpenIdToken


        /// <summary>
        /// Gets an OpenID token, using a known Cognito ID. This known Cognito ID is returned
        /// by <a>GetId</a>. You can optionally add additional logins for the identity. Supplying
        /// multiple logins creates an implicit link.
        /// 
        ///  
        /// <para>
        /// The OpenId token is valid for 10 minutes.
        /// </para>
        ///  
        /// <para>
        /// This is a public API. You do not need any credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityId">A unique identifier in the format REGION:GUID.</param>
        /// 
        /// <returns>The response from the GetOpenIdToken service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ExternalServiceException">
        /// An exception thrown when a dependent service such as Facebook or Twitter is not responding
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdToken">REST API Reference for GetOpenIdToken Operation</seealso>
        GetOpenIdTokenResponse GetOpenIdToken(string identityId);

        /// <summary>
        /// Gets an OpenID token, using a known Cognito ID. This known Cognito ID is returned
        /// by <a>GetId</a>. You can optionally add additional logins for the identity. Supplying
        /// multiple logins creates an implicit link.
        /// 
        ///  
        /// <para>
        /// The OpenId token is valid for 10 minutes.
        /// </para>
        ///  
        /// <para>
        /// This is a public API. You do not need any credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdToken service method.</param>
        /// 
        /// <returns>The response from the GetOpenIdToken service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ExternalServiceException">
        /// An exception thrown when a dependent service such as Facebook or Twitter is not responding
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdToken">REST API Reference for GetOpenIdToken Operation</seealso>
        GetOpenIdTokenResponse GetOpenIdToken(GetOpenIdTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIdToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdToken operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOpenIdToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdToken">REST API Reference for GetOpenIdToken Operation</seealso>
        IAsyncResult BeginGetOpenIdToken(GetOpenIdTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpenIdToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpenIdToken.</param>
        /// 
        /// <returns>Returns a  GetOpenIdTokenResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdToken">REST API Reference for GetOpenIdToken Operation</seealso>
        GetOpenIdTokenResponse EndGetOpenIdToken(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOpenIdTokenForDeveloperIdentity


        /// <summary>
        /// Registers (or retrieves) a Cognito <code>IdentityId</code> and an OpenID Connect token
        /// for a user authenticated by your backend authentication process. Supplying multiple
        /// logins will create an implicit linked account. You can only specify one developer
        /// provider as part of the <code>Logins</code> map, which is linked to the identity pool.
        /// The developer provider is the "domain" by which Cognito will refer to your users.
        /// 
        ///  
        /// <para>
        /// You can use <code>GetOpenIdTokenForDeveloperIdentity</code> to create a new identity
        /// and to link new logins (that is, user credentials issued by a public provider or developer
        /// provider) to an existing identity. When you want to create a new identity, the <code>IdentityId</code>
        /// should be null. When you want to associate a new login with an existing authenticated/unauthenticated
        /// identity, you can do so by providing the existing <code>IdentityId</code>. This API
        /// will create the identity in the specified <code>IdentityPoolId</code>.
        /// </para>
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdTokenForDeveloperIdentity service method.</param>
        /// 
        /// <returns>The response from the GetOpenIdTokenForDeveloperIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.DeveloperUserAlreadyRegisteredException">
        /// The provided developer user identifier is already registered with Cognito under a
        /// different identity ID.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdTokenForDeveloperIdentity">REST API Reference for GetOpenIdTokenForDeveloperIdentity Operation</seealso>
        GetOpenIdTokenForDeveloperIdentityResponse GetOpenIdTokenForDeveloperIdentity(GetOpenIdTokenForDeveloperIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIdTokenForDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdTokenForDeveloperIdentity operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOpenIdTokenForDeveloperIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdTokenForDeveloperIdentity">REST API Reference for GetOpenIdTokenForDeveloperIdentity Operation</seealso>
        IAsyncResult BeginGetOpenIdTokenForDeveloperIdentity(GetOpenIdTokenForDeveloperIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpenIdTokenForDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpenIdTokenForDeveloperIdentity.</param>
        /// 
        /// <returns>Returns a  GetOpenIdTokenForDeveloperIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdTokenForDeveloperIdentity">REST API Reference for GetOpenIdTokenForDeveloperIdentity Operation</seealso>
        GetOpenIdTokenForDeveloperIdentityResponse EndGetOpenIdTokenForDeveloperIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIdentities


        /// <summary>
        /// Lists the identities in an identity pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities service method.</param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        IAsyncResult BeginListIdentities(ListIdentitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentities.</param>
        /// 
        /// <returns>Returns a  ListIdentitiesResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        ListIdentitiesResponse EndListIdentities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIdentityPools


        /// <summary>
        /// Lists all of the Cognito identity pools registered for your account.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPools service method.</param>
        /// 
        /// <returns>The response from the ListIdentityPools service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentityPools">REST API Reference for ListIdentityPools Operation</seealso>
        ListIdentityPoolsResponse ListIdentityPools(ListIdentityPoolsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPools operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityPools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentityPools">REST API Reference for ListIdentityPools Operation</seealso>
        IAsyncResult BeginListIdentityPools(ListIdentityPoolsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityPools.</param>
        /// 
        /// <returns>Returns a  ListIdentityPoolsResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentityPools">REST API Reference for ListIdentityPools Operation</seealso>
        ListIdentityPoolsResponse EndListIdentityPools(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags that are assigned to an Amazon Cognito identity pool.
        /// 
        ///  
        /// <para>
        /// A tag is a label that you can apply to identity pools to categorize and manage them
        /// in different ways, such as by purpose, owner, environment, or other criteria.
        /// </para>
        ///  
        /// <para>
        /// You can use this action up to 10 times per second, per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  LookupDeveloperIdentity


        /// <summary>
        /// Retrieves the <code>IdentityID</code> associated with a <code>DeveloperUserIdentifier</code>
        /// or the list of <code>DeveloperUserIdentifier</code> values associated with an <code>IdentityId</code>
        /// for an existing identity. Either <code>IdentityID</code> or <code>DeveloperUserIdentifier</code>
        /// must not be null. If you supply only one of these values, the other value will be
        /// searched in the database and returned as a part of the response. If you supply both,
        /// <code>DeveloperUserIdentifier</code> will be matched against <code>IdentityID</code>.
        /// If the values are verified against the database, the response returns both values
        /// and is the same as the request. Otherwise a <code>ResourceConflictException</code>
        /// is thrown.
        /// 
        ///  
        /// <para>
        ///  <code>LookupDeveloperIdentity</code> is intended for low-throughput control plane
        /// operations: for example, to enable customer service to locate an identity ID by username.
        /// If you are using it for higher-volume operations such as user authentication, your
        /// requests are likely to be throttled. <a>GetOpenIdTokenForDeveloperIdentity</a> is
        /// a better option for higher-volume operations for user authentication.
        /// </para>
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LookupDeveloperIdentity service method.</param>
        /// 
        /// <returns>The response from the LookupDeveloperIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/LookupDeveloperIdentity">REST API Reference for LookupDeveloperIdentity Operation</seealso>
        LookupDeveloperIdentityResponse LookupDeveloperIdentity(LookupDeveloperIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the LookupDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LookupDeveloperIdentity operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLookupDeveloperIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/LookupDeveloperIdentity">REST API Reference for LookupDeveloperIdentity Operation</seealso>
        IAsyncResult BeginLookupDeveloperIdentity(LookupDeveloperIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  LookupDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLookupDeveloperIdentity.</param>
        /// 
        /// <returns>Returns a  LookupDeveloperIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/LookupDeveloperIdentity">REST API Reference for LookupDeveloperIdentity Operation</seealso>
        LookupDeveloperIdentityResponse EndLookupDeveloperIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  MergeDeveloperIdentities


        /// <summary>
        /// Merges two users having different <code>IdentityId</code>s, existing in the same identity
        /// pool, and identified by the same developer provider. You can use this action to request
        /// that discrete users be merged and identified as a single user in the Cognito environment.
        /// Cognito associates the given source user (<code>SourceUserIdentifier</code>) with
        /// the <code>IdentityId</code> of the <code>DestinationUserIdentifier</code>. Only developer-authenticated
        /// users can be merged. If the users to be merged are associated with the same public
        /// provider, but as two different users, an exception will be thrown.
        /// 
        ///  
        /// <para>
        /// The number of linked logins is limited to 20. So, the number of linked logins for
        /// the source user, <code>SourceUserIdentifier</code>, and the destination user, <code>DestinationUserIdentifier</code>,
        /// together should not be larger than 20. Otherwise, an exception will be thrown.
        /// </para>
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeDeveloperIdentities service method.</param>
        /// 
        /// <returns>The response from the MergeDeveloperIdentities service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/MergeDeveloperIdentities">REST API Reference for MergeDeveloperIdentities Operation</seealso>
        MergeDeveloperIdentitiesResponse MergeDeveloperIdentities(MergeDeveloperIdentitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MergeDeveloperIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeDeveloperIdentities operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMergeDeveloperIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/MergeDeveloperIdentities">REST API Reference for MergeDeveloperIdentities Operation</seealso>
        IAsyncResult BeginMergeDeveloperIdentities(MergeDeveloperIdentitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MergeDeveloperIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergeDeveloperIdentities.</param>
        /// 
        /// <returns>Returns a  MergeDeveloperIdentitiesResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/MergeDeveloperIdentities">REST API Reference for MergeDeveloperIdentities Operation</seealso>
        MergeDeveloperIdentitiesResponse EndMergeDeveloperIdentities(IAsyncResult asyncResult);

        #endregion
        
        #region  SetIdentityPoolRoles


        /// <summary>
        /// Sets the roles for an identity pool. These roles are used when making calls to <a>GetCredentialsForIdentity</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">An identity pool ID in the format REGION:GUID.</param>
        /// <param name="roles">The map of roles associated with this pool. For a given role, the key will be either "authenticated" or "unauthenticated" and the value will be the Role ARN.</param>
        /// 
        /// <returns>The response from the SetIdentityPoolRoles service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ConcurrentModificationException">
        /// Thrown if there are parallel requests to modify a resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/SetIdentityPoolRoles">REST API Reference for SetIdentityPoolRoles Operation</seealso>
        SetIdentityPoolRolesResponse SetIdentityPoolRoles(string identityPoolId, Dictionary<string, string> roles);

        /// <summary>
        /// Sets the roles for an identity pool. These roles are used when making calls to <a>GetCredentialsForIdentity</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolRoles service method.</param>
        /// 
        /// <returns>The response from the SetIdentityPoolRoles service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ConcurrentModificationException">
        /// Thrown if there are parallel requests to modify a resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/SetIdentityPoolRoles">REST API Reference for SetIdentityPoolRoles Operation</seealso>
        SetIdentityPoolRolesResponse SetIdentityPoolRoles(SetIdentityPoolRolesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityPoolRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolRoles operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityPoolRoles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/SetIdentityPoolRoles">REST API Reference for SetIdentityPoolRoles Operation</seealso>
        IAsyncResult BeginSetIdentityPoolRoles(SetIdentityPoolRolesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityPoolRoles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityPoolRoles.</param>
        /// 
        /// <returns>Returns a  SetIdentityPoolRolesResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/SetIdentityPoolRoles">REST API Reference for SetIdentityPoolRoles Operation</seealso>
        SetIdentityPoolRolesResponse EndSetIdentityPoolRoles(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns a set of tags to an Amazon Cognito identity pool. A tag is a label that you
        /// can use to categorize and manage identity pools in different ways, such as by purpose,
        /// owner, environment, or other criteria.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and value, both of which you define. A key is a general
        /// category for more specific values. For example, if you have two versions of an identity
        /// pool, one for testing and another for production, you might assign an <code>Environment</code>
        /// tag key to both identity pools. The value of this key might be <code>Test</code> for
        /// one identity pool and <code>Production</code> for the other.
        /// </para>
        ///  
        /// <para>
        /// Tags are useful for cost tracking and access control. You can activate your tags so
        /// that they appear on the Billing and Cost Management console, where you can track the
        /// costs associated with your identity pools. In an IAM policy, you can constrain permissions
        /// for identity pools based on specific tags or tag values.
        /// </para>
        ///  
        /// <para>
        /// You can use this action up to 5 times per second, per account. An identity pool can
        /// have as many as 50 tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UnlinkDeveloperIdentity


        /// <summary>
        /// Unlinks a <code>DeveloperUserIdentifier</code> from an existing identity. Unlinked
        /// developer users will be considered new identities next time they are seen. If, for
        /// a given Cognito identity, you remove all federated identities as well as the developer
        /// user identifier, the Cognito identity becomes inaccessible.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnlinkDeveloperIdentity service method.</param>
        /// 
        /// <returns>The response from the UnlinkDeveloperIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UnlinkDeveloperIdentity">REST API Reference for UnlinkDeveloperIdentity Operation</seealso>
        UnlinkDeveloperIdentityResponse UnlinkDeveloperIdentity(UnlinkDeveloperIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnlinkDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnlinkDeveloperIdentity operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnlinkDeveloperIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UnlinkDeveloperIdentity">REST API Reference for UnlinkDeveloperIdentity Operation</seealso>
        IAsyncResult BeginUnlinkDeveloperIdentity(UnlinkDeveloperIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnlinkDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnlinkDeveloperIdentity.</param>
        /// 
        /// <returns>Returns a  UnlinkDeveloperIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UnlinkDeveloperIdentity">REST API Reference for UnlinkDeveloperIdentity Operation</seealso>
        UnlinkDeveloperIdentityResponse EndUnlinkDeveloperIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  UnlinkIdentity


        /// <summary>
        /// Unlinks a federated identity from an existing account. Unlinked logins will be considered
        /// new identities next time they are seen. Removing the last linked login will make this
        /// identity inaccessible.
        /// 
        ///  
        /// <para>
        /// This is a public API. You do not need any credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnlinkIdentity service method.</param>
        /// 
        /// <returns>The response from the UnlinkIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ExternalServiceException">
        /// An exception thrown when a dependent service such as Facebook or Twitter is not responding
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UnlinkIdentity">REST API Reference for UnlinkIdentity Operation</seealso>
        UnlinkIdentityResponse UnlinkIdentity(UnlinkIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnlinkIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnlinkIdentity operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnlinkIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UnlinkIdentity">REST API Reference for UnlinkIdentity Operation</seealso>
        IAsyncResult BeginUnlinkIdentity(UnlinkIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnlinkIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnlinkIdentity.</param>
        /// 
        /// <returns>Returns a  UnlinkIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UnlinkIdentity">REST API Reference for UnlinkIdentity Operation</seealso>
        UnlinkIdentityResponse EndUnlinkIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from an Amazon Cognito identity pool. You can use this
        /// action up to 5 times per second, per account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIdentityPool


        /// <summary>
        /// Updates an identity pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPool service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ConcurrentModificationException">
        /// Thrown if there are parallel requests to modify a resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.LimitExceededException">
        /// Thrown when the total number of user pools has exceeded a preset limit.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UpdateIdentityPool">REST API Reference for UpdateIdentityPool Operation</seealso>
        UpdateIdentityPoolResponse UpdateIdentityPool(UpdateIdentityPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPool operation on AmazonCognitoIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdentityPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UpdateIdentityPool">REST API Reference for UpdateIdentityPool Operation</seealso>
        IAsyncResult BeginUpdateIdentityPool(UpdateIdentityPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentityPool.</param>
        /// 
        /// <returns>Returns a  UpdateIdentityPoolResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UpdateIdentityPool">REST API Reference for UpdateIdentityPool Operation</seealso>
        UpdateIdentityPoolResponse EndUpdateIdentityPool(IAsyncResult asyncResult);

        #endregion
        
    }
}