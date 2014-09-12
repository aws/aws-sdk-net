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
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
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
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
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
        
        #region  DescribeIdentityPool

        internal DescribeIdentityPoolResponse DescribeIdentityPool(DescribeIdentityPoolRequest request)
        {
            var marshaller = new DescribeIdentityPoolRequestMarshaller();
            var unmarshaller = DescribeIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityPoolRequest,DescribeIdentityPoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityPool operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
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
        
        #region  GetId

        internal GetIdResponse GetId(GetIdRequest request)
        {
            var marshaller = new GetIdRequestMarshaller();
            var unmarshaller = GetIdResponseUnmarshaller.Instance;

            return Invoke<GetIdRequest,GetIdResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetId operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
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
        
        #region  GetOpenIdToken

        internal GetOpenIdTokenResponse GetOpenIdToken(GetOpenIdTokenRequest request)
        {
            var marshaller = new GetOpenIdTokenRequestMarshaller();
            var unmarshaller = GetOpenIdTokenResponseUnmarshaller.Instance;

            return Invoke<GetOpenIdTokenRequest,GetOpenIdTokenResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIdToken operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
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
        
        #region  ListIdentities

        internal ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
        {
            var marshaller = new ListIdentitiesRequestMarshaller();
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitiesRequest,ListIdentitiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
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
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
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
        
        #region  UnlinkIdentity

        internal UnlinkIdentityResponse UnlinkIdentity(UnlinkIdentityRequest request)
        {
            var marshaller = new UnlinkIdentityRequestMarshaller();
            var unmarshaller = UnlinkIdentityResponseUnmarshaller.Instance;

            return Invoke<UnlinkIdentityRequest,UnlinkIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnlinkIdentity operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
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
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
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