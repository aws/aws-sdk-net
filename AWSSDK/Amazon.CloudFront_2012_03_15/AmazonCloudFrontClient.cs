/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *  Author(s): Manoj Mehta, Norm Johanson
 *
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

using Amazon.Util;
using Amazon.Runtime;
using Amazon.CloudFront_2012_03_15.Model;
using Amazon.CloudFront_2012_03_15.Util;

namespace Amazon.CloudFront_2012_03_15
{
    /// <summary>
    /// AmazonCloudFrontClient is an implementation of AmazonCloudFront; the client allows you to manage your CloudFront 
    /// distributions and origin access identities.<br />
    /// If you want to use the AmazonCloudFrontClient from a Medium Trust hosting environment, please create the
    /// client with an AmazonCloudFrontConfig object whose UseSecureStringForAwsSecretKey property is false.
    /// </summary>
    /// <remarks>
    /// Amazon CloudFront provides a simple web services interface that can be used to store and retrieve any amount of data,
    /// at any time, from anywhere on the web. It gives any developer access to the same highly scalable, reliable,
    /// fast, inexpensive data storage infrastructure that Amazon uses to run its own global network of web sites.
    /// The service aims to maximize benefits of scale and to pass those benefits on to developers.
    /// </remarks>
    /// <seealso cref="P:Amazon.CloudFront.AmazonCloudFrontConfig.UseSecureStringForAwsSecretKey"/>
    [Obsolete("This version of the CloudFront SDK has been obsoleted but is kept around due to " +
            "breaking changes in the main Amazon.CloudFront namespace. No further updates will be made " +
            "to this version and applications should migrate to the Amazon.CloudFront namespace.")]
    public class AmazonCloudFrontClient : AmazonCloudFront
    {
        #region Private Members

        private bool ownCredentials;
        private AWSCredentials credentials;
        private AmazonCloudFrontConfig config;
        private bool disposed;
        private static int defaultRetry = 3;

        #endregion

        #region Dispose Pattern

        /// <summary>
        /// Implements the Dispose pattern for the AmazonCloudFrontClient
        /// </summary>
        /// <param name="fDisposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool fDisposing)
        {
            if (!this.disposed)
            {
                if (fDisposing && credentials != null)
                {
                    if (ownCredentials)
                    {
                        credentials.Dispose();
                    }
                    credentials = null;
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~AmazonCloudFrontClient()
        {
            this.Dispose(false);
        }

        #endregion

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
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig(), true) { }

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
        /// <param name="config">The AmazonEC2 Configuration Object</param>
        public AmazonCloudFrontClient(AmazonCloudFrontConfig config)
            : this(FallbackCredentialsFactory.GetCredentials(), config, true) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey, true), new AmazonCloudFrontConfig(), true)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFront Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The CloudFront Configuration Object</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFrontConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey, config.UseSecureStringForAwsSecretKey), config, true)
        {
        }

        /// <summary>
        /// Constructs an AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// Amazon CloudFront Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The CloudFront Configuration Object</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonCloudFrontConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true)
        {
        }

        /// <summary>
        /// Constructs an AmazonCloudFrontClient with AWSCredentials
        /// </summary>
        /// <param name="credentials"></param>
        public AmazonCloudFrontClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFrontConfig(), false) { }

        /// <summary>
        /// Constructs an AmazonCloudFrontClient with AWSCredentials and an AmazonCloudFront Configuration object
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="config"></param>
        public AmazonCloudFrontClient(AWSCredentials credentials, AmazonCloudFrontConfig config)
            : this(credentials, config, false) { }

        // Constructs an AmazonEC2Client with credentials, config and flag which
        // specifies if the credentials are owned by the client or not
        private AmazonCloudFrontClient(AWSCredentials credentials, AmazonCloudFrontConfig config, bool ownCredentials)
        {
            this.credentials = credentials;
            this.config = config;
            this.ownCredentials = ownCredentials;
        }

        #endregion

        #region Invalidation

        /// <summary>
        /// The PostInvalidation operation invalidates objects specified in the PostInvalidationRequest which will
        /// cause Cloudfront to go back to the origin to get a new copy.
        /// 
        /// <code>
        /// PostInvalidationRequest request = new PostInvalidationRequest();
        /// request.DistributionId = distributionId;
        /// request.InvalidationBatch.CallerReference = callerReference;
        /// request.InvalidationBatch.WithPaths("/image1.jpg", "/image2.jpg");
        /// PostInvalidationResponse response = cfcClient.PostInvalidation(request);
        /// </code>
        /// </summary>
        /// <param name="request">The PostInvalidationRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a PostInvalidationResponse from CloudFront.</returns>
        public PostInvalidationResponse PostInvalidation(PostInvalidationRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The PostInvalidationRequest specified is null!");
            }
            if (request.DistributionId == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Distribution Id specified is null or empty!");
            }
            if (request.InvalidationBatch == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The InvalidationBatch specified is null or empty!");
            }
            if (request.InvalidationBatch.CallerReference == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The InvalidationBatch.CallerReference specified is null or empty!");
            }

            return Invoke<PostInvalidationResponse>(ConvertPostInvalidation(request), request.Headers);
        }

        /// <summary>
        /// The GetInvalidationList operation will return back a list of all the invalidations done for a distribution for the
        /// current and previous billing period. If the list is long, you can paginate it using the MaxItems
        /// and Marker parameters
        /// 
        /// <code>
        /// GetInvalidationListRequest request = new GetInvalidationListRequest();
        /// request.DistributionId = distributionId;
        /// GetInvalidationListResponse response = cfcClient.GetInvalidationList(request);
        /// </code>
        /// </summary>
        /// <param name="request">The GetInvalidationListRequest that defines the parameters of the operation. Distribution id is a required parameter.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetInvalidationListResponse from CloudFront.</returns>
        public GetInvalidationListResponse GetInvalidationList(GetInvalidationListRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The GetInvalidationListRequest specified is null!");
            }
            if (request.DistributionId == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Distribution Id specified is null or empty!");
            }

            return Invoke<GetInvalidationListResponse>(ConvertGetInvalidationList(request), request.Headers);
        }

        /// <summary>
        /// The GetInvalidation operation returns back the details for a specific invalidation.
        /// 
        /// <code>
        /// GetInvalidationRequest request = new GetInvalidationRequest()
        ///     .WithDistribtionId(distributionId)
        ///     .WithInvalidationId(invalidationId);
        /// GetInvalidationResponse response = cfcClient.GetInvalidation(request);
        /// </code>
        /// </summary>
        /// <param name="request">The GetInvalidationRequest that defines the parameters of the operation.  Distribution id and Invalidation id are required parameters.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetInvalidationResponse from CloudFront.</returns>
        public GetInvalidationResponse GetInvalidation(GetInvalidationRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The GetInvalidationRequest specified is null!");
            }
            if (request.DistributionId == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Distribution Id specified is null or empty!");
            }
            if (request.InvalidationId == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Invalidation Id specified is null or empty!");
            }

            return Invoke<GetInvalidationResponse>(ConvertGetInvalidation(request), request.Headers);
        }

        #endregion

        #region Distribution Operations

        /// <summary>
        /// The ListDistributions operation returns a list of all of the distributions
        /// owned by the authenticated sender of the request.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a ListDistributionsResponse with the response from CloudFront.</returns>
        public ListDistributionsResponse ListDistributions()
        {
            return ListDistributions(new ListDistributionsRequest());
        }

        /// <summary>
        /// The ListDistributions operation returns a list of all of the distributions
        /// owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">The ListDistributionsRequest with values for
        /// the Marker and MaxItems properties set</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a ListDistributionsResponse with the response from CloudFront.</returns>
        public ListDistributionsResponse ListDistributions(ListDistributionsRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The ListDistributionsRequest specified is null!");
            }
            return Invoke<ListDistributionsResponse>(ConvertListDistributions(request), request.Headers);
        }

        /// <summary>
        /// The GetDistributionConfig gets the Configuration for the CloudFront distribution.
        /// For more information on the format of the CloudFront Distribution Configuration object,
        /// please refer:
        /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/DistributionConfigDatatype.html"/>
        /// </summary>
        /// <param name="request">The GetDistributionConfigRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetDistributionConfigResponse from CloudFront.</returns>
        public GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The GetDistributionConfigRequest specified is null!");
            }
            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Distribution Id specified is null or empty!");
            }

            return Invoke<GetDistributionConfigResponse>(ConvertGetDistributionConfig(request), request.Headers);
        }

        /// <summary>
        /// The GetDistributionInfo operation gets the complete information asociated with a distribution.
        /// For more information on what information is returned by CloudFront, please refer:
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/DeveloperGuide/AboutCreatingDistributions.html"/><br />
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/DistributionDatatype.html"/>
        /// </summary>
        /// <param name="request">
        /// The GetDistributionInfoRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetDistributionInfoResponse from CloudFront.</returns>
        public GetDistributionInfoResponse GetDistributionInfo(GetDistributionInfoRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The GetDistributionInfoRequest specified is null!");
            }

            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Distribution Id specified is null or empty!");
            }

            return Invoke<GetDistributionInfoResponse>(ConvertGetDistributionInfo(request), request.Headers);
        }

        /// <summary>
        /// The SetDistributionConfig operation sets the configuration for a CloudFront distribution.
        /// </summary>
        /// <param name="request">
        /// The SetDistributionConfigRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a SetDistributionConfigResponse from CloudFront.</returns>
        public SetDistributionConfigResponse SetDistributionConfig(SetDistributionConfigRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The SetDistributionConfigRequest specified is null!");
            }

            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Distribution Id specified is null or empty!");
            }

            if (!request.IsSetDistributionConfig())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "No Distribution Config specified!");
            }

            if (!request.IsSetETag())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Distribution ETag specified is null or empty. It is required for the if-match header.");
            }

            return Invoke<SetDistributionConfigResponse>(ConvertSetDistributionConfig(request), request.Headers);
        }

        /// <summary>
        /// The CreateDistribution operation creates a new CloudFront Distribution.
        /// </summary>
        /// <seealso href="http://docs.amazonwebservices.com/AmazonCloudFront/2010-11-01/APIReference/CreateDistribution.html">
        /// POST Distribution API Reference</seealso>
        /// <param name="request">
        /// The CreateDistributionRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a CreateDistributionResponse from CloudFront.</returns>
        public CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The CreateDistributionRequest specified is null!");
            }

            CloudFrontDistributionConfig config = request.DistributionConfig;

            if (config == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The request's DistributionConfig is null!");
            }

            if (!config.IsSetS3Origin() && !config.IsSetCustomOrigin())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "Either the S3Origin or CustomOrigin property must be set!");
            }
            if (config.IsSetS3Origin() && config.IsSetCustomOrigin())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "Both the S3Origin and CustomOrigin property are set, only one can be set!");
            }
            if (config.IsSetS3Origin() && !config.S3Origin.IsSetDNSName())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The DNSName property on the S3Origin object is null or empty which must be set!");
            }
            if (config.IsSetCustomOrigin() && !config.CustomOrigin.IsSetDNSName())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The DNSName property on the CustomOrigin object is null or empty which must be set!");
            }
            if (config.IsSetCustomOrigin() && !config.CustomOrigin.IsSetProtocolPolicy())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The ProtocolPolicy property on the CustomOrigin object is null which must be set!");
            }

            if (!config.IsSetCallerReference())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The CallerReference to create the distribution with is null or empty!");
            }

            return Invoke<CreateDistributionResponse>(ConvertCreateDistribution(request), request.Headers);
        }

        /// <summary>
        /// The DeleteDistribution operation deletes the distribution specified in the request.
        /// </summary>
        /// <seealso href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/DeveloperGuide/HowToDeleteDistribution.html">
        /// Deleting a Distribution Developer Guide</seealso>
        /// <param name="request">
        /// The DeleteDistributionRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a DeleteDistributionResponse from CloudFront.</returns>
        public DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The DeleteDistributionRequest specified is null!");
            }

            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Distribution Id specified is null or empty!");
            }

            if (!request.IsSetETag())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Distribution ETag specified is null or empty. It is required for the if-match header.");
            }

            return Invoke<DeleteDistributionResponse>(ConvertDeleteDistribution(request), request.Headers);
        }

        #endregion

        #region Origin Access Identity Operations

        /// <summary>
        /// The CreateOriginAccessIdentity operation creates a new CloudFront Access Identity.
        /// You can create up to 100 per AWS account.
        /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html" />
        /// </summary>
        /// <param name="request">
        /// The CreateOriginAccessIdentityRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a CreateOriginAccessIdentityResponse from CloudFront.</returns>
        /// <seealso cref="T:Amazon.CloudFront.Model.CreateOriginAccessIdentityRequest"/>
        public CreateOriginAccessIdentityResponse CreateOriginAccessIdentity(CreateOriginAccessIdentityRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The CreateOriginAccessIdentityRequest specified is null!");
            }

            CloudFrontOriginAccessIdentityConfig config = request.OriginAccessIdentityConfig;

            if (config == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The request's OriginAccessIdentityConfig is null!");
            }

            if (!config.IsSetCallerReference())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The CallerReference to create the distribution with is null or empty!");
            }

            return Invoke<CreateOriginAccessIdentityResponse>(ConvertCreateOriginAccessIdentity(request), request.Headers);
        }

        /// <summary>
        /// The DeleteOriginAccessIdentity operation deletes the origin access identity specified in the request.
        /// </summary>
        /// <param name="request">
        /// The DeleteOriginAccessIdentityRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a DeleteOriginAccessIdentityResponse from CloudFront.</returns>
        public DeleteOriginAccessIdentityResponse DeleteOriginAccessIdentity(DeleteOriginAccessIdentityRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The DeleteOriginAccessIdentityRequest specified is null!");
            }

            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The OriginAccessIdentity Id specified is null or empty!");
            }

            if (!request.IsSetETag())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The OriginAccessIdentity ETag specified is null or empty. It is required for the if-match header.");
            }

            return Invoke<DeleteOriginAccessIdentityResponse>(ConvertDeleteOriginAccessIdentity(request), request.Headers);
        }

        /// <summary>
        /// The ListOriginAccessIdentities operation returns a list of all of the Origin Access Identities
        /// owned by the authenticated sender of the request.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a ListOriginAccessIdentitiesResponse with the response from CloudFront.</returns>
        public ListOriginAccessIdentitiesResponse ListOriginAccessIdentities()
        {
            return ListOriginAccessIdentities(new ListOriginAccessIdentitiesRequest());
        }

        /// <summary>
        /// The ListOriginAccessIdentities operation returns a list of all of the Origin Access Identities
        /// owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">The ListOriginAccessIdentitiesRequest with values for
        /// the Marker and MaxItems properties set</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a ListOriginAccessIdentitiesResponse with the response from CloudFront.</returns>
        public ListOriginAccessIdentitiesResponse ListOriginAccessIdentities(ListOriginAccessIdentitiesRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The ListOriginAccessIdentitiesRequest specified is null!");
            }
            return Invoke<ListOriginAccessIdentitiesResponse>(ConvertListOriginAccessIdentities(request), request.Headers);
        }

        /// <summary>
        /// The GetOriginAccessIdentityInfo operation gets the complete information asociated with an Origin Access Identity.
        /// For more information on what information is returned by CloudFront, please refer:
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/GetOAI.html"/><br />
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/OAIDatatype.html"/>
        /// </summary>
        /// <param name="request">
        /// The GetOriginAccessIdentityInfoRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetOriginAccessIdentityInfoResponse from CloudFront.</returns>
        public GetOriginAccessIdentityInfoResponse GetOriginAccessIdentityInfo(GetOriginAccessIdentityInfoRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The GetOriginAccessIdentityInfoRequest specified is null!");
            }

            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Origin Access Identity Id specified is null or empty!");
            }

            return Invoke<GetOriginAccessIdentityInfoResponse>(ConvertGetOriginAccessIdentityInfo(request), request.Headers);
        }

        /// <summary>
        /// The GetOriginAccessIdentityConfig gets the Configuration for the CloudFront Origin Access Identity.
        /// For more information on the format of the CloudFront Origin Access Identity Configuration object,
        /// please refer:
        /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/OAIConfigDatatype.html"/>
        /// </summary>
        /// <param name="request">The GetOriginAccessIdentityConfigRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetOriginAccessIdentityConfigResponse from CloudFront.</returns>
        public GetOriginAccessIdentityConfigResponse GetOriginAccessIdentityConfig(GetOriginAccessIdentityConfigRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The GetOriginAccessIdentityConfigRequest specified is null!");
            }
            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Origin Access Identity Id specified is null or empty!");
            }

            return Invoke<GetOriginAccessIdentityConfigResponse>(ConvertGetOriginAccessIdentityConfig(request), request.Headers);
        }

        /// <summary>
        /// The SetOriginAccessIdentityConfig operation sets the configuration for a CloudFront Origin Access Identity.
        /// </summary>
        /// <param name="request">
        /// The SetOriginAccessIdentityConfigRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a SetOriginAccessIdentityConfigResponse from CloudFront.</returns>
        public SetOriginAccessIdentityConfigResponse SetOriginAccessIdentityConfig(SetOriginAccessIdentityConfigRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The SetOriginAccessIdentityConfigRequest specified is null!");
            }

            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Origin Access Identity Id specified is null or empty!");
            }

            if (!request.IsSetOriginAccessIdentityConfig())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "No OriginAccessIdentity Config specified!");
            }

            if (!request.IsSetETag())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The OriginAccessIdentity ETag specified is null or empty. It is required for the if-match header.");
            }

            return Invoke<SetOriginAccessIdentityConfigResponse>(ConvertSetOriginAccessIdentityConfig(request), request.Headers);
        }

        #endregion

        #region Operations on Streaming Distributions

        /// <summary>
        /// List CloudFront Streaming Distributions
        /// </summary>
        /// <returns>List Streaming Distributions Response from the service</returns>
        /// <remarks>
        /// The ListStreamingDistributions operation lists all of the streaming distributions 
        /// associated with your account.
        /// </remarks>
        public ListStreamingDistributionsResponse ListStreamingDistributions()
        {
            return ListStreamingDistributions(new ListStreamingDistributionsRequest());
        }

        /// <summary>
        /// List CloudFront Streaming Distributions
        /// </summary>
        /// <param name="request">The ListStreamingDistributionsRequest with values for
        /// the Marker and MaxItems properties set</param>
        /// <returns>List Streaming Distributions Response from the service</returns>
        /// <remarks>
        /// The ListStreamingDistributions operation lists all of the distributions associated with
        /// your account.
        /// </remarks>
        public ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The ListStreamingDistributionsRequest specified is null!");
            }
            return Invoke<ListStreamingDistributionsResponse>(ConvertListStreamingDistributions(request), request.Headers);
        }

        /// <summary>
        /// The GetStreamingDistributionConfig gets the Configuration for the streaming distribution.
        /// For more information on the format of the CloudFront StreamingDistribution Configuration object,
        /// please refer:
        /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/StreamingDistributionConfigDatatype.html"/>
        /// </summary>
        /// <param name="request">The GetStreamingDistributionConfigRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetStreamingDistributionConfigResponse from CloudFront.</returns>
        public GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The GetStreamingDistributionConfigRequest specified is null!");
            }
            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The StreamingDistribution Id specified is null or empty!");
            }

            return Invoke<GetStreamingDistributionConfigResponse>(ConvertGetStreamingDistributionConfig(request), request.Headers);
        }

        /// <summary>
        /// The GetStreamingDistributionInfo operation gets the complete information asociated with a streaming distribution.
        /// For more information on what information is returned by CloudFront, please refer:
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/DeveloperGuide/AboutCreatingStreamingDistributions.html"/><br />
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/StreamingDistributionDatatype.html"/>
        /// </summary>
        /// <param name="request">
        /// The GetStreamingDistributionInfoRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetStreamingDistributionInfoResponse from CloudFront.</returns>
        public GetStreamingDistributionInfoResponse GetStreamingDistributionInfo(GetStreamingDistributionInfoRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The GetStreamingDistributionInfoRequest specified is null!");
            }

            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The StreamingDistribution Id specified is null or empty!");
            }

            return Invoke<GetStreamingDistributionInfoResponse>(ConvertGetStreamingDistributionInfo(request), request.Headers);
        }

        /// <summary>
        /// The SetStreamingDistributionConfig operation sets the configuration for a CloudFront distribution.
        /// </summary>
        /// <param name="request">
        /// The SetStreamingDistributionConfigRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a SetStreamingDistributionConfigResponse from CloudFront.</returns>
        public SetStreamingDistributionConfigResponse SetStreamingDistributionConfig(SetStreamingDistributionConfigRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The SetStreamingDistributionConfigRequest specified is null!");
            }

            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The StreamingDistribution Id specified is null or empty!");
            }

            if (!request.IsSetStreamingDistributionConfig())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "No StreamingDistribution Config specified!");
            }

            if (!request.IsSetETag())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The StreamingDistribution ETag specified is null or empty. It is required for the if-match header.");
            }

            return Invoke<SetStreamingDistributionConfigResponse>(ConvertSetStreamingDistributionConfig(request), request.Headers);
        }

        /// <summary>
        /// The CreateStreamingDistribution operation creates a new CloudFront StreamingDistribution.
        /// </summary>
        /// <seealso href="http://docs.amazonwebservices.com/AmazonCloudFront/2010-11-01/APIReference/CreateStreamingDistribution.html">
        /// POST Streaming Distribution API Reference</seealso>
        /// <param name="request">
        /// The CreateStreamingDistributionRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a CreateStreamingDistributionResponse from CloudFront.</returns>
        public CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The CreateStreamingDistributionRequest specified is null!");
            }

            CloudFrontStreamingDistributionConfig config = request.StreamingDistributionConfig;

            if (config == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The request's StreamingDistributionConfig is null!");
            }

            if (!config.IsSetS3Origin() || !config.S3Origin.IsSetDNSName())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The Origin Server Bucket to create the distribution with is null or empty!");
            }

            if (!config.IsSetCallerReference())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The CallerReference to create the distribution with is null or empty!");
            }

            return Invoke<CreateStreamingDistributionResponse>(ConvertCreateStreamingDistribution(request), request.Headers);
        }

        /// <summary>
        /// The DeleteStreamingDistribution operation deletes the distribution specified in the request.
        /// </summary>
        /// <param name="request">
        /// The DeleteStreamingDistributionRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a DeleteStreamingDistributionResponse from CloudFront.</returns>
        public DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The DeleteStreamingDistributionRequest specified is null!");
            }

            if (!request.IsSetId())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The StreamingDistribution Id specified is null or empty!");
            }

            if (!request.IsSetETag())
            {
                throw new ArgumentNullException(CloudFrontConstants.RequestParam, "The StreamingDistribution ETag specified is null or empty. It is required for the if-match header.");
            }

            return Invoke<DeleteStreamingDistributionResponse>(ConvertDeleteStreamingDistribution(request), request.Headers);
        }

        #endregion

        #region Convert Methods for Distribution requests

        /**
        * Convert ListDistributionsRequest to key/value pairs
        */
        private IDictionary<CloudFrontQueryParameter, string> ConvertListDistributions(ListDistributionsRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "ListDistributions");

            StringBuilder queryStr = new StringBuilder(128);
            if (request.IsSetMarker())
            {
                queryStr.Append("?Marker=").Append(request.Marker);
            }

            if (request.IsSetMaxItems())
            {
                queryStr.Append("&MaxItems=").Append(request.MaxItems);
            }

            if (queryStr.Length > 0)
            {
                parameters.Add(CloudFrontQueryParameter.Query, queryStr.ToString());
            }

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         * Convert GetDistributionInfoRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertGetDistributionInfo(GetDistributionInfoRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "GetDistributionInfo");
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);
            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         * Convert GetDistributionConfigRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertGetDistributionConfig(GetDistributionConfigRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "GetDistributionConfig");
            parameters.Add(CloudFrontQueryParameter.Query, CloudFrontConstants.ConfigQuery);
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         *  Convert SetDistributionInfoRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertSetDistributionConfig(SetDistributionConfigRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.PutVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "SetDistributionConfig");
            parameters.Add(CloudFrontQueryParameter.Query, CloudFrontConstants.ConfigQuery);

            // A Distribution Config is definitely associated with the request
            parameters.Add(CloudFrontQueryParameter.ContentBody, request.DistributionConfig.ToString());
            parameters.Add(CloudFrontQueryParameter.ContentType, AWSSDKUtils.UrlEncodedContent);

            // A Distribution ID is needed in order to get this far
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);

            // A Distribution ETag is needed in order to get this far
            request.Headers[AWSSDKUtils.IfMatchHeader] = request.ETag;

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         *  Convert CreateDistributionRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertCreateDistribution(CreateDistributionRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.PostVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "CreateDistribution");

            // A Distribution Config is definitely associated with the request
            parameters.Add(CloudFrontQueryParameter.ContentBody, request.DistributionConfig.ToString());
            parameters.Add(CloudFrontQueryParameter.ContentType, AWSSDKUtils.UrlEncodedContent);

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         * Convert DeleteDistributionRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertDeleteDistribution(DeleteDistributionRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.DeleteVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "DeleteDistribution");
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);
            request.Headers[AWSSDKUtils.IfMatchHeader] = request.ETag;

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        #endregion

        #region Convert Methods for Origin Access Identity operations

        /**
         *  Convert CreateOriginAccessIdentityRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertCreateOriginAccessIdentity(CreateOriginAccessIdentityRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.PostVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "CreateOriginAccessIdentity");

            // A Distribution Config is definitely associated with the request
            parameters.Add(CloudFrontQueryParameter.ContentBody, request.OriginAccessIdentityConfig.ToString());
            parameters.Add(CloudFrontQueryParameter.ContentType, AWSSDKUtils.UrlEncodedContent);

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         * Convert DeleteOriginAccessIdentityRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertDeleteOriginAccessIdentity(DeleteOriginAccessIdentityRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.DeleteVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "DeleteOriginAccessIdentity");
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);
            request.Headers[AWSSDKUtils.IfMatchHeader] = request.ETag;

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
        * Convert ListOriginAccessIdentitiessRequest to key/value pairs
        */
        private IDictionary<CloudFrontQueryParameter, string> ConvertListOriginAccessIdentities(ListOriginAccessIdentitiesRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "ListOriginAccessIdentities");

            StringBuilder queryStr = new StringBuilder(128);
            if (request.IsSetMarker())
            {
                queryStr.Append("?Marker=").Append(request.Marker);
            }

            if (request.IsSetMaxItems())
            {
                queryStr.Append("&MaxItems=").Append(request.MaxItems);
            }

            if (queryStr.Length > 0)
            {
                parameters.Add(CloudFrontQueryParameter.Query, queryStr.ToString());
            }

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         * Convert GetOriginAccessIdentityInfoRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertGetOriginAccessIdentityInfo(GetOriginAccessIdentityInfoRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "GetOriginAccessIdentityInfo");
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);
            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         * Convert GetOriginAccessIdentityConfigRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertGetOriginAccessIdentityConfig(GetOriginAccessIdentityConfigRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "GetOriginAccessIdentityConfig");
            parameters.Add(CloudFrontQueryParameter.Query, CloudFrontConstants.ConfigQuery);
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         *  Convert SetOriginAccessIdentityInfoRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertSetOriginAccessIdentityConfig(SetOriginAccessIdentityConfigRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.PutVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "SetOriginAccessIdentityConfig");
            parameters.Add(CloudFrontQueryParameter.Query, CloudFrontConstants.ConfigQuery);

            // A OriginAccessIdentity Config is definitely associated with the request
            parameters.Add(CloudFrontQueryParameter.ContentBody, request.OriginAccessIdentityConfig.ToString());
            parameters.Add(CloudFrontQueryParameter.ContentType, AWSSDKUtils.UrlEncodedContent);

            // A OriginAccessIdentity ID is needed in order to get this far
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);

            // A OriginAccessIdentity ETag is needed in order to get this far
            request.Headers[AWSSDKUtils.IfMatchHeader] = request.ETag;

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        #endregion

        #region Convert Methods for Streaming Distribution requests

        /**
        * Convert ListStreamingDistributionsRequest to key/value pairs
        */
        private IDictionary<CloudFrontQueryParameter, string> ConvertListStreamingDistributions(ListStreamingDistributionsRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "ListStreamingDistributions");

            StringBuilder queryStr = new StringBuilder(128);
            if (request.IsSetMarker())
            {
                queryStr.Append("?Marker=").Append(request.Marker);
            }

            if (request.IsSetMaxItems())
            {
                queryStr.Append("&MaxItems=").Append(request.MaxItems);
            }

            if (queryStr.Length > 0)
            {
                parameters.Add(CloudFrontQueryParameter.Query, queryStr.ToString());
            }

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         *  Convert CreateStreamingDistributionRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertCreateStreamingDistribution(CreateStreamingDistributionRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.PostVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "CreateStreamingDistribution");

            // A StreamingDistribution Config is definitely associated with the request
            parameters.Add(CloudFrontQueryParameter.ContentBody, request.StreamingDistributionConfig.ToString());
            parameters.Add(CloudFrontQueryParameter.ContentType, AWSSDKUtils.UrlEncodedContent);

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
        * Convert GetStreamingDistributionInfoRequest to key/value pairs.
        */
        private IDictionary<CloudFrontQueryParameter, string> ConvertGetStreamingDistributionInfo(GetStreamingDistributionInfoRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "GetStreamingDistributionInfo");
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);
            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         * Convert GetStreamingDistributionConfigRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertGetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "GetStreamingDistributionConfig");
            parameters.Add(CloudFrontQueryParameter.Query, CloudFrontConstants.ConfigQuery);
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         *  Convert SetStreamingDistributionInfoRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertSetStreamingDistributionConfig(SetStreamingDistributionConfigRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.PutVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "SetStreamingDistributionConfig");
            parameters.Add(CloudFrontQueryParameter.Query, CloudFrontConstants.ConfigQuery);

            // A StreamingDistribution Config is definitely associated with the request
            parameters.Add(CloudFrontQueryParameter.ContentBody, request.StreamingDistributionConfig.ToString());
            parameters.Add(CloudFrontQueryParameter.ContentType, AWSSDKUtils.UrlEncodedContent);

            // A StreamingDistribution ID is needed in order to get this far
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);

            // A StreamingDistribution ETag is needed in order to get this far
            request.Headers[AWSSDKUtils.IfMatchHeader] = request.ETag;

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        /**
         * Convert DeleteStreamingDistributionRequest to key/value pairs.
         */
        private IDictionary<CloudFrontQueryParameter, string> ConvertDeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>(5);

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.DeleteVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "DeleteStreamingDistribution");
            parameters.Add(CloudFrontQueryParameter.Id, request.Id);
            request.Headers[AWSSDKUtils.IfMatchHeader] = request.ETag;

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        #endregion

        #region Convert Methods for Invalidation

        private IDictionary<CloudFrontQueryParameter, string> ConvertPostInvalidation(PostInvalidationRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>();

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.PostVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "PostInvalidation");
            parameters.Add(CloudFrontQueryParameter.ContentBody, request.InvalidationBatch.ToString());
            parameters.Add(CloudFrontQueryParameter.ContentType, AWSSDKUtils.UrlEncodedContent);

            parameters.Add(CloudFrontQueryParameter.DistributionId, request.DistributionId);

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        private IDictionary<CloudFrontQueryParameter, string> ConvertGetInvalidationList(GetInvalidationListRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>();

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "GetInvalidationList");

            parameters.Add(CloudFrontQueryParameter.DistributionId, request.DistributionId);

            StringBuilder queryStr = new StringBuilder(128);
            string delimiter = "?";
            if (request.Marker != null)
            {
                queryStr.Append(delimiter).Append("Marker=").Append(request.Marker);
                delimiter = "&";
            }

            if (request.MaxItems > 0)
            {
                queryStr.Append(delimiter).Append("MaxItems=").Append(request.MaxItems);
                delimiter = "&";
            }

            if (queryStr.Length > 0)
            {
                parameters.Add(CloudFrontQueryParameter.Query, queryStr.ToString());
            }

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        private IDictionary<CloudFrontQueryParameter, string> ConvertGetInvalidation(GetInvalidationRequest request)
        {
            IDictionary<CloudFrontQueryParameter, string> parameters = new Dictionary<CloudFrontQueryParameter, string>();

            parameters.Add(CloudFrontQueryParameter.Verb, CloudFrontConstants.GetVerb);
            parameters.Add(CloudFrontQueryParameter.Action, "GetInvalidation");

            parameters.Add(CloudFrontQueryParameter.DistributionId, request.DistributionId);
            parameters.Add(CloudFrontQueryParameter.InvalidationId, request.InvalidationId);

            AddCloudFrontQueryParameters(parameters, request.Headers);

            return parameters;
        }

        #endregion

        #region Private Methods

        /**
         * Add authentication related and version parameters
         */
        private void AddCloudFrontQueryParameters(IDictionary<CloudFrontQueryParameter, string> parameters, WebHeaderCollection webHeaders)
        {
            if (webHeaders != null)
            {
                webHeaders[CloudFrontConstants.AmzDateHeader] = AmazonCloudFrontUtil.FormattedCurrentTimestamp;
            }

            string action = parameters[CloudFrontQueryParameter.Action];
            StringBuilder canonicalResource = new StringBuilder(CloudFrontConstants.ServiceResource, 256);

            if (null == action)
            {
                throw new AmazonCloudFrontException("No ACTION set for the operation");
            }

            if (action.Contains("StreamingDistribution"))
            {
                canonicalResource.Append("streaming-distribution");
            }
            else if (action.Contains("Distribution"))
            {
                canonicalResource.Append("distribution");
            }
            else if (action.Contains("OriginAccessIdentit"))
            {
                canonicalResource.Append("origin-access-identity/cloudfront");
            }
            else if(action.Equals("PostInvalidation"))
            {                
                canonicalResource.AppendFormat("distribution/{0}/invalidation", parameters[CloudFrontQueryParameter.DistributionId]);
            }
            else if (action.Equals("GetInvalidationList"))
            {
                canonicalResource.AppendFormat("distribution/{0}/invalidation", parameters[CloudFrontQueryParameter.DistributionId]);
            }
            else if (action.Equals("GetInvalidation"))
            {
                canonicalResource.AppendFormat("distribution/{0}/invalidation/{1}", 
                    parameters[CloudFrontQueryParameter.DistributionId], parameters[CloudFrontQueryParameter.InvalidationId]);
            }

            if (parameters.ContainsKey(CloudFrontQueryParameter.Id))
            {
                canonicalResource.Append("/");
                canonicalResource.Append(parameters[CloudFrontQueryParameter.Id]);
            }

            if (parameters.ContainsKey(CloudFrontQueryParameter.Query))
            {
                canonicalResource.Append(parameters[CloudFrontQueryParameter.Query]);
            }

            parameters.Add(
                CloudFrontQueryParameter.CanonicalizedResource,
                canonicalResource.ToString()
                );
        }

        /**
        * Invoke request and return response
        */
        private T Invoke<T>(IDictionary<CloudFrontQueryParameter, string> parameters, WebHeaderCollection headers) where T : CloudFrontResponse, new()
        {
            ImmutableCredentials immutableCredentials = credentials.GetCredentials();
            string auth;
            if (immutableCredentials.UseSecureStringForSecretKey)
            {
                auth = BuildSigningString(headers, immutableCredentials.SecureSecretKey);
            }
            else
            {
                auth = BuildSigningString(headers, immutableCredentials.ClearSecretKey);
            }
            parameters.Add(CloudFrontQueryParameter.Authorization, auth);



            string actionName = parameters[CloudFrontQueryParameter.Action];
            T response = default(T);
            HttpStatusCode statusCode = default(HttpStatusCode);
            string verb = parameters[CloudFrontQueryParameter.Verb];

            // Variables that pertain to PUT requests
            byte[] requestData = Encoding.UTF8.GetBytes("");
            long reqDataLen = 0;

            // The HTTP operation specified has to be one of the operations
            // the Amazon CloudFront service explicitly supports
            if (!(verb.Equals(CloudFrontConstants.PostVerb) ||
                verb.Equals(CloudFrontConstants.PutVerb) ||
                verb.Equals(CloudFrontConstants.GetVerb) ||
                verb.Equals(CloudFrontConstants.DeleteVerb)))
            {
                throw new AmazonCloudFrontException("Invalid HTTP Operation attempted! Supported operations - GET, POST, PUT, DELETE");
            }

            if (parameters.ContainsKey(CloudFrontQueryParameter.ContentBody))
            {
                string reqBody = parameters[CloudFrontQueryParameter.ContentBody];
                requestData = Encoding.UTF8.GetBytes(reqBody);

                // Since there is a request body, determine the length of the
                // data that will be sent to the server.
                reqDataLen = requestData.Length;
            }

            bool shouldRetry = false;
            string requestAddr;
            HttpWebRequest request;
            int retries = 0;
            int maxRetries = config.IsSetMaxErrorRetry() ? config.MaxErrorRetry : AWSSDKUtils.DefaultMaxRetry;
            do
            {
                request = ConfigureWebRequest(parameters, headers, reqDataLen, immutableCredentials);
                requestAddr = request.Address.ToString();
                // Submit the request and read response body
                try
                {
                    // Accessing the Request Stream for operations other than PUT results
                    // in a ProtocolViolationException. Good thing to test is whether
                    // the request data length > 0 or the HTTP Verb is "PUT"
                    if (reqDataLen > 0)
                    {
                        using (Stream requestStream = request.GetRequestStream())
                        {
                            using (MemoryStream ms = new MemoryStream(requestData))
                            {
                                byte[] buffer = new byte[32768];
                                int count = 0;
                                while ((count = ms.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    requestStream.Write(buffer, 0, count);
                                }
                            }
                        }
                    }

                    // The request submission has completed. Retrieve the response.
                    response = ProcessRequestResponse<T>(request, actionName);
                    shouldRetry = false;
                }
                // Web exception is thrown on unsucessful responses
                catch (WebException we)
                {
                    WebHeaderCollection respHdrs;
                    shouldRetry = ProcessRequestError(request, we, requestAddr, out respHdrs);

                    if (shouldRetry)
                    {
                        PauseOnRetry(
                            ++retries,
                            config.IsSetMaxErrorRetry() ? config.MaxErrorRetry : defaultRetry,
                            statusCode,
                            requestAddr,
                            respHdrs,
                            we
                            );
                    }
                }
                catch (IOException)
                {
                    // Let's abort this "unsuccessful" request
                    request.Abort();
                    throw;
                }
            } while (shouldRetry && retries <= config.MaxErrorRetry);

            return response;
        }

        private T ProcessRequestResponse<T>(HttpWebRequest request, string actionName) where T : CloudFrontResponse, new()
        {
            T response = default(T);

            using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse)
            {
                if (httpResponse == null)
                {
                    throw new WebException(
                        "The Web Response for a successful request is null!",
                        WebExceptionStatus.ProtocolError
                        );
                }

                WebHeaderCollection headerCollection = httpResponse.Headers;
                string responseBody = null;

                using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
                {
                    responseBody = reader.ReadToEnd();
                }

                // Perform response transformation
                if (!String.IsNullOrEmpty(responseBody) &&
                    responseBody.EndsWith(">"))
                {
                    string transformed = Transform(responseBody, actionName, this.GetType());

                    // Attempt to deserialize response into <Action> Response type
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    using (XmlTextReader sr = new XmlTextReader(new StringReader(transformed)))
                    {
                        response = (T)serializer.Deserialize(sr);
                    }
                }
                else
                {
                    // We can receive responses that have no response body.
                    // All responses have headers so at a future point,
                    // we "do" attach the headers to the response.
                    response = new T();
                }

                // Store the headers in the response for all successful service requests
                if (response != null)
                {
                    // Add the header key/value pairs to our <Action> Response type
                    response.Headers = headerCollection;

                    // Save the actual XML for future reference, just in case it
                    // is needed for debugging, etc
                    response.XML = responseBody;

                    // Get Service specific data out of the response headers
                    GetServiceSpecificDataFromHeader(response);
                }
            }

            return response;
        }

        private static bool ProcessRequestError(HttpWebRequest request, WebException we, string requestAddr, out WebHeaderCollection respHdrs)
        {
            bool shouldRetry = false;
            HttpStatusCode statusCode = default(HttpStatusCode);
            string responseBody = null;

            // Initialize the out parameter to null
            // in case there is no httpErrorResponse
            respHdrs = null;

            using (HttpWebResponse httpErrorResponse = we.Response as HttpWebResponse)
            {
                if (httpErrorResponse == null)
                {
                    // Abort the unsuccessful request
                    request.Abort();
                    throw we;
                }

                // Set the response headers for future use
                respHdrs = httpErrorResponse.Headers;

                // Obtain the HTTP status code
                statusCode = httpErrorResponse.StatusCode;

                using (StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8))
                {
                    responseBody = reader.ReadToEnd();
                }

                // Abort the unsuccessful request
                request.Abort();
            }

            if (statusCode == HttpStatusCode.InternalServerError ||
                statusCode == HttpStatusCode.ServiceUnavailable)
            {
                shouldRetry = true;
            }
            else if (!String.IsNullOrEmpty(responseBody))
            {
                // Attempt to deserialize response into ErrorResponse type
                using (XmlTextReader sr = new XmlTextReader(new StringReader(responseBody)))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ErrorResponse));
                    ErrorResponse errorResponse = (ErrorResponse)serializer.Deserialize(sr);
                    CloudFrontError error = errorResponse.Error[0];

                    // Throw formatted exception with information available from the error response
                    throw new AmazonCloudFrontException(error.Message, statusCode, error.Code, error.RequestId, error.Type, responseBody, requestAddr, respHdrs, null);
                }
            }
            return shouldRetry;
        }

        /**
         * Sets the headers we want to expose to the user from the response.
         */
        private static void GetServiceSpecificDataFromHeader(CloudFrontResponse response)
        {
            string value;
            if (!String.IsNullOrEmpty(value = response.Headers.Get(CloudFrontConstants.AmzRequestIdHeader)))
            {
                response.RequestId = value;
            }

            if (!String.IsNullOrEmpty(value = response.Headers.Get(AWSSDKUtils.ETagHeader)))
            {
                response.ETag = value;
            }
        }

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonEC2Config instance
         */
        private HttpWebRequest ConfigureWebRequest(IDictionary<CloudFrontQueryParameter, string> parameters, WebHeaderCollection headers, long contentLength, ImmutableCredentials immutableCredentials)
        {
            string url = config.ServiceURL;

            // Encode the portion of the URL before adding the query string
            url = AWSSDKUtils.UrlEncode(url, true);

            if (parameters.ContainsKey(CloudFrontQueryParameter.CanonicalizedResource))
            {
                url = String.Concat(url, parameters[CloudFrontQueryParameter.CanonicalizedResource]);
            }

            HttpWebRequest httpRequest = WebRequest.Create(url) as HttpWebRequest;

            if (httpRequest != null)
            {
                httpRequest.ServicePoint.ConnectionLimit = this.config.ConnectionLimit;

                if (config.IsSetProxyHost() && config.IsSetProxyPort())
                {
                    WebProxy proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                    httpRequest.Proxy = proxy;
                }
                if (httpRequest.Proxy != null && config.IsSetProxyCredentials())
                {
                    httpRequest.Proxy.Credentials = config.ProxyCredentials;
                }

                httpRequest.UserAgent = config.UserAgent;

                // Add the AWS Authorization header.
                httpRequest.Headers[CloudFrontConstants.AuthorizationHeader] = String.Concat(
                    "AWS ",
                    immutableCredentials.AccessKey,
                    ":",
                    parameters[CloudFrontQueryParameter.Authorization]
                    );

                httpRequest.Headers.Add(headers);
                httpRequest.Method = parameters[CloudFrontQueryParameter.Verb];

                if (parameters.ContainsKey(CloudFrontQueryParameter.ContentType))
                {
                    httpRequest.ContentType = parameters[CloudFrontQueryParameter.ContentType];
                }

                httpRequest.ContentLength = contentLength;
                httpRequest.KeepAlive = false;
                httpRequest.AllowAutoRedirect = true;
                httpRequest.MaximumAutomaticRedirections = 2;
                httpRequest.AllowWriteStreamBuffering = false;
            }

            return httpRequest;
        }

        /**
         * Exponential sleep on failed request
         */
        private static void PauseOnRetry(int retries, int maxRetries, HttpStatusCode status, string requestAddr, WebHeaderCollection headers, Exception cause)
        {
            if (retries <= maxRetries)
            {
                int delay = (int)Math.Pow(4, retries) * 100;
                System.Threading.Thread.Sleep(delay);
            }
            else
            {
                throw new AmazonCloudFrontException(
                    String.Concat("Maximum number of retry attempts reached : ", (retries - 1)),
                    status,
                    "",
                    "",
                    "",
                    "",
                    requestAddr,
                    headers,
                    cause
                    );
            }
        }

        /*
         *  Transforms response based on xslt template
         */
        private static string Transform(string responseBody, string actionName, Type t)
        {
            char[] seps = { ',' };
            Assembly assembly = Assembly.GetAssembly(t);

            string assemblyName = assembly.FullName;
            assemblyName = assemblyName.Split(seps)[0];

            // Build the name of the xslt Transform to apply to the response
            string ns = t.Namespace;
            string resourceName = String.Concat(
                assemblyName,
                ".",
                ns,
                ".Model.",
                actionName,
                "Response.xslt"
                );

            XslCompiledTransform transformer = AWSSDKUtils.GetXslCompiledTransform(resourceName);
            StringBuilder sb = new StringBuilder(1024);
            using (XmlTextReader xmlR = new XmlTextReader(new StringReader(responseBody)))
            {
                using (StringWriter sw = new StringWriter(sb))
                {
                    transformer.Transform(xmlR, null, sw);
                    return sb.ToString();
                }
            }
        }

        /**
         * Creates a string based on the parameters and encrypts it using
         * key. Returns the encrypted string.
         */
        private static string BuildSigningString(WebHeaderCollection headers, SecureString key)
        {
            return AWSSDKUtils.HMACSign(
                headers.Get(CloudFrontConstants.AmzDateHeader),
                key,
                new HMACSHA1()
                );
        }

        /**
         * Creates a string based on the parameters and encrypts it using
         * key. Returns the encrypted string.
         */
        private static string BuildSigningString(WebHeaderCollection headers, string key)
        {
            return AWSSDKUtils.HMACSign(
                headers.Get(CloudFrontConstants.AmzDateHeader),
                key,
                new HMACSHA1()
                );
        }

        #endregion
    }
}