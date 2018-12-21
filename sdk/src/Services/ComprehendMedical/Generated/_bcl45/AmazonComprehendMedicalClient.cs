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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ComprehendMedical.Model;
using Amazon.ComprehendMedical.Model.Internal.MarshallTransformations;
using Amazon.ComprehendMedical.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ComprehendMedical
{
    /// <summary>
    /// Implementation for accessing ComprehendMedical
    ///
    /// Comprehend Medical extracts structured information from unstructured clinical text.
    /// Use these actions to gain insight in your documents.
    /// </summary>
    public partial class AmazonComprehendMedicalClient : AmazonServiceClient, IAmazonComprehendMedical
    {
        private static IServiceMetadata serviceMetadata = new AmazonComprehendMedicalMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with the credentials loaded from the application's
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
        public AmazonComprehendMedicalClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonComprehendMedicalConfig()) { }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with the credentials loaded from the application's
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
        public AmazonComprehendMedicalClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonComprehendMedicalConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonComprehendMedicalClient Configuration Object</param>
        public AmazonComprehendMedicalClient(AmazonComprehendMedicalConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonComprehendMedicalClient(AWSCredentials credentials)
            : this(credentials, new AmazonComprehendMedicalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComprehendMedicalClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonComprehendMedicalConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with AWS Credentials and an
        /// AmazonComprehendMedicalClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonComprehendMedicalClient Configuration Object</param>
        public AmazonComprehendMedicalClient(AWSCredentials credentials, AmazonComprehendMedicalConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonComprehendMedicalClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComprehendMedicalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComprehendMedicalClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComprehendMedicalConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComprehendMedicalClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonComprehendMedicalClient Configuration Object</param>
        public AmazonComprehendMedicalClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonComprehendMedicalConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonComprehendMedicalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComprehendMedicalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComprehendMedicalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComprehendMedicalConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendMedicalClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComprehendMedicalClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonComprehendMedicalClient Configuration Object</param>
        public AmazonComprehendMedicalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonComprehendMedicalConfig clientConfig)
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


        #region  DetectEntities


        /// <summary>
        /// Inspects the clinical text for a variety of medical entities and returns specific
        /// information about them such as entity category, location, and confidence score on
        /// that information .
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectEntities service method.</param>
        /// 
        /// <returns>The response from the DetectEntities service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidEncodingException">
        /// The input text was not in valid UTF-8 character encoding. Check your text then retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ServiceUnavailableException">
        /// The Comprehend Medical service is temporarily unavailable. Please wait and then retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        public virtual DetectEntitiesResponse DetectEntities(DetectEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<DetectEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectEntities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        public virtual Task<DetectEntitiesResponse> DetectEntitiesAsync(DetectEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetectEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectPHI


        /// <summary>
        /// Inspects the clinical text for personal health information (PHI) entities and entity
        /// category, location, and confidence score on that information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectPHI service method.</param>
        /// 
        /// <returns>The response from the DetectPHI service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidEncodingException">
        /// The input text was not in valid UTF-8 character encoding. Check your text then retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ServiceUnavailableException">
        /// The Comprehend Medical service is temporarily unavailable. Please wait and then retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectPHI">REST API Reference for DetectPHI Operation</seealso>
        public virtual DetectPHIResponse DetectPHI(DetectPHIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectPHIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectPHIResponseUnmarshaller.Instance;

            return Invoke<DetectPHIResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectPHI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectPHI operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectPHI">REST API Reference for DetectPHI Operation</seealso>
        public virtual Task<DetectPHIResponse> DetectPHIAsync(DetectPHIRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectPHIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectPHIResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetectPHIResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}