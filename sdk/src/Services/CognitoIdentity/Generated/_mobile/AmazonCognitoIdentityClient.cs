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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

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
    /// Amazon Cognito is a web service that delivers scoped temporary credentials to mobile
    /// devices and other untrusted environments. Amazon Cognito uniquely identifies a device
    /// and supplies the user with a consistent identity over the lifetime of an application.
    /// </para>
    ///  
    /// <para>
    /// Using Amazon Cognito, you can enable authentication with one or more third-party identity
    /// providers (Facebook, Google, or Login with Amazon), and you can also choose to support
    /// unauthenticated access from your app. Cognito delivers a unique identifier for each
    /// user and acts as an OpenID token provider trusted by AWS Security Token Service (STS)
    /// to access temporary, limited-privilege AWS credentials.
    /// </para>
    ///  
    /// <para>
    /// To provide end-user credentials, first make an unsigned call to <a>GetId</a>. If the
    /// end user is authenticated with one of the supported identity providers, set the <code>Logins</code>
    /// map with the identity provider token. <code>GetId</code> returns a unique identifier
    /// for the user.
    /// </para>
    ///  
    /// <para>
    /// Next, make an unsigned call to <a>GetCredentialsForIdentity</a>. This call expects
    /// the same <code>Logins</code> map as the <code>GetId</code> call, as well as the <code>IdentityID</code>
    /// originally returned by <code>GetId</code>. Assuming your identity pool has been configured
    /// via the <a>SetIdentityPoolRoles</a> operation, <code>GetCredentialsForIdentity</code>
    /// will return AWS credentials for your use. If your pool has not been configured with
    /// <code>SetIdentityPoolRoles</code>, or if you want to follow legacy flow, make an unsigned
    /// call to <a>GetOpenIdToken</a>, which returns the OpenID token necessary to call STS
    /// and retrieve AWS credentials. This call expects the same <code>Logins</code> map as
    /// the <code>GetId</code> call, as well as the <code>IdentityID</code> originally returned
    /// by <code>GetId</code>. The token returned by <code>GetOpenIdToken</code> can be passed
    /// to the STS operation <a href="http://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRoleWithWebIdentity.html">AssumeRoleWithWebIdentity</a>
    /// to retrieve AWS credentials.
    /// </para>
    ///  
    /// <para>
    /// If you want to use Amazon Cognito in an Android, iOS, or Unity application, you will
    /// probably want to make API calls via the AWS Mobile SDK. To learn more, see the <a
    /// href="http://docs.aws.amazon.com/mobile/index.html">AWS Mobile SDK Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCognitoIdentityClient : AmazonServiceClient, IAmazonCognitoIdentity
    {
        
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
            : this(credentials, new AmazonCognitoIdentityConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Credentials and an
        /// AmazonCognitoIdentityClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityClient Configuration Object</param>
        public AmazonCognitoIdentityClient(AWSCredentials credentials, AmazonCognitoIdentityConfig clientConfig)
            : base(credentials, clientConfig)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityConfig{RegionEndpoint = region})
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreateIdentityPool

        internal CreateIdentityPoolResponse CreateIdentityPool(CreateIdentityPoolRequest request)
        {
            var marshaller = new CreateIdentityPoolRequestMarshaller();
            var unmarshaller = CreateIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<CreateIdentityPoolRequest,CreateIdentityPoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateIdentityPoolResponse> CreateIdentityPoolAsync(CreateIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateIdentityPoolRequestMarshaller();
            var unmarshaller = CreateIdentityPoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIdentityPoolRequest,CreateIdentityPoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIdentityPool

        internal DeleteIdentityPoolResponse DeleteIdentityPool(DeleteIdentityPoolRequest request)
        {
            var marshaller = new DeleteIdentityPoolRequestMarshaller();
            var unmarshaller = DeleteIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityPoolRequest,DeleteIdentityPoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(DeleteIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteIdentityPoolRequestMarshaller();
            var unmarshaller = DeleteIdentityPoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentityPoolRequest,DeleteIdentityPoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentity

        internal DescribeIdentityResponse DescribeIdentity(DescribeIdentityRequest request)
        {
            var marshaller = new DescribeIdentityRequestMarshaller();
            var unmarshaller = DescribeIdentityResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityRequest,DescribeIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeIdentityResponse> DescribeIdentityAsync(DescribeIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeIdentityRequestMarshaller();
            var unmarshaller = DescribeIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdentityRequest,DescribeIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentityPool

        internal DescribeIdentityPoolResponse DescribeIdentityPool(DescribeIdentityPoolRequest request)
        {
            var marshaller = new DescribeIdentityPoolRequestMarshaller();
            var unmarshaller = DescribeIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityPoolRequest,DescribeIdentityPoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(DescribeIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeIdentityPoolRequestMarshaller();
            var unmarshaller = DescribeIdentityPoolResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdentityPoolRequest,DescribeIdentityPoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCredentialsForIdentity

        internal GetCredentialsForIdentityResponse GetCredentialsForIdentity(GetCredentialsForIdentityRequest request)
        {
            var marshaller = new GetCredentialsForIdentityRequestMarshaller();
            var unmarshaller = GetCredentialsForIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCredentialsForIdentityRequest,GetCredentialsForIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialsForIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialsForIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(GetCredentialsForIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCredentialsForIdentityRequestMarshaller();
            var unmarshaller = GetCredentialsForIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetCredentialsForIdentityRequest,GetCredentialsForIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetId

        internal GetIdResponse GetId(GetIdRequest request)
        {
            var marshaller = new GetIdRequestMarshaller();
            var unmarshaller = GetIdResponseUnmarshaller.Instance;

            return Invoke<GetIdRequest,GetIdResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetId operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetIdResponse> GetIdAsync(GetIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIdRequestMarshaller();
            var unmarshaller = GetIdResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdRequest,GetIdResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityPoolRoles

        internal GetIdentityPoolRolesResponse GetIdentityPoolRoles(GetIdentityPoolRolesRequest request)
        {
            var marshaller = new GetIdentityPoolRolesRequestMarshaller();
            var unmarshaller = GetIdentityPoolRolesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityPoolRolesRequest,GetIdentityPoolRolesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityPoolRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolRoles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(GetIdentityPoolRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIdentityPoolRolesRequestMarshaller();
            var unmarshaller = GetIdentityPoolRolesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityPoolRolesRequest,GetIdentityPoolRolesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetOpenIdToken

        internal GetOpenIdTokenResponse GetOpenIdToken(GetOpenIdTokenRequest request)
        {
            var marshaller = new GetOpenIdTokenRequestMarshaller();
            var unmarshaller = GetOpenIdTokenResponseUnmarshaller.Instance;

            return Invoke<GetOpenIdTokenRequest,GetOpenIdTokenResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIdToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(GetOpenIdTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetOpenIdTokenRequestMarshaller();
            var unmarshaller = GetOpenIdTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetOpenIdTokenRequest,GetOpenIdTokenResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetOpenIdTokenForDeveloperIdentity

        internal GetOpenIdTokenForDeveloperIdentityResponse GetOpenIdTokenForDeveloperIdentity(GetOpenIdTokenForDeveloperIdentityRequest request)
        {
            var marshaller = new GetOpenIdTokenForDeveloperIdentityRequestMarshaller();
            var unmarshaller = GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<GetOpenIdTokenForDeveloperIdentityRequest,GetOpenIdTokenForDeveloperIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIdTokenForDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdTokenForDeveloperIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentityAsync(GetOpenIdTokenForDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetOpenIdTokenForDeveloperIdentityRequestMarshaller();
            var unmarshaller = GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetOpenIdTokenForDeveloperIdentityRequest,GetOpenIdTokenForDeveloperIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIdentities

        internal ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
        {
            var marshaller = new ListIdentitiesRequestMarshaller();
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitiesRequest,ListIdentitiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListIdentitiesRequestMarshaller();
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentitiesRequest,ListIdentitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIdentityPools

        internal ListIdentityPoolsResponse ListIdentityPools(ListIdentityPoolsRequest request)
        {
            var marshaller = new ListIdentityPoolsRequestMarshaller();
            var unmarshaller = ListIdentityPoolsResponseUnmarshaller.Instance;

            return Invoke<ListIdentityPoolsRequest,ListIdentityPoolsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPools operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListIdentityPoolsResponse> ListIdentityPoolsAsync(ListIdentityPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListIdentityPoolsRequestMarshaller();
            var unmarshaller = ListIdentityPoolsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentityPoolsRequest,ListIdentityPoolsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  LookupDeveloperIdentity

        internal LookupDeveloperIdentityResponse LookupDeveloperIdentity(LookupDeveloperIdentityRequest request)
        {
            var marshaller = new LookupDeveloperIdentityRequestMarshaller();
            var unmarshaller = LookupDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<LookupDeveloperIdentityRequest,LookupDeveloperIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the LookupDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LookupDeveloperIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<LookupDeveloperIdentityResponse> LookupDeveloperIdentityAsync(LookupDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new LookupDeveloperIdentityRequestMarshaller();
            var unmarshaller = LookupDeveloperIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<LookupDeveloperIdentityRequest,LookupDeveloperIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  MergeDeveloperIdentities

        internal MergeDeveloperIdentitiesResponse MergeDeveloperIdentities(MergeDeveloperIdentitiesRequest request)
        {
            var marshaller = new MergeDeveloperIdentitiesRequestMarshaller();
            var unmarshaller = MergeDeveloperIdentitiesResponseUnmarshaller.Instance;

            return Invoke<MergeDeveloperIdentitiesRequest,MergeDeveloperIdentitiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MergeDeveloperIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeDeveloperIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<MergeDeveloperIdentitiesResponse> MergeDeveloperIdentitiesAsync(MergeDeveloperIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new MergeDeveloperIdentitiesRequestMarshaller();
            var unmarshaller = MergeDeveloperIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<MergeDeveloperIdentitiesRequest,MergeDeveloperIdentitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityPoolRoles

        internal SetIdentityPoolRolesResponse SetIdentityPoolRoles(SetIdentityPoolRolesRequest request)
        {
            var marshaller = new SetIdentityPoolRolesRequestMarshaller();
            var unmarshaller = SetIdentityPoolRolesResponseUnmarshaller.Instance;

            return Invoke<SetIdentityPoolRolesRequest,SetIdentityPoolRolesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityPoolRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolRoles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(SetIdentityPoolRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetIdentityPoolRolesRequestMarshaller();
            var unmarshaller = SetIdentityPoolRolesResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityPoolRolesRequest,SetIdentityPoolRolesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnlinkDeveloperIdentity

        internal UnlinkDeveloperIdentityResponse UnlinkDeveloperIdentity(UnlinkDeveloperIdentityRequest request)
        {
            var marshaller = new UnlinkDeveloperIdentityRequestMarshaller();
            var unmarshaller = UnlinkDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<UnlinkDeveloperIdentityRequest,UnlinkDeveloperIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnlinkDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnlinkDeveloperIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UnlinkDeveloperIdentityResponse> UnlinkDeveloperIdentityAsync(UnlinkDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnlinkDeveloperIdentityRequestMarshaller();
            var unmarshaller = UnlinkDeveloperIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<UnlinkDeveloperIdentityRequest,UnlinkDeveloperIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnlinkIdentity

        internal UnlinkIdentityResponse UnlinkIdentity(UnlinkIdentityRequest request)
        {
            var marshaller = new UnlinkIdentityRequestMarshaller();
            var unmarshaller = UnlinkIdentityResponseUnmarshaller.Instance;

            return Invoke<UnlinkIdentityRequest,UnlinkIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnlinkIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnlinkIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UnlinkIdentityResponse> UnlinkIdentityAsync(UnlinkIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnlinkIdentityRequestMarshaller();
            var unmarshaller = UnlinkIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<UnlinkIdentityRequest,UnlinkIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateIdentityPool

        internal UpdateIdentityPoolResponse UpdateIdentityPool(UpdateIdentityPoolRequest request)
        {
            var marshaller = new UpdateIdentityPoolRequestMarshaller();
            var unmarshaller = UpdateIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityPoolRequest,UpdateIdentityPoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(UpdateIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateIdentityPoolRequestMarshaller();
            var unmarshaller = UpdateIdentityPoolResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIdentityPoolRequest,UpdateIdentityPoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}