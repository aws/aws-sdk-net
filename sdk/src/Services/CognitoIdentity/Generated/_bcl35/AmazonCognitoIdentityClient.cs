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
        /// that is specific to your AWS account. The limit on identity pools is 60 per account.
        /// The keys for <code>SupportedLoginProviders</code> are as follows:
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
            var marshaller = CreateIdentityPoolRequestMarshaller.Instance;
            var unmarshaller = CreateIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<CreateIdentityPoolRequest,CreateIdentityPoolResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginCreateIdentityPool(CreateIdentityPoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateIdentityPoolRequestMarshaller.Instance;
            var unmarshaller = CreateIdentityPoolResponseUnmarshaller.Instance;

            return BeginInvoke<CreateIdentityPoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdentityPool.</param>
        /// 
        /// <returns>Returns a  CreateIdentityPoolResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/CreateIdentityPool">REST API Reference for CreateIdentityPool Operation</seealso>
        public virtual CreateIdentityPoolResponse EndCreateIdentityPool(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIdentityPoolResponse>(asyncResult);
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
            var marshaller = DeleteIdentitiesRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentitiesResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentitiesRequest,DeleteIdentitiesResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginDeleteIdentities(DeleteIdentitiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIdentitiesRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentitiesResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIdentitiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentities.</param>
        /// 
        /// <returns>Returns a  DeleteIdentitiesResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentities">REST API Reference for DeleteIdentities Operation</seealso>
        public virtual DeleteIdentitiesResponse EndDeleteIdentities(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdentitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIdentityPool

        /// <summary>
        /// Deletes a user pool. Once a pool is deleted, users will not be able to authenticate
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
        /// Deletes a user pool. Once a pool is deleted, users will not be able to authenticate
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
            var marshaller = DeleteIdentityPoolRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityPoolRequest,DeleteIdentityPoolResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginDeleteIdentityPool(DeleteIdentityPoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIdentityPoolRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityPoolResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIdentityPoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentityPool.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityPoolResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentityPool">REST API Reference for DeleteIdentityPool Operation</seealso>
        public virtual DeleteIdentityPoolResponse EndDeleteIdentityPool(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdentityPoolResponse>(asyncResult);
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
            var marshaller = DescribeIdentityRequestMarshaller.Instance;
            var unmarshaller = DescribeIdentityResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityRequest,DescribeIdentityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginDescribeIdentity(DescribeIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeIdentityRequestMarshaller.Instance;
            var unmarshaller = DescribeIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentity.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentity">REST API Reference for DescribeIdentity Operation</seealso>
        public virtual DescribeIdentityResponse EndDescribeIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIdentityResponse>(asyncResult);
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
            var marshaller = DescribeIdentityPoolRequestMarshaller.Instance;
            var unmarshaller = DescribeIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityPoolRequest,DescribeIdentityPoolResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginDescribeIdentityPool(DescribeIdentityPoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeIdentityPoolRequestMarshaller.Instance;
            var unmarshaller = DescribeIdentityPoolResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeIdentityPoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityPool.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityPoolResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentityPool">REST API Reference for DescribeIdentityPool Operation</seealso>
        public virtual DescribeIdentityPoolResponse EndDescribeIdentityPool(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIdentityPoolResponse>(asyncResult);
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
        /// <param name="logins">A set of optional name-value pairs that map provider names to provider tokens.</param>
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
            var marshaller = GetCredentialsForIdentityRequestMarshaller.Instance;
            var unmarshaller = GetCredentialsForIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCredentialsForIdentityRequest,GetCredentialsForIdentityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginGetCredentialsForIdentity(GetCredentialsForIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCredentialsForIdentityRequestMarshaller.Instance;
            var unmarshaller = GetCredentialsForIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<GetCredentialsForIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCredentialsForIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCredentialsForIdentity.</param>
        /// 
        /// <returns>Returns a  GetCredentialsForIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetCredentialsForIdentity">REST API Reference for GetCredentialsForIdentity Operation</seealso>
        public virtual GetCredentialsForIdentityResponse EndGetCredentialsForIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCredentialsForIdentityResponse>(asyncResult);
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
            var marshaller = GetIdRequestMarshaller.Instance;
            var unmarshaller = GetIdResponseUnmarshaller.Instance;

            return Invoke<GetIdRequest,GetIdResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginGetId(GetIdRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIdRequestMarshaller.Instance;
            var unmarshaller = GetIdResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetId.</param>
        /// 
        /// <returns>Returns a  GetIdResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetId">REST API Reference for GetId Operation</seealso>
        public virtual GetIdResponse EndGetId(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdResponse>(asyncResult);
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
            var marshaller = GetIdentityPoolRolesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityPoolRolesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityPoolRolesRequest,GetIdentityPoolRolesResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginGetIdentityPoolRoles(GetIdentityPoolRolesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIdentityPoolRolesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityPoolRolesResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdentityPoolRolesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityPoolRoles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityPoolRoles.</param>
        /// 
        /// <returns>Returns a  GetIdentityPoolRolesResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetIdentityPoolRoles">REST API Reference for GetIdentityPoolRoles Operation</seealso>
        public virtual GetIdentityPoolRolesResponse EndGetIdentityPoolRoles(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityPoolRolesResponse>(asyncResult);
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
        /// The OpenId token is valid for 15 minutes.
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
        /// The OpenId token is valid for 15 minutes.
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
            var marshaller = GetOpenIdTokenRequestMarshaller.Instance;
            var unmarshaller = GetOpenIdTokenResponseUnmarshaller.Instance;

            return Invoke<GetOpenIdTokenRequest,GetOpenIdTokenResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginGetOpenIdToken(GetOpenIdTokenRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetOpenIdTokenRequestMarshaller.Instance;
            var unmarshaller = GetOpenIdTokenResponseUnmarshaller.Instance;

            return BeginInvoke<GetOpenIdTokenRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpenIdToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpenIdToken.</param>
        /// 
        /// <returns>Returns a  GetOpenIdTokenResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdToken">REST API Reference for GetOpenIdToken Operation</seealso>
        public virtual GetOpenIdTokenResponse EndGetOpenIdToken(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOpenIdTokenResponse>(asyncResult);
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
            var marshaller = GetOpenIdTokenForDeveloperIdentityRequestMarshaller.Instance;
            var unmarshaller = GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<GetOpenIdTokenForDeveloperIdentityRequest,GetOpenIdTokenForDeveloperIdentityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginGetOpenIdTokenForDeveloperIdentity(GetOpenIdTokenForDeveloperIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetOpenIdTokenForDeveloperIdentityRequestMarshaller.Instance;
            var unmarshaller = GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<GetOpenIdTokenForDeveloperIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpenIdTokenForDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpenIdTokenForDeveloperIdentity.</param>
        /// 
        /// <returns>Returns a  GetOpenIdTokenForDeveloperIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdTokenForDeveloperIdentity">REST API Reference for GetOpenIdTokenForDeveloperIdentity Operation</seealso>
        public virtual GetOpenIdTokenForDeveloperIdentityResponse EndGetOpenIdTokenForDeveloperIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOpenIdTokenForDeveloperIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdentities

        /// <summary>
        /// Lists the identities in a pool.
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
            var marshaller = ListIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitiesRequest,ListIdentitiesResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginListIdentities(ListIdentitiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return BeginInvoke<ListIdentitiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentities.</param>
        /// 
        /// <returns>Returns a  ListIdentitiesResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        public virtual ListIdentitiesResponse EndListIdentities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentitiesResponse>(asyncResult);
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
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentityPools">REST API Reference for ListIdentityPools Operation</seealso>
        public virtual ListIdentityPoolsResponse ListIdentityPools(ListIdentityPoolsRequest request)
        {
            var marshaller = ListIdentityPoolsRequestMarshaller.Instance;
            var unmarshaller = ListIdentityPoolsResponseUnmarshaller.Instance;

            return Invoke<ListIdentityPoolsRequest,ListIdentityPoolsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginListIdentityPools(ListIdentityPoolsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListIdentityPoolsRequestMarshaller.Instance;
            var unmarshaller = ListIdentityPoolsResponseUnmarshaller.Instance;

            return BeginInvoke<ListIdentityPoolsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityPools.</param>
        /// 
        /// <returns>Returns a  ListIdentityPoolsResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentityPools">REST API Reference for ListIdentityPools Operation</seealso>
        public virtual ListIdentityPoolsResponse EndListIdentityPools(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentityPoolsResponse>(asyncResult);
        }

        #endregion
        
        #region  LookupDeveloperIdentity

        /// <summary>
        /// Retrieves the <code>IdentityID</code> associated with a <code>DeveloperUserIdentifier</code>
        /// or the list of <code>DeveloperUserIdentifier</code>s associated with an <code>IdentityId</code>
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
            var marshaller = LookupDeveloperIdentityRequestMarshaller.Instance;
            var unmarshaller = LookupDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<LookupDeveloperIdentityRequest,LookupDeveloperIdentityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginLookupDeveloperIdentity(LookupDeveloperIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = LookupDeveloperIdentityRequestMarshaller.Instance;
            var unmarshaller = LookupDeveloperIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<LookupDeveloperIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  LookupDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLookupDeveloperIdentity.</param>
        /// 
        /// <returns>Returns a  LookupDeveloperIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/LookupDeveloperIdentity">REST API Reference for LookupDeveloperIdentity Operation</seealso>
        public virtual LookupDeveloperIdentityResponse EndLookupDeveloperIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<LookupDeveloperIdentityResponse>(asyncResult);
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
            var marshaller = MergeDeveloperIdentitiesRequestMarshaller.Instance;
            var unmarshaller = MergeDeveloperIdentitiesResponseUnmarshaller.Instance;

            return Invoke<MergeDeveloperIdentitiesRequest,MergeDeveloperIdentitiesResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginMergeDeveloperIdentities(MergeDeveloperIdentitiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = MergeDeveloperIdentitiesRequestMarshaller.Instance;
            var unmarshaller = MergeDeveloperIdentitiesResponseUnmarshaller.Instance;

            return BeginInvoke<MergeDeveloperIdentitiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MergeDeveloperIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergeDeveloperIdentities.</param>
        /// 
        /// <returns>Returns a  MergeDeveloperIdentitiesResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/MergeDeveloperIdentities">REST API Reference for MergeDeveloperIdentities Operation</seealso>
        public virtual MergeDeveloperIdentitiesResponse EndMergeDeveloperIdentities(IAsyncResult asyncResult)
        {
            return EndInvoke<MergeDeveloperIdentitiesResponse>(asyncResult);
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
            var marshaller = SetIdentityPoolRolesRequestMarshaller.Instance;
            var unmarshaller = SetIdentityPoolRolesResponseUnmarshaller.Instance;

            return Invoke<SetIdentityPoolRolesRequest,SetIdentityPoolRolesResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginSetIdentityPoolRoles(SetIdentityPoolRolesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SetIdentityPoolRolesRequestMarshaller.Instance;
            var unmarshaller = SetIdentityPoolRolesResponseUnmarshaller.Instance;

            return BeginInvoke<SetIdentityPoolRolesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityPoolRoles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityPoolRoles.</param>
        /// 
        /// <returns>Returns a  SetIdentityPoolRolesResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/SetIdentityPoolRoles">REST API Reference for SetIdentityPoolRoles Operation</seealso>
        public virtual SetIdentityPoolRolesResponse EndSetIdentityPoolRoles(IAsyncResult asyncResult)
        {
            return EndInvoke<SetIdentityPoolRolesResponse>(asyncResult);
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
            var marshaller = UnlinkDeveloperIdentityRequestMarshaller.Instance;
            var unmarshaller = UnlinkDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<UnlinkDeveloperIdentityRequest,UnlinkDeveloperIdentityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginUnlinkDeveloperIdentity(UnlinkDeveloperIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UnlinkDeveloperIdentityRequestMarshaller.Instance;
            var unmarshaller = UnlinkDeveloperIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<UnlinkDeveloperIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnlinkDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnlinkDeveloperIdentity.</param>
        /// 
        /// <returns>Returns a  UnlinkDeveloperIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UnlinkDeveloperIdentity">REST API Reference for UnlinkDeveloperIdentity Operation</seealso>
        public virtual UnlinkDeveloperIdentityResponse EndUnlinkDeveloperIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<UnlinkDeveloperIdentityResponse>(asyncResult);
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
            var marshaller = UnlinkIdentityRequestMarshaller.Instance;
            var unmarshaller = UnlinkIdentityResponseUnmarshaller.Instance;

            return Invoke<UnlinkIdentityRequest,UnlinkIdentityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginUnlinkIdentity(UnlinkIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UnlinkIdentityRequestMarshaller.Instance;
            var unmarshaller = UnlinkIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<UnlinkIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnlinkIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnlinkIdentity.</param>
        /// 
        /// <returns>Returns a  UnlinkIdentityResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UnlinkIdentity">REST API Reference for UnlinkIdentity Operation</seealso>
        public virtual UnlinkIdentityResponse EndUnlinkIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<UnlinkIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIdentityPool

        /// <summary>
        /// Updates a user pool.
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
            var marshaller = UpdateIdentityPoolRequestMarshaller.Instance;
            var unmarshaller = UpdateIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityPoolRequest,UpdateIdentityPoolResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual IAsyncResult BeginUpdateIdentityPool(UpdateIdentityPoolRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateIdentityPoolRequestMarshaller.Instance;
            var unmarshaller = UpdateIdentityPoolResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateIdentityPoolRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentityPool.</param>
        /// 
        /// <returns>Returns a  UpdateIdentityPoolResult from CognitoIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UpdateIdentityPool">REST API Reference for UpdateIdentityPool Operation</seealso>
        public virtual UpdateIdentityPoolResponse EndUpdateIdentityPool(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIdentityPoolResponse>(asyncResult);
        }

        #endregion
        
    }
}