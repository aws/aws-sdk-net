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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

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
    /// Amazon CloudFront 
    /// <para>
    /// This is the <i>Amazon CloudFront API Reference</i>. This guide is for developers who
    /// need detailed information about CloudFront API actions, data types, and errors. For
    /// detailed information about CloudFront features, see the <i>Amazon CloudFront Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudFrontClient : AmazonServiceClient, IAmazonCloudFront
    {
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudFrontClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        public AmazonCloudFrontClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(AmazonCloudFrontConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            : base(credentials, clientConfig)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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

        
        #region  CreateCloudFrontOriginAccessIdentity

        /// <summary>
        /// Creates a new origin access identity. If you're using Amazon S3 for your origin, you
        /// can use an origin access identity to require users to access your content using a
        /// CloudFront URL instead of the Amazon S3 URL. For more information about how to use
        /// origin access identities, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityAlreadyExistsException">
        /// If the <code>CallerReference</code> is a value you already sent in a previous request
        /// to create an identity but the content of the <code>CloudFrontOriginAccessIdentityConfig</code>
        /// is different from the original request, CloudFront returns a <code>CloudFrontOriginAccessIdentityAlreadyExists</code>
        /// error.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCloudFrontOriginAccessIdentitiesException">
        /// Processing your request would cause you to exceed the maximum number of origin access
        /// identities allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = CreateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<CreateCloudFrontOriginAccessIdentityRequest,CreateCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual IAsyncResult BeginCreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCloudFrontOriginAccessIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  CreateCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual CreateCloudFrontOriginAccessIdentityResponse EndCreateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDistribution

        /// <summary>
        /// Creates a new web distribution. Send a <code>POST</code> request to the <code>/<i>CloudFront
        /// API version</i>/distribution</code>/<code>distribution ID</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <code>whitelisted</code> list of cookie names. Either list of cookie names
        /// has been specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <code>RequiredProtocols</code> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <code>Origin Id</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda function associations than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        public virtual CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
        {
            var marshaller = CreateDistributionRequestMarshaller.Instance;
            var unmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionRequest,CreateDistributionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        public virtual IAsyncResult BeginCreateDistribution(CreateDistributionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDistributionRequestMarshaller.Instance;
            var unmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDistributionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistribution.</param>
        /// 
        /// <returns>Returns a  CreateDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        public virtual CreateDistributionResponse EndCreateDistribution(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDistributionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDistributionWithTags

        /// <summary>
        /// Create a new distribution with tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionWithTags service method.</param>
        /// 
        /// <returns>The response from the CreateDistributionWithTags service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <code>whitelisted</code> list of cookie names. Either list of cookie names
        /// has been specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <code>RequiredProtocols</code> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <code>Origin Id</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda function associations than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
        public virtual CreateDistributionWithTagsResponse CreateDistributionWithTags(CreateDistributionWithTagsRequest request)
        {
            var marshaller = CreateDistributionWithTagsRequestMarshaller.Instance;
            var unmarshaller = CreateDistributionWithTagsResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionWithTagsRequest,CreateDistributionWithTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionWithTags operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDistributionWithTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
        public virtual IAsyncResult BeginCreateDistributionWithTags(CreateDistributionWithTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDistributionWithTagsRequestMarshaller.Instance;
            var unmarshaller = CreateDistributionWithTagsResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDistributionWithTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistributionWithTags.</param>
        /// 
        /// <returns>Returns a  CreateDistributionWithTagsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
        public virtual CreateDistributionWithTagsResponse EndCreateDistributionWithTags(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDistributionWithTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFieldLevelEncryptionConfig

        /// <summary>
        /// Create a new field-level encryption configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the CreateFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionConfigAlreadyExistsException">
        /// The specified configuration for field-level encryption already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.QueryArgProfileEmptyException">
        /// No profile specified for the field-level encryption query argument.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionConfigsException">
        /// The maximum number of configurations for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionContentTypeProfilesException">
        /// The maximum number of content type profiles for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionQueryArgProfilesException">
        /// The maximum number of query arg profiles for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        public virtual CreateFieldLevelEncryptionConfigResponse CreateFieldLevelEncryptionConfig(CreateFieldLevelEncryptionConfigRequest request)
        {
            var marshaller = CreateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<CreateFieldLevelEncryptionConfigRequest,CreateFieldLevelEncryptionConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFieldLevelEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateFieldLevelEncryptionConfig(CreateFieldLevelEncryptionConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return BeginInvoke<CreateFieldLevelEncryptionConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFieldLevelEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  CreateFieldLevelEncryptionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        public virtual CreateFieldLevelEncryptionConfigResponse EndCreateFieldLevelEncryptionConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFieldLevelEncryptionConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFieldLevelEncryptionProfile

        /// <summary>
        /// Create a field-level encryption profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionProfile service method.</param>
        /// 
        /// <returns>The response from the CreateFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileAlreadyExistsException">
        /// The specified profile for field-level encryption already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileSizeExceededException">
        /// The maximum size of a profile for field-level encryption was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionEncryptionEntitiesException">
        /// The maximum number of encryption entities for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionFieldPatternsException">
        /// The maximum number of field patterns for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionProfilesException">
        /// The maximum number of profiles for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        public virtual CreateFieldLevelEncryptionProfileResponse CreateFieldLevelEncryptionProfile(CreateFieldLevelEncryptionProfileRequest request)
        {
            var marshaller = CreateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<CreateFieldLevelEncryptionProfileRequest,CreateFieldLevelEncryptionProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionProfile operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFieldLevelEncryptionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateFieldLevelEncryptionProfile(CreateFieldLevelEncryptionProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return BeginInvoke<CreateFieldLevelEncryptionProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFieldLevelEncryptionProfile.</param>
        /// 
        /// <returns>Returns a  CreateFieldLevelEncryptionProfileResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        public virtual CreateFieldLevelEncryptionProfileResponse EndCreateFieldLevelEncryptionProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFieldLevelEncryptionProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInvalidation

        /// <summary>
        /// Create a new invalidation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation service method.</param>
        /// 
        /// <returns>The response from the CreateInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.BatchTooLargeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyInvalidationsInProgressException">
        /// You have exceeded the maximum number of allowable InProgress invalidation batch requests,
        /// or invalidation objects.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
        public virtual CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request)
        {
            var marshaller = CreateInvalidationRequestMarshaller.Instance;
            var unmarshaller = CreateInvalidationResponseUnmarshaller.Instance;

            return Invoke<CreateInvalidationRequest,CreateInvalidationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvalidation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInvalidation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
        public virtual IAsyncResult BeginCreateInvalidation(CreateInvalidationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateInvalidationRequestMarshaller.Instance;
            var unmarshaller = CreateInvalidationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateInvalidationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInvalidation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvalidation.</param>
        /// 
        /// <returns>Returns a  CreateInvalidationResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
        public virtual CreateInvalidationResponse EndCreateInvalidation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInvalidationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePublicKey

        /// <summary>
        /// Add a new public key to CloudFront to use, for example, for field-level encryption.
        /// You can add a maximum of 10 public keys with one AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicKey service method.</param>
        /// 
        /// <returns>The response from the CreatePublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PublicKeyAlreadyExistsException">
        /// The specified public key already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyPublicKeysException">
        /// The maximum number of public keys for field-level encryption have been created. To
        /// create a new public key, delete one of the existing keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        public virtual CreatePublicKeyResponse CreatePublicKey(CreatePublicKeyRequest request)
        {
            var marshaller = CreatePublicKeyRequestMarshaller.Instance;
            var unmarshaller = CreatePublicKeyResponseUnmarshaller.Instance;

            return Invoke<CreatePublicKeyRequest,CreatePublicKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicKey operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        public virtual IAsyncResult BeginCreatePublicKey(CreatePublicKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreatePublicKeyRequestMarshaller.Instance;
            var unmarshaller = CreatePublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePublicKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePublicKey.</param>
        /// 
        /// <returns>Returns a  CreatePublicKeyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        public virtual CreatePublicKeyResponse EndCreatePublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStreamingDistribution

        /// <summary>
        /// Creates a new RMTP distribution. An RTMP distribution is similar to a web distribution,
        /// but an RTMP distribution streams media files using the Adobe Real-Time Messaging Protocol
        /// (RTMP) instead of serving files using HTTP. 
        /// 
        ///  
        /// <para>
        /// To create a new web distribution, submit a <code>POST</code> request to the <i>CloudFront
        /// API version</i>/distribution resource. The request body must include a document with
        /// a <i>StreamingDistributionConfig</i> element. The response echoes the <code>StreamingDistributionConfig</code>
        /// element and returns other information about the RTMP distribution.
        /// </para>
        ///  
        /// <para>
        /// To get the status of your request, use the <i>GET StreamingDistribution</i> API action.
        /// When the value of <code>Enabled</code> is <code>true</code> and the value of <code>Status</code>
        /// is <code>Deployed</code>, your distribution is ready. A distribution usually deploys
        /// in less than 15 minutes.
        /// </para>
        ///  
        /// <para>
        /// For more information about web distributions, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-rtmp.html">Working
        /// with RTMP Distributions</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Beginning with the 2012-05-05 version of the CloudFront API, we made substantial changes
        /// to the format of the XML document that you include in the request body when you create
        /// or update a web distribution or an RTMP distribution, and when you invalidate objects.
        /// With previous versions of the API, we discovered that it was too easy to accidentally
        /// delete one or more values for an element that accepts multiple values, for example,
        /// CNAMEs and trusted signers. Our changes for the 2012-05-05 release are intended to
        /// prevent these accidental deletions and to notify you when there's a mismatch between
        /// the number of values you say you're specifying in the <code>Quantity</code> element
        /// and the number of values specified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of streaming
        /// distributions allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
        public virtual CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request)
        {
            var marshaller = CreateStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingDistributionRequest,CreateStreamingDistributionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamingDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
        public virtual IAsyncResult BeginCreateStreamingDistribution(CreateStreamingDistributionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateStreamingDistributionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  CreateStreamingDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
        public virtual CreateStreamingDistributionResponse EndCreateStreamingDistribution(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStreamingDistributionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStreamingDistributionWithTags

        /// <summary>
        /// Create a new streaming distribution with tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistributionWithTags service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistributionWithTags service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of streaming
        /// distributions allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
        public virtual CreateStreamingDistributionWithTagsResponse CreateStreamingDistributionWithTags(CreateStreamingDistributionWithTagsRequest request)
        {
            var marshaller = CreateStreamingDistributionWithTagsRequestMarshaller.Instance;
            var unmarshaller = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingDistributionWithTagsRequest,CreateStreamingDistributionWithTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistributionWithTags operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamingDistributionWithTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
        public virtual IAsyncResult BeginCreateStreamingDistributionWithTags(CreateStreamingDistributionWithTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateStreamingDistributionWithTagsRequestMarshaller.Instance;
            var unmarshaller = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance;

            return BeginInvoke<CreateStreamingDistributionWithTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingDistributionWithTags.</param>
        /// 
        /// <returns>Returns a  CreateStreamingDistributionWithTagsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
        public virtual CreateStreamingDistributionWithTagsResponse EndCreateStreamingDistributionWithTags(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStreamingDistributionWithTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCloudFrontOriginAccessIdentity

        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity()
        {
            return DeleteCloudFrontOriginAccessIdentity(new DeleteCloudFrontOriginAccessIdentityRequest());
        }

        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = DeleteCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudFrontOriginAccessIdentityRequest,DeleteCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual IAsyncResult BeginDeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCloudFrontOriginAccessIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual DeleteCloudFrontOriginAccessIdentityResponse EndDeleteCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDistribution

        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionNotDisabledException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        public virtual DeleteDistributionResponse DeleteDistribution()
        {
            return DeleteDistribution(new DeleteDistributionRequest());
        }

        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution service method.</param>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionNotDisabledException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        public virtual DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
        {
            var marshaller = DeleteDistributionRequestMarshaller.Instance;
            var unmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return Invoke<DeleteDistributionRequest,DeleteDistributionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        public virtual IAsyncResult BeginDeleteDistribution(DeleteDistributionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDistributionRequestMarshaller.Instance;
            var unmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDistributionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDistribution.</param>
        /// 
        /// <returns>Returns a  DeleteDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        public virtual DeleteDistributionResponse EndDeleteDistribution(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDistributionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFieldLevelEncryptionConfig

        /// <summary>
        /// Remove a field-level encryption configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionConfigInUseException">
        /// The specified configuration for field-level encryption is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        public virtual DeleteFieldLevelEncryptionConfigResponse DeleteFieldLevelEncryptionConfig(DeleteFieldLevelEncryptionConfigRequest request)
        {
            var marshaller = DeleteFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteFieldLevelEncryptionConfigRequest,DeleteFieldLevelEncryptionConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFieldLevelEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteFieldLevelEncryptionConfig(DeleteFieldLevelEncryptionConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteFieldLevelEncryptionConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFieldLevelEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  DeleteFieldLevelEncryptionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        public virtual DeleteFieldLevelEncryptionConfigResponse EndDeleteFieldLevelEncryptionConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFieldLevelEncryptionConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFieldLevelEncryptionProfile

        /// <summary>
        /// Remove a field-level encryption profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileInUseException">
        /// The specified profile for field-level encryption is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        public virtual DeleteFieldLevelEncryptionProfileResponse DeleteFieldLevelEncryptionProfile(DeleteFieldLevelEncryptionProfileRequest request)
        {
            var marshaller = DeleteFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteFieldLevelEncryptionProfileRequest,DeleteFieldLevelEncryptionProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionProfile operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFieldLevelEncryptionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteFieldLevelEncryptionProfile(DeleteFieldLevelEncryptionProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteFieldLevelEncryptionProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFieldLevelEncryptionProfile.</param>
        /// 
        /// <returns>Returns a  DeleteFieldLevelEncryptionProfileResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        public virtual DeleteFieldLevelEncryptionProfileResponse EndDeleteFieldLevelEncryptionProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFieldLevelEncryptionProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePublicKey

        /// <summary>
        /// Remove a public key you previously added to CloudFront.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicKey service method.</param>
        /// 
        /// <returns>The response from the DeletePublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PublicKeyInUseException">
        /// The specified public key is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        public virtual DeletePublicKeyResponse DeletePublicKey(DeletePublicKeyRequest request)
        {
            var marshaller = DeletePublicKeyRequestMarshaller.Instance;
            var unmarshaller = DeletePublicKeyResponseUnmarshaller.Instance;

            return Invoke<DeletePublicKeyRequest,DeletePublicKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicKey operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        public virtual IAsyncResult BeginDeletePublicKey(DeletePublicKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeletePublicKeyRequestMarshaller.Instance;
            var unmarshaller = DeletePublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePublicKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePublicKey.</param>
        /// 
        /// <returns>Returns a  DeletePublicKeyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        public virtual DeletePublicKeyResponse EndDeletePublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServiceLinkedRole

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceLinkedRole service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        public virtual DeleteServiceLinkedRoleResponse DeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest request)
        {
            var marshaller = DeleteServiceLinkedRoleRequestMarshaller.Instance;
            var unmarshaller = DeleteServiceLinkedRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceLinkedRoleRequest,DeleteServiceLinkedRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceLinkedRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        public virtual IAsyncResult BeginDeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteServiceLinkedRoleRequestMarshaller.Instance;
            var unmarshaller = DeleteServiceLinkedRoleResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteServiceLinkedRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceLinkedRole.</param>
        /// 
        /// <returns>Returns a  DeleteServiceLinkedRoleResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        public virtual DeleteServiceLinkedRoleResponse EndDeleteServiceLinkedRole(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServiceLinkedRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStreamingDistribution

        /// <summary>
        /// Delete a streaming distribution. To delete an RTMP distribution using the CloudFront
        /// API, perform the following steps.
        /// 
        ///  
        /// <para>
        ///  <b>To delete an RTMP distribution using the CloudFront API</b>:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Disable the RTMP distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>GET Streaming Distribution Config</code> request to get the current
        /// configuration and the <code>Etag</code> header for the distribution. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the XML document that was returned in the response to your <code>GET Streaming
        /// Distribution Config</code> request to change the value of <code>Enabled</code> to
        /// <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>PUT Streaming Distribution Config</code> request to update the configuration
        /// for your distribution. In the request body, include the XML document that you updated
        /// in Step 3. Then set the value of the HTTP <code>If-Match</code> header to the value
        /// of the <code>ETag</code> header that CloudFront returned when you submitted the <code>GET
        /// Streaming Distribution Config</code> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to the <code>PUT Streaming Distribution Config</code> request
        /// to confirm that the distribution was successfully disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>GET Streaming Distribution Config</code> request to confirm that your
        /// changes have propagated. When propagation is complete, the value of <code>Status</code>
        /// is <code>Deployed</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DELETE Streaming Distribution</code> request. Set the value of the
        /// HTTP <code>If-Match</code> header to the value of the <code>ETag</code> header that
        /// CloudFront returned when you submitted the <code>GET Streaming Distribution Config</code>
        /// request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to your <code>DELETE Streaming Distribution</code> request to
        /// confirm that the distribution was successfully deleted.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For information about deleting a distribution using the CloudFront console, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/HowToDeleteDistribution.html">Deleting
        /// a Distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionNotDisabledException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        public virtual DeleteStreamingDistributionResponse DeleteStreamingDistribution()
        {
            return DeleteStreamingDistribution(new DeleteStreamingDistributionRequest());
        }

        /// <summary>
        /// Delete a streaming distribution. To delete an RTMP distribution using the CloudFront
        /// API, perform the following steps.
        /// 
        ///  
        /// <para>
        ///  <b>To delete an RTMP distribution using the CloudFront API</b>:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Disable the RTMP distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>GET Streaming Distribution Config</code> request to get the current
        /// configuration and the <code>Etag</code> header for the distribution. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the XML document that was returned in the response to your <code>GET Streaming
        /// Distribution Config</code> request to change the value of <code>Enabled</code> to
        /// <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>PUT Streaming Distribution Config</code> request to update the configuration
        /// for your distribution. In the request body, include the XML document that you updated
        /// in Step 3. Then set the value of the HTTP <code>If-Match</code> header to the value
        /// of the <code>ETag</code> header that CloudFront returned when you submitted the <code>GET
        /// Streaming Distribution Config</code> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to the <code>PUT Streaming Distribution Config</code> request
        /// to confirm that the distribution was successfully disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>GET Streaming Distribution Config</code> request to confirm that your
        /// changes have propagated. When propagation is complete, the value of <code>Status</code>
        /// is <code>Deployed</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DELETE Streaming Distribution</code> request. Set the value of the
        /// HTTP <code>If-Match</code> header to the value of the <code>ETag</code> header that
        /// CloudFront returned when you submitted the <code>GET Streaming Distribution Config</code>
        /// request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to your <code>DELETE Streaming Distribution</code> request to
        /// confirm that the distribution was successfully deleted.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For information about deleting a distribution using the CloudFront console, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/HowToDeleteDistribution.html">Deleting
        /// a Distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionNotDisabledException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        public virtual DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
        {
            var marshaller = DeleteStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamingDistributionRequest,DeleteStreamingDistributionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStreamingDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        public virtual IAsyncResult BeginDeleteStreamingDistribution(DeleteStreamingDistributionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteStreamingDistributionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  DeleteStreamingDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        public virtual DeleteStreamingDistributionResponse EndDeleteStreamingDistribution(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStreamingDistributionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentity

        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity()
        {
            return GetCloudFrontOriginAccessIdentity(new GetCloudFrontOriginAccessIdentityRequest());
        }

        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = GetCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCloudFrontOriginAccessIdentityRequest,GetCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual IAsyncResult BeginGetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<GetCloudFrontOriginAccessIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  GetCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual GetCloudFrontOriginAccessIdentityResponse EndGetCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCloudFrontOriginAccessIdentityConfig

        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        public virtual GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig()
        {
            return GetCloudFrontOriginAccessIdentityConfig(new GetCloudFrontOriginAccessIdentityConfigRequest());
        }

        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig service method.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        public virtual GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request)
        {
            var marshaller = GetCloudFrontOriginAccessIdentityConfigRequestMarshaller.Instance;
            var unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;

            return Invoke<GetCloudFrontOriginAccessIdentityConfigRequest,GetCloudFrontOriginAccessIdentityConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudFrontOriginAccessIdentityConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        public virtual IAsyncResult BeginGetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCloudFrontOriginAccessIdentityConfigRequestMarshaller.Instance;
            var unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;

            return BeginInvoke<GetCloudFrontOriginAccessIdentityConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudFrontOriginAccessIdentityConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentityConfig.</param>
        /// 
        /// <returns>Returns a  GetCloudFrontOriginAccessIdentityConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        public virtual GetCloudFrontOriginAccessIdentityConfigResponse EndGetCloudFrontOriginAccessIdentityConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCloudFrontOriginAccessIdentityConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDistribution

        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        public virtual GetDistributionResponse GetDistribution()
        {
            return GetDistribution(new GetDistributionRequest());
        }

        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution service method.</param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        public virtual GetDistributionResponse GetDistribution(GetDistributionRequest request)
        {
            var marshaller = GetDistributionRequestMarshaller.Instance;
            var unmarshaller = GetDistributionResponseUnmarshaller.Instance;

            return Invoke<GetDistributionRequest,GetDistributionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        public virtual IAsyncResult BeginGetDistribution(GetDistributionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDistributionRequestMarshaller.Instance;
            var unmarshaller = GetDistributionResponseUnmarshaller.Instance;

            return BeginInvoke<GetDistributionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistribution.</param>
        /// 
        /// <returns>Returns a  GetDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        public virtual GetDistributionResponse EndGetDistribution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDistributionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDistributionConfig

        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        public virtual GetDistributionConfigResponse GetDistributionConfig()
        {
            return GetDistributionConfig(new GetDistributionConfigRequest());
        }

        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig service method.</param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        public virtual GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request)
        {
            var marshaller = GetDistributionConfigRequestMarshaller.Instance;
            var unmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;

            return Invoke<GetDistributionConfigRequest,GetDistributionConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistributionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        public virtual IAsyncResult BeginGetDistributionConfig(GetDistributionConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDistributionConfigRequestMarshaller.Instance;
            var unmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;

            return BeginInvoke<GetDistributionConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionConfig.</param>
        /// 
        /// <returns>Returns a  GetDistributionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        public virtual GetDistributionConfigResponse EndGetDistributionConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDistributionConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFieldLevelEncryption

        /// <summary>
        /// Get the field-level encryption configuration information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryption service method.</param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryption service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        public virtual GetFieldLevelEncryptionResponse GetFieldLevelEncryption(GetFieldLevelEncryptionRequest request)
        {
            var marshaller = GetFieldLevelEncryptionRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionRequest,GetFieldLevelEncryptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryption operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFieldLevelEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        public virtual IAsyncResult BeginGetFieldLevelEncryption(GetFieldLevelEncryptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetFieldLevelEncryptionRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionResponseUnmarshaller.Instance;

            return BeginInvoke<GetFieldLevelEncryptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFieldLevelEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFieldLevelEncryption.</param>
        /// 
        /// <returns>Returns a  GetFieldLevelEncryptionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        public virtual GetFieldLevelEncryptionResponse EndGetFieldLevelEncryption(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFieldLevelEncryptionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFieldLevelEncryptionConfig

        /// <summary>
        /// Get the field-level encryption configuration information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        public virtual GetFieldLevelEncryptionConfigResponse GetFieldLevelEncryptionConfig(GetFieldLevelEncryptionConfigRequest request)
        {
            var marshaller = GetFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionConfigRequest,GetFieldLevelEncryptionConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFieldLevelEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        public virtual IAsyncResult BeginGetFieldLevelEncryptionConfig(GetFieldLevelEncryptionConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return BeginInvoke<GetFieldLevelEncryptionConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFieldLevelEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  GetFieldLevelEncryptionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        public virtual GetFieldLevelEncryptionConfigResponse EndGetFieldLevelEncryptionConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFieldLevelEncryptionConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFieldLevelEncryptionProfile

        /// <summary>
        /// Get the field-level encryption profile information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfile service method.</param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        public virtual GetFieldLevelEncryptionProfileResponse GetFieldLevelEncryptionProfile(GetFieldLevelEncryptionProfileRequest request)
        {
            var marshaller = GetFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionProfileRequest,GetFieldLevelEncryptionProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfile operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFieldLevelEncryptionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        public virtual IAsyncResult BeginGetFieldLevelEncryptionProfile(GetFieldLevelEncryptionProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return BeginInvoke<GetFieldLevelEncryptionProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFieldLevelEncryptionProfile.</param>
        /// 
        /// <returns>Returns a  GetFieldLevelEncryptionProfileResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        public virtual GetFieldLevelEncryptionProfileResponse EndGetFieldLevelEncryptionProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFieldLevelEncryptionProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFieldLevelEncryptionProfileConfig

        /// <summary>
        /// Get the field-level encryption profile configuration information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfileConfig service method.</param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryptionProfileConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        public virtual GetFieldLevelEncryptionProfileConfigResponse GetFieldLevelEncryptionProfileConfig(GetFieldLevelEncryptionProfileConfigRequest request)
        {
            var marshaller = GetFieldLevelEncryptionProfileConfigRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionProfileConfigRequest,GetFieldLevelEncryptionProfileConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionProfileConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfileConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFieldLevelEncryptionProfileConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        public virtual IAsyncResult BeginGetFieldLevelEncryptionProfileConfig(GetFieldLevelEncryptionProfileConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetFieldLevelEncryptionProfileConfigRequestMarshaller.Instance;
            var unmarshaller = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance;

            return BeginInvoke<GetFieldLevelEncryptionProfileConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFieldLevelEncryptionProfileConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFieldLevelEncryptionProfileConfig.</param>
        /// 
        /// <returns>Returns a  GetFieldLevelEncryptionProfileConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        public virtual GetFieldLevelEncryptionProfileConfigResponse EndGetFieldLevelEncryptionProfileConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFieldLevelEncryptionProfileConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInvalidation

        /// <summary>
        /// Get the information about an invalidation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation service method.</param>
        /// 
        /// <returns>The response from the GetInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchInvalidationException">
        /// The specified invalidation does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
        public virtual GetInvalidationResponse GetInvalidation(GetInvalidationRequest request)
        {
            var marshaller = GetInvalidationRequestMarshaller.Instance;
            var unmarshaller = GetInvalidationResponseUnmarshaller.Instance;

            return Invoke<GetInvalidationRequest,GetInvalidationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvalidation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvalidation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
        public virtual IAsyncResult BeginGetInvalidation(GetInvalidationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetInvalidationRequestMarshaller.Instance;
            var unmarshaller = GetInvalidationResponseUnmarshaller.Instance;

            return BeginInvoke<GetInvalidationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvalidation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvalidation.</param>
        /// 
        /// <returns>Returns a  GetInvalidationResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
        public virtual GetInvalidationResponse EndGetInvalidation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInvalidationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPublicKey

        /// <summary>
        /// Get the public key information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey service method.</param>
        /// 
        /// <returns>The response from the GetPublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            var marshaller = GetPublicKeyRequestMarshaller.Instance;
            var unmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyRequest,GetPublicKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual IAsyncResult BeginGetPublicKey(GetPublicKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetPublicKeyRequestMarshaller.Instance;
            var unmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke<GetPublicKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPublicKey.</param>
        /// 
        /// <returns>Returns a  GetPublicKeyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual GetPublicKeyResponse EndGetPublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPublicKeyConfig

        /// <summary>
        /// Return public key configuration informaation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKeyConfig service method.</param>
        /// 
        /// <returns>The response from the GetPublicKeyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        public virtual GetPublicKeyConfigResponse GetPublicKeyConfig(GetPublicKeyConfigRequest request)
        {
            var marshaller = GetPublicKeyConfigRequestMarshaller.Instance;
            var unmarshaller = GetPublicKeyConfigResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyConfigRequest,GetPublicKeyConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicKeyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKeyConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPublicKeyConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        public virtual IAsyncResult BeginGetPublicKeyConfig(GetPublicKeyConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetPublicKeyConfigRequestMarshaller.Instance;
            var unmarshaller = GetPublicKeyConfigResponseUnmarshaller.Instance;

            return BeginInvoke<GetPublicKeyConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPublicKeyConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPublicKeyConfig.</param>
        /// 
        /// <returns>Returns a  GetPublicKeyConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        public virtual GetPublicKeyConfigResponse EndGetPublicKeyConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPublicKeyConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStreamingDistribution

        /// <summary>
        /// Gets information about a specified RTMP distribution, including the distribution configuration.
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        public virtual GetStreamingDistributionResponse GetStreamingDistribution()
        {
            return GetStreamingDistribution(new GetStreamingDistributionRequest());
        }

        /// <summary>
        /// Gets information about a specified RTMP distribution, including the distribution configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        public virtual GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request)
        {
            var marshaller = GetStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<GetStreamingDistributionRequest,GetStreamingDistributionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamingDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        public virtual IAsyncResult BeginGetStreamingDistribution(GetStreamingDistributionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;

            return BeginInvoke<GetStreamingDistributionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  GetStreamingDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        public virtual GetStreamingDistributionResponse EndGetStreamingDistribution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStreamingDistributionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStreamingDistributionConfig

        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        public virtual GetStreamingDistributionConfigResponse GetStreamingDistributionConfig()
        {
            return GetStreamingDistributionConfig(new GetStreamingDistributionConfigRequest());
        }

        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig service method.</param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        public virtual GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
        {
            var marshaller = GetStreamingDistributionConfigRequestMarshaller.Instance;
            var unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;

            return Invoke<GetStreamingDistributionConfigRequest,GetStreamingDistributionConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamingDistributionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        public virtual IAsyncResult BeginGetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetStreamingDistributionConfigRequestMarshaller.Instance;
            var unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;

            return BeginInvoke<GetStreamingDistributionConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistributionConfig.</param>
        /// 
        /// <returns>Returns a  GetStreamingDistributionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        public virtual GetStreamingDistributionConfigResponse EndGetStreamingDistributionConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStreamingDistributionConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCloudFrontOriginAccessIdentities

        /// <summary>
        /// Lists origin access identities.
        /// </summary>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        public virtual ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities()
        {
            return ListCloudFrontOriginAccessIdentities(new ListCloudFrontOriginAccessIdentitiesRequest());
        }

        /// <summary>
        /// Lists origin access identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities service method.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        public virtual ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request)
        {
            var marshaller = ListCloudFrontOriginAccessIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListCloudFrontOriginAccessIdentitiesRequest,ListCloudFrontOriginAccessIdentitiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudFrontOriginAccessIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        public virtual IAsyncResult BeginListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListCloudFrontOriginAccessIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;

            return BeginInvoke<ListCloudFrontOriginAccessIdentitiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudFrontOriginAccessIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudFrontOriginAccessIdentities.</param>
        /// 
        /// <returns>Returns a  ListCloudFrontOriginAccessIdentitiesResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        public virtual ListCloudFrontOriginAccessIdentitiesResponse EndListCloudFrontOriginAccessIdentities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCloudFrontOriginAccessIdentitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDistributions

        /// <summary>
        /// List distributions.
        /// </summary>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        public virtual ListDistributionsResponse ListDistributions()
        {
            return ListDistributions(new ListDistributionsRequest());
        }

        /// <summary>
        /// List distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions service method.</param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        public virtual ListDistributionsResponse ListDistributions(ListDistributionsRequest request)
        {
            var marshaller = ListDistributionsRequestMarshaller.Instance;
            var unmarshaller = ListDistributionsResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsRequest,ListDistributionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        public virtual IAsyncResult BeginListDistributions(ListDistributionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListDistributionsRequestMarshaller.Instance;
            var unmarshaller = ListDistributionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDistributionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributions.</param>
        /// 
        /// <returns>Returns a  ListDistributionsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        public virtual ListDistributionsResponse EndListDistributions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDistributionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDistributionsByWebACLId

        /// <summary>
        /// List the distributions that are associated with a specified AWS WAF web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByWebACLId service method.</param>
        /// 
        /// <returns>The response from the ListDistributionsByWebACLId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
        public virtual ListDistributionsByWebACLIdResponse ListDistributionsByWebACLId(ListDistributionsByWebACLIdRequest request)
        {
            var marshaller = ListDistributionsByWebACLIdRequestMarshaller.Instance;
            var unmarshaller = ListDistributionsByWebACLIdResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByWebACLIdRequest,ListDistributionsByWebACLIdResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByWebACLId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByWebACLId operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributionsByWebACLId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
        public virtual IAsyncResult BeginListDistributionsByWebACLId(ListDistributionsByWebACLIdRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListDistributionsByWebACLIdRequestMarshaller.Instance;
            var unmarshaller = ListDistributionsByWebACLIdResponseUnmarshaller.Instance;

            return BeginInvoke<ListDistributionsByWebACLIdRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributionsByWebACLId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributionsByWebACLId.</param>
        /// 
        /// <returns>Returns a  ListDistributionsByWebACLIdResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
        public virtual ListDistributionsByWebACLIdResponse EndListDistributionsByWebACLId(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDistributionsByWebACLIdResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFieldLevelEncryptionConfigs

        /// <summary>
        /// List all field-level encryption configurations that have been created in CloudFront
        /// for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionConfigs service method.</param>
        /// 
        /// <returns>The response from the ListFieldLevelEncryptionConfigs service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        public virtual ListFieldLevelEncryptionConfigsResponse ListFieldLevelEncryptionConfigs(ListFieldLevelEncryptionConfigsRequest request)
        {
            var marshaller = ListFieldLevelEncryptionConfigsRequestMarshaller.Instance;
            var unmarshaller = ListFieldLevelEncryptionConfigsResponseUnmarshaller.Instance;

            return Invoke<ListFieldLevelEncryptionConfigsRequest,ListFieldLevelEncryptionConfigsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFieldLevelEncryptionConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionConfigs operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFieldLevelEncryptionConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        public virtual IAsyncResult BeginListFieldLevelEncryptionConfigs(ListFieldLevelEncryptionConfigsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListFieldLevelEncryptionConfigsRequestMarshaller.Instance;
            var unmarshaller = ListFieldLevelEncryptionConfigsResponseUnmarshaller.Instance;

            return BeginInvoke<ListFieldLevelEncryptionConfigsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFieldLevelEncryptionConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFieldLevelEncryptionConfigs.</param>
        /// 
        /// <returns>Returns a  ListFieldLevelEncryptionConfigsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        public virtual ListFieldLevelEncryptionConfigsResponse EndListFieldLevelEncryptionConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFieldLevelEncryptionConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFieldLevelEncryptionProfiles

        /// <summary>
        /// Request a list of field-level encryption profiles that have been created in CloudFront
        /// for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionProfiles service method.</param>
        /// 
        /// <returns>The response from the ListFieldLevelEncryptionProfiles service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        public virtual ListFieldLevelEncryptionProfilesResponse ListFieldLevelEncryptionProfiles(ListFieldLevelEncryptionProfilesRequest request)
        {
            var marshaller = ListFieldLevelEncryptionProfilesRequestMarshaller.Instance;
            var unmarshaller = ListFieldLevelEncryptionProfilesResponseUnmarshaller.Instance;

            return Invoke<ListFieldLevelEncryptionProfilesRequest,ListFieldLevelEncryptionProfilesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFieldLevelEncryptionProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionProfiles operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFieldLevelEncryptionProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        public virtual IAsyncResult BeginListFieldLevelEncryptionProfiles(ListFieldLevelEncryptionProfilesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListFieldLevelEncryptionProfilesRequestMarshaller.Instance;
            var unmarshaller = ListFieldLevelEncryptionProfilesResponseUnmarshaller.Instance;

            return BeginInvoke<ListFieldLevelEncryptionProfilesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFieldLevelEncryptionProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFieldLevelEncryptionProfiles.</param>
        /// 
        /// <returns>Returns a  ListFieldLevelEncryptionProfilesResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        public virtual ListFieldLevelEncryptionProfilesResponse EndListFieldLevelEncryptionProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFieldLevelEncryptionProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInvalidations

        /// <summary>
        /// Lists invalidation batches.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations service method.</param>
        /// 
        /// <returns>The response from the ListInvalidations service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
        public virtual ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request)
        {
            var marshaller = ListInvalidationsRequestMarshaller.Instance;
            var unmarshaller = ListInvalidationsResponseUnmarshaller.Instance;

            return Invoke<ListInvalidationsRequest,ListInvalidationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvalidations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvalidations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
        public virtual IAsyncResult BeginListInvalidations(ListInvalidationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListInvalidationsRequestMarshaller.Instance;
            var unmarshaller = ListInvalidationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListInvalidationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvalidations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvalidations.</param>
        /// 
        /// <returns>Returns a  ListInvalidationsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
        public virtual ListInvalidationsResponse EndListInvalidations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInvalidationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPublicKeys

        /// <summary>
        /// List all public keys that have been added to CloudFront for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys service method.</param>
        /// 
        /// <returns>The response from the ListPublicKeys service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request)
        {
            var marshaller = ListPublicKeysRequestMarshaller.Instance;
            var unmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListPublicKeysRequest,ListPublicKeysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPublicKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual IAsyncResult BeginListPublicKeys(ListPublicKeysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListPublicKeysRequestMarshaller.Instance;
            var unmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return BeginInvoke<ListPublicKeysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPublicKeys.</param>
        /// 
        /// <returns>Returns a  ListPublicKeysResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual ListPublicKeysResponse EndListPublicKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPublicKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStreamingDistributions

        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        public virtual ListStreamingDistributionsResponse ListStreamingDistributions()
        {
            return ListStreamingDistributions(new ListStreamingDistributionsRequest());
        }

        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions service method.</param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        public virtual ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request)
        {
            var marshaller = ListStreamingDistributionsRequestMarshaller.Instance;
            var unmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;

            return Invoke<ListStreamingDistributionsRequest,ListStreamingDistributionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamingDistributions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamingDistributions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        public virtual IAsyncResult BeginListStreamingDistributions(ListStreamingDistributionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListStreamingDistributionsRequestMarshaller.Instance;
            var unmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListStreamingDistributionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamingDistributions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamingDistributions.</param>
        /// 
        /// <returns>Returns a  ListStreamingDistributionsResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        public virtual ListStreamingDistributionsResponse EndListStreamingDistributions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStreamingDistributionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List tags for a CloudFront resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Add tags to a CloudFront resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke<TagResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Remove tags from a CloudFront resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke<UntagResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCloudFrontOriginAccessIdentity

        /// <summary>
        /// Update an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity service method.</param>
        /// 
        /// <returns>The response from the UpdateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request)
        {
            var marshaller = UpdateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<UpdateCloudFrontOriginAccessIdentityRequest,UpdateCloudFrontOriginAccessIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCloudFrontOriginAccessIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual IAsyncResult BeginUpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            var unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateCloudFrontOriginAccessIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a  UpdateCloudFrontOriginAccessIdentityResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual UpdateCloudFrontOriginAccessIdentityResponse EndUpdateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDistribution

        /// <summary>
        /// Updates the configuration for a web distribution. Perform the following steps.
        /// 
        ///  
        /// <para>
        /// For information about updating a distribution using the CloudFront console, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-creating-console.html">Creating
        /// or Updating a Web Distribution Using the CloudFront Console </a> in the <i>Amazon
        /// CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>To update a web distribution using the CloudFront API</b> 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>GetDistributionConfig</a> request to get the current configuration and
        /// an <code>Etag</code> header for the distribution.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you update the distribution again, you need to get a new <code>Etag</code> header.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Update the XML document that was returned in the response to your <code>GetDistributionConfig</code>
        /// request to include the desired changes. You can't change the value of <code>CallerReference</code>.
        /// If you try to change this value, CloudFront returns an <code>IllegalUpdate</code>
        /// error.
        /// </para>
        ///  <important> 
        /// <para>
        /// The new configuration replaces the existing configuration; the values that you specify
        /// in an <code>UpdateDistribution</code> request are not merged into the existing configuration.
        /// When you add, delete, or replace values in an element that allows multiple values
        /// (for example, <code>CNAME</code>), you must specify all of the values that you want
        /// to appear in the updated distribution. In addition, you must update the corresponding
        /// <code>Quantity</code> element.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// Submit an <code>UpdateDistribution</code> request to update the configuration for
        /// your distribution:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In the request body, include the XML document that you updated in Step 2. The request
        /// body must include an XML document with a <code>DistributionConfig</code> element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set the value of the HTTP <code>If-Match</code> header to the value of the <code>ETag</code>
        /// header that CloudFront returned when you submitted the <code>GetDistributionConfig</code>
        /// request in Step 1.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Review the response to the <code>UpdateDistribution</code> request to confirm that
        /// the configuration was successfully updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: Submit a <a>GetDistribution</a> request to confirm that your changes have
        /// propagated. When propagation is complete, the value of <code>Status</code> is <code>Deployed</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Beginning with the 2012-05-05 version of the CloudFront API, we made substantial changes
        /// to the format of the XML document that you include in the request body when you create
        /// or update a distribution. With previous versions of the API, we discovered that it
        /// was too easy to accidentally delete one or more values for an element that accepts
        /// multiple values, for example, CNAMEs and trusted signers. Our changes for the 2012-05-05
        /// release are intended to prevent these accidental deletions and to notify you when
        /// there's a mismatch between the number of values you say you're specifying in the <code>Quantity</code>
        /// element and the number of values you're actually specifying.
        /// </para>
        ///  </important> </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <code>whitelisted</code> list of cookie names. Either list of cookie names
        /// has been specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <code>RequiredProtocols</code> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <code>Origin Id</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda function associations than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        public virtual UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request)
        {
            var marshaller = UpdateDistributionRequestMarshaller.Instance;
            var unmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionRequest,UpdateDistributionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        public virtual IAsyncResult BeginUpdateDistribution(UpdateDistributionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDistributionRequestMarshaller.Instance;
            var unmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDistributionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistribution.</param>
        /// 
        /// <returns>Returns a  UpdateDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        public virtual UpdateDistributionResponse EndUpdateDistribution(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDistributionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFieldLevelEncryptionConfig

        /// <summary>
        /// Update a field-level encryption configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.QueryArgProfileEmptyException">
        /// No profile specified for the field-level encryption query argument.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionContentTypeProfilesException">
        /// The maximum number of content type profiles for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionQueryArgProfilesException">
        /// The maximum number of query arg profiles for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        public virtual UpdateFieldLevelEncryptionConfigResponse UpdateFieldLevelEncryptionConfig(UpdateFieldLevelEncryptionConfigRequest request)
        {
            var marshaller = UpdateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateFieldLevelEncryptionConfigRequest,UpdateFieldLevelEncryptionConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionConfig operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFieldLevelEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateFieldLevelEncryptionConfig(UpdateFieldLevelEncryptionConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFieldLevelEncryptionConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFieldLevelEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  UpdateFieldLevelEncryptionConfigResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        public virtual UpdateFieldLevelEncryptionConfigResponse EndUpdateFieldLevelEncryptionConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFieldLevelEncryptionConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFieldLevelEncryptionProfile

        /// <summary>
        /// Update a field-level encryption profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileAlreadyExistsException">
        /// The specified profile for field-level encryption already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileSizeExceededException">
        /// The maximum size of a profile for field-level encryption was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionEncryptionEntitiesException">
        /// The maximum number of encryption entities for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionFieldPatternsException">
        /// The maximum number of field patterns for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        public virtual UpdateFieldLevelEncryptionProfileResponse UpdateFieldLevelEncryptionProfile(UpdateFieldLevelEncryptionProfileRequest request)
        {
            var marshaller = UpdateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateFieldLevelEncryptionProfileRequest,UpdateFieldLevelEncryptionProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionProfile operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFieldLevelEncryptionProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateFieldLevelEncryptionProfile(UpdateFieldLevelEncryptionProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            var unmarshaller = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFieldLevelEncryptionProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFieldLevelEncryptionProfile.</param>
        /// 
        /// <returns>Returns a  UpdateFieldLevelEncryptionProfileResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        public virtual UpdateFieldLevelEncryptionProfileResponse EndUpdateFieldLevelEncryptionProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFieldLevelEncryptionProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePublicKey

        /// <summary>
        /// Update public key information. Note that the only value you can change is the comment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicKey service method.</param>
        /// 
        /// <returns>The response from the UpdatePublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotChangeImmutablePublicKeyFieldsException">
        /// You can't change the value of a public key.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        public virtual UpdatePublicKeyResponse UpdatePublicKey(UpdatePublicKeyRequest request)
        {
            var marshaller = UpdatePublicKeyRequestMarshaller.Instance;
            var unmarshaller = UpdatePublicKeyResponseUnmarshaller.Instance;

            return Invoke<UpdatePublicKeyRequest,UpdatePublicKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicKey operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        public virtual IAsyncResult BeginUpdatePublicKey(UpdatePublicKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdatePublicKeyRequestMarshaller.Instance;
            var unmarshaller = UpdatePublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke<UpdatePublicKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePublicKey.</param>
        /// 
        /// <returns>Returns a  UpdatePublicKeyResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        public virtual UpdatePublicKeyResponse EndUpdatePublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStreamingDistribution

        /// <summary>
        /// Update a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// Origin and <code>CallerReference</code> cannot be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <code>Quantity</code> and the size of <code>Items</code> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <code>Content-Type</code>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
        public virtual UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request)
        {
            var marshaller = UpdateStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamingDistributionRequest,UpdateStreamingDistributionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution operation on AmazonCloudFrontClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStreamingDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
        public virtual IAsyncResult BeginUpdateStreamingDistribution(UpdateStreamingDistributionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateStreamingDistributionRequestMarshaller.Instance;
            var unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateStreamingDistributionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a  UpdateStreamingDistributionResult from CloudFront.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
        public virtual UpdateStreamingDistributionResponse EndUpdateStreamingDistribution(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStreamingDistributionResponse>(asyncResult);
        }

        #endregion
        
    }
}