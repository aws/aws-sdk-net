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
    /// Amazon Comprehend Medical extracts structured information from unstructured clinical
    /// text. Use these actions to gain insight in your documents.
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


        #region  DescribeEntitiesDetectionV2Job


        /// <summary>
        /// Gets the properties associated with a medical entities detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntitiesDetectionV2Job service method.</param>
        /// 
        /// <returns>The response from the DescribeEntitiesDetectionV2Job service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeEntitiesDetectionV2Job">REST API Reference for DescribeEntitiesDetectionV2Job Operation</seealso>
        public virtual DescribeEntitiesDetectionV2JobResponse DescribeEntitiesDetectionV2Job(DescribeEntitiesDetectionV2JobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntitiesDetectionV2JobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitiesDetectionV2JobResponseUnmarshaller.Instance;

            return Invoke<DescribeEntitiesDetectionV2JobResponse>(request, options);
        }


        /// <summary>
        /// Gets the properties associated with a medical entities detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntitiesDetectionV2Job service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEntitiesDetectionV2Job service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeEntitiesDetectionV2Job">REST API Reference for DescribeEntitiesDetectionV2Job Operation</seealso>
        public virtual Task<DescribeEntitiesDetectionV2JobResponse> DescribeEntitiesDetectionV2JobAsync(DescribeEntitiesDetectionV2JobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntitiesDetectionV2JobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitiesDetectionV2JobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEntitiesDetectionV2JobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeICD10CMInferenceJob


        /// <summary>
        /// Gets the properties associated with an InferICD10CM job. Use this operation to get
        /// the status of an inference job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeICD10CMInferenceJob service method.</param>
        /// 
        /// <returns>The response from the DescribeICD10CMInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeICD10CMInferenceJob">REST API Reference for DescribeICD10CMInferenceJob Operation</seealso>
        public virtual DescribeICD10CMInferenceJobResponse DescribeICD10CMInferenceJob(DescribeICD10CMInferenceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeICD10CMInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeICD10CMInferenceJobResponseUnmarshaller.Instance;

            return Invoke<DescribeICD10CMInferenceJobResponse>(request, options);
        }


        /// <summary>
        /// Gets the properties associated with an InferICD10CM job. Use this operation to get
        /// the status of an inference job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeICD10CMInferenceJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeICD10CMInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeICD10CMInferenceJob">REST API Reference for DescribeICD10CMInferenceJob Operation</seealso>
        public virtual Task<DescribeICD10CMInferenceJobResponse> DescribeICD10CMInferenceJobAsync(DescribeICD10CMInferenceJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeICD10CMInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeICD10CMInferenceJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeICD10CMInferenceJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePHIDetectionJob


        /// <summary>
        /// Gets the properties associated with a protected health information (PHI) detection
        /// job. Use this operation to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePHIDetectionJob service method.</param>
        /// 
        /// <returns>The response from the DescribePHIDetectionJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribePHIDetectionJob">REST API Reference for DescribePHIDetectionJob Operation</seealso>
        public virtual DescribePHIDetectionJobResponse DescribePHIDetectionJob(DescribePHIDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePHIDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePHIDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribePHIDetectionJobResponse>(request, options);
        }


        /// <summary>
        /// Gets the properties associated with a protected health information (PHI) detection
        /// job. Use this operation to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePHIDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePHIDetectionJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribePHIDetectionJob">REST API Reference for DescribePHIDetectionJob Operation</seealso>
        public virtual Task<DescribePHIDetectionJobResponse> DescribePHIDetectionJobAsync(DescribePHIDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePHIDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePHIDetectionJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePHIDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRxNormInferenceJob


        /// <summary>
        /// Gets the properties associated with an InferRxNorm job. Use this operation to get
        /// the status of an inference job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRxNormInferenceJob service method.</param>
        /// 
        /// <returns>The response from the DescribeRxNormInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeRxNormInferenceJob">REST API Reference for DescribeRxNormInferenceJob Operation</seealso>
        public virtual DescribeRxNormInferenceJobResponse DescribeRxNormInferenceJob(DescribeRxNormInferenceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRxNormInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRxNormInferenceJobResponseUnmarshaller.Instance;

            return Invoke<DescribeRxNormInferenceJobResponse>(request, options);
        }


        /// <summary>
        /// Gets the properties associated with an InferRxNorm job. Use this operation to get
        /// the status of an inference job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRxNormInferenceJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRxNormInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeRxNormInferenceJob">REST API Reference for DescribeRxNormInferenceJob Operation</seealso>
        public virtual Task<DescribeRxNormInferenceJobResponse> DescribeRxNormInferenceJobAsync(DescribeRxNormInferenceJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRxNormInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRxNormInferenceJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRxNormInferenceJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectEntities


        /// <summary>
        /// The <code>DetectEntities</code> operation is deprecated. You should use the <a>DetectEntitiesV2</a>
        /// operation instead.
        /// 
        ///  
        /// <para>
        ///  Inspects the clinical text for a variety of medical entities and returns specific
        /// information about them such as entity category, location, and confidence score on
        /// that information .
        /// </para>
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
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
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
        [Obsolete("This operation is deprecated, use DetectEntitiesV2 instead.")]
        public virtual DetectEntitiesResponse DetectEntities(DetectEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<DetectEntitiesResponse>(request, options);
        }


        /// <summary>
        /// The <code>DetectEntities</code> operation is deprecated. You should use the <a>DetectEntitiesV2</a>
        /// operation instead.
        /// 
        ///  
        /// <para>
        ///  Inspects the clinical text for a variety of medical entities and returns specific
        /// information about them such as entity category, location, and confidence score on
        /// that information .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
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
        [Obsolete("This operation is deprecated, use DetectEntitiesV2 instead.")]
        public virtual Task<DetectEntitiesResponse> DetectEntitiesAsync(DetectEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetectEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectEntitiesV2


        /// <summary>
        /// Inspects the clinical text for a variety of medical entities and returns specific
        /// information about them such as entity category, location, and confidence score on
        /// that information. Amazon Comprehend Medical only detects medical entities in English
        /// language texts.
        /// 
        ///  
        /// <para>
        /// The <code>DetectEntitiesV2</code> operation replaces the <a>DetectEntities</a> operation.
        /// This new action uses a different model for determining the entities in your medical
        /// text and changes the way that some entities are returned in the output. You should
        /// use the <code>DetectEntitiesV2</code> operation in all new applications.
        /// </para>
        ///  
        /// <para>
        /// The <code>DetectEntitiesV2</code> operation returns the <code>Acuity</code> and <code>Direction</code>
        /// entities as attributes instead of types. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectEntitiesV2 service method.</param>
        /// 
        /// <returns>The response from the DetectEntitiesV2 service method, as returned by ComprehendMedical.</returns>
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
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntitiesV2">REST API Reference for DetectEntitiesV2 Operation</seealso>
        public virtual DetectEntitiesV2Response DetectEntitiesV2(DetectEntitiesV2Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesV2ResponseUnmarshaller.Instance;

            return Invoke<DetectEntitiesV2Response>(request, options);
        }


        /// <summary>
        /// Inspects the clinical text for a variety of medical entities and returns specific
        /// information about them such as entity category, location, and confidence score on
        /// that information. Amazon Comprehend Medical only detects medical entities in English
        /// language texts.
        /// 
        ///  
        /// <para>
        /// The <code>DetectEntitiesV2</code> operation replaces the <a>DetectEntities</a> operation.
        /// This new action uses a different model for determining the entities in your medical
        /// text and changes the way that some entities are returned in the output. You should
        /// use the <code>DetectEntitiesV2</code> operation in all new applications.
        /// </para>
        ///  
        /// <para>
        /// The <code>DetectEntitiesV2</code> operation returns the <code>Acuity</code> and <code>Direction</code>
        /// entities as attributes instead of types. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectEntitiesV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectEntitiesV2 service method, as returned by ComprehendMedical.</returns>
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
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntitiesV2">REST API Reference for DetectEntitiesV2 Operation</seealso>
        public virtual Task<DetectEntitiesV2Response> DetectEntitiesV2Async(DetectEntitiesV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesV2ResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetectEntitiesV2Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectPHI


        /// <summary>
        /// Inspects the clinical text for protected health information (PHI) entities and returns
        /// the entity category, location, and confidence score for each entity. Amazon Comprehend
        /// Medical only detects entities in English language texts.
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
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
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
        /// Inspects the clinical text for protected health information (PHI) entities and returns
        /// the entity category, location, and confidence score for each entity. Amazon Comprehend
        /// Medical only detects entities in English language texts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectPHI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
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
        public virtual Task<DetectPHIResponse> DetectPHIAsync(DetectPHIRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectPHIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectPHIResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetectPHIResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InferICD10CM


        /// <summary>
        /// InferICD10CM detects medical conditions as entities listed in a patient record and
        /// links those entities to normalized concept identifiers in the ICD-10-CM knowledge
        /// base from the Centers for Disease Control. Amazon Comprehend Medical only detects
        /// medical entities in English language texts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InferICD10CM service method.</param>
        /// 
        /// <returns>The response from the InferICD10CM service method, as returned by ComprehendMedical.</returns>
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
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferICD10CM">REST API Reference for InferICD10CM Operation</seealso>
        public virtual InferICD10CMResponse InferICD10CM(InferICD10CMRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InferICD10CMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InferICD10CMResponseUnmarshaller.Instance;

            return Invoke<InferICD10CMResponse>(request, options);
        }


        /// <summary>
        /// InferICD10CM detects medical conditions as entities listed in a patient record and
        /// links those entities to normalized concept identifiers in the ICD-10-CM knowledge
        /// base from the Centers for Disease Control. Amazon Comprehend Medical only detects
        /// medical entities in English language texts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InferICD10CM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InferICD10CM service method, as returned by ComprehendMedical.</returns>
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
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferICD10CM">REST API Reference for InferICD10CM Operation</seealso>
        public virtual Task<InferICD10CMResponse> InferICD10CMAsync(InferICD10CMRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InferICD10CMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InferICD10CMResponseUnmarshaller.Instance;
            
            return InvokeAsync<InferICD10CMResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InferRxNorm


        /// <summary>
        /// InferRxNorm detects medications as entities listed in a patient record and links to
        /// the normalized concept identifiers in the RxNorm database from the National Library
        /// of Medicine. Amazon Comprehend Medical only detects medical entities in English language
        /// texts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InferRxNorm service method.</param>
        /// 
        /// <returns>The response from the InferRxNorm service method, as returned by ComprehendMedical.</returns>
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
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferRxNorm">REST API Reference for InferRxNorm Operation</seealso>
        public virtual InferRxNormResponse InferRxNorm(InferRxNormRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InferRxNormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InferRxNormResponseUnmarshaller.Instance;

            return Invoke<InferRxNormResponse>(request, options);
        }


        /// <summary>
        /// InferRxNorm detects medications as entities listed in a patient record and links to
        /// the normalized concept identifiers in the RxNorm database from the National Library
        /// of Medicine. Amazon Comprehend Medical only detects medical entities in English language
        /// texts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InferRxNorm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InferRxNorm service method, as returned by ComprehendMedical.</returns>
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
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferRxNorm">REST API Reference for InferRxNorm Operation</seealso>
        public virtual Task<InferRxNormResponse> InferRxNormAsync(InferRxNormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InferRxNormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InferRxNormResponseUnmarshaller.Instance;
            
            return InvokeAsync<InferRxNormResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEntitiesDetectionV2Jobs


        /// <summary>
        /// Gets a list of medical entity detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesDetectionV2Jobs service method.</param>
        /// 
        /// <returns>The response from the ListEntitiesDetectionV2Jobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListEntitiesDetectionV2Jobs">REST API Reference for ListEntitiesDetectionV2Jobs Operation</seealso>
        public virtual ListEntitiesDetectionV2JobsResponse ListEntitiesDetectionV2Jobs(ListEntitiesDetectionV2JobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesDetectionV2JobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesDetectionV2JobsResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesDetectionV2JobsResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of medical entity detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesDetectionV2Jobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntitiesDetectionV2Jobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListEntitiesDetectionV2Jobs">REST API Reference for ListEntitiesDetectionV2Jobs Operation</seealso>
        public virtual Task<ListEntitiesDetectionV2JobsResponse> ListEntitiesDetectionV2JobsAsync(ListEntitiesDetectionV2JobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesDetectionV2JobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesDetectionV2JobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEntitiesDetectionV2JobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListICD10CMInferenceJobs


        /// <summary>
        /// Gets a list of InferICD10CM jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListICD10CMInferenceJobs service method.</param>
        /// 
        /// <returns>The response from the ListICD10CMInferenceJobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListICD10CMInferenceJobs">REST API Reference for ListICD10CMInferenceJobs Operation</seealso>
        public virtual ListICD10CMInferenceJobsResponse ListICD10CMInferenceJobs(ListICD10CMInferenceJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListICD10CMInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListICD10CMInferenceJobsResponseUnmarshaller.Instance;

            return Invoke<ListICD10CMInferenceJobsResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of InferICD10CM jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListICD10CMInferenceJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListICD10CMInferenceJobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListICD10CMInferenceJobs">REST API Reference for ListICD10CMInferenceJobs Operation</seealso>
        public virtual Task<ListICD10CMInferenceJobsResponse> ListICD10CMInferenceJobsAsync(ListICD10CMInferenceJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListICD10CMInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListICD10CMInferenceJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListICD10CMInferenceJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPHIDetectionJobs


        /// <summary>
        /// Gets a list of protected health information (PHI) detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPHIDetectionJobs service method.</param>
        /// 
        /// <returns>The response from the ListPHIDetectionJobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListPHIDetectionJobs">REST API Reference for ListPHIDetectionJobs Operation</seealso>
        public virtual ListPHIDetectionJobsResponse ListPHIDetectionJobs(ListPHIDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPHIDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPHIDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListPHIDetectionJobsResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of protected health information (PHI) detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPHIDetectionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPHIDetectionJobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListPHIDetectionJobs">REST API Reference for ListPHIDetectionJobs Operation</seealso>
        public virtual Task<ListPHIDetectionJobsResponse> ListPHIDetectionJobsAsync(ListPHIDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPHIDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPHIDetectionJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPHIDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRxNormInferenceJobs


        /// <summary>
        /// Gets a list of InferRxNorm jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRxNormInferenceJobs service method.</param>
        /// 
        /// <returns>The response from the ListRxNormInferenceJobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListRxNormInferenceJobs">REST API Reference for ListRxNormInferenceJobs Operation</seealso>
        public virtual ListRxNormInferenceJobsResponse ListRxNormInferenceJobs(ListRxNormInferenceJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRxNormInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRxNormInferenceJobsResponseUnmarshaller.Instance;

            return Invoke<ListRxNormInferenceJobsResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of InferRxNorm jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRxNormInferenceJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRxNormInferenceJobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListRxNormInferenceJobs">REST API Reference for ListRxNormInferenceJobs Operation</seealso>
        public virtual Task<ListRxNormInferenceJobsResponse> ListRxNormInferenceJobsAsync(ListRxNormInferenceJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRxNormInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRxNormInferenceJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRxNormInferenceJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartEntitiesDetectionV2Job


        /// <summary>
        /// Starts an asynchronous medical entity detection job for a collection of documents.
        /// Use the <code>DescribeEntitiesDetectionV2Job</code> operation to track the status
        /// of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEntitiesDetectionV2Job service method.</param>
        /// 
        /// <returns>The response from the StartEntitiesDetectionV2Job service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartEntitiesDetectionV2Job">REST API Reference for StartEntitiesDetectionV2Job Operation</seealso>
        public virtual StartEntitiesDetectionV2JobResponse StartEntitiesDetectionV2Job(StartEntitiesDetectionV2JobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEntitiesDetectionV2JobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEntitiesDetectionV2JobResponseUnmarshaller.Instance;

            return Invoke<StartEntitiesDetectionV2JobResponse>(request, options);
        }


        /// <summary>
        /// Starts an asynchronous medical entity detection job for a collection of documents.
        /// Use the <code>DescribeEntitiesDetectionV2Job</code> operation to track the status
        /// of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEntitiesDetectionV2Job service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEntitiesDetectionV2Job service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartEntitiesDetectionV2Job">REST API Reference for StartEntitiesDetectionV2Job Operation</seealso>
        public virtual Task<StartEntitiesDetectionV2JobResponse> StartEntitiesDetectionV2JobAsync(StartEntitiesDetectionV2JobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEntitiesDetectionV2JobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEntitiesDetectionV2JobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartEntitiesDetectionV2JobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartICD10CMInferenceJob


        /// <summary>
        /// Starts an asynchronous job to detect medical conditions and link them to the ICD-10-CM
        /// ontology. Use the <code>DescribeICD10CMInferenceJob</code> operation to track the
        /// status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartICD10CMInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StartICD10CMInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartICD10CMInferenceJob">REST API Reference for StartICD10CMInferenceJob Operation</seealso>
        public virtual StartICD10CMInferenceJobResponse StartICD10CMInferenceJob(StartICD10CMInferenceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartICD10CMInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartICD10CMInferenceJobResponseUnmarshaller.Instance;

            return Invoke<StartICD10CMInferenceJobResponse>(request, options);
        }


        /// <summary>
        /// Starts an asynchronous job to detect medical conditions and link them to the ICD-10-CM
        /// ontology. Use the <code>DescribeICD10CMInferenceJob</code> operation to track the
        /// status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartICD10CMInferenceJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartICD10CMInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartICD10CMInferenceJob">REST API Reference for StartICD10CMInferenceJob Operation</seealso>
        public virtual Task<StartICD10CMInferenceJobResponse> StartICD10CMInferenceJobAsync(StartICD10CMInferenceJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartICD10CMInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartICD10CMInferenceJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartICD10CMInferenceJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartPHIDetectionJob


        /// <summary>
        /// Starts an asynchronous job to detect protected health information (PHI). Use the <code>DescribePHIDetectionJob</code>
        /// operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPHIDetectionJob service method.</param>
        /// 
        /// <returns>The response from the StartPHIDetectionJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartPHIDetectionJob">REST API Reference for StartPHIDetectionJob Operation</seealso>
        public virtual StartPHIDetectionJobResponse StartPHIDetectionJob(StartPHIDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPHIDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPHIDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartPHIDetectionJobResponse>(request, options);
        }


        /// <summary>
        /// Starts an asynchronous job to detect protected health information (PHI). Use the <code>DescribePHIDetectionJob</code>
        /// operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPHIDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPHIDetectionJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartPHIDetectionJob">REST API Reference for StartPHIDetectionJob Operation</seealso>
        public virtual Task<StartPHIDetectionJobResponse> StartPHIDetectionJobAsync(StartPHIDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPHIDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPHIDetectionJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartPHIDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartRxNormInferenceJob


        /// <summary>
        /// Starts an asynchronous job to detect medication entities and link them to the RxNorm
        /// ontology. Use the <code>DescribeRxNormInferenceJob</code> operation to track the status
        /// of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRxNormInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StartRxNormInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartRxNormInferenceJob">REST API Reference for StartRxNormInferenceJob Operation</seealso>
        public virtual StartRxNormInferenceJobResponse StartRxNormInferenceJob(StartRxNormInferenceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRxNormInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRxNormInferenceJobResponseUnmarshaller.Instance;

            return Invoke<StartRxNormInferenceJobResponse>(request, options);
        }


        /// <summary>
        /// Starts an asynchronous job to detect medication entities and link them to the RxNorm
        /// ontology. Use the <code>DescribeRxNormInferenceJob</code> operation to track the status
        /// of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRxNormInferenceJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRxNormInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartRxNormInferenceJob">REST API Reference for StartRxNormInferenceJob Operation</seealso>
        public virtual Task<StartRxNormInferenceJobResponse> StartRxNormInferenceJobAsync(StartRxNormInferenceJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRxNormInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRxNormInferenceJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartRxNormInferenceJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopEntitiesDetectionV2Job


        /// <summary>
        /// Stops a medical entities detection job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEntitiesDetectionV2Job service method.</param>
        /// 
        /// <returns>The response from the StopEntitiesDetectionV2Job service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopEntitiesDetectionV2Job">REST API Reference for StopEntitiesDetectionV2Job Operation</seealso>
        public virtual StopEntitiesDetectionV2JobResponse StopEntitiesDetectionV2Job(StopEntitiesDetectionV2JobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEntitiesDetectionV2JobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEntitiesDetectionV2JobResponseUnmarshaller.Instance;

            return Invoke<StopEntitiesDetectionV2JobResponse>(request, options);
        }


        /// <summary>
        /// Stops a medical entities detection job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEntitiesDetectionV2Job service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEntitiesDetectionV2Job service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopEntitiesDetectionV2Job">REST API Reference for StopEntitiesDetectionV2Job Operation</seealso>
        public virtual Task<StopEntitiesDetectionV2JobResponse> StopEntitiesDetectionV2JobAsync(StopEntitiesDetectionV2JobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEntitiesDetectionV2JobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEntitiesDetectionV2JobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopEntitiesDetectionV2JobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopICD10CMInferenceJob


        /// <summary>
        /// Stops an InferICD10CM inference job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopICD10CMInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StopICD10CMInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopICD10CMInferenceJob">REST API Reference for StopICD10CMInferenceJob Operation</seealso>
        public virtual StopICD10CMInferenceJobResponse StopICD10CMInferenceJob(StopICD10CMInferenceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopICD10CMInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopICD10CMInferenceJobResponseUnmarshaller.Instance;

            return Invoke<StopICD10CMInferenceJobResponse>(request, options);
        }


        /// <summary>
        /// Stops an InferICD10CM inference job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopICD10CMInferenceJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopICD10CMInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopICD10CMInferenceJob">REST API Reference for StopICD10CMInferenceJob Operation</seealso>
        public virtual Task<StopICD10CMInferenceJobResponse> StopICD10CMInferenceJobAsync(StopICD10CMInferenceJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopICD10CMInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopICD10CMInferenceJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopICD10CMInferenceJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopPHIDetectionJob


        /// <summary>
        /// Stops a protected health information (PHI) detection job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPHIDetectionJob service method.</param>
        /// 
        /// <returns>The response from the StopPHIDetectionJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopPHIDetectionJob">REST API Reference for StopPHIDetectionJob Operation</seealso>
        public virtual StopPHIDetectionJobResponse StopPHIDetectionJob(StopPHIDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPHIDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPHIDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopPHIDetectionJobResponse>(request, options);
        }


        /// <summary>
        /// Stops a protected health information (PHI) detection job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPHIDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopPHIDetectionJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopPHIDetectionJob">REST API Reference for StopPHIDetectionJob Operation</seealso>
        public virtual Task<StopPHIDetectionJobResponse> StopPHIDetectionJobAsync(StopPHIDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPHIDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPHIDetectionJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopPHIDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopRxNormInferenceJob


        /// <summary>
        /// Stops an InferRxNorm inference job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRxNormInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StopRxNormInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopRxNormInferenceJob">REST API Reference for StopRxNormInferenceJob Operation</seealso>
        public virtual StopRxNormInferenceJobResponse StopRxNormInferenceJob(StopRxNormInferenceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopRxNormInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRxNormInferenceJobResponseUnmarshaller.Instance;

            return Invoke<StopRxNormInferenceJobResponse>(request, options);
        }


        /// <summary>
        /// Stops an InferRxNorm inference job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRxNormInferenceJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopRxNormInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopRxNormInferenceJob">REST API Reference for StopRxNormInferenceJob Operation</seealso>
        public virtual Task<StopRxNormInferenceJobResponse> StopRxNormInferenceJobAsync(StopRxNormInferenceJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopRxNormInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRxNormInferenceJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopRxNormInferenceJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}