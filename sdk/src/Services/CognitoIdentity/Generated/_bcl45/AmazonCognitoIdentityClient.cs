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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CognitoIdentity.Model;
using Amazon.CognitoIdentity.Model.Internal.MarshallTransformations;
using Amazon.CognitoIdentity.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentity
{
    /// <summary>
    /// Implementation for accessing CognitoIdentity
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
    public partial class AmazonCognitoIdentityClient : AmazonServiceClient, IAmazonCognitoIdentity
    {
        private static IServiceMetadata serviceMetadata = new AmazonCognitoIdentityMetadata();
        private ICognitoIdentityPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICognitoIdentityPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CognitoIdentityPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with the credentials loaded from the application's
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
        public AmazonCognitoIdentityClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCognitoIdentityConfig()) { }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with the credentials loaded from the application's
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
        public AmazonCognitoIdentityClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCognitoIdentityConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCognitoIdentityClient Configuration Object</param>
        public AmazonCognitoIdentityClient(AmazonCognitoIdentityConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        public virtual CreateIdentityPoolResponse CreateIdentityPool(CreateIdentityPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<CreateIdentityPoolResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateIdentityPoolResponse> CreateIdentityPoolAsync(CreateIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityPoolResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateIdentityPoolResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteIdentitiesResponse DeleteIdentities(DeleteIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentitiesResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentitiesResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteIdentitiesResponse> DeleteIdentitiesAsync(DeleteIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIdentitiesResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteIdentityPoolResponse DeleteIdentityPool(string identityPoolId)
        {
            var request = new DeleteIdentityPoolRequest();
            request.IdentityPoolId = identityPoolId;
            return DeleteIdentityPool(request);
        }


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
        public virtual DeleteIdentityPoolResponse DeleteIdentityPool(DeleteIdentityPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityPoolResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteIdentityPoolRequest();
            request.IdentityPoolId = identityPoolId;
            return DeleteIdentityPoolAsync(request, cancellationToken);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(DeleteIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityPoolResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIdentityPoolResponse>(request, options, cancellationToken);
        }

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
        public virtual DescribeIdentityResponse DescribeIdentity(string identityId)
        {
            var request = new DescribeIdentityRequest();
            request.IdentityId = identityId;
            return DescribeIdentity(request);
        }


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
        public virtual DescribeIdentityResponse DescribeIdentity(DescribeIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeIdentityResponse> DescribeIdentityAsync(string identityId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeIdentityRequest();
            request.IdentityId = identityId;
            return DescribeIdentityAsync(request, cancellationToken);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeIdentityResponse> DescribeIdentityAsync(DescribeIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeIdentityResponse>(request, options, cancellationToken);
        }

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
        public virtual DescribeIdentityPoolResponse DescribeIdentityPool(string identityPoolId)
        {
            var request = new DescribeIdentityPoolRequest();
            request.IdentityPoolId = identityPoolId;
            return DescribeIdentityPool(request);
        }


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
        public virtual DescribeIdentityPoolResponse DescribeIdentityPool(DescribeIdentityPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityPoolResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeIdentityPoolRequest();
            request.IdentityPoolId = identityPoolId;
            return DescribeIdentityPoolAsync(request, cancellationToken);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(DescribeIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityPoolResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeIdentityPoolResponse>(request, options, cancellationToken);
        }

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
        public virtual GetCredentialsForIdentityResponse GetCredentialsForIdentity(string identityId)
        {
            var request = new GetCredentialsForIdentityRequest();
            request.IdentityId = identityId;
            return GetCredentialsForIdentity(request);
        }


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
        public virtual GetCredentialsForIdentityResponse GetCredentialsForIdentity(string identityId, Dictionary<string, string> logins)
        {
            var request = new GetCredentialsForIdentityRequest();
            request.IdentityId = identityId;
            request.Logins = logins;
            return GetCredentialsForIdentity(request);
        }


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
        public virtual GetCredentialsForIdentityResponse GetCredentialsForIdentity(GetCredentialsForIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialsForIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialsForIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCredentialsForIdentityResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetCredentialsForIdentityRequest();
            request.IdentityId = identityId;
            return GetCredentialsForIdentityAsync(request, cancellationToken);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, Dictionary<string, string> logins, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetCredentialsForIdentityRequest();
            request.IdentityId = identityId;
            request.Logins = logins;
            return GetCredentialsForIdentityAsync(request, cancellationToken);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(GetCredentialsForIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialsForIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialsForIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCredentialsForIdentityResponse>(request, options, cancellationToken);
        }

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
        public virtual GetIdResponse GetId(GetIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdResponseUnmarshaller.Instance;

            return Invoke<GetIdResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetIdResponse> GetIdAsync(GetIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIdResponse>(request, options, cancellationToken);
        }

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
        public virtual GetIdentityPoolRolesResponse GetIdentityPoolRoles(string identityPoolId)
        {
            var request = new GetIdentityPoolRolesRequest();
            request.IdentityPoolId = identityPoolId;
            return GetIdentityPoolRoles(request);
        }


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
        public virtual GetIdentityPoolRolesResponse GetIdentityPoolRoles(GetIdentityPoolRolesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityPoolRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityPoolRolesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityPoolRolesResponse>(request, options);
        }


        /// <summary>
        /// Gets the roles for an identity pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">An identity pool ID in the format REGION:GUID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetIdentityPoolRolesRequest();
            request.IdentityPoolId = identityPoolId;
            return GetIdentityPoolRolesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Gets the roles for an identity pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolRoles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(GetIdentityPoolRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityPoolRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityPoolRolesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIdentityPoolRolesResponse>(request, options, cancellationToken);
        }

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
        public virtual GetOpenIdTokenResponse GetOpenIdToken(string identityId)
        {
            var request = new GetOpenIdTokenRequest();
            request.IdentityId = identityId;
            return GetOpenIdToken(request);
        }


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
        public virtual GetOpenIdTokenResponse GetOpenIdToken(GetOpenIdTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIdTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIdTokenResponseUnmarshaller.Instance;

            return Invoke<GetOpenIdTokenResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(string identityId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetOpenIdTokenRequest();
            request.IdentityId = identityId;
            return GetOpenIdTokenAsync(request, cancellationToken);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(GetOpenIdTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIdTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIdTokenResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOpenIdTokenResponse>(request, options, cancellationToken);
        }

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
        public virtual GetOpenIdTokenForDeveloperIdentityResponse GetOpenIdTokenForDeveloperIdentity(GetOpenIdTokenForDeveloperIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIdTokenForDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<GetOpenIdTokenForDeveloperIdentityResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentityAsync(GetOpenIdTokenForDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIdTokenForDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOpenIdTokenForDeveloperIdentityResponse>(request, options, cancellationToken);
        }

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
        public virtual ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitiesResponse>(request, options);
        }


        /// <summary>
        /// Lists the identities in an identity pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListIdentitiesResponse>(request, options, cancellationToken);
        }

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
        public virtual ListIdentityPoolsResponse ListIdentityPools(ListIdentityPoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityPoolsResponseUnmarshaller.Instance;

            return Invoke<ListIdentityPoolsResponse>(request, options);
        }


        /// <summary>
        /// Lists all of the Cognito identity pools registered for your account.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListIdentityPoolsResponse> ListIdentityPoolsAsync(ListIdentityPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityPoolsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListIdentityPoolsResponse>(request, options, cancellationToken);
        }

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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual LookupDeveloperIdentityResponse LookupDeveloperIdentity(LookupDeveloperIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LookupDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<LookupDeveloperIdentityResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<LookupDeveloperIdentityResponse> LookupDeveloperIdentityAsync(LookupDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LookupDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupDeveloperIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<LookupDeveloperIdentityResponse>(request, options, cancellationToken);
        }

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
        public virtual MergeDeveloperIdentitiesResponse MergeDeveloperIdentities(MergeDeveloperIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergeDeveloperIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeDeveloperIdentitiesResponseUnmarshaller.Instance;

            return Invoke<MergeDeveloperIdentitiesResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<MergeDeveloperIdentitiesResponse> MergeDeveloperIdentitiesAsync(MergeDeveloperIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergeDeveloperIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeDeveloperIdentitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<MergeDeveloperIdentitiesResponse>(request, options, cancellationToken);
        }

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
        public virtual SetIdentityPoolRolesResponse SetIdentityPoolRoles(string identityPoolId, Dictionary<string, string> roles)
        {
            var request = new SetIdentityPoolRolesRequest();
            request.IdentityPoolId = identityPoolId;
            request.Roles = roles;
            return SetIdentityPoolRoles(request);
        }


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
        public virtual SetIdentityPoolRolesResponse SetIdentityPoolRoles(SetIdentityPoolRolesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityPoolRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityPoolRolesResponseUnmarshaller.Instance;

            return Invoke<SetIdentityPoolRolesResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(string identityPoolId, Dictionary<string, string> roles, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SetIdentityPoolRolesRequest();
            request.IdentityPoolId = identityPoolId;
            request.Roles = roles;
            return SetIdentityPoolRolesAsync(request, cancellationToken);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(SetIdentityPoolRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityPoolRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityPoolRolesResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetIdentityPoolRolesResponse>(request, options, cancellationToken);
        }

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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual UnlinkDeveloperIdentityResponse UnlinkDeveloperIdentity(UnlinkDeveloperIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlinkDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlinkDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<UnlinkDeveloperIdentityResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UnlinkDeveloperIdentityResponse> UnlinkDeveloperIdentityAsync(UnlinkDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlinkDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlinkDeveloperIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<UnlinkDeveloperIdentityResponse>(request, options, cancellationToken);
        }

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
        public virtual UnlinkIdentityResponse UnlinkIdentity(UnlinkIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlinkIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlinkIdentityResponseUnmarshaller.Instance;

            return Invoke<UnlinkIdentityResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UnlinkIdentityResponse> UnlinkIdentityAsync(UnlinkIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlinkIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlinkIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<UnlinkIdentityResponse>(request, options, cancellationToken);
        }

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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from an Amazon Cognito identity pool. You can use this
        /// action up to 5 times per second, per account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateIdentityPoolResponse UpdateIdentityPool(UpdateIdentityPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityPoolResponse>(request, options);
        }


        /// <summary>
        /// Updates an identity pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(UpdateIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityPoolResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateIdentityPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}