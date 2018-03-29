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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.ElasticTranscoder.Model;
using Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticTranscoder
{
    /// <summary>
    /// Implementation for accessing ElasticTranscoder
    ///
    /// AWS Elastic Transcoder Service 
    /// <para>
    /// The AWS Elastic Transcoder Service.
    /// </para>
    /// </summary>
    public partial class AmazonElasticTranscoderClient : AmazonServiceClient, IAmazonElasticTranscoder
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with the credentials loaded from the application's
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
        public AmazonElasticTranscoderClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticTranscoderConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with the credentials loaded from the application's
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
        public AmazonElasticTranscoderClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticTranscoderConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(AmazonElasticTranscoderConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticTranscoderClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticTranscoderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticTranscoderClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticTranscoderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Credentials and an
        /// AmazonElasticTranscoderClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(AWSCredentials credentials, AmazonElasticTranscoderConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticTranscoderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticTranscoderConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticTranscoderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticTranscoderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticTranscoderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticTranscoderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticTranscoderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticTranscoderConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.ElasticTranscoder.Internal.AmazonElasticTranscoderPreMarshallHandler());
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

        
        #region  CancelJob

        /// <summary>
        /// The CancelJob operation cancels an unfinished job.
        /// 
        ///  <note> 
        /// <para>
        /// You can only cancel a job that has a status of <code>Submitted</code>. To prevent
        /// a pipeline from starting to process a job while you're getting the job identifier,
        /// use <a>UpdatePipelineStatus</a> to temporarily pause the pipeline.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var marshaller = CancelJobRequestMarshaller.Instance;
            var unmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobRequest,CancelJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        public virtual IAsyncResult BeginCancelJob(CancelJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CancelJobRequestMarshaller.Instance;
            var unmarshaller = CancelJobResponseUnmarshaller.Instance;

            return BeginInvoke<CancelJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a  CancelJobResult from ElasticTranscoder.</returns>
        public virtual CancelJobResponse EndCancelJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateJob

        /// <summary>
        /// When you create a job, Elastic Transcoder returns JSON data that includes the values
        /// that you specified plus information about the job that is created.
        /// 
        ///  
        /// <para>
        /// If you have specified more than one output for your jobs (for example, one output
        /// for the Kindle Fire and another output for the Apple iPhone 4s), you currently must
        /// use the Elastic Transcoder API to list the jobs (as opposed to the AWS Console).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var marshaller = CreateJobRequestMarshaller.Instance;
            var unmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobRequest,CreateJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        public virtual IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateJobRequestMarshaller.Instance;
            var unmarshaller = CreateJobResponseUnmarshaller.Instance;

            return BeginInvoke<CreateJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from ElasticTranscoder.</returns>
        public virtual CreateJobResponse EndCreateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePipeline

        /// <summary>
        /// The CreatePipeline operation creates a pipeline with settings that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var marshaller = CreatePipelineRequestMarshaller.Instance;
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineRequest,CreatePipelineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        public virtual IAsyncResult BeginCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreatePipelineRequestMarshaller.Instance;
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePipelineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a  CreatePipelineResult from ElasticTranscoder.</returns>
        public virtual CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePreset

        /// <summary>
        /// The CreatePreset operation creates a preset with settings that you specify.
        /// 
        ///  <important> 
        /// <para>
        /// Elastic Transcoder checks the CreatePreset settings to ensure that they meet Elastic
        /// Transcoder requirements and to determine whether they comply with H.264 standards.
        /// If your settings are not valid for Elastic Transcoder, Elastic Transcoder returns
        /// an HTTP 400 response (<code>ValidationException</code>) and does not create the preset.
        /// If the settings are valid for Elastic Transcoder but aren't strictly compliant with
        /// the H.264 standard, Elastic Transcoder creates the preset and returns a warning message
        /// in the response. This helps you determine whether your settings comply with the H.264
        /// standard while giving you greater flexibility with respect to the video that Elastic
        /// Transcoder produces.
        /// </para>
        ///  </important> 
        /// <para>
        /// Elastic Transcoder uses the H.264 video-compression format. For more information,
        /// see the International Telecommunication Union publication <i>Recommendation ITU-T
        /// H.264: Advanced video coding for generic audiovisual services</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset service method.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual CreatePresetResponse CreatePreset(CreatePresetRequest request)
        {
            var marshaller = CreatePresetRequestMarshaller.Instance;
            var unmarshaller = CreatePresetResponseUnmarshaller.Instance;

            return Invoke<CreatePresetRequest,CreatePresetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePreset
        ///         operation.</returns>
        public virtual IAsyncResult BeginCreatePreset(CreatePresetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreatePresetRequestMarshaller.Instance;
            var unmarshaller = CreatePresetResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePresetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePreset.</param>
        /// 
        /// <returns>Returns a  CreatePresetResult from ElasticTranscoder.</returns>
        public virtual CreatePresetResponse EndCreatePreset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePresetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePipeline

        /// <summary>
        /// The DeletePipeline operation removes a pipeline.
        /// 
        ///  
        /// <para>
        ///  You can only delete a pipeline that has never been used or that is not currently
        /// in use (doesn't contain any active jobs). If the pipeline is currently in use, <code>DeletePipeline</code>
        /// returns an error. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var marshaller = DeletePipelineRequestMarshaller.Instance;
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineRequest,DeletePipelineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeletePipelineRequestMarshaller.Instance;
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePipelineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a  DeletePipelineResult from ElasticTranscoder.</returns>
        public virtual DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePreset

        /// <summary>
        /// The DeletePreset operation removes a preset that you've added in an AWS region.
        /// 
        ///  <note> 
        /// <para>
        /// You can't delete the default presets that are included with Elastic Transcoder.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset service method.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual DeletePresetResponse DeletePreset(DeletePresetRequest request)
        {
            var marshaller = DeletePresetRequestMarshaller.Instance;
            var unmarshaller = DeletePresetResponseUnmarshaller.Instance;

            return Invoke<DeletePresetRequest,DeletePresetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePreset
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeletePreset(DeletePresetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeletePresetRequestMarshaller.Instance;
            var unmarshaller = DeletePresetResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePresetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePreset.</param>
        /// 
        /// <returns>Returns a  DeletePresetResult from ElasticTranscoder.</returns>
        public virtual DeletePresetResponse EndDeletePreset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePresetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobsByPipeline

        /// <summary>
        /// The ListJobsByPipeline operation gets a list of the jobs currently in a pipeline.
        /// 
        ///  
        /// <para>
        /// Elastic Transcoder returns all of the jobs currently in the specified pipeline. The
        /// response body contains one element for each job that satisfies the search criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline service method.</param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual ListJobsByPipelineResponse ListJobsByPipeline(ListJobsByPipelineRequest request)
        {
            var marshaller = ListJobsByPipelineRequestMarshaller.Instance;
            var unmarshaller = ListJobsByPipelineResponseUnmarshaller.Instance;

            return Invoke<ListJobsByPipelineRequest,ListJobsByPipelineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobsByPipeline
        ///         operation.</returns>
        public virtual IAsyncResult BeginListJobsByPipeline(ListJobsByPipelineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListJobsByPipelineRequestMarshaller.Instance;
            var unmarshaller = ListJobsByPipelineResponseUnmarshaller.Instance;

            return BeginInvoke<ListJobsByPipelineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobsByPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByPipeline.</param>
        /// 
        /// <returns>Returns a  ListJobsByPipelineResult from ElasticTranscoder.</returns>
        public virtual ListJobsByPipelineResponse EndListJobsByPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsByPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobsByStatus

        /// <summary>
        /// The ListJobsByStatus operation gets a list of jobs that have a specified status. The
        /// response body contains one element for each job that satisfies the search criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus service method.</param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual ListJobsByStatusResponse ListJobsByStatus(ListJobsByStatusRequest request)
        {
            var marshaller = ListJobsByStatusRequestMarshaller.Instance;
            var unmarshaller = ListJobsByStatusResponseUnmarshaller.Instance;

            return Invoke<ListJobsByStatusRequest,ListJobsByStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobsByStatus
        ///         operation.</returns>
        public virtual IAsyncResult BeginListJobsByStatus(ListJobsByStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListJobsByStatusRequestMarshaller.Instance;
            var unmarshaller = ListJobsByStatusResponseUnmarshaller.Instance;

            return BeginInvoke<ListJobsByStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobsByStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByStatus.</param>
        /// 
        /// <returns>Returns a  ListJobsByStatusResult from ElasticTranscoder.</returns>
        public virtual ListJobsByStatusResponse EndListJobsByStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsByStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPipelines

        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual ListPipelinesResponse ListPipelines()
        {
            return ListPipelines(new ListPipelinesRequest());
        }

        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var marshaller = ListPipelinesRequestMarshaller.Instance;
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesRequest,ListPipelinesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        public virtual IAsyncResult BeginListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListPipelinesRequestMarshaller.Instance;
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return BeginInvoke<ListPipelinesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a  ListPipelinesResult from ElasticTranscoder.</returns>
        public virtual ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPipelinesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPresets

        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the presets that you've added in an AWS region.
        /// </summary>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual ListPresetsResponse ListPresets()
        {
            return ListPresets(new ListPresetsRequest());
        }

        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the presets that you've added in an AWS region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPresets service method.</param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual ListPresetsResponse ListPresets(ListPresetsRequest request)
        {
            var marshaller = ListPresetsRequestMarshaller.Instance;
            var unmarshaller = ListPresetsResponseUnmarshaller.Instance;

            return Invoke<ListPresetsRequest,ListPresetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPresets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPresets operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPresets
        ///         operation.</returns>
        public virtual IAsyncResult BeginListPresets(ListPresetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListPresetsRequestMarshaller.Instance;
            var unmarshaller = ListPresetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListPresetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPresets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPresets.</param>
        /// 
        /// <returns>Returns a  ListPresetsResult from ElasticTranscoder.</returns>
        public virtual ListPresetsResponse EndListPresets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPresetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ReadJob

        /// <summary>
        /// The ReadJob operation returns detailed information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadJob service method.</param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual ReadJobResponse ReadJob(ReadJobRequest request)
        {
            var marshaller = ReadJobRequestMarshaller.Instance;
            var unmarshaller = ReadJobResponseUnmarshaller.Instance;

            return Invoke<ReadJobRequest,ReadJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReadJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadJob operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadJob
        ///         operation.</returns>
        public virtual IAsyncResult BeginReadJob(ReadJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ReadJobRequestMarshaller.Instance;
            var unmarshaller = ReadJobResponseUnmarshaller.Instance;

            return BeginInvoke<ReadJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReadJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadJob.</param>
        /// 
        /// <returns>Returns a  ReadJobResult from ElasticTranscoder.</returns>
        public virtual ReadJobResponse EndReadJob(IAsyncResult asyncResult)
        {
            return EndInvoke<ReadJobResponse>(asyncResult);
        }

        #endregion
        
        #region  ReadPipeline

        /// <summary>
        /// The ReadPipeline operation gets detailed information about a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline service method.</param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual ReadPipelineResponse ReadPipeline(ReadPipelineRequest request)
        {
            var marshaller = ReadPipelineRequestMarshaller.Instance;
            var unmarshaller = ReadPipelineResponseUnmarshaller.Instance;

            return Invoke<ReadPipelineRequest,ReadPipelineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadPipeline
        ///         operation.</returns>
        public virtual IAsyncResult BeginReadPipeline(ReadPipelineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ReadPipelineRequestMarshaller.Instance;
            var unmarshaller = ReadPipelineResponseUnmarshaller.Instance;

            return BeginInvoke<ReadPipelineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReadPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadPipeline.</param>
        /// 
        /// <returns>Returns a  ReadPipelineResult from ElasticTranscoder.</returns>
        public virtual ReadPipelineResponse EndReadPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<ReadPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  ReadPreset

        /// <summary>
        /// The ReadPreset operation gets detailed information about a preset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset service method.</param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual ReadPresetResponse ReadPreset(ReadPresetRequest request)
        {
            var marshaller = ReadPresetRequestMarshaller.Instance;
            var unmarshaller = ReadPresetResponseUnmarshaller.Instance;

            return Invoke<ReadPresetRequest,ReadPresetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadPreset
        ///         operation.</returns>
        public virtual IAsyncResult BeginReadPreset(ReadPresetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ReadPresetRequestMarshaller.Instance;
            var unmarshaller = ReadPresetResponseUnmarshaller.Instance;

            return BeginInvoke<ReadPresetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReadPreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadPreset.</param>
        /// 
        /// <returns>Returns a  ReadPresetResult from ElasticTranscoder.</returns>
        public virtual ReadPresetResponse EndReadPreset(IAsyncResult asyncResult)
        {
            return EndInvoke<ReadPresetResponse>(asyncResult);
        }

        #endregion
        
        #region  TestRole

        /// <summary>
        /// The TestRole operation tests the IAM role used to create the pipeline.
        /// 
        ///  
        /// <para>
        /// The <code>TestRole</code> action lets you determine whether the IAM role you are using
        /// has sufficient permissions to let Elastic Transcoder perform tasks associated with
        /// the transcoding process. The action attempts to assume the specified IAM role, checks
        /// read access to the input and output buckets, and tries to send a test notification
        /// to Amazon SNS topics that you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRole service method.</param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        [Obsolete("This API is deprecated and will be removed in a future release.")]
        public virtual TestRoleResponse TestRole(TestRoleRequest request)
        {
            var marshaller = TestRoleRequestMarshaller.Instance;
            var unmarshaller = TestRoleResponseUnmarshaller.Instance;

            return Invoke<TestRoleRequest,TestRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRole operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestRole
        ///         operation.</returns>
        [Obsolete("This API is deprecated and will be removed in a future release.")]
        public virtual IAsyncResult BeginTestRole(TestRoleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TestRoleRequestMarshaller.Instance;
            var unmarshaller = TestRoleResponseUnmarshaller.Instance;

            return BeginInvoke<TestRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestRole.</param>
        /// 
        /// <returns>Returns a  TestRoleResult from ElasticTranscoder.</returns>
        [Obsolete("This API is deprecated and will be removed in a future release.")]
        public virtual TestRoleResponse EndTestRole(IAsyncResult asyncResult)
        {
            return EndInvoke<TestRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePipeline

        /// <summary>
        /// Use the <code>UpdatePipeline</code> operation to update settings for a pipeline.
        /// 
        ///  <important> 
        /// <para>
        /// When you change pipeline settings, your changes take effect immediately. Jobs that
        /// you have already submitted and that Elastic Transcoder has not started to process
        /// are affected in addition to jobs that you submit after you change settings. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var marshaller = UpdatePipelineRequestMarshaller.Instance;
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineRequest,UpdatePipelineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipeline
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdatePipeline(UpdatePipelineRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdatePipelineRequestMarshaller.Instance;
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return BeginInvoke<UpdatePipelineRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipeline.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineResult from ElasticTranscoder.</returns>
        public virtual UpdatePipelineResponse EndUpdatePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePipelineNotifications

        /// <summary>
        /// With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification
        /// Service (Amazon SNS) notifications for a pipeline.
        /// 
        ///  
        /// <para>
        /// When you update notifications for a pipeline, Elastic Transcoder returns the values
        /// that you specified in the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual UpdatePipelineNotificationsResponse UpdatePipelineNotifications(UpdatePipelineNotificationsRequest request)
        {
            var marshaller = UpdatePipelineNotificationsRequestMarshaller.Instance;
            var unmarshaller = UpdatePipelineNotificationsResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineNotificationsRequest,UpdatePipelineNotificationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipelineNotifications
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdatePipelineNotifications(UpdatePipelineNotificationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdatePipelineNotificationsRequestMarshaller.Instance;
            var unmarshaller = UpdatePipelineNotificationsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdatePipelineNotificationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipelineNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineNotifications.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineNotificationsResult from ElasticTranscoder.</returns>
        public virtual UpdatePipelineNotificationsResponse EndUpdatePipelineNotifications(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePipelineNotificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePipelineStatus

        /// <summary>
        /// The UpdatePipelineStatus operation pauses or reactivates a pipeline, so that the pipeline
        /// stops or restarts the processing of jobs.
        /// 
        ///  
        /// <para>
        /// Changing the pipeline status is useful if you want to cancel one or more jobs. You
        /// can't cancel jobs after Elastic Transcoder has started processing them; if you pause
        /// the pipeline to which you submitted the jobs, you have more time to get the job IDs
        /// for the jobs that you want to cancel, and to send a <a>CancelJob</a> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public virtual UpdatePipelineStatusResponse UpdatePipelineStatus(UpdatePipelineStatusRequest request)
        {
            var marshaller = UpdatePipelineStatusRequestMarshaller.Instance;
            var unmarshaller = UpdatePipelineStatusResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineStatusRequest,UpdatePipelineStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipelineStatus
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdatePipelineStatus(UpdatePipelineStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdatePipelineStatusRequestMarshaller.Instance;
            var unmarshaller = UpdatePipelineStatusResponseUnmarshaller.Instance;

            return BeginInvoke<UpdatePipelineStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipelineStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineStatus.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineStatusResult from ElasticTranscoder.</returns>
        public virtual UpdatePipelineStatusResponse EndUpdatePipelineStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePipelineStatusResponse>(asyncResult);
        }

        #endregion
        
    }
}