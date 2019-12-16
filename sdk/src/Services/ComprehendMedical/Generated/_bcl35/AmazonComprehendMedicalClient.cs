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
        /// Initiates the asynchronous execution of the DescribeEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntitiesDetectionV2Job operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEntitiesDetectionV2Job
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeEntitiesDetectionV2Job">REST API Reference for DescribeEntitiesDetectionV2Job Operation</seealso>
        public virtual IAsyncResult BeginDescribeEntitiesDetectionV2Job(DescribeEntitiesDetectionV2JobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntitiesDetectionV2JobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitiesDetectionV2JobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEntitiesDetectionV2Job.</param>
        /// 
        /// <returns>Returns a  DescribeEntitiesDetectionV2JobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeEntitiesDetectionV2Job">REST API Reference for DescribeEntitiesDetectionV2Job Operation</seealso>
        public virtual DescribeEntitiesDetectionV2JobResponse EndDescribeEntitiesDetectionV2Job(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEntitiesDetectionV2JobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribePHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePHIDetectionJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePHIDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribePHIDetectionJob">REST API Reference for DescribePHIDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginDescribePHIDetectionJob(DescribePHIDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePHIDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePHIDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePHIDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribePHIDetectionJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribePHIDetectionJob">REST API Reference for DescribePHIDetectionJob Operation</seealso>
        public virtual DescribePHIDetectionJobResponse EndDescribePHIDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePHIDetectionJobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DetectEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectEntities operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        [Obsolete("This operation is deprecated, use DetectEntitiesV2 instead.")]
        public virtual IAsyncResult BeginDetectEntities(DetectEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectEntities.</param>
        /// 
        /// <returns>Returns a  DetectEntitiesResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        [Obsolete("This operation is deprecated, use DetectEntitiesV2 instead.")]
        public virtual DetectEntitiesResponse EndDetectEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectEntitiesV2

        /// <summary>
        /// Inspects the clinical text for a variety of medical entities and returns specific
        /// information about them such as entity category, location, and confidence score on
        /// that information.
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
        /// Initiates the asynchronous execution of the DetectEntitiesV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectEntitiesV2 operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectEntitiesV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntitiesV2">REST API Reference for DetectEntitiesV2 Operation</seealso>
        public virtual IAsyncResult BeginDetectEntitiesV2(DetectEntitiesV2Request request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesV2ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectEntitiesV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectEntitiesV2.</param>
        /// 
        /// <returns>Returns a  DetectEntitiesV2Result from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntitiesV2">REST API Reference for DetectEntitiesV2 Operation</seealso>
        public virtual DetectEntitiesV2Response EndDetectEntitiesV2(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectEntitiesV2Response>(asyncResult);
        }

        #endregion
        
        #region  DetectPHI

        /// <summary>
        /// Inspects the clinical text for protected health information (PHI) entities and entity
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
        /// Initiates the asynchronous execution of the DetectPHI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectPHI operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectPHI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectPHI">REST API Reference for DetectPHI Operation</seealso>
        public virtual IAsyncResult BeginDetectPHI(DetectPHIRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectPHIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectPHIResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectPHI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectPHI.</param>
        /// 
        /// <returns>Returns a  DetectPHIResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectPHI">REST API Reference for DetectPHI Operation</seealso>
        public virtual DetectPHIResponse EndDetectPHI(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectPHIResponse>(asyncResult);
        }

        #endregion
        
        #region  InferICD10CM

        /// <summary>
        /// InferICD10CM detects medical conditions as entities listed in a patient record and
        /// links those entities to normalized concept identifiers in the ICD-10-CM knowledge
        /// base from the Centers for Disease Control.
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
        /// Initiates the asynchronous execution of the InferICD10CM operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InferICD10CM operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInferICD10CM
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferICD10CM">REST API Reference for InferICD10CM Operation</seealso>
        public virtual IAsyncResult BeginInferICD10CM(InferICD10CMRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InferICD10CMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InferICD10CMResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InferICD10CM operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInferICD10CM.</param>
        /// 
        /// <returns>Returns a  InferICD10CMResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferICD10CM">REST API Reference for InferICD10CM Operation</seealso>
        public virtual InferICD10CMResponse EndInferICD10CM(IAsyncResult asyncResult)
        {
            return EndInvoke<InferICD10CMResponse>(asyncResult);
        }

        #endregion
        
        #region  InferRxNorm

        /// <summary>
        /// InferRxNorm detects medications as entities listed in a patient record and links to
        /// the normalized concept identifiers in the RxNorm database from the National Library
        /// of Medicine.
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
        /// Initiates the asynchronous execution of the InferRxNorm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InferRxNorm operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInferRxNorm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferRxNorm">REST API Reference for InferRxNorm Operation</seealso>
        public virtual IAsyncResult BeginInferRxNorm(InferRxNormRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InferRxNormRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InferRxNormResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InferRxNorm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInferRxNorm.</param>
        /// 
        /// <returns>Returns a  InferRxNormResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferRxNorm">REST API Reference for InferRxNorm Operation</seealso>
        public virtual InferRxNormResponse EndInferRxNorm(IAsyncResult asyncResult)
        {
            return EndInvoke<InferRxNormResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListEntitiesDetectionV2Jobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesDetectionV2Jobs operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntitiesDetectionV2Jobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListEntitiesDetectionV2Jobs">REST API Reference for ListEntitiesDetectionV2Jobs Operation</seealso>
        public virtual IAsyncResult BeginListEntitiesDetectionV2Jobs(ListEntitiesDetectionV2JobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesDetectionV2JobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesDetectionV2JobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntitiesDetectionV2Jobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntitiesDetectionV2Jobs.</param>
        /// 
        /// <returns>Returns a  ListEntitiesDetectionV2JobsResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListEntitiesDetectionV2Jobs">REST API Reference for ListEntitiesDetectionV2Jobs Operation</seealso>
        public virtual ListEntitiesDetectionV2JobsResponse EndListEntitiesDetectionV2Jobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEntitiesDetectionV2JobsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListPHIDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPHIDetectionJobs operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPHIDetectionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListPHIDetectionJobs">REST API Reference for ListPHIDetectionJobs Operation</seealso>
        public virtual IAsyncResult BeginListPHIDetectionJobs(ListPHIDetectionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPHIDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPHIDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPHIDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPHIDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListPHIDetectionJobsResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListPHIDetectionJobs">REST API Reference for ListPHIDetectionJobs Operation</seealso>
        public virtual ListPHIDetectionJobsResponse EndListPHIDetectionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPHIDetectionJobsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StartEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEntitiesDetectionV2Job operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEntitiesDetectionV2Job
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartEntitiesDetectionV2Job">REST API Reference for StartEntitiesDetectionV2Job Operation</seealso>
        public virtual IAsyncResult BeginStartEntitiesDetectionV2Job(StartEntitiesDetectionV2JobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEntitiesDetectionV2JobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEntitiesDetectionV2JobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEntitiesDetectionV2Job.</param>
        /// 
        /// <returns>Returns a  StartEntitiesDetectionV2JobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartEntitiesDetectionV2Job">REST API Reference for StartEntitiesDetectionV2Job Operation</seealso>
        public virtual StartEntitiesDetectionV2JobResponse EndStartEntitiesDetectionV2Job(IAsyncResult asyncResult)
        {
            return EndInvoke<StartEntitiesDetectionV2JobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StartPHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPHIDetectionJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPHIDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartPHIDetectionJob">REST API Reference for StartPHIDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStartPHIDetectionJob(StartPHIDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPHIDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPHIDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartPHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPHIDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartPHIDetectionJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartPHIDetectionJob">REST API Reference for StartPHIDetectionJob Operation</seealso>
        public virtual StartPHIDetectionJobResponse EndStartPHIDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartPHIDetectionJobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StopEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEntitiesDetectionV2Job operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEntitiesDetectionV2Job
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopEntitiesDetectionV2Job">REST API Reference for StopEntitiesDetectionV2Job Operation</seealso>
        public virtual IAsyncResult BeginStopEntitiesDetectionV2Job(StopEntitiesDetectionV2JobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEntitiesDetectionV2JobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEntitiesDetectionV2JobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEntitiesDetectionV2Job.</param>
        /// 
        /// <returns>Returns a  StopEntitiesDetectionV2JobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopEntitiesDetectionV2Job">REST API Reference for StopEntitiesDetectionV2Job Operation</seealso>
        public virtual StopEntitiesDetectionV2JobResponse EndStopEntitiesDetectionV2Job(IAsyncResult asyncResult)
        {
            return EndInvoke<StopEntitiesDetectionV2JobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StopPHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopPHIDetectionJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopPHIDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopPHIDetectionJob">REST API Reference for StopPHIDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStopPHIDetectionJob(StopPHIDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPHIDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPHIDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopPHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopPHIDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopPHIDetectionJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopPHIDetectionJob">REST API Reference for StopPHIDetectionJob Operation</seealso>
        public virtual StopPHIDetectionJobResponse EndStopPHIDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopPHIDetectionJobResponse>(asyncResult);
        }

        #endregion
        
    }
}