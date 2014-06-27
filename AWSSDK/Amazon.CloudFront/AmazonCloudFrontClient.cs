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


using System;
using System.Threading;

using Amazon.CloudFront.Model;
using Amazon.CloudFront.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront
{
    /// <summary>
    /// Implementation for accessing CloudFront
    ///
    /// 
    /// </summary>
    public partial class AmazonCloudFrontClient : AmazonWebServiceClient, AmazonCloudFront
    {
        AbstractAWSSigner signer = new AWS4Signer();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudFrontClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig{RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(AmazonCloudFrontConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFrontClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFrontConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials and an
        /// AmazonCloudFrontClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(AWSCredentials credentials, AmazonCloudFrontConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFrontConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFrontConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  CreateCloudFrontOriginAccessIdentity


        /// <summary>
        /// Create a new origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="CloudFrontOriginAccessIdentityAlreadyExistsException">
        /// If the CallerReference is a value you already sent in a previous request to create
        /// an identity but the content of the CloudFrontOriginAccessIdentityConfig is different
        /// from the original request,    CloudFront returns a CloudFrontOriginAccessIdentityAlreadyExists
        /// error.
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="TooManyCloudFrontOriginAccessIdentitiesException">
        /// Processing your request would cause you to exceed the maximum number of origin access
        /// identities allowed.
        /// </exception>
        public CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request)
        {
            IAsyncResult asyncResult = invokeCreateCloudFrontOriginAccessIdentity(request, null, null, true);
            return EndCreateCloudFrontOriginAccessIdentity(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        public IAsyncResult BeginCreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateCloudFrontOriginAccessIdentity(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  CreateCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        public  CreateCloudFrontOriginAccessIdentityResponse EndCreateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return endOperation< CreateCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }

        IAsyncResult invokeCreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateCloudFrontOriginAccessIdentityRequestMarshaller().Marshall(request);
            var unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateDistribution


        /// <summary>
        /// Create a new distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="InvalidErrorCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the whitelisted    list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names    is missing when expected.
        /// </exception>
        /// <exception cref="InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="InvalidLocationCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or    does not begin with a slash
        /// (/).
        /// </exception>
        /// <exception cref="InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the RequiredProtocols element from your distribution configuration.
        /// </exception>
        /// <exception cref="InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidViewerCertificateException">
        /// 
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="NoSuchOriginException">
        /// No origin exists with the specified Origin Id.
        /// </exception>
        /// <exception cref="TooManyCacheBehaviorsException">
        /// You cannot create anymore cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="TooManyCertificatesException">
        /// You cannot create anymore custom ssl certificates.
        /// </exception>
        /// <exception cref="TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="TooManyOriginsException">
        /// You cannot create anymore origins for the distribution.
        /// </exception>
        /// <exception cref="TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        public CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
        {
            IAsyncResult asyncResult = invokeCreateDistribution(request, null, null, true);
            return EndCreateDistribution(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDistribution
        ///         operation.</returns>
        public IAsyncResult BeginCreateDistribution(CreateDistributionRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateDistribution(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistribution.</param>
        /// 
        /// <returns>Returns a  CreateDistributionResult from CloudFront.</returns>
        public  CreateDistributionResponse EndCreateDistribution(IAsyncResult asyncResult)
        {
            return endOperation< CreateDistributionResponse>(asyncResult);
        }

        IAsyncResult invokeCreateDistribution(CreateDistributionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDistributionRequestMarshaller().Marshall(request);
            var unmarshaller = CreateDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateInvalidation


        /// <summary>
        /// Create a new invalidation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation service method.</param>
        /// 
        /// <returns>The response from the CreateInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="BatchTooLargeException">
        /// 
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="TooManyInvalidationsInProgressException">
        /// You have exceeded the maximum number of allowable InProgress invalidation batch requests,
        /// or invalidation objects.
        /// </exception>
        public CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request)
        {
            IAsyncResult asyncResult = invokeCreateInvalidation(request, null, null, true);
            return EndCreateInvalidation(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInvalidation
        ///         operation.</returns>
        public IAsyncResult BeginCreateInvalidation(CreateInvalidationRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateInvalidation(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvalidation.</param>
        /// 
        /// <returns>Returns a  CreateInvalidationResult from CloudFront.</returns>
        public  CreateInvalidationResponse EndCreateInvalidation(IAsyncResult asyncResult)
        {
            return endOperation< CreateInvalidationResponse>(asyncResult);
        }

        IAsyncResult invokeCreateInvalidation(CreateInvalidationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateInvalidationRequestMarshaller().Marshall(request);
            var unmarshaller = CreateInvalidationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateStreamingDistribution


        /// <summary>
        /// Create a new streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="StreamingDistributionAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="TooManyStreamingDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of streaming
        /// distributions allowed.
        /// </exception>
        /// <exception cref="TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        public CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request)
        {
            IAsyncResult asyncResult = invokeCreateStreamingDistribution(request, null, null, true);
            return EndCreateStreamingDistribution(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamingDistribution
        ///         operation.</returns>
        public IAsyncResult BeginCreateStreamingDistribution(CreateStreamingDistributionRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateStreamingDistribution(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  CreateStreamingDistributionResult from CloudFront.</returns>
        public  CreateStreamingDistributionResponse EndCreateStreamingDistribution(IAsyncResult asyncResult)
        {
            return endOperation< CreateStreamingDistributionResponse>(asyncResult);
        }

        IAsyncResult invokeCreateStreamingDistribution(CreateStreamingDistributionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateStreamingDistributionRequestMarshaller().Marshall(request);
            var unmarshaller = CreateStreamingDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteCloudFrontOriginAccessIdentity

        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CloudFrontOriginAccessIdentityInUseException">
        /// 
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity()
        {
            return DeleteCloudFrontOriginAccessIdentity(new DeleteCloudFrontOriginAccessIdentityRequest());
        }

        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CloudFrontOriginAccessIdentityInUseException">
        /// 
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteCloudFrontOriginAccessIdentity(request, null, null, true);
            return EndDeleteCloudFrontOriginAccessIdentity(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteCloudFrontOriginAccessIdentity(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        public  DeleteCloudFrontOriginAccessIdentityResponse EndDeleteCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return endOperation< DeleteCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteDistribution

        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="DistributionNotDisabledException">
        /// 
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public DeleteDistributionResponse DeleteDistribution()
        {
            return DeleteDistribution(new DeleteDistributionRequest());
        }

        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution service method.</param>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="DistributionNotDisabledException">
        /// 
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteDistribution(request, null, null, true);
            return EndDeleteDistribution(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDistribution
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDistribution(DeleteDistributionRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteDistribution(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDistribution.</param>
        /// 
        /// <returns>Returns a  DeleteDistributionResult from CloudFront.</returns>
        public  DeleteDistributionResponse EndDeleteDistribution(IAsyncResult asyncResult)
        {
            return endOperation< DeleteDistributionResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteDistribution(DeleteDistributionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDistributionRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteStreamingDistribution

        /// <summary>
        /// Delete a streaming distribution.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="StreamingDistributionNotDisabledException">
        /// 
        /// </exception>
        public DeleteStreamingDistributionResponse DeleteStreamingDistribution()
        {
            return DeleteStreamingDistribution(new DeleteStreamingDistributionRequest());
        }

        /// <summary>
        /// Delete a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="StreamingDistributionNotDisabledException">
        /// 
        /// </exception>
        public DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteStreamingDistribution(request, null, null, true);
            return EndDeleteStreamingDistribution(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStreamingDistribution
        ///         operation.</returns>
        public IAsyncResult BeginDeleteStreamingDistribution(DeleteStreamingDistributionRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteStreamingDistribution(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  DeleteStreamingDistributionResult from CloudFront.</returns>
        public  DeleteStreamingDistributionResponse EndDeleteStreamingDistribution(IAsyncResult asyncResult)
        {
            return endOperation< DeleteStreamingDistributionResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteStreamingDistribution(DeleteStreamingDistributionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteStreamingDistributionRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentity

        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        public GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity()
        {
            return GetCloudFrontOriginAccessIdentity(new GetCloudFrontOriginAccessIdentityRequest());
        }

        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        public GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request)
        {
            IAsyncResult asyncResult = invokeGetCloudFrontOriginAccessIdentity(request, null, null, true);
            return EndGetCloudFrontOriginAccessIdentity(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        public IAsyncResult BeginGetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state)
        {
            return invokeGetCloudFrontOriginAccessIdentity(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  GetCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        public  GetCloudFrontOriginAccessIdentityResponse EndGetCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return endOperation< GetCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }

        IAsyncResult invokeGetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetCloudFrontOriginAccessIdentityRequestMarshaller().Marshall(request);
            var unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentityConfig

        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        public GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig()
        {
            return GetCloudFrontOriginAccessIdentityConfig(new GetCloudFrontOriginAccessIdentityConfigRequest());
        }

        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig service method.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        public GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request)
        {
            IAsyncResult asyncResult = invokeGetCloudFrontOriginAccessIdentityConfig(request, null, null, true);
            return EndGetCloudFrontOriginAccessIdentityConfig(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudFrontOriginAccessIdentityConfig
        ///         operation.</returns>
        public IAsyncResult BeginGetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request, AsyncCallback callback, object state)
        {
            return invokeGetCloudFrontOriginAccessIdentityConfig(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudFrontOriginAccessIdentityConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentityConfig.</param>
        /// 
        /// <returns>Returns a  GetCloudFrontOriginAccessIdentityConfigResult from CloudFront.</returns>
        public  GetCloudFrontOriginAccessIdentityConfigResponse EndGetCloudFrontOriginAccessIdentityConfig(IAsyncResult asyncResult)
        {
            return endOperation< GetCloudFrontOriginAccessIdentityConfigResponse>(asyncResult);
        }

        IAsyncResult invokeGetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetCloudFrontOriginAccessIdentityConfigRequestMarshaller().Marshall(request);
            var unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  GetDistribution

        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        public GetDistributionResponse GetDistribution()
        {
            return GetDistribution(new GetDistributionRequest());
        }

        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution service method.</param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        public GetDistributionResponse GetDistribution(GetDistributionRequest request)
        {
            IAsyncResult asyncResult = invokeGetDistribution(request, null, null, true);
            return EndGetDistribution(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistribution
        ///         operation.</returns>
        public IAsyncResult BeginGetDistribution(GetDistributionRequest request, AsyncCallback callback, object state)
        {
            return invokeGetDistribution(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistribution.</param>
        /// 
        /// <returns>Returns a  GetDistributionResult from CloudFront.</returns>
        public  GetDistributionResponse EndGetDistribution(IAsyncResult asyncResult)
        {
            return endOperation< GetDistributionResponse>(asyncResult);
        }

        IAsyncResult invokeGetDistribution(GetDistributionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetDistributionRequestMarshaller().Marshall(request);
            var unmarshaller = GetDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  GetDistributionConfig

        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        public GetDistributionConfigResponse GetDistributionConfig()
        {
            return GetDistributionConfig(new GetDistributionConfigRequest());
        }

        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig service method.</param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        public GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request)
        {
            IAsyncResult asyncResult = invokeGetDistributionConfig(request, null, null, true);
            return EndGetDistributionConfig(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistributionConfig
        ///         operation.</returns>
        public IAsyncResult BeginGetDistributionConfig(GetDistributionConfigRequest request, AsyncCallback callback, object state)
        {
            return invokeGetDistributionConfig(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionConfig.</param>
        /// 
        /// <returns>Returns a  GetDistributionConfigResult from CloudFront.</returns>
        public  GetDistributionConfigResponse EndGetDistributionConfig(IAsyncResult asyncResult)
        {
            return endOperation< GetDistributionConfigResponse>(asyncResult);
        }

        IAsyncResult invokeGetDistributionConfig(GetDistributionConfigRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetDistributionConfigRequestMarshaller().Marshall(request);
            var unmarshaller = GetDistributionConfigResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  GetInvalidation


        /// <summary>
        /// Get the information about an invalidation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation service method.</param>
        /// 
        /// <returns>The response from the GetInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="NoSuchInvalidationException">
        /// The specified invalidation does not exist.
        /// </exception>
        public GetInvalidationResponse GetInvalidation(GetInvalidationRequest request)
        {
            IAsyncResult asyncResult = invokeGetInvalidation(request, null, null, true);
            return EndGetInvalidation(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvalidation
        ///         operation.</returns>
        public IAsyncResult BeginGetInvalidation(GetInvalidationRequest request, AsyncCallback callback, object state)
        {
            return invokeGetInvalidation(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvalidation.</param>
        /// 
        /// <returns>Returns a  GetInvalidationResult from CloudFront.</returns>
        public  GetInvalidationResponse EndGetInvalidation(IAsyncResult asyncResult)
        {
            return endOperation< GetInvalidationResponse>(asyncResult);
        }

        IAsyncResult invokeGetInvalidation(GetInvalidationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetInvalidationRequestMarshaller().Marshall(request);
            var unmarshaller = GetInvalidationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  GetStreamingDistribution

        /// <summary>
        /// Get the information about a streaming distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        public GetStreamingDistributionResponse GetStreamingDistribution()
        {
            return GetStreamingDistribution(new GetStreamingDistributionRequest());
        }

        /// <summary>
        /// Get the information about a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        public GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request)
        {
            IAsyncResult asyncResult = invokeGetStreamingDistribution(request, null, null, true);
            return EndGetStreamingDistribution(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamingDistribution
        ///         operation.</returns>
        public IAsyncResult BeginGetStreamingDistribution(GetStreamingDistributionRequest request, AsyncCallback callback, object state)
        {
            return invokeGetStreamingDistribution(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  GetStreamingDistributionResult from CloudFront.</returns>
        public  GetStreamingDistributionResponse EndGetStreamingDistribution(IAsyncResult asyncResult)
        {
            return endOperation< GetStreamingDistributionResponse>(asyncResult);
        }

        IAsyncResult invokeGetStreamingDistribution(GetStreamingDistributionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetStreamingDistributionRequestMarshaller().Marshall(request);
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  GetStreamingDistributionConfig

        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        public GetStreamingDistributionConfigResponse GetStreamingDistributionConfig()
        {
            return GetStreamingDistributionConfig(new GetStreamingDistributionConfigRequest());
        }

        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig service method.</param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        public GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
        {
            IAsyncResult asyncResult = invokeGetStreamingDistributionConfig(request, null, null, true);
            return EndGetStreamingDistributionConfig(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamingDistributionConfig
        ///         operation.</returns>
        public IAsyncResult BeginGetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request, AsyncCallback callback, object state)
        {
            return invokeGetStreamingDistributionConfig(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistributionConfig.</param>
        /// 
        /// <returns>Returns a  GetStreamingDistributionConfigResult from CloudFront.</returns>
        public  GetStreamingDistributionConfigResponse EndGetStreamingDistributionConfig(IAsyncResult asyncResult)
        {
            return endOperation< GetStreamingDistributionConfigResponse>(asyncResult);
        }

        IAsyncResult invokeGetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetStreamingDistributionConfigRequestMarshaller().Marshall(request);
            var unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListCloudFrontOriginAccessIdentities

        /// <summary>
        /// List origin access identities.
        /// </summary>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities()
        {
            return ListCloudFrontOriginAccessIdentities(new ListCloudFrontOriginAccessIdentitiesRequest());
        }

        /// <summary>
        /// List origin access identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities service method.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request)
        {
            IAsyncResult asyncResult = invokeListCloudFrontOriginAccessIdentities(request, null, null, true);
            return EndListCloudFrontOriginAccessIdentities(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudFrontOriginAccessIdentities
        ///         operation.</returns>
        public IAsyncResult BeginListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request, AsyncCallback callback, object state)
        {
            return invokeListCloudFrontOriginAccessIdentities(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudFrontOriginAccessIdentities operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudFrontOriginAccessIdentities.</param>
        /// 
        /// <returns>Returns a  ListCloudFrontOriginAccessIdentitiesResult from CloudFront.</returns>
        public  ListCloudFrontOriginAccessIdentitiesResponse EndListCloudFrontOriginAccessIdentities(IAsyncResult asyncResult)
        {
            return endOperation< ListCloudFrontOriginAccessIdentitiesResponse>(asyncResult);
        }

        IAsyncResult invokeListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListCloudFrontOriginAccessIdentitiesRequestMarshaller().Marshall(request);
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListDistributions

        /// <summary>
        /// List distributions.
        /// </summary>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListDistributionsResponse ListDistributions()
        {
            return ListDistributions(new ListDistributionsRequest());
        }

        /// <summary>
        /// List distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions service method.</param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListDistributionsResponse ListDistributions(ListDistributionsRequest request)
        {
            IAsyncResult asyncResult = invokeListDistributions(request, null, null, true);
            return EndListDistributions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributions
        ///         operation.</returns>
        public IAsyncResult BeginListDistributions(ListDistributionsRequest request, AsyncCallback callback, object state)
        {
            return invokeListDistributions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributions.</param>
        /// 
        /// <returns>Returns a  ListDistributionsResult from CloudFront.</returns>
        public  ListDistributionsResponse EndListDistributions(IAsyncResult asyncResult)
        {
            return endOperation< ListDistributionsResponse>(asyncResult);
        }

        IAsyncResult invokeListDistributions(ListDistributionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListDistributionsRequestMarshaller().Marshall(request);
            var unmarshaller = ListDistributionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListInvalidations


        /// <summary>
        /// List invalidation batches.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations service method.</param>
        /// 
        /// <returns>The response from the ListInvalidations service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        public ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request)
        {
            IAsyncResult asyncResult = invokeListInvalidations(request, null, null, true);
            return EndListInvalidations(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvalidations operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvalidations
        ///         operation.</returns>
        public IAsyncResult BeginListInvalidations(ListInvalidationsRequest request, AsyncCallback callback, object state)
        {
            return invokeListInvalidations(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvalidations operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvalidations.</param>
        /// 
        /// <returns>Returns a  ListInvalidationsResult from CloudFront.</returns>
        public  ListInvalidationsResponse EndListInvalidations(IAsyncResult asyncResult)
        {
            return endOperation< ListInvalidationsResponse>(asyncResult);
        }

        IAsyncResult invokeListInvalidations(ListInvalidationsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListInvalidationsRequestMarshaller().Marshall(request);
            var unmarshaller = ListInvalidationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListStreamingDistributions

        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListStreamingDistributionsResponse ListStreamingDistributions()
        {
            return ListStreamingDistributions(new ListStreamingDistributionsRequest());
        }

        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions service method.</param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        public ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request)
        {
            IAsyncResult asyncResult = invokeListStreamingDistributions(request, null, null, true);
            return EndListStreamingDistributions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamingDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamingDistributions
        ///         operation.</returns>
        public IAsyncResult BeginListStreamingDistributions(ListStreamingDistributionsRequest request, AsyncCallback callback, object state)
        {
            return invokeListStreamingDistributions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamingDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamingDistributions.</param>
        /// 
        /// <returns>Returns a  ListStreamingDistributionsResult from CloudFront.</returns>
        public  ListStreamingDistributionsResponse EndListStreamingDistributions(IAsyncResult asyncResult)
        {
            return endOperation< ListStreamingDistributionsResponse>(asyncResult);
        }

        IAsyncResult invokeListStreamingDistributions(ListStreamingDistributionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListStreamingDistributionsRequestMarshaller().Marshall(request);
            var unmarshaller = ListStreamingDistributionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdateCloudFrontOriginAccessIdentity


        /// <summary>
        /// Update an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the UpdateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="IllegalUpdateException">
        /// Origin and CallerReference cannot be updated.
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        public UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateCloudFrontOriginAccessIdentity(request, null, null, true);
            return EndUpdateCloudFrontOriginAccessIdentity(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        public IAsyncResult BeginUpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateCloudFrontOriginAccessIdentity(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  UpdateCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        public  UpdateCloudFrontOriginAccessIdentityResponse EndUpdateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return endOperation< UpdateCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdateDistribution


        /// <summary>
        /// Update a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="IllegalUpdateException">
        /// Origin and CallerReference cannot be updated.
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="InvalidErrorCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the whitelisted    list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names    is missing when expected.
        /// </exception>
        /// <exception cref="InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="InvalidLocationCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or    does not begin with a slash
        /// (/).
        /// </exception>
        /// <exception cref="InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the RequiredProtocols element from your distribution configuration.
        /// </exception>
        /// <exception cref="InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="InvalidViewerCertificateException">
        /// 
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="NoSuchOriginException">
        /// No origin exists with the specified Origin Id.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="TooManyCacheBehaviorsException">
        /// You cannot create anymore cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="TooManyCertificatesException">
        /// You cannot create anymore custom ssl certificates.
        /// </exception>
        /// <exception cref="TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="TooManyOriginsException">
        /// You cannot create anymore origins for the distribution.
        /// </exception>
        /// <exception cref="TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        public UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateDistribution(request, null, null, true);
            return EndUpdateDistribution(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDistribution
        ///         operation.</returns>
        public IAsyncResult BeginUpdateDistribution(UpdateDistributionRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateDistribution(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistribution.</param>
        /// 
        /// <returns>Returns a  UpdateDistributionResult from CloudFront.</returns>
        public  UpdateDistributionResponse EndUpdateDistribution(IAsyncResult asyncResult)
        {
            return endOperation< UpdateDistributionResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateDistribution(UpdateDistributionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateDistributionRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdateStreamingDistribution


        /// <summary>
        /// Update a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="IllegalUpdateException">
        /// Origin and CallerReference cannot be updated.
        /// </exception>
        /// <exception cref="InconsistentQuantitiesException">
        /// The value of Quantity and the size of Items do not match.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="InvalidIfMatchVersionException">
        /// The If-Match version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the Content-Type
        /// header is set.
        /// </exception>
        /// <exception cref="NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to false.
        /// </exception>
        /// <exception cref="TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers do not exist.
        /// </exception>
        public UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateStreamingDistribution(request, null, null, true);
            return EndUpdateStreamingDistribution(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStreamingDistribution
        ///         operation.</returns>
        public IAsyncResult BeginUpdateStreamingDistribution(UpdateStreamingDistributionRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateStreamingDistribution(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  UpdateStreamingDistributionResult from CloudFront.</returns>
        public  UpdateStreamingDistributionResponse EndUpdateStreamingDistribution(IAsyncResult asyncResult)
        {
            return endOperation< UpdateStreamingDistributionResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateStreamingDistribution(UpdateStreamingDistributionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateStreamingDistributionRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
    }
}